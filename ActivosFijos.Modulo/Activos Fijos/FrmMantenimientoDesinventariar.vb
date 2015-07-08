Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas

Public Class FrmMantenimientoDesinventariar
    Private mActivos As ActivoList = Nothing
    Public Property Activos As ActivoList
        Get
            Return mActivos
        End Get
        Set(value As ActivoList)
            mActivos = value
            llenar_datos()
        End Set
    End Property

    Private mInventario As Inventario = Nothing
    Public Property Inventario As Inventario
        Get
            Return mInventario
        End Get
        Set(value As Inventario)
            mInventario = value
        End Set
    End Property

    Sub llenar_datos()
        Me.bsdets.DataSource = mActivos
        Me.dgdets.AutoDiscover()
    End Sub

    Private Sub FrmMantenimientoBajaActivo_Guardar(sender As Object, e As System.EventArgs) Handles Me.Guardar
        If mActivos Is Nothing Then
            Exit Sub
        End If

        For Each _activo As Activo In mActivos
            Dim invdet As InventarioDet = Nothing
            Try
                invdet = New InventarioDet(Sistema.OperadorDatos, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario, _activo.Activo_Codigo)
                If invdet.Pardet_EstadoInventario = Enumerados.enumEstadoInventarioActivo.NoInventariado Then
                    MsgBox("El activo " + _activo.Activo_CodigoBarra + " ya tiene el estado No Inventariado", MsgBoxStyle.Critical, "Error")
                    'Exit Sub
                Else
                    invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.NoInventariado)
                    If invdet.Guardar() Then
                        MsgBox("El activo " + _activo.Activo_CodigoBarra + " fue No Inventariado con éxito", MsgBoxStyle.Information, "Información")
                        Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Asignar estado No Inventariado {0} {1}", _activo.Activo_CodigoBarra, _activo.Descripcion))
                    Else
                        MsgBox(invdet.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Catch ex As Exception
                MsgBox("No existe el activo " + _activo.Activo_CodigoBarra + " en el inventario actual", MsgBoxStyle.Critical, "Error")
                'Exit Sub
            End Try
        Next
        Me.Close()
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
        MyBase.Tabla = "Asignar estado No inventariado"

    End Sub
#End Region

End Class