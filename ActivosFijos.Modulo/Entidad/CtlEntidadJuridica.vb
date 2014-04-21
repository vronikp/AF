Imports ActivosFijos.Reglas


Public Class CtlEntidadJuridica
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
        Me.ComboBoTipoContrib.OperadorDatos = value.OperadorDatos
        Me.ComboBoTipoContrib.Parametro = Enumerados.EnumParametros.TipoContribuyente
        Me.ComboBoTipoContrib.Llenar_Datos()

        Me.CtlBuscaEntidad1.OperadorDatos = value.OperadorDatos
        Me.CtlBuscaEntidad2.OperadorDatos = value.OperadorDatos
        Llenar_datos()
      End If
    End Set
  End Property

  Public Sub Llenar_datos()
    If mEntidad Is Nothing OrElse mEntidad.Entidadjuridica Is Nothing Then
      Me.pnl_cuerpo.Visible = False
      Exit Sub
    End If

    Me.Entjur_NombreComercial.Text = mEntidad.Entidadjuridica.Entjur_Nombrecomercial
    Me.EntJur_RazonSocial.Text = mEntidad.Entidadjuridica.Entjur_Razonsocial
    Me.EntJur_Fechaconstitucion.Checked = Not mEntidad.Entidadjuridica.Entjur_Fechaconstitucion = Nothing
    If Not mEntidad.Entidadjuridica.Entjur_Fechaconstitucion = Nothing Then
      Me.EntJur_Fechaconstitucion.Value = mEntidad.Entidadjuridica.Entjur_Fechaconstitucion
    End If
    Me.ComboBoTipoContrib.ParametroDet = mEntidad.Entidadjuridica.PardetTipoContribuyente
    Me.CtlBuscaEntidad1.EntidadNatural = mEntidad.Entidadjuridica.RepresentanteLegal
    Me.CtlBuscaEntidad2.EntidadNatural = mEntidad.Entidadjuridica.Contacto

    Me.CtlDireccion1.Entidad = mEntidad
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Trabajo

    Me.CtlTelefono1.Entidad = mEntidad
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    Me.CtlTelefono2.Entidad = mEntidad
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Fax

    Me.CtlEmail1.Entidad = mEntidad
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    Me.CtlEmail2.Entidad = mEntidad
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo1

    Me.CtlIdentificacion1.Entidad = mEntidad
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC

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

    mEntidad.Entidadjuridica.Entjur_Nombrecomercial = Me.Entjur_NombreComercial.Text
    mEntidad.Entidadjuridica.Entjur_Razonsocial = Me.EntJur_RazonSocial.Text
    mEntidad.Entidadjuridica.PardetTipoContribuyente = Me.ComboBoTipoContrib.ParametroDet
    If Me.EntJur_Fechaconstitucion.Checked Then
      mEntidad.Entidadjuridica.Entjur_Fechaconstitucion = Me.EntJur_Fechaconstitucion.Value
    End If
    mEntidad.Entidadjuridica.RepresentanteLegal = Me.CtlBuscaEntidad1.EntidadNatural
    mEntidad.Entidadjuridica.Contacto = Me.CtlBuscaEntidad2.EntidadNatural

    mEntidad.Entida_AutorizacionFactura = Me.txtautofactura.Text
    mEntidad.Entida_CaducidadFactura = Me.mskcaducfactura.Text
    mEntidad.Entida_AutorizacionNotaVenta = Me.txtautonotvta.Text
    mEntidad.Entida_CaducidadNotaVenta = Me.mskcaducnotvta.Text
    mEntidad.Entida_AutorizacionRetencion = Me.txtautoret.Text
    mEntidad.Entida_CaducidadRetencion = Me.mskcaducret.Text
  End Sub

  Public Event Repetido As EventHandler

  Private Sub CtlIdentificacion1_Repetido(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlIdentificacion1.Repetido ', CtlIdentificacion2.Repetido, CtlIdentificacion3.Repetido, CtlIdentificacion4.Repetido, CtlIdentificacion5.Repetido
    Dim _ident As CtlIdentificacion
    _ident = CType(sender, CtlIdentificacion)
    If MsgBox(String.Format("La identificación {0} con número {1} ya está registrada a nombre de {2}. ¿Desea recargar la información de esa persona?", _ident.Identificacion.PardetTipoIdent.Pardet_Descripcion, _ident.Identificacion.Identi_Numero, _ident.EntidadRepetido.NombreCompleto), MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
      Entidad = _ident.EntidadRepetido
      RaiseEvent Repetido(sender, e)
    End If
  End Sub
End Class
