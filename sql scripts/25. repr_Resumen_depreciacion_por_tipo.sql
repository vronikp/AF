
/****** Object:  StoredProcedure [dbo].[repr_Resumen_depreciacion_por_tipo]    Script Date: 04/11/2018 05:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[repr_Resumen_depreciacion_por_tipo]
	@accion	varchar(200)=null,
	@acciondatos	varchar(1500)=null,
	@Ocu_Usuario	char(18)=null,
	@Cortado_al		datetime=null,
	@cbo_Tipo_Depreciacion int=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @accion='select'
		select 1

	if @accion='@cbo_Tipo_Depreciacion'
	begin
		select pardet_Secuencia, Pardet_Descripcion
		from ParametroDet
		where Parame_Codigo=10080
	end
	
	if @accion='def_@Anio'
		select YEAR(getdate())
	
	if @accion='def_@Mes'
		select MONTH(getdate())
		
	if @accion is null
	begin
	
		declare @Parame_FrecuenciaDepreciacion int =10055
		declare @Pardet_FrecuenciaDepreciacion int
		declare @dia int = DAY(@cortado_al)
		declare @mes int = MONTH(@Cortado_al)
		declare @anio int = year(@Cortado_al)
		declare @periodoMes int = @anio*100+@mes
		declare @periodoDia int = @anio*10000+@mes*100+@dia
		declare @actval_sec int
	
		--Parametrizado!
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
								where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Diaria'
			set @Pardet_FrecuenciaDepreciacion =2
		if (select Pardet_DatoStr1 from dbo.ParametroDet AS pdDep 
							where pdDep.Parame_Codigo = 10003 AND pdDep.Pardet_Secuencia = 1) = 'Mensual'
			set @Pardet_FrecuenciaDepreciacion =1
		
		
		
		--Mensual:
		if @Pardet_FrecuenciaDepreciacion=1
		begin 
			select Tipo, 
				sum(Inicial) as CostoOriginal,
				sum(Valoracion) as Valoracion, sum(Salvamento) as Salvamento, 
				sum(DepreciacionAcumuladaAnt) as  DepreciacionAcumuladaAnt,
				sum(DepreciacionPeriodo) as DepreciacionMes, 
				sum(DepreciacionAnio) as DepreciacionAnio,
				sum(DepreciacionAcumulada) as DepreciacionAcumulada, 
				sum(ValorEnLibros) as ValorEnLibros
			from vw_DepreciacionDetMensual as dd
			where dd.Deprec_Codigo=@periodoMes
				and dd.Pardet_TipoDepreciacion= @cbo_tipo_depreciacion 
				and year(dd.Activo_FechaIngreso)*100+	MONTH(dd.Activo_FechaIngreso) <= @periodoMes
				and (year(dd.Activo_FechaBaja)*100+MONTH(dd.Activo_FechaBaja)>@periodoMes or dd.Activo_FechaBaja is null)
			group by tipo
		end 
		
		--Diaria:
		if @Pardet_FrecuenciaDepreciacion=2
		begin 
			select Tipo, 
				sum(Inicial) as CostoOriginal,
				sum(Valoracion) as Valoracion, sum(Salvamento) as Salvamento, 
				sum(DepreciacionAcumuladaAnt) as  DepreciacionAcumuladaAnt,
				sum(DepreciacionPeriodo) as DepreciacionDia,
				sum(DepreciacionMes) as DepreciacionMes, 
				sum(DepreciacionAnio) as DepreciacionAnio,
				sum(DepreciacionAcumulada) as DepreciacionAcumulada, 
				sum(ValorEnLibros) as ValorEnLibros
			from vw_DepreciacionDetDiaria as dd
			where dd.Deprec_Codigo=@periodoMes
				and dd.Pardet_TipoDepreciacion= @cbo_tipo_depreciacion 
				and year(dd.Activo_FechaIngreso)*100+	MONTH(dd.Activo_FechaIngreso) <= @periodoMes
				and (year(dd.Activo_FechaBaja)*100+MONTH(dd.Activo_FechaBaja)>@periodoMes or dd.Activo_FechaBaja is null)
			group by tipo
		end 

	end

END
