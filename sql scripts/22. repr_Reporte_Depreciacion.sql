
/****** Object:  StoredProcedure [dbo].[repr_Reporte_Depreciacion]    Script Date: 04/10/2018 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[repr_Reporte_Depreciacion]
	@accion	varchar(200)=null,
	@acciondatos	varchar(1500)=null,
	@Ocu_Usuario	char(18)=null,
	@Cortado_al		datetime=null,
	@cbo_Tipo_Depreciacion int=null

AS
BEGIN

	if @accion='select'
		select 1
	
	if @accion='@cbo_Tipo_Depreciacion'
	begin
		select pardet_Secuencia, Pardet_Descripcion
		from ParametroDet
		where Parame_Codigo=10080
	end

	if @accion is null
	begin
		declare @Parame_FrecuenciaDepreciacion int =10055
		declare @Pardet_FrecuenciaDepreciacion int
		declare @periodoDep int =0
	
		--Parametrizado!
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
								where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
			set @Pardet_FrecuenciaDepreciacion =2
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
			set @Pardet_FrecuenciaDepreciacion =1
	
		--Mensual:
		if @Pardet_FrecuenciaDepreciacion=1
			set @periodoDep = year(@Cortado_al)*100+MONTH(@Cortado_al)
		
		--Diaria:
		if @Pardet_FrecuenciaDepreciacion=2
			set @periodoDep = year(@Cortado_al)*10000+MONTH(@Cortado_al)*100+DAY(@cortado_al)
		
		select act.Activo_CodigoBarra as CodigoBarras, pdTipo.Pardet_Descripcion as Tipo, pdClase.Pardet_Descripcion as Clase,
			dd.Deprec_Ubicacion, act.Activo_FechaIngreso as FechaInicioDep, av.ActVal_FechaValoracion as FechaValoracion, 
			(Select ActVal_Costo from ActivoValor av2 
			where av2.Activo_Codigo=act.Activo_Codigo 
			and av2.Pardet_TipoDepreciacion=@cbo_Tipo_Depreciacion and av2.Pardet_TipoValoracion=1) as Inicial,
			av.ActVal_Costo as Valoracion, av.ActVal_Salvamento as Salvamento, av.ActVal_PeriodosDepreciables as VidaUtil,
			YEAR(@cortado_al) as Año, dd.Deprec_Valor as DepreciacionPeriodo, dd.Deprec_PeriodosDepreciados as PeriodosDepreciados,
			dd.Deprec_DepreciacionAcumulada as DepreciacionAcumulada, av.ActVal_Costo-dd.Deprec_DepreciacionAcumulada as ValorEnLibros
		from Activo act left join 
			ParametroDet pdClase on act.Parame_ClaseActivo = pdClase.Parame_Codigo and act.Pardet_ClaseActivo = pdClase.Pardet_Secuencia left join
			ParametroDet pdTipo on pdClase.Parame_Padre = pdTipo.Parame_Codigo and pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia left join
			DepreciacionDet dd on act.Activo_Codigo = dd.Activo_Codigo left join
			ActivoValor av on act.Activo_Codigo =av.Activo_Codigo and dd.ActVal_Secuencia=av.ActVal_Secuencia and av.Pardet_TipoDepreciacion=dd.Pardet_TipoDepreciacion
		where dd.Deprec_Codigo=@periodoDep
			and dd.Pardet_TipoDepreciacion= @cbo_tipo_depreciacion
		order by act.Activo_CodigoBarra
	
	end
END
