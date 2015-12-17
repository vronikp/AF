Imports Infoware.Datos

Public Class Licencia

    Private mCodigo As String = ""
    Private mTipoVersion As Integer = 0
    Private mNoVersion As String = ""
    Private mEsAlquilada As Boolean = True
    Private mFechaAdquisicion As Date = Nothing
    Private mFechaActivacion As DateTime = Nothing
    Private mFechaUltimaVerificacion As DateTime = Nothing
    Private mNombre As String = Nothing

    Public Property Codigo() As String
        Get
            If mCodigo Is Nothing Then
                Return String.Empty
            Else
                Return mCodigo
            End If
        End Get
        Set(value As String)
            mCodigo = value
        End Set
    End Property

    Public Property TipoVersion() As Integer
        Get
            Return mTipoVersion
        End Get
        Set(value As Integer)
            mTipoVersion = value
        End Set
    End Property

    Public Property NoVersion() As String
        Get
            If mNoVersion Is Nothing Then
                Return String.Empty
            Else
                Return mNoVersion
            End If
        End Get
        Set(value As String)
            mNoVersion = value
        End Set
    End Property

    Public Property EsAlquilada() As Boolean
        Get
            Return mEsAlquilada
        End Get
        Set(value As Boolean)
            mEsAlquilada = value
        End Set
    End Property

    Public Property FechaAdquisicion() As Date
        Get
                Return mFechaAdquisicion
        End Get
        Set(value As Date)
            mFechaAdquisicion = value
        End Set
    End Property

    Public Property FechaUltimaVerificacion() As DateTime
        Get
            Return mFechaUltimaVerificacion
        End Get
        Set(value As DateTime)
            mFechaUltimaVerificacion = value
        End Set
    End Property


    Public Property FechaActivacion() As DateTime
        Get
            Return mFechaActivacion
        End Get
        Set(value As DateTime)
            mFechaActivacion = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            If mNombre Is Nothing Then
                Return String.Empty
            Else
                Return mNombre
            End If
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public ReadOnly Property TipoVersionDescripcion As String
        Get
            If mTipoVersion = 1 Then
                Return "Básica"
            ElseIf mTipoVersion = 2 Then
                Return "Estándar"
            ElseIf mTipoVersion = 3 Then
                Return "Profesional"
            ElseIf mTipoVersion = 4 Then
                Return "Interprof XD =P >.<"
            Else
                Return String.Empty
            End If

            'Return String.Format("{0} {1}", PeriodoString, UbicacionString)
        End Get
    End Property


End Class
