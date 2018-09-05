Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports ActivosFijos.Modulo.clsReporteActivo
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReporteListaActivos
  Private mdsReporteActivos As dsReporteActivos
  Public Property dsReporteActivos As dsReporteActivos
    Get
      Return mdsReporteActivos
    End Get
    Set(value As dsReporteActivos)
      mdsReporteActivos = value
      llenar_datos()
    End Set
  End Property

  Private mFiltro As String
  Public Property Filtro As String
    Get
      Return mFiltro
    End Get
    Set(value As String)
      mFiltro = value
    End Set
  End Property

  Private mListaActivosOrden As EnumListaActivosOrden = EnumListaActivosOrden.GrupoTipoClase
  Public Property ListaActivosOrden As EnumListaActivosOrden
    Get
      Return mListaActivosOrden
    End Get
    Set(value As EnumListaActivosOrden)
      mListaActivosOrden = value
    End Set
  End Property

  Sub llenar_datos()
    Try
      Dim info As ReportClass = Nothing
      Select Case ListaActivosOrden
        Case EnumListaActivosOrden.GrupoTipoClase
          info = New crpListaActivosporGrupoTipoClase
        Case EnumListaActivosOrden.Custodio
          info = New crpListaActivosporCustodio
        Case EnumListaActivosOrden.Ubicacion
          info = New crpListaActivosporUbicacion
      End Select
      info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)
      info.DataDefinition.FormulaFields("filtro").Text = String.Format("'{0}'", Filtro)

      info.SetDataSource(dsReporteActivos)
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

  End Sub
#End Region


End Class