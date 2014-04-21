Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General

Public Class WWTSUsuario
  Inherits Infoware.Reglas.General.Usuario

  Private Const _Procedimiento As String = "proc_Usuario"

  Private mEntida_Empleado As Integer = 0

  Private mEmpleado As Empleado = Nothing

  Private mParame_Ubicacion As Integer = 0

  Private mPardet_Ubicacion As Integer = 0

  Private mPardetUbicacion As WWTSParametroDet = Nothing

  Private mUsuari_RequerirAprobacionCambioCustodio As Boolean = False

  Private mUsuari_Activo As Boolean = True

  Public Overridable Property Entida_Empleado() As Integer
    Get
      Return mEntida_Empleado
    End Get
    Set(ByVal value As Integer)
      mEntida_Empleado = value
    End Set
  End Property

  'Empleado
  Public Overridable Property Empleado() As Empleado
    Get
      If Me.mEmpleado Is Nothing AndAlso Not Entida_Empleado = 0 Then
        Try
          Me.mEmpleado = New Empleado(OperadorDatos, Entida_Empleado)
        Catch ex As Exception
          Me.mEmpleado = Nothing
        End Try
      End If
      Return Me.mEmpleado
    End Get
    Set(ByVal value As Empleado)
      Me.mEmpleado = value
      If value Is Nothing Then
        Entida_Empleado = 0
      Else
        Entida_Empleado = value.Entida_Codigo
      End If
    End Set
  End Property


  <XmlAttribute()> _
  Public Overridable Property Parame_Ubicacion() As Integer
    Get
      Return Me.mParame_Ubicacion
    End Get
    Set(value As Integer)
      Me.mParame_Ubicacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Ubicacion() As Integer
    Get
      Return Me.mPardet_Ubicacion
    End Get
    Set(value As Integer)
      Me.mPardet_Ubicacion = value
      EsModificado = True
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetUbicacion() As WWTSParametroDet
    Get
      If mPardetUbicacion Is Nothing AndAlso Pardet_Ubicacion > 0 Then
        mPardetUbicacion = New WWTSParametroDet(OperadorDatos, Parame_Ubicacion, Pardet_Ubicacion)
      End If
      Return Me.mPardetUbicacion
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetUbicacion = value
      If value Is Nothing Then
        Parame_Ubicacion = 0
        Pardet_Ubicacion = 0
      Else
        Parame_Ubicacion = value.Parame_Codigo
        Pardet_Ubicacion = value.Pardet_Secuencia
      End If
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Usuari_RequerirAprobacionCambioCustodio() As Boolean
    Get
      Return Me.mUsuari_RequerirAprobacionCambioCustodio
    End Get
    Set(value As Boolean)
      Me.mUsuari_RequerirAprobacionCambioCustodio = value
      EsModificado = True
    End Set
  End Property


  <Infoware.Reportes.CampoReporteAtributo("Usuario", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
    Public ReadOnly Property Codigo() As String
    Get
      Return Usuari_Codigo
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Descripción", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
    Public Overloads ReadOnly Property Descripcion() As String
    Get
      Return Usuari_Descripcion
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 50, True)> _
    Public Property Usuari_Activo() As Boolean
    Get
      Return mUsuari_Activo
    End Get
    Set(ByVal value As Boolean)
      mUsuari_Activo = value
    End Set
  End Property

#Region "Constructores de la clase"
  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Usuari_Codigo As String)
    Me.New(_OperadorDatos, False)
    Usuari_Codigo = _Usuari_Codigo
    If Not Me.Recargar Then
      Throw New Exception("No existe el usuario. Intente nuevamente")
    End If
  End Sub
#End Region

#Region "Implementación de los métodos de persistencia"
  Public Overrides Function Recargar() As Boolean
    Dim dsResult As New DataTable
    Dim bResult As Boolean

    With Me.OperadorDatos
      .AgregarParametro("@accion", "C")
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .Procedimiento = _Procedimiento
      bResult = .Ejecutar(dsResult)
      .LimpiarParametros()
    End With
    If bResult AndAlso Not dsResult Is Nothing AndAlso dsResult.Rows.Count > 0 Then
      Me.MapearDataRowaObjeto(dsResult.Rows(0))
      Return True
    Else
      Return False
    End If
  End Function
#End Region

