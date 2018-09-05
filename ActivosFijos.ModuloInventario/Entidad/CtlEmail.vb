Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas


Public Class CtlEmail
  Private mEntidad As Entidad = Nothing
  Public Property Entidad() As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      If value IsNot Nothing Then
        ComboBoxTipoEmail.OperadorDatos = value.OperadorDatos
        ComboBoxTipoEmail.Parametro = Enumerados.EnumParametros.TipoEmail
        ComboBoxTipoEmail.Llenar_Datos(IIf(mEntidad.Entidadnatural IsNot Nothing, WWTSParametroDetList.enumTipoObjeto.Natural, WWTSParametroDetList.enumTipoObjeto.Juridica))
      End If
    End Set
  End Property

  Private mTipoEmail As Enumerados.enumTipoEmail = Enumerados.enumTipoEmail.Trabajo
  Public Property TipoEmail() As Enumerados.enumTipoEmail
    Get
      Return mTipoEmail
    End Get
    Set(ByVal value As Enumerados.enumTipoEmail)
      mTipoEmail = value
      ComboBoxTipoEmail.SelectedValue = CInt(mTipoEmail)
      Llenar_datos()
    End Set
  End Property

  Private mEmail As EntidadDatos = Nothing

  Public Sub Llenar_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If

    mEmail = Nothing
    For Each _email As EntidadDatos In mEntidad.OtrosDatos
      If _email.Parame_Tipodatos = CInt(Enumerados.EnumParametros.TipoEmail) And _email.Pardet_Tipodatos = CInt(mTipoEmail) Then
        mEmail = _email
      End If
    Next

    If mEmail Is Nothing Then
      mEmail = New EntidadDatos(mEntidad.OperadorDatos, True)
      mEmail.Entidad = mEntidad
      mEmail.Parame_Tipodatos = CInt(Enumerados.EnumParametros.TipoEmail)
      mEmail.Pardet_Tipodatos = CInt(mTipoEmail)
      mEntidad.OtrosDatos.Add(mEmail)
    End If

    Me.Entdat_DescripcionTextBox.Text = mEmail.Entdat_Descripcion
  End Sub

  Private Sub Entdat_DescripcionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entdat_DescripcionTextBox.TextChanged
    mEmail.Entdat_Descripcion = Me.Entdat_DescripcionTextBox.Text
  End Sub

  Private Sub ComboBoxTipoEmail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoEmail.SelectedIndexChanged
    TipoEmail = ComboBoxTipoEmail.ParametroDet.Pardet_Secuencia
  End Sub
End Class
