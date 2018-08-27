

/****** Object:  View [dbo].[vw_ReporteActivoIngreso]    Script Date: 04/11/2018 07:03:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [dbo].[vw_ReporteActivoIngreso]
AS
SELECT     prov.NombreCompleto AS Proveedor, prov.Entida_Codigo AS ProveedorCodigo, fact.Factura_Numero, 
DATENAME(WEEKDAY, Factura_Fecha) + ' ' + CAST(DAY(Factura_Fecha) AS varchar) +
		 ' de ' + DATENAME(MONTH, Factura_Fecha) + ' de ' + CAST(YEAR(Factura_Fecha) AS varchar) as Factura_Fecha, cust.NombreCompleto AS Custodio, cust.Entida_Codigo AS CustodioCodigo, 
                      dbo.ParametroDetDescripcion(actubi.Parame_Ubicacion, actubi.Pardet_Ubicacion, ' > ') AS UbicacionInicial, dbo.Activo.Activo_Codigo, dbo.Activo.Activo_Serie, 
                      PardetGrupo.Pardet_Descripcion AS Grupo, PardetTipo.Pardet_Descripcion AS Tipo, PardetClase.Pardet_Descripcion AS Clase, dbo.Activo.Activo_CodigoBarra, dbo.Activo.Activo_CodigoAux, 
                      dbo.Activo.Activo_Descripcion, PardetMarca.Pardet_Descripcion AS Marca, dbo.Activo.Activo_Modelo, dbo.Activo.Activo_Observacion, 
                      PardetEstadoDepreciacion.Pardet_Descripcion AS Estado_Depreciacion, PardetEstadoActivo.Pardet_Descripcion AS Estado_Activo, dbo.Activo.Activo_ResponsableMantenimiento, 
                      dbo.Activo.Activo_FechaIngreso, dbo.Activo.Activo_FechaCompra, dbo.Activo.Activo_FechaUso, dbo.Activo.Activo_FechaGarantia, PardetCentroCosto.Pardet_Descripcion AS Centro_Costo, 
                      dbo.Activo.Factura_Codigo, dbo.Activo.Activo_FechaBaja, PardetTipoBajaActivo.Pardet_Descripcion AS TipoBajaActivo, dbo.Fnc_Caracteristicas(dbo.Activo.Activo_Codigo) AS Caracteristicas, 
                      dbo.Activo.Pardet_Marca, dbo.Activo.Parame_ClaseActivo, dbo.Activo.Pardet_ClaseActivo, PardetGrupo.Pardet_Secuencia AS codGrupo, PardetTipo.Pardet_Secuencia AS codTipo, 
                      PardetClase.Pardet_Secuencia AS codClase, dbo.Activo.Activo_CodigoBarraCruce, actubi.Parame_Ubicacion, actubi.Pardet_Ubicacion, dbo.ActivoValor.ActVal_Costo AS CostoOriginal, 
                      cust.Identificacion AS CustodioCI
FROM         dbo.Activo INNER JOIN
                      dbo.ActivoCustodio AS actcus ON dbo.Activo.Activo_Codigo = actcus.Activo_Codigo AND actcus.ActCus_Secuencia = 1 INNER JOIN
                      dbo.ActivoUbicacion AS actubi ON dbo.Activo.Activo_Codigo = actubi.Activo_Codigo AND actubi.ActUbi_Secuencia = 1 INNER JOIN
                      dbo.FacturaActivo AS fact ON dbo.Activo.Factura_Codigo = fact.Factura_Codigo INNER JOIN
                      dbo.vw_Persona AS prov ON fact.Entida_Proveedor = prov.Entida_Codigo INNER JOIN
                      dbo.vw_Persona AS cust ON actcus.Emplea_Custodio = cust.Entida_Codigo INNER JOIN
                      dbo.ParametroDet AS PardetClase ON dbo.Activo.Parame_ClaseActivo = PardetClase.Parame_Codigo AND dbo.Activo.Pardet_ClaseActivo = PardetClase.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetTipo ON PardetClase.Parame_Padre = PardetTipo.Parame_Codigo AND PardetClase.Pardet_Padre = PardetTipo.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetGrupo ON PardetTipo.Parame_Padre = PardetGrupo.Parame_Codigo AND PardetTipo.Pardet_Padre = PardetGrupo.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetMarca ON dbo.Activo.Parame_Marca = PardetMarca.Parame_Codigo AND dbo.Activo.Pardet_Marca = PardetMarca.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetEstadoDepreciacion ON dbo.Activo.Parame_EstadoDepreciacion = PardetEstadoDepreciacion.Parame_Codigo AND 
                      dbo.Activo.Pardet_EstadoDepreciacion = PardetEstadoDepreciacion.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetEstadoActivo ON dbo.Activo.Parame_EstadoActivo = PardetEstadoActivo.Parame_Codigo AND 
                      dbo.Activo.Pardet_EstadoActivo = PardetEstadoActivo.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS PardetCentroCosto ON dbo.Activo.Parame_CentroCosto = PardetCentroCosto.Parame_Codigo AND 
                      dbo.Activo.Pardet_CentroCosto = PardetCentroCosto.Pardet_Secuencia LEFT OUTER JOIN
                      dbo.ActivoValor ON dbo.Activo.Activo_Codigo = dbo.ActivoValor.Activo_Codigo AND dbo.ActivoValor.ActVal_Secuencia = 1 AND dbo.ActivoValor.Pardet_TipoDepreciacion = 1 LEFT OUTER JOIN
                      dbo.ParametroDet AS PardetTipoBajaActivo ON dbo.Activo.Parame_TipoBajaActivo = PardetTipoBajaActivo.Parame_Codigo AND 
                      dbo.Activo.Pardet_TipoBajaActivo = PardetTipoBajaActivo.Pardet_Secuencia


GO


