Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
Imports System.ComponentModel
Imports ActivosFijos.Reglas

<ToolboxItem(True)> _
Public Class CtlInventario
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

  Private mPardetPeriodoInventario As WWTSParametroDet = Nothing
  Public Property PardetPeriodoInventario As WWTSParametroDet
    Get
      Return mPardetPeriodoInventario
    End Get
    Set(value As WWTSParametroDet)
      mPardetPeriodoInventario = value
    End Set
  End Property

  Public Property Inventario() As Inventario
    Get
      If mInventarios Is Nothing OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mInventarios(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Inventario)
      If value Is Nothing OrElse mInventarios Is Nothing Then
        If MyBase.Items.Count > 0 Then
          MyBase.SelectedIndex = 0
        Else
          MyBase.SelectedIndex = -1
        End If
      Else
        Dim index = -1
        For Each inven As Inventario In mInventarios
          index += 1
          If inven.Pardet_PeriodoInventario = value.Pardet_PeriodoInventario And inven.Pardet_Ubicacion = value.Pardet_Ubicacion Then
            MyBase.SelectedIndex = index
            Exit For
          End If
        Next
      End If
    End Set
  End Property

  Private mInventarios As InventarioList = Nothing

  Public Sub Llenar_Datos()
    If mOp Is Nothing Then
      Me.Items.Clear()
      Exit Sub
    End If

    mInventarios = InventarioList.ObtenerLista(mOp, Nothing, mPardetPeriodoInventario)

    MyBase.DisplayMember = "Descripcion"
    MyBase.DataSource = mInventarios
  End Sub

  Private Sub ComboBoxInventario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    PuedeNuevo = False
    PuedeModificar = False
    PuedeEliminar = False
    If mOp Is Nothing OrElse Me.SelectedIndex = -1 Then
      Exit Sub
    End If
  End Sub
End Class
