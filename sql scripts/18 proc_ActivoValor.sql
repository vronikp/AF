
/****** Object:  StoredProcedure [dbo].[proc_ActivoValor]    Script Date: 03/19/2018 09:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[proc_ActivoValor]
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@Parame_TipoDepreciacion	int=null, 
	@Pardet_TipoDepreciacion	int=null, 
	@ActVal_Secuencia	int=null, 
	@Parame_TipoValoracion	int=null, 
	@Pardet_TipoValoracion	int=null, 
	@ActVal_Costo	money=null, 
	@ActVal_Salvamento	money=null, 
	@ActVal_PeriodosDepreciables	int=null, 
	@ActVal_FechaValoracion	smalldatetime=null, 
	@Entida_Perito	int=null, 
	@ActVal_Activo	bit=null, 
	@ActCom_Secuencia	int=null, 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null,
	@ActVal_ValorErogacion	money=null,
	@filtro	nvarchar(350)=null,
	@esDepreciable bit = null)
as
begin
	declare @ActualDep as int = null
	declare @ProximaDep as date=null
	declare @ProximaDepInt as int = null
	
	if @esDepreciable is null and (select Pardet_EstadoDepreciacion from Activo where Activo_Codigo = @Activo_Codigo)=1
		set @esDepreciable =1
		
	
	set @Parame_FrecuenciaDepreciacion = 10055
	--Parametrizado!
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
		set @Pardet_FrecuenciaDepreciacion =2
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
		set @Pardet_FrecuenciaDepreciacion =1
	
	
	if @accion='i'
	begin
		if @ActVal_Secuencia=0
		begin
			select @ActVal_Secuencia=isnull(max(ActVal_Secuencia),0)+1 from ActivoValor
				where Activo_Codigo=@Activo_Codigo
				and Parame_TipoDepreciacion= @Parame_TipoDepreciacion
				and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion
		end
		
		if @ActVal_Activo=1
			update ActivoValor
				set ActVal_Activo=0
				where Activo_Codigo=@Activo_Codigo
				and Parame_TipoDepreciacion= @Parame_TipoDepreciacion
				and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion

		--Generar Depreciaciones de TODA la vida!
		print 'Si es inicial o valoracion y es un activo depreciable, se generan todas las depreciaciones'
		if @Pardet_TipoValoracion in (1,2) and @esDepreciable=1
		begin
			if @ActVal_PeriodosDepreciables = 0
			begin
				raiserror (N'No puede generar la valoración de un activo depreciable con periodos depreciables 0', 16, 1)
				return -1
			end
			--nik: verificar si no se ha depreciado!
			--Es mensual
			print CAST (@ActVal_FechaValoracion as nvarchar)
			if @Pardet_FrecuenciaDepreciacion = 1
			begin
				set @ActualDep = cast(YEAR(@ActVal_FechaValoracion)*100+MONTH(@ActVal_FechaValoracion)as nvarchar) --cast(left(replace(CAST (@ActVal_FechaValoracion as nvarchar),'-',''),6) as int)
				set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, @ActVal_FechaValoracion), 0) )
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ActualDep = cast(YEAR(@ActVal_FechaValoracion)*10000+MONTH(@ActVal_FechaValoracion)*100+DAY(@ActVal_FechaValoracion) as nvarchar)--cast(replace(CAST (@ActVal_FechaValoracion as nvarchar),'-','') as int)
				set @ProximaDep = DATEADD(d,1,@ActVal_FechaValoracion)
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
			end
			
			
			--Error si la depreciacion proxima ya esta generada
			if exists (Select * from Depreciacion
			            where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion and Pardet_TipoDepreciacion =@Pardet_TipoDepreciacion
			            and Deprec_Codigo= @ProximaDepInt)
			begin
				raiserror (N'No puede generar la valoración ya que está generada la depreciación %i', 16, 1, @ProximaDepInt)
				return -1
			end
			
			--Error si la depreciacion actual no esta generada
			/*if not exists (Select * from Depreciacion
						where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion and Pardet_TipoDepreciacion =@Pardet_TipoDepreciacion
						and Deprec_Codigo= @ActualDep)
			begin
				raiserror (N'No puede generar la valoración ya que no está generada la depreciación %i', 16, 1, @ActualDep)
				return -1
			end*/
			
			insert into ActivoValor 
			(Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, ActVal_Costo, ActVal_Salvamento, ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, ActVal_ValorErogacion)
			values (@Activo_Codigo, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, @ActVal_Secuencia, @Parame_TipoValoracion, @Pardet_TipoValoracion, @ActVal_Costo, @ActVal_Salvamento, @ActVal_PeriodosDepreciables, @ActVal_FechaValoracion, @Entida_Perito, @ActVal_Activo, @ActCom_Secuencia, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @ActVal_ValorErogacion)
		
			
			delete from DepreciacionDet where Deprec_Codigo >=@ProximaDepInt and Pardet_TipoDepreciacion =@Pardet_TipoDepreciacion and Activo_Codigo=@Activo_Codigo
			
			declare @decimales int
			set  @decimales = (select Pardet_DatoInt1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
			declare @FrecuenciaDepreciacion nvarchar(10)= (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
							
			--nik: FLOOR para "cortar", CEILING para "redondear"
			declare @valorDepreciable decimal (18,8) =(@ActVal_Costo - @ActVal_Salvamento)
			declare @valorDepreciacion decimal (18,8) =(FLOOR((@valorDepreciable/ @ActVal_PeriodosDepreciables) * @decimales) / @decimales)
			declare @valorDeprecAcum decimal (18,8)=@valorDepreciacion
			declare @numDeprec int =1
			
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
				
			
			while (@valorDeprecAcum<@valorDepreciable and @numDeprec<@ActVal_PeriodosDepreciables)
			begin
				
				exec proc_DepreciacionDet 'i', @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, 
					@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, @ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum
				
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
				exec proc_DepreciacionDet 'i', @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, 
					@ProximaDepInt, @Activo_Codigo, @ActVal_Secuencia, @valorDepreciacion, @ctaActivo, @CentroCosto, @ctaGasto, @ubicacion,@numDeprec, @valorDeprecAcum
				
			end
		end
		else 
		begin
			insert into ActivoValor 
			(Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Parame_TipoValoracion, Pardet_TipoValoracion, ActVal_Costo, ActVal_Salvamento, ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, ActVal_ValorErogacion)
			values (@Activo_Codigo, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, @ActVal_Secuencia, @Parame_TipoValoracion, @Pardet_TipoValoracion, @ActVal_Costo, @ActVal_Salvamento, @ActVal_PeriodosDepreciables, @ActVal_FechaValoracion, @Entida_Perito, @ActVal_Activo, @ActCom_Secuencia, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @ActVal_ValorErogacion)
		end
		
		select @ActVal_Secuencia
		return 0
	end
	if @accion='m'
	begin
		update ActivoValor
			set Parame_TipoValoracion= @Parame_TipoValoracion, Pardet_TipoValoracion= @Pardet_TipoValoracion, ActVal_Costo= @ActVal_Costo, ActVal_Salvamento= @ActVal_Salvamento, ActVal_PeriodosDepreciables= @ActVal_PeriodosDepreciables, ActVal_FechaValoracion= @ActVal_FechaValoracion, Entida_Perito= @Entida_Perito, ActVal_Activo= @ActVal_Activo, ActCom_Secuencia= @ActCom_Secuencia, Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion, ActVal_ValorErogacion= @ActVal_ValorErogacion
		where Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, 
			Parame_TipoValoracion, Pardet_TipoValoracion, ActVal_Costo, ActVal_Salvamento, 
			ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo,
			ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			ActVal_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt 
			from ActivoValor
		where Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete ActivoValor
		where Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, 
			Parame_TipoValoracion, Pardet_TipoValoracion, ActVal_Costo, ActVal_Salvamento, 
			ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, 
			ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			ActVal_ValorErogacion, ActVal_DeprecAcumAnt, ActVal_NumDeprecAcumAnt
			from ActivoValor
		where Activo_Codigo= @Activo_Codigo 
		order by Pardet_TipoDepreciacion, ActVal_Secuencia 
		return 0
	end
end
