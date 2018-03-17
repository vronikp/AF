

/****** Object:  View [dbo].[vw_TransaccionBaja]    Script Date: 03/14/2018 09:17:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[vw_TransaccionBaja]
AS
SELECT     Right('000000' + CONVERT(NVARCHAR, tb.TraBaj_Codigo), 6) as TraBaj_Codigo, tb.Usuari_Codigo, tb.TraBaj_Fecha, tb.TraBaj_Observacion, dbo.ParametroDetDescripcion(tb.Parame_TipoBaja, tb.Pardet_TipoBaja, ' > ') AS TipoBaja, act.Activo_CodigoBarra, 
                      dbo.ParametroDetDescripcion(act.Parame_ClaseActivo, act.Pardet_ClaseActivo, ' > ') AS Activo_Clase, act.Activo_Descripcion, dbo.ParametroDetDescripcion(act.Parame_Marca, act.Pardet_Marca, 
                      ' > ') AS Activo_Marca, act.Activo_Modelo, act.Activo_Serie, dbo.Fnc_CustodioActual(act.Activo_Codigo) AS CustodioActual, dbo.Fnc_UbicacionActual(act.Activo_Codigo) AS UbicacionActual, 
                      'El día ' + DATENAME(WEEKDAY, tb.TraBaj_Fecha) + ' ' + CAST(DAY(tb.TraBaj_Fecha) AS varchar) + ' de ' + DATENAME(MONTH, tb.TraBaj_Fecha) + ' de ' + CAST(YEAR(tb.TraBaj_Fecha) AS varchar) 
                      + ', se procede con la elaboración de la presente acta de baja definitiva de bienes de la compañía. Los bienes que dados de baja por el motivo ' + dbo.ParametroDetDescripcion(tb.Parame_TipoBaja,
                       tb.Pardet_TipoBaja, ' > ') + ' se detallan a continuación:' AS Cabecera, 
                      'Los firmantes de esta acta damos fe que los bienes detallados han sido dados de baja luego del debido análisis, que dan como resultado que estos bienes no son útiles para la operación de la empresa.'
                       AS Pie
FROM         dbo.TransaccionBaja AS tb INNER JOIN
                      dbo.Activo AS act ON tb.TraBaj_Codigo = act.TraBaj_Codigo

GO


