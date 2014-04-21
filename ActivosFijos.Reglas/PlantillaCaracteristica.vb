Imports Infoware.Datos

Public Class PlantillaCaracteristica
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

  Private mCaracteristica As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Caracteristica", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Caracteristica As String
    Get
      Return mCaracteristica
    End Get
    Set(value As String)
      mCaracteristica = value
    End Set
  End Property

  Private mValor As String = ""
  <Infoware.Reportes.CampoReporteAtributo("Valor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
  Public Property Valor As String
    Get
      Return mValor
    End Get
    Set(value As String)
      mValor = value
    End Set
  End Property

  Public Function Validar() As Boolean
    mErrores = ""
    If String.IsNullOrWhiteSpace(CodigoBarras) Then
      mErrores = mErrores + " El código de barras no puede estar en blanco."
    End If
    If String.IsNullOrWhiteSpace(Caracteristica) Then
      mErrores = mErrores + " Caracteristica no puede estar en blanco."
    End If
    If String.IsNullOrWhiteSpace(Valor) Then
      mErrores = mErrores + " Valor no puede estar en blanco."
    End If
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
    OperadorDatos.AgregarParametro("@Caracteristica", Caracteristica)
    OperadorDatos.AgregarParametro("@Valor", Valor)
    OperadorDatos.Procedimiento = "proc_PlantillaCaracteristica"
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

#Region "PlantillaCaracteristicaList"
Public Class PlantillaCaracteristicaList
  Inherits System.ComponentModel.BindingList(Of PlantillaCaracteristica)
End Class
#End Region
