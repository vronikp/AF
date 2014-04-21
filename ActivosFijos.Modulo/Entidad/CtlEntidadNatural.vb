Imports ActivosFijos.Reglas


Public Class CtlEntidadNatural
  Public Property PuedeSRI() As Boolean
    Get
      Return Me.grpsri.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.grpsri.Visible = value
    End Set
  End Property

  Private mEntidad As Entidad = Nothing
  Public Property Entidad() As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      If value IsNot Nothing Then
        Me.ComboBoxEstadoCivil.OperadorDatos = value.OperadorDatos
        Me.ComboBoxEstadoCivil.Parametro = Enumerados.EnumParametros.EstadoCivil
        Me.ComboBoxEstadoCivil.Llenar_Datos()

        Me.ComboBoxSexo.OperadorDatos = value.OperadorDatos
        Me.ComboBoxSexo.Parametro = Enumerados.EnumParametros.Sexo
        Me.ComboBoxSexo.Llenar_Datos()

        llenar_datos()
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mEntidad Is Nothing OrElse mEntidad.Entidadnatural Is Nothing Then
      Me.pnlcuerpo.Visible = False
      Exit Sub
    End If

    Me.Entnat_ApellidopaternoTextBox.Text = mEntidad.Entidadnatural.Entnat_Apellidopaterno
    Me.Entnat_ApellidomaternoTextBox.Text = mEntidad.Entidadnatural.Entnat_Apellidomaterno
    Me.Entnat_NombresTextBox.Text = mEntidad.Entidadnatural.Entnat_Nombres
    Me.Entnat_FechanacimientoDateTimePicker.Checked = Not mEntidad.Entidadnatural.Entnat_Fechanacimiento = Nothing
    If Not mEntidad.Entidadnatural.Entnat_Fechanacimiento = Nothing Then
      Me.Entnat_FechanacimientoDateTimePicker.Value = mEntidad.Entidadnatural.Entnat_Fechanacimiento
    End If
    Me.ComboBoxEstadoCivil.ParametroDet = mEntidad.Entidadnatural.PardetEstadoCivil
    Me.ComboBoxSexo.ParametroDet = mEntidad.Entidadnatural.PardetSexo

    Me.CtlDireccion1.Entidad = mEntidad
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Domicilio

    Me.CtlTelefono1.Entidad = mEntidad
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    Me.CtlTelefono2.Entidad = mEntidad
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Fax
    Me.CtlTelefono3.Entidad = mEntidad
    Me.CtlTelefono3.TipoTelefono = Enumerados.enumTipoTelefono.Domicilio

    Me.CtlEmail1.Entidad = mEntidad
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    Me.CtlEmail2.Entidad = mEntidad
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo1

    Me.CtlIdentificacion1.Entidad = mEntidad
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion2.Entidad = mEntidad
    Me.CtlIdentificacion2.TipoIdentificacion = Enumerados.enumTipoIdentificacion.Cedula
    Me.CtlIdentificacion3.Entidad = mEntidad
    Me.CtlIdentificacion3.TipoIdentificacion = Enumerados.enumTipoIdentificacion.Pasaporte
    Me.CtlIdentificacion4.Entidad = mEntidad
    Me.CtlIdentificacion4.TipoIdentificacion = Enumerados.enumTipoIdentificacion.CedulaMilitar
    Me.CtlIdentificacion5.Entidad = mEntidad
    Me.CtlIdentificacion5.TipoIdentificacion = Enumerados.enumTipoIdentificacion.LicenciaConducir

    Me.txtautofactura.Text = mEntidad.Entida_AutorizacionFactura
    Me.mskcaducfactura.Text = mEntidad.Entida_CaducidadFactura
    Me.txtautonotvta.Text = mEntidad.Entida_AutorizacionNotaVenta
    Me.mskcaducnotvta.Text = mEntidad.Entida_CaducidadNotaVenta
    Me.txtautoret.Text = mEntidad.Entida_AutorizacionRetencion
    Me.mskcaducret.Text = mEntidad.Entida_CaducidadRetencion

  End Sub

  Public Sub Mapear_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If

    mEntidad.Entidadnatural.Entnat_Apellidopaterno = Me.Entnat_ApellidopaternoTextBox.Text
    mEntidad.Entidadnatural.Entnat_Apellidomaterno = Me.Entnat_ApellidomaternoTextBox.Text
    mEntidad.Entidadnatural.Entnat_Nombres = Me.Entnat_NombresTextBox.Text
    If Me.Entnat_FechanacimientoDateTimePicker.Checked Then
      mEntidad.Entidadnatural.Entnat_Fechanacimiento = Me.Entnat_FechanacimientoDateTimePicker.Value
    End If
    mEntidad.Entidadnatural.PardetEstadoCivil = Me.ComboBoxEstadoCivil.ParametroDet
    mEntidad.Entidadnatural.PardetSexo = Me.ComboBoxSexo.ParametroDet

    mEntidad.Entida_AutorizacionFactura = Me.txtautofactura.Text
    mEntidad.Entida_CaducidadFactura = Me.mskcaducfactura.Text
    mEntidad.Entida_AutorizacionNotaVenta = Me.txtautonotvta.Text
    mEntidad.Entida_CaducidadNotaVenta = Me.mskcaducnotvta.Text
    mEntidad.Entida_AutorizacionRetencion = Me.txtautoret.Text
    mEntidad.Entida_CaducidadRetencion = Me.mskcaducret.Text
  End Sub

  Private Sub CtlDireccion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlDireccion1.Load

  End Sub

  Private Sub CtlIdentificacion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlIdentificacion1.Load

  End Sub

  Public Event Repetido As EventHandler

  Private Sub CtlIdentificacion1_Repetido(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlIdentificacion1.Repetido, CtlIdentificacion2.Repetido, CtlIdentificacion3.Repetido, CtlIdentificacion4.Repetido, CtlIdentificacion5.Repetido
    Dim _ident As CtlIdentificacion
    _ident = CType(sender, CtlIdentificacion)
    If MsgBox(String.Format("La identificación {0} con número {1} ya está registrada a nombre de {2}. ¿Desea recargar la información de esa persona?", _ident.Identificacion.PardetTipoIdent.Pardet_Descripcion, _ident.Identificacion.Identi_Numero, _ident.EntidadRepetido.NombreCompleto), MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      Entidad = _ident.EntidadRepetido
      RaiseEvent Repetido(sender, e)
    End If
  End Sub
End Class
