IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Parametro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Parametro]
go
Create Procedure proc_Parametro
(	@accion	char(1), 
	@Parame_Codigo	int=null, 
	@Parame_Descripcion	nvarchar(100)=null, 
	@Parame_Modificable	bit=null, 
	@Parame_Padre	int=null, 
	@Parame_esImagen	bit=null, 
	@Parame_LeyendaDatoStr1	nvarchar(50)=null, 
	@Parame_LeyendaDatoStr2	nvarchar(50)=null, 
	@Parame_LeyendaDatoStr3	nvarchar(50)=null, 
	@Parame_LeyendaDatoInt1	nvarchar(50)=null, 
	@Parame_CtaCtble1	nvarchar(50)=null, 
	@Parame_CtaCtble2	nvarchar(50)=null, 
	@Parame_LeyendaDatoImg1	nvarchar(50)=null, 
	@Parame_LeyendaDatoDec1	nvarchar(50)=null, 
	@Parame_LeyendaLeyenda	nvarchar(50)=null, 
	@Parame_LeyendaDatoBit1	nvarchar(50)=null)
as
begin
	if @accion='i'
	begin
		insert into Parametro 
			(Parame_Codigo, Parame_Descripcion, Parame_Modificable, Parame_Padre, Parame_esImagen, Parame_LeyendaDatoStr1, Parame_LeyendaDatoStr2, Parame_LeyendaDatoStr3, Parame_LeyendaDatoInt1, Parame_CtaCtble1, Parame_CtaCtble2, Parame_LeyendaDatoImg1, Parame_LeyendaDatoDec1, Parame_LeyendaLeyenda, Parame_LeyendaDatoBit1)
		values (@Parame_Codigo, @Parame_Descripcion, @Parame_Modificable, @Parame_Padre, @Parame_esImagen, @Parame_LeyendaDatoStr1, @Parame_LeyendaDatoStr2, @Parame_LeyendaDatoStr3, @Parame_LeyendaDatoInt1, @Parame_CtaCtble1, @Parame_CtaCtble2, @Parame_LeyendaDatoImg1, @Parame_LeyendaDatoDec1, @Parame_LeyendaLeyenda, @Parame_LeyendaDatoBit1)
		return 0
	end
	if @accion='m'
	begin
		update Parametro
			set Parame_Descripcion= @Parame_Descripcion, Parame_Modificable= @Parame_Modificable, Parame_Padre= @Parame_Padre, Parame_esImagen= @Parame_esImagen, Parame_LeyendaDatoStr1= @Parame_LeyendaDatoStr1, Parame_LeyendaDatoStr2= @Parame_LeyendaDatoStr2, Parame_LeyendaDatoStr3= @Parame_LeyendaDatoStr3, Parame_LeyendaDatoInt1= @Parame_LeyendaDatoInt1, Parame_CtaCtble1= @Parame_CtaCtble1, Parame_CtaCtble2= @Parame_CtaCtble2, Parame_LeyendaDatoImg1= @Parame_LeyendaDatoImg1, Parame_LeyendaDatoDec1= @Parame_LeyendaDatoDec1, Parame_LeyendaLeyenda= @Parame_LeyendaLeyenda, Parame_LeyendaDatoBit1= @Parame_LeyendaDatoBit1
		where Parame_Codigo= @Parame_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Parame_Codigo, Parame_Descripcion, Parame_Modificable, Parame_Padre, Parame_esImagen, Parame_LeyendaDatoStr1, Parame_LeyendaDatoStr2, Parame_LeyendaDatoStr3, Parame_LeyendaDatoInt1, Parame_CtaCtble1, Parame_CtaCtble2, Parame_LeyendaDatoImg1, Parame_LeyendaDatoDec1, Parame_LeyendaLeyenda, Parame_LeyendaDatoBit1
			from Parametro
		where Parame_Codigo= @Parame_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Parametro
		where Parame_Codigo= @Parame_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Parame_Codigo, Parame_Descripcion, Parame_Modificable, Parame_Padre, Parame_esImagen, Parame_LeyendaDatoStr1, Parame_LeyendaDatoStr2, Parame_LeyendaDatoStr3, Parame_LeyendaDatoInt1, Parame_CtaCtble1, Parame_CtaCtble2, Parame_LeyendaDatoImg1, Parame_LeyendaDatoDec1, Parame_LeyendaLeyenda, Parame_LeyendaDatoBit1
			from Parametro
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_ParametroDet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_ParametroDet]
go
Create Procedure proc_ParametroDet
(	@accion	char(1), 
	@Parame_Codigo	int=null, 
	@Pardet_Secuencia	int=null, 
	@Pardet_Descripcion	nvarchar(150)=null, 
	@Pardet_DatoStr1	nvarchar(200)=null, 
	@Pardet_DatoStr2	nvarchar(1500)=null, 
	@Pardet_DatoStr3	nvarchar(1500)=null, 
	@Pardet_DatoInt1	int=null, 
	@Pardet_Modificable	bit=null, 
	@Parame_Padre	int=null, 
	@Pardet_Padre	int=null, 
	@Pardet_Imagen	image=null, 
	@Pardet_Leyenda	text=null, 
	@CtaCtb_CtaCtble1	varchar(11)=null, 
	@CtaCtb_CtaCtble2	varchar(11)=null, 
	@Pardet_DatoDec1	decimal(18,4)=null, 
	@Pardet_DatoBit1	bit=null)
as
begin
	if @accion='i'
	begin
		insert into ParametroDet 
			(Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, Pardet_Imagen, Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1)
		values (@Parame_Codigo, @Pardet_Secuencia, @Pardet_Descripcion, @Pardet_DatoStr1, @Pardet_DatoStr2, @Pardet_DatoStr3, @Pardet_DatoInt1, @Pardet_Modificable, @Parame_Padre, @Pardet_Padre, @Pardet_Imagen, @Pardet_Leyenda, @CtaCtb_CtaCtble1, @CtaCtb_CtaCtble2, @Pardet_DatoDec1, @Pardet_DatoBit1)
		return 0
	end
	if @accion='m'
	begin
		update ParametroDet
			set Pardet_Descripcion= @Pardet_Descripcion, Pardet_DatoStr1= @Pardet_DatoStr1, Pardet_DatoStr2= @Pardet_DatoStr2, Pardet_DatoStr3= @Pardet_DatoStr3, Pardet_DatoInt1= @Pardet_DatoInt1, Pardet_Modificable= @Pardet_Modificable, Parame_Padre= @Parame_Padre, Pardet_Padre= @Pardet_Padre, Pardet_Imagen= @Pardet_Imagen, Pardet_Leyenda= @Pardet_Leyenda, CtaCtb_CtaCtble1= @CtaCtb_CtaCtble1, CtaCtb_CtaCtble2= @CtaCtb_CtaCtble2, Pardet_DatoDec1= @Pardet_DatoDec1, Pardet_DatoBit1= @Pardet_DatoBit1
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, Pardet_Imagen, Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
			from ParametroDet
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete ParametroDet
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, Pardet_Imagen, Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
			from ParametroDet
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Inventario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Inventario]
go
Create Procedure proc_Inventario
(	@accion	char(1), 
	@Parame_Ubicacion	int=null, 
	@Pardet_Ubicacion	int=null, 
	@Parame_PeriodoInventario	int=null, 
	@Pardet_PeriodoInventario	int=null, 
	@Invent_Descripcion	nvarchar(150)=null, 
	@Invent_FechaDesde	date=null, 
	@Invent_FechaHasta	date=null)
as
begin
	if @accion='i'
	begin
		insert into Inventario 
			(Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Invent_Descripcion, Invent_FechaDesde, Invent_FechaHasta)
		values (@Parame_Ubicacion, @Pardet_Ubicacion, @Parame_PeriodoInventario, @Pardet_PeriodoInventario, @Invent_Descripcion, @Invent_FechaDesde, @Invent_FechaHasta)
		return 0
	end
	if @accion='m'
	begin
		update Inventario
			set Invent_Descripcion= @Invent_Descripcion, Invent_FechaDesde= @Invent_FechaDesde, Invent_FechaHasta= @Invent_FechaHasta
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario
		return 0
	end
	if @accion='c'
	begin
		select Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Invent_Descripcion, Invent_FechaDesde, Invent_FechaHasta
			from Inventario
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario
		return 0
	end
	if @accion='e'
	begin
		delete Inventario
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario
		return 0
	end
	if @accion='f'
	begin
		select Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Invent_Descripcion, Invent_FechaDesde, Invent_FechaHasta
			from Inventario
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_InventarioDet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_InventarioDet]
go
Create Procedure proc_InventarioDet
(	@accion	char(1), 
	@Parame_Ubicacion	int=null, 
	@Pardet_Ubicacion	int=null, 
	@Parame_PeriodoInventario	int=null, 
	@Pardet_PeriodoInventario	int=null, 
	@Activo_Codigo	int=null, 
	@InvDet_Observacion	nvarchar(350)=null, 
	@InvDet_esCambioUbicacion	bit=null, 
	@ActUbi_SecuenciaAnterior	int=null, 
	@ActUbi_SecuenciaActual	int=null, 
	@InvDet_esCambioCustodio	bit=null, 
	@ActCus_SecuenciaAnterior	int=null, 
	@ActCus_SecuenciaActual	int=null, 
	@Parame_EstadoInventario	int=null, 
	@Pardet_EstadoInventario	int=null, 
	@InvDet_Activo	bit=null)
