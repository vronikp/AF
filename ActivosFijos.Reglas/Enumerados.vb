Public Class Enumerados
#Region "Opciones del sistema"
  Enum EnumModulos
    General = 100
    ActivosFijos = 200
    Seguridad = 900
    Configuracion = 9000
  End Enum

  Enum EnumOpciones
    Sistema = 1

    ListadoProveedores = 100
    ListadoEmpleados = 102
    ListadoPersonas = 104
    ListadoPeritos = 106
    Caracteristicas = 110
    Secuencias = 112
    ReportesGeneral = 199

    ListadoActivos = 200
    CargarActivosLote = 201
    ListadoFacturaActivos = 202
    ListadoPolizas = 204
    ListadoTransaccionActivos = 206
    ListadoPendientesCustodio = 208
    ReporteActaEntregaCustodio = 209
    Depreciacion = 210
    ReporteResumenDepreciacion = 211
    DarBajaActivo = 212
    InventarioActivo = 214
    ResumenDepreciacionPorTipo = 216

    ReportesActivosFijos = 299

    InventariarDesdePDA = 300

    Usuarios = 910
    Auditoria = 912

    Modulos = 9005
        Opciones = 9010
        Parametros = 9015
  End Enum
#End Region

#Region "Parametros"
  Enum EnumParametros
    Nulo = 0
    Modulos = 4
    Opciones = 5
    TipoAccion = 10

    TipoObjeto = 100
    TipoEntidad = 110
    TipoLugar = 115
    TipoIdentificacion = 120
    TipoDireccion = 125
    'pedro
    SectorDomicilio = 127
    TipoOtrosDatos = 130

    TipoTelefono = 131
    TipoEmail = 132

    Sexo = 140
    EstadoCivil = 141

    TipoContribuyente = 145

    TipoEmpleado = 150

    Pais = 200
    Provincia = 210
    Ciudad = 220
    Parroquia = 230

    Banco = 300
    TipoCtaBan = 310
    TarjetaCredito = 305
    TipoCtaCtble = 315
    SubCuenta = 316

    ClaseEmpleado = 705
    TipoDiscapacidad = 707
    Nacionalidad = 710
    TipoSangre = 715
    'pedro
    Bachiller = 717
    'pedro
    TituloSuperior = 718
    FormaPagoRol = 720
    MotivoPago = 722
    SeguroCorporativo = 724
    TipoCargafamiliar = 725
    PeriodoPago = 730
    'pedro
    TipoPeriodoPago = 731
    TipoContrato = 735
    TipoContratoFormato = 736
    'pedro
    EstadoContrato = 737
    EstadoDiaLabor = 740
    TipoLiquidacion = 745
    TipoSalida = 750
    'pedro
    Licencia = 751
    TipoPermiso = 752
    TipoLlamado = 753
    'pedro
    GravedadLLamdo = 754
    Beneficio = 755
    TipoBeneficio = 756
    TipoPrestamo = 757

    'pedro
    Departamento = 759
    Seccion = 760
    Escalafon = 762
    'pedro
    Area = 763
    'pedro
    Rubro = 764
    'pedro
    TipoRubro = 765
    'pedro
    ActividadSectorial = 770
    'pedro
    ResultadoSeleccion = 780
    'pedro
    SeleccionTest = 781
    TipoGastoPersonal = 790
    ModeloLabor = 800

    ConfiguracionAfiliado = 1000
    TipoAfiliacion = 1001
    FranjaHorarios = 1003
    Ocupacion = 1005
    TipoActividadPuntos = 1010
    Mesa = 1020
    Juego = 1025

    Adjuntos = 2000
    Adjuntosdetalle = 2005

    MarcaSlot = 5000
    ModeloSlot = 5005
    MonedaSlot = 5010
    EmpresaSlot = 5015
    AsociacionSlot = 5020
    SalaSlot = 5025
    EstadoSlot = 5030
    FormulaSlot = 5035
    TipoNovedad = 5060
    Novedad = 5061
    EstadoNovedad = 5065
    EstadoParteTecnico = 5066
    EstadoOrdenreparacion = 5067
    EstadoReparacionComponentes = 5068
    TipoComponente = 5070

    ConceptoCuadreBoveda = 6005
    TurnoSala = 6010

    FichasMesas = 6100
    ClaseSitio = 6104
    TipoSitio = 6105

    EmpresaActivo = 10001
    Secuencias = 10002
    GrupoActivo = 10009
    TipoActivo = 10019
    ClaseActivo = 10029
    MarcaActivo = 10030
    EstadoDepreciacion = 10035
    EstadoActivo = 10040
    TipoBajaActivo = 10050
    FrecuenciaDepreciacion = 10055
    CentroCostoActivo = 10069
    CaracteristicaActivo = 10070
    UbicacionActivo = 10079

    TipoDepreciacion = 10080
    TipoValoracion = 10085
    AprobacionNuevoCustodio = 10095
    PeriodoInventario = 10100
    EstadoInventario = 10105
        EstadoInventarioActivo = 10110
        TipoPoliza = 10120
  End Enum
