Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class CtlParametroDetAnidado
  Public ReadOnly Property Sistema() As Sistema
    Get
      Dim _sistema As Sistema = Nothing
      Dim _control As Control = Me.Parent
      While True
        If TypeOf _control Is FrmFormaBase Then
          Exit While
        End If
        _control = _control.Parent
      End While
      _sistema = CType(_control, FrmFormaBase).Sistema
      Return _sistema
    End Get
  End Property

  Public Property SoloVisibles As Boolean
    Get
      Return Me.TreeviewParametroDet1.SoloVisibles
    End Get
    Set(value As Boolean)
      Me.TreeviewParametroDet1.SoloVisibles = value
    End Set
  End Property

  Public ReadOnly Property Largo As Decimal
    Get
      If Me.TreeviewParametroDet1.Visible = False Then
        Return Me.FlowLayoutPanel1.Height
      Else
        Return Me.FlowLayoutPanel1.Height + 116
      End If
    End Get
  End Property

  Public Property ParametroEnum As Enumerados.EnumParametros
    Get
      Return Me.TreeviewParametroDet1.ParametroEnum
    End Get
    Set(value As Enumerados.EnumParametros)
      Me.TreeviewParametroDet1.ParametroEnum = value
    End Set
  End Property

  Public Property PardetRaiz As WWTSParametroDet
    Get
      Return Me.TreeviewParametroDet1.PardetRaiz
    End Get
    Set(value As WWTSParametroDet)
      Me.TreeviewParametroDet1.PardetRaiz = value
    End Set
  End Property

  Public Property ParametroDet As WWTSParametroDet
    Get
      Return Me.TreeviewParametroDet1.ParametroDet
    End Get
    Set(value As WWTSParametroDet)
      If value IsNot Nothing Then
        Me.TreeviewParametroDet1.ParametroDet = value
      End If
    End Set
  End Property

  Public Event DespuesSeleccionar As EventHandler
  Public Event CambiarLargo As EventHandler
  Private Sub TreeviewParametroDet1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeviewParametroDet1.AfterSelect
    Me.FlowLayoutPanel1.Controls.Clear()
    If ParametroDet Is Nothing Then
      Exit Sub
    End If
    Dim _controles As New List(Of Control)
    Dim _pardet As WWTSParametroDet = ParametroDet
    Dim _primero As Boolean = True
    While _pardet IsNot Nothing
      If Not _primero Then
        Dim _label As New Label
        _label.AutoSize = True
        _label.Text = ">"
        _controles.Insert(0, _label)
      End If
      _primero = False

      Dim _link As New LinkLabel
      _link.Text = _pardet.Descripcion.Trim
      _link.Tag = _pardet
      _link.AutoSize = True
      AddHandler _link.Click, AddressOf linkclick
      'Me.FlowLayoutPanel1.Controls.Add(_link)
      _controles.Insert(0, _link)
      _pardet = _pardet.PardetPadre
    End While

    Dim _height As Integer = 15
    For Each _control As Control In _controles
      Me.FlowLayoutPanel1.Controls.Add(_control)
      _control.Dock = DockStyle.Left
      _height = _control.Top + _control.Height + 5
    Next
    Me.FlowLayoutPanel1.Height = _height
    RaiseEvent DespuesSeleccionar(Me, Nothing)
    RaiseEvent CambiarLargo(Me, Nothing)
    Me.Timer1.Enabled = False
    Me.Timer1.Enabled = True
  End Sub

  Sub linkclick(sender As Object, e As EventArgs)
    Me.TreeviewParametroDet1.ParametroDet = sender.tag
    Me.Timer1.Enabled = False
    Me.Timer1.Enabled = True
    Me.TreeviewParametroDet1.Visible = True
    RaiseEvent CambiarLargo(Me, Nothing)
  End Sub

  Public Sub llenar_Datos()
    Me.TreeviewParametroDet1.llenar_datos()
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    Me.Timer1.Enabled = False
    Me.TreeviewParametroDet1.Visible = False
    RaiseEvent CambiarLargo(Me, Nothing)
  End Sub

  Private Sub CtlParametroDetAnidado_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
    Timer1_Tick(Me, Nothing)
  End Sub

End Class