as
begin
	if @accion='i'
	begin
		insert into InventarioDet 
			(Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Activo_Codigo, InvDet_Observacion, InvDet_esCambioUbicacion, ActUbi_SecuenciaAnterior, ActUbi_SecuenciaActual, InvDet_esCambioCustodio, ActCus_SecuenciaAnterior, ActCus_SecuenciaActual, Parame_EstadoInventario, Pardet_EstadoInventario, InvDet_Activo)
		values (@Parame_Ubicacion, @Pardet_Ubicacion, @Parame_PeriodoInventario, @Pardet_PeriodoInventario, @Activo_Codigo, @InvDet_Observacion, @InvDet_esCambioUbicacion, @ActUbi_SecuenciaAnterior, @ActUbi_SecuenciaActual, @InvDet_esCambioCustodio, @ActCus_SecuenciaAnterior, @ActCus_SecuenciaActual, @Parame_EstadoInventario, @Pardet_EstadoInventario, @InvDet_Activo)
		return 0
	end
	if @accion='m'
	begin
		update InventarioDet
			set InvDet_Observacion= @InvDet_Observacion, InvDet_esCambioUbicacion= @InvDet_esCambioUbicacion, ActUbi_SecuenciaAnterior= @ActUbi_SecuenciaAnterior, ActUbi_SecuenciaActual= @ActUbi_SecuenciaActual, InvDet_esCambioCustodio= @InvDet_esCambioCustodio, ActCus_SecuenciaAnterior= @ActCus_SecuenciaAnterior, ActCus_SecuenciaActual= @ActCus_SecuenciaActual, Parame_EstadoInventario= @Parame_EstadoInventario, Pardet_EstadoInventario= @Pardet_EstadoInventario, InvDet_Activo= @InvDet_Activo
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Activo_Codigo, InvDet_Observacion, InvDet_esCambioUbicacion, ActUbi_SecuenciaAnterior, ActUbi_SecuenciaActual, InvDet_esCambioCustodio, ActCus_SecuenciaAnterior, ActCus_SecuenciaActual, Parame_EstadoInventario, Pardet_EstadoInventario, InvDet_Activo
			from InventarioDet
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete InventarioDet
		where Parame_Ubicacion= @Parame_Ubicacion and Pardet_Ubicacion= @Pardet_Ubicacion and Parame_PeriodoInventario= @Parame_PeriodoInventario and Pardet_PeriodoInventario= @Pardet_PeriodoInventario and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Parame_Ubicacion, Pardet_Ubicacion, Parame_PeriodoInventario, Pardet_PeriodoInventario, Activo_Codigo, InvDet_Observacion, InvDet_esCambioUbicacion, ActUbi_SecuenciaAnterior, ActUbi_SecuenciaActual, InvDet_esCambioCustodio, ActCus_SecuenciaAnterior, ActCus_SecuenciaActual, Parame_EstadoInventario, Pardet_EstadoInventario, InvDet_Activo
			from InventarioDet
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_ActivoValor]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_ActivoValor]
go
Create Procedure proc_ActivoValor
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@Parame_TipoDepreciacion	int=null, 
	@Pardet_TipoDepreciacion	int=null, 
	@ActVal_Secuencia	int=null, 
	@Parame_TipoValorizacion	int=null, 
	@Pardet_TipoValorizacion	int=null, 
	@ActVal_Costo	money=null, 
	@ActVal_Salvamento	money=null, 
	@ActVal_PeriodosDepreciables	int=null, 
	@ActVal_FechaValoracion	date=null, 
	@Entida_Perito	int=null, 
	@ActVal_Activo	bit=null, 
	@ActCom_Secuencia	int=null, 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null)
as
begin
	if @accion='i'
	begin
		insert into ActivoValor 
			(Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Parame_TipoValorizacion, Pardet_TipoValorizacion, ActVal_Costo, ActVal_Salvamento, ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion)
		values (@Activo_Codigo, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, @ActVal_Secuencia, @Parame_TipoValorizacion, @Pardet_TipoValorizacion, @ActVal_Costo, @ActVal_Salvamento, @ActVal_PeriodosDepreciables, @ActVal_FechaValoracion, @Entida_Perito, @ActVal_Activo, @ActCom_Secuencia, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion)
		return 0
	end
	if @accion='m'
	begin
		update ActivoValor
			set Parame_TipoValorizacion= @Parame_TipoValorizacion, Pardet_TipoValorizacion= @Pardet_TipoValorizacion, ActVal_Costo= @ActVal_Costo, ActVal_Salvamento= @ActVal_Salvamento, ActVal_PeriodosDepreciables= @ActVal_PeriodosDepreciables, ActVal_FechaValoracion= @ActVal_FechaValoracion, Entida_Perito= @Entida_Perito, ActVal_Activo= @ActVal_Activo, ActCom_Secuencia= @ActCom_Secuencia, Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion
		where Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Parame_TipoValorizacion, Pardet_TipoValorizacion, ActVal_Costo, ActVal_Salvamento, ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion
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
		select Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Parame_TipoValorizacion, Pardet_TipoValorizacion, ActVal_Costo, ActVal_Salvamento, ActVal_PeriodosDepreciables, ActVal_FechaValoracion, Entida_Perito, ActVal_Activo, ActCom_Secuencia, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion
			from ActivoValor
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Activo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Activo]
go
Create Procedure proc_Activo
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@Activo_Serie	nvarchar(50)=null, 
	@Parame_GrupoActivo	int=null, 
	@Pardet_GrupoActivo	int=null, 
	@Parame_Tipoactivo	int=null, 
	@Pardet_Tipoactivo	int=null, 
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
	@Parame_CentroCosto	int=null, 
	@Pardet_CentroCosto	int=null, 
	@Factura_Codigo	int=null, 
	@Activo_FechaBaja	date=null, 
	@Parame_TipoBajaActivo	int=null, 
	@Pardet_TipoBajaActivo	int=null, 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null)
as
begin
	if @accion='i'
	begin
		insert into Activo 
			(Activo_Codigo, Activo_Serie, Parame_GrupoActivo, Pardet_GrupoActivo, Parame_Tipoactivo, Pardet_Tipoactivo, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Activo_Imagen, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion)
		values (@Activo_Codigo, @Activo_Serie, @Parame_GrupoActivo, @Pardet_GrupoActivo, @Parame_Tipoactivo, @Pardet_Tipoactivo, @Parame_ClaseActivo, @Pardet_ClaseActivo, @Activo_Descripcion, @Parame_Marca, @Pardet_Marca, @Activo_Modelo, @Activo_Observacion, @Activo_Imagen, @Parame_EstadoDepreciacion, @Pardet_EstadoDepreciacion, @Parame_EstadoActivo, @Pardet_EstadoActivo, @Activo_ResponsableMantenimiento, @Activo_FechaIngreso, @Activo_FechaCompra, @Activo_FechaUso, @Parame_CentroCosto, @Pardet_CentroCosto, @Factura_Codigo, @Activo_FechaBaja, @Parame_TipoBajaActivo, @Pardet_TipoBajaActivo, @Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion)
		return 0
	end
	if @accion='m'
	begin
		update Activo
			set Activo_Serie= @Activo_Serie, Parame_GrupoActivo= @Parame_GrupoActivo, Pardet_GrupoActivo= @Pardet_GrupoActivo, Parame_Tipoactivo= @Parame_Tipoactivo, Pardet_Tipoactivo= @Pardet_Tipoactivo, Parame_ClaseActivo= @Parame_ClaseActivo, Pardet_ClaseActivo= @Pardet_ClaseActivo, Activo_Descripcion= @Activo_Descripcion, Parame_Marca= @Parame_Marca, Pardet_Marca= @Pardet_Marca, Activo_Modelo= @Activo_Modelo, Activo_Observacion= @Activo_Observacion, Activo_Imagen= @Activo_Imagen, Parame_EstadoDepreciacion= @Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion= @Pardet_EstadoDepreciacion, Parame_EstadoActivo= @Parame_EstadoActivo, Pardet_EstadoActivo= @Pardet_EstadoActivo, Activo_ResponsableMantenimiento= @Activo_ResponsableMantenimiento, Activo_FechaIngreso= @Activo_FechaIngreso, Activo_FechaCompra= @Activo_FechaCompra, Activo_FechaUso= @Activo_FechaUso, Parame_CentroCosto= @Parame_CentroCosto, Pardet_CentroCosto= @Pardet_CentroCosto, Factura_Codigo= @Factura_Codigo, Activo_FechaBaja= @Activo_FechaBaja, Parame_TipoBajaActivo= @Parame_TipoBajaActivo, Pardet_TipoBajaActivo= @Pardet_TipoBajaActivo, Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion
		where Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, Activo_Serie, Parame_GrupoActivo, Pardet_GrupoActivo, Parame_Tipoactivo, Pardet_Tipoactivo, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Activo_Imagen, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion
			from Activo
		where Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Activo
		where Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, Activo_Serie, Parame_GrupoActivo, Pardet_GrupoActivo, Parame_Tipoactivo, Pardet_Tipoactivo, Parame_ClaseActivo, Pardet_ClaseActivo, Activo_Descripcion, Parame_Marca, Pardet_Marca, Activo_Modelo, Activo_Observacion, Activo_Imagen, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion, Parame_EstadoActivo, Pardet_EstadoActivo, Activo_ResponsableMantenimiento, Activo_FechaIngreso, Activo_FechaCompra, Activo_FechaUso, Parame_CentroCosto, Pardet_CentroCosto, Factura_Codigo, Activo_FechaBaja, Parame_TipoBajaActivo, Pardet_TipoBajaActivo, Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion
			from Activo
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Auditoria]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Auditoria]
go
Create Procedure proc_Auditoria
(	@accion	char(1), 
	@Usuari_Codigo	char(18)=null, 
	@Parame_Opciones	int=null, 
	@Pardet_Opciones	int=null, 
	@Audito_Secuencia	int=null, 
	@Audito_Descripcion	nvarchar(200)=null, 
	@Audito_FechaHora	datetime=null, 
	@Parame_TipoAccion	int=null, 
	@Pardet_TipoAccion	int=null)
