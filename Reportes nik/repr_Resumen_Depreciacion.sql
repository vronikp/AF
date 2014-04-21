USE [AF_SRI2]
GO

/****** Object:  StoredProcedure [dbo].[repr_Resumen_Depreciacion]    Script Date: 10/30/2012 04:26:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[repr_Resumen_Depreciacion]
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

declare @ultimoperiodo varchar(50)
declare @ultimodiames datetime
set @ultimodiames=DATEADD(MONTH,1,@Cortado_al)
set @ultimodiames=DATEADD(day, -day(@ultimodiames),@ultimodiames)

if not @Cortado_al=@ultimodiames
	set @ultimodiames=DATEADD(month, -1, @ultimodiames)
set @ultimoperiodo=CAST(year(@ultimodiames)*100+month(@ultimodiames) as varchar(50))

select 
/*PardetTipo.Pardet_Descripcion as Tipo,*/
(Select SUM (ActVal_Costo) from ActivoValor av2 
where /*av2.Activo_Codigo=Ac.Activo_Codigo 
and */av2.Pardet_TipoDepreciacion=@cbo_Tipo_Depreciacion and av2.Pardet_TipoValoracion=1) as Inicial,

SUM (av.ActVal_Costo) as Valoracion,
SUM (av.ActVal_Salvamento) as Rescate,

SUM (av.ActVal_Costo-av.ActVal_Salvamento) as Depreciable,
SUM (dd.Deprec_Valor) as Deprec_Mensual
/*(case 
	when ActVal_PeriodosDepreciables=0 then 0
	else (ActVal_Costo-ActVal_Salvamento)/ActVal_PeriodosDepreciables 
	end) as Deprec_Mensual,*/


FROM  Activo AS ac INNER JOIN
	  ParametroDet PardetClase on ac.Parame_ClaseActivo=PardetClase.Parame_codigo and ac.Pardet_ClaseActivo=PardetClase.Pardet_Secuencia INNER JOIN
	  ParametroDet PardetTipo on PardetClase.parame_padre=PardetTipo.Parame_codigo and PardetClase.pardet_padre=PardetTipo.Pardet_Secuencia inner join
      FacturaActivo AS fa ON ac.Factura_Codigo = fa.Factura_Codigo INNER JOIN
      Proveedor AS pr ON fa.Entida_Proveedor = pr.Entida_Codigo INNER JOIN
      vw_Persona AS vp ON vp.Entida_Codigo = pr.Entida_Codigo INNER JOIN
      DepreciacionDet AS dd ON ac.Activo_Codigo = dd.Activo_Codigo INNER JOIN
      Depreciacion AS de ON dd.Parame_FrecuenciaDepreciacion = de.Parame_FrecuenciaDepreciacion AND 
      dd.Pardet_FrecuenciaDepreciacion = de.Pardet_FrecuenciaDepreciacion AND dd.Parame_TipoDepreciacion = de.Parame_TipoDepreciacion AND 
      dd.Pardet_TipoDepreciacion = de.Pardet_TipoDepreciacion AND dd.Deprec_Codigo = de.Deprec_Codigo INNER JOIN
      ActivoValor av ON Av.Activo_Codigo=ac.Activo_Codigo AND av.Pardet_TipoDepreciacion=@cbo_Tipo_Depreciacion AND av.ActVal_Activo=1
      LEFT OUTER JOIN
      EntidadIdentificacion AS ei ON ei.Entida_Codigo = pr.Entida_Codigo AND ei.Pardet_Tipoidentificacion = 1

where dd.Deprec_Codigo=@ultimoperiodo
and dd.Pardet_TipoDepreciacion= @cbo_tipo_depreciacion

/*order by PardetTipo.Pardet_Descripcion*/

	end
END

GO

