Imports ActivosFijos.Reglas


Public Class CtlEntidadLugar
  Private mEmpresa As Empresa = Nothing
  Public WriteOnly Property Empresa() As Empresa
    Set(ByVal value As Empresa)
      mEmpresa = value
    End Set
  End Property

  Public Property PuedeSRI() As Boolean
    Get
      Return Me.grpsri.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.grpsri.Visible = value
    End Set
  End Property

  Private mTipoLugar As Enumerados.EnumTipoLugar = Enumerados.EnumTipoLugar.Sucursal
  Public Property TipoLugar() As Enumerados.EnumTipoLugar
    Get
      Return mTipoLugar
    End Get
    Set(ByVal value As Enumerados.EnumTipoLugar)
      mTipoLugar = value
      Me.grp_identificacion.Visible = value = Enumerados.EnumTipoLugar.Sucursal
    End Set
  End Property

  Private mEntidadLugar As EntidadLugar = Nothing
  Public Property EntidadLugar() As EntidadLugar
    Get
      Return mEntidadLugar
    End Get
    Set(ByVal value As EntidadLugar)
      mEntidadLugar = value
      If value IsNot Nothing Then
        llenar_datos()
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mEntidadLugar Is Nothing OrElse mEntidadLugar Is Nothing Then
      Me.pnlcuerpo.Visible = False
      Exit Sub
    End If

    Me.Entlug_Descripcion.Text = mEntidadLugar.EntLug_Nombre

    Me.CtlDireccion1.Entidad = mEntidadLugar.Entidad
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Trabajo

    Me.CtlTelefono1.Entidad = mEntidadLugar.Entidad
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    Me.CtlTelefono2.Entidad = mEntidadLugar.Entidad
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Fax

    Me.CtlEmail1.Entidad = mEntidadLugar.Entidad
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    Me.CtlEmail2.Entidad = mEntidadLugar.Entidad
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo1

    Me.CtlIdentificacion1.Entidad = mEntidadLugar.Entidad
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.PrefijoFacturas

    Me.txtautofactura.Text = mEntidadLugar.Entidad.Entida_AutorizacionFactura
    Me.mskcaducfactura.Text = mEntidadLugar.Entidad.Entida_CaducidadFactura
    Me.txtautonotvta.Text = mEntidadLugar.Entidad.Entida_AutorizacionNotaVenta
    Me.mskcaducnotvta.Text = mEntidadLugar.Entidad.Entida_CaducidadNotaVenta
    Me.txtautoret.Text = mEntidadLugar.Entidad.Entida_AutorizacionRetencion
    Me.mskcaducret.Text = mEntidadLugar.Entidad.Entida_CaducidadRetencion
  End Sub

  Public Sub Mapear_datos()
    If mEntidadLugar Is Nothing Then
      Exit Sub
    End If

    mEntidadLugar.EntLug_Nombre = Me.Entlug_Descripcion.Text
    mEntidadLugar.Entidad.Entida_AutorizacionFactura = Me.txtautofactura.Text
    mEntidadLugar.Entidad.Entida_CaducidadFactura = Me.mskcaducfactura.Text
    mEntidadLugar.Entidad.Entida_AutorizacionNotaVenta = Me.txtautonotvta.Text
    mEntidadLugar.Entidad.Entida_CaducidadNotaVenta = Me.mskcaducnotvta.Text
    mEntidadLugar.Entidad.Entida_AutorizacionRetencion = Me.txtautoret.Text
    mEntidadLugar.Entidad.Entida_CaducidadRetencion = Me.mskcaducret.Text
  End Sub
End Class
