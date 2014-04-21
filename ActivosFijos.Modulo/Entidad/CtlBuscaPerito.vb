Imports System.Windows.Forms.SendKeys
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class CtlBuscaPerito
  Public ReadOnly Property Sistema() As Sistema
    Get
      Return CType(Me.ParentForm, FrmFormaBase).Sistema
    End Get
  End Property

  Public Enum EnumUbicacion
    Normal = 0
    Abajo = 1
  End Enum
  Private mUbicacion As EnumUbicacion = EnumUbicacion.Normal
  Public Property Ubicacion() As EnumUbicacion
    Get
      Return mUbicacion
    End Get
    Set(ByVal value As EnumUbicacion)
      mUbicacion = value
      Select Case mUbicacion
        Case EnumUbicacion.Normal
          Me.ComboBox1.Location = New Point(124, 0)
          Me.ComboBox1.Size = New Size(Me.Width - 124, 23)
        Case EnumUbicacion.Abajo
          Me.ComboBox1.Location = New Point(0, 24)
          Me.ComboBox1.Size = New Size(Me.Width, 23)
      End Select
    End Set
  End Property

  Public Event CambioItem As EventHandler

  Private mOperadorDatos As OperadorDatos = Nothing
  Public WriteOnly Property OperadorDatos() As OperadorDatos
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value

      If value IsNot Nothing Then
        Llenar_Datos()
      End If
    End Set
  End Property

  Sub Llenar_Datos()
    Me.ComboBox1.DisplayMember = "NombreCompleto"
    Me.ComboBox1.ValueMember = "Entida_Codigo"
    mPeritos = PeritoList.ObtenerLista(mOperadorDatos)
    Me.ComboBox1.DataSource = mPeritos
  End Sub

  Public Property ItemText() As String
    Get
      Return Me.btn_Item.Text
    End Get
    Set(ByVal value As String)
      Me.btn_Item.Text = value
    End Set
  End Property

  Private mPeritos As PeritoList = Nothing
  <System.ComponentModel.Browsable(False)> _
  Public Property Perito() As Perito
    Get
      If Me.ComboBox1.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mPeritos(Me.ComboBox1.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Perito)
      If value Is Nothing Then
        If mPeritos IsNot Nothing AndAlso mPeritos.Count > 0 Then
          Me.ComboBox1.SelectedIndex = 0
          cambiar_item()
        End If
      Else
        Me.ComboBox1.SelectedValue = value.Entida_Codigo
      End If
    End Set
  End Property

  Private Sub btn_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Item.Click, BuscarToolStripMenuItem.Click
    abrir_consulta()
  End Sub

  Private Sub abrir_consulta(Optional ByVal filtro As String = "")
    Dim f As New FrmListaPeritos(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoPeritos, True)
    f.Perito = Perito
    f.Filtro = filtro
    If f.ShowDialog() = DialogResult.OK Then
      Llenar_Datos()
      Perito = f.Perito
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Public Property PeritoText() As String
    Get
      Return Me.btn_Item.Text
    End Get
    Set(ByVal value As String)
      Me.btn_Item.Text = value
    End Set
  End Property

  Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
    Perito = Nothing
    RaiseEvent CambioItem(Me, Nothing)
  End Sub

  Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
    If e.KeyCode = Keys.Enter Then
      If Me.ComboBox1.SelectedIndex = -1 Then
        abrir_consulta(Me.ComboBox1.Text)
      End If
      Send("{TAB}")
      e.Handled = True
    End If
  End Sub

  Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    cambiar_item()
  End Sub

  Private Sub cambiar_item()
    If Me.ComboBox1.SelectedIndex >= 0 AndAlso mPeritos IsNot Nothing Then
      Perito = mPeritos(Me.ComboBox1.SelectedIndex)
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    Dim f As New FrmMantenimientoPerito(Sistema, Enumerados.EnumOpciones.ListadoPeritos)
    f.Perito = New Perito(Sistema.OperadorDatos, True)
    f.ShowDialog()

    If f.Perito IsNot Nothing AndAlso Not f.Perito.EsNuevo Then
      Llenar_Datos()
      Me.ComboBox1.SelectedValue = f.Perito.Entida_Codigo
    End If

    f.Dispose()
  End Sub
End Class
