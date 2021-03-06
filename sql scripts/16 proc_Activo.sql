USE [AFDepNueva]
GO
/****** Object:  StoredProcedure [dbo].[proc_Activo]    Script Date: 03/19/2018 08:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[proc_Activo]
(	@accion	char(6), 
	@Activo_Codigo	int=null, 
	@Activo_CodigoBarra nvarchar(50)=null,
	@Activo_CodigoBarraCruce nvarchar(50)=null,
	@Activo_CodigoAux	nvarchar(50)=null,
	@Activo_Serie	nvarchar(50)=null, 
	@Parame_ClaseActivo	int=null, 
	@Pardet_ClaseActivo	int=null, 
	@Activo_Descripcion	nvarchar(150)=null, 
	@Parame_Marca	int=null, 
	@Pardet_Marca	int=null, 
	@Activo_Modelo	nvarchar(150)=null, 
	@Activo_Observacion	nvarchar(350)=null, 
	@Activo_Imagen	image=null, 
	@Parame_EstadoDepreciacion	int=null, 
	@Pardet_EstadoDepreciacion	int=null, 
	@Parame_EstadoActivo	int=null, 
	@Pardet_EstadoActivo	int=null, 
	@Activo_ResponsableMantenimiento	nvarchar(150)=null, 
	@Activo_FechaIngreso	date=null, 
	@Activo_FechaCompra	date=null, 
	@Activo_FechaUso	date=null,
	@Activo_FechaGarantia	date=null, 
	@Parame_CentroCosto	int=null, 
	@Pardet_CentroCosto	int=null, 
	@Factura_Codigo	int=null, 
	@Activo_FechaBaja	date=null, 
	@Parame_TipoBajaActivo	int=null, 
	@Pardet_TipoBajaActivo	int=null, 
	
	@Parame_Ubicacion	int=null,
	@Pardet_Ubicacion	int=null,
	@Entida_Custodio	int=null,
	@Costo	money=null,
	@Salvamento	money=null,
	@PeriodosDepreciables	int=null,
	@Parame_FrecuenciaDepreciacion	int=null,
	@Pardet_FrecuenciaDepreciacion	int=null,
	@Fecha_Cambio_UbicacionCustodio date=null,
	@Grabar_UbicacionCustodio bit=null,
	
	@Parame_EstadoInventario	int=null, 
	@Pardet_EstadoInventario	int=null, 
	
	@TraBaj_Codigo int=null,
	
	@Pardet_GrupoActivo	int=null, 
	@Pardet_TipoActivo	int=null, 
	@Entida_Proveedor	int=null,
	@SoloActivos	bit=null,
	
	@RangoFecha	int=null,
	@FechaDesde	date=null,
	@FechaHasta date=null,
	
	--rac
	@Parame_PeriodoInventario int=null,
	@Pardet_PeriodoInventario int=null,
	
	@SoloInventariados bit=null,
	
	@filtro	nvarchar(200)=null)
as
begin
	declare @ffc as nvarchar (8)
	select @ffc =  '20'+CtaCtb_CtaCtble1 + CtaCtb_CtaCtble2+Pardet_DatoStr3 
	from ParametroDet where Parame_Codigo=1
	
	print @ffc 
	print getdate()

	declare @ActualDep int
	declare @ProximaDep date
	declare @ProximaDepInt int
	declare @AnteriorDep date
	declare @AnteriorDepInt int
	
	declare @ctaActivo nvarchar (50) =null
	declare @ctaGasto nvarchar (50)=null
	declare @centroCosto nvarchar (50)=null
	
	set @Parame_FrecuenciaDepreciacion = 10055
	
	--Parametrizado!
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
		set @Pardet_FrecuenciaDepreciacion =2
	if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
		set @Pardet_FrecuenciaDepreciacion =1
	
	if GETDATE()>@ffc
	begin
		update ParametroDet set Pardet_DatoStr1='', Pardet_DatoStr2 ='', Pardet_DatoStr3 = '' where Parame_Codigo = 10001
		print 'Vencio'
		raiserror('Ha vencido el plazo del contrato de alquiler. Contáctese con el proveedor.', 16,1)
		return -1
	end
	
	print 'continua'
	
	declare @error varchar(300)
	declare @cruceant nvarchar(50)
	set @cruceant=null
	
	print 'Cargando activo'
	if @accion='i'
	begin
		if @Activo_Codigo=0
		begin
 			select @Activo_Codigo=isnull(max(Activo_Codigo),0)+1 from Activo
		end
		if @Activo_CodigoBarra=''
			exec proc_CodigoBarrasArtefacta @Activo_CodigoBarra output
		else
		  if exists (Select * from Activo where Activo_CodigoBarra=@Activo_CodigoBarra)
		  begin
		    raiserror('El código de barras que desea guardar ya existe en el sistema', 16,1)
		    return -1
		  end

		if @Factura_Codigo=0 and not exists(select * from FacturaActivo where Factura_Codigo=0)
		begin
			select @Entida_Proveedor=isnull(max(Entida_Codigo),0)+1 from Entidad
			insert into Entidad 
				(Entida_Codigo, Parame_Tipoentidad, Pardet_Tipoentidad, Entida_AutorizacionFactura, Entida_CaducidadFactura, Entida_AutorizacionNotaVenta, Entida_CaducidadNotaVenta, Entida_AutorizacionRetencion, Entida_CaducidadRetencion, Entida_Imagen)
			values (@Entida_Proveedor, 110, 2,'','','','','','',null)
			
			insert into EntidadJuridica
				(Entida_Codigo, Entjur_Nombrecomercial, Entjur_Razonsocial, Entjur_Fechaconstitucion, Parame_Tipocontribuyente, Pardet_Tipocontribuyente, Entida_RepresLegal, Entida_Contacto)
			values (@Entida_Proveedor, 'NN','',null,
				145,1,null,null)
				
			insert into EntidadIdentificacion
				(Entida_Codigo, Parame_Tipoidentificacion, Pardet_Tipoidentificacion, Identi_Numero)
			values (@Entida_Proveedor, 120, 1, '000')
			
			insert into Proveedor
				(Entida_Codigo, Provee_Visible)
			values (@Entida_Proveedor, 1)
		
			print 'Cargando factura'
		
			set @factura_codigo=0
			
			insert into FacturaActivo 
				(Factura_Codigo, Entida_Proveedor, Factura_Numero, Factura_Fecha)
			values (@Factura_Codigo, @Entida_Proveedor, 'NN', getdate())
			
		end
		
		insert into Activo 
			(Activo_Codigo, Activo_CodigoBarra, Activo_CodigoAux, Activo_Serie, Parame_ClaseActivo, Pardet_ClaseActivo, 
			Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, 
			Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, 
			Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Activo_FechaGarantia,
			Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo)
		values (@Activo_Codigo, @Activo_CodigoBarra, @Activo_CodigoAux, @Activo_Serie, @Parame_ClaseActivo, @Pardet_ClaseActivo, 
			@Activo_Descripcion, @Parame_Marca, @Pardet_Marca, @Activo_Modelo, @Activo_Observacion, 
			@Parame_EstadoDepreciacion, @Pardet_EstadoDepreciacion, @Parame_EstadoActivo, @Pardet_EstadoActivo, 
			@Activo_ResponsableMantenimiento, @Activo_FechaIngreso, @Activo_FechaCompra, @Activo_FechaUso, @Activo_FechaGarantia,
			@Parame_CentroCosto, @Pardet_CentroCosto, @Factura_Codigo, @Activo_FechaBaja, @Parame_TipoBajaActivo, 
			@Pardet_TipoBajaActivo)

		select @Activo_Codigo
		
		set @Grabar_UbicacionCustodio=1
		set @Fecha_Cambio_UbicacionCustodio=@Activo_FechaIngreso
	end
	if @accion='m'
	begin
		select @cruceant=Activo_CodigoBarraCruce
			from Activo
			where Activo_Codigo=@Activo_Codigo
		if @Pardet_EstadoDepreciacion=1 or (@Pardet_EstadoDepreciacion is null and (select Pardet_EstadoDepreciacion from Activo where Activo_Codigo = @Activo_Codigo)=1)
		begin
			set @Pardet_EstadoDepreciacion =1
			--Es mensual
			if @Pardet_FrecuenciaDepreciacion = 1
			begin
				set @ActualDep = cast(YEAR(getdate())*100+MONTH(getdate())as nvarchar)--cast(left(replace(CAST (getdate() as nvarchar),'-',''),6) as int)
				set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, getdate()), 0) )
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
				set @AnteriorDep = DATEADD(m,-1,DATEADD(m, DATEDIFF(m, 0, getdate()), 0) )
				set @AnteriorDepInt = cast(left(replace(CAST (@AnteriorDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ActualDep = cast(YEAR(getdate())*10000+MONTH(getdate())*100+DAY(getdate()) as nvarchar)--cast(replace(CAST (getdate() as nvarchar),'-','') as int)
				set @ProximaDep = DATEADD(d,1,getdate())
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
				set @AnteriorDep = DATEADD(d,-1,getdate())
				set @AnteriorDepInt = cast(replace(CAST (@AnteriorDep as nvarchar),'-','') as int)
			end
		end
				
		--Cambio en clase si es depreciable
		declare @Pardet_ClaseActivoAnt int = (select Pardet_ClaseActivo
									from Activo where Activo_Codigo =@Activo_Codigo)
		if @Pardet_ClaseActivo <> @Pardet_ClaseActivoAnt and @Pardet_EstadoDepreciacion=1
		begin
			--cambio en tipo
			if (select Pardet_Padre from ParametroDet where Parame_Codigo =10029 and Pardet_Secuencia =@Pardet_ClaseActivo)<>
				(select Pardet_Padre from ParametroDet where Parame_Codigo =10029 and Pardet_Secuencia =@Pardet_ClaseActivoAnt)
			begin
				--Error si esta depreciacion ya esta generada
				if exists (Select * from Depreciacion
			            where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
			            and Deprec_Codigo= @ActualDep)
				begin
					raiserror (N'No puede cambiar el tipo ya que está generada la depreciación %i', 16, 1, @ActualDep)
					return -1
				end
			
				--Error si la depreciacion anterior no esta generada
				if not exists (Select * from Depreciacion
						where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
						and Deprec_Codigo= @AnteriorDepInt)
				begin
					raiserror (N'No puede cambiar el tipo ya que no está generada la depreciación %i', 16, 1, @AnteriorDepInt)
					return -1
				end
				--CuentaActivo y cuenta gasto
				select @ctaActivo = pdTipo.Pardet_DatoStr1, @ctaGasto = pdTipo.Pardet_DatoStr2 
				from ParametroDet as pdClase inner join ParametroDet pdTipo on pdClase.Parame_Padre = pdTipo.Parame_Codigo and
					pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia
				where pdClase.Parame_Codigo =10029 and pdClase.Pardet_Secuencia =@Pardet_ClaseActivo
				
				update DepreciacionDet set Deprec_CtaActivoFijo = @ctaActivo, Deprec_CtaGasto=@ctaGasto 
				where Deprec_Codigo >=@ActualDep  and Activo_Codigo=@Activo_Codigo
				
			end
		end
		
		--Cambio de centro de costo
		declare @Pardet_CentroCostoAnt int = (select Pardet_CentroCosto
									from Activo where Activo_Codigo =@Activo_Codigo)
		if @Pardet_CentroCosto <> @Pardet_CentroCostoAnt and @Pardet_EstadoDepreciacion=1
		begin
			--Error si esta depreciacion ya esta generada
			if exists (Select * from Depreciacion
			           where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
			           and Deprec_Codigo= @ActualDep)
			begin
				raiserror (N'No puede cambiar el centro de costo ya que está generada la depreciación %i', 16, 1, @ActualDep)
				return -1
			end
			
			--Error si la depreciacion anterior no esta generada
			if not exists (Select * from Depreciacion
					where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
					and Deprec_Codigo= @AnteriorDepInt)
			begin
				raiserror (N'No puede cambiar el centro de costo ya que no está generada la depreciación %i', 16, 1, @AnteriorDepInt)
				return -1
			end
			
			--Cta Centoro Costo
			select @centroCosto = Pardet_DatoStr1
			from ParametroDet  
			where Parame_Codigo= @Parame_CentroCosto and Pardet_Secuencia = @Pardet_CentroCosto
				
			update DepreciacionDet set Deprec_CtaCentroCosto = @centroCosto 
			where Deprec_Codigo >=@ActualDep  and Activo_Codigo=@Activo_Codigo
		end
		if not @Activo_FechaBaja is null
		begin						
			if @Pardet_EstadoDepreciacion=1
			begin				
				--Es mensual
				if @Pardet_FrecuenciaDepreciacion = 1
				begin
					set @ActualDep = cast(YEAR(@Activo_FechaBaja)*100+MONTH(@Activo_FechaBaja)as nvarchar)--cast(left(replace(CAST (getdate() as nvarchar),'-',''),6) as int)
					set @ProximaDep = DATEADD(m,1,DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0) )
					set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
					set @AnteriorDep = DATEADD(m,-1,DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0) )
					set @AnteriorDepInt = cast(left(replace(CAST (@AnteriorDep as nvarchar),'-',''),6) as int)
				end
			
				--Es diaria
				if @Pardet_FrecuenciaDepreciacion = 2
				begin
					set @ActualDep = cast(YEAR(@Activo_FechaBaja)*10000+MONTH(@Activo_FechaBaja)*100+DAY(@Activo_FechaBaja) as nvarchar)--cast(replace(CAST (getdate() as nvarchar),'-','') as int)
					set @ProximaDep = DATEADD(d,1,@Activo_FechaBaja)
					set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
					set @AnteriorDep = DATEADD(d,-1,@Activo_FechaBaja)
					set @AnteriorDepInt = cast(replace(CAST (@AnteriorDep as nvarchar),'-','') as int)
				end
				--Error si esta depreciacion ya esta generada
				if exists (Select * from Depreciacion
			            where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
			            and Deprec_Codigo= @ActualDep)
				begin
					raiserror (N'No puede dar de baja ya que está generada la depreciación %i', 16, 1, @ActualDep)
					return -1
				end
			
				--Error si la depreciacion anterior no esta generada
				if not exists (Select * from Depreciacion
						where Pardet_FrecuenciaDepreciacion=@Pardet_FrecuenciaDepreciacion
						and Deprec_Codigo= @AnteriorDepInt)
				begin
					raiserror (N'No puede dar de baja ya que no está generada la depreciación %i', 16, 1, @AnteriorDepInt)
					return -1
				end
				
				--Eliminar depreciaciones
				delete from DepreciacionDet where Deprec_Codigo >=@ActualDep  and Activo_Codigo=@Activo_Codigo
				
			end
			
		end
		update Activo
			set Activo_CodigoBarra= @Activo_CodigoBarra,
			Activo_CodigoAux= @Activo_CodigoAux, 
			Activo_Serie= @Activo_Serie, Parame_ClaseActivo= @Parame_ClaseActivo, 
			Pardet_ClaseActivo= @Pardet_ClaseActivo, Activo_Descripcion= @Activo_Descripcion, 
			Parame_Marca= @Parame_Marca, Pardet_Marca= @Pardet_Marca, Activo_Modelo= @Activo_Modelo, 
			Activo_Observacion= @Activo_Observacion, Parame_EstadoDepreciacion= @Parame_EstadoDepreciacion, 
			Pardet_EstadoDepreciacion= @Pardet_EstadoDepreciacion, Parame_EstadoActivo= @Parame_EstadoActivo, 
			Pardet_EstadoActivo= @Pardet_EstadoActivo, 
			Activo_ResponsableMantenimiento= @Activo_ResponsableMantenimiento, 
			Activo_FechaIngreso= @Activo_FechaIngreso, Activo_FechaCompra= @Activo_FechaCompra, 
			Activo_FechaUso= @Activo_FechaUso, Activo_FechaGarantia=@Activo_FechaGarantia, Parame_CentroCosto= @Parame_CentroCosto, 
			Pardet_CentroCosto= @Pardet_CentroCosto, Factura_Codigo= @Factura_Codigo, 
			Activo_FechaBaja= @Activo_FechaBaja, Parame_TipoBajaActivo= @Parame_TipoBajaActivo, Pardet_TipoBajaActivo= @Pardet_TipoBajaActivo,
			TraBaj_Codigo=@TraBaj_Codigo
		where Activo_Codigo= @Activo_Codigo
	end
	if @accion in ('i', 'm')
	begin
		
		
		if not @Activo_CodigoBarraCruce is null
		begin
			if @cruceant is null or not @cruceant=@Activo_CodigoBarraCruce
			begin
				declare @codant int
				declare @Factura_Codigoant int
				declare @Activo_FechaIngresoant date
				declare @Activo_FechaCompraant date
				declare @Activo_FechaUsoant date
				declare @Activo_FechaGarantiaant date
				declare @Activo_Descripcionant nvarchar(150)
				Select @codant=Activo_Codigo, 
				  @Factura_Codigoant=Factura_Codigo,
				  @Activo_FechaIngresoant=Activo_FechaIngreso,
				  @Activo_FechaCompraant=Activo_FechaCompra,
				  @Activo_FechaUsoant=Activo_FechaUso,
				  @Activo_FechaGarantiaant=Activo_FechaGarantia,
				  @Activo_Descripcionant=Activo_Descripcion
					from Activo
					where Activo_CodigoBarra=@Activo_CodigoBarraCruce
					and Activo_FechaBaja is null
				
				if @codant is null
				begin
					set @error='No se puede realizar el cruce ya que el código de barras ' + @Activo_CodigoBarraCruce + ' no existe o no está activo'
					raiserror(@error, 16,1)
					return -1 
				end
				
				Update Activo
					set Activo_CodigoBarraCruce=@Activo_CodigoBarraCruce,
					Factura_Codigo=@Factura_Codigoant,
					Activo_FechaIngreso=@Activo_FechaIngresoant,
					Activo_FechaCompra=@Activo_FechaCompraant,
					Activo_FechaUso=@Activo_FechaUsoant,
					Activo_FechaGarantia= @Activo_FechaGarantiaant, 
					Activo_Descripcion=@Activo_Descripcionant
					where Activo_Codigo=@Activo_Codigo

				Update Activo
					set Activo_CodigoBarraCruce=@Activo_CodigoBarra,
					Factura_Codigo=@Factura_Codigo,
					Activo_FechaIngreso=@Activo_FechaIngreso,
					Activo_FechaCompra=@Activo_FechaCompra,
					Activo_FechaUso=@Activo_FechaUso,
					Activo_FechaGarantia= @Activo_FechaGarantiaant, 
					Activo_Descripcion=@Activo_Descripcion
					where Activo_Codigo=@codant

				Update Activo
					set Activo_FechaBaja = GETDATE(),
					Parame_TipoBajaActivo = 10050,
					Pardet_TipoBajaActivo = 99
					where Activo_Codigo=@codant
					
				Update ActivoValor
					set Activo_Codigo=case when Activo_Codigo=@Activo_Codigo then @codant
											else @Activo_Codigo end
					where Activo_Codigo in (@Activo_Codigo, @codant)
			end
		end
		
				
		if @Grabar_UbicacionCustodio=1
		begin
			if not @Entida_Custodio = coalesce((Select top 1 Emplea_Custodio from ActivoCustodio where Activo_Codigo=@Activo_Codigo and ActCus_Activo=1),-1)
				exec proc_ActivoCustodio
					'i', @Activo_Codigo, 0, 1, 10095,2, @Fecha_Cambio_UbicacionCustodio, null, @Entida_Custodio, ''
			
			if not @Pardet_Ubicacion = coalesce((Select top 1 Pardet_Ubicacion from ActivoUbicacion where Activo_Codigo=@Activo_Codigo and ActUbi_Activo=1),-1)
				exec proc_ActivoUbicacion	
					'i', @Activo_Codigo, 0, 1, @Parame_Ubicacion, @Pardet_Ubicacion, @Fecha_Cambio_UbicacionCustodio, null
		end
		
		if @Costo >0
		begin
			--Si tiene valor, agregamos en activoValor
			declare @esDepreciable bit=0
			if @Pardet_EstadoDepreciacion =1 
				set @esDepreciable =1
				
			exec proc_ActivoValor
				'i', @Activo_Codigo, 10080, 1, 0, 10085, 1, @Costo, @Salvamento, @PeriodosDepreciables,
				@Activo_FechaIngreso, null, 1, null, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, null, null, @esDepreciable
		
			exec proc_ActivoValor
				'i', @Activo_Codigo, 10080, 2, 0, 10085, 1, @Costo, @Salvamento, @PeriodosDepreciables,
				@Activo_FechaIngreso, null, 1, null, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, null, null, @esDepreciable
		end
		
		return 0

	end
	if @accion='pl' --picture load
	begin
		select Activo_Imagen
			from Activo
		where Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='ps' --picture save
	begin
		update Activo set Activo_Imagen=@Activo_Imagen
		where Activo_Codigo= @Activo_Codigo
		return 0
	end

	if @accion='c'
	begin
		select Activo_Codigo, Activo_CodigoBarra, Activo_CodigoBarraCruce, Activo_CodigoAux, Activo_Serie, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Activo_FechaGarantia, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo
			from Activo
		where Activo_Codigo= @Activo_Codigo
		return 0
	end

	if @accion='cb'
	begin
		select Activo_Codigo, Activo_CodigoBarra, Activo_CodigoBarraCruce, Activo_CodigoAux, Activo_Serie, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Activo_FechaGarantia, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo
			from Activo
		where Activo_CodigoBarra= @Activo_CodigoBarra
		return 0
	end
	if @accion='e'
	begin
		delete Activo
		where Activo_Codigo= @Activo_Codigo
		return 0
	end
	/*
	'Tipo Rango Fechas
  '0 Compra entre
  '1 Ingreso entre
  '2 Uso entre
  '3 Baja entre
  '4 Sin fecha de uso
  '5 Sin fecha de baja
  */
	if @accion='f'
	begin
		if @filtro = 'inventario'
		begin
		--select null
		
		SELECT     Activo.Activo_Codigo, Activo.Activo_CodigoBarra, Activo_CodigoBarraCruce, Activo_CodigoAux, Activo.Activo_Serie, Activo.Parame_ClaseActivo, Activo.Pardet_ClaseActivo, Activo.Activo_Descripcion, 
                      Activo.Parame_Marca, Activo.Pardet_Marca, Activo.Activo_Modelo, Activo.Activo_Observacion, Activo.Parame_EstadoDepreciacion, 
                      Activo.Pardet_EstadoDepreciacion, Activo.Parame_EstadoActivo, Activo.Pardet_EstadoActivo, Activo.Activo_ResponsableMantenimiento, Activo.Activo_FechaIngreso, 
                      Activo.Activo_FechaCompra, Activo.Activo_FechaUso, Activo.Activo_FechaGarantia, Activo.Parame_CentroCosto, Activo.Pardet_CentroCosto, Activo.Factura_Codigo, Activo.Activo_FechaBaja, 
                      Activo.Parame_TipoBajaActivo, Activo.Pardet_TipoBajaActivo
		FROM         Activo  INNER JOIN InventarioDet ON activo.Activo_Codigo = InventarioDet.Activo_Codigo AND InventarioDet.InvDet_Activo = 1
							INNER JOIN ActivoCustodio ON InventarioDet.Activo_Codigo = ActivoCustodio.Activo_Codigo AND 
                      ActivoCustodio.ActCus_Secuencia = CASE WHEN InventarioDet.InvDet_esCambioCustodio = 1 THEN ActCus_SecuenciaActual ELSE ActCus_SecuenciaAnterior END INNER JOIN
                      dbo.vw_Persona ON dbo.ActivoCustodio.Emplea_Custodio = dbo.vw_Persona.Entida_Codigo
		where 
			ActivoCustodio.Emplea_Custodio = @Entida_Custodio
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=Activo.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=Activo.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario<> @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		order by Pardet_EstadoInventario, dbo.ParametroDetDescripcion(Activo.Parame_ClaseActivo, activo.Pardet_ClaseActivo, '>'), activo.Activo_CodigoBarra
		
		return 0
		end
		else
		begin
		SELECT     Activo.Activo_Codigo, Activo.Activo_CodigoBarra, Activo_CodigoBarraCruce, Activo_CodigoAux, Activo.Activo_Serie, Activo.Parame_ClaseActivo, Activo.Pardet_ClaseActivo, Activo.Activo_Descripcion, 
                      Activo.Parame_Marca, Activo.Pardet_Marca, Activo.Activo_Modelo, Activo.Activo_Observacion, Activo.Parame_EstadoDepreciacion, 
                      Activo.Pardet_EstadoDepreciacion, Activo.Parame_EstadoActivo, Activo.Pardet_EstadoActivo, Activo.Activo_ResponsableMantenimiento, Activo.Activo_FechaIngreso, 
                      Activo.Activo_FechaCompra, Activo.Activo_FechaUso, Activo.Activo_FechaGarantia, Activo.Parame_CentroCosto, Activo.Pardet_CentroCosto, Activo.Factura_Codigo, Activo.Activo_FechaBaja, 
                      Activo.Parame_TipoBajaActivo, Activo.Pardet_TipoBajaActivo
		FROM         ParametroDet as PardetClase INNER JOIN
                      Activo ON PardetClase.Parame_Codigo = Activo.Parame_ClaseActivo AND PardetClase.Pardet_Secuencia = Activo.Pardet_ClaseActivo INNER JOIN
                      ParametroDet AS PardetTipo ON PardetClase.Parame_Padre = PardetTipo.Parame_Codigo AND 
                      PardetClase.Pardet_Padre = PardetTipo.Pardet_Secuencia
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=Activo.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=Activo.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=Activo.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and (case when @Pardet_TipoBajaActivo IS null then 1
		when @Pardet_TipoBajaActivo=Pardet_TipoBajaActivo then 1
		else 0 end)=1
		
		--coalesce (@Pardet_TipoBajaActivo, Pardet_TipoBajaActivo)=Pardet_TipoBajaActivo
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=Activo.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by Activo_CodigoBarra
		return 0
		end
	end
	if @accion='fp'
	begin
		SELECT     1
		FROM          Activo inner join InventarioDet on
							InventarioDet.Activo_Codigo=Activo.Activo_codigo
		where Activo.Activo_Codigo=@Activo_Codigo
		and Pardet_PeriodoInventario= @Pardet_PeriodoInventario
		and inventariodet.Pardet_EstadoInventario>1
		order by Activo_CodigoBarra
		return 0
	end
	if @accion='rg'
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso,  Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual
			from vw_ReporteActivo
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=vw_ReporteActivo.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=vw_ReporteActivo.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by Grupo, Tipo, Clase, Activo_Codigo
		return 0
	end
	if @accion='rc'  --por custodio
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual
			from vw_ReporteActivo
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=vw_ReporteActivo.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=vw_ReporteActivo.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by CustodioActual, Activo_Codigo
		return 0
	end
	if @accion='ru' --por ubicacion
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual
			from vw_ReporteActivo
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=vw_ReporteActivo.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=vw_ReporteActivo.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by UbicacionActual, Activo_Codigo
		return 0
	end

