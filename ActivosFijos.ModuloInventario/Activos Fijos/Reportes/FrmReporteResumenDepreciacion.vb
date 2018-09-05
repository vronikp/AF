Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmReporteResumenDepreciacion
  Sub llenar_datos()
    If cbotipodepreciacion.ParametroDet Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpReporteResumenDepreciacion
      info.DataDefinition.FormulaFields("cortado_al").Text = String.Format("'{0}'", Me.DateTimePicker1.Value.ToLongDateString)
      info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)

      info.SetDataSource(clsReporteResumenDepreciacion.RetornarResumenDepreciacionDS(Me.cbotipodepreciacion.ParametroDet, Me.DateTimePicker1.Value))
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cbotipodepreciacion.Parametro = Enumerados.EnumParametros.TipoDepreciacion
    Me.cbotipodepreciacion.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipodepreciacion.Llenar_Datos()
  End Sub
#End Region

  Private Sub btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrar.Click
    llenar_datos()
  End Sub
End Class