as
begin
	if @accion='i'
	begin
		insert into Auditoria 
			(Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Audito_Secuencia, Audito_Descripcion, Audito_FechaHora, Parame_TipoAccion, Pardet_TipoAccion)
		values (@Usuari_Codigo, @Parame_Opciones, @Pardet_Opciones, @Audito_Secuencia, @Audito_Descripcion, @Audito_FechaHora, @Parame_TipoAccion, @Pardet_TipoAccion)
		return 0
	end
	if @accion='m'
	begin
		update Auditoria
			set Audito_Descripcion= @Audito_Descripcion, Audito_FechaHora= @Audito_FechaHora, Parame_TipoAccion= @Parame_TipoAccion, Pardet_TipoAccion= @Pardet_TipoAccion
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones and Audito_Secuencia= @Audito_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Audito_Secuencia, Audito_Descripcion, Audito_FechaHora, Parame_TipoAccion, Pardet_TipoAccion
			from Auditoria
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones and Audito_Secuencia= @Audito_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete Auditoria
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones and Audito_Secuencia= @Audito_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Audito_Secuencia, Audito_Descripcion, Audito_FechaHora, Parame_TipoAccion, Pardet_TipoAccion
			from Auditoria
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Restriccion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Restriccion]
go
Create Procedure proc_Restriccion
(	@accion	char(1), 
	@Usuari_Codigo	char(18)=null, 
	@Parame_Opciones	int=null, 
	@Pardet_Opciones	int=null, 
	@Restri_Lectura	bit=null, 
	@Restri_Ingreso	bit=null, 
	@Restri_Modificacion	bit=null, 
	@Restri_Eliminacion	bit=null, 
	@Restri_Impresion	bit=null, 
	@Restri_VerConfidencial	bit=null, 
	@Restri_Favorito	bit=null)
as
begin
	if @accion='i'
	begin
		insert into Restriccion 
			(Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Restri_Lectura, Restri_Ingreso, Restri_Modificacion, Restri_Eliminacion, Restri_Impresion, Restri_VerConfidencial, Restri_Favorito)
		values (@Usuari_Codigo, @Parame_Opciones, @Pardet_Opciones, @Restri_Lectura, @Restri_Ingreso, @Restri_Modificacion, @Restri_Eliminacion, @Restri_Impresion, @Restri_VerConfidencial, @Restri_Favorito)
		return 0
	end
	if @accion='m'
	begin
		update Restriccion
			set Restri_Lectura= @Restri_Lectura, Restri_Ingreso= @Restri_Ingreso, Restri_Modificacion= @Restri_Modificacion, Restri_Eliminacion= @Restri_Eliminacion, Restri_Impresion= @Restri_Impresion, Restri_VerConfidencial= @Restri_VerConfidencial, Restri_Favorito= @Restri_Favorito
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones
		return 0
	end
	if @accion='c'
	begin
		select Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Restri_Lectura, Restri_Ingreso, Restri_Modificacion, Restri_Eliminacion, Restri_Impresion, Restri_VerConfidencial, Restri_Favorito
			from Restriccion
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones
		return 0
	end
	if @accion='e'
	begin
		delete Restriccion
		where Usuari_Codigo= @Usuari_Codigo and Parame_Opciones= @Parame_Opciones and Pardet_Opciones= @Pardet_Opciones
		return 0
	end
	if @accion='f'
	begin
		select Usuari_Codigo, Parame_Opciones, Pardet_Opciones, Restri_Lectura, Restri_Ingreso, Restri_Modificacion, Restri_Eliminacion, Restri_Impresion, Restri_VerConfidencial, Restri_Favorito
			from Restriccion
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Usuario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Usuario]
go
Create Procedure proc_Usuario
(	@accion	char(1), 
	@Usuari_Codigo	char(18)=null, 
	@Usuari_Descripcion	varchar(30)=null, 
	@Usuari_Password	varbinary=null, 
	@Usuari_Mensaje	text=null, 
	@Usuari_RegEntSal	bit=null, 
	@Usuari_RegIngModEli	bit=null, 
	@Usuari_RegImp	bit=null, 
	@Usuari_RegConfidencial	bit=null, 
	@Entida_Empleado	int=null, 
	@Usuari_CambiarContrasena	bit=null, 
	@Usuari_Activo	bit=null, 
	@Parame_Ubicacion	int=null, 
	@Pardet_Ubicacion	int=null)
as
begin
	if @accion='i'
	begin
		insert into Usuario 
			(Usuari_Codigo, Usuari_Descripcion, Usuari_Password, Usuari_Mensaje, Usuari_RegEntSal, Usuari_RegIngModEli, Usuari_RegImp, Usuari_RegConfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion)
		values (@Usuari_Codigo, @Usuari_Descripcion, @Usuari_Password, @Usuari_Mensaje, @Usuari_RegEntSal, @Usuari_RegIngModEli, @Usuari_RegImp, @Usuari_RegConfidencial, @Entida_Empleado, @Usuari_CambiarContrasena, @Usuari_Activo, @Parame_Ubicacion, @Pardet_Ubicacion)
		return 0
	end
	if @accion='m'
	begin
		update Usuario
			set Usuari_Descripcion= @Usuari_Descripcion, Usuari_Password= @Usuari_Password, Usuari_Mensaje= @Usuari_Mensaje, Usuari_RegEntSal= @Usuari_RegEntSal, Usuari_RegIngModEli= @Usuari_RegIngModEli, Usuari_RegImp= @Usuari_RegImp, Usuari_RegConfidencial= @Usuari_RegConfidencial, Entida_Empleado= @Entida_Empleado, Usuari_CambiarContrasena= @Usuari_CambiarContrasena, Usuari_Activo= @Usuari_Activo, Parame_Ubicacion= @Parame_Ubicacion, Pardet_Ubicacion= @Pardet_Ubicacion
		where Usuari_Codigo= @Usuari_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Usuari_Codigo, Usuari_Descripcion, Usuari_Password, Usuari_Mensaje, Usuari_RegEntSal, Usuari_RegIngModEli, Usuari_RegImp, Usuari_RegConfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion
			from Usuario
		where Usuari_Codigo= @Usuari_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Usuario
		where Usuari_Codigo= @Usuari_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Usuari_Codigo, Usuari_Descripcion, Usuari_Password, Usuari_Mensaje, Usuari_RegEntSal, Usuari_RegIngModEli, Usuari_RegImp, Usuari_RegConfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion
			from Usuario
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Depreciacion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Depreciacion]
go
Create Procedure proc_Depreciacion
(	@accion	char(1), 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null, 
	@Deprec_Codigo	nvarchar(50)=null, 
	@Parame_TipoActivo	int=null, 
	@Pardet_TipoActivo	int=null, 
	@Parame_ClaseActivo	int=null, 
	@Pardet_ClaseActivo	int=null, 
	@Parame_GrupoActivo	int=null, 
	@Pardet_GrupoActivo	int=null, 
	@Deprec_Observacion	nvarchar(350)=null)
