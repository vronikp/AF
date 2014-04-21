Imports Infoware.Datos

Public Class PlantillaActivo
  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(value As OperadorDatos)
      mOperadorDatos = value
    End Set
  End Property

  Private mErrores As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Errores", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public Property Errores As String
    Get
      If String.IsNullOrWhiteSpace(mErrores) Then
        Validar()
      End If
      Return mErrores
    End Get
    Set(value As String)
      mErrores = value
    End Set
  End Property

  Private mCodigoBarras As String = ""
  <Infoware.Reportes.CampoReporteAtributo("CodigoBarras", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property CodigoBarras As String
    Get
      Return mCodigoBarras
    End Get
    Set(value As String)
      mCodigoBarras = value
    End Set
  End Property

  Private mCodigoAux As String = ""
  <Infoware.Reportes.CampoReporteAtributo("CodigoAux", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property CodigoAux As String
    Get
      Return mCodigoAux
    End Get
    Set(value As String)
      mCodigoAux = value
    End Set
  End Property

  Private mSerie As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Serie", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Serie As String
    Get
      Return mSerie
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mSerie = String.Empty
      Else
        mSerie = value
      End If
    End Set
  End Property

  'Private mGrupo As String = ""
  '<Infoware.Reportes.CampoReporteAtributo("Grupo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  'Public Property Grupo As String
  '  Get
  '    Return mGrupo
  '  End Get
  '  Set(value As String)
  '    mGrupo = value
  '  End Set
  'End Property

  'Private mTipo As String = ""
  '<Infoware.Reportes.CampoReporteAtributo("Tipo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  'Public Property Tipo As String
  '  Get
  '    Return mTipo
  '  End Get
  '  Set(value As String)
  '    mTipo = value
  '  End Set
  'End Property

  Private mClase As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Clase", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public Property Clase As String
    Get
      Return mClase
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mClase = String.Empty
      Else
        mClase = value
      End If
    End Set
  End Property

  Private mDescripcion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Descripcion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Descripcion As String
    Get
      Return mDescripcion
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mDescripcion = String.Empty
      Else
        mDescripcion = value
      End If
    End Set
  End Property

  Private mMarca As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Marca", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Marca As String
    Get
      Return mMarca
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mMarca = String.Empty
      Else
        mMarca = value
      End If
    End Set
  End Property

  Private mModelo As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Modelo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Modelo As String
    Get
      Return mModelo
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mModelo = String.Empty
      Else
        mModelo = value
      End If
    End Set
  End Property

  Private mObservacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Observacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Observacion As String
    Get
      Return mObservacion
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mObservacion = String.Empty
      Else
        mObservacion = value
      End If
    End Set
  End Property

  Private mEstadoDepreciacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("EstadoDepreciacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property EstadoDepreciacion As String
    Get
      Return mEstadoDepreciacion
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mEstadoDepreciacion = String.Empty
      Else
        mEstadoDepreciacion = value
      End If
    End Set
  End Property

  Private mEstadoActivo As String = ""
  <Infoware.Reportes.CampoReporteAtributo("EstadoActivo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property EstadoActivo As String
    Get
      Return mEstadoActivo
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mEstadoActivo = String.Empty
      Else
        mEstadoActivo = value
      End If
    End Set
  End Property

  Private mResponsableMantenimiento As String = ""
  <Infoware.Reportes.CampoReporteAtributo("ResponsableMantenimiento", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property ResponsableMantenimiento As String
    Get
      Return mResponsableMantenimiento
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mResponsableMantenimiento = String.Empty
      Else
        mResponsableMantenimiento = value
      End If
    End Set
  End Property

  Private mFechaIngreso As Date = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaIngreso", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaIngreso As Date
    Get
      Return mFechaIngreso
    End Get
    Set(value As Date)
      mFechaIngreso = value
    End Set
  End Property

  Private mFechaCompra As Date = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaCompra", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaCompra As Date
    Get
      Return mFechaCompra
    End Get
    Set(value As Date)
      mFechaCompra = value
    End Set
  End Property

  Private mFechaUso As Date = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaUso", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaUso As Date
    Get
      Return mFechaUso
    End Get
    Set(value As Date)
      mFechaUso = value
    End Set
  End Property

  Private mFechaBaja As Date = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaBaja", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaBaja As Date
    Get
      Return mFechaBaja
    End Get
    Set(value As Date)
      mFechaBaja = value
    End Set
  End Property

  Private mUbicacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Ubicacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 180, True)> _
  Public Property Ubicacion As String
    Get
      Return mUbicacion
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mUbicacion = String.Empty
      Else
        mUbicacion = value
      End If
    End Set
  End Property

  Private mCentroCostos As String = ""
  <Infoware.Reportes.CampoReporteAtributo("CentroCostos", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property CentroCostos As String
    Get
      Return mCentroCostos
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mCentroCostos = String.Empty
      Else
        mCentroCostos = value
      End If
    End Set
  End Property

  Private mCustodio As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Custodio", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Custodio As String
    Get
      Return mCustodio
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mCustodio = String.Empty
      Else
        mCustodio = value
      End If
    End Set
  End Property

  Private mCosto As Decimal = 0
  <Infoware.Reportes.CampoReporteAtributo("Costo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 80, True)> _
  Public Property Costo As Decimal
    Get
      Return mCosto
    End Get
    Set(value As Decimal)
      mCosto = value
    End Set
  End Property

  Private mSalvamento As Decimal = 0
  <Infoware.Reportes.CampoReporteAtributo("Salvamento", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 80, True)> _
  Public Property Salvamento As Decimal
    Get
      Return mSalvamento
    End Get
    Set(value As Decimal)
      mSalvamento = value
    End Set
  End Property

  Private mPeriodosDepreciablesMeses As Integer = 0
  <Infoware.Reportes.CampoReporteAtributo("PeriodosDepreciablesMeses", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Numero, 80, True)> _
  Public Property PeriodosDepreciablesMeses As Integer
    Get
      Return mPeriodosDepreciablesMeses
    End Get
    Set(value As Integer)
      mPeriodosDepreciablesMeses = value
    End Set
  End Property

  Private mFrecuenciaDepreciacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("FrecuenciaDepreciacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property FrecuenciaDepreciacion As String
    Get
      Return mFrecuenciaDepreciacion
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mFrecuenciaDepreciacion = String.Empty
      Else
        mFrecuenciaDepreciacion = value
      End If
    End Set
  End Property

  Private mProveedor As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Proveedor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Proveedor As String
    Get
      Return mProveedor
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mProveedor = String.Empty
      Else
        mProveedor = value
      End If
    End Set
  End Property

  Private mFactura As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Factura", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Factura As String
    Get
      Return mFactura
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mFactura = String.Empty
      Else
        mFactura = value
      End If
    End Set
  End Property

  Private mTipoBajaActivo As String = ""
  <Infoware.Reportes.CampoReporteAtributo("TipoBajaActivo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property TipoBajaActivo As String
    Get
      Return mTipoBajaActivo
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mTipoBajaActivo = String.Empty
      Else
        mTipoBajaActivo = value
      End If
    End Set
  End Property

  Private mCaracteristicas As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Caracteristicas", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 300, True)> _
  Public Property Caracteristicas As String
    Get
      Return mCaracteristicas
    End Get
    Set(value As String)
      If String.IsNullOrWhiteSpace(value) Then
        mCaracteristicas = String.Empty
      Else
        mCaracteristicas = value
      End If
    End Set
  End Property

  Private mFechaCambioUbcacionCustodio As Date = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaCambioUbcacionCustodio", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 150, True)> _
  Public Property FechaCambioUbcacionCustodio As Date
    Get
      Return mFechaCambioUbcacionCustodio
    End Get
    Set(value As Date)
      mFechaCambioUbcacionCustodio = value
    End Set
  End Property

  Private mForzar As Boolean = False
  <Infoware.Reportes.CampoReporteAtributo("Forzar", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 50, True)> _
  Public Property Forzar As Boolean
    Get
      Return mForzar
    End Get
    Set(value As Boolean)
      mForzar = value
    End Set
  End Property

  Public Function Validar() As Boolean
    mErrores = ""
    If String.IsNullOrWhiteSpace(CodigoBarras) Then
      mErrores = mErrores + " El código de barras no puede estar en blanco."
    End If
    'If String.IsNullOrWhiteSpace(Serie) Then
    '  mErrores = mErrores + " La serie no puede estar en blanco."
    'End If
    If String.IsNullOrWhiteSpace(mErrores) Then
      mErrores = "ok"

    End If
    Return mErrores = "ok"
  End Function

  Public Sub New(_OperadorDatos As OperadorDatos)
    OperadorDatos = _OperadorDatos
  End Sub

  Public Overridable Function Guardar() As Boolean
    Dim Result As String = ""
    Dim bReturn As Boolean = True

    If Not Validar() Then
      Return False
    End If


    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    OperadorDatos.AgregarParametro("@CodigoBarras", CodigoBarras)
    OperadorDatos.AgregarParametro("@CodigoAux", CodigoAux)
    OperadorDatos.AgregarParametro("@Serie", Serie)
    'OperadorDatos.AgregarParametro("@Grupo", Grupo)
    'OperadorDatos.AgregarParametro("@Tipo", Tipo)
    OperadorDatos.AgregarParametro("@Clase", Clase)
    OperadorDatos.AgregarParametro("@Descripcion", Descripcion)
    OperadorDatos.AgregarParametro("@Marca", Marca)
    OperadorDatos.AgregarParametro("@Modelo", Modelo)
    OperadorDatos.AgregarParametro("@Observacion", Observacion)
    OperadorDatos.AgregarParametro("@EstadoDepreciacion", EstadoDepreciacion)
    OperadorDatos.AgregarParametro("@EstadoActivo", EstadoActivo)
    OperadorDatos.AgregarParametro("@ResponsableMantenimiento", ResponsableMantenimiento)
    OperadorDatos.AgregarParametro("@FechaIngreso", FechaIngreso)
    OperadorDatos.AgregarParametro("@FechaCompra", FechaCompra)
    OperadorDatos.AgregarParametro("@FechaUso", FechaUso)
    If Not FechaBaja = Nothing Then
      OperadorDatos.AgregarParametro("@FechaBaja", FechaBaja)
    End If
    OperadorDatos.AgregarParametro("@Ubicacion", Ubicacion)
    OperadorDatos.AgregarParametro("@CentroCostos", CentroCostos)
    OperadorDatos.AgregarParametro("@Custodio", Custodio)
    OperadorDatos.AgregarParametro("@Costo", Costo)
    OperadorDatos.AgregarParametro("@Salvamento", Salvamento)
    OperadorDatos.AgregarParametro("@PeriodosDepreciablesMeses", PeriodosDepreciablesMeses)
    OperadorDatos.AgregarParametro("@FrecuenciaDepreciacion", FrecuenciaDepreciacion)
    OperadorDatos.AgregarParametro("@Proveedor", Proveedor)
    OperadorDatos.AgregarParametro("@Factura", Factura)
    OperadorDatos.AgregarParametro("@TipoBajaActivo", TipoBajaActivo)
    OperadorDatos.AgregarParametro("@Caracteristicas", Caracteristicas)
    OperadorDatos.AgregarParametro("@Fecha_Cambio_UbicacionCustodio", FechaCambioUbcacionCustodio)
    OperadorDatos.AgregarParametro("@Forzar", Forzar)

    OperadorDatos.Procedimiento = "proc_PlantillaActivo"
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If Not String.IsNullOrWhiteSpace(Result) AndAlso Result.StartsWith("ERROR: ") Then
        bReturn = False
      End If
    End If
    If _comenzotransaccion Then
      If bReturn Then
        mErrores = "ok"
        OperadorDatos.TerminarTransaccion()
      Else
        mErrores = OperadorDatos.MsgError
        OperadorDatos.CancelarTransaccion()
        If Not String.IsNullOrWhiteSpace(Result) Then
          mErrores = Result
        End If
      End If
    End If
    Return bReturn
  End Function
End Class

#Region "PlantillaActivoList"
Public Class PlantillaActivoList
  Inherits System.ComponentModel.BindingList(Of PlantillaActivo)
End Class
#End Region
