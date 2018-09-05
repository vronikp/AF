Imports Infoware.Reglas.General

Imports ActivosFijos.Reglas

Public Class CtlTelefono
  Private mEntidad As Entidad = Nothing
  Public Property Entidad() As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      If value IsNot Nothing Then
        Me.ComboBoxTipoTelefono.OperadorDatos = value.OperadorDatos
        ComboBoxTipoTelefono.Parametro = Enumerados.EnumParametros.TipoTelefono
        ComboBoxTipoTelefono.Llenar_Datos(IIf(mEntidad.Entidadnatural IsNot Nothing, WWTSParametroDetList.enumTipoObjeto.Natural, WWTSParametroDetList.enumTipoObjeto.Juridica))
      End If
    End Set
  End Property

  Private mTipoTelefono As Enumerados.enumTipoTelefono = Enumerados.enumTipoTelefono.Trabajo
  Public Property TipoTelefono() As Enumerados.enumTipoTelefono
    Get
      Return mTipoTelefono
    End Get
    Set(ByVal value As Enumerados.enumTipoTelefono)
      mTipoTelefono = value
      ComboBoxTipoTelefono.SelectedValue = CInt(mTipoTelefono)
      Llenar_datos()
    End Set
  End Property

  Private mTelefono As EntidadDatos = Nothing

  Public Sub Llenar_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If

    mTelefono = Nothing
    For Each _telefono As EntidadDatos In mEntidad.OtrosDatos
      If _telefono.Parame_Tipodatos = CInt(Enumerados.EnumParametros.TipoTelefono) And _telefono.Pardet_Tipodatos = CInt(mTipoTelefono) Then
        mTelefono = _telefono
      End If
    Next
    If mTelefono Is Nothing Then
      mTelefono = New EntidadDatos(mEntidad.OperadorDatos, True)
      mTelefono.Entidad = mEntidad
      mTelefono.Parame_Tipodatos = CInt(Enumerados.EnumParametros.TipoTelefono)
      mTelefono.Pardet_Tipodatos = CInt(mTipoTelefono)
      mEntidad.OtrosDatos.Add(mTelefono)
    End If

    Me.Entdat_DescripcionTextBox.Text = mTelefono.Entdat_Descripcion
  End Sub

  Private Sub Entdat_DescripcionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entdat_DescripcionTextBox.TextChanged
    mTelefono.Entdat_Descripcion = Me.Entdat_DescripcionTextBox.Text
  End Sub

  Private Sub ComboBoxTipoTelefono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoTelefono.SelectedIndexChanged
    If ComboBoxTipoTelefono.ParametroDet IsNot Nothing Then
      TipoTelefono = ComboBoxTipoTelefono.ParametroDet.Pardet_Secuencia
    End If
  End Sub
End Class
