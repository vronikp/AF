Imports ActivosFijos.Reglas
Imports Infoware.Consola.Base

Public Class CtlActivo
    Private mesClon As Boolean = False
    Private mUbicacionClone As WWTSParametroDet
    Private mCustodioClone As Empleado
    Private mCostoClone As Decimal
    Private mSalvamentoClone As Decimal
    Private mPeriodosClone As Integer
    Private mFrecuenciaClone As WWTSParametroDet

    Public ReadOnly Property Sistema() As Sistema
        Get
            If CType(Me.ParentForm, FrmFormaBase) Is Nothing Then
                Return Nothing
            End If
            Return CType(Me.ParentForm, FrmFormaBase).Sistema
        End Get
    End Property

    Private mActivo As Activo = Nothing
    Public Property Activo As Activo
        Get
            Return mActivo
        End Get
        Set(value As Activo)
            mActivo = value
            llenar_datos()
        End Set
    End Property

    Sub llenar_datos()
        If mActivo Is Nothing Then
            Exit Sub
        End If
        CargarCombos()
        Me.pnlcopiaractivo.Enabled = Not mActivo.EsNuevo
        'Es version basica
        Dim PardetEmpresaActivo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1)
        If PardetEmpresaActivo.Pardet_DatoStr1 = "F8MM7B" And PardetEmpresaActivo.Pardet_DatoStr2 = "N9ME4A" And
            PardetEmpresaActivo.Pardet_DatoStr3 = "F6MG3S" And PardetEmpresaActivo.Pardet_DatoInt1 = 151102 And
            PardetEmpresaActivo.Pardet_DatoBit1 = True Then
            Me.TabControl1.TabPages.Remove(Me.TabPage2)
        End If

        If Not mActivo.EsNuevo AndAlso mActivo.Facturaactivo IsNot Nothing Then
            Me.CtlBuscaProveedor1.Proveedor = mActivo.Facturaactivo.Proveedor
            Me.CtlBuscaFactura1.FacturaActivo = mActivo.Facturaactivo
            Me.dtfecfactura.Value = mActivo.Facturaactivo.Factura_Fecha
        End If
        Me.txtcodigo.Enabled = False

        If mActivo.OperadorDatos.Proveedor = Infoware.Datos.enumProveedorDatos.Sybase Then
            Me.PictureBox1.Enabled = False
        Else
            Me.PictureBox1.Imagen = mActivo.Activo_Imagen
        End If

        Me.txtcodigo.Value = mActivo.Activo_Codigo
        Me.txtcodigobarra.Text = mActivo.Activo_CodigoBarra

        If Not String.IsNullOrWhiteSpace(mActivo.Activo_CodigoBarraCruce) Then
            Me.lblmensaje.Text = "Activo cruzado con código de barras " + mActivo.Activo_CodigoBarraCruce
            Me.lblmensaje.Visible = True
        Else
            Me.lblmensaje.Visible = False
        End If

        If mActivo.PardetTipoBajaActivo Is Nothing Then
            Me.pnlcabecera.BackColor = System.Drawing.SystemColors.Control
        Else
            Me.pnlcabecera.BackColor = Color.Salmon
        End If

        Me.txtcodbarracruce.Text = mActivo.Activo_CodigoBarraCruce
        Me.txtcodigoauxiliar.Text = mActivo.Activo_CodigoAux
        Me.txtserie.Text = mActivo.Activo_Serie

        If mActivo.PardetClaseActivo IsNot Nothing Then
            Me.cboGrupo.ParametroDet = mActivo.PardetClaseActivo.PardetPadre.PardetPadre
            Me.cboTipo.ParametroDet = mActivo.PardetClaseActivo.PardetPadre
            Me.cboClase.ParametroDet = mActivo.PardetClaseActivo
        End If
        'Me.CtlGrupoTipoClase.ParametroEnum = Enumerados.EnumParametros.ClaseActivo
        'Me.CtlGrupoTipoClase.ParametroDet = mActivo.PardetClaseActivo

        Me.txtdescripcion.Text = mActivo.Activo_Descripcion
        Me.cbomarca.ParametroDet = mActivo.PardetMarca
        Me.txtmodelo.Text = mActivo.Activo_Modelo
        Me.txtobservacion.Text = mActivo.Activo_Observacion
        Me.cboestadodepreciacion.ParametroDet = mActivo.PardetEstadoDepreciacion
        Me.cboestado.ParametroDet = mActivo.PardetEstadoActivo
        Me.txtresponsablemant.Text = mActivo.Activo_ResponsableMantenimiento
        Me.dtfecingreso.Value = mActivo.Activo_FechaIngreso
        Me.dtfeccompra.Value = If(mActivo.Activo_FechaCompra = Nothing, Now.Date, mActivo.Activo_FechaCompra)
        Me.dtfecuso.Checked = Not mActivo.Activo_FechaUso = Nothing
        Me.dtfecuso.Value = If(mActivo.Activo_FechaUso = Nothing, Now.Date, mActivo.Activo_FechaUso)
        Me.dtfecgarantia.Checked = Not mActivo.Activo_FechaGarantia = Nothing
        Me.dtfecgarantia.Value = If(mActivo.Activo_FechaGarantia = Nothing, Now.Date, mActivo.Activo_FechaGarantia)
        Me.grpbaja.Visible = Not mActivo.Activo_FechaBaja = Nothing
        If Not mActivo.Activo_FechaBaja = Nothing Then
            Me.dtfecbaja.Value = mActivo.Activo_FechaBaja
        End If
        Me.cbotipobaja.ParametroDet = mActivo.PardetTipoBajaActivo

        Me.cbocentrocosto.ParametroDet = mActivo.PardetCentroCosto

        If mActivo.EsNuevo AndAlso (mActivo.ActivoCustodios Is Nothing OrElse mActivo.ActivoCustodios.Count = 0) Then
            Dim _custodio As Empleado = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo).Empleado
            Me.CtlBuscaCustodio.SoloActivos = True
            Me.CtlBuscaCustodio.Empleado = _custodio
            Me.CtlBuscaCustodio.Enabled = _custodio Is Nothing
        End If

        Me.pnlubicacionnuevo.Visible = mActivo.EsNuevo AndAlso (mActivo.ActivoUbicaciones Is Nothing OrElse mActivo.ActivoUbicaciones.Count = 0)
        Me.grpubicacion.Visible = Not (mActivo.EsNuevo AndAlso (mActivo.ActivoUbicaciones Is Nothing OrElse mActivo.ActivoUbicaciones.Count = 0))
        Me.grpcustodio.Visible = Not (mActivo.EsNuevo AndAlso (mActivo.ActivoCustodios Is Nothing OrElse mActivo.ActivoCustodios.Count = 0))

        'Me.dgActivos.AutoDiscover()
        llenar_caracteristicas()

        Me.bsubicaciones.DataSource = mActivo.ActivoUbicaciones
        Me.dgubicaciones.AutoDiscover()

        Me.bscustodios.DataSource = mActivo.ActivoCustodios
        Me.dgcustodios.AutoDiscover()

        Me.bscomponentes.DataSource = mActivo.Componentes
        Me.dgComponentes.AutoDiscover()

        Me.bsinventarios.DataSource = mActivo.Inventarios
        Me.dginventarios.AutoDiscover()

        Me.bspolizas.DataSource = mActivo.Polizas
        Me.dgpoliza.AutoDiscover()

        Me.pnlvaloracion.Visible = mActivo.EsNuevo AndAlso (mActivo.Valoraciones Is Nothing OrElse mActivo.Valoraciones.Count = 0)
        Me.grpvaloracion.Visible = Not (mActivo.EsNuevo AndAlso (mActivo.Valoraciones Is Nothing OrElse mActivo.Valoraciones.Count = 0))
        Me.bsvaloraciones.DataSource = mActivo.Valoraciones
        Me.dgvaloracion.AutoDiscover()

        If mesClon Then
            MsgBox(mUbicacionClone.DescripcionLarga)
            MsgBox(mCustodioClone.NombreCompleto)
            Me.CtlUbicacionActivo1.ParametroDet = mUbicacionClone
            Me.CtlBuscaCustodio.Empleado = mCustodioClone
            MsgBox(Me.CtlBuscaCustodio.Empleado.NombreCompleto)
            Me.txtcostoactivo.Value = mCostoClone
            Me.txtvalorsalvamento.Value = mSalvamentoClone
            Me.txtperiodosdepreciables.Value = mPeriodosClone
            Me.cboFrecuenciaDepreciacion.ParametroDet = mFrecuenciaClone
        End If
        mesClon = False
    End Sub

