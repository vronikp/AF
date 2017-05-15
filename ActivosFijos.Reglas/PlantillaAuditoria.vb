Imports Infoware.Datos

Public Class PlantillaAuditoria
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
    OperadorDatos.AgregarParametro("@UbicacionActual", UbicacionActual)
    OperadorDatos.AgregarParametro("@CustodioActual", CustodioActual)
    OperadorDatos.AgregarParametro("@EstadoInventarioDet", EstadoInventarioDet)
    If Not String.IsNullOrWhiteSpace(Usuari_CodigoPDA) Then
      OperadorDatos.AgregarParametro("@Usuari_CodigoPDA", Usuari_CodigoPDA)
    End If
    OperadorDatos.AgregarParametro("@CodigoBarras", CodigoBarras)
    OperadorDatos.AgregarParametro("@EstadoActivo", EstadoActivo)
    If Not FechaRegistro = Nothing Then
      OperadorDatos.AgregarParametro("@FechaRegistro", FechaRegistro)
    End If

    OperadorDatos.Procedimiento = "proc_PlantillaAuditoria"
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
    UbicacionActual = CStr(Fila("UbicacionActual"))
    CustodioActual = CStr(Fila("CustodioActual"))
    EstadoInventarioDet = CStr(Fila("EstadoInventarioDet"))
    If TypeOf Fila("Usuari_CodigoPDA") Is DBNull Then
      Usuari_CodigoPDA = ""
    Else
      Usuari_CodigoPDA = CStr(Fila("Usuari_CodigoPDA"))
    End If
    CodigoBarras = CStr(Fila("CodigoBarras"))
    EstadoActivo = CStr(Fila("EstadoActivo"))
    If TypeOf Fila("FechaRegistro") Is DBNull Then
      FechaRegistro = Nothing
    Else
      FechaRegistro = CDate(Fila("FechaRegistro"))
    End If
  End Sub
End Class

#Region "PlantillaAuditoriaList"
Public Class PlantillaAuditoriaList
  Inherits System.ComponentModel.BindingList(Of PlantillaAuditoria)

  Public Shared Function ObtenerLista(_Inventario As Inventario) As PlantillaAuditoriaList
    Dim oResult As New PlantillaAuditoriaList
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
        Dim _fila As New PlantillaAuditoria(_Inventario.OperadorDatos)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerXml(_Inventario As Inventario) As Xml.XmlDocument
    Dim oResult As New Xml.XmlDocument
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    Dim datos As String = ""
    With _Inventario.OperadorDatos
      .AgregarParametro("@Accion", "xml")
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
        datos = CStr(_dr("Inventario"))
        'Dim _fila As New PlantillaAuditoria(_Inventario.OperadorDatos)
        '_fila.MapearDataRowaObjeto(_dr)
        'oResult.Add(_fila)
      Next
    End If
    oResult.LoadXml(datos)
    Return oResult
  End Function
End Class
#End Region
