Imports Infoware.Datos
Imports Infoware.Controles.Base
Imports System.ComponentModel
Imports Infoware.Controles.General

<ToolboxItem(True)> _
Public Class ComboBoxConexionOtros
  Inherits ComboBoxDB

  Private mArchivoxml As String
  Public Property Archivoxml() As String
    Get
      Return mArchivoxml
    End Get
    Set(ByVal value As String)
      mArchivoxml = value
    End Set
  End Property

  Private mConexiones As OperadorDatosList

  Public ReadOnly Property OperadorDatos() As OperadorDatos
    Get
      If mConexiones Is Nothing OrElse mConexiones.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mConexiones(MyBase.SelectedIndex)
      End If
    End Get
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = True
    MyBase.PuedeModificar = True
    MyBase.PuedeEliminar = True
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    MyBase.DisplayMember = "Descripcion"
    mConexiones = OperadorDatosList.dexml(Archivoxml)
    MyBase.DataSource = mConexiones
  End Sub

  Private Sub CtlConexion_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    Dim f As New Infoware.Controles.General.FrmConexion
    f.Direccion = IMantenimiento.Accion.Eliminacion
    f.OperadorDatos = mConexiones(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      mConexiones.RemoveAt(MyBase.SelectedIndex)
      mConexiones.axml(Archivoxml)
    End If
  End Sub

  Private Sub CtlConexion_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    Dim f As New Infoware.Controles.General.FrmConexion
    f.Direccion = IMantenimiento.Accion.Modificacion
    f.OperadorDatos = mConexiones(MyBase.SelectedIndex)
    If f.ShowDialog() = DialogResult.OK Then
      f.OperadorDatos.GuardarContrasena = True
      mconexiones(MyBase.selectedindex) = f.operadordatos
      mConexiones.axml(Archivoxml)
    End If
  End Sub

  Private Sub CtlConexion_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim f As New Infoware.Controles.General.FrmConexion
    f.Direccion = IMantenimiento.Accion.Ingreso
    f.OperadorDatos = Nothing ' New OperadorDatos("(local)", "database", "sa", String.Empty, True)
    If f.ShowDialog() = DialogResult.OK Then
      f.OperadorDatos.GuardarContrasena = True
      mConexiones.Add(f.OperadorDatos)
      mConexiones.axml(Archivoxml)
      MyBase.DataSource = Nothing
      MyBase.DisplayMember = "Descripcion"
      MyBase.DataSource = mConexiones
    End If
  End Sub
End Class

