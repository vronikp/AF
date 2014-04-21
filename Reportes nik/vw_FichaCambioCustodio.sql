create view vw_FichaCambioCustodio
as
SELECT     Activos.Activo_Codigo AS Codigo, Activos.Activo_CodigoBarra AS CodigoBarras, pdClase.Pardet_Padre AS CodigoTipo, Activos.Activo_Descripcion AS Descripcion, 
                      pdClase.Pardet_Descripcion AS Marca, Activos.Activo_Modelo AS Modelo, dbo.Fnc_CustodioActual(Activos.Activo_Codigo) AS CustodioActual, 
                      dbo.Fnc_CustodioAnterior(Activos.Activo_Codigo) AS CustodioAnterior, CASE WHEN pardet_estadoactivo = 1 THEN 'x' ELSE '' END AS Bueno, 
                      CASE WHEN pardet_estadoactivo = 3 THEN 'x' ELSE '' END AS Regular, CASE WHEN NOT pardet_estadoactivo IN (1, 3) THEN 'x' ELSE '' END AS Malo, 
                      CASE WHEN pdClase.Pardet_Padre IN (6, 9, 11) THEN 'x' ELSE '' END AS SujetoControl, CASE WHEN NOT pdClase.Pardet_Padre IN (6, 9, 11) 
                      THEN 'x' ELSE '' END AS ActivoFijo, dbo.ActivoCustodio.ActCus_FechaDesde AS FechaCambio, pdCiudad.Pardet_Descripcion AS Ciudad, 
                      dbo.Fnc_CustodioActualIdentificacion(Activos.Activo_Codigo) AS CustodioActId, dbo.Fnc_CustodioAnteriorIdentificacion(Activos.Activo_Codigo) AS CustodioAntId
FROM         dbo.ParametroDet AS pdDept INNER JOIN
                      dbo.Activo AS Activos INNER JOIN
                      dbo.ParametroDet AS pdClase ON Activos.Parame_ClaseActivo = pdClase.Parame_Codigo AND Activos.Pardet_ClaseActivo = pdClase.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS pdMarca ON Activos.Parame_Marca = pdMarca.Parame_Codigo AND Activos.Pardet_Marca = pdMarca.Pardet_Secuencia INNER JOIN
                      dbo.ActivoCustodio ON Activos.Activo_Codigo = dbo.ActivoCustodio.Activo_Codigo INNER JOIN
                      dbo.ActivoUbicacion ON Activos.Activo_Codigo = dbo.ActivoUbicacion.Activo_Codigo INNER JOIN
                      dbo.ParametroDet AS pdArea ON dbo.ActivoUbicacion.Parame_Ubicacion = pdArea.Parame_Codigo AND 
                      dbo.ActivoUbicacion.Pardet_Ubicacion = pdArea.Pardet_Secuencia ON pdDept.Parame_Codigo = pdArea.Parame_Padre AND 
                      pdDept.Pardet_Secuencia = pdArea.Pardet_Padre INNER JOIN
                      dbo.ParametroDet AS pdEdif ON pdDept.Parame_Padre = pdEdif.Parame_Codigo AND pdDept.Pardet_Padre = pdEdif.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS pdCiudad ON pdEdif.Parame_Padre = pdCiudad.Parame_Codigo AND pdEdif.Pardet_Padre = pdCiudad.Pardet_Secuencia
WHERE     (dbo.ActivoUbicacion.ActUbi_Activo = 1) AND (dbo.ActivoCustodio.ActCus_Activo = 1)