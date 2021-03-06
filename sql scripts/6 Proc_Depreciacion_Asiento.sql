USE [AF_DMIRO]
GO
/****** Object:  StoredProcedure [dbo].[proc_Depreciacion_Exportar]    Script Date: 25/2/2018 15:56:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].Proc_Depreciacion_Asiento (
	@accion	varchar(100)=null,
	@cbo_Frecuencia_Depreciacion	int=null,
	@cba_Codigo_Depreciacion	varchar(50)=null,
	@Fecha_ultimo_dia_mes	datetime=null,
	@ocu_solo_calculo int=null
)
AS
BEGIN
	if @accion='@cbo_Frecuencia_Depreciacion'
	begin
		select Pardet_Secuencia, Pardet_descripcion
			from ParametroDet
			where Parame_Codigo=10055
		return 0
	end
	
	if @accion='@cba_Codigo_Depreciacion'
	begin
		select distinct Deprec_Codigo, Deprec_Codigo
			from Depreciacion
			where Pardet_FrecuenciaDepreciacion=  @cbo_Frecuencia_Depreciacion
			--and Pardet_TipoDepreciacion= @cbo_Tipo_Depreciacion
			order by Depreciacion.Deprec_Codigo desc
		return 0
	end
	if @accion is null
	begin
    --exec proc_DepreciacionResumen 10055, @cbo_Frecuencia_Depreciacion, @cba_Codigo_Depreciacion
    delete DepreciacionAsiento 
        where Pardet_FrecuenciaDepreciacion=  @cbo_Frecuencia_Depreciacion
        and Deprec_Codigo=@cba_Codigo_Depreciacion

    insert into DepreciacionAsiento (
        Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
        Deprec_Codigo, Activo_Codigo, DepAsi_Cuenta, DepAsi_esDebe,
        DepAsi_Valor, DepAsi_CtaCentroCosto, 
        DepAsi_Ubicacion, DepAsi_Secuencia, DepAsi_Observacion, DepAsi_esCtaDepAcu)
    Select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
        Deprec_Codigo, Activo_Codigo, 
        Deprec_CtaGasto, 1, Deprec_Financiera, 
        Deprec_CtaCentroCosto, Deprec_Ubicacion, 1, '', 0
        from DepreciacionResumen
        where Deprec_Tributaria >= Deprec_Financiera
        and Pardet_FrecuenciaDepreciacion=@cbo_Frecuencia_Depreciacion
        and Deprec_Codigo=@cba_Codigo_Depreciacion
    union
    Select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
        Deprec_Codigo, Activo_Codigo, 
        Deprec_CtaGasto, 1, Deprec_Tributaria, 
        Deprec_CtaCentroCosto, Deprec_Ubicacion, 1, '-MD', 0
        from DepreciacionResumen
        where Deprec_Tributaria < Deprec_Financiera
        and Pardet_FrecuenciaDepreciacion=@cbo_Frecuencia_Depreciacion
        and Deprec_Codigo=@cba_Codigo_Depreciacion

    union

    Select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
        Deprec_Codigo, Activo_Codigo, 
        Deprec_CtaGastoND, 1, Deprec_Financiera-Deprec_Tributaria, --nodeducibles
        Deprec_CtaCentroCosto, Deprec_Ubicacion, 2, '-MND',0
        from DepreciacionResumen
        where Deprec_Tributaria < Deprec_Financiera
        and Pardet_FrecuenciaDepreciacion=@cbo_Frecuencia_Depreciacion
        and Deprec_Codigo=@cba_Codigo_Depreciacion

    union

    Select Parame_FrecuenciaDepreciacion, Pardet_FrecuenciaDepreciacion, 
        Deprec_Codigo, Activo_Codigo, 
        Deprec_CtaActivoFijo, 0, Deprec_Financiera, 
        Deprec_CtaCentroCosto, Deprec_Ubicacion,1, '',1
        from DepreciacionResumen
        where --Deprec_Tributaria >= Deprec_Financiera and 
        Pardet_FrecuenciaDepreciacion=@cbo_Frecuencia_Depreciacion
        and Deprec_Codigo=@cba_Codigo_Depreciacion
    order by 6 desc, 4

		;
	--COLUMNA
	--0 ANIO
	--1 ASIENTO APP
	--2 GLOSA CABECERA
	--3 SISTEMA
	--4 SUCURSAL
	--5 CTA CTBLE
	--6 CTO COSTOS
	--7 ES DEBITO SI NO
	--8 GLOSA DETALLE
	--9 MONTO

		SELECT LEFT(DEPREC_CODIGO,4),
			1, --TODO: COMO SE GENERA EL NUMERO DEL ASIENTO? ES UN SECUENCIAL?
			'Depreciacion ' + Deprec_Codigo,
			'AFDMIRO', --TODO: CUAL ES EL CODIGO DEL SISTEMA EXTERNO?
			1, --COMO SE OBTIENE LA SUCURSAL?
			DepAsi_Cuenta,
			DepAsi_CtaCentroCosto,
			DepAsi_esDebe,
			ACTIVO.Activo_Descripcion, --EN EL DETALLE VA EL NOMBRE DEL ACTIVO O EL DEL GRUPO?
			DepAsi_Valor
		FROM         DepreciacionAsiento INNER JOIN
				        Activo ON DepreciacionAsiento.Activo_Codigo = Activo.Activo_Codigo
	      where Pardet_FrecuenciaDepreciacion=  @cbo_Frecuencia_Depreciacion
		      and Deprec_Codigo= @cba_Codigo_Depreciacion

    end

END