#End Region
  
#Region "TipoEntidad"
  Enum EnumTipoEntidad
    Natural = 1
    Juridica = 2
    Lugar = 3
  End Enum
#End Region

#Region "AprobacionNuevoCustodio"
  Enum EnumAprobacionNuevoCustodio
    Pendiente = 1
    Aprobado = 2
    Reprobado = 3
  End Enum
#End Region

#Region "TipoLugar"
  Enum EnumTipoLugar
    Sucursal = 1
    Bodega = 2
  End Enum
#End Region

#Region "TipoOtrosDatos"
  Enum enumTipoOtrosDatos
    Email = 1
    Telefono = 2
    TelefonoDomicilio = 3
    Celular = 8
  End Enum
#End Region

#Region "TipoDireccion"
  Enum enumTipoDireccion
    Trabajo = 1
    Domicilio = 2
  End Enum
#End Region

#Region "TipoTelefono"
  Enum enumTipoTelefono
    Trabajo = 1
    Fax = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoEmail"
  Enum enumTipoEmail
    Trabajo = 1
    Trabajo1 = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoIdentificacion"
  Enum enumTipoIdentificacion
    RUC = 1
    Cedula = 2
    Pasaporte = 3
    CedulaMilitar = 4
    LicenciaConducir = 5
    CarnetSeguro = 10

    PrefijoFacturas = 6
  End Enum
#End Region

#Region "TipoAccion"
  Enum enumTipoAccion
    IngresoSistema = 1
    SalidaSistema = 2
    Adicion = 3
    Modificacion = 4
    Eliminacion = 5
    Impresion = 6
    Confidencial = 7
  End Enum
#End Region
  Public Shared Function RetornarDifFecha(ByVal fechamayor As Date, ByVal fechamenor As Date) As String
    Dim diasdiff As Integer
    diasdiff = DateDiff(DateInterval.Day, fechamenor, fechamayor)
    Select Case diasdiff
      Case 0
        Return "Hoy"
      Case 1
        Return "Ayer"
      Case -1
        Return "Mañana"
      Case Else
        Dim leyenda As String = IIf(diasdiff < 0, "Faltan ", "hace ")
        diasdiff = Math.Abs(diasdiff)

        While diasdiff > 0
          Select Case diasdiff
            Case Is > 365
              leyenda += Int(diasdiff / 365) & " años "
              diasdiff -= Int(diasdiff / 365) * 365
            Case Is > 270
              leyenda += Int(diasdiff / 30) & " meses "
              diasdiff -= Int(diasdiff / 30) * 30
            Case Is > 6
              leyenda += Int(diasdiff / 7) & " semanas "
              diasdiff -= Int(diasdiff / 7) * 7
            Case Else
              leyenda += diasdiff & " dias "
              diasdiff -= diasdiff
          End Select
        End While
        Return leyenda
    End Select
  End Function

#Region "Meses del año"
  Enum MesesDelAnio As Byte
    Enero = 1
    Febrero = 2
    Marzo = 3
    Abril = 4
    Mayo = 5
    Junio = 6
    Julio = 7
    Agosto = 8
    Septiembre = 9
    Octubre = 10
    Noviembre = 11
    Diciembre = 12
  End Enum
  Public Shared Function MesesdelAnioList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(MesesDelAnio.Enero, "Enero", "ENE"))
    oResult.Add(New Elemento(MesesDelAnio.Febrero, "Febrero", "FEB"))
    oResult.Add(New Elemento(MesesDelAnio.Marzo, "Marzo", "MAR"))
    oResult.Add(New Elemento(MesesDelAnio.Abril, "Abril", "ABR"))
    oResult.Add(New Elemento(MesesDelAnio.Mayo, "Mayo", "MAY"))
    oResult.Add(New Elemento(MesesDelAnio.Junio, "Junio", "JUN"))
    oResult.Add(New Elemento(MesesDelAnio.Julio, "Julio", "JUL"))
    oResult.Add(New Elemento(MesesDelAnio.Agosto, "Agosto", "AGO"))
    oResult.Add(New Elemento(MesesDelAnio.Septiembre, "Septiembre", "SEP"))
    oResult.Add(New Elemento(MesesDelAnio.Octubre, "Octubre", "OCT"))
    oResult.Add(New Elemento(MesesDelAnio.Noviembre, "Noviembre", "NOV"))
    oResult.Add(New Elemento(MesesDelAnio.Diciembre, "Diciembre", "DIC"))
    Return oResult
  End Function
