Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports Infoware.Consola.Base
Imports ActivosFijos.Modulo.clsReporteActivo

Public Class CtlBuscaActivos
  Public ReadOnly Property Sistema() As Sistema
    Get
      Return CType(Me.ParentForm, FrmFormaBase).Sistema
    End Get
  End Property

  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        Me.CtlGrupoTipoClase.ParametroEnum = Enumerados.EnumParametros.ClaseActivo
        Me.CtlGrupoTipoClase.llenar_Datos()

        Me.cboMarca.OperadorDatos = mOperadorDatos
        Me.cboMarca.Parametro = Reglas.Enumerados.EnumParametros.MarcaActivo
        Me.cboMarca.Llenar_Datos()

        Me.cboestadoinv.OperadorDatos = mOperadorDatos
        Me.cboestadoinv.Parametro = Reglas.Enumerados.EnumParametros.EstadoInventarioActivo
        Me.cboestadoinv.Llenar_Datos()

        Me.CtlBuscaFactura1.OperadorDatos = mOperadorDatos

        Me.CtlBuscaProveedor1.SoloActivos = True
        Me.CtlBuscaProveedor1.OperadorDatos = mOperadorDatos
        Me.CtlBuscaProveedor1.Llenar_Datos()

        Dim _usuario As WWTSUsuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

        'Me.CtlUbicacionActivo1.SoloVisibles = True
        Me.CtlUbicacionActivo1.PardetRaiz = _usuario.PardetUbicacion
        Me.CtlUbicacionActivo1.llenar_Datos()

        If _usuario.PardetUbicacion IsNot Nothing Then
          Me.chkubicacion.Checked = True
          Me.chkubicacion.Enabled = False
        End If

        Me.CtlBuscaEmpleado1.SoloActivos = True
        Me.CtlBuscaEmpleado1.OperadorDatos = mOperadorDatos
        Me.CtlBuscaEmpleado1.Llenar_Datos()

        If _usuario.Empleado IsNot Nothing Then
          Me.chkcustodio.Checked = True
          Me.chkcustodio.Enabled = False
          Me.CtlBuscaEmpleado1.Empleado = _usuario.Empleado
          Me.CtlBuscaEmpleado1.Enabled = False
        End If

        Me.cbotipofecha.SelectedIndex = 0
        dimensionartodo()
      End If
    End Set
  End Property

  Public Property PuedeExportaryBarCode As Boolean
    Get
      Return Me.btnexportar.Visible
    End Get
    Set(value As Boolean)
      Me.btnexportar.Visible = value
      Me.ToolStripMenuItem2.Visible = value
      Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem.Visible = value
    End Set
  End Property

  Private Sub chkgrupo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkgrupo.CheckedChanged
    Me.pnlgrupo.Visible = Me.chkgrupo.Checked
    dimensionartodo()
  End Sub

  Private Sub chkmarca_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkmarca.CheckedChanged
    Me.pnlmarca.Visible = Me.chkmarca.Checked
    dimensionartodo()
  End Sub

  Sub dimensionartodo()
    Me.Height = Me.HeaderStrip2.Height + Me.pnlcierre.Top + Me.pnlcierre.Height
  End Sub

  Private mActivos As ActivoList = Nothing
  Public ReadOnly Property Activos As ActivoList
    Get
      Return mActivos
    End Get
  End Property

  Public Event Buscar As EventHandler
  Private Sub btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscaractivos.Click
    Llenar_Datos()
    RaiseEvent Buscar(Me, Nothing)
  End Sub

  Public Sub Llenar_Datos()
    mActivos = ActivoList.ObtenerLista(mOperadorDatos, Me.txtcodigobarra.Text, Me.txtcodigoaux.Text, Me.txtserie.Text, Me.txtdescripcion.Text, IIf(Me.chkgrupo.Checked, Me.CtlGrupoTipoClase.ParametroDet, Nothing), IIf(Me.chkmarca.Checked, Me.cboMarca.ParametroDet, Nothing), Me.txtmodelo.Text, IIf(Me.chkproveedor.Checked, Me.CtlBuscaProveedor1.Proveedor, Nothing), IIf(Me.chkfactura.Checked, Me.CtlBuscaFactura1.FacturaActivo, Nothing), IIf(Me.chkcustodio.Checked, Me.CtlBuscaEmpleado1.Empleado, Nothing), IIf(Me.chkubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing), IIf(Me.chkestadoinv.Checked, Me.cboestadoinv.ParametroDet, Nothing), Me.chksoloactivos.Checked, IIf(Me.chkfecha.Checked, Me.cbotipofecha.SelectedIndex, -1), IIf(Me.chkfecha.Checked, Me.dtfecdesde.Value, Nothing), IIf(Me.chkfecha.Checked, Me.dtfechasta.Value, Nothing), Nothing)

  End Sub

  Private Sub CtlBuscaProveedor1_CambioItem(sender As Object, e As System.EventArgs) Handles CtlBuscaProveedor1.CambioItem
    Me.CtlBuscaFactura1.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    Me.CtlBuscaFactura1.Llenar_Datos()
  End Sub

  Private Sub chkproveedor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkproveedor.CheckedChanged
    Me.pnlproveedor.Visible = Me.chkproveedor.Checked
    dimensionarchkproveedorfactura()
  End Sub

  Private Sub chkfactura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkfactura.CheckedChanged
    Me.pnlfactura.Visible = Me.chkfactura.Checked
    dimensionarchkproveedorfactura()
  End Sub

  Sub dimensionarchkproveedorfactura()
    If Me.chkproveedor.Checked Then
      Me.pnlproveedor.Height = 45 + 17
      If Me.chkfactura.Checked Then
        Me.pnlproveedor.Height += 45
      End If
    End If
    dimensionartodo()
  End Sub

  Private Sub chkcustodio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkcustodio.CheckedChanged
    Me.pnlcustodio.Visible = Me.chkcustodio.Checked
    dimensionartodo()
  End Sub

  Private Sub chkubicacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkubicacion.CheckedChanged
    Me.pnlubicacion.Visible = Me.chkubicacion.Checked
    dimensionartodo()
  End Sub

  Private Sub CtlGrupoTipoClase_CambiarLargo(sender As Object, e As System.EventArgs) Handles CtlGrupoTipoClase.CambiarLargo, CtlUbicacionActivo1.CambiarLargo
    Me.pnlgrupo.Height = Me.CtlGrupoTipoClase.Largo
    Me.pnlubicacion.Height = Me.CtlUbicacionActivo1.Largo
    dimensionartodo()
  End Sub

  Private Function AgregarFiltro(_filtro As String, _agregar As String) As String
    If Not String.IsNullOrWhiteSpace(_filtro) Then
      Return _filtro + ", " + _agregar
    Else
      Return _agregar
    End If
  End Function

  Private Sub chkestadoinv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkestadoinv.CheckedChanged
    Me.pnlestadoinv.Visible = Me.chkestadoinv.Checked
    dimensionartodo()
  End Sub

  Private Sub PorGrupoTipoClaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PorGrupoTipoClaseToolStripMenuItem.Click, PorCustodioToolStripMenuItem.Click, PorUbicacionToolStripMenuItem.Click
    Dim _filtro As String = ""
    If Not String.IsNullOrWhiteSpace(Me.txtcodigobarra.Text) Then
      _filtro = AgregarFiltro(_filtro, "Código de barras: " + Me.txtcodigobarra.Text)
    End If
    If Not String.IsNullOrWhiteSpace(Me.txtcodigoaux.Text) Then
      _filtro = AgregarFiltro(_filtro, "Código auxiliar: " + Me.txtcodigoaux.Text)
    End If
    If Not String.IsNullOrWhiteSpace(Me.txtserie.Text) Then
      _filtro = AgregarFiltro(_filtro, "Serie: " + Me.txtserie.Text)
    End If
    If Not String.IsNullOrWhiteSpace(Me.txtdescripcion.Text) Then
      _filtro = AgregarFiltro(_filtro, "Descripción: " + Me.txtdescripcion.Text)
    End If
    If Me.chkgrupo.Checked Then
      _filtro = AgregarFiltro(_filtro, "Grupo/Tipo/Clase: " + Me.CtlGrupoTipoClase.ParametroDet.DescripcionLarga)
    End If
    If Me.chkmarca.Checked Then
      _filtro = AgregarFiltro(_filtro, "Marca: " + Me.cboMarca.ParametroDet.Descripcion)
    End If
    If Not String.IsNullOrWhiteSpace(Me.txtmodelo.Text) Then
      _filtro = AgregarFiltro(_filtro, "Modelo: " + Me.txtmodelo.Text)
    End If
    If Me.chkproveedor.Checked Then
      _filtro = AgregarFiltro(_filtro, "Proveedor: " + Me.CtlBuscaProveedor1.Proveedor.NombreCompleto)
    End If
    If Me.chkfactura.Checked Then
      _filtro = AgregarFiltro(_filtro, "Factura: " + Me.CtlBuscaFactura1.FacturaActivo.Descripcion)
    End If
    If Me.chkcustodio.Checked Then
      _filtro = AgregarFiltro(_filtro, "Custodio: " + Me.CtlBuscaEmpleado1.Empleado.NombreCompleto)
    End If
    If Me.chkubicacion.Checked Then
      _filtro = AgregarFiltro(_filtro, "Ubicación: " + Me.CtlUbicacionActivo1.ParametroDet.DescripcionLarga)
    End If
    If Me.chkestadoinv.Checked Then
      _filtro = AgregarFiltro(_filtro, "Estado de inventario: " + Me.cboestadoinv.ParametroDet.Descripcion)
    End If
    If Me.chkfecha.Checked Then
      If Me.cbotipofecha.SelectedIndex < 4 Then
        _filtro = AgregarFiltro(_filtro, "Rango de fechas de " + Me.cbotipofecha.SelectedText + ": " + Me.dtfecdesde.Value.ToShortDateString + " y " + Me.dtfechasta.Value.ToShortDateString)
      Else
        _filtro = AgregarFiltro(_filtro, Me.cbotipofecha.SelectedText)
      End If
    End If
    If Me.chksoloactivos.Checked Then
      _filtro = AgregarFiltro(_filtro, "Sólo activos")
    End If

    Dim _ListaActivosOrden As EnumListaActivosOrden
    If sender Is PorGrupoTipoClaseToolStripMenuItem Then
      _ListaActivosOrden = EnumListaActivosOrden.GrupoTipoClase
    End If
    If sender Is PorCustodioToolStripMenuItem Then
      _ListaActivosOrden = EnumListaActivosOrden.Custodio
    End If
    If sender Is PorUbicacionToolStripMenuItem Then
      _ListaActivosOrden = EnumListaActivosOrden.Ubicacion
    End If

    If MnuDeprec.Checked Then
      Dim f As New FrmReporteListaActivosDepreciacion(Sistema, Enumerados.EnumOpciones.ListadoActivos)
      f.Filtro = _filtro
      f.ListaActivosOrden = _ListaActivosOrden
      f.dsReporteActivoDepreciacion = clsReporteActivo.RetornarListaActivosDepreciacionDS(_ListaActivosOrden, mOperadorDatos, Me.txtcodigobarra.Text, Me.txtcodigoaux.Text, Me.txtserie.Text, Me.txtdescripcion.Text, IIf(Me.chkgrupo.Checked, Me.CtlGrupoTipoClase.ParametroDet, Nothing), IIf(Me.chkmarca.Checked, Me.cboMarca.ParametroDet, Nothing), Me.txtmodelo.Text, IIf(Me.chkproveedor.Checked, Me.CtlBuscaProveedor1.Proveedor, Nothing), IIf(Me.chkfactura.Checked, Me.CtlBuscaFactura1.FacturaActivo, Nothing), IIf(Me.chkcustodio.Checked, Me.CtlBuscaEmpleado1.Empleado, Nothing), IIf(Me.chkubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing), IIf(Me.chkestadoinv.Checked, Me.cboestadoinv.ParametroDet, Nothing), Me.chksoloactivos.Checked, IIf(Me.chkfecha.Checked, Me.cbotipofecha.SelectedIndex, -1), IIf(Me.chkfecha.Checked, Me.dtfecdesde.Value, Nothing), IIf(Me.chkfecha.Checked, Me.dtfechasta.Value, Nothing))

      f.ShowDialog()
    Else
      Dim f As New FrmReporteListaActivos(Sistema, Enumerados.EnumOpciones.ListadoActivos)
      f.Filtro = _filtro
      f.ListaActivosOrden = _ListaActivosOrden
      f.dsReporteActivos = clsReporteActivo.RetornarListaActivosDS(_ListaActivosOrden, mOperadorDatos, Me.txtcodigobarra.Text, Me.txtcodigoaux.Text, Me.txtserie.Text, Me.txtdescripcion.Text, IIf(Me.chkgrupo.Checked, Me.CtlGrupoTipoClase.ParametroDet, Nothing), IIf(Me.chkmarca.Checked, Me.cboMarca.ParametroDet, Nothing), Me.txtmodelo.Text, IIf(Me.chkproveedor.Checked, Me.CtlBuscaProveedor1.Proveedor, Nothing), IIf(Me.chkfactura.Checked, Me.CtlBuscaFactura1.FacturaActivo, Nothing), IIf(Me.chkcustodio.Checked, Me.CtlBuscaEmpleado1.Empleado, Nothing), IIf(Me.chkubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing), IIf(Me.chkestadoinv.Checked, Me.cboestadoinv.ParametroDet, Nothing), Me.chksoloactivos.Checked, IIf(Me.chkfecha.Checked, Me.cbotipofecha.SelectedIndex, -1), IIf(Me.chkfecha.Checked, Me.dtfecdesde.Value, Nothing), IIf(Me.chkfecha.Checked, Me.dtfechasta.Value, Nothing))

      f.ShowDialog()
    End If
  End Sub

  Public Event Exportar As EventHandler

  Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
    RaiseEvent Exportar(Me, Nothing)
  End Sub

  Public Event ImprimirBarCode As EventHandler

  Private Sub ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem.Click
    RaiseEvent ImprimirBarCode(Me, Nothing)
  End Sub

  Private Sub pnlfecha_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlfecha.Paint

  End Sub

  Private Sub chkfecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkfecha.CheckedChanged
    Me.pnlfecha.Visible = Me.chkfecha.Checked
    dimensionartodo()
  End Sub

  Private Sub cbotipofecha_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbotipofecha.SelectedIndexChanged
    Me.pnlrangofechas.Visible = Me.cbotipofecha.SelectedIndex < 4
  End Sub

    Private Sub ActaDeIngresoDeActivosFijosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActaDeIngresoDeActivosFijosToolStripMenuItem.Click

        Dim f As New FrmReporteIngresoActivos(Sistema, Enumerados.EnumOpciones.ListadoActivos)
        'f.Filtro = _filtro
        'f.ListaActivosOrden = EnumListaActivosOrden.Ubicacion
        f.dsReporteActivos = clsReporteActivo.RetornarListaActivosIngresoDS(mOperadorDatos, Me.txtcodigobarra.Text, Me.txtcodigoaux.Text, Me.txtserie.Text, Me.txtdescripcion.Text, IIf(Me.chkgrupo.Checked, Me.CtlGrupoTipoClase.ParametroDet, Nothing), IIf(Me.chkmarca.Checked, Me.cboMarca.ParametroDet, Nothing), Me.txtmodelo.Text, IIf(Me.chkproveedor.Checked, Me.CtlBuscaProveedor1.Proveedor, Nothing), IIf(Me.chkfactura.Checked, Me.CtlBuscaFactura1.FacturaActivo, Nothing), IIf(Me.chkcustodio.Checked, Me.CtlBuscaEmpleado1.Empleado, Nothing), IIf(Me.chkubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing), IIf(Me.chkestadoinv.Checked, Me.cboestadoinv.ParametroDet, Nothing), Me.chksoloactivos.Checked, IIf(Me.chkfecha.Checked, Me.cbotipofecha.SelectedIndex, -1), IIf(Me.chkfecha.Checked, Me.dtfecdesde.Value, Nothing), IIf(Me.chkfecha.Checked, Me.dtfechasta.Value, Nothing))
        f.ShowDialog()
    End Sub
End Class
