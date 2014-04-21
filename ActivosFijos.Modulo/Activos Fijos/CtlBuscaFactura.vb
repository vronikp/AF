Imports System.Windows.Forms.SendKeys
Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class CtlBuscaFactura
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

  Private mProveedor As Proveedor = Nothing
  Public Property Proveedor As Proveedor
    Get
      Return mProveedor
    End Get
    Set(value As Proveedor)
      mProveedor = value
    End Set
  End Property

  Sub Llenar_Datos()
    If mProveedor Is Nothing Then
      Exit Sub
    End If
    Me.ComboBox1.DisplayMember = "FacturaRef"
    Me.ComboBox1.ValueMember = "Factura_Codigo"
    mFacturaActivos = FacturaActivoList.ObtenerLista(mProveedor)
    Me.ComboBox1.DataSource = mFacturaActivos
  End Sub

  Public Property ItemText() As String
    Get
      Return Me.btn_Item.Text
    End Get
    Set(ByVal value As String)
      Me.btn_Item.Text = value
    End Set
  End Property

  Private mFacturaActivos As FacturaActivoList = Nothing
  <System.ComponentModel.Browsable(False)> _
  Public Property FacturaActivo() As FacturaActivo
    Get
      If Me.ComboBox1.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mFacturaActivos(Me.ComboBox1.SelectedIndex)
      End If
    End Get
    Set(ByVal value As FacturaActivo)
      If value Is Nothing Then
        If mFacturaActivos IsNot Nothing AndAlso mFacturaActivos.Count > 0 Then
          Me.ComboBox1.SelectedIndex = 0
          cambiar_item()
        End If
      Else
        Me.ComboBox1.SelectedValue = value.Factura_Codigo
      End If
    End Set
  End Property

  Private Sub btn_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Item.Click, BuscarToolStripMenuItem.Click
    abrir_consulta()
  End Sub

  Private Sub abrir_consulta(Optional ByVal filtro As String = "")
    Dim f As New FrmListaFacturaActivos(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoFacturaActivos, True)
    f.Proveedor = Proveedor
    f.FacturaActivo = FacturaActivo
    f.Filtro = filtro
    If f.ShowDialog() = DialogResult.OK Then
      Llenar_Datos()
      FacturaActivo = f.FacturaActivo
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Public Property FacturaText() As String
    Get
      Return Me.btn_Item.Text
    End Get
    Set(ByVal value As String)
      Me.btn_Item.Text = value
    End Set
  End Property

  Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
    FacturaActivo = Nothing
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

  Private Sub ComboBox1_Leave(sender As Object, e As System.EventArgs) Handles ComboBox1.Leave
    If Not String.IsNullOrWhiteSpace(Me.ComboBox1.Text) AndAlso Me.ComboBox1.SelectedIndex = -1 Then
      If MsgBox("Ha ingresado una factura nueva, ¿Desea terminar de ingresar todos los datos?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Abrir_Mantenimiento()
      Else
        Me.ComboBox1.Text = ""
      End If
    End If
  End Sub

  Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    cambiar_item()
  End Sub

  Private Sub cambiar_item()
    If Me.ComboBox1.SelectedIndex >= 0 AndAlso mFacturaActivos IsNot Nothing Then
      FacturaActivo = mFacturaActivos(Me.ComboBox1.SelectedIndex)
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    Dim _nuevafact As New FacturaActivo(Sistema.OperadorDatos, True)
    _nuevafact.Proveedor = Proveedor
    If Me.ComboBox1.SelectedIndex = -1 Then
      _nuevafact.Factura_Numero = Me.ComboBox1.Text
    End If

    Dim f As New FrmMantenimientoFacturaActivo(Sistema, Enumerados.EnumOpciones.ListadoFacturaActivos)
    f.Proveedor = Proveedor
    f.FacturaActivo = _nuevafact
    f.ShowDialog()

    If f.FacturaActivo IsNot Nothing AndAlso Not f.FacturaActivo.EsNuevo Then
      Llenar_Datos()
      Me.ComboBox1.SelectedValue = f.FacturaActivo.Factura_Codigo
    End If

    f.Dispose()
  End Sub
End Class
