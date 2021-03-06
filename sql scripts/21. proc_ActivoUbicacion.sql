USE [AFDepNueva]
GO
/****** Object:  StoredProcedure [dbo].[proc_ActivoUbicacion]    Script Date: 03/22/2018 10:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[proc_ActivoUbicacion]
(	@accion	char(2), 
	@Activo_Codigo	int=null, 
	@ActUbi_Secuencia	int=null, 
	@ActUbi_Activo	bit=null, 
	@Parame_Ubicacion	int=null, 
	@Pardet_Ubicacion	int=null, 
	@ActUbi_FechaDesde	date=null, 
	@ActUbi_FechaHasta	date=null,
	@Transa_Codigo	int=null,
	
	@filtro	nvarchar(350)=null)
as
begin
	declare @mensaje varchar(250)

	if @accion in ('i','m') and @ActUbi_Activo=1
	begin
		if @accion='i' or (Select top 1 ActUbi_Activo from ActivoUbicacion where Activo_Codigo=@Activo_Codigo)=0
		begin
			if exists (Select * from ActivoUbicacion where ActUbi_Activo=1)
				if (Select top 1 ActUbi_FechaDesde from ActivoUbicacion 
					where ActUbi_Activo=1
					and Activo_Codigo=@Activo_Codigo)> @ActUbi_FechaDesde
				begin
					set @mensaje='La fecha de cambio de Ubicacion debe ser mayor o igual al registro anterior para código ' + cast(@Activo_Codigo as varchar(20))
					raiserror (@mensaje,16,1)
					return -1
				end
			update ActivoUbicacion set ActUbi_FechaHasta=@ActUbi_FechaDesde
				where ActUbi_Activo=1
				and Activo_Codigo=@Activo_Codigo
		end
	end
	if @accion='i'
	begin
		if @ActUbi_Secuencia=0
		begin
			select @ActUbi_Secuencia=isnull(max(ActUbi_Secuencia),0)+1 from ActivoUbicacion
				where Activo_Codigo=@Activo_Codigo
		end
		
		--Actualizar ubicaciones en depreciaciones!
		declare @esDepreciable bit =0
		declare @Pardet_FrecuenciaDepreciacion int
		declare @ActualDep int
		declare @ProximaDep date
		declare @ProximaDepInt int
		declare @AnteriorDep date
		declare @AnteriorDepInt int
	 
		
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
			set @Pardet_FrecuenciaDepreciacion =1
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
			set @Pardet_FrecuenciaDepreciacion =2
		
		if (select Pardet_EstadoDepreciacion from Activo where Activo_Codigo = @Activo_Codigo)=1 and @ActUbi_Secuencia>1
		begin
			set @esDepreciable =1
			--Es mensual
			if @Pardet_FrecuenciaDepreciacion = 1
			begin
				set @ActualDep = cast(YEAR(@ActUbi_FechaDesde)*100+MONTH(@ActUbi_FechaDesde)as nvarchar) --cast(left(replace(CAST (getdate() as nvarchar),'-',''),6) as int)
				set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, @ActUbi_FechaDesde), 0) )
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
				set @AnteriorDep = DATEADD(m,-1,DATEADD(m, DATEDIFF(m, 0, @ActUbi_FechaDesde), 0) )
				set @AnteriorDepInt = cast(left(replace(CAST (@AnteriorDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ActualDep = cast(YEAR(@ActUbi_FechaDesde)*10000+MONTH(@ActUbi_FechaDesde)*100+DAY(@ActUbi_FechaDesde) as nvarchar) --cast(replace(CAST (getdate() as nvarchar),'-','') as int)
				set @ProximaDep = DATEADD(d,1, @ActUbi_FechaDesde)
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
				set @AnteriorDep = DATEADD(d,-1,@ActUbi_FechaDesde)
				set @AnteriorDepInt = cast(replace(CAST (@AnteriorDep as nvarchar),'-','') as int)
			end
			
			--Error si esta depreciacion ya esta generada
			if exists (Select * from Depreciacion
		           where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
		           and Deprec_Codigo= @ActualDep)
			begin
				raiserror (N'No puede cambiar la ubicación ya que está generada la depreciación %s', 16, 1, @ActualDep)
				return -1
			end
			
			--Error si la depreciacion anterior no esta generada
			if not exists (Select * from Depreciacion
					where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
					and Deprec_Codigo= @AnteriorDepInt)
			begin
				raiserror (N'No puede cambiar la ubicación ya que no está generada la depreciación %s', 16, 1, @AnteriorDepInt)
				return -1
			end
		end
		
		
		if @ActUbi_Activo=1
			update ActivoUbicacion set ActUbi_Activo=0
				where Activo_Codigo=@Activo_Codigo
		
		insert into ActivoUbicacion 
			(Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta, Transa_Codigo)
		values (@Activo_Codigo, @ActUbi_Secuencia, @ActUbi_Activo, @Parame_Ubicacion, @Pardet_Ubicacion, @ActUbi_FechaDesde, @ActUbi_FechaHasta, @Transa_Codigo)
		
		--Ubicacion
		declare @ubicacion nvarchar (250)=dbo.Fnc_UbicacionActual (@Activo_Codigo)
		if @ubicacion is null
			set @ubicacion ='error de ubicacion'
		
		update DepreciacionDet set Deprec_Ubicacion = @ubicacion
				where Deprec_Codigo >=@ActualDep  and Activo_Codigo=@Activo_Codigo
		
		select @ActUbi_Secuencia
		return 0
	end
	if @accion='m'
	begin
		update ActivoUbicacion
			set ActUbi_Activo= @ActUbi_Activo, Parame_Ubicacion= @Parame_Ubicacion, Pardet_Ubicacion= @Pardet_Ubicacion, ActUbi_FechaDesde= @ActUbi_FechaDesde, 
			ActUbi_FechaHasta= @ActUbi_FechaHasta, Transa_Codigo=@Transa_Codigo
		where Activo_Codigo= @Activo_Codigo and ActUbi_Secuencia= @ActUbi_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta, Transa_Codigo
			from ActivoUbicacion
		where Activo_Codigo= @Activo_Codigo and ActUbi_Secuencia= @ActUbi_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete ActivoUbicacion
		where Activo_Codigo= @Activo_Codigo and ActUbi_Secuencia= @ActUbi_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta, Transa_Codigo
			from ActivoUbicacion
		where Activo_Codigo= @Activo_Codigo 
		order by ActUbi_FechaDesde desc
		return 0
	end
	if @accion='fa'
	begin
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta, Transa_Codigo
			from ActivoUbicacion
		where Activo_Codigo= @Activo_Codigo 
		and ActUbi_Activo=1
		order by ActUbi_FechaDesde desc
		return 0
	end
	if @accion='ft'
	begin
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta, Transa_Codigo
			from ActivoUbicacion
		where Transa_Codigo= @Transa_Codigo 
		order by ActUbi_Secuencia
		return 0
	end
end
