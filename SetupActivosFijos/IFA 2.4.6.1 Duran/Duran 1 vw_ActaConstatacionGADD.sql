
/****** Object:  View [dbo].[vw_ActaConstatacionGADD]    Script Date: 11/28/2017 17:16:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_ActaConstatacionGADD]
AS
SELECT     'En el Cantón Eloy Alfaro Duran a los ' + CAST(DAY(GETDATE()) AS nvarchar) + ' días del mes de ' + CASE month(getdate()) 
                      WHEN 1 THEN 'Enero' WHEN 2 THEN 'Febrero' WHEN 3 THEN 'Marzo' WHEN 4 THEN 'Abril' WHEN 5 THEN 'Mayo' WHEN 6 THEN 'Junio' WHEN 7 THEN 'Julio' WHEN 8 THEN 'Agosto' WHEN 9 THEN
                       'Septiembre' WHEN 10 THEN 'Octubre' WHEN 11 THEN 'Noviembre' WHEN 12 THEN 'Diciembre' ELSE '' END + CAST(YEAR(GETDATE()) AS nvarchar) 
                      + 'comparecen en la celebración de la presente acta, por una parte a la ING: KATHERINE LOZANO JAMA, en su calidad de Jefa de Guardalmacén y Control de Bienes, y por otra parte ' + UPPER(dbo.vw_Persona.NombreCompleto)
                       + ', con la finalidad de proceder a la entrega-recepción de bienes, cuyas especificaciones y características se detalla a continuación: ' AS Cabecera, 
                      dbo.vw_Persona.NombreCompleto AS CustodioActual, dbo.vw_Persona.Identificacion AS IdCustodioActual, CASE WHEN dbo.InventarioDet.Pardet_EstadoInventario = 4 OR
                      ((dbo.InventarioDet.InvDet_esCambioCustodio = 1) AND (dbo.InventarioDet.Pardet_EstadoInventario = 2)) 
                      THEN 'BIENES ADICIONALES CONSTATADOS FISICAMENTE' WHEN dbo.InventarioDet.Pardet_EstadoInventario IN (2, 3) 
                      THEN ' BIENES CONSTATADOS FISICAMENTE' WHEN dbo.InventarioDet.Pardet_EstadoInventario = 1 THEN 'BIENES NO CONSTATADOS FISICAMENTE' ELSE '' END AS EstadoInv, 
                      dbo.ParametroDetDescripcion(dbo.ActivoUbicacion.Parame_Ubicacion, dbo.ActivoUbicacion.Pardet_Ubicacion, '>') AS UbicacionActual, dbo.Activo.Activo_CodigoBarra AS CodigoBarras, 
                      upper(pdClase.Pardet_Descripcion + ' ' + dbo.Activo.Activo_Descripcion + ' ' + dbo.Fnc_Caracteristicas(dbo.Activo.Activo_Codigo)) AS Descripcion, '1' AS Cantidad, Marca.Pardet_Descripcion AS Marca, 
                      dbo.Activo.Activo_Modelo AS Modelo, dbo.Activo.Activo_Serie AS Serie, pdEstado.Pardet_Descripcion AS Estado, dbo.Activo.Activo_Codigo, dbo.Activo.Activo_FechaBaja, 
                      dbo.InventarioDet.Parame_Ubicacion, dbo.InventarioDet.Pardet_Ubicacion, dbo.InventarioDet.Parame_PeriodoInventario, dbo.InventarioDet.Pardet_PeriodoInventario, 
                      dbo.InventarioDet.Pardet_EstadoInventario, dbo.ActivoCustodio.Emplea_Custodio, dbo.InventarioDet.InvDet_esCambioCustodio, dbo.ActivoCustodio.ActCus_FechaDesde AS FechaCambio, 
                      pdClase.Pardet_Descripcion AS Clase, pdTipo.Pardet_Descripcion AS Tipo, pdPeriodoInv.Pardet_Descripcion AS PeriodoInv, dbo.ParametroDetDescripcion(dbo.InventarioDet.Parame_Ubicacion, 
                      dbo.InventarioDet.Pardet_Ubicacion, '>') AS UbicacionInv, dbo.InventarioDet.Usuari_CodigoPDA, dbo.InventarioDet.Usuari_FechaHoraRegistro, 
                      'Por su parte ' + UPPER(dbo.vw_Persona.NombreCompleto) 
                      + ', responsable del uso y custodia del bien, se compromete a observar, cumplir y hacer cumplir las disposiciones constantes en los cuerpos legales que regulan el manejo y administraciones de los bienes del sector público, fundamentalmente las siguientes: '
                       AS Pie1, 'REGLAMENTO GENERAL PARA LA ADMINISTRACION, UTILIZACION, MANEJO Y CONTROL DE LOS BIENES Y EXISTENCIAS DEL SECTOR PUBLICO. ' AS Pie2, 
                      'Art. 3.- “(…) La consevaciones, buen uso y mantenimiento de los bienes, sera de responsabilidad directa del servidor que los ha recibido para el desempeño de sus funciones y labores oficiales (…) El daño, perdida o destrucción, por negligencia comprobada o su mal uso, no imputable al deterioro normal de las cosas, sera de responsabilidad del servidor que lo tiene a su cargo, y de los servidores que de cualquier manera tienen acceso al bien (…) salvo que se conozca o se compruebe la identidad de la  persona causante de la afectación del bien”. '
                       AS Pie3, 
                      'Art. 94.- Procedencia.- Habra lugar a la entrega – recepción en todos los casos de compra, venta, permuta, transferencia gratuita, traspaso de bienes, comodato, o cuando el servidor encargado de su custodia y administración sea reemplazado por otro (…)'
                       AS Pie4, 
                      'Sobre la base del Art. precedente, el usuario se encuentra en la obligación de realizar la correspondiente entrega – recepción, mediante acta al momento que se produzca su ausencia temporal o definitiva, o cuando la autoridad competente lo disponga. '
                       AS Pie5, 'OBSERVACION: ' AS Pie6, 
                      'Es importante indicar que hasta que no se culmine con el proceso de depuración, validación, constatación, verificación y codificación, en lo que respecta a activos fijos y bienes de control administrativo del G.A.D Municipal el Cantón Duran, las actas de entrega recepción realizada en periodos anteriores a los funcionarios custodios, se mantendrá.'
                       AS Pie7, 'Seguidamente de este trámite se informara a cada uno de los custodios sobre las anulaciones de las actas de entrega recepción. ' AS Pie8, 
                      'Por último, se procede a suscribir la presente acta de entrega recepción a partir de la presente fecha. ' AS Pie9, 
                      'Para constancia y en fe de lo actuado, firman las partes que aquí intervienen, en unidad de acto, en tres originales. ' AS Pie10
FROM         dbo.ParametroDet AS Marca INNER JOIN
                      dbo.Activo INNER JOIN
                      dbo.ParametroDet AS pdClase ON dbo.Activo.Parame_ClaseActivo = pdClase.Parame_Codigo AND dbo.Activo.Pardet_ClaseActivo = pdClase.Pardet_Secuencia INNER JOIN
                      dbo.InventarioDet ON dbo.Activo.Activo_Codigo = dbo.InventarioDet.Activo_Codigo ON Marca.Parame_Codigo = dbo.Activo.Parame_Marca AND 
                      Marca.Pardet_Secuencia = dbo.Activo.Pardet_Marca INNER JOIN
                      dbo.ActivoUbicacion ON dbo.InventarioDet.Activo_Codigo = dbo.ActivoUbicacion.Activo_Codigo AND 
                      dbo.ActivoUbicacion.ActUbi_Secuencia = CASE WHEN InventarioDet.InvDet_esCambioUbicacion = 1 THEN ActUbi_SecuenciaActual ELSE ActUbi_SecuenciaAnterior END INNER JOIN
                      dbo.ActivoCustodio ON dbo.InventarioDet.Activo_Codigo = dbo.ActivoCustodio.Activo_Codigo AND 
                      dbo.ActivoCustodio.ActCus_Secuencia = CASE WHEN InventarioDet.InvDet_esCambioCustodio = 1 THEN ActCus_SecuenciaActual ELSE ActCus_SecuenciaAnterior END INNER JOIN
                      dbo.vw_Persona ON dbo.ActivoCustodio.Emplea_Custodio = dbo.vw_Persona.Entida_Codigo INNER JOIN
                      dbo.ParametroDet AS pdTipo ON pdClase.Parame_Padre = pdTipo.Parame_Codigo AND pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS pdEstado ON dbo.Activo.Parame_EstadoActivo = pdEstado.Parame_Codigo AND dbo.Activo.Pardet_EstadoActivo = pdEstado.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS pdPeriodoInv ON dbo.InventarioDet.Parame_PeriodoInventario = pdPeriodoInv.Parame_Codigo AND 
                      dbo.InventarioDet.Pardet_PeriodoInventario = pdPeriodoInv.Pardet_Secuencia INNER JOIN
                      dbo.ParametroDet AS pdUbicacionInv ON dbo.InventarioDet.Parame_Ubicacion = pdUbicacionInv.Parame_Codigo AND dbo.InventarioDet.Pardet_Ubicacion = pdUbicacionInv.Pardet_Secuencia

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Marca"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Activo"
            Begin Extent = 
               Top = 6
               Left = 257
               Bottom = 126
               Right = 513
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdClase"
            Begin Extent = 
               Top = 6
               Left = 551
               Bottom = 126
               Right = 732
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "InventarioDet"
            Begin Extent = 
               Top = 6
               Left = 770
               Bottom = 126
               Right = 989
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ActivoUbicacion"
            Begin Extent = 
               Top = 6
               Left = 1027
               Bottom = 126
               Right = 1212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ActivoCustodio"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 246
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_Persona"
            Begin Extent = 
               Top = 6
               Left = 1250
               Bottom = 111
               Right = 1421
            End
            D' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ActaConstatacionGADD'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'isplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdTipo"
            Begin Extent = 
               Top = 114
               Left = 1250
               Bottom = 234
               Right = 1431
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdEstado"
            Begin Extent = 
               Top = 126
               Left = 327
               Bottom = 246
               Right = 508
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdPeriodoInv"
            Begin Extent = 
               Top = 126
               Left = 546
               Bottom = 246
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdUbicacionInv"
            Begin Extent = 
               Top = 126
               Left = 765
               Bottom = 246
               Right = 946
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ActaConstatacionGADD'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ActaConstatacionGADD'
GO


