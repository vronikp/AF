Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports Infoware.Consola.Base

Public Class TreeviewParametroDet
  Inherits TreeView

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

  Private mParametroEnum As Enumerados.EnumParametros = Enumerados.EnumParametros.UbicacionActivo
  Public Property ParametroEnum As Enumerados.EnumParametros
    Get
      Return mParametroEnum
    End Get
    Set(value As Enumerados.EnumParametros)
      mParametroEnum = value
    End Set
  End Property

  Private mSoloVisibles As Boolean = False
  Public Property SoloVisibles As Boolean
    Get
      Return mSoloVisibles
    End Get
    Set(value As Boolean)
      mSoloVisibles = value
    End Set
  End Property

  Private mPardetRaiz As WWTSParametroDet = Nothing

  Public Property PardetRaiz As WWTSParametroDet
    Get
      Return mPardetRaiz
    End Get
    Set(value As WWTSParametroDet)
      mPardetRaiz = value
    End Set
  End Property

  Public Property ParametroDet As WWTSParametroDet
    Get
      If Me.SelectedNode Is Nothing Then
        Return Nothing
      End If
      Return Me.SelectedNode.Tag
    End Get
    Set(value As WWTSParametroDet)
      seleccionarnodo(value)
    End Set
  End Property

  Sub seleccionarnodo(_value As WWTSParametroDet)
    Me.SelectedNode = buscarnodo(Nothing, _value)
  End Sub

  Function buscarnodo(_padrenodo As TreeNode, _valor As WWTSParametroDet) As TreeNode
    If _valor Is Nothing Then
      Return Nothing
    End If
    Dim _nodos As TreeNodeCollection
    If _padrenodo Is Nothing Then
      _nodos = Me.Nodes
    Else
      _nodos = _padrenodo.Nodes
    End If

    For Each _nodo As TreeNode In _nodos
      If CType(_nodo.Tag, WWTSParametroDet).Parame_Codigo = _valor.Parame_Codigo And CType(_nodo.Tag, WWTSParametroDet).Pardet_Secuencia = _valor.Pardet_Secuencia Then
        'Me.SelectedNode = _nodo
        Return _nodo
      Else
        Dim _nodoaux As TreeNode = buscarnodo(_nodo, _valor)
        If _nodoaux IsNot Nothing Then
          Return _nodoaux
        End If
      End If
    Next
    Return Nothing
  End Function


  Public Event ComandoNuevo As EventHandler
  Public Event ComandoModificar As EventHandler
  Public Event ComandoEliminar As EventHandler

  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem

  Private mParameRaiz As WWTSParametro = Nothing
  Private mPadres As New WWTSParametroList

  Sub llenar_datos()
    Me.HideSelection = False

    If Sistema Is Nothing Then 'OrElse mPardetRaiz Is Nothing 
      Exit Sub
    End If

    Dim _pardetubicacion As WWTSParametro = New WWTSParametro(Sistema.OperadorDatos, mParametroEnum)
    mPadres.Add(_pardetubicacion)

    Dim _padreubicacion As WWTSParametro = _pardetubicacion
    While _padreubicacion.ParametroPadre IsNot Nothing
      _padreubicacion = _padreubicacion.ParametroPadre
      mPadres.Add(_padreubicacion)
    End While
    mParameRaiz = _padreubicacion

    Me.Nodes.Clear()
    crearnodos(Nothing, mPadres, mPadres.Count - 1, Nothing)

    If mPardetRaiz IsNot Nothing Then
      Dim _nodoaux As TreeNode = buscarnodo(Nothing, mPardetRaiz)
      If _nodoaux Is Nothing Then
        Me.Nodes.Clear()
        MsgBox("El usuario tiene un asignada una ubicación que no existe. Contacte con el Administrador del Sistema", MsgBoxStyle.Critical, "Error")
      Else
        Dim _nodoclon As TreeNode = _nodoaux.Clone()
        Me.Nodes.Clear()
        Me.Nodes.Add(_nodoclon)
      End If
    End If

    If Me.Nodes.Count > 0 Then
      Me.SelectedNode = Me.Nodes(0)
    End If
  End Sub

  Sub crearnodos(_padrenode As TreeNode, _padres As WWTSParametroList, _indicepadre As Integer, _padredetubicacion As WWTSParametroDet)
    Dim _hijos As WWTSParametroDetList = WWTSParametroDetList.ObtenerLista(Sistema.OperadorDatos, _padres(_indicepadre).Parame_Codigo, WWTSParametroDetList.enumTipoObjeto.Nada, _padredetubicacion)
    For Each _hijo As WWTSParametroDet In _hijos
      If Not mSoloVisibles OrElse (mSoloVisibles AndAlso _hijo.Pardet_DatoBit1) Then
        Dim _node As New TreeNode
        _node.Text = _hijo.Pardet_Descripcion
        _node.Tag = _hijo
        If _padrenode Is Nothing Then
          Me.Nodes.Add(_node)
        Else
          _padrenode.Nodes.Add(_node)
        End If
        If _indicepadre - 1 >= 0 Then
          crearnodos(_node, _padres, _indicepadre - 1, _hijo)
        End If
      End If
    Next
  End Sub

  Public Sub New()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
    Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador = New System.Windows.Forms.ToolStripSeparator
    Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuModificar, Me.mnuseparador, Me.mnuEliminar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
    '
    'mnuNuevo
    '
    Me.mnuNuevo.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.mnuNuevo.Name = "mnuNuevo"
    Me.mnuNuevo.Size = New System.Drawing.Size(117, 22)
    Me.mnuNuevo.Text = "&Nuevo"
    '
    'mnuModificar
    '
    Me.mnuModificar.Image = My.Resources.Resources.abrir.ToBitmap
    Me.mnuModificar.Name = "mnuModificar"
    Me.mnuModificar.Size = New System.Drawing.Size(117, 22)
    Me.mnuModificar.Text = "&Modificar"
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

    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

    Me.ContextMenuStrip = Me.ContextMenuStrip1

  End Sub

  Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    If Me.SelectedNode Is Nothing Then
      Me.mnuNuevo.Visible = True
    Else
      Me.mnuNuevo.Visible = Not CType(Me.SelectedNode.Tag, WWTSParametroDet).Parame_Codigo = mParametroEnum
    End If
    Me.mnuModificar.Visible = Me.SelectedNode IsNot Nothing
    Me.mnuEliminar.Visible = Me.SelectedNode IsNot Nothing
  End Sub

  Private Sub mnuNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuNuevo.Click
    Dim _pardet As WWTSParametroDet
    If Me.SelectedNode Is Nothing Then
      If mParameRaiz Is Nothing Then
        Exit Sub
      End If
      _pardet = New WWTSParametroDet(Sistema.OperadorDatos, mParameRaiz.Parame_Codigo, True)
    Else
      Dim _indicepadre As Integer = 0
      For Each _padre As WWTSParametro In mPadres
        If _padre.Parame_Codigo = CType(Me.SelectedNode.Tag, WWTSParametroDet).Parame_Codigo Then
          Exit For
        End If
        _indicepadre += 1
      Next
      _pardet = New WWTSParametroDet(Sistema.OperadorDatos, mPadres(_indicepadre - 1).Parame_Codigo, True)
      _pardet.PardetPadre = CType(Me.SelectedNode.Tag, WWTSParametroDet)
    End If
        Dim f As New FrmMantenimientoParametroDet(Sistema, Enumerados.EnumOpciones.Parametros)
    f.ParametroDet = _pardet
    f.ShowDialog()
    If Not _pardet.EsNuevo Then
      llenar_datos()
    End If
  End Sub

  Private Sub mnuModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuModificar.Click
    If Me.SelectedNode.Tag Is Nothing Then
      Exit Sub
    End If
        Dim f As New FrmMantenimientoParametroDet(Sistema, Enumerados.EnumOpciones.Parametros)
    f.ParametroDet = CType(Me.SelectedNode.Tag, WWTSParametroDet)
    f.ShowDialog()
    llenar_datos()
  End Sub

  Private Sub mnuEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
    If Me.SelectedNode.Tag Is Nothing Then
      Exit Sub
    End If
    If CType(Me.SelectedNode.Tag, WWTSParametroDet).Eliminar Then
      llenar_datos()
    End If
  End Sub

End Class
