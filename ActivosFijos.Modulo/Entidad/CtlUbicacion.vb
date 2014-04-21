Imports System.ComponentModel
Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


<ToolboxItem(True)> _
Public Class CtlUbicacion
  Inherits System.Windows.Forms.TreeView

  Private mOp As OperadorDatos
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOp
    End Get
    Set(ByVal value As OperadorDatos)
      mOp = value
    End Set
  End Property

  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Private components As System.ComponentModel.IContainer
  Friend WithEvents mnuNuevo1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNuevo2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuseparador1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuActualizar As System.Windows.Forms.ToolStripMenuItem

  Public Property Parroquia() As WWTSParametroDet
    Get
      If Me.Nodes.Count > 0 AndAlso Me.SelectedNode IsNot Nothing AndAlso CType(Me.SelectedNode.Tag, WWTSParametroDet).Parame_Codigo = Enumerados.EnumParametros.Parroquia Then
        Return Me.SelectedNode.Tag
      Else
        Return Nothing
      End If
    End Get
    Set(ByVal Value As WWTSParametroDet)
      If Value Is Nothing Or Me.Nodes.Count = 0 Then
        Me.SelectedNode = Nothing
      Else
        seleccionarnodo(Me.Nodes(0), Value)
      End If
    End Set
  End Property

  Private Sub seleccionarnodo(ByVal node As TreeNode, ByVal value As WWTSParametroDet)
    While Not node Is Nothing
      If CType(node.Tag, WWTSParametroDet).Parame_Codigo = Enumerados.EnumParametros.Parroquia Then
        Dim mPrr As WWTSParametroDet
        mPrr = node.Tag

        If mPrr.Pardet_Secuencia = value.Pardet_Secuencia Then
          Me.SelectedNode = node
          node.EnsureVisible()
        End If
      End If
      If node.GetNodeCount(False) > 0 Then
        seleccionarnodo(node.Nodes(0), value)
      End If
      node = node.NextNode
    End While
  End Sub

  Public Sub llenar_datos()
    Me.BeginUpdate()
    Me.Nodes.Clear()
    Dim paises As WWTSParametroDetList
    paises = WWTSParametroDetList.ObtenerLista(mOp, Enumerados.EnumParametros.Pais)
    If Not paises Is Nothing Then
      For Each _pais As WWTSParametroDet In paises
        'creo nodo
        Dim nodepais As New TreeNode
        nodepais.Text = _pais.Pardet_Descripcion
        nodepais.Tag = _pais

        'fin de creo nodo
        Me.Nodes.Add(nodepais)

        Dim provincias As WWTSParametroDetList
        provincias = WWTSParametroDetList.ObtenerLista(OperadorDatos, Enumerados.EnumParametros.Provincia, WWTSParametroDetList.enumTipoObjeto.Nada, _pais)
        If Not provincias Is Nothing Then
          For Each _prov As WWTSParametroDet In provincias
            Dim nodeprov As New TreeNode
            nodeprov.Text = _prov.Pardet_Descripcion
            nodeprov.Tag = _prov
            nodepais.Nodes.Add(nodeprov)

            Dim cantones As WWTSParametroDetList
            cantones = WWTSParametroDetList.ObtenerLista(OperadorDatos, Enumerados.EnumParametros.Ciudad, WWTSParametroDetList.enumTipoObjeto.Nada, _prov)
            If Not cantones Is Nothing Then
              For Each _canton As WWTSParametroDet In cantones
                Dim nodecant As New TreeNode
                nodecant.Text = _canton.Pardet_Descripcion
                nodecant.Tag = _canton
                nodeprov.Nodes.Add(nodecant)

                Dim parroquias As WWTSParametroDetList
                parroquias = WWTSParametroDetList.ObtenerLista(OperadorDatos, Enumerados.EnumParametros.Parroquia, WWTSParametroDetList.enumTipoObjeto.Nada, _canton)
                If Not parroquias Is Nothing Then
                  For Each _parr As WWTSParametroDet In parroquias
                    Dim nodeprr As New TreeNode
                    nodeprr.Text = _parr.Pardet_Descripcion
                    nodeprr.Tag = _parr
                    nodecant.Nodes.Add(nodeprr)
                  Next
                End If
              Next
            End If
          Next
        End If
      Next
    End If
    Me.EndUpdate()
  End Sub

  Public Sub New()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
    Me.mnuNuevo1 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuNuevo2 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador = New System.Windows.Forms.ToolStripSeparator
    Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuseparador1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuActualizar = New System.Windows.Forms.ToolStripMenuItem
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo1, Me.mnuNuevo2, Me.mnuModificar, Me.mnuseparador, Me.mnuEliminar, Me.mnuseparador1, Me.mnuActualizar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
    '
    'mnuNuevo1
    '
    Me.mnuNuevo1.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.mnuNuevo1.Name = "mnuNuevo"
    Me.mnuNuevo1.Size = New System.Drawing.Size(117, 22)
    Me.mnuNuevo1.Text = "&Nuevo"
    '
    'mnuNuevo2
    '
    Me.mnuNuevo2.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.mnuNuevo2.Name = "mnuNuevo"
    Me.mnuNuevo2.Size = New System.Drawing.Size(117, 22)
    Me.mnuNuevo2.Text = "&Nuevo"
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
    '
    'mnuActualizar
    '
    'Me.mnuActualizar.Image = My.Resources.Resources.Abriricono
    Me.mnuActualizar.Name = "mnuActualizar"
    Me.mnuActualizar.Size = New System.Drawing.Size(117, 22)
    Me.mnuActualizar.Text = "&Actualizar"
    '
    'mnuseparador1
    '
    Me.mnuseparador1.Name = "mnuseparador"
    Me.mnuseparador1.Size = New System.Drawing.Size(114, 6)
    '
    'ComboBoxDB
    '
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)

    Me.ContextMenuStrip = Me.ContextMenuStrip1
    Me.HideSelection = False
  End Sub

  Private Sub menu_Popup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    Me.mnuNuevo1.Visible = True
    Me.mnuNuevo2.Visible = True
    Me.mnuEliminar.Visible = True
    Me.mnuModificar.Visible = True

    If Me.SelectedNode Is Nothing Then
      Me.mnuNuevo1.Text = "Nuevo país"
      Me.mnuNuevo2.Visible = False
      Me.mnuEliminar.Visible = False
      Me.mnuModificar.Visible = False
    Else
      Select Case CType(CType(Me.SelectedNode.Tag, WWTSParametroDet).Parame_Codigo, Enumerados.EnumParametros)
        Case Enumerados.EnumParametros.Pais
          Me.mnuNuevo1.Text = "Nuevo país"
          Me.mnuNuevo2.Text = "Nueva provincia"
          Me.mnuEliminar.Text = "Eliminar país"
          Me.mnuModificar.Text = "Modificar país"
        Case Enumerados.EnumParametros.Provincia
          Me.mnuNuevo1.Text = "Nueva provincia"
          Me.mnuNuevo2.Text = "Nueva ciudad"
          Me.mnuEliminar.Text = "Eliminar provincia"
          Me.mnuModificar.Text = "Modificar provincia"
        Case Enumerados.EnumParametros.Ciudad
          Me.mnuNuevo1.Text = "Nueva ciudad"
          Me.mnuNuevo2.Text = "Nueva parroquia"
          Me.mnuEliminar.Text = "Eliminar ciudad"
          Me.mnuModificar.Text = "Modificar ciudad"
        Case Enumerados.EnumParametros.Parroquia
          Me.mnuNuevo1.Text = "Nueva parroquia"
          Me.mnuNuevo2.Visible = False
          Me.mnuEliminar.Text = "Eliminar parroquia"
          Me.mnuModificar.Text = "Modificar parroquia"
      End Select
    End If
  End Sub

  Private Sub mnunuevo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevo1.Click
    nuevo(Me.mnuNuevo1.Text)
  End Sub
  Private Sub mnunuevo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevo2.Click
    nuevo(Me.mnuNuevo2.Text)
  End Sub

  Sub nuevo(ByVal opcion As String)
    Dim _pardetactual As WWTSParametroDet = Nothing
    If Me.SelectedNode IsNot Nothing AndAlso Me.SelectedNode.Tag IsNot Nothing Then
      _pardetactual = CType(Me.SelectedNode.Tag, WWTSParametroDet)
    End If

    Dim _sistema As Sistema = Nothing
    Dim _control As Control = Me.Parent
    While True
      If TypeOf _control Is FrmFormaBase Then
        Exit While
      End If
      _control = _control.Parent
    End While
    _sistema = CType(_control, FrmFormaBase).Sistema

    Select Case opcion
      Case "Nuevo país"
        Dim fpais As New FrmMantenimientoParametroDet(_sistema, Enumerados.EnumOpciones.ListadoEmpleados)
        fpais.ParametroDet = New WWTSParametroDet(OperadorDatos, Enumerados.EnumParametros.Pais, True)
        fpais.ShowDialog()
        llenar_datos()
      Case "Nueva provincia"
        Dim fprovincia As New FrmMantenimientoParametroDet(_sistema, Enumerados.EnumOpciones.ListadoEmpleados)
        Select Case CType(_pardetactual.Parame_Codigo, Enumerados.EnumParametros)
          Case Enumerados.EnumParametros.Provincia
            fprovincia.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.PardetPadre.Parame_Codigo, True)
          Case Enumerados.EnumParametros.Pais
            fprovincia.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.Parame_Codigo, True)
        End Select
        fprovincia.ShowDialog()
        llenar_datos()
      Case "Nueva ciudad"
        Dim fcanton As New FrmMantenimientoParametroDet(_sistema, Enumerados.EnumOpciones.ListadoEmpleados)
        Select Case CType(_pardetactual.Parame_Codigo, Enumerados.EnumParametros)
          Case Enumerados.EnumParametros.Ciudad
            fcanton.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.PardetPadre.Parame_Codigo, True)
          Case Enumerados.EnumParametros.Provincia
            fcanton.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.Parame_Codigo, True)
        End Select
        fcanton.ShowDialog()
        llenar_datos()
      Case "Nueva parroquia"
        Dim fparroquia As New FrmMantenimientoParametroDet(_sistema, Enumerados.EnumOpciones.ListadoEmpleados)
        Select Case CType(_pardetactual.Parame_Codigo, Enumerados.EnumParametros)
          Case Enumerados.EnumParametros.Parroquia
            fparroquia.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.PardetPadre.Parame_Codigo, True)
          Case Enumerados.EnumParametros.Ciudad
            fparroquia.ParametroDet = New WWTSParametroDet(OperadorDatos, _pardetactual.Parame_Codigo, True)
        End Select
        fparroquia.ShowDialog()
        llenar_datos()
    End Select
  End Sub

  Private Sub mnueliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
    Dim _pardetactual As WWTSParametroDet = Nothing
    If Me.SelectedNode.Tag IsNot Nothing Then
      _pardetactual = CType(Me.SelectedNode.Tag, WWTSParametroDet)
      Try
        If Not _pardetactual.Eliminar() Then
          Throw New Exception("No se puede eliminar")
        End If
        Me.SelectedNode.Remove()
      Catch ex As Exception
        MsgBox(String.Format("{0} {1}", ex.Message, _pardetactual.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
      End Try
    End If
  End Sub

  Private Sub mnuModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModificar.Click
    Dim _pardetactual As WWTSParametroDet = Nothing
    If Me.SelectedNode.Tag IsNot Nothing Then
      _pardetactual = CType(Me.SelectedNode.Tag, WWTSParametroDet)

      Dim _sistema As Sistema = Nothing
      Dim _control As Control = Me.Parent
      While True
        If TypeOf _control Is FrmFormaBase Then
          Exit While
        End If
        _control = _control.Parent
      End While
      _sistema = CType(_control, FrmFormaBase).Sistema

      Dim frmmodificar As New FrmMantenimientoParametroDet(_Sistema, Enumerados.EnumOpciones.ListadoEmpleados)
      frmmodificar.ParametroDet = _pardetactual
      frmmodificar.ShowDialog()

      llenar_datos()
    End If
  End Sub

  Private Sub mnuactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActualizar.Click
    Me.llenar_datos()
  End Sub
End Class