#End Region

#Region "Tipo de beneficios"
  Enum enumTipoBeneficio As Byte
    DecimoTercero = 1
    DecimoCuarto = 2
    Vacaciones = 3
    Utilidades = 4
  End Enum
#End Region

#Region "Dia de la semana"
  Enum DiasSemana As Byte
    Lunes = System.DayOfWeek.Monday
    Martes = System.DayOfWeek.Tuesday
    Miercoles = System.DayOfWeek.Wednesday
    Jueves = System.DayOfWeek.Thursday
    Viernes = System.DayOfWeek.Friday
    Sabado = System.DayOfWeek.Saturday
    Domingo = System.DayOfWeek.Sunday
  End Enum
  Public Shared Function DiaSemanaList() As ElementoList
    Dim oResult As New ElementoList
    oResult.Add(New Elemento(DayOfWeek.Monday, "Lunes", "LU"))
    oResult.Add(New Elemento(DayOfWeek.Tuesday, "Martes", "MA"))
    oResult.Add(New Elemento(DayOfWeek.Wednesday, "Miércoles", "MI"))
    oResult.Add(New Elemento(DayOfWeek.Thursday, "Jueves", "JU"))
    oResult.Add(New Elemento(DayOfWeek.Friday, "Viernes", "VI"))
    oResult.Add(New Elemento(DayOfWeek.Saturday, "Sábado", "SA"))
    oResult.Add(New Elemento(DayOfWeek.Sunday, "Domingo", "DO"))
    Return oResult
  End Function
#End Region

#Region "Forma de pago"
  Enum enumFormaPagoRol As Byte
    Cheque = 1
    Efectivo = 2
    Deposito = 3
  End Enum
#End Region

#Region "Tipo Empleado"
  Enum enumTipoEmpleado As Byte
    Custodio = 1
  End Enum
#End Region

#Region "Frecuencia Depreciacion"
  Enum enumFrecuenciaDepreciacion As Byte
    Mensual = 1
    Diaria = 2
  End Enum
#End Region

#Region "Tipo de Depreciacion"
  Enum enumTipoDepreciacion As Byte
    Tributaria = 1
    Financiera = 2
  End Enum
#End Region

#Region "Tipo de Valoracion"
  Enum enumTipoValoracion As Byte
    Inicial = 1
    Valoracion = 2
    Erogacion = 3
  End Enum
#End Region

#Region "Estado Inventario"
  Enum enumEstadoInventario As Byte
    Noterminado = 1
    Terminado = 2
    Inconcluso = 3
  End Enum
#End Region

#Region "Estado InventarioActivo"
  Enum enumEstadoInventarioActivo As Byte
    NoInventariado = 1
    Inventariado = 2
    EncontradoExistente = 3
    EncontradoNuevo = 4
  End Enum
#End Region
End Class

Public Class Elemento
  Private mNumero As Integer
  Private mDescripcion As String
  Private mCaracter As String

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal Value As Integer)
      mNumero = Value
    End Set
  End Property
  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal Value As String)
      mDescripcion = Value
    End Set
  End Property
  Public Property Caracter() As String
    Get
      Return mCaracter
    End Get
    Set(ByVal Value As String)
      mCaracter = Value
    End Set
  End Property

  Public Sub New(ByVal _numero As Integer, ByVal _descripcion As String, ByVal _caracter As String)
    mNumero = _numero
    mDescripcion = _descripcion
    mCaracter = _caracter
  End Sub
End Class

Public Class ElementoList
  Inherits System.ComponentModel.BindingList(Of Elemento)
  Public Sub New()
  End Sub

  Public Function RetornarDescripcion(ByVal _numero As Integer) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Numero = _numero Then
        Return _elemento.Descripcion
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarDescripcion(ByVal _caracter As String) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Caracter.Trim = _caracter.Trim Then
        Return _elemento.Descripcion
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarNumero(ByVal _valor As String) As Integer
    Dim oResult As Integer = 0
    For Each _elemento As Elemento In Me.Items
      If _elemento.Caracter.Trim = _valor.Trim Then
        Return _elemento.Numero
      End If
    Next
    Return oResult
  End Function

  Public Function RetornarCaracter(ByVal _numero As Integer) As String
    Dim oResult As String = String.Empty
    For Each _elemento As Elemento In Me.Items
      If _elemento.Numero = _numero Then
        Return _elemento.Caracter
      End If
    Next
    Return oResult
  End Function

End Class