as
begin
	if @accion='i'
	begin
		insert into Depreciacion 
			(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Deprec_Observacion)
		values (@Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo, @Parame_TipoActivo, @Pardet_TipoActivo, @Parame_ClaseActivo, @Pardet_ClaseActivo, @Parame_GrupoActivo, @Pardet_GrupoActivo, @Deprec_Observacion)
		return 0
	end
	if @accion='m'
	begin
		update Depreciacion
			set Deprec_Observacion= @Deprec_Observacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo
		return 0
	end
	if @accion='c'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Deprec_Observacion
			from Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo
		return 0
	end
	if @accion='e'
	begin
		delete Depreciacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo
		return 0
	end
	if @accion='f'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Deprec_Observacion
			from Depreciacion
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_ActivoCustodio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_ActivoCustodio]
go
Create Procedure proc_ActivoCustodio
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@ActCus_Secuencia	int=null, 
	@ActCus_Activo	bit=null, 
	@ActCus_esAprobadoNuevoCustodio	bit=null, 
	@ActCus_FechaDesde	date=null, 
	@ActCus_FechaHasta	date=null, 
	@Emplea_Custodio	int=null, 
	@ActCus_Observacion	nvarchar(350)=null)
as
begin
	if @accion='i'
	begin
		insert into ActivoCustodio 
			(Activo_Codigo, ActCus_Secuencia, ActCus_Activo, ActCus_esAprobadoNuevoCustodio, ActCus_FechaDesde, ActCus_FechaHasta, Emplea_Custodio, ActCus_Observacion)
		values (@Activo_Codigo, @ActCus_Secuencia, @ActCus_Activo, @ActCus_esAprobadoNuevoCustodio, @ActCus_FechaDesde, @ActCus_FechaHasta, @Emplea_Custodio, @ActCus_Observacion)
		return 0
	end
	if @accion='m'
	begin
		update ActivoCustodio
			set ActCus_Activo= @ActCus_Activo, ActCus_esAprobadoNuevoCustodio= @ActCus_esAprobadoNuevoCustodio, ActCus_FechaDesde= @ActCus_FechaDesde, ActCus_FechaHasta= @ActCus_FechaHasta, Emplea_Custodio= @Emplea_Custodio, ActCus_Observacion= @ActCus_Observacion
		where Activo_Codigo= @Activo_Codigo and ActCus_Secuencia= @ActCus_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, ActCus_Secuencia, ActCus_Activo, ActCus_esAprobadoNuevoCustodio, ActCus_FechaDesde, ActCus_FechaHasta, Emplea_Custodio, ActCus_Observacion
			from ActivoCustodio
		where Activo_Codigo= @Activo_Codigo and ActCus_Secuencia= @ActCus_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete ActivoCustodio
		where Activo_Codigo= @Activo_Codigo and ActCus_Secuencia= @ActCus_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, ActCus_Secuencia, ActCus_Activo, ActCus_esAprobadoNuevoCustodio, ActCus_FechaDesde, ActCus_FechaHasta, Emplea_Custodio, ActCus_Observacion
			from ActivoCustodio
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_sysdiagrams]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_sysdiagrams]
go
Create Procedure proc_sysdiagrams
(	@accion	char(1), 
	@name	nvarchar(128)=null, 
	@principal_id	int=null, 
	@diagram_id	int=null, 
	@version	int=null, 
	@definition	varbinary=null)
as
begin
	if @accion='i'
	begin
		insert into sysdiagrams 
			(name, principal_id, diagram_id, version, definition)
		values (@name, @principal_id, @diagram_id, @version, @definition)
		return 0
	end
	if @accion='m'
	begin
		update sysdiagrams
			set name= @name, principal_id= @principal_id, version= @version, definition= @definition
		where diagram_id= @diagram_id
		return 0
	end
	if @accion='c'
	begin
		select name, principal_id, diagram_id, version, definition
			from sysdiagrams
		where diagram_id= @diagram_id
		return 0
	end
	if @accion='e'
	begin
		delete sysdiagrams
		where diagram_id= @diagram_id
		return 0
	end
	if @accion='f'
	begin
		select name, principal_id, diagram_id, version, definition
			from sysdiagrams
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_DepreciacionDet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_DepreciacionDet]
go
Create Procedure proc_DepreciacionDet
(	@accion	char(1), 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null, 
	@Deprec_Codigo	nvarchar(50)=null, 
	@Parame_TipoActivo	int=null, 
	@Pardet_TipoActivo	int=null, 
	@Parame_ClaseActivo	int=null, 
	@Pardet_ClaseActivo	int=null, 
	@Parame_GrupoActivo	int=null, 
	@Pardet_GrupoActivo	int=null, 
	@Activo_Codigo	int=null, 
	@Parame_TipoDepreciacion	int=null, 
	@Pardet_TipoDepreciacion	int=null, 
	@ActVal_Secuencia	int=null, 
	@Deprec_Valor	money=null, 
	@Deprec_CtaActivoFijo	nvarchar(50)=null, 
	@Deprec_CtaCentroCosto	nvarchar(50)=null, 
	@Deprec_CtaGasto	nvarchar(50)=null)
as
begin
	if @accion='i'
	begin
		insert into DepreciacionDet 
			(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto)
		values (@Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, @Deprec_Codigo, @Parame_TipoActivo, @Pardet_TipoActivo, @Parame_ClaseActivo, @Pardet_ClaseActivo, @Parame_GrupoActivo, @Pardet_GrupoActivo, @Activo_Codigo, @Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, @ActVal_Secuencia, @Deprec_Valor, @Deprec_CtaActivoFijo, @Deprec_CtaCentroCosto, @Deprec_CtaGasto)
		return 0
	end
	if @accion='m'
	begin
		update DepreciacionDet
			set Deprec_Valor= @Deprec_Valor, Deprec_CtaActivoFijo= @Deprec_CtaActivoFijo, Deprec_CtaCentroCosto= @Deprec_CtaCentroCosto, Deprec_CtaGasto= @Deprec_CtaGasto
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo and Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto
			from DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo and Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion and Deprec_Codigo= @Deprec_Codigo and Parame_TipoActivo= @Parame_TipoActivo and Pardet_TipoActivo= @Pardet_TipoActivo and Parame_ClaseActivo= @Parame_ClaseActivo and Pardet_ClaseActivo= @Pardet_ClaseActivo and Parame_GrupoActivo= @Parame_GrupoActivo and Pardet_GrupoActivo= @Pardet_GrupoActivo and Activo_Codigo= @Activo_Codigo and Parame_TipoDepreciacion= @Parame_TipoDepreciacion and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion and ActVal_Secuencia= @ActVal_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, Deprec_Codigo, Parame_TipoActivo, Pardet_TipoActivo, Parame_ClaseActivo, Pardet_ClaseActivo, Parame_GrupoActivo, Pardet_GrupoActivo, Activo_Codigo, Parame_TipoDepreciacion, Pardet_TipoDepreciacion, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto
			from DepreciacionDet
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_ActivoComponente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_ActivoComponente]
go
Create Procedure proc_ActivoComponente
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@ActCom_Secuencia	int=null, 
	@ActCom_Activo	bit=null, 
	@ActCom_Descripcion	nvarchar(150)=null, 
	@Parame_Marca	int=null, 
	@Pardet_Marca	int=null, 
	@Parame_Modelo	int=null, 
	@Pardet_Modelo	int=null, 
	@ActCom_Serie	nvarchar(50)=null, 
	@ActCom_esErogacion	bit=null, 
	@ActCom_ValorErogacion	money=null, 
	@ActCom_FechaAdquisicion	date=null, 
	@Entida_Proveedor	int=null, 
	@ActCom_Factura	nvarchar(50)=null, 
	@ActCom_FechaBaja	date=null)
as
begin
	if @accion='i'
	begin
		insert into ActivoComponente 
			(Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, Parame_Modelo, Pardet_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja)
		values (@Activo_Codigo, @ActCom_Secuencia, @ActCom_Activo, @ActCom_Descripcion, @Parame_Marca, @Pardet_Marca, @Parame_Modelo, @Pardet_Modelo, @ActCom_Serie, @ActCom_esErogacion, @ActCom_ValorErogacion, @ActCom_FechaAdquisicion, @Entida_Proveedor, @ActCom_Factura, @ActCom_FechaBaja)
		return 0
	end
	if @accion='m'
	begin
		update ActivoComponente
			set ActCom_Activo= @ActCom_Activo, ActCom_Descripcion= @ActCom_Descripcion, Parame_Marca= @Parame_Marca, Pardet_Marca= @Pardet_Marca, Parame_Modelo= @Parame_Modelo, Pardet_Modelo= @Pardet_Modelo, ActCom_Serie= @ActCom_Serie, ActCom_esErogacion= @ActCom_esErogacion, ActCom_ValorErogacion= @ActCom_ValorErogacion, ActCom_FechaAdquisicion= @ActCom_FechaAdquisicion, Entida_Proveedor= @Entida_Proveedor, ActCom_Factura= @ActCom_Factura, ActCom_FechaBaja= @ActCom_FechaBaja
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, Parame_Modelo, Pardet_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja
			from ActivoComponente
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
		return 0
	end
	if @accion='e'
	begin
		delete ActivoComponente
		where Activo_Codigo= @Activo_Codigo and ActCom_Secuencia= @ActCom_Secuencia
		return 0
	end
	if @accion='f'
	begin
		select Activo_Codigo, ActCom_Secuencia, ActCom_Activo, ActCom_Descripcion, Parame_Marca, Pardet_Marca, Parame_Modelo, Pardet_Modelo, ActCom_Serie, ActCom_esErogacion, ActCom_ValorErogacion, ActCom_FechaAdquisicion, Entida_Proveedor, ActCom_Factura, ActCom_FechaBaja
			from ActivoComponente
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Poliza]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Poliza]
go
Create Procedure proc_Poliza
(	@accion	char(1), 
	@Poliza_Codigo	int=null, 
	@Poliza_Descripcion	nvarchar(150)=null, 
	@Entida_Proveedor	int=null, 
	@Poliza_FechaInicio	date=null, 
	@Poliza_FechaFin	date=null, 
	@Poliza_ValorAsegurado	money=null)
