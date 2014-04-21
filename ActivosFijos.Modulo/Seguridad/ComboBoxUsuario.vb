Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Controles.Base
Imports System.ComponentModel
Imports ActivosFijos.Reglas


<ToolboxItem(True)> _
Public Class ComboBoxUsuario
  Inherits ComboBoxDB

  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      Llenar_datos()
    End Set
  End Property

  Private mUsuarios As WWTSUsuarioList
  Public Property Usuario() As WWTSUsuario
    Get
      If mUsuarios Is Nothing OrElse mUsuarios.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mUsuarios(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As WWTSUsuario)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.Usuari_Codigo
      End If
    End Set
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = False
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    If mOperadorDatos Is Nothing Then
      MyBase.DataSource = Nothing
    Else
      MyBase.DisplayMember = "Usuari_Descripcion"
      MyBase.ValueMember = "Usuari_Codigo"
      mUsuarios = WWTSUsuarioList.ObtenerLista(mOperadorDatos)
      MyBase.DataSource = mUsuarios
    End If
  End Sub
End Class

