USE [AFDepNueva]
GO
/****** Object:  StoredProcedure [dbo].[proc_ActivoComponente]    Script Date: 03/19/2018 16:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[proc_ActivoComponente]
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@ActCom_Secuencia	int=null, 
	@ActCom_Activo	bit=null, 
	@ActCom_Descripcion	nvarchar(150)=null, 
	@Parame_Marca	int=null, 
	@Pardet_Marca	int=null, 
	@ActCom_Modelo	nvarchar(50)=null, 
	@ActCom_Serie	nvarchar(50)=null, 
	@ActCom_esErogacion	bit=null, 
	@ActCom_ValorErogacion	money=null, 
	@ActCom_FechaAdquisicion	date=null, 
	@ActCom_FechaIngreso	date=null, 
	@Entida_Proveedor	int=null, 
	@ActCom_Factura	nvarchar(50)=null, 
	@ActCom_FechaBaja	date=null,
	
	@filtro	nvarchar(350)=null)
as
begin
	declare @esDeprecible bit=0
	declare @Pardet_FrecuenciaDepreciacion int 
	declare @ProximaDep date
	declare @ProximaDepInt int
	declare @ActualDep int
	
	if (select Pardet_EstadoDepreciacion from Activo where Activo_Codigo = @Activo_Codigo)=1
		set @esDeprecible =1
		
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
		set @Pardet_FrecuenciaDepreciacion =2
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
		set @Pardet_FrecuenciaDepreciacion =1
			
	if @accion='i'
	begin
		if @ActCom_esErogacion=1 and @ActCom_ValorErogacion>0 and @esDeprecible =1
		begin
			--Es mensual
			if @Pardet_FrecuenciaDepreciacion = 1
			begin
				set @ActualDep = cast(left(replace(CAST (@ActCom_FechaAdquisicion as nvarchar),'-',''),6) as int)
				set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, @ActCom_FechaAdquisicion), 0) )
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ActualDep = cast(replace(CAST (@ActCom_FechaAdquisicion as nvarchar),'-','') as int)
				set @ProximaDep = DATEADD(d,1,@ActCom_FechaAdquisicion)
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
			end
			
			
			--Error si la depreciacion proxima ya esta generada
			if exists (Select * from Depreciacion
			            where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
			            and Deprec_Codigo= @ProximaDepInt)
			begin
				raiserror (N'No puede generar una adición ya que está generada la depreciación %i', 16, 1, @ProximaDepInt)
				return -1
			end
			
			--Error si la depreciacion actual no esta generada
			if not exists (Select * from Depreciacion
						where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
						and Deprec_Codigo= @ActualDep)
			begin
				raiserror (N'No puede generar una adición ya que no está generada la depreciación %i', 16, 1, @ActualDep)
				return -1
			end
		end

		if @ActCom_Secuencia=0
		begin
			select @ActCom_Secuencia=isnull(max(ActCom_Secuencia),0)+1 from ActivoComponente
				where Activo_Codigo=@Activo_Codigo
		end
		
		insert into ActivoComponente 
			(Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, ActCom_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, ActCom_FechaIngreso, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja)
		values (@Activo_Codigo, @ActCom_Secuencia, @ActCom_Activo, @ActCom_Descripcion, @Parame_Marca, @Pardet_Marca, @ActCom_Modelo, @ActCom_Serie, @ActCom_esErogacion, @ActCom_ValorErogacion, @ActCom_FechaAdquisicion, @ActCom_FechaIngreso, @Entida_Proveedor, @ActCom_Factura, @ActCom_FechaBaja)
		
		
		if @ActCom_esErogacion=1 and @ActCom_ValorErogacion>0
		begin
			declare @depreciacionAcum decimal (18,8)
			declare @periodosDepreciados int
			
			update ActivoValor set ActVal_FlagNuevo=0
					where Activo_Codigo=@Activo_Codigo
					
			if @esDeprecible = 1 
			begin
				insert into ActivoValor (Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				  ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, 
				  ActVal_Costo, ActVal_Salvamento, 
				  ActVal_PeriodosDepreciables, ActVal_FechaValoracion, 
				  Entida_Perito, ActVal_Activo, ActCom_Secuencia, 
				  Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, ActVal_FlagNuevo, 
				  Actval_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt)
				  
				SELECT     ActivoValor.Activo_Codigo, ActivoValor.Parame_TipoDepreciacion, ActivoValor.Pardet_TipoDepreciacion, 
				  (select isnull(max(av2.ActVal_Secuencia),0)+1 
				      from ActivoValor av2 
					  where av2.Activo_Codigo=@Activo_Codigo
					  and av2.Parame_TipoDepreciacion=ActivoValor.Parame_TipoDepreciacion
					  and av2.Pardet_TipoDepreciacion=ActivoValor.Pardet_TipoDepreciacion), 10085, 3, --erogacion
				  ActivoValor.ActVal_Costo + @ActCom_ValorErogacion, 
				  --ActivoValor.ActVal_Salvamento, --se mantiene valor de salvamento anterior
				  ActivoValor.ActVal_Salvamento + @ActCom_ValorErogacion*0.1, --se aumenta el 10% del valor del salvamento
				  ActivoValor.ActVal_PeriodosDepreciables, @ActCom_FechaAdquisicion,
				  null, 1, @ActCom_Secuencia,
				  ActivoValor.Parame_FrecuenciaDepreciacion, ActivoValor.Pardet_FrecuenciaDepreciacion, 1,
				  @ActCom_ValorErogacion, 
				  dd.Deprec_DepreciacionAcumulada, dd.Deprec_PeriodosDepreciados
				FROM         ActivoValor INNER JOIN
				  DepreciacionDet dd ON ActivoValor.Activo_Codigo = dd.Activo_Codigo AND 
				  ActivoValor.Parame_TipoDepreciacion = dd.Parame_TipoDepreciacion AND 
				  ActivoValor.Pardet_TipoDepreciacion = dd.Pardet_TipoDepreciacion 
				  --AND ActivoValor.ActVal_Secuencia = dd.ActVal_Secuencia 
				  INNER JOIN
				  Activo ON ActivoValor.Activo_Codigo = Activo.Activo_Codigo
				WHERE     (ActivoValor.ActVal_Activo = 1) AND (Activo.Activo_FechaBaja IS NULL)
				and ActivoValor.Activo_Codigo=@Activo_Codigo and dd.Deprec_Codigo=@ActualDep
				
				update ActivoValor set ActVal_Activo=ActVal_FlagNuevo
					where Activo_Codigo=@Activo_Codigo
			  
				--Recalcular !
				--depreciaciones !
				declare @decimales int
				set  @decimales = (select Pardet_DatoInt1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
				declare @FrecuenciaDepreciacion nvarchar(10)= (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
				
				--CuentaActivo y cuenta gasto
				declare @ctaActivo nvarchar (50) =null
				declare @ctaGasto nvarchar (50)=null
				select @ctaActivo = pdTipo.Pardet_DatoStr1, @ctaGasto = pdTipo.Pardet_DatoStr2 
				from Activo act inner join ParametroDet as pdClase on  act.Parame_ClaseActivo = pdClase.Parame_Codigo
					and act.Pardet_ClaseActivo =pdClase.Pardet_Secuencia 
					inner join ParametroDet pdTipo on pdClase.Parame_Padre = pdTipo.Parame_Codigo and
					pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia
				where Activo_Codigo=@Activo_Codigo
			
				--CentroDeCosto (definir CC o nivel de ubicacion)
				declare @centroCosto nvarchar (50)=null
				select @centroCosto = pdCentroCosto.Pardet_DatoStr1
				from Activo act inner join ParametroDet as pdCentroCosto on  act.Parame_CentroCosto = pdCentroCosto.Parame_Codigo
					and act.Pardet_CentroCosto =pdCentroCosto.Pardet_Secuencia 
				where Activo_Codigo=@Activo_Codigo
			
				--Ubicacion
				declare @ubicacion nvarchar (250)=dbo.Fnc_UbicacionActual (@Activo_Codigo)
				if @ubicacion is null
					set @ubicacion ='error de ubicacion'
					
				--Eliminar depreciaciones
				delete from DepreciacionDet where Deprec_Codigo >=@ProximaDepInt  and Activo_Codigo=@Activo_Codigo
				
				--Tributaria:
				declare @ActVal_Secuencia int = (select ActVal_Secuencia from ActivoValor 
												where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)
				declare @periodosDepreciables int =(select ActVal_PeriodosDepreciables from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)
				declare @valorDepreciable decimal (18,8) = (select ActVal_Costo-ActVal_Salvamento from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)
				declare @valorDepreciacion decimal (18,8) =(CEILING(((select ActVal_Costo-ActVal_Salvamento-ActVal_DeprecAcumAnt from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)/ 
															(select ActVal_PeriodosDepreciables-ActVal_NumDeprecAcumAnt from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)) * @decimales) / @decimales)
				declare @valorDeprecAcum decimal (18,8)= @valorDepreciacion+(select ActVal_DeprecAcumAnt from ActivoValor 
																		where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)				
				declare @numDeprec int =1+(select ActVal_NumDeprecAcumAnt from ActivoValor 
											where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)
				
			
				while (@valorDeprecAcum<@valorDepreciable and @numDeprec<@periodosDepreciables)
				begin
					exec proc_DepreciacionDet 'i', 10055, @Pardet_FrecuenciaDepreciacion, 10080, 1, 
						@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, 
						@ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum
				
					--Es mensual
					if @Pardet_FrecuenciaDepreciacion = 1
					begin
						set @ProximaDep = DATEADD(m,1,@ProximaDep)
						set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
					end
					--Es diaria
					if @Pardet_FrecuenciaDepreciacion = 2
					begin
						set @ProximaDep = DATEADD(d,1,@ProximaDep)
						set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
					end
				
					set @valorDeprecAcum=@valorDeprecAcum+@valorDepreciacion
					set @numDeprec =@numDeprec+1
				
				end
			
				set @valorDeprecAcum=@valorDeprecAcum-@valorDepreciacion
			
				if (@valorDeprecAcum<@valorDepreciable)
				begin
					set @valorDepreciacion =@valorDepreciable - @valorDeprecAcum
					set @valorDeprecAcum=@valorDepreciable
					exec proc_DepreciacionDet 'i', 10055, @Pardet_FrecuenciaDepreciacion, 10080, 1, 
						@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, 
						@ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum				
				end
				
				--Financiera
				--Es mensual
				if @Pardet_FrecuenciaDepreciacion = 1
				begin
					set @ActualDep = cast(left(replace(CAST (@ActCom_FechaAdquisicion as nvarchar),'-',''),6) as int)
					set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, @ActCom_FechaAdquisicion), 0) )
					set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
				end
			
				--Es diaria
				if @Pardet_FrecuenciaDepreciacion = 2
				begin
					set @ActualDep = cast(replace(CAST (@ActCom_FechaAdquisicion as nvarchar),'-','') as int)
					set @ProximaDep = DATEADD(d,1,@ActCom_FechaAdquisicion)
					set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
				end
				
				set @ActVal_Secuencia = (select ActVal_Secuencia from ActivoValor 
												where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)
				set @periodosDepreciables =(select ActVal_PeriodosDepreciables from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)
				set @valorDepreciable = (select ActVal_Costo-ActVal_Salvamento from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)
				set @valorDepreciacion =(CEILING(((select ActVal_Costo-ActVal_Salvamento-ActVal_DeprecAcumAnt from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)/ 
															(select ActVal_PeriodosDepreciables-ActVal_NumDeprecAcumAnt from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)) * @decimales) / @decimales)
				set @valorDeprecAcum = @valorDepreciacion+(select ActVal_DeprecAcumAnt from ActivoValor 
															where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)				
				set @numDeprec=1+(select ActVal_NumDeprecAcumAnt from ActivoValor 
											where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)
				
			
				while (@valorDeprecAcum<@valorDepreciable and @numDeprec<@periodosDepreciables)
				begin
					exec proc_DepreciacionDet 'i', 10055, @Pardet_FrecuenciaDepreciacion, 10080, 2, 
						@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, 
						@ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum
				
					--Es mensual
					if @Pardet_FrecuenciaDepreciacion = 1
					begin
						set @ProximaDep = DATEADD(m,1,@ProximaDep)
						set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
					end
					--Es diaria
					if @Pardet_FrecuenciaDepreciacion = 2
					begin
						set @ProximaDep = DATEADD(d,1,@ProximaDep)
						set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
					end
				
					set @valorDeprecAcum=@valorDeprecAcum+@valorDepreciacion
					set @numDeprec =@numDeprec+1
				
				end
			
				set @valorDeprecAcum=@valorDeprecAcum-@valorDepreciacion
			
				if (@valorDeprecAcum<@valorDepreciable)
				begin
					set @valorDepreciacion =@valorDepreciable - @valorDeprecAcum
					set @valorDeprecAcum=@valorDepreciable
					exec proc_DepreciacionDet 'i', 10055, @Pardet_FrecuenciaDepreciacion, 10080, 2, 
						@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, 
						@ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum				
				end
			end
			else
			begin
				insert into ActivoValor (Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
				  ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, 
				  ActVal_Costo, ActVal_Salvamento, 
				  ActVal_PeriodosDepreciables, ActVal_FechaValoracion, 
				  Entida_Perito, ActVal_Activo, ActCom_Secuencia, 
				  Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, ActVal_FlagNuevo, 
				  Actval_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt)
				  
				SELECT     ActivoValor.Activo_Codigo, ActivoValor.Parame_TipoDepreciacion, ActivoValor.Pardet_TipoDepreciacion, 
				  (select isnull(max(av2.ActVal_Secuencia),0)+1 
				      from ActivoValor av2 
					  where av2.Activo_Codigo=@Activo_Codigo
					  and av2.Parame_TipoDepreciacion=ActivoValor.Parame_TipoDepreciacion
					  and av2.Pardet_TipoDepreciacion=ActivoValor.Pardet_TipoDepreciacion), 10085, 3, --erogacion
				  ActivoValor.ActVal_Costo + @ActCom_ValorErogacion, ActivoValor.ActVal_Salvamento, 
				  0, @ActCom_FechaAdquisicion,
				  null, 1, @ActCom_Secuencia,
				  ActivoValor.Parame_FrecuenciaDepreciacion, ActivoValor.Pardet_FrecuenciaDepreciacion, 1,
				  @ActCom_ValorErogacion, 0, 0
				FROM         ActivoValor INNER JOIN
				  Activo ON ActivoValor.Activo_Codigo = Activo.Activo_Codigo
				WHERE     (ActivoValor.ActVal_Activo = 1) AND (Activo.Activo_FechaBaja IS NULL)
				and ActivoValor.Activo_Codigo=@Activo_Codigo 
			end
			
			

			
		end	
		
		select @ActCom_Secuencia

    return 0		
	end
	if @accion='m'
	begin
		update ActivoComponente
			set ActCom_Activo= @ActCom_Activo, ActCom_Descripcion= @ActCom_Descripcion, Parame_Marca= @Parame_Marca, Pardet_Marca= @Pardet_Marca, ActCom_Modelo= @ActCom_Modelo, ActCom_Serie= @ActCom_Serie, ActCom_esErogacion= @ActCom_esErogacion, ActCom_ValorErogacion= @ActCom_ValorErogacion, 
			ActCom_FechaAdquisicion= @ActCom_FechaAdquisicion, 
			ActCom_FechaIngreso= @ActCom_FechaIngreso, 
			Entida_Proveedor= @Entida_Proveedor, ActCom_Factura= @ActCom_Factura, ActCom_FechaBaja= @ActCom_FechaBaja
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
    return 0		
	end
	if @accion='c'
	begin
		select Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, ActCom_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, ActCom_FechaIngreso, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja
			from ActivoComponente
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
		return 0
	end
	if @accion='e'
	begin
		if @ActCom_esErogacion=1 and @ActCom_ValorErogacion>0
		begin
			set @ActualDep=CAST(YEAR(@ActCom_FechaAdquisicion)*100+MONTH(@ActCom_FechaAdquisicion) as varchar(10))
			if exists (Select * from vw_DepreciacionDetReales
						where Parame_FrecuenciaDepreciacion=10055
						and Pardet_FrecuenciaDepreciacion=1
						and Deprec_Codigo= @ActualDep)
			begin
				raiserror (N'No puede eliminar el componente ya que está generada la depreciación %i', 16, 1, @ActualDep)
				return -1
			end
		end
		delete ActivoComponente
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, ActCom_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, ActCom_FechaIngreso, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja
			from ActivoComponente
		where Activo_Codigo= @Activo_Codigo
		order by ActCom_Secuencia
		return 0
	end
end