as
begin
	if @accion='i'
	begin
		insert into Poliza 
			(Poliza_Codigo, Poliza_Descripcion, Entida_Proveedor, Poliza_FechaInicio, Poliza_FechaFin, Poliza_ValorAsegurado)
		values (@Poliza_Codigo, @Poliza_Descripcion, @Entida_Proveedor, @Poliza_FechaInicio, @Poliza_FechaFin, @Poliza_ValorAsegurado)
		return 0
	end
	if @accion='m'
	begin
		update Poliza
			set Poliza_Descripcion= @Poliza_Descripcion, Entida_Proveedor= @Entida_Proveedor, Poliza_FechaInicio= @Poliza_FechaInicio, Poliza_FechaFin= @Poliza_FechaFin, Poliza_ValorAsegurado= @Poliza_ValorAsegurado
		where Poliza_Codigo= @Poliza_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Poliza_Codigo, Poliza_Descripcion, Entida_Proveedor, Poliza_FechaInicio, Poliza_FechaFin, Poliza_ValorAsegurado
			from Poliza
		where Poliza_Codigo= @Poliza_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Poliza
		where Poliza_Codigo= @Poliza_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Poliza_Codigo, Poliza_Descripcion, Entida_Proveedor, Poliza_FechaInicio, Poliza_FechaFin, Poliza_ValorAsegurado
			from Poliza
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_PolizaDet]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_PolizaDet]
go
Create Procedure proc_PolizaDet
(	@accion	char(1), 
	@Poliza_Codigo	int=null, 
	@Activo_Codigo	int=null)
as
begin
	if @accion='i'
	begin
		insert into PolizaDet 
			(Poliza_Codigo, Activo_Codigo)
		values (@Poliza_Codigo, @Activo_Codigo)
		return 0
	end
	if @accion='m'
	begin
		update PolizaDet
			set 
		where Poliza_Codigo= @Poliza_Codigo and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Poliza_Codigo, Activo_Codigo
			from PolizaDet
		where Poliza_Codigo= @Poliza_Codigo and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete PolizaDet
		where Poliza_Codigo= @Poliza_Codigo and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Poliza_Codigo, Activo_Codigo
			from PolizaDet
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Entidad]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Entidad]
go
Create Procedure proc_Entidad
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Parame_Tipoentidad	int=null, 
	@Pardet_Tipoentidad	int=null, 
	@Entida_AutorizacionFactura	varchar(10)=null, 
	@Entida_CaducidadFactura	varchar(7)=null, 
	@Entida_AutorizacionNotaVenta	varchar(10)=null, 
	@Entida_CaducidadNotaVenta	varchar(7)=null, 
	@Entida_AutorizacionRetencion	varchar(10)=null, 
	@Entida_CaducidadRetencion	varchar(7)=null, 
	@Entida_Imagen	image=null)
