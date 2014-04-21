Imports ActivosFijos.Reglas

Public Class CtlPersona
  Public Property PuedeRegistrarPersonacomo() As Boolean
    Get
      Return Me.pnlRegistrar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.pnlRegistrar.Visible = value
    End Set
  End Property

  Public Property PuedeElegirTipoEntidad() As Boolean
    Get
      Return Me.pnltipopersona.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.pnltipopersona.Visible = value
    End Set
  End Property

  Private mPuedeSRI As Boolean = False
  Public Property PuedeSRI() As Boolean
    Get
      Return mPuedeSRI
    End Get
    Set(ByVal value As Boolean)
      mPuedeSRI = value
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
        llenar_datos()
      End If
    End Set
  End Property

  Private CtlEntidadNatural1 As CtlEntidadNatural
  Private CtlEntidadJuridica1 As CtlEntidadJuridica
  Private EstaLlenando As Boolean = False

  Sub llenar_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If
    EstaLlenando = True
    Me.SuspendLayout()
    'Me.pnlcuerpo.SuspendLayout()
    Me.pnlcuerpo.Visible = False
    Me.pnlcuerpo.Controls.Clear()
    If mEntidad.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural Then
      Me.rdopersonanatural.Checked = True
      CtlEntidadNatural1 = New CtlEntidadNatural()
      Me.CtlEntidadNatural1.Dock = DockStyle.Fill
      Me.pnlcuerpo.Controls.Add(CtlEntidadNatural1)
      Me.CtlEntidadNatural1.Entidad = mEntidad
      Me.CtlEntidadNatural1.PuedeSRI = mPuedeSRI
      AddHandler CtlEntidadNatural1.Repetido, AddressOf Repetidox
    Else
      Me.rdopersonajuridica.Checked = True
      CtlEntidadJuridica1 = New CtlEntidadJuridica()
      Me.CtlEntidadJuridica1.Dock = DockStyle.Fill
      Me.pnlcuerpo.Controls.Add(CtlEntidadJuridica1)
      Me.CtlEntidadJuridica1.Entidad = mEntidad
      Me.CtlEntidadJuridica1.PuedeSRI = mPuedeSRI
      AddHandler CtlEntidadJuridica1.Repetido, AddressOf Repetidox
    End If

    Me.PictureBoxSQL1.Imagen = mEntidad.Entida_Imagen

    Me.pnlRegistrar.Enabled = Not mEntidad.EsNuevo
    ' ''Me.btnregcliente.Visible = Not mEntidad.EsCliente
    Me.btnregproveedor.Visible = Not mEntidad.EsProveedor

    'Me.pnlcuerpo.ResumeLayout(False)
    Me.pnlcuerpo.Visible = True
    Me.ResumeLayout(False)
    EstaLlenando = False
  End Sub

  Public Event Repetido As EventHandler

  Public Sub Repetidox(ByVal sender As System.Object, ByVal e As System.EventArgs)
    mEntidad = CType(sender, CtlIdentificacion).Identificacion.Entidad
    Me.PictureBoxSQL1.Imagen = mEntidad.Entida_Imagen
    RaiseEvent Repetido(sender, e)
  End Sub

  Public Sub Mapear_datos()
    If mEntidad.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural Then
      Me.CtlEntidadNatural1.Mapear_datos()
      mEntidad.Entidadjuridica = Nothing
      mEntidad = Me.CtlEntidadNatural1.Entidad
    Else
      Me.CtlEntidadJuridica1.Mapear_datos()
      mEntidad.Entidadnatural = Nothing
      mEntidad = Me.CtlEntidadJuridica1.Entidad
    End If
  End Sub

  Private Sub rdopersonanatural_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdopersonanatural.CheckedChanged, rdopersonajuridica.CheckedChanged
    If mEntidad Is Nothing Then
      Exit Sub
    End If
    If Not EstaLlenando Then
      If Me.rdopersonanatural.Checked Then
        mEntidad.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural
      Else
        mEntidad.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Juridica
      End If
      llenar_datos()
    End If
  End Sub

  ' ''Private Sub btnregcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregcliente.Click
  ' ''  Dim mCliente As New Cliente(mEntidad.OperadorDatos, True)
  ' ''  mCliente.Entidad = mEntidad
  ' ''  If mCliente.Guardar Then
  ' ''    Me.btnregcliente.Visible = False
  ' ''  Else
  ' ''    MsgBox(mCliente.Entidad.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
  ' ''  End If
  ' ''End Sub

  Private Sub btnregproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregproveedor.Click
    Dim mproveedor As New Proveedor(mEntidad.OperadorDatos, True)
    mproveedor.Entidad = mEntidad
    If mproveedor.Guardar Then
      Me.btnregproveedor.Visible = False
    Else
      MsgBox(mproveedor.Entidad.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

#Region "Imagen"
  Private Sub CambioImagen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxSQL1.CambioImagen
    If mEntidad Is Nothing Then
      Exit Sub
    End If
    mEntidad.ArchivoImagen = Me.PictureBoxSQL1.ArchivoImagen
  End Sub
#End Region

End Class
