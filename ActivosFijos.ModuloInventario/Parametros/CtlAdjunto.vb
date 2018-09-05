Imports ActivosFijos.Reglas


Public Class CtlAdjunto
  Inherits ListView

  'Private mParametroDets As WWTSParametroDetList = Nothing
  'Private mParametroDetsEli As WWTSParametroDetList = Nothing
  Private mParameAdjunto As WWTSParametroDet
  Public Property ParameAdjunto() As WWTSParametroDet
    Get
      Return mParameAdjunto
    End Get
    Set(ByVal value As WWTSParametroDet)
      If value IsNot Nothing Then
        mParameAdjunto = value
        'mParametroDets = WWTSParametroDetList.ObtenerLista(value.OperadorDatos, Enumerados.EnumParametros.Adjuntosdetalle, WWTSParametroDetList.enumTipoObjeto.Nada, value)
        'mParametroDetsEli = New WWTSParametroDetList
        llenar_datos()
      End If
    End Set
  End Property

  Sub llenar_datos()
    Me.Items.Clear()
    Me.ImageList1.Images.Clear()
    Dim cont As Integer = 0
    For Each _param As WWTSParametroDet In mParameAdjunto.PardetHijos
      Me.ImageList1.Images.Add(_param.ArchivoSalidaIcono)
      Dim _item As New ListViewItem
      _item.Tag = _param
      _item.Text = _param.Pardet_DatoStr1
      _item.ImageIndex = cont
      Me.Items.Add(_item)

      cont += 1
    Next
  End Sub

#Region "New"
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Private components As System.ComponentModel.IContainer
  Friend WithEvents mnuAbrir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAdjuntar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents OpenFileDialog1 As OpenFileDialog
  Friend WithEvents ImageList1 As ImageList

  Public Sub New()
    Me.View = Windows.Forms.View.LargeIcon
    'Me.DropDownStyle = ComboBoxStyle.DropDownList
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
    Me.mnuAbrir = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAdjuntar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador = New System.Windows.Forms.ToolStripSeparator
    OpenFileDialog1 = New OpenFileDialog
    ImageList1 = New ImageList
    'ImageList1.ColorDepth = ColorDepth.Depth24Bit
    ImageList1.TransparentColor = Color.Transparent
    ImageList1.ImageSize = New Size(32, 32)
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrir, Me.mnuAdjuntar, Me.mnuseparador, Me.mnuEliminar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
    '
    'mnuNuevo
    '
    Me.mnuAbrir.Image = My.Resources.Resources.abrir.ToBitmap
    Me.mnuAbrir.Name = "mnuAbrir"
    Me.mnuAbrir.Size = New System.Drawing.Size(117, 22)
    Me.mnuAbrir.Text = "&Abrir"
    '
    'mnuModificar
    '
    Me.mnuAdjuntar.Image = My.Resources.Resources.adjunto.ToBitmap
    Me.mnuAdjuntar.Name = "mnuAdjuntar"
    Me.mnuAdjuntar.Size = New System.Drawing.Size(117, 22)
    Me.mnuAdjuntar.Text = "Ad&juntar"
    '
    'mnuEliminar
    '
    Me.mnuEliminar.Image = My.Resources.Resources.eliminar.ToBitmap
    Me.mnuEliminar.Name = "mnuEliminar"
    Me.mnuEliminar.Size = New System.Drawing.Size(117, 22)
    Me.mnuEliminar.Text = "&Eliminar"
    '
    'mnuseparador
    '
    Me.mnuseparador.Name = "mnuseparador"
    Me.mnuseparador.Size = New System.Drawing.Size(114, 6)
    '
    'ComboBoxDB
    '
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

    Me.ContextMenuStrip = Me.ContextMenuStrip1
    Me.LargeImageList = Me.ImageList1
  End Sub
#End Region

  Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnuAbrir.Enabled = Not Me.SelectedItems.Count = 0
    Me.mnuEliminar.Enabled = Not Me.SelectedItems.Count = 0
  End Sub

  Private Sub mnuAdjuntar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAdjuntar.Click
    With OpenFileDialog1
      .Filter = "Todos los archivos (*.*)|*.*|Documentos de Word (*.doc;*.docx)|*.doc;*.docx|Documentos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
      .FilterIndex = 1
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Dim _param As New WWTSParametroDet(mParameAdjunto.OperadorDatos, Enumerados.EnumParametros.Adjuntosdetalle, True)

        _param.ArchivoImagen = .FileName
        _param.Pardet_DatoStr1 = My.Computer.FileSystem.GetFileInfo(.FileName).Name

        mParameAdjunto.PardetHijos.Add(_param)

        Me.ImageList1.Images.Add(_param.ArchivoSalidaIcono)
        Dim _item As New ListViewItem
        _item.Tag = _param
        _item.Text = _param.Pardet_DatoStr1
        _item.ImageIndex = Me.Items.Count
        Me.Items.Add(_item)

        'Me.lnkarchivo.Text = My.Computer.FileSystem.GetFileInfo(.FileName).Name
        'Me.lnkarchivo.Tag = .FileName
        'mParametroDet.ArchivoImagen = .FileName
        'mParametroDet.Pardet_DatoStr1 = My.Computer.FileSystem.GetFileInfo(.FileName).Name
      End If
    End With
  End Sub

  Private Sub mnuAbrir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAbrir.Click, Me.DoubleClick
    If Me.SelectedItems.Count = 0 Then
      Exit Sub
    End If

    Dim archivo As String = ""
    archivo = CType(Me.SelectedItems(0).Tag, WWTSParametroDet).ArchivoSalida

    Dim mProcess As New System.Diagnostics.Process
    mProcess.StartInfo.FileName = archivo
    mProcess.StartInfo.Arguments = ""
    mProcess.StartInfo.Verb = "Open"
    'mProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    mProcess.EnableRaisingEvents = True
    mProcess.Start()
  End Sub

  Private Sub mnuEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
    If Me.SelectedItems.Count = 0 Then
      Exit Sub
    End If

    For Each _elemento As ListViewItem In Me.SelectedItems
      mParameAdjunto.PardetHijosEli.Add(_elemento.Tag)
      mParameAdjunto.PardetHijos.Remove(_elemento.Tag)
      Me.Items.Remove(_elemento)
    Next

    llenar_datos()
  End Sub
End Class