as
begin
	if @accion='i'
	begin
		insert into Entidad 
			(Entida_Codigo, Parame_Tipoentidad, Pardet_Tipoentidad, Entida_AutorizacionFactura, Entida_CaducidadFactura, Entida_AutorizacionNotaVenta, Entida_CaducidadNotaVenta, Entida_AutorizacionRetencion, Entida_CaducidadRetencion, Entida_Imagen)
		values (@Entida_Codigo, @Parame_Tipoentidad, @Pardet_Tipoentidad, @Entida_AutorizacionFactura, @Entida_CaducidadFactura, @Entida_AutorizacionNotaVenta, @Entida_CaducidadNotaVenta, @Entida_AutorizacionRetencion, @Entida_CaducidadRetencion, @Entida_Imagen)
		return 0
	end
	if @accion='m'
	begin
		update Entidad
			set Parame_Tipoentidad= @Parame_Tipoentidad, Pardet_Tipoentidad= @Pardet_Tipoentidad, Entida_AutorizacionFactura= @Entida_AutorizacionFactura, Entida_CaducidadFactura= @Entida_CaducidadFactura, Entida_AutorizacionNotaVenta= @Entida_AutorizacionNotaVenta, Entida_CaducidadNotaVenta= @Entida_CaducidadNotaVenta, Entida_AutorizacionRetencion= @Entida_AutorizacionRetencion, Entida_CaducidadRetencion= @Entida_CaducidadRetencion, Entida_Imagen= @Entida_Imagen
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Parame_Tipoentidad, Pardet_Tipoentidad, Entida_AutorizacionFactura, Entida_CaducidadFactura, Entida_AutorizacionNotaVenta, Entida_CaducidadNotaVenta, Entida_AutorizacionRetencion, Entida_CaducidadRetencion, Entida_Imagen
			from Entidad
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Entidad
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Parame_Tipoentidad, Pardet_Tipoentidad, Entida_AutorizacionFactura, Entida_CaducidadFactura, Entida_AutorizacionNotaVenta, Entida_CaducidadNotaVenta, Entida_AutorizacionRetencion, Entida_CaducidadRetencion, Entida_Imagen
			from Entidad
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadDatos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadDatos]
go
Create Procedure proc_EntidadDatos
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Parame_Tipodatos	int=null, 
	@Pardet_Tipodatos	int=null, 
	@Entdat_Descripcion	nvarchar(300)=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadDatos 
			(Entida_Codigo, Parame_Tipodatos, Pardet_Tipodatos, Entdat_Descripcion)
		values (@Entida_Codigo, @Parame_Tipodatos, @Pardet_Tipodatos, @Entdat_Descripcion)
		return 0
	end
	if @accion='m'
	begin
		update EntidadDatos
			set Entdat_Descripcion= @Entdat_Descripcion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodatos= @Parame_Tipodatos and Pardet_Tipodatos= @Pardet_Tipodatos
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Parame_Tipodatos, Pardet_Tipodatos, Entdat_Descripcion
			from EntidadDatos
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodatos= @Parame_Tipodatos and Pardet_Tipodatos= @Pardet_Tipodatos
		return 0
	end
	if @accion='e'
	begin
		delete EntidadDatos
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodatos= @Parame_Tipodatos and Pardet_Tipodatos= @Pardet_Tipodatos
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Parame_Tipodatos, Pardet_Tipodatos, Entdat_Descripcion
			from EntidadDatos
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadDireccion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadDireccion]
go
Create Procedure proc_EntidadDireccion
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Parame_Tipodireccion	int=null, 
	@Pardet_Tipodireccion	int=null, 
	@Parame_Ciudad	int=null, 
	@Pardet_Ciudad	int=null, 
	@Direcc_Calleprincipal	nvarchar(100)=null, 
	@Direcc_Numero	nvarchar(50)=null, 
	@Direcc_Calleinterseccion	nvarchar(100)=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadDireccion 
			(Entida_Codigo, Parame_Tipodireccion, Pardet_Tipodireccion, Parame_Ciudad, Pardet_Ciudad, Direcc_Calleprincipal, Direcc_Numero, Direcc_Calleinterseccion)
		values (@Entida_Codigo, @Parame_Tipodireccion, @Pardet_Tipodireccion, @Parame_Ciudad, @Pardet_Ciudad, @Direcc_Calleprincipal, @Direcc_Numero, @Direcc_Calleinterseccion)
		return 0
	end
	if @accion='m'
	begin
		update EntidadDireccion
			set Parame_Ciudad= @Parame_Ciudad, Pardet_Ciudad= @Pardet_Ciudad, Direcc_Calleprincipal= @Direcc_Calleprincipal, Direcc_Numero= @Direcc_Numero, Direcc_Calleinterseccion= @Direcc_Calleinterseccion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodireccion= @Parame_Tipodireccion and Pardet_Tipodireccion= @Pardet_Tipodireccion
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Parame_Tipodireccion, Pardet_Tipodireccion, Parame_Ciudad, Pardet_Ciudad, Direcc_Calleprincipal, Direcc_Numero, Direcc_Calleinterseccion
			from EntidadDireccion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodireccion= @Parame_Tipodireccion and Pardet_Tipodireccion= @Pardet_Tipodireccion
		return 0
	end
	if @accion='e'
	begin
		delete EntidadDireccion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipodireccion= @Parame_Tipodireccion and Pardet_Tipodireccion= @Pardet_Tipodireccion
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Parame_Tipodireccion, Pardet_Tipodireccion, Parame_Ciudad, Pardet_Ciudad, Direcc_Calleprincipal, Direcc_Numero, Direcc_Calleinterseccion
			from EntidadDireccion
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadIdentificacion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadIdentificacion]
go
Create Procedure proc_EntidadIdentificacion
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Parame_Tipoidentificacion	int=null, 
	@Pardet_Tipoidentificacion	int=null, 
	@Identi_Numero	nvarchar(50)=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadIdentificacion 
			(Entida_Codigo, Parame_Tipoidentificacion, Pardet_Tipoidentificacion, Identi_Numero)
		values (@Entida_Codigo, @Parame_Tipoidentificacion, @Pardet_Tipoidentificacion, @Identi_Numero)
		return 0
	end
	if @accion='m'
	begin
		update EntidadIdentificacion
			set Identi_Numero= @Identi_Numero
		where Entida_Codigo= @Entida_Codigo and Parame_Tipoidentificacion= @Parame_Tipoidentificacion and Pardet_Tipoidentificacion= @Pardet_Tipoidentificacion
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Parame_Tipoidentificacion, Pardet_Tipoidentificacion, Identi_Numero
			from EntidadIdentificacion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipoidentificacion= @Parame_Tipoidentificacion and Pardet_Tipoidentificacion= @Pardet_Tipoidentificacion
		return 0
	end
	if @accion='e'
	begin
		delete EntidadIdentificacion
		where Entida_Codigo= @Entida_Codigo and Parame_Tipoidentificacion= @Parame_Tipoidentificacion and Pardet_Tipoidentificacion= @Pardet_Tipoidentificacion
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Parame_Tipoidentificacion, Pardet_Tipoidentificacion, Identi_Numero
			from EntidadIdentificacion
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadJuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadJuridica]
go
Create Procedure proc_EntidadJuridica
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Entjur_Nombrecomercial	nvarchar(100)=null, 
	@Entjur_Razonsocial	nvarchar(100)=null, 
	@Entjur_Fechaconstitucion	datetime=null, 
	@Parame_Tipocontribuyente	int=null, 
	@Pardet_Tipocontribuyente	int=null, 
	@Entida_RepresLegal	int=null, 
	@Entida_Contacto	int=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadJuridica 
			(Entida_Codigo, Entjur_Nombrecomercial, Entjur_Razonsocial, Entjur_Fechaconstitucion, Parame_Tipocontribuyente, Pardet_Tipocontribuyente, Entida_RepresLegal, Entida_Contacto)
		values (@Entida_Codigo, @Entjur_Nombrecomercial, @Entjur_Razonsocial, @Entjur_Fechaconstitucion, @Parame_Tipocontribuyente, @Pardet_Tipocontribuyente, @Entida_RepresLegal, @Entida_Contacto)
		return 0
	end
	if @accion='m'
	begin
		update EntidadJuridica
			set Entjur_Nombrecomercial= @Entjur_Nombrecomercial, Entjur_Razonsocial= @Entjur_Razonsocial, Entjur_Fechaconstitucion= @Entjur_Fechaconstitucion, Parame_Tipocontribuyente= @Parame_Tipocontribuyente, Pardet_Tipocontribuyente= @Pardet_Tipocontribuyente, Entida_RepresLegal= @Entida_RepresLegal, Entida_Contacto= @Entida_Contacto
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Entjur_Nombrecomercial, Entjur_Razonsocial, Entjur_Fechaconstitucion, Parame_Tipocontribuyente, Pardet_Tipocontribuyente, Entida_RepresLegal, Entida_Contacto
			from EntidadJuridica
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete EntidadJuridica
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Entjur_Nombrecomercial, Entjur_Razonsocial, Entjur_Fechaconstitucion, Parame_Tipocontribuyente, Pardet_Tipocontribuyente, Entida_RepresLegal, Entida_Contacto
			from EntidadJuridica
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadLugar]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadLugar]
go
Create Procedure proc_EntidadLugar
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@EntLug_Nombre	nvarchar(100)=null, 
	@Parame_TipoEntLug	int=null, 
	@Pardet_TipoEntLug	int=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadLugar 
			(Entida_Codigo, EntLug_Nombre, Parame_TipoEntLug, Pardet_TipoEntLug)
		values (@Entida_Codigo, @EntLug_Nombre, @Parame_TipoEntLug, @Pardet_TipoEntLug)
		return 0
	end
	if @accion='m'
	begin
		update EntidadLugar
			set EntLug_Nombre= @EntLug_Nombre, Parame_TipoEntLug= @Parame_TipoEntLug, Pardet_TipoEntLug= @Pardet_TipoEntLug
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, EntLug_Nombre, Parame_TipoEntLug, Pardet_TipoEntLug
			from EntidadLugar
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete EntidadLugar
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, EntLug_Nombre, Parame_TipoEntLug, Pardet_TipoEntLug
			from EntidadLugar
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Perito]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Perito]
go
Create Procedure proc_Perito
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Perito_Visible	bit=null)
as
begin
	if @accion='i'
	begin
		insert into Perito 
			(Entida_Codigo, Perito_Visible)
		values (@Entida_Codigo, @Perito_Visible)
		return 0
	end
	if @accion='m'
	begin
		update Perito
			set Perito_Visible= @Perito_Visible
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Perito_Visible
			from Perito
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Perito
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Perito_Visible
			from Perito
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_EntidadNatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_EntidadNatural]
go
Create Procedure proc_EntidadNatural
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Entnat_Nombres	nvarchar(50)=null, 
	@Entnat_Apellidopaterno	nvarchar(50)=null, 
	@Entnat_Apellidomaterno	nvarchar(50)=null, 
	@Entnat_Sobrenombre	nvarchar(100)=null, 
	@Parame_Sexo	int=null, 
	@Pardet_Sexo	int=null, 
	@Parame_Estadocivil	int=null, 
	@Pardet_Estadocivil	int=null, 
	@Entnat_Fechanacimiento	datetime=null)
as
begin
	if @accion='i'
	begin
		insert into EntidadNatural 
			(Entida_Codigo, Entnat_Nombres, Entnat_Apellidopaterno, Entnat_Apellidomaterno, Entnat_Sobrenombre, Parame_Sexo, Pardet_Sexo, Parame_Estadocivil, Pardet_Estadocivil, Entnat_Fechanacimiento)
		values (@Entida_Codigo, @Entnat_Nombres, @Entnat_Apellidopaterno, @Entnat_Apellidomaterno, @Entnat_Sobrenombre, @Parame_Sexo, @Pardet_Sexo, @Parame_Estadocivil, @Pardet_Estadocivil, @Entnat_Fechanacimiento)
		return 0
	end
	if @accion='m'
	begin
		update EntidadNatural
			set Entnat_Nombres= @Entnat_Nombres, Entnat_Apellidopaterno= @Entnat_Apellidopaterno, Entnat_Apellidomaterno= @Entnat_Apellidomaterno, Entnat_Sobrenombre= @Entnat_Sobrenombre, Parame_Sexo= @Parame_Sexo, Pardet_Sexo= @Pardet_Sexo, Parame_Estadocivil= @Parame_Estadocivil, Pardet_Estadocivil= @Pardet_Estadocivil, Entnat_Fechanacimiento= @Entnat_Fechanacimiento
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Entnat_Nombres, Entnat_Apellidopaterno, Entnat_Apellidomaterno, Entnat_Sobrenombre, Parame_Sexo, Pardet_Sexo, Parame_Estadocivil, Pardet_Estadocivil, Entnat_Fechanacimiento
			from EntidadNatural
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete EntidadNatural
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Entnat_Nombres, Entnat_Apellidopaterno, Entnat_Apellidomaterno, Entnat_Sobrenombre, Parame_Sexo, Pardet_Sexo, Parame_Estadocivil, Pardet_Estadocivil, Entnat_Fechanacimiento
			from EntidadNatural
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_FacturaActivo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_FacturaActivo]
go
Create Procedure proc_FacturaActivo
(	@accion	char(1), 
	@Factura_Codigo	int=null, 
	@Entida_Proveedor	int=null, 
	@Factura_Numero	nvarchar(150)=null, 
	@Factura_Fecha	date=null)
as
begin
	if @accion='i'
	begin
		insert into FacturaActivo 
			(Factura_Codigo, Entida_Proveedor, Factura_Numero, Factura_Fecha)
		values (@Factura_Codigo, @Entida_Proveedor, @Factura_Numero, @Factura_Fecha)
		return 0
	end
	if @accion='m'
	begin
		update FacturaActivo
			set Entida_Proveedor= @Entida_Proveedor, Factura_Numero= @Factura_Numero, Factura_Fecha= @Factura_Fecha
		where Factura_Codigo= @Factura_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Factura_Codigo, Entida_Proveedor, Factura_Numero, Factura_Fecha
			from FacturaActivo
		where Factura_Codigo= @Factura_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete FacturaActivo
		where Factura_Codigo= @Factura_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Factura_Codigo, Entida_Proveedor, Factura_Numero, Factura_Fecha
			from FacturaActivo
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_ActivoUbicacion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_ActivoUbicacion]
go
Create Procedure proc_ActivoUbicacion
(	@accion	char(1), 
	@Activo_Codigo	int=null, 
	@ActUbi_Secuencia	int=null, 
	@ActUbi_Activo	bit=null, 
	@Parame_Ubicacion	int=null, 
	@Pardet_Ubicacion	int=null, 
	@ActUbi_FechaDesde	date=null, 
	@ActUbi_FechaHasta	date=null)