#Region "Imagen"
    Private Sub CambioImagen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.CambioImagen
        If mActivo Is Nothing Then
            Exit Sub
        End If
        mActivo.ArchivoImagen = Me.PictureBox1.ArchivoImagen
    End Sub
#End Region

    Sub llenar_caracteristicas()
        If Activo Is Nothing OrElse cboTipo.ParametroDet Is Nothing Then
            Exit Sub
        End If
        'Activo.Caracteristicas = Nothing
        Dim _caracts As New ActivoCaracteristicaList
        _caracts = Activo.Caracteristicas

        Dim t As Integer = 0
        While t < _caracts.Count
            If String.IsNullOrWhiteSpace(_caracts(t).ActCar_Descripcion) AndAlso _caracts(t).EsNuevo Then
                _caracts.RemoveAt(t)
            Else
                t += 1
            End If
        End While

        Dim _nuevasCaracts As New WWTSParametroDetList
        If Me.cboTipo.ParametroDet IsNot Nothing Then
            _nuevasCaracts = WWTSParametroDetList.ObtenerLista(Sistema.OperadorDatos, Enumerados.EnumParametros.CaracteristicaActivo, WWTSParametroDetList.enumTipoObjeto.Nada, Me.cboTipo.ParametroDet)
        End If

        For Each _caractp As WWTSParametroDet In _nuevasCaracts
            Dim _existe As Boolean = False
            For Each _caract As ActivoCaracteristica In _caracts
                If _caractp.Pardet_Secuencia = _caract.Pardet_Caracteristica Then
                    _existe = True
                    Exit For
                End If
            Next
            If Not _existe Then
                Dim _caracteristica As New ActivoCaracteristica(Sistema.OperadorDatos, True)
                _caracteristica.PardetCaracteristica = _caractp
                _caracteristica.Activo = Activo
                _caracts.Add(_caracteristica)
            End If
        Next

        Activo.Caracteristicas = _caracts
        bscaracteristicas.DataSource = _caracts
        Me.dgcaracteristicas.AutoDiscover()
    End Sub

    Sub Mapear_datos()
        If Me.CtlBuscaFactura1.FacturaActivo Is Nothing Then
            Throw New Exception("No ha seleccionado una factura")
        End If
        mActivo.Facturaactivo = Me.CtlBuscaFactura1.FacturaActivo
        mActivo.Activo_Codigo = Me.txtcodigo.Value
        mActivo.Activo_CodigoBarra = Me.txtcodigobarra.Text
        mActivo.Activo_CodigoBarraCruce = Me.txtcodbarracruce.Text
        mActivo.Activo_CodigoAux = Me.txtcodigoauxiliar.Text
        mActivo.Activo_Serie = Me.txtserie.Text
        If Me.cboClase.ParametroDet Is Nothing OrElse Not Me.cboClase.ParametroDet.Parame_Codigo = Enumerados.EnumParametros.ClaseActivo Then
            Me.TabControl1.SelectedTab = Me.TpUbicacion
            Throw New Exception("Debe seleccionar una clase de activo")
        End If
        mActivo.PardetClaseActivo = Me.cboClase.ParametroDet
        mActivo.Activo_Descripcion = Me.txtdescripcion.Text
        mActivo.PardetMarca = Me.cbomarca.ParametroDet
        mActivo.Activo_Modelo = Me.txtmodelo.Text
        mActivo.Activo_Observacion = Me.txtobservacion.Text
        mActivo.PardetEstadoDepreciacion = Me.cboestadodepreciacion.ParametroDet
        mActivo.PardetEstadoActivo = Me.cboestado.ParametroDet
        mActivo.Activo_ResponsableMantenimiento = Me.txtresponsablemant.Text
        mActivo.Activo_FechaIngreso = Me.dtfecingreso.Value
        mActivo.Activo_FechaCompra = Me.dtfeccompra.Value
        mActivo.Activo_FechaUso = IIf(Me.dtfecuso.Checked, Me.dtfecuso.Value, Nothing)
        mActivo.Activo_FechaGarantia = IIf(Me.dtfecgarantia.Checked, Me.dtfecgarantia.Value, Nothing)
        If Not mActivo.Activo_FechaBaja = Nothing Then
            mActivo.Activo_FechaBaja = Me.dtfecbaja.Value
            mActivo.PardetTipoBajaActivo = Me.cbotipobaja.ParametroDet
        Else
            mActivo.PardetTipoBajaActivo = Nothing
        End If

        mActivo.PardetCentroCosto = Me.cbocentrocosto.ParametroDet

        If mActivo.EsNuevo Then
            If Me.CtlUbicacionActivo1.ParametroDet Is Nothing OrElse Not Me.CtlUbicacionActivo1.ParametroDet.Parame_Codigo = Enumerados.EnumParametros.UbicacionActivo Then
                Me.TabControl1.SelectedTab = Me.TpUbicacion
                Throw New Exception("Debe seleccionar una ubicación")
            End If
            If Me.CtlBuscaCustodio.Empleado Is Nothing Then
                Me.TabControl1.SelectedTab = Me.TpUbicacion
                Throw New Exception("Debe seleccionar un custodio")
            End If

        End If

    End Sub

    Public Function Guardar() As Boolean
        dgcaracteristicas.EndEdit()
        Dim result As Boolean = mActivo.Guardar(Me.CtlUbicacionActivo1.ParametroDet, Me.CtlBuscaCustodio.Empleado, Me.txtcostoactivo.Value, Me.txtvalorsalvamento.Value, Me.txtperiodosdepreciables.Value, Me.cboFrecuenciaDepreciacion.ParametroDet)
        If result Then
            mActivo.Recargar()
        End If
        Return result
    End Function

    Private mActivoCopiar As Activo = Nothing

    Public ReadOnly Property ActivoCopiar As Activo
        Get
            Return mActivoCopiar
        End Get
    End Property

    Public Event CopiarActivo As EventHandler

    Private Sub btncopiaractivo_Click(sender As System.Object, e As System.EventArgs) Handles btncopiaractivo.Click
        If mActivo Is Nothing Then
            Exit Sub
        End If
        Dim _Activo As Activo = mActivo.Clone
        mesClon = True
        mUbicacionClone = mActivo.UbicacionActual
        mCustodioClone = mActivo.CustodioActual
        mCostoClone = mActivo.CostoActual
        mSalvamentoClone = mActivo.SalvamentoActual
        mPeriodosClone = mActivo.PeriodosDepreciablesActual
        mFrecuenciaClone = mActivo.FrecuenciaDepreciacionActual
        mActivoCopiar = _Activo

        RaiseEvent CopiarActivo(Me, Nothing)
    End Sub

    Public Function clonar() As Boolean
        If mActivo Is Nothing Then
            Return False
        End If
        Dim _Activo As Activo = mActivo.Clone
        mesClon = True
        mUbicacionClone = mActivo.UbicacionActual
        mCustodioClone = mActivo.CustodioActual
        mCostoClone = mActivo.CostoActual
        mSalvamentoClone = mActivo.SalvamentoActual
        mPeriodosClone = mActivo.PeriodosDepreciablesActual
        mFrecuenciaClone = mActivo.FrecuenciaDepreciacionActual
        mActivoCopiar = _Activo

        RaiseEvent CopiarActivo(Me, Nothing)
        Return True
    End Function

    Private Sub CtlActivo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
    End Sub

    Private mCombosCargados As Boolean = False

    Private Sub CargarCombos()
        If Sistema IsNot Nothing Then
            Me.CtlBuscaProveedor1.SoloActivos = mActivo.EsNuevo
            Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
            Me.CtlBuscaProveedor1.Llenar_Datos()

            Me.CtlBuscaCustodio.SoloActivos = mActivo.EsNuevo
            Me.CtlBuscaCustodio.OperadorDatos = Sistema.OperadorDatos
            Me.CtlBuscaCustodio.TipoEmpleado = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoEmpleado, Enumerados.enumTipoEmpleado.Custodio)
            Me.CtlBuscaCustodio.Llenar_Datos()
        End If

        If Sistema Is Nothing AndAlso Not mCombosCargados Then
            Exit Sub
        End If

        mCombosCargados = True

        Me.CtlBuscaFactura1.OperadorDatos = Sistema.OperadorDatos

        Me.cboGrupo.Parametro = Enumerados.EnumParametros.GrupoActivo
        Me.cboGrupo.OperadorDatos = Sistema.OperadorDatos
        Me.cboGrupo.Llenar_Datos()
        'Me.CtlGrupoTipoClase.ParametroEnum = Enumerados.EnumParametros.ClaseActivo
        'Me.CtlGrupoTipoClase.llenar_Datos()

        Me.cbomarca.Parametro = Enumerados.EnumParametros.MarcaActivo
        Me.cbomarca.OperadorDatos = Sistema.OperadorDatos
        Me.cbomarca.Llenar_Datos()

        Me.cboestadodepreciacion.Parametro = Enumerados.EnumParametros.EstadoDepreciacion
        Me.cboestadodepreciacion.OperadorDatos = Sistema.OperadorDatos
        Me.cboestadodepreciacion.Llenar_Datos()

        Me.cboestado.Parametro = Enumerados.EnumParametros.EstadoActivo
        Me.cboestado.OperadorDatos = Sistema.OperadorDatos
        Me.cboestado.Llenar_Datos()

        Me.cboFrecuenciaDepreciacion.Parametro = Enumerados.EnumParametros.FrecuenciaDepreciacion
        Me.cboFrecuenciaDepreciacion.OperadorDatos = Sistema.OperadorDatos
        Me.cboFrecuenciaDepreciacion.Llenar_Datos()

        Me.cbotipobaja.Parametro = Enumerados.EnumParametros.TipoBajaActivo
        Me.cbotipobaja.OperadorDatos = Sistema.OperadorDatos
        Me.cbotipobaja.Llenar_Datos()

        Me.cbocentrocosto.Parametro = Enumerados.EnumParametros.CentroCostoActivo
        Me.cbocentrocosto.OperadorDatos = Sistema.OperadorDatos
        Me.cbocentrocosto.Llenar_Datos()

        Me.cboFrecuenciaDepreciacion.Parametro = Enumerados.EnumParametros.FrecuenciaDepreciacion
        Me.cboFrecuenciaDepreciacion.OperadorDatos = Sistema.OperadorDatos
        Me.cboFrecuenciaDepreciacion.Llenar_Datos()

        Me.CtlUbicacionActivo1.SoloVisibles = True
        Me.CtlUbicacionActivo1.PardetRaiz = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo).PardetUbicacion
        Me.CtlUbicacionActivo1.llenar_Datos()
    End Sub

    Private Sub CtlBuscaProveedor1_CambioItem(sender As Object, e As System.EventArgs) Handles CtlBuscaProveedor1.CambioItem
        Me.CtlBuscaFactura1.Proveedor = Me.CtlBuscaProveedor1.Proveedor
        Me.CtlBuscaFactura1.Llenar_Datos()
    End Sub

    Private Sub CtlBuscaFactura1_CambioItem(sender As Object, e As System.EventArgs) Handles CtlBuscaFactura1.CambioItem
        If CtlBuscaFactura1.FacturaActivo IsNot Nothing Then
            Me.dtfecfactura.Value = Me.CtlBuscaFactura1.FacturaActivo.Factura_Fecha
            Me.dtfecfactura.Enabled = False
        Else
            Me.dtfecfactura.Enabled = True
        End If
    End Sub


