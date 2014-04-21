USE [AF_SRI_InvIniciado]
GO

/****** Object:  View [dbo].[vw_SRIActaConstatacion]    Script Date: 11/05/2012 13:01:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[vw_SRIActaConstatacion]
AS
SELECT     TOP (100) PERCENT dbo.Activo.Activo_Codigo, 
                      CASE WHEN dbo.InventarioDet.Pardet_EstadoInventario = 2 THEN ' BIENES CONSTATADOS FISICAMENTE' WHEN dbo.InventarioDet.Pardet_EstadoInventario IN (3, 
                      4) OR
                      ((dbo.InventarioDet.InvDet_esCambioCustodio = 1) AND (dbo.InventarioDet.Pardet_EstadoInventario = 2)) 
                      THEN 'BIENES ADICIONALES CONSTATADOS FISICAMENTE' WHEN dbo.InventarioDet.Pardet_EstadoInventario = 1 THEN 'BIENES NO CONSTATADOS FISICAMENTE' ELSE
                       '' END AS EstadoInv, dbo.vw_ReporteActivo.CustodioActual AS Custodio, dbo.vw_ReporteActivo.UbicacionActual AS Ubicacion, 
                      dbo.vw_ReporteActivo.Activo_Descripcion AS Descrpicion, dbo.vw_ReporteActivo.Activo_CodigoBarra AS CodigoBarras, dbo.vw_ReporteActivo.Marca, 
                      dbo.vw_ReporteActivo.Activo_Modelo AS Modelo, dbo.vw_ReporteActivo.Activo_Serie AS Serie, Area.Pardet_Descripcion AS Area, 
                      Departamento.Pardet_Descripcion AS Departamento, Ciudad.Pardet_Descripcion AS Ciudad, 
                      CASE WHEN pardet_estadoactivo = 1 THEN 'Bueno' WHEN pardet_estadoactivo = 3 THEN 'Regular' WHEN NOT pardet_estadoactivo IN (1, 3) 
                      THEN 'Malo' ELSE '' END AS Estado, dbo.ActivoCaracteristica.ActCar_Descripcion AS Llaves, Regional.Pardet_Descripcion AS Regional, 
                      agencia.Pardet_DatoStr1 AS Direccion, dbo.vw_Persona.Identificacion, dbo.Activo.Activo_FechaBaja, dbo.Fnc_UbicacionActual(dbo.Activo.Activo_Codigo) 
                      AS UbicacionActual, Regional.Pardet_DatoStr2 AS ResponsableReg
FROM         dbo.ParametroDet AS agencia INNER JOIN
                      dbo.vw_ReporteActivo INNER JOIN
                      dbo.InventarioDet ON dbo.vw_ReporteActivo.Activo_Codigo = dbo.InventarioDet.Activo_Codigo INNER JOIN
                      dbo.ActivoUbicacion ON dbo.vw_ReporteActivo.Activo_Codigo = dbo.ActivoUbicacion.Activo_Codigo INNER JOIN
                      dbo.ParametroDet AS Area ON dbo.ActivoUbicacion.Parame_Ubicacion = Area.Parame_Codigo AND 
                      dbo.ActivoUbicacion.Pardet_Ubicacion = Area.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS Departamento ON Area.Parame_Padre = Departamento.Parame_Codigo AND Area.Pardet_Padre = Departamento.Pardet_Secuencia ON 
                      agencia.Parame_Codigo = Departamento.Parame_Padre AND agencia.Pardet_Secuencia = Departamento.Pardet_Padre INNER JOIN
                      dbo.ParametroDet AS Ciudad ON agencia.Parame_Padre = Ciudad.Parame_Codigo AND agencia.Pardet_Padre = Ciudad.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS Provincia ON Ciudad.Parame_Padre = Provincia.Parame_Codigo AND Ciudad.Pardet_Padre = Provincia.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS Regional ON Provincia.Parame_Padre = Regional.Parame_Codigo AND Provincia.Pardet_Padre = Regional.Pardet_Secuencia INNER JOIN
                      dbo.Activo ON dbo.vw_ReporteActivo.Activo_Codigo = dbo.Activo.Activo_Codigo INNER JOIN
                      dbo.ActivoCaracteristica ON dbo.vw_ReporteActivo.Activo_Codigo = dbo.ActivoCaracteristica.Activo_Codigo INNER JOIN
                      dbo.ActivoCustodio ON dbo.Activo.Activo_Codigo = dbo.ActivoCustodio.Activo_Codigo INNER JOIN
                      dbo.vw_Persona ON dbo.ActivoCustodio.Emplea_Custodio = dbo.vw_Persona.Entida_Codigo
WHERE     (dbo.ActivoUbicacion.ActUbi_Activo = 1) AND (dbo.ActivoCaracteristica.Pardet_Caracteristica IN (81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94)) AND 
                      (dbo.ActivoCustodio.ActCus_Activo = 1)
ORDER BY EstadoInv

GO