as
begin
	if @accion='i'
	begin
		insert into ActivoUbicacion 
			(Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta)
		values (@Activo_Codigo, @ActUbi_Secuencia, @ActUbi_Activo, @Parame_Ubicacion, @Pardet_Ubicacion, @ActUbi_FechaDesde, @ActUbi_FechaHasta)
		return 0
	end
	if @accion='m'
	begin
		update ActivoUbicacion
			set ActUbi_Activo= @ActUbi_Activo, Parame_Ubicacion= @Parame_Ubicacion, Pardet_Ubicacion= @Pardet_Ubicacion, ActUbi_FechaDesde= @ActUbi_FechaDesde, ActUbi_FechaHasta= @ActUbi_FechaHasta
		where Activo_Codigo= @Activo_Codigo and ActUbi_Secuencia= @ActUbi_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta
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
		select Activo_Codigo, ActUbi_Secuencia, ActUbi_Activo, Parame_Ubicacion, Pardet_Ubicacion, ActUbi_FechaDesde, ActUbi_FechaHasta
			from ActivoUbicacion
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Empleado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Empleado]
go
Create Procedure proc_Empleado
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Parame_Tipoempleado	int=null, 
	@Pardet_Tipoempleado	int=null, 
	@Emplea_Visible	bit=null, 
	@Parame_ClaseEmpleado	int=null, 
	@Pardet_ClaseEmpleado	int=null, 
	@Parame_Parroquia	int=null, 
	@Pardet_Parroquia	int=null, 
	@Parame_Banco	int=null, 
	@Pardet_Banco	int=null, 
	@Parame_TipoSangre	int=null, 
	@Pardet_TipoSangre	int=null, 
	@Parame_Nacionalidad	int=null, 
	@Pardet_Nacionalidad	int=null, 
	@Emplea_Emergencia	varchar(100)=null, 
	@Emplea_Enfermedad	varchar(150)=null, 
	@Emplea_FichaRoja	bit=null, 
	@Parame_TipoCuentaBancaria	int=null, 
	@Pardet_TipoCuentaBancaria	int=null, 
	@Emplea_NumeroCuentaBancaria	varchar(18)=null, 
	@Parame_FormaPagoRol	int=null, 
	@Pardet_FormaPagoRol	int=null, 
	@Emplea_JubilacionPatronal	money=null, 
	@Emplea_DesctoPrestQuirogMensual	money=null, 
	@Emplea_Primaria	varchar(50)=null, 
	@Emplea_Primariaanio	varchar(2)=null, 
	@Emplea_Secundaria	varchar(50)=null, 
	@Emplea_Secundariaanio	varchar(2)=null, 
	@Emplea_Bachiller	varchar(50)=null, 
	@Emplea_Superior	varchar(50)=null, 
	@Emplea_Superioranio	varchar(3)=null, 
	@Emplea_Titulo	varchar(50)=null, 
	@Emplea_Cursos	text=null, 
	@Emplea_ReferPersonales	text=null, 
	@Emplea_ReferLaborales	text=null, 
	@Emplea_ExcluirFamiliares	bit=null, 
	@Emplea_FechaAfiliacionIESS	datetime=null, 
	@Parame_TipoDiscapacidad	int=null, 
	@Pardet_TipoDiscapacidad	int=null, 
	@Emplea_DiscaFisica	bit=null, 
	@Emplea_DiscaAuditiva	bit=null, 
	@Emplea_DiscaLenguaje	bit=null, 
	@Emplea_DiscaVisual	bit=null, 
	@Emplea_DiscaIntelectual	bit=null, 
	@Emplea_DiscaPsicologica	bit=null, 
	@Parame_SeguroCorporativo	int=null, 
	@Pardet_SeguroCorporativo	int=null, 
	@Parame_SectorDomicilio	int=null, 
	@Pardet_SectorDomicilio	int=null, 
	@Parame_AdjuntoArchivos	int=null, 
	@Pardet_AdjuntoArchivos	int=null)
