Imports Infoware.Datos

Public Class PlantillaCambioCustodio
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

    Private mCustodio As String = ""
    <Infoware.Reportes.CampoReporteAtributo("CustodioActual", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
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

    Private mCustodioNuevo As String = ""
    <Infoware.Reportes.CampoReporteAtributo("CustodioNuevo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 80, True)> _
    Public Property CustodioNuevo As String
        Get
            Return mCustodioNuevo
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                mCustodioNuevo = String.Empty
            Else
                mCustodioNuevo = value
            End If
        End Set
    End Property

    Private mFechaCambio As Date = Now.Date
    <Infoware.Reportes.CampoReporteAtributo("FechaCambio", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 80, True)> _
    Public Property FechaCambio As Date
        Get
            Return mFechaCambio
        End Get
        Set(value As Date)
            mFechaCambio = value
        End Set
    End Property

    Private mUsuario As String = ""
    Public Property Usuario As String
        Get
            Return mUsuario
        End Get
        Set(value As String)
            mUsuario = value
        End Set
    End Property

    Public Function Validar() As Boolean
        mErrores = ""
        'If String.IsNullOrWhiteSpace(CodigoBarras) Then
        '    mErrores = mErrores + " El código de barras no puede estar en blanco."
        'End If
        'If String.IsNullOrWhiteSpace(Custodio) Then
        '    mErrores = mErrores + " El custodio actual no puede estar en blanco."
        'End If
        'If String.IsNullOrWhiteSpace(CustodioNuevo) Then
        '    mErrores = mErrores + " El custodio nuevo no puede estar en blanco."
        'End If
        'If Custodio = CustodioNuevo Then
        '    mErrores = mErrores + " El custodio actual y el custodio nuevo no pueden ser el mismo."
        'End If
        'If String.IsNullOrWhiteSpace(FechaCambio) Then
        '    mErrores = mErrores + " La fecha no puede estar en blanco."
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
        OperadorDatos.AgregarParametro("@Custodio", Custodio)
        OperadorDatos.AgregarParametro("@CustodioNuevo", CustodioNuevo)
        OperadorDatos.AgregarParametro("@FechaCambio", FechaCambio)
        OperadorDatos.AgregarParametro("@Usuario", Usuario)

        OperadorDatos.Procedimiento = "proc_PlantillaCambioCustodio"
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

#Region "PlantillaCambioCustodioList"
Public Class PlantillaCambioCustodioList
    Inherits System.ComponentModel.BindingList(Of PlantillaCambioCustodio)
End Class
#End Region
