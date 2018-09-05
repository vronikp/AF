Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
Imports System.ComponentModel
Imports ActivosFijos.Reglas

<ToolboxItem(True)> _
Public Class ComboBoxParametro
  Inherits ComboBoxDB
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property Op() As Infoware.Datos.OperadorDatos Implements Infoware.Datos.IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As Infoware.Datos.OperadorDatos)
      mOp = value
    End Set
  End Property

  Public Property Parametro() As WWTSParametro
    Get
      If mParametros Is Nothing OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mParametros(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As WWTSParametro)
      If value Is Nothing OrElse mParametros Is Nothing Then
        If MyBase.Items.Count > 0 Then
          MyBase.SelectedIndex = 0
        Else
          MyBase.SelectedIndex = -1
        End If
      Else
        MyBase.SelectedValue = value.Parame_Codigo
      End If
    End Set
  End Property

  Private mParametros As WWTSParametroList = Nothing

  Public Sub Llenar_Datos()
    If mOp Is Nothing Then
      Me.Items.Clear()
      Exit Sub
    End If

    mParametros = WWTSParametroList.ObtenerLista(mOp)

    MyBase.DisplayMember = "Parame_Descripcion"
    MyBase.ValueMember = "Parame_Codigo"
    MyBase.DataSource = mParametros
  End Sub

  Private Sub ComboBoxParametro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    PuedeNuevo = False
    PuedeModificar = False
    PuedeEliminar = False
    If mOp Is Nothing OrElse Me.SelectedIndex = -1 Then
      Exit Sub
    End If
  End Sub
End Class
