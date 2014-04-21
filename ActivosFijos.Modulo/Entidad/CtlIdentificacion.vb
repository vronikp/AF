Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas


Public Class CtlIdentificacion
  Private mTipoLugar As Enumerados.EnumTipoLugar = Enumerados.EnumTipoLugar.Sucursal
  Public Property TipoLugar() As Enumerados.EnumTipoLugar
    Get
      Return mTipoLugar
    End Get
    Set(ByVal value As Enumerados.EnumTipoLugar)
      mTipoLugar = value
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
        Me.ComboBoxTipoIdentificacion.OperadorDatos = value.OperadorDatos
        ComboBoxTipoIdentificacion.Parametro = Enumerados.EnumParametros.TipoIdentificacion
        If mEntidad.Entidadnatural IsNot Nothing Then
          ComboBoxTipoIdentificacion.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Natural)
        ElseIf mEntidad.Entidadjuridica IsNot Nothing Then
          ComboBoxTipoIdentificacion.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Juridica)
        ElseIf mTipoLugar = Enumerados.EnumTipoLugar.Sucursal Then
          ComboBoxTipoIdentificacion.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Sucursal)
        ElseIf mTipoLugar = Enumerados.EnumTipoLugar.Bodega Then
          ComboBoxTipoIdentificacion.Llenar_Datos(WWTSParametroDetList.enumTipoObjeto.Bodega)
        End If
      End If
    End Set
  End Property

  Private mTipoIdentificacion As Enumerados.enumTipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC

  Public Property TipoIdentificacion() As Enumerados.enumTipoIdentificacion
    Get
      Return mTipoIdentificacion
    End Get
    Set(ByVal value As Enumerados.enumTipoIdentificacion)
      mTipoIdentificacion = value
      ComboBoxTipoIdentificacion.SelectedValue = CInt(mTipoIdentificacion)
      Llenar_datos()
    End Set
  End Property

  Private mIdentificacion As EntidadIdentificacion = Nothing

  Public ReadOnly Property Identificacion() As EntidadIdentificacion
    Get
      Return mIdentificacion
    End Get
  End Property

  Public Sub Llenar_datos()
    If mEntidad Is Nothing Then
      Exit Sub
    End If

    mIdentificacion = Nothing
    For Each _Identificacion As EntidadIdentificacion In mEntidad.Identificaciones
      If _Identificacion.Parame_Tipoidentificacion = CInt(Enumerados.EnumParametros.TipoIdentificacion) And _Identificacion.Pardet_Tipoidentificacion = CInt(mTipoIdentificacion) Then
        mIdentificacion = _Identificacion
      End If
    Next

    If mIdentificacion Is Nothing Then
      mIdentificacion = New EntidadIdentificacion(mEntidad.OperadorDatos, True)
      mIdentificacion.Entidad = mEntidad
      mIdentificacion.Parame_Tipoidentificacion = CInt(Enumerados.EnumParametros.TipoIdentificacion)
      mIdentificacion.Pardet_Tipoidentificacion = CInt(mTipoIdentificacion)
      mEntidad.Identificaciones.Add(mIdentificacion)
    End If

    Me.Entdat_DescripcionTextBox.Text = mIdentificacion.Identi_Numero
  End Sub

  Private Sub Entdat_DescripcionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entdat_DescripcionTextBox.TextChanged
    mIdentificacion.Identi_Numero = Me.Entdat_DescripcionTextBox.Text
  End Sub

  Private Sub ComboBoxTipoIdentificacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoIdentificacion.SelectedIndexChanged
    TipoIdentificacion = ComboBoxTipoIdentificacion.ParametroDet.Pardet_Secuencia
  End Sub

  Public Event Repetido As EventHandler

  Private Sub Entdat_DescripcionTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Entdat_DescripcionTextBox.Validated
    If Not Me.Entdat_DescripcionTextBox.Text.Trim = String.Empty AndAlso (TipoIdentificacion = Enumerados.enumTipoIdentificacion.Cedula Or TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC) Then
      Dim _ident As String = Me.Entdat_DescripcionTextBox.Text.Trim
      If (TipoIdentificacion = Enumerados.enumTipoIdentificacion.Cedula And _ident.Length = 10) Or (TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC And _ident.Length = 13) Then
        Dim suma As Integer = 0
        Dim coeficientes As String
        Dim modulo As Integer
        Dim tiporuc As String

        Select Case CInt(_ident.Substring(2, 1))
          Case 9
            tiporuc = "RUC para sociedades Privadas y Extranjeros sin cédula"
            coeficientes = "432765432"
            modulo = 11
          Case 6
            tiporuc = "RUC para sociedades Públicas"
            coeficientes = "32765432"
            modulo = 11
          Case Else
            tiporuc = "RUC/Cédula para personas naturales"
            coeficientes = "212121212"
            modulo = 10
        End Select

        For t As Integer = 1 To coeficientes.Length
          Dim res As Integer = 0
          res = CInt(_ident.Substring(t - 1, 1)) * CInt(coeficientes.Substring(t - 1, 1))
          If res > 9 Then
            res = CInt(res.ToString.Substring(0, 1)) + CInt(res.ToString.Substring(1, 1))
          End If
          suma += res
        Next

        Dim verificador As Integer = 0
        Dim residuo As Integer = (suma - Math.Floor(suma / modulo) * modulo)
        If residuo = 0 Then
          verificador = 0
        Else
          verificador = 10 - residuo
        End If
        If Not CInt(_ident.Substring(coeficientes.Length, 1)) = verificador Then
          MsgBox(String.Format("El {0} es inválido", tiporuc), MsgBoxStyle.Critical, "Error")
        End If
      Else
        MsgBox("El número de identificación no tiene la longitud esperada", MsgBoxStyle.Critical, "Error")
      End If

      'buscar si existe
      Try
        If mEntidad.EsNuevo Then
          Dim _identi As EntidadIdentificacion
          _identi = New EntidadIdentificacion(mEntidad.OperadorDatos, Me.ComboBoxTipoIdentificacion.ParametroDet, Me.Entdat_DescripcionTextBox.Text.Trim)

          If Not _identi.EsNuevo Then
            mEntidadRepetido = _identi.Entidad
            RaiseEvent Repetido(Me, Nothing)
          End If
        End If
      Catch ex As Exception

      End Try
    End If
  End Sub

  Private mEntidadRepetido As Entidad = Nothing
  Public Property EntidadRepetido() As Entidad
    Get
      Return mEntidadRepetido
    End Get
    Set(ByVal value As Entidad)
      mEntidadRepetido = value
    End Set
  End Property
End Class
