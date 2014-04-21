Imports Infoware.Datos

Public Class PlantillaInventario
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

  Private mUbicacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Ubicacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Ubicacion As String
    Get
      Return mUbicacion
    End Get
    Set(value As String)
      mUbicacion = value
    End Set
  End Property

  Private mPeriodoInventario As String = ""
  <Infoware.Reportes.CampoReporteAtributo("PeriodoInventario", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property PeriodoInventario As String
    Get
      Return mPeriodoInventario
    End Get
    Set(value As String)
      mPeriodoInventario = value
    End Set
  End Property

  Private mInvent_Descripcion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Invent_Descripcion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Invent_Descripcion As String
    Get
      Return mInvent_Descripcion
    End Get
    Set(value As String)
      mInvent_Descripcion = value
    End Set
  End Property

  Private mInvent_Fecha As String = Nothing
  <Infoware.Reportes.CampoReporteAtributo("Invent_Fecha", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property Invent_Fecha As Date
    Get
      Return mInvent_Fecha
    End Get
    Set(value As Date)
      mInvent_Fecha = value
    End Set
  End Property

  Private mEstadoInventario As String = ""
  <Infoware.Reportes.CampoReporteAtributo("EstadoInventario", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property EstadoInventario As String
    Get
      Return mEstadoInventario
    End Get
    Set(value As String)
      mEstadoInventario = value
    End Set
  End Property

  Private mInvDet_Observacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("InvDet_Observacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property InvDet_Observacion As String
    Get
      Return mInvDet_Observacion
    End Get
    Set(value As String)
      mInvDet_Observacion = value
    End Set
  End Property

  Private mUbicacionActual As String = ""
  <Infoware.Reportes.CampoReporteAtributo("UbicacionActual", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property UbicacionActual As String
    Get
      Return mUbicacionActual
    End Get
    Set(value As String)
      mUbicacionActual = value
    End Set
  End Property

  Private mCustodioActual As String = ""
  <Infoware.Reportes.CampoReporteAtributo("CustodioActual", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property CustodioActual As String
    Get
      Return mCustodioActual
    End Get
    Set(value As String)
      mCustodioActual = value
    End Set
  End Property

  Private mEstadoInventarioDet As String = ""
  <Infoware.Reportes.CampoReporteAtributo("EstadoInventarioDet", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property EstadoInventarioDet As String
    Get
      Return mEstadoInventarioDet
    End Get
    Set(value As String)
      mEstadoInventarioDet = value
    End Set
  End Property

  Private mUsuari_CodigoPDA As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Usuari_CodigoPDA", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Usuari_CodigoPDA As String
    Get
      Return mUsuari_CodigoPDA
    End Get
    Set(value As String)
      mUsuari_CodigoPDA = value
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

  Private mFechaRegistro As DateTime = Nothing
  <Infoware.Reportes.CampoReporteAtributo("FechaRegistro", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaRegistro As DateTime
    Get
      Return mFechaRegistro
    End Get
    Set(value As DateTime)
      mFechaRegistro = value
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

    OperadorDatos.AgregarParametro("@Ubicacion", Ubicacion)
    OperadorDatos.AgregarParametro("@PeriodoInventario", PeriodoInventario)
    OperadorDatos.AgregarParametro("@Invent_Descripcion", Invent_Descripcion)
    OperadorDatos.AgregarParametro("@Invent_Fecha", Invent_Fecha)
    OperadorDatos.AgregarParametro("@EstadoInventario", EstadoInventario)
    OperadorDatos.AgregarParametro("@InvDet_Observacion", InvDet_Observacion)
    OperadorDatos.AgregarParametro("@UbicacionActual", UbicacionActual)
    OperadorDatos.AgregarParametro("@CustodioActual", CustodioActual)
    OperadorDatos.AgregarParametro("@EstadoInventarioDet", EstadoInventarioDet)
    If Not String.IsNullOrWhiteSpace(Usuari_CodigoPDA) Then
      OperadorDatos.AgregarParametro("@Usuari_CodigoPDA", Usuari_CodigoPDA)
    End If
    OperadorDatos.AgregarParametro("@CodigoBarras", CodigoBarras)
    OperadorDatos.AgregarParametro("@CodigoAux", CodigoAux)
    OperadorDatos.AgregarParametro("@Serie", Serie)
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
    OperadorDatos.AgregarParametro("@CentroCostos", CentroCostos)
    OperadorDatos.AgregarParametro("@Proveedor", Proveedor)
    OperadorDatos.AgregarParametro("@Factura", Factura)
    OperadorDatos.AgregarParametro("@TipoBajaActivo", TipoBajaActivo)
    OperadorDatos.AgregarParametro("@Caracteristicas", Caracteristicas)
    If Not FechaRegistro = Nothing Then
      OperadorDatos.AgregarParametro("@FechaRegistro", FechaRegistro)
    End If

    OperadorDatos.Procedimiento = "proc_PlantillaInventario"
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

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Ubicacion = CStr(Fila("Ubicacion"))
    PeriodoInventario = CStr(Fila("PeriodoInventario"))
    Invent_Descripcion = CStr(Fila("Invent_Descripcion"))
    Invent_Fecha = CDate(Fila("Invent_Fecha"))
    EstadoInventario = CStr(Fila("EstadoInventario"))
    InvDet_Observacion = CStr(Fila("InvDet_Observacion"))
    UbicacionActual = CStr(Fila("UbicacionActual"))
    CustodioActual = CStr(Fila("CustodioActual"))
    EstadoInventarioDet = CStr(Fila("EstadoInventarioDet"))
    If TypeOf Fila("Usuari_CodigoPDA") Is dbnull Then
      Usuari_CodigoPDA = ""
    Else
      Usuari_CodigoPDA = CStr(Fila("Usuari_CodigoPDA"))
    End If
    CodigoBarras = CStr(Fila("CodigoBarras"))
    CodigoAux = CStr(Fila("Activo_CodigoAux"))
    Serie = CStr(Fila("Activo_Serie"))
    Clase = CStr(Fila("ClaseActivo"))
    Descripcion = CStr(Fila("Activo_Descripcion"))
    Marca = CStr(Fila("Marca"))
    Modelo = CStr(Fila("Activo_Modelo"))
    Observacion = CStr(Fila("Activo_Observacion"))
    EstadoDepreciacion = CStr(Fila("EstadoDepreciacion"))
    EstadoActivo = CStr(Fila("EstadoActivo"))
    ResponsableMantenimiento = CStr(Fila("Activo_ResponsableMantenimiento"))
    FechaIngreso = CDate(Fila("Activo_FechaIngreso"))
    FechaCompra = CDate(Fila("Activo_FechaCompra"))
    If TypeOf Fila("Activo_FechaUso") Is dbnull Then
      FechaUso = Nothing
    Else
      FechaUso = CDate(Fila("Activo_FechaUso"))
    End If
    CentroCostos = CStr(Fila("CentroCosto"))
    If TypeOf Fila("Proveedor") Is dbnull Then
      Proveedor = ""
    Else
      Proveedor = CStr(Fila("Proveedor"))
    End If
    Factura = CStr(Fila("Factura"))
    If TypeOf Fila("Activo_FechaBaja") Is dbnull Then
      fechabaja = Nothing
    Else
      FechaBaja = CDate(Fila("Activo_FechaBaja"))
    End If
    TipoBajaActivo = CStr(Fila("TipoBajaActivo"))
    Caracteristicas = CStr(Fila("Caracteristicas"))
    If TypeOf Fila("FechaRegistro") Is DBNull Then
      FechaRegistro = Nothing
    Else
      FechaRegistro = CDate(Fila("FechaRegistro"))
    End If
  End Sub
End Class

#Region "PlantillaInventarioList"
Public Class PlantillaInventarioList
  Inherits System.ComponentModel.BindingList(Of PlantillaInventario)

  Public Shared Function ObtenerLista(_Inventario As Inventario) As PlantillaInventarioList
    Dim oResult As New PlantillaInventarioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Inventario.OperadorDatos
      .AgregarParametro("@Accion", "xp")
      .AgregarParametro("@Parame_Ubicacion", _Inventario.Parame_Ubicacion)
      .AgregarParametro("@Pardet_Ubicacion", _Inventario.Pardet_Ubicacion)
      .AgregarParametro("@Parame_PeriodoInventario", _Inventario.Parame_PeriodoInventario)
      .AgregarParametro("@Pardet_PeriodoInventario", _Inventario.Pardet_PeriodoInventario)
      .Procedimiento = "proc_Inventario"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New PlantillaInventario(_Inventario.OperadorDatos)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