as
begin
	if @accion='i'
	begin
		insert into Empleado 
			(Entida_Codigo, Parame_Tipoempleado, Pardet_Tipoempleado, Emplea_Visible, Parame_ClaseEmpleado, Pardet_ClaseEmpleado, Parame_Parroquia, Pardet_Parroquia, Parame_Banco, Pardet_Banco, Parame_TipoSangre, Pardet_TipoSangre, Parame_Nacionalidad, Pardet_Nacionalidad, Emplea_Emergencia, Emplea_Enfermedad, Emplea_FichaRoja, Parame_TipoCuentaBancaria, Pardet_TipoCuentaBancaria, Emplea_NumeroCuentaBancaria, Parame_FormaPagoRol, Pardet_FormaPagoRol, Emplea_JubilacionPatronal, Emplea_DesctoPrestQuirogMensual, Emplea_Primaria, Emplea_Primariaanio, Emplea_Secundaria, Emplea_Secundariaanio, Emplea_Bachiller, Emplea_Superior, Emplea_Superioranio, Emplea_Titulo, Emplea_Cursos, Emplea_ReferPersonales, Emplea_ReferLaborales, Emplea_ExcluirFamiliares, Emplea_FechaAfiliacionIESS, Parame_TipoDiscapacidad, Pardet_TipoDiscapacidad, Emplea_DiscaFisica, Emplea_DiscaAuditiva, Emplea_DiscaLenguaje, Emplea_DiscaVisual, Emplea_DiscaIntelectual, Emplea_DiscaPsicologica, Parame_SeguroCorporativo, Pardet_SeguroCorporativo, Parame_SectorDomicilio, Pardet_SectorDomicilio, Parame_AdjuntoArchivos, Pardet_AdjuntoArchivos)
		values (@Entida_Codigo, @Parame_Tipoempleado, @Pardet_Tipoempleado, @Emplea_Visible, @Parame_ClaseEmpleado, @Pardet_ClaseEmpleado, @Parame_Parroquia, @Pardet_Parroquia, @Parame_Banco, @Pardet_Banco, @Parame_TipoSangre, @Pardet_TipoSangre, @Parame_Nacionalidad, @Pardet_Nacionalidad, @Emplea_Emergencia, @Emplea_Enfermedad, @Emplea_FichaRoja, @Parame_TipoCuentaBancaria, @Pardet_TipoCuentaBancaria, @Emplea_NumeroCuentaBancaria, @Parame_FormaPagoRol, @Pardet_FormaPagoRol, @Emplea_JubilacionPatronal, @Emplea_DesctoPrestQuirogMensual, @Emplea_Primaria, @Emplea_Primariaanio, @Emplea_Secundaria, @Emplea_Secundariaanio, @Emplea_Bachiller, @Emplea_Superior, @Emplea_Superioranio, @Emplea_Titulo, @Emplea_Cursos, @Emplea_ReferPersonales, @Emplea_ReferLaborales, @Emplea_ExcluirFamiliares, @Emplea_FechaAfiliacionIESS, @Parame_TipoDiscapacidad, @Pardet_TipoDiscapacidad, @Emplea_DiscaFisica, @Emplea_DiscaAuditiva, @Emplea_DiscaLenguaje, @Emplea_DiscaVisual, @Emplea_DiscaIntelectual, @Emplea_DiscaPsicologica, @Parame_SeguroCorporativo, @Pardet_SeguroCorporativo, @Parame_SectorDomicilio, @Pardet_SectorDomicilio, @Parame_AdjuntoArchivos, @Pardet_AdjuntoArchivos)
		return 0
	end
	if @accion='m'
	begin
		update Empleado
			set Parame_Tipoempleado= @Parame_Tipoempleado, Pardet_Tipoempleado= @Pardet_Tipoempleado, Emplea_Visible= @Emplea_Visible, Parame_ClaseEmpleado= @Parame_ClaseEmpleado, Pardet_ClaseEmpleado= @Pardet_ClaseEmpleado, Parame_Parroquia= @Parame_Parroquia, Pardet_Parroquia= @Pardet_Parroquia, Parame_Banco= @Parame_Banco, Pardet_Banco= @Pardet_Banco, Parame_TipoSangre= @Parame_TipoSangre, Pardet_TipoSangre= @Pardet_TipoSangre, Parame_Nacionalidad= @Parame_Nacionalidad, Pardet_Nacionalidad= @Pardet_Nacionalidad, Emplea_Emergencia= @Emplea_Emergencia, Emplea_Enfermedad= @Emplea_Enfermedad, Emplea_FichaRoja= @Emplea_FichaRoja, Parame_TipoCuentaBancaria= @Parame_TipoCuentaBancaria, Pardet_TipoCuentaBancaria= @Pardet_TipoCuentaBancaria, Emplea_NumeroCuentaBancaria= @Emplea_NumeroCuentaBancaria, Parame_FormaPagoRol= @Parame_FormaPagoRol, Pardet_FormaPagoRol= @Pardet_FormaPagoRol, Emplea_JubilacionPatronal= @Emplea_JubilacionPatronal, Emplea_DesctoPrestQuirogMensual= @Emplea_DesctoPrestQuirogMensual, Emplea_Primaria= @Emplea_Primaria, Emplea_Primariaanio= @Emplea_Primariaanio, Emplea_Secundaria= @Emplea_Secundaria, Emplea_Secundariaanio= @Emplea_Secundariaanio, Emplea_Bachiller= @Emplea_Bachiller, Emplea_Superior= @Emplea_Superior, Emplea_Superioranio= @Emplea_Superioranio, Emplea_Titulo= @Emplea_Titulo, Emplea_Cursos= @Emplea_Cursos, Emplea_ReferPersonales= @Emplea_ReferPersonales, Emplea_ReferLaborales= @Emplea_ReferLaborales, Emplea_ExcluirFamiliares= @Emplea_ExcluirFamiliares, Emplea_FechaAfiliacionIESS= @Emplea_FechaAfiliacionIESS, Parame_TipoDiscapacidad= @Parame_TipoDiscapacidad, Pardet_TipoDiscapacidad= @Pardet_TipoDiscapacidad, Emplea_DiscaFisica= @Emplea_DiscaFisica, Emplea_DiscaAuditiva= @Emplea_DiscaAuditiva, Emplea_DiscaLenguaje= @Emplea_DiscaLenguaje, Emplea_DiscaVisual= @Emplea_DiscaVisual, Emplea_DiscaIntelectual= @Emplea_DiscaIntelectual, Emplea_DiscaPsicologica= @Emplea_DiscaPsicologica, Parame_SeguroCorporativo= @Parame_SeguroCorporativo, Pardet_SeguroCorporativo= @Pardet_SeguroCorporativo, Parame_SectorDomicilio= @Parame_SectorDomicilio, Pardet_SectorDomicilio= @Pardet_SectorDomicilio, Parame_AdjuntoArchivos= @Parame_AdjuntoArchivos, Pardet_AdjuntoArchivos= @Pardet_AdjuntoArchivos
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Parame_Tipoempleado, Pardet_Tipoempleado, Emplea_Visible, Parame_ClaseEmpleado, Pardet_ClaseEmpleado, Parame_Parroquia, Pardet_Parroquia, Parame_Banco, Pardet_Banco, Parame_TipoSangre, Pardet_TipoSangre, Parame_Nacionalidad, Pardet_Nacionalidad, Emplea_Emergencia, Emplea_Enfermedad, Emplea_FichaRoja, Parame_TipoCuentaBancaria, Pardet_TipoCuentaBancaria, Emplea_NumeroCuentaBancaria, Parame_FormaPagoRol, Pardet_FormaPagoRol, Emplea_JubilacionPatronal, Emplea_DesctoPrestQuirogMensual, Emplea_Primaria, Emplea_Primariaanio, Emplea_Secundaria, Emplea_Secundariaanio, Emplea_Bachiller, Emplea_Superior, Emplea_Superioranio, Emplea_Titulo, Emplea_Cursos, Emplea_ReferPersonales, Emplea_ReferLaborales, Emplea_ExcluirFamiliares, Emplea_FechaAfiliacionIESS, Parame_TipoDiscapacidad, Pardet_TipoDiscapacidad, Emplea_DiscaFisica, Emplea_DiscaAuditiva, Emplea_DiscaLenguaje, Emplea_DiscaVisual, Emplea_DiscaIntelectual, Emplea_DiscaPsicologica, Parame_SeguroCorporativo, Pardet_SeguroCorporativo, Parame_SectorDomicilio, Pardet_SectorDomicilio, Parame_AdjuntoArchivos, Pardet_AdjuntoArchivos
			from Empleado
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Empleado
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Parame_Tipoempleado, Pardet_Tipoempleado, Emplea_Visible, Parame_ClaseEmpleado, Pardet_ClaseEmpleado, Parame_Parroquia, Pardet_Parroquia, Parame_Banco, Pardet_Banco, Parame_TipoSangre, Pardet_TipoSangre, Parame_Nacionalidad, Pardet_Nacionalidad, Emplea_Emergencia, Emplea_Enfermedad, Emplea_FichaRoja, Parame_TipoCuentaBancaria, Pardet_TipoCuentaBancaria, Emplea_NumeroCuentaBancaria, Parame_FormaPagoRol, Pardet_FormaPagoRol, Emplea_JubilacionPatronal, Emplea_DesctoPrestQuirogMensual, Emplea_Primaria, Emplea_Primariaanio, Emplea_Secundaria, Emplea_Secundariaanio, Emplea_Bachiller, Emplea_Superior, Emplea_Superioranio, Emplea_Titulo, Emplea_Cursos, Emplea_ReferPersonales, Emplea_ReferLaborales, Emplea_ExcluirFamiliares, Emplea_FechaAfiliacionIESS, Parame_TipoDiscapacidad, Pardet_TipoDiscapacidad, Emplea_DiscaFisica, Emplea_DiscaAuditiva, Emplea_DiscaLenguaje, Emplea_DiscaVisual, Emplea_DiscaIntelectual, Emplea_DiscaPsicologica, Parame_SeguroCorporativo, Pardet_SeguroCorporativo, Parame_SectorDomicilio, Pardet_SectorDomicilio, Parame_AdjuntoArchivos, Pardet_AdjuntoArchivos
			from Empleado
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_Proveedor]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_Proveedor]
go
Create Procedure proc_Proveedor
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Provee_Visible	int=null)
as
begin
	if @accion='i'
	begin
		insert into Proveedor 
			(Entida_Codigo, Provee_Visible)
		values (@Entida_Codigo, @Provee_Visible)
		return 0
	end
	if @accion='m'
	begin
		update Proveedor
			set Provee_Visible= @Provee_Visible
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Provee_Visible
			from Proveedor
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Proveedor
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		select Entida_Codigo, Provee_Visible
			from Proveedor
		return 0
	end
end
go

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[proc_asientocontable]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[proc_asientocontable]
go
Create Procedure proc_asientocontable
(	@accion	char(1), 
	@fecha_proceso	date=null, 
	@estado	bit=null, 
	@cabecera	int=null, 
	@secuencia	int=null, 
	@sucursal	int=null, 
	@rubro_contable	nvarchar(50)=null, 
	@detalle_asiento	nvarchar(28)=null, 
	@distribucion	nvarchar(1)=null, 
	@fecha_valor	date=null, 
	@fuente_fondo	int=null, 
	@centro_costo	int=null, 
	@descripcion	nvarchar(28)=null, 
	@signo	nvarchar(1)=null, 
	@importe	decimal(18,2)=null)
as
begin
	if @accion='i'
	begin
		insert into asientocontable 
			(fecha_proceso, estado, cabecera, secuencia, sucursal, rubro_contable, detalle_asiento, distribucion, fecha_valor, fuente_fondo, centro_costo, descripcion, signo, importe)
		values (@fecha_proceso, @estado, @cabecera, @secuencia, @sucursal, @rubro_contable, @detalle_asiento, @distribucion, @fecha_valor, @fuente_fondo, @centro_costo, @descripcion, @signo, @importe)
		return 0
	end
	if @accion='m'
	begin
		update asientocontable
			set estado= @estado, sucursal= @sucursal, rubro_contable= @rubro_contable, detalle_asiento= @detalle_asiento, distribucion= @distribucion, fecha_valor= @fecha_valor, fuente_fondo= @fuente_fondo, centro_costo= @centro_costo, descripcion= @descripcion, signo= @signo, importe= @importe
		where fecha_proceso= @fecha_proceso and cabecera= @cabecera and secuencia= @secuencia
		return 0
	end
	if @accion='c'
	begin
		select fecha_proceso, estado, cabecera, secuencia, sucursal, rubro_contable, detalle_asiento, distribucion, fecha_valor, fuente_fondo, centro_costo, descripcion, signo, importe
			from asientocontable
		where fecha_proceso= @fecha_proceso and cabecera= @cabecera and secuencia= @secuencia
		return 0
	end
	if @accion='e'
	begin
		delete asientocontable
		where fecha_proceso= @fecha_proceso and cabecera= @cabecera and secuencia= @secuencia
		return 0
	end
	if @accion='f'
	begin
		select fecha_proceso, estado, cabecera, secuencia, sucursal, rubro_contable, detalle_asiento, distribucion, fecha_valor, fuente_fondo, centro_costo, descripcion, signo, importe
			from asientocontable
		return 0
	end
end
go

