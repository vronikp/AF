USE [AFDepNueva]
GO
/****** Object:  StoredProcedure [dbo].[proc_Depreciacion]    Script Date: 03/22/2018 14:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[proc_Depreciacion]
(	@accion	char(2), 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null, 
	@Parame_TipoDepreciacion	int=null, 
	@Pardet_TipoDepreciacion	int=null, 
	@Deprec_Codigo	nvarchar(50)=null, 
	@Deprec_Observacion	nvarchar(350)=null,
	@Deprec_esProyeccion	bit=null)
as
begin
	declare @Activo_Codigo int
	declare @ActCom_Secuencia int
	declare @ActCom_FechaAdquisicion date
	declare @ActCom_ValorErogacion money

	if @accion='i'
	begin
		--mostrar mensaje de error si no se han corrido dep anteriores
		
		declare @FrecuenciaDepreciacion nvarchar(10)= (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
		
		declare @ActualDep as int
		select @ActualDep=isnull(max(Deprec_Codigo),0) from Depreciacion
		
		declare @ProximaDep as date
		declare @ProximaDepInt as int
		
		if @ActualDep>999999
		begin
			set @ProximaDep = DATEADD(d,1,cast(cast(@ActualDep as nvarchar) as DATE))
			set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
		end
		else
		begin
			if @ActualDep<>0
			begin
				set @ProximaDep = DATEADD(m,1,cast(cast(@ActualDep as nvarchar)+'01' as DATE))
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
			end
		end
		
		if @ActualDep = 0
		begin
			select @ProximaDepInt=isnull(min(Deprec_Codigo),0) from DepreciacionDet
			if @ProximaDepInt<>0
				set @ActualDep =1
		end
		
		
		
		if @ActualDep <> 0 and  @ProximaDepInt <> CAST(replace(@Deprec_Codigo,'/','') as int)
		begin
			declare @error as varchar(300) 
			set @error = 'Debe correr primero la depreciacion ' + cast(@ProximaDepInt as nvarchar)
			raiserror(@error, 16,1)
		    return -1
		end
		
		
		insert into Depreciacion 
			(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, Deprec_Observacion, Deprec_esProyeccion)
		values (@Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo, 10080, 1, @Deprec_Observacion, @Deprec_esProyeccion)

		insert into Depreciacion 
			(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, Deprec_Observacion, Deprec_esProyeccion)
		values (@Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo, 10080, 2, @Deprec_Observacion, @Deprec_esProyeccion)
		
		--Actualizar cuentas contables!
		
		/*if @Pardet_FrecuenciaDepreciacion=1 --mensual
		begin
			insert into DepreciacionDet
				(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				Deprec_Codigo, Activo_Codigo, ActVal_Secuencia, 
				Deprec_Valor, 
				Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto,
				Deprec_Ubicacion)
			SELECT Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				@Deprec_Codigo, Activo_Codigo, ActVal_Secuencia, 
				case when DepreciacionPorPeriodo > FaltaDepreciar then FaltaDepreciar
					else DepreciacionPorPeriodo end,
				isnull(CtaActivo,''), 
				isnull(dbo.CentroCostosUbicacion(Activo_Codigo,0),''), 
				isnull(CtaGasto,''),
				dbo.Fnc_UbicacionActual(Activo_Codigo)
			FROM vw_Depreciacion
			where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
			and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
			and FaltaDepreciar>0
			and (Activo_FechaBaja is null or YEAR(Activo_FechaBaja)*100+MONTH(Activo_FechaBaja)>CAST(replace(@Deprec_Codigo,'/','') as int))
			and YEAR(Activo_FechaIngreso)*100+MONTH(Activo_FechaIngreso)<CAST(replace(@Deprec_Codigo,'/','') as int)
			
			exec proc_DepreciacionResumen @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo
			EXEC proc_Depreciacion_Exportar
			 @accion = NULL,
	         @cbo_Frecuencia_Depreciacion = 1,
			 @cbo_Mostrar = 1,
			 @cba_Codigo_Depreciacion = @Deprec_Codigo,
			 @Fecha_ultimo_dia_mes = NULL,
			 @ocu_solo_calculo = 1

      
			declare adicion_cursor cursor for 
				Select activo_codigo, ActCom_Secuencia, ActCom_FechaAdquisicion, ActCom_ValorErogacion
				  from ActivoComponente
				  where ActCom_esErogacion=1 and ActCom_ValorErogacion>0
				  and YEAR(ActCom_FechaAdquisicion)*100+MONTH(ActCom_FechaAdquisicion)=CAST(replace(@Deprec_Codigo,'/','') as int)

			open adicion_cursor
			fetch next from adicion_cursor into @Activo_Codigo, @ActCom_Secuencia, @ActCom_FechaAdquisicion, @ActCom_ValorErogacion

			while @@FETCH_STATUS = 0
			begin
				update ActivoValor set ActVal_FlagNuevo=0
					where Activo_Codigo=@Activo_Codigo

				insert into ActivoValor (Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				  ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, 
				  ActVal_Costo, ActVal_Salvamento, 
				  ActVal_PeriodosDepreciables, ActVal_FechaValoracion, 
				  Entida_Perito, ActVal_Activo, ActCom_Secuencia, 
				  Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				  ActVal_FlagNuevo, Actval_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt)
				SELECT     ActivoValor.Activo_Codigo, ActivoValor.Parame_TipoDepreciacion, ActivoValor.Pardet_TipoDepreciacion, 
				  (select isnull(max(av2.ActVal_Secuencia),0)+1 
					  from ActivoValor av2 
					  where av2.Activo_Codigo=@Activo_Codigo
					  and av2.Parame_TipoDepreciacion=ActivoValor.Parame_TipoDepreciacion
					  and av2.Pardet_TipoDepreciacion=ActivoValor.Pardet_TipoDepreciacion), 10085, 3, --erogacion
				  ActivoValor.ActVal_Costo + @ActCom_ValorErogacion, ActivoValor.ActVal_Salvamento, 
				  ActivoValor.ActVal_PeriodosDepreciables, @ActCom_FechaAdquisicion,
				  null, 1, @ActCom_Secuencia,
				  ActivoValor.Parame_FrecuenciaDepreciacion, ActivoValor.Pardet_FrecuenciaDepreciacion, 1,
				  @ActCom_ValorErogacion, vw_ActivoValorDepreciado.ValorDepreciado, vw_ActivoValorDepreciado.NumDepreciaciones
				FROM         ActivoValor INNER JOIN
				  vw_ActivoValorDepreciado ON ActivoValor.Activo_Codigo = vw_ActivoValorDepreciado.Activo_Codigo AND 
				  ActivoValor.Parame_TipoDepreciacion = vw_ActivoValorDepreciado.Parame_TipoDepreciacion AND 
				  ActivoValor.Pardet_TipoDepreciacion = vw_ActivoValorDepreciado.Pardet_TipoDepreciacion AND 
				  ActivoValor.ActVal_Secuencia = vw_ActivoValorDepreciado.ActVal_Secuencia INNER JOIN
				  Activo ON ActivoValor.Activo_Codigo = Activo.Activo_Codigo
				WHERE     (ActivoValor.ActVal_Activo = 1) AND (Activo.Activo_FechaBaja IS NULL)
				and ActivoValor.Activo_Codigo=@Activo_Codigo

				update ActivoValor set ActVal_Activo=ActVal_FlagNuevo
				  where Activo_Codigo=@Activo_Codigo
				  
				fetch next from adicion_cursor into @activo_codigo, @ActCom_Secuencia, @ActCom_FechaAdquisicion, @ActCom_ValorErogacion
			end
	      
			close adicion_cursor
			deallocate adicion_cursor
		end
		
		if @Pardet_FrecuenciaDepreciacion=2 --diaria
		begin
			insert into DepreciacionDet
				(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				Deprec_Codigo, Activo_Codigo, ActVal_Secuencia, 
				Deprec_Valor, 
				Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto,
				Deprec_Ubicacion)
			SELECT Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				@Deprec_Codigo, Activo_Codigo, ActVal_Secuencia, 
				case when DepreciacionPorPeriodo > FaltaDepreciar then FaltaDepreciar
					else DepreciacionPorPeriodo end,
				isnull(CtaActivo,''), 
				isnull(dbo.CentroCostosUbicacion(Activo_Codigo,0),''), 
				isnull(CtaGasto,''),
				dbo.Fnc_UbicacionActual(Activo_Codigo)
			FROM vw_Depreciacion
			where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
			and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
			and FaltaDepreciar>0
			and (Activo_FechaBaja is null or YEAR(Activo_FechaBaja)*10000+MONTH(Activo_FechaBaja)*100+DAY(Activo_FechaBaja)>CAST(replace(@Deprec_Codigo,'/','') as int))
			and YEAR(Activo_FechaIngreso)*10000+MONTH(Activo_FechaIngreso)*100+DAY(Activo_FechaIngreso)<CAST(replace(@Deprec_Codigo,'/','') as int)
			
			exec proc_DepreciacionResumen @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo
			EXEC proc_Depreciacion_Exportar
			 @accion = NULL,
	         @cbo_Frecuencia_Depreciacion = 1,
			 @cbo_Mostrar = 1,
			 @cba_Codigo_Depreciacion = @Deprec_Codigo,
			 @Fecha_ultimo_dia_mes = NULL,
			 @ocu_solo_calculo = 1

      
			declare adicion_cursor cursor for 
				Select activo_codigo, ActCom_Secuencia, ActCom_FechaAdquisicion, ActCom_ValorErogacion
				  from ActivoComponente
				  where ActCom_esErogacion=1 and ActCom_ValorErogacion>0
				  and YEAR(ActCom_FechaAdquisicion)*100+MONTH(ActCom_FechaAdquisicion)+DAY(ActCom_FechaAdquisicion)=CAST(replace(@Deprec_Codigo,'/','') as int)

			open adicion_cursor
			fetch next from adicion_cursor into @Activo_Codigo, @ActCom_Secuencia, @ActCom_FechaAdquisicion, @ActCom_ValorErogacion

			while @@FETCH_STATUS = 0
			begin
				update ActivoValor set ActVal_FlagNuevo=0
					where Activo_Codigo=@Activo_Codigo

				insert into ActivoValor (Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				  ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, 
				  ActVal_Costo, ActVal_Salvamento, 
				  ActVal_PeriodosDepreciables, ActVal_FechaValoracion, 
				  Entida_Perito, ActVal_Activo, ActCom_Secuencia, 
				  Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
				  ActVal_FlagNuevo, Actval_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt)
				SELECT     ActivoValor.Activo_Codigo, ActivoValor.Parame_TipoDepreciacion, ActivoValor.Pardet_TipoDepreciacion, 
				  (select isnull(max(av2.ActVal_Secuencia),0)+1 
					  from ActivoValor av2 
					  where av2.Activo_Codigo=@Activo_Codigo
					  and av2.Parame_TipoDepreciacion=ActivoValor.Parame_TipoDepreciacion
					  and av2.Pardet_TipoDepreciacion=ActivoValor.Pardet_TipoDepreciacion), 10085, 3, --erogacion
				  ActivoValor.ActVal_Costo + @ActCom_ValorErogacion, ActivoValor.ActVal_Salvamento, 
				  ActivoValor.ActVal_PeriodosDepreciables, @ActCom_FechaAdquisicion,
				  null, 1, @ActCom_Secuencia,
				  ActivoValor.Parame_FrecuenciaDepreciacion, ActivoValor.Pardet_FrecuenciaDepreciacion, 1,
				  @ActCom_ValorErogacion, vw_ActivoValorDepreciado.ValorDepreciado, vw_ActivoValorDepreciado.NumDepreciaciones
				FROM         ActivoValor INNER JOIN
				  vw_ActivoValorDepreciado ON ActivoValor.Activo_Codigo = vw_ActivoValorDepreciado.Activo_Codigo AND 
				  ActivoValor.Parame_TipoDepreciacion = vw_ActivoValorDepreciado.Parame_TipoDepreciacion AND 
				  ActivoValor.Pardet_TipoDepreciacion = vw_ActivoValorDepreciado.Pardet_TipoDepreciacion AND 
				  ActivoValor.ActVal_Secuencia = vw_ActivoValorDepreciado.ActVal_Secuencia INNER JOIN
				  Activo ON ActivoValor.Activo_Codigo = Activo.Activo_Codigo
				WHERE     (ActivoValor.ActVal_Activo = 1) AND (Activo.Activo_FechaBaja IS NULL)
				and ActivoValor.Activo_Codigo=@Activo_Codigo

				update ActivoValor set ActVal_Activo=ActVal_FlagNuevo
				  where Activo_Codigo=@Activo_Codigo
				  
				fetch next from adicion_cursor into @activo_codigo, @ActCom_Secuencia, @ActCom_FechaAdquisicion, @ActCom_ValorErogacion
			end
	      
			close adicion_cursor
			deallocate adicion_cursor
		end
		*/
		return 0
	end
	if @accion='c'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, Deprec_Observacion, Deprec_esProyeccion
			from Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion
		return 0
	end
	if @accion='up' --ultimo periodo
	begin
		select max(deprec_codigo)
		from Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion 
		and Deprec_esProyeccion = 0
	end
	
	if @accion='e'
	begin
		/*delete DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo */

		delete Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		
		/*declare remadicion_cursor cursor for 
			Select distinct Activo_Codigo
			  from ActivoValor
			  where Pardet_TipoValoracion = 3
			  and YEAR(ActVal_FechaValoracion)*100+MONTH(ActVal_FechaValoracion)=CAST(replace(@Deprec_Codigo,'/','') as int)

		open remadicion_cursor
		fetch next from remadicion_cursor into @Activo_Codigo

		while @@FETCH_STATUS = 0
		begin
			delete ActivoValor
				where Activo_Codigo=@Activo_Codigo
				and Pardet_TipoValoracion = 3
				and YEAR(ActVal_FechaValoracion)*100+MONTH(ActVal_FechaValoracion)=CAST(replace(@Deprec_Codigo,'/','') as int)
			
			update ActivoValor set ActVal_Activo=0
				where Activo_Codigo=@Activo_Codigo

			update ActivoValor set ActVal_Activo=1
			  where Activo_Codigo=@Activo_Codigo
			  and Pardet_TipoDepreciacion=1
			  and ActVal_Secuencia= (Select top 1 ActVal_Secuencia from ActivoValor
										where Activo_Codigo=@Activo_Codigo
										and Pardet_TipoDepreciacion=1
										order by ActVal_FechaValoracion)
			  
			update ActivoValor set ActVal_Activo=1
			  where Activo_Codigo=@Activo_Codigo
			  and Pardet_TipoDepreciacion=2
			  and ActVal_Secuencia= (Select top 1 ActVal_Secuencia from ActivoValor
										where Activo_Codigo=@Activo_Codigo
										and Pardet_TipoDepreciacion=2
										order by ActVal_FechaValoracion)
			  
			fetch next from remadicion_cursor into @Activo_Codigo
		end
      
		close remadicion_cursor
		deallocate remadicion_cursor*/
		return 0
	end

	if @accion='f'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			Deprec_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
			Deprec_Observacion, Deprec_esProyeccion
			from Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion
		order by Deprec_Codigo desc
		return 0
	end
end

update ParametroDet set Pardet_DatoStr1 = 'A9MP0P', Pardet_DatoStr2 = 'R0MG3R',
Pardet_DatoStr3 = 'A6MG3O', Pardet_DatoInt1 = 151102, Pardet_DatoBit1 = 1 
WHERE Parame_Codigo = 10001

update ParametroDet set CtaCtb_CtaCtble1 = '18', CtaCtb_CtaCtble2 = '03', Pardet_DatoStr3 = '31' where Parame_Codigo=1

update ParametroDet set Pardet_Descripcion = 'TERMINAL DE CARGA DEL ECUADOR' where Parame_Codigo=10001
