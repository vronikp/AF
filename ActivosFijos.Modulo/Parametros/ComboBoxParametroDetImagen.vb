Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports System.ComponentModel
Imports ActivosFijos.Reglas

<ToolboxItem(True)> _
Public Class ComboBoxParametroDetImagen
  Inherits System.Windows.Forms.ComboBox
  Implements IDatos

  Public Event CambioItem As EventHandler
  Private mOp As OperadorDatos
  Public Property Op() As Infoware.Datos.OperadorDatos Implements Infoware.Datos.IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As Infoware.Datos.OperadorDatos)
      mOp = value
      If value IsNot Nothing Then
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem

        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})

        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = My.Resources.Resources.nuevo.ToBitmap
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = My.Resources.Resources.abrir.ToBitmap
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "&Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = My.Resources.Resources.eliminar.ToBitmap
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar"

        Me.ContextMenuStrip = Me.ContextMenuStrip1
      End If
    End Set
  End Property

  Private mParametro As Enumerados.EnumParametros = Enumerados.EnumParametros.TipoEntidad
  Public Property Parametro() As Enumerados.EnumParametros
    Get
      Return mParametro
    End Get
    Set(ByVal value As Enumerados.EnumParametros)
      mParametro = value
    End Set
  End Property

  Public Property ParametroDet() As WWTSParametroDet
    Get
      If mParametroDets Is Nothing OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mParametroDets(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As WWTSParametroDet)
      If value Is Nothing OrElse mParametroDets Is Nothing Then
        If MyBase.Items.Count > 0 Then
          MyBase.SelectedIndex = 0
        Else
          MyBase.SelectedIndex = -1
        End If
      Else
        MyBase.SelectedValue = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Private mParametroDets As WWTSParametroDetList = Nothing

  Private Sub ComboBoxParametroDetImagen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    RaiseEvent CambioItem(Me, Nothing)
  End Sub

  Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Private WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

  Public Sub Llenar_Datos(Optional ByVal _enumtipoobjeto As Infoware.Reglas.General.ParametroDetList.enumTipoObjeto = WWTSParametroDetList.enumTipoObjeto.Nada)
    MyBase.DropDownStyle = ComboBoxStyle.DropDownList
    If mOp Is Nothing OrElse Parametro = -1 Then
      Me.Items.Clear()
      Exit Sub
    End If

    mParametroDets = WWTSParametroDetList.ObtenerLista(mOp, mParametro, _enumtipoobjeto)

    MyBase.DisplayMember = "Pardet_Descripcion"
    MyBase.ValueMember = "Pardet_Secuencia"
    MyBase.DataSource = mParametroDets
  End Sub

  Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Dim _parametrodet As WWTSParametroDet = ParametroDet
    Dim _parametro As WWTSParametro = New WWTSParametro(mOp, Me.Parametro)

    If _parametro.Parame_Modificable Then
      Me.NuevoToolStripMenuItem.Enabled = True
      If _parametrodet Is Nothing Then
        Me.ModificarToolStripMenuItem.Enabled = False
        Me.EliminarToolStripMenuItem.Enabled = False
      Else
        Me.ModificarToolStripMenuItem.Enabled = _parametrodet.Pardet_Modificable
        Me.EliminarToolStripMenuItem.Enabled = _parametrodet.Pardet_Modificable
      End If
    Else
      Me.NuevoToolStripMenuItem.Enabled = False
      Me.ModificarToolStripMenuItem.Enabled = False
      Me.EliminarToolStripMenuItem.Enabled = False
    End If
  End Sub

  Private Sub NuevoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
    Dim f As New FrmParametroDetImagen
    f.ParametroDet = New WWTSParametroDet(mOp, Me.Parametro, True)
    f.Direccion = Infoware.Controles.General.IMantenimiento.Accion.Ingreso
    If f.ShowDialog() = DialogResult.OK Then
      Llenar_Datos()
    End If
  End Sub

  Private Sub ModificarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
    Dim f As New FrmParametroDetImagen
    f.ParametroDet = ParametroDet
    f.Direccion = Infoware.Controles.General.IMantenimiento.Accion.Modificacion
    If f.ShowDialog() = DialogResult.OK Then
      Llenar_Datos()
    End If
  End Sub

  Private Sub EliminarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
    Dim f As New FrmParametroDetImagen
    f.ParametroDet = ParametroDet
    f.Direccion = Infoware.Controles.General.IMantenimiento.Accion.Eliminacion
    If f.ShowDialog() = DialogResult.OK Then
      Llenar_Datos()
    End If
  End Sub

  Public Sub New()
    MyBase.ItemHeight = 32
    MyBase.DrawMode = Windows.Forms.DrawMode.OwnerDrawVariable
  End Sub

  Private Sub ComboBoxParametroDetImagen_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
    If e.Index = -1 Then
      Exit Sub
    End If
    Dim BrushFont As SolidBrush
    Dim BrushBack As SolidBrush
    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
      BrushFont = New SolidBrush(System.Drawing.SystemColors.HighlightText)
      BrushBack = New SolidBrush(System.Drawing.SystemColors.MenuHighlight)
    Else
      BrushFont = New SolidBrush(System.Drawing.SystemColors.MenuText)
      BrushBack = New SolidBrush(System.Drawing.SystemColors.Menu)
    End If
    Dim ancho As Integer = 32
    e.Graphics.FillRectangle(BrushBack, e.Bounds)
    e.Graphics.DrawString(mParametroDets(e.Index).Pardet_Descripcion, MyBase.Font, BrushFont, e.Bounds.Left + ancho + 2, e.Bounds.Top + ancho / 4)
    If mParametroDets(e.Index).Pardet_Imagen IsNot Nothing Then
      'On Error Resume Next
      Dim _imagen As New Bitmap(mParametroDets(e.Index).Pardet_Imagen)
      '_imagen = _imagen.GetThumbnailImage(ancho, alto, Nothing, New IntPtr())
      e.Graphics.DrawImage(mParametroDets(e.Index).Pardet_Imagen, e.Bounds.Left, e.Bounds.Top, ancho, ancho)
      'On Error GoTo 0
    End If

    BrushFont.Dispose()
    BrushBack.Dispose()
  End Sub

  Private Sub ComboBoxParametroDetImagen_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles Me.MeasureItem
    e.ItemHeight = 32
    e.ItemWidth = 32
  End Sub
End Class
