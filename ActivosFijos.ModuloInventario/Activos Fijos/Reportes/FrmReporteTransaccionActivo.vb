Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports ActivosFijos.ModuloInventario.clsReporteTransaccionActivo
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReporteTransaccionActivo
    Private mTransaccionActivo As TransaccionActivo = Nothing
    Public Property TransaccionActivo As TransaccionActivo
        Get
            Return mTransaccionActivo
        End Get
        Set(value As TransaccionActivo)
            mTransaccionActivo = value
            llenar_datos()
        End Set
    End Property

    Private mReporteTransaccionTipo As EnumListaTransaccionTipo '= EnumListaActivosOrden.GrupoTipoClase
    Public Property ReporteTransaccionTipo As EnumListaTransaccionTipo
        Get
            Return mReporteTransaccionTipo
        End Get
        Set(value As EnumListaTransaccionTipo)
            mReporteTransaccionTipo = value
        End Set
    End Property

    Sub llenar_datos()
        Try
            If ReporteTransaccionTipo = EnumListaTransaccionTipo.Resumen Then
                Dim info As New crpTransaccionActivo
                info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)
                'info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Desde {0} Hasta {1}'", Me.dtfecdesde.Value.ToShortDateString, Me.dtfechasta.Value.ToShortDateString)

                info.SetDataSource(clsReporteTransaccionActivo.RetornarTransaccionActivoDS(mTransaccionActivo))
                info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                'Me.CrystalReportViewer1.Zoom(1)
                Me.ReporteDatos = info
            ElseIf ReporteTransaccionTipo = EnumListaTransaccionTipo.Custodio1 Then
                Dim info As New crpTransaccionActivoCustodio
                info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)
                'info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Desde {0} Hasta {1}'", Me.dtfecdesde.Value.ToShortDateString, Me.dtfechasta.Value.ToShortDateString)

                info.SetDataSource(clsReporteTransaccionActivo.RetornarTransaccionActivoCustodioDS(mTransaccionActivo))
                info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                'Me.CrystalReportViewer1.Zoom(1)
                Me.ReporteDatos = info
            ElseIf ReporteTransaccionTipo = EnumListaTransaccionTipo.Custodio2 Then
                Dim info As New crpTransaccionActivoCustodio2
                info.SetDataSource(clsReporteTransaccionActivo.RetornarTransaccionActivoCustodio2DS(mTransaccionActivo))
                info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                'Me.CrystalReportViewer1.Zoom(1)
                Me.ReporteDatos = info
            ElseIf ReporteTransaccionTipo = EnumListaTransaccionTipo.Ubicacion Then
                Dim info As New crpTransaccionActivoUbicacion
                info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)
                'info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Desde {0} Hasta {1}'", Me.dtfecdesde.Value.ToShortDateString, Me.dtfechasta.Value.ToShortDateString)

                info.SetDataSource(clsReporteTransaccionActivo.RetornarTransaccionActivoUbicacionDS(mTransaccionActivo))
                info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                'Me.CrystalReportViewer1.Zoom(1)
                Me.ReporteDatos = info
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.CtlPersona1.PuedeElegirTipoEntidad = True
        FrmMantenimientoActivo_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

    Private Sub FrmMantenimientoActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar

    End Sub
#End Region


End Class