if @accion='ri'  --reporte ingreso de activos
	begin
		select Proveedor, Factura_Numero, Factura_Fecha, Custodio, UbicacionInicial,
			Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, 
			Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, 
			Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, 
			CostoOriginal,CustodioCI
		from vw_ReporteActivoIngreso
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		and coalesce (@Entida_Proveedor, ProveedorCodigo)=ProveedorCodigo
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and coalesce (@Entida_Custodio, CustodioCodigo)=CustodioCodigo
		and (case when @Pardet_Ubicacion is null then 1
			when dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%' then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=vw_ReporteActivoIngreso.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by Proveedor, Factura_Numero, Factura_Fecha, Custodio, UbicacionInicial, Grupo, Tipo, Clase, Activo_Codigo
		return 0
	end


	if @accion='rgd'
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual,
			CostoTrib, SalvamentoTrib, DepreciadoTrib, ResiduoTrib, CostoFin, 
			SalvamentoFin, DepreciadoFin, ResiduoFin
			from vw_ReporteActivoDepreciacion
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=vw_ReporteActivoDepreciacion.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo= vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo= vw_ReporteActivoDepreciacion.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is not null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by Grupo, Tipo, Clase, Activo_Codigo
		return 0
	end
	if @accion='rcd'  --por custodio
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual,
			CostoTrib, SalvamentoTrib, DepreciadoTrib, ResiduoTrib, CostoFin, 
			SalvamentoFin, DepreciadoFin, ResiduoFin
			from  vw_ReporteActivoDepreciacion
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo= vw_ReporteActivoDepreciacion.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo= vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo= vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo= vw_ReporteActivoDepreciacion.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by CustodioActual, Activo_Codigo
		return 0
	end
	if @accion='rud' --por ubicacion
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, 
			Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, 
			Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, 
			Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, 
			Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, 
			UbicacionActual, CustodioActual,
			CostoTrib, SalvamentoTrib, DepreciadoTrib, ResiduoTrib, CostoFin, 
			SalvamentoFin, DepreciadoFin, ResiduoFin
			from  vw_ReporteActivoDepreciacion
		where 
			(case when @Activo_CodigoBarra is null then 1
			when Activo_CodigoBarra like '%'+@Activo_CodigoBarra+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_CodigoAux is null then 1
			when Activo_CodigoAux like '%'+@Activo_CodigoAux+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Serie is null then 1
			when Activo_Serie like '%'+@Activo_Serie+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Descripcion is null then 1
			when Activo_Descripcion like '%'+@Activo_Descripcion+'%' then 1
			else 0 end)=1
		and
			(case when @Activo_Modelo is null then 1
			when Activo_Modelo like '%'+@Activo_Modelo+'%' then 1
			else 0 end)=1
		and coalesce (@Pardet_Marca, Pardet_Marca)=Pardet_Marca
		--and coalesce (@Pardet_ClaseActivo, Pardet_ClaseActivo)=Pardet_ClaseActivo
		and 
			(case when @Pardet_ClaseActivo is null then 1
			when dbo.ParametroDetDescripcion(Parame_ClaseActivo, Pardet_ClaseActivo, ' > ') 
				like dbo.ParametroDetDescripcion(@Parame_ClaseActivo, @Pardet_ClaseActivo, ' > ')+'%' then 1
			else 0 end)=1

		--and coalesce (@Pardet_TipoActivo, PardetTipo.Pardet_Secuencia)=PardetTipo.Pardet_Secuencia
		--and coalesce (@Pardet_GrupoActivo, PardetTipo.Pardet_Padre)=PardetTipo.Pardet_Padre
		
		and 
			(case when @Entida_Proveedor is null then 1
			when exists (Select * from FacturaActivo where
							FacturaActivo.Factura_Codigo=vw_ReporteActivoDepreciacion.Factura_Codigo
							and Entida_Proveedor=@Entida_Proveedor) then 1
			else 0 end)=1
		and coalesce (@Factura_Codigo, Factura_Codigo)=Factura_Codigo
		and 
			(case when @Entida_Custodio is null then 1
			when exists (Select * from ActivoCustodio where
							ActivoCustodio.Activo_Codigo=vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActCus_Activo=1
							and Emplea_Custodio=@Entida_Custodio) then 1
			else 0 end)=1
		and 
			(case when @Pardet_Ubicacion is null then 1
			when exists (Select * from ActivoUbicacion where
							ActivoUbicacion.Activo_Codigo=vw_ReporteActivoDepreciacion.Activo_Codigo
							and ActUbi_Activo=1
							and dbo.ParametroDetDescripcion(Parame_Ubicacion, Pardet_Ubicacion, ' > ') like dbo.ParametroDetDescripcion(@Parame_Ubicacion, @Pardet_Ubicacion, ' > ')+'%') then 1
			else 0 end)=1
		and
			(case when @Parame_EstadoInventario is null then 1
			when exists (Select * from InventarioDet where
							InventarioDet.Activo_Codigo=vw_ReporteActivoDepreciacion.Activo_codigo
							and InvDet_Activo=1
							and Pardet_EstadoInventario= @Pardet_EstadoInventario) then 1
			else 0 end)=1
		and
			(case when @SoloActivos is null then 1
				when @SoloActivos=1 and Activo_FechaBaja is null then 1
				else 0 end)=1
		and
			(case when @RangoFecha=0 and Activo_FechaCompra between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=1 and Activo_FechaIngreso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=2 and Activo_FechaUso between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=3 and Activo_FechaBaja between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=5 and Activo_FechaUso IS null then 1
			when @RangoFecha=6 and not Activo_FechaBaja is null then 1
			when @RangoFecha=4 and Activo_FechaGarantia between @FechaDesde and @FechaHasta then 1
			when @RangoFecha=7 and Activo_FechaGarantia is null then 1
			when @RangoFecha=8 and not Activo_FechaGarantia is null then 1
			when @RangoFecha=-1 then 1
			else 0 end)=1
		order by UbicacionActual, Activo_Codigo
		return 0
	end

if @accion='rf' --reporte ficha
	begin
		SELECT     vw_ReporteActivo.Activo_Codigo, vw_ReporteActivo.Activo_Serie, vw_ReporteActivo.Grupo, vw_ReporteActivo.Tipo, vw_ReporteActivo.Clase, 
			vw_ReporteActivo.Activo_CodigoBarra, vw_ReporteActivo.Activo_Descripcion, vw_ReporteActivo.Marca, vw_ReporteActivo.Activo_Modelo, 
			vw_ReporteActivo.Activo_Observacion, vw_ReporteActivo.Estado_Depreciacion, vw_ReporteActivo.Estado_Activo, 
			vw_ReporteActivo.Activo_ResponsableMantenimiento, vw_ReporteActivo.Activo_FechaIngreso, vw_ReporteActivo.Activo_FechaCompra, 
			vw_ReporteActivo.Activo_FechaUso, vw_ReporteActivo.Centro_Costo, vw_ReporteActivo.Factura_Codigo, vw_ReporteActivo.Activo_FechaBaja, 
			vw_ReporteActivo.TipoBajaActivo, vw_ReporteActivo.Caracteristicas, vw_ReporteActivo.UbicacionActual, vw_ReporteActivo.CustodioActual, 
			PardetTipoDepreciacion.Pardet_Descripcion AS TipoDepreciacion, 
			ActivoValor.ActVal_FechaValoracion, ActivoValor.ActVal_Costo, 
			ActivoValor.ActVal_Salvamento, 
			PardetFrecuenciaDepreciacion.Pardet_Descripcion AS FrecuenciaDepreciacion, 
			ActivoValor.ActVal_PeriodosDepreciables, 
			isnull(SUM(DepreciacionDet.Deprec_Valor),0) AS Depreciado, ActVal_Activo, 
			PardetTipoDepreciacion.Pardet_DatoInt1 * 
				case when ActivoValor.ActVal_Activo=1 then 1 else 0 end 
				as FactorTipoDepreciacion
		FROM         vw_ReporteActivo LEFT OUTER JOIN
                      ActivoValor ON vw_ReporteActivo.Activo_Codigo = ActivoValor.Activo_Codigo LEFT OUTER JOIN
                      ParametroDet AS PardetTipoDepreciacion ON ActivoValor.Parame_TipoDepreciacion = PardetTipoDepreciacion.Parame_Codigo AND 
                      ActivoValor.Pardet_TipoDepreciacion = PardetTipoDepreciacion.Pardet_Secuencia LEFT OUTER JOIN
                      ParametroDet AS PardetFrecuenciaDepreciacion ON ActivoValor.Parame_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Parame_Codigo AND 
                      ActivoValor.Pardet_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Pardet_Secuencia LEFT OUTER JOIN
                      DepreciacionDet ON ActivoValor.Activo_Codigo = DepreciacionDet.Activo_Codigo AND 
                      ActivoValor.Parame_TipoDepreciacion = DepreciacionDet.Parame_TipoDepreciacion AND 
                      ActivoValor.Pardet_TipoDepreciacion = DepreciacionDet.Pardet_TipoDepreciacion AND ActivoValor.ActVal_Secuencia = DepreciacionDet.ActVal_Secuencia
		where vw_ReporteActivo.Activo_Codigo= @Activo_Codigo
		GROUP BY vw_ReporteActivo.Activo_Codigo, vw_ReporteActivo.Activo_Serie, vw_ReporteActivo.Grupo, vw_ReporteActivo.Tipo, vw_ReporteActivo.Clase, 
                      vw_ReporteActivo.Activo_CodigoBarra, vw_ReporteActivo.Activo_Descripcion, vw_ReporteActivo.Marca, vw_ReporteActivo.Activo_Modelo, 
                      vw_ReporteActivo.Activo_Observacion, vw_ReporteActivo.Estado_Depreciacion, vw_ReporteActivo.Estado_Activo, 
                      vw_ReporteActivo.Activo_ResponsableMantenimiento, vw_ReporteActivo.Activo_FechaIngreso, vw_ReporteActivo.Activo_FechaCompra, 
                      vw_ReporteActivo.Activo_FechaUso, vw_ReporteActivo.Centro_Costo, vw_ReporteActivo.Factura_Codigo, vw_ReporteActivo.Activo_FechaBaja, 
                      vw_ReporteActivo.TipoBajaActivo, vw_ReporteActivo.Caracteristicas, vw_ReporteActivo.UbicacionActual, vw_ReporteActivo.CustodioActual, 
                      PardetTipoDepreciacion.Pardet_Descripcion, ActivoValor.ActVal_FechaValoracion, ActivoValor.ActVal_Costo, ActivoValor.ActVal_Salvamento, 
                      PardetFrecuenciaDepreciacion.Pardet_Descripcion, ActivoValor.ActVal_PeriodosDepreciables, ActVal_Activo,
                      PardetTipoDepreciacion.Pardet_DatoInt1
		order by PardetTipoDepreciacion.Pardet_Descripcion, ActVal_Activo desc,
			ActVal_FechaValoracion desc
		return 0
	end

	if  @accion='asd' --reporte ficha
	begin
		SELECT     vw_ReporteActivo.Activo_Codigo, vw_ReporteActivo.Activo_Serie, vw_ReporteActivo.Grupo, vw_ReporteActivo.Tipo, vw_ReporteActivo.Clase, 
			vw_ReporteActivo.Activo_CodigoBarra, vw_ReporteActivo.Activo_Descripcion, vw_ReporteActivo.Marca, vw_ReporteActivo.Activo_Modelo, 
			vw_ReporteActivo.Activo_Observacion, vw_ReporteActivo.Estado_Depreciacion, vw_ReporteActivo.Estado_Activo, 
			vw_ReporteActivo.Activo_ResponsableMantenimiento, vw_ReporteActivo.Activo_FechaIngreso, vw_ReporteActivo.Activo_FechaCompra, 
			vw_ReporteActivo.Activo_FechaUso, vw_ReporteActivo.Centro_Costo, vw_ReporteActivo.Factura_Codigo, vw_ReporteActivo.Activo_FechaBaja, 
			vw_ReporteActivo.TipoBajaActivo, vw_ReporteActivo.Caracteristicas, vw_ReporteActivo.UbicacionActual, vw_ReporteActivo.CustodioActual, 
			PardetTipoDepreciacion.Pardet_Descripcion AS TipoDepreciacion, 
			ActivoValor.ActVal_FechaValoracion, ActivoValor.ActVal_Costo, 
			ActivoValor.ActVal_Salvamento, 
			PardetFrecuenciaDepreciacion.Pardet_Descripcion AS FrecuenciaDepreciacion, 
			ActivoValor.ActVal_PeriodosDepreciables, 
			isnull(SUM(DepreciacionDet.Deprec_Valor),0) AS Depreciado, ActVal_Activo, 
			PardetTipoDepreciacion.Pardet_DatoInt1 * 
				case when ActivoValor.ActVal_Activo=1 then 1 else 0 end 
				as FactorTipoDepreciacion
		FROM         vw_ReporteActivo INNER JOIN
                      ActivoValor ON vw_ReporteActivo.Activo_Codigo = ActivoValor.Activo_Codigo INNER JOIN
                      ParametroDet AS PardetTipoDepreciacion ON ActivoValor.Parame_TipoDepreciacion = PardetTipoDepreciacion.Parame_Codigo AND 
                      ActivoValor.Pardet_TipoDepreciacion = PardetTipoDepreciacion.Pardet_Secuencia INNER JOIN
                      ParametroDet AS PardetFrecuenciaDepreciacion ON ActivoValor.Parame_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Parame_Codigo AND 
                      ActivoValor.Pardet_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Pardet_Secuencia LEFT OUTER JOIN
                      DepreciacionDet ON ActivoValor.Activo_Codigo = DepreciacionDet.Activo_Codigo AND 
                      ActivoValor.Parame_TipoDepreciacion = DepreciacionDet.Parame_TipoDepreciacion AND 
                      ActivoValor.Pardet_TipoDepreciacion = DepreciacionDet.Pardet_TipoDepreciacion AND ActivoValor.ActVal_Secuencia = DepreciacionDet.ActVal_Secuencia
		where vw_ReporteActivo.Activo_Codigo= @Activo_Codigo
		GROUP BY vw_ReporteActivo.Activo_Codigo, vw_ReporteActivo.Activo_Serie, vw_ReporteActivo.Grupo, vw_ReporteActivo.Tipo, vw_ReporteActivo.Clase, 
                      vw_ReporteActivo.Activo_CodigoBarra, vw_ReporteActivo.Activo_Descripcion, vw_ReporteActivo.Marca, vw_ReporteActivo.Activo_Modelo, 
                      vw_ReporteActivo.Activo_Observacion, vw_ReporteActivo.Estado_Depreciacion, vw_ReporteActivo.Estado_Activo, 
                      vw_ReporteActivo.Activo_ResponsableMantenimiento, vw_ReporteActivo.Activo_FechaIngreso, vw_ReporteActivo.Activo_FechaCompra, 
                      vw_ReporteActivo.Activo_FechaUso, vw_ReporteActivo.Centro_Costo, vw_ReporteActivo.Factura_Codigo, vw_ReporteActivo.Activo_FechaBaja, 
                      vw_ReporteActivo.TipoBajaActivo, vw_ReporteActivo.Caracteristicas, vw_ReporteActivo.UbicacionActual, vw_ReporteActivo.CustodioActual, 
                      PardetTipoDepreciacion.Pardet_Descripcion, ActivoValor.ActVal_FechaValoracion, ActivoValor.ActVal_Costo, ActivoValor.ActVal_Salvamento, 
                      PardetFrecuenciaDepreciacion.Pardet_Descripcion, ActivoValor.ActVal_PeriodosDepreciables, ActVal_Activo,
                      PardetTipoDepreciacion.Pardet_DatoInt1
		order by PardetTipoDepreciacion.Pardet_Descripcion, ActVal_Activo desc,
			ActVal_FechaValoracion desc
		return 0
	end
	if @accion='rac' --acta entrega custodio
	begin
		select Activo_Codigo, Activo_Serie, Grupo, Tipo, Clase, Activo_CodigoBarra, Activo_Descripcion, Marca, Activo_Modelo, Activo_Observacion, Estado_Depreciacion, Estado_Activo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Centro_Costo, Factura_Codigo, Activo_FechaBaja, TipoBajaActivo, Caracteristicas, UbicacionActual, CustodioActual
		from vw_ReporteActivo
		where  Activo_FechaBaja is null 
		and exists (Select * from ActivoCustodio where ActivoCustodio.ActCus_Activo=1
				and ActivoCustodio.Activo_Codigo=vw_ReporteActivo.Activo_Codigo
				and Emplea_Custodio=@Entida_Custodio) 
		order by UbicacionActual, Activo_Codigo
		return 0
	end
	
	if @accion='racF2' --acta entrega custodio
	begin
		SELECT   *
		FROM         vw_ActaConstacionF2
		where  case when @Pardet_Ubicacion is null then 1
					when Parame_Ubicacion=@Parame_Ubicacion
						and Pardet_Ubicacion=@Pardet_Ubicacion then 1
					else 0 end = 1
			and Parame_PeriodoInventario=@Parame_PeriodoInventario
			and	Pardet_PeriodoInventario=@Pardet_PeriodoInventario
			and case when @SoloInventariados = 0 then 1
					when Pardet_EstadoInventario> 1 then 1
					else 0 end =1
			and Emplea_Custodio=@Entida_Custodio
		order by UbicacionActual, Activo_Codigo
		return 0
	end
	if @accion='racF3' --acta entrega custodio
	begin
		SELECT   *
		FROM         vw_ActaConstatacionF3
		where  case when @Pardet_Ubicacion is null then 1
					when Parame_Ubicacion=@Parame_Ubicacion
						and Pardet_Ubicacion=@Pardet_Ubicacion then 1
					else 0 end = 1
			and Parame_PeriodoInventario=@Parame_PeriodoInventario
			and	Pardet_PeriodoInventario=@Pardet_PeriodoInventario
			and case when @SoloInventariados = 0 then 1
					when Pardet_EstadoInventario> 1 then 1
					else 0 end =1
			and Emplea_Custodio=@Entida_Custodio
		order by UbicacionActual, Activo_Codigo
		return 0
	end
	
	if @accion='racSRI' --acta entrega custodio
	begin
		SELECT   *
		FROM         vw_SRIActaConstatacion
		where  case when @Pardet_Ubicacion is null then 1
					when Parame_Ubicacion=@Parame_Ubicacion
						and Pardet_Ubicacion=@Pardet_Ubicacion then 1
					else 0 end = 1
			and Parame_PeriodoInventario=@Parame_PeriodoInventario
			and	Pardet_PeriodoInventario=@Pardet_PeriodoInventario
			and case when @SoloInventariados = 0 then 1
					when Pardet_EstadoInventario> 1 then 1
					else 0 end =1
			and Emplea_Custodio=@Entida_Custodio
		order by UbicacionActual, Activo_Codigo
		return 0
	end
	if @accion='ccuSRI' --cambio custodio
	begin
		SELECT   CustodioActual,IdCustodioActual, EstadoInv,UbicacionActual,Area,Departamento,Edificio,Direccion,Ciudad,
		Regional,RespRegional,CodigoBarras,Descripcion,Pardet_Descripcion as Marca,Modelo,Serie,Bueno,Regular,Malo,Estado,
		Activo_Codigo	Activo_FechaBaja,Llaves,Parame_Ubicacion,Pardet_Ubicacion,Parame_PeriodoInventario,
		Pardet_PeriodoInventario,Pardet_EstadoInventario,Emplea_Custodio,InvDet_esCambioCustodio,SujetoControl,ActivoFijo,
		FechaCambio
		FROM         vw_SRIActaConstatacion
		where  case when @Pardet_Ubicacion is null then 1
					when Parame_Ubicacion=@Parame_Ubicacion
						and Pardet_Ubicacion=@Pardet_Ubicacion then 1
					else 0 end = 1
			and Parame_PeriodoInventario=@Parame_PeriodoInventario
			and	Pardet_PeriodoInventario=@Pardet_PeriodoInventario
			and case when @SoloInventariados = 0 then 1
					when Pardet_EstadoInventario> 1 then 1
					else 0 end =1
			and Emplea_Custodio=@Entida_Custodio
			and InvDet_esCambioCustodio=1
		order by CodigoBarras
		return 0
	end
	
	if @accion='rb' --reversar baja!
	begin
		set @Activo_FechaBaja =(select Activo_FechaBaja from Activo where Activo_Codigo = @Activo_Codigo) 
		if @Activo_FechaBaja is null
		begin
			raiserror (N'Activo no se encuentra dado de baja.', 16, 1)
			return -1
		end
		
		update Activo set Activo_FechaBaja = null, Parame_TipoBajaActivo= null, Pardet_TipoBajaActivo= null 
		where Activo_Codigo=@Activo_Codigo and Activo_CodigoBarra=@Activo_CodigoBarra
			
		if @Pardet_EstadoDepreciacion is null and (select Pardet_EstadoDepreciacion from Activo where Activo_Codigo = @Activo_Codigo)=1
			set @Pardet_EstadoDepreciacion =1
		
		declare @FrecuenciaDepreciacion nvarchar(10)= (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
		
		if @FrecuenciaDepreciacion = 'Mensual' and @Pardet_FrecuenciaDepreciacion is null
			set @Pardet_FrecuenciaDepreciacion=1
		if @FrecuenciaDepreciacion = 'Diaria' and @Pardet_FrecuenciaDepreciacion is null
			set @Pardet_FrecuenciaDepreciacion=2
			
		if @Pardet_EstadoDepreciacion=1
		begin
			--Es mensual
			if @Pardet_FrecuenciaDepreciacion = 1
			begin
				set @ProximaDep = DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0)
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
				set @AnteriorDep = DATEADD(m,-1,DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0) )
				set @AnteriorDepInt = cast(left(replace(CAST (@AnteriorDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ProximaDep = @Activo_FechaBaja
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
				set @AnteriorDep = DATEADD(d,-1,@Activo_FechaBaja)
				set @AnteriorDepInt = cast(replace(CAST (@AnteriorDep as nvarchar),'-','') as int)
			end
			
			--Recalcular !
			--depreciaciones !
			declare @decimales int
			set  @decimales = (select Pardet_DatoInt1 from dbo.ParametroDet AS pdDep 
						where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1)
				
			--CuentaActivo y cuenta gasto
			select @ctaActivo = pdTipo.Pardet_DatoStr1, @ctaGasto = pdTipo.Pardet_DatoStr2 
			from Activo act inner join ParametroDet as pdClase on  act.Parame_ClaseActivo = pdClase.Parame_Codigo
				and act.Pardet_ClaseActivo =pdClase.Pardet_Secuencia 
				inner join ParametroDet pdTipo on pdClase.Parame_Padre = pdTipo.Parame_Codigo and
				pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia
			where Activo_Codigo=@Activo_Codigo
			
			--CentroDeCosto (definir CC o nivel de ubicacion)
			select @centroCosto = pdCentroCosto.Pardet_DatoStr1
			from Activo act inner join ParametroDet as pdCentroCosto on  act.Parame_CentroCosto = pdCentroCosto.Parame_Codigo
				and act.Pardet_CentroCosto =pdCentroCosto.Pardet_Secuencia 
			where Activo_Codigo=@Activo_Codigo
			
			--Ubicacion
			declare @ubicacion nvarchar (250)=dbo.Fnc_UbicacionActual (@Activo_Codigo)
			if @ubicacion is null
				set @ubicacion ='error de ubicacion'

			declare @ActVal_Secuencia int 
			declare @valorDepreciable decimal (18,8)
			declare @valorDepreciacion decimal (18,8)
			declare @valorDeprecAcum decimal (18,8)
			declare @numDeprec int 
			
			--Tributaria:
			select @ActVal_Secuencia=ActVal_Secuencia,@valorDepreciacion =Deprec_Valor, 
					@valorDeprecAcum= Deprec_DepreciacionAcumulada, @numDeprec=Deprec_PeriodosDepreciados
			from DepreciacionDet 
			where Activo_Codigo=@Activo_Codigo and Deprec_Codigo=@AnteriorDepInt and Pardet_TipoDepreciacion=1	
			
			if @ActVal_Secuencia<>(select 	ActVal_Secuencia	
									from ActivoValor 
									where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1)
			begin
				raiserror (N'Ultima depreciacion no coincide con ultima valoracion %i', 16, 1, @ActualDep)
				return -1
			end
			
			select 	@periodosDepreciables=	ActVal_PeriodosDepreciables, @valorDepreciable= ActVal_Costo-ActVal_Salvamento	
			from ActivoValor 
			where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=1					
			
			set @valorDeprecAcum = @valorDepreciacion +@valorDeprecAcum		
			set @numDeprec =@numDeprec+1
			
			
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
				set @ProximaDep = DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0)
				set @ProximaDepInt = cast(left(replace(CAST (@ProximaDep as nvarchar),'-',''),6) as int)
				set @AnteriorDep = DATEADD(m,-1,DATEADD(m, DATEDIFF(m, 0, @Activo_FechaBaja), 0) )
				set @AnteriorDepInt = cast(left(replace(CAST (@AnteriorDep as nvarchar),'-',''),6) as int)
			end
			
			--Es diaria
			if @Pardet_FrecuenciaDepreciacion = 2
			begin
				set @ProximaDep = @Activo_FechaBaja
				set @ProximaDepInt = cast(replace(CAST (@ProximaDep as nvarchar),'-','') as int)
				set @AnteriorDep = DATEADD(d,-1,@Activo_FechaBaja)
				set @AnteriorDepInt = cast(replace(CAST (@AnteriorDep as nvarchar),'-','') as int)
			end
			
			select @ActVal_Secuencia=ActVal_Secuencia,@valorDepreciacion =Deprec_Valor, 
					@valorDeprecAcum= Deprec_DepreciacionAcumulada, @numDeprec=Deprec_PeriodosDepreciados
			from DepreciacionDet 
			where Activo_Codigo=@Activo_Codigo and Deprec_Codigo=@AnteriorDepInt and Pardet_TipoDepreciacion=2	
			
			if @ActVal_Secuencia<>(select 	ActVal_Secuencia	
									from ActivoValor 
									where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2)
			begin
				raiserror (N'Ultima depreciacion no coincide con ultima valoracion %i', 16, 1, @ActualDep)
				return -1
			end
			
			select 	@periodosDepreciables=	ActVal_PeriodosDepreciables, @valorDepreciable= ActVal_Costo-ActVal_Salvamento	
			from ActivoValor 
			where Activo_Codigo=@Activo_Codigo and ActVal_Activo=1 and Pardet_TipoDepreciacion=2					
			
			set @valorDeprecAcum = @valorDepreciacion +@valorDeprecAcum		
			set @numDeprec =@numDeprec+1
				
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
		return 0 
	end
	
	if @accion='fb'--Find Bajas
	begin
		select Activo_Codigo, Activo_CodigoBarra, Activo_CodigoBarraCruce, Activo_CodigoAux, Activo_Serie, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Activo_FechaGarantia, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo
			from Activo
		where TraBaj_Codigo= @TraBaj_Codigo
		return 0
	end
end
