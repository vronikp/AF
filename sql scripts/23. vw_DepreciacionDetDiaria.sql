
/****** Object:  View [dbo].[vw_DepreciacionDetDiaria]    Script Date: 04/11/2018 06:44:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_DepreciacionDetDiaria]
AS
SELECT     TOP (100) PERCENT act.Activo_CodigoBarra AS CodigoBarras, pdTipo.Pardet_Descripcion AS Tipo, pdClase.Pardet_Descripcion AS Clase, dd.Deprec_Ubicacion, 
                      act.Activo_FechaIngreso AS FechaInicioDep, av.ActVal_FechaValoracion AS FechaValoracion,
                          (SELECT     ActVal_Costo
                            FROM          dbo.ActivoValor AS av2
                            WHERE      (Activo_Codigo = act.Activo_Codigo) AND (Pardet_TipoDepreciacion = dd.Pardet_TipoDepreciacion) AND (Pardet_TipoValoracion = 1)) AS Inicial, av.ActVal_Costo AS Valoracion, 
                      av.ActVal_Salvamento AS Salvamento, av.ActVal_PeriodosDepreciables AS VidaUtil, LEFT(dd.Deprec_Codigo, 4) AS Año, dd.Deprec_Valor AS DepreciacionPeriodo, 
                      dd.Deprec_PeriodosDepreciados AS PeriodosDepreciados, dd.Deprec_DepreciacionAcumulada AS DepreciacionAcumulada, av.ActVal_Costo - dd.Deprec_DepreciacionAcumulada AS ValorEnLibros, 
                      dd.Deprec_DepreciacionAcumulada - dd.Deprec_Valor AS DepreciacionAcumuladaAnt,
                          (SELECT     SUM(Deprec_Valor) AS Expr1
                            FROM          dbo.DepreciacionDet AS dd1
                            WHERE      (Activo_Codigo = act.Activo_Codigo) AND (Pardet_TipoDepreciacion = dd.Pardet_TipoDepreciacion) AND (Deprec_Codigo BETWEEN LEFT(dd.Deprec_Codigo, 6) * 100 + 1 AND 
                                                   dd.Deprec_Codigo)) AS DepreciacionMes,
                          (SELECT     SUM(Deprec_Valor) AS Expr1
                            FROM          dbo.DepreciacionDet AS dd1
                            WHERE      (Activo_Codigo = act.Activo_Codigo) AND (Pardet_TipoDepreciacion = dd.Pardet_TipoDepreciacion) AND (Deprec_Codigo BETWEEN LEFT(dd.Deprec_Codigo, 4) * 10000 + 101 AND 
                                                   dd.Deprec_Codigo)) AS DepreciacionAnio, dd.Pardet_TipoDepreciacion, act.Activo_FechaIngreso, av.ActVal_FechaValoracion, dd.Deprec_Codigo, act.Activo_FechaBaja
FROM         dbo.Activo AS act LEFT OUTER JOIN
                      dbo.ParametroDet AS pdClase ON act.Parame_ClaseActivo = pdClase.Parame_Codigo AND act.Pardet_ClaseActivo = pdClase.Pardet_Secuencia LEFT OUTER JOIN
                      dbo.ParametroDet AS pdTipo ON pdClase.Parame_Padre = pdTipo.Parame_Codigo AND pdClase.Pardet_Padre = pdTipo.Pardet_Secuencia LEFT OUTER JOIN
                      dbo.DepreciacionDet AS dd ON act.Activo_Codigo = dd.Activo_Codigo LEFT OUTER JOIN
                      dbo.ActivoValor AS av ON act.Activo_Codigo = av.Activo_Codigo AND dd.ActVal_Secuencia = av.ActVal_Secuencia AND av.Pardet_TipoDepreciacion = dd.Pardet_TipoDepreciacion
ORDER BY CodigoBarras

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
         Begin Table = "act"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 294
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdClase"
            Begin Extent = 
               Top = 6
               Left = 332
               Bottom = 126
               Right = 513
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pdTipo"
            Begin Extent = 
               Top = 6
               Left = 551
               Bottom = 126
               Right = 732
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dd"
            Begin Extent = 
               Top = 6
               Left = 770
               Bottom = 126
               Right = 1014
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "av"
            Begin Extent = 
               Top = 6
               Left = 1052
               Bottom = 126
               Right = 1296
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
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DepreciacionDetDiaria'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DepreciacionDetDiaria'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DepreciacionDetDiaria'
GO


