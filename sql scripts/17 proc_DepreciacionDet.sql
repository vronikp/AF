USE [AFDepNueva]
GO
/****** Object:  StoredProcedure [dbo].[proc_DepreciacionDet]    Script Date: 03/19/2018 10:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[proc_DepreciacionDet]
(	@accion	char(2), 
	@Parame_FrecuenciaDepreciacion	int=null, 
	@Pardet_FrecuenciaDepreciacion	int=null, 
	@Parame_TipoDepreciacion	int=null, 
	@Pardet_TipoDepreciacion	int=null, 
	@Deprec_Codigo	nvarchar(50)=null, 
	@Activo_Codigo	int=null, 
	@ActVal_Secuencia	int=null, 
	@Deprec_Valor	decimal (18,8)=null, 
	@Deprec_CtaActivoFijo	nvarchar(50)=null, 
	@Deprec_CtaCentroCosto	nvarchar(150)=null, 
	@Deprec_CtaGasto	nvarchar(50)=null,
	@Deprec_Ubicacion	nvarchar(350)=null,
	@Deprec_PeriodosDepreciados  int=null,
	@Deprec_DepreciacionAcumulada decimal (18,8)=null)
as
begin
	if @accion='i'
	begin
		insert into DepreciacionDet 
			(Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			Parame_TipoDepreciacion, Pardet_TipoDepreciacion, 
			Deprec_Codigo, Activo_Codigo, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto, Deprec_Ubicacion,
			Deprec_PeriodosDepreciados, Deprec_DepreciacionAcumulada)
		values (@Parame_FrecuenciaDepreciacion, @Pardet_FrecuenciaDepreciacion, 
		@Parame_TipoDepreciacion, @Pardet_TipoDepreciacion, @Deprec_Codigo, @Activo_Codigo, @ActVal_Secuencia, @Deprec_Valor, @Deprec_CtaActivoFijo, 
		@Deprec_CtaCentroCosto, @Deprec_CtaGasto, @Deprec_Ubicacion, @Deprec_PeriodosDepreciados,@Deprec_DepreciacionAcumulada)
		return 0
	end
	if @accion='m'
	begin
		update DepreciacionDet
			set ActVal_Secuencia= @ActVal_Secuencia, Deprec_Valor= @Deprec_Valor, 
			Deprec_CtaActivoFijo= @Deprec_CtaActivoFijo, Deprec_CtaCentroCosto= @Deprec_CtaCentroCosto, Deprec_CtaGasto= @Deprec_CtaGasto,
			Deprec_Ubicacion= @Deprec_Ubicacion
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		and Activo_Codigo= @Activo_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			Parame_TipoDepreciacion, Pardet_TipoDepreciacion, Deprec_Codigo, 
			Activo_Codigo, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto, Deprec_Ubicacion
			from DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		and Activo_Codigo= @Activo_Codigo 
		return 0
	end
	if @accion='e'
	begin
		delete DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		and Activo_Codigo= @Activo_Codigo 
		return 0
	end
	if @accion='f'
	begin
		select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
			Parame_TipoDepreciacion, Pardet_TipoDepreciacion, Deprec_Codigo, 
			Activo_Codigo, ActVal_Secuencia, Deprec_Valor, Deprec_CtaActivoFijo, Deprec_CtaCentroCosto, Deprec_CtaGasto, Deprec_Ubicacion
			from DepreciacionDet
		where Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion 
		and Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion 
		and Parame_TipoDepreciacion= @Parame_TipoDepreciacion 
		and Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion 
		and Deprec_Codigo= @Deprec_Codigo 
		return 0
	end
	if @accion='fv'
	begin
    SELECT     dd.Parame_FrecuenciaDepreciacion, dd.Pardet_FrecuenciaDepreciacion, dd.Parame_TipoDepreciacion, dd.Pardet_TipoDepreciacion, dd.Deprec_Codigo, dd.Activo_Codigo, dd.ActVal_Secuencia, 
                          dd.Deprec_Valor, dd.Deprec_CtaActivoFijo, dd.Deprec_CtaCentroCosto, dd.Deprec_CtaGasto, dd.Deprec_Ubicacion
    FROM         DepreciacionDet AS dd INNER JOIN
                          Depreciacion AS d ON dd.Parame_FrecuenciaDepreciacion = d.Parame_FrecuenciaDepreciacion AND dd.Pardet_FrecuenciaDepreciacion = d.Pardet_FrecuenciaDepreciacion AND 
                          dd.Parame_TipoDepreciacion = d.Parame_TipoDepreciacion AND dd.Pardet_TipoDepreciacion = d.Pardet_TipoDepreciacion AND dd.Deprec_Codigo = d.Deprec_Codigo
    WHERE     (dd.Activo_Codigo = @Activo_Codigo) AND (dd.Parame_TipoDepreciacion = @Parame_TipoDepreciacion) AND (dd.Pardet_TipoDepreciacion = @Pardet_TipoDepreciacion) AND 
                          (dd.ActVal_Secuencia = @ActVal_Secuencia) AND (d.Deprec_esProyeccion = 0)
    ORDER BY dd.Deprec_Codigo
		return 0
	end
	if @accion='r'
	begin
		SELECT     PardetFrecuenciaDepreciacion.Pardet_Descripcion AS FrecuenciaDepreciacion, PardetTipoDepreciacion.Pardet_Descripcion AS TipoDepreciacion, 
                      DepreciacionDet.Parame_FrecuenciaDepreciacion, DepreciacionDet.Pardet_FrecuenciaDepreciacion, DepreciacionDet.Parame_TipoDepreciacion, 
                      DepreciacionDet.Pardet_TipoDepreciacion, DepreciacionDet.Deprec_Codigo, DepreciacionDet.Activo_Codigo, vw_ReporteActivo.Activo_Descripcion, 
                      DepreciacionDet.Deprec_Valor, DepreciacionDet.Deprec_CtaActivoFijo, DepreciacionDet.Deprec_CtaCentroCosto, DepreciacionDet.Deprec_CtaGasto, Deprec_Ubicacion,
                      vw_ReporteActivo.Grupo, vw_ReporteActivo.Tipo, vw_ReporteActivo.Clase, vw_ReporteActivo.Activo_Serie, vw_ReporteActivo.Marca, 
                      vw_ReporteActivo.Activo_Modelo, vw_ReporteActivo.Activo_CodigoBarra
		FROM         vw_ReporteActivo INNER JOIN
                      DepreciacionDet ON vw_ReporteActivo.Activo_Codigo = DepreciacionDet.Activo_Codigo INNER JOIN
                      ParametroDet AS PardetFrecuenciaDepreciacion ON DepreciacionDet.Parame_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Parame_Codigo AND 
                      DepreciacionDet.Pardet_FrecuenciaDepreciacion = PardetFrecuenciaDepreciacion.Pardet_Secuencia INNER JOIN
                      ParametroDet AS PardetTipoDepreciacion ON DepreciacionDet.Parame_TipoDepreciacion = PardetTipoDepreciacion.Parame_Codigo AND 
                      DepreciacionDet.Pardet_TipoDepreciacion = PardetTipoDepreciacion.Pardet_Secuencia
		where DepreciacionDet.Parame_FrecuenciaDepreciacion= @Parame_FrecuenciaDepreciacion
		and DepreciacionDet.Pardet_FrecuenciaDepreciacion= @Pardet_FrecuenciaDepreciacion
		and DepreciacionDet.Parame_TipoDepreciacion= @Parame_TipoDepreciacion
		and DepreciacionDet.Pardet_TipoDepreciacion= @Pardet_TipoDepreciacion
		and DepreciacionDet.Deprec_Codigo= @Deprec_Codigo
		order by Grupo,Tipo, Clase, DepreciacionDet.Activo_Codigo, vw_ReporteActivo.Activo_Descripcion
	end
end