#Region "Componentes"
    Private Sub btnnuevocomp_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevocomp.Click
        Me.bscomponentes.AddNew()

        Dim f As New FrmMantenimientoActivoComponente(Sistema, Enumerados.EnumOpciones.ListadoActivos)
        f.ActivoComponentes = Me.bscomponentes
        f.ShowDialog()
        Me.bsvaloraciones.DataSource = mActivo.Valoraciones
        Me.dgvaloracion.AutoDiscover()
        Me.dgComponentes.AutoDiscover()
    End Sub

    Private Sub btnmodicomp_Click(sender As System.Object, e As System.EventArgs) Handles btnmodicomp.Click
        If Me.bscomponentes.Current Is Nothing Then
            Exit Sub
        End If
        Dim f As New FrmMantenimientoActivoComponente(Sistema, Enumerados.EnumOpciones.ListadoActivos)
        f.ActivoComponentes = Me.bscomponentes
        f.ShowDialog()
        Me.bsvaloraciones.DataSource = mActivo.Valoraciones
        Me.dgvaloracion.AutoDiscover()
        Me.dgComponentes.Invalidate()
    End Sub

    Private Sub btnelimcomp_Click(sender As System.Object, e As System.EventArgs) Handles btnelimcomp.Click
        If Me.bscomponentes.Current Is Nothing Then
            Exit Sub
        End If
        If MsgBox("¿Está seguro que desea eliminar este componente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim comp As ActivoComponente = CType(Me.bscomponentes.Current, ActivoComponente)
            If Not comp.EsNuevo AndAlso Not CType(Me.bscomponentes.Current, ActivoComponente).Eliminar Then
                MsgBox("Error al eliminar componente. " & comp.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            mActivo.ComponentesEli.Add(Me.bscomponentes.Current)
            Me.bscomponentes.RemoveCurrent()
            Me.dgComponentes.AutoDiscover()
            Mapear_datos()
            Guardar()
            Me.bsvaloraciones.DataSource = mActivo.Valoraciones
            Me.dgvaloracion.AutoDiscover()
            Me.dgComponentes.Invalidate()
        End If
    End Sub

#End Region

    Private Sub txtcostoactivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcostoactivo.TextChanged, txtvalorsalvamento.TextChanged
        Me.txtvaloradepreciar.Value = Me.txtcostoactivo.Value - Me.txtvalorsalvamento.Value
    End Sub

    Private Sub dgcustodios_DespuesSeleccionarCampos(sender As Object, e As System.EventArgs) Handles dgcustodios.DespuesSeleccionarCampos
        Me.dgcustodios.Columns.RemoveAt(1)
    End Sub

    Private Sub dgubicaciones_DespuesSeleccionarCampos(sender As Object, e As System.EventArgs) Handles dgubicaciones.DespuesSeleccionarCampos
        Me.dgubicaciones.Columns.RemoveAt(1)
    End Sub

    Private Sub btnnuevovaloracion_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevovaloracion.Click
        Dim _val As New ActivoValor(Sistema.OperadorDatos, True)
        _val.Activo = mActivo
        _val.PardetTipoValoracion = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoValoracion, CInt(Enumerados.enumTipoValoracion.Valoracion))

        Me.bsvaloraciones.Add(_val)
        Me.bsvaloraciones.MoveLast()

        Dim f As New FrmMantenimientoActivoValoracion(Sistema, Enumerados.EnumOpciones.ListadoActivos)
        f.ActivoValores = Me.bsvaloraciones
        f.ShowDialog()

        Me.bsvaloraciones.DataSource = mActivo.Valoraciones
        Me.dgvaloracion.AutoDiscover()
    End Sub

    Private Sub dginventarios_DespuesSeleccionarCampos(sender As Object, e As System.EventArgs) Handles dginventarios.DespuesSeleccionarCampos
        Me.dginventarios.Columns.RemoveAt(1)

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "PeriodoString"
        DataGridViewTextBoxColumn1.HeaderText = "Periodo"
        DataGridViewTextBoxColumn1.Width = 120
        Me.dginventarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        DataGridViewTextBoxColumn1.Width = 120
        Me.dginventarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "EstadoInventarioString"
        DataGridViewTextBoxColumn1.HeaderText = "Estado Inventario"
        DataGridViewTextBoxColumn1.Width = 120
        Me.dginventarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    End Sub

    Private Sub bsvaloracion_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles bsvaloraciones.CurrentChanged
        If Me.bsvaloraciones.Current Is Nothing Then
            Me.bsdepreciaciones.DataSource = Nothing
            Me.dgDepreciaciones.AutoDiscover()
        Else
            Me.bsdepreciaciones.DataSource = CType(bsvaloraciones.Current, ActivoValor).Depreciaciones
            Me.dgDepreciaciones.AutoDiscover()
        End If
    End Sub

    Private Sub CtlBuscaProveedor1_Load(sender As System.Object, e As System.EventArgs) Handles CtlBuscaProveedor1.Load

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        Me.cboTipo.Parametro = Enumerados.EnumParametros.TipoActivo
        Me.cboTipo.OperadorDatos = Sistema.OperadorDatos
        'Me.cboTipo.ParametroDet.PardetPadre = Me.cboGrupo.ParametroDet
        Me.cboTipo.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Nada, Me.cboGrupo.ParametroDet)
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.ParametroDet Is Nothing Then
            Exit Sub
        End If
        Me.cboClase.Parametro = Enumerados.EnumParametros.ClaseActivo
        Me.cboClase.OperadorDatos = Sistema.OperadorDatos
        Me.cboClase.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Nada, Me.cboTipo.ParametroDet)

        Me.txtperiodosdepreciables.Value = Me.cboTipo.ParametroDet.Pardet_DatoInt1
        llenar_caracteristicas()
    End Sub

    Private Sub btnNuevoMarca_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoMarca.Click
        Dim _param As WWTSParametro
        _param = New WWTSParametro(Sistema.OperadorDatos, Me.cbomarca.Parametro)
        Dim menumtipoobjeto As Infoware.Reglas.General.ParametroDetList.enumTipoObjeto = WWTSParametroDetList.enumTipoObjeto.Nada
        If Not _param.Parame_esImagen And Not String.IsNullOrEmpty(_param.Parame_LeyendaDatoImg1) Then
            Dim f As New FrmParametroDetFile
            f.ParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, Me.cbomarca.Parametro, True)
            'f.Direccion = IMantenimiento.Accion.Ingreso
            If f.ShowDialog() = DialogResult.OK Then
                Me.cbomarca.Llenar_Datos(menumtipoobjeto, Me.cbomarca.ParametroDet.PardetPadre)
            End If
        Else
            Dim f As New FrmParametroDet
            f.enumtipoobjeto = menumtipoobjeto
            f.ParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, Me.cbomarca.Parametro, True)
            'f.Direccion = IMantenimiento.Accion.Ingreso
            If f.ShowDialog() = DialogResult.OK Then
                Me.cbomarca.Llenar_Datos(menumtipoobjeto, Me.cbomarca.ParametroDet.PardetPadre)
            End If
        End If
    End Sub
End Class
