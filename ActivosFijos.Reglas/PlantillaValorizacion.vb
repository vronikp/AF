Imports Infoware.Datos

Public Class PlantillaValoracion
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
      mFrecuenciaDepreciacion = value
    End Set
  End Property

  Private mTipoDepreciacion As String = ""
  <Infoware.Reportes.CampoReporteAtributo("TipoDepreciacion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property TipoDepreciacion As String
    Get
      Return mTipoDepreciacion
    End Get
    Set(value As String)
      mTipoDepreciacion = value
    End Set
  End Property

  Private mFechaValoracion As Date = Now.Date
  <Infoware.Reportes.CampoReporteAtributo("FechaValoracion", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
  Public Property FechaValoracion As Date
    Get
      Return mFechaValoracion
    End Get
    Set(value As Date)
      mFechaValoracion = value
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
    OperadorDatos.AgregarParametro("@Costo", Costo)
    OperadorDatos.AgregarParametro("@Salvamento", Salvamento)
    OperadorDatos.AgregarParametro("@PeriodosDepreciablesMeses", PeriodosDepreciablesMeses)
    OperadorDatos.AgregarParametro("@FrecuenciaDepreciacion", FrecuenciaDepreciacion)
    OperadorDatos.AgregarParametro("@TipoDepreciacion", TipoDepreciacion)
    OperadorDatos.AgregarParametro("@FechaValoracion", FechaValoracion)

    OperadorDatos.Procedimiento = "proc_PlantillaValoracion"
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

#Region "PlantillaValoracionList"
Public Class PlantillaValoracionList
  Inherits System.ComponentModel.BindingList(Of PlantillaValoracion)
End Class
#End Region
