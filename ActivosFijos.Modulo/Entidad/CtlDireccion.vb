Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas


Public Class CtlDireccion
  Private mEntidad As Entidad = Nothing
  Public Property Entidad() As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      If value IsNot Nothing Then
        EstaLlenando = True
        Me.ComboBoxCiudad.OperadorDatos = value.OperadorDatos
        Me.ComboBoxTipoDireccion.OperadorDatos = value.OperadorDatos

        ComboBoxTipoDireccion.Parametro = Enumerados.EnumParametros.TipoDireccion
        ComboBoxCiudad.Parametro = Enumerados.EnumParametros.Ciudad

        ComboBoxTipoDireccion.Llenar_Datos(IIf(mEntidad.Entidadnatural IsNot Nothing, WWTSParametroDetList.enumTipoObjeto.Natural, WWTSParametroDetList.enumTipoObjeto.Juridica))
        ComboBoxCiudad.Llenar_Datos()
        EstaLlenando = False
        Llenar_datos()
      End If
    End Set
  End Property

  Private mTipoDireccion As Enumerados.enumTipoDireccion = Enumerados.enumTipoDireccion.Trabajo
  Public Property TipoDireccion() As Enumerados.enumTipoDireccion
    Get
      Return mTipoDireccion
    End Get
    Set(ByVal value As Enumerados.enumTipoDireccion)
      mTipoDireccion = value
      ComboBoxTipoDireccion.SelectedValue = CInt(mTipoDireccion)
      Llenar_datos()
    End Set
  End Property

  Private mDireccion As EntidadDireccion = Nothing
  Private EstaLlenando As Boolean = False

  Public Sub Llenar_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If
    EstaLlenando = True
    mDireccion = Nothing
    For Each _direccion As EntidadDireccion In mEntidad.Direcciones
      If _direccion.Pardet_Tipodireccion = CInt(mTipoDireccion) Then
        mDireccion = _direccion
      End If
    Next
    If mDireccion Is Nothing Then
      mDireccion = New EntidadDireccion(mEntidad.OperadorDatos, True)
      mDireccion.Entidad = mEntidad
      mDireccion.Pardet_Tipodireccion = CInt(mTipoDireccion)
      mEntidad.Direcciones.Add(mDireccion)
    End If

    Me.ComboBoxTipoDireccion.ParametroDet = mDireccion.PardetTipoDirec
    Me.Direcc_CalleprincipalTextBox.Text = mDireccion.Direcc_Calleprincipal
    Me.Direcc_CalleinterseccionTextBox.Text = mDireccion.Direcc_Calleinterseccion
    Me.Direcc_NumeroTextBox.Text = mDireccion.Direcc_Numero
    Me.ComboBoxCiudad.ParametroDet = mDireccion.PardetCiudad
    EstaLlenando = False
  End Sub

  Private Sub Direcc_CalleprincipalTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Direcc_CalleprincipalTextBox.TextChanged, Direcc_NumeroTextBox.TextChanged, Direcc_CalleinterseccionTextBox.TextChanged, ComboBoxCiudad.SelectedIndexChanged
    If Not EstaLlenando Then
      mDireccion.Direcc_Calleprincipal = Me.Direcc_CalleprincipalTextBox.Text
      mDireccion.Direcc_Calleinterseccion = Me.Direcc_CalleinterseccionTextBox.Text
      mDireccion.Direcc_Numero = Me.Direcc_NumeroTextBox.Text
      If Me.ComboBoxCiudad.ParametroDet IsNot Nothing Then
        mDireccion.PardetCiudad = Me.ComboBoxCiudad.ParametroDet
      End If
    End If
  End Sub

  Private Sub ComboBoxTipoDireccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoDireccion.SelectedIndexChanged
    If Not EstaLlenando And ComboBoxTipoDireccion.SelectedValue IsNot Nothing Then
      TipoDireccion = ComboBoxTipoDireccion.SelectedValue
    End If
  End Sub
End Class