#Region "Métodos internos de la clase"
  Public Overrides Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Usuari_Codigo = CStr(Fila("Usuari_Codigo"))
    Usuari_Descripcion = CStr(Fila("Usuari_Descripcion"))
    Usuari_Password = String.Empty
    Usuari_Mensaje = CStr(Fila("Usuari_Mensaje"))
    Usuari_RegEntSal = CBool(Fila("Usuari_RegEntSal"))
    Usuari_RegIngModEli = CBool(Fila("Usuari_RegIngModEli"))
    Usuari_RegImp = CBool(Fila("Usuari_RegImp"))
    Usuari_RegConfidencial = CBool(Fila("Usuari_RegConfidencial"))
    Try
      Dim obj As Object
      obj = Fila("Entida_Empleado")
      If TypeOf obj Is DBNull Then
        Entida_Empleado = 0
      Else
        Entida_Empleado = CType(obj, Integer)
      End If
    Catch ex As Exception
      Entida_Empleado = 0
    End Try
    Usuari_CambiarContrasena = CBool(Fila("Usuari_CambiarContrasena"))
    Usuari_Activo = CBool(Fila("Usuari_Activo"))
    mEmpleado = Nothing

    Try
      If TypeOf Fila("Parame_Ubicacion") Is DBNull Then
        Parame_Ubicacion = 0
      Else
        Parame_Ubicacion = CInt(Fila("Parame_Ubicacion"))
      End If
      If TypeOf Fila("Pardet_Ubicacion") Is DBNull Then
        Pardet_Ubicacion = 0
      Else
        Pardet_Ubicacion = CInt(Fila("Pardet_Ubicacion"))
      End If
    Catch ex As Exception
      Parame_Ubicacion = 0
      Pardet_Ubicacion = 0
    End Try

    Try
      If TypeOf Fila("Usuari_RequerirAprobacionCambioCustodio") Is DBNull Then
        Usuari_RequerirAprobacionCambioCustodio = False
      Else
        Usuari_RequerirAprobacionCambioCustodio = CBool(Fila("Usuari_RequerirAprobacionCambioCustodio"))
      End If
    Catch ex As Exception
      Usuari_RequerirAprobacionCambioCustodio = False
    End Try
  End Sub

  Public Overrides Function Guardar() As Boolean
    Dim dsResult As New DataTable
    Dim bReturn As Boolean
    Dim sAccion As String = String.Empty
    If EsNuevo Then
      sAccion = "I"
    Else
      sAccion = "M"
    End If

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    With OperadorDatos
      .AgregarParametro("@accion", sAccion)
      .AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
      .AgregarParametro("@Usuari_Descripcion", Usuari_Descripcion)
      .AgregarParametro("@Usuari_Password", Usuari_Password)
      .AgregarParametro("@Usuari_Mensaje", Usuari_Mensaje)
      .AgregarParametro("@Usuari_RegEntSal", Usuari_RegEntSal)
      .AgregarParametro("@Usuari_RegIngModEli", Usuari_RegIngModEli)
      .AgregarParametro("@Usuari_RegImp", Usuari_RegImp)
      .AgregarParametro("@Usuari_RegConfidencial", Usuari_RegConfidencial)
      If Not Entida_Empleado = 0 Then
        OperadorDatos.AgregarParametro("@Entida_Empleado", Entida_Empleado)
      End If
      If Not Pardet_Ubicacion = 0 Then
        OperadorDatos.AgregarParametro("@Parame_Ubicacion", Parame_Ubicacion)
        OperadorDatos.AgregarParametro("@Pardet_Ubicacion", Pardet_Ubicacion)
      End If
      OperadorDatos.AgregarParametro("@Usuari_RequerirAprobacionCambioCustodio", Usuari_RequerirAprobacionCambioCustodio)
      .AgregarParametro("@Usuari_CambiarContrasena", Usuari_CambiarContrasena)
      .AgregarParametro("@Usuari_Activo", Usuari_Activo)

      .Procedimiento = _Procedimiento
      bReturn = .Ejecutar(dsResult)
      .LimpiarParametros()
      If bReturn Then

        For Each _restriccion As Restriccion In Restricciones
          _restriccion.Usuario = Me
          If Not _restriccion.Guardar() Then
            bReturn = False
            Exit For
          End If
        Next

        If Not OperadorDatos.EstaenTransaccion Then
          EsNuevo = False
          EsModificado = False
        End If
      End If
    End With

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function
#End Region
End Class

Public Class WWTSUsuarioList
  Inherits System.ComponentModel.BindingList(Of WWTSUsuario)
  Public Sub New()
  End Sub

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As WWTSUsuarioList
    Dim oResult As New WWTSUsuarioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Usuario"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New WWTSUsuario(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
