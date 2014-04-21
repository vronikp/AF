Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas

Public Class FrmMantenimientoBajaActivo

  Private mActivos As ActivoList = Nothing
  Public Property Activos As ActivoList
    Get
      Return mActivos
    End Get
    Set(value As ActivoList)
      mActivos = value
      llenar_datos()
    End Set
  End Property

  Sub llenar_datos()
    Me.bsdets.DataSource = mActivos
    Me.dgdets.AutoDiscover()
  End Sub

  Private Sub FrmMantenimientoBajaActivo_Guardar(sender As Object, e As System.EventArgs) Handles Me.Guardar
    If mActivos Is Nothing Then
      Exit Sub
    End If

    For Each _activo As Activo In mActivos
      _activo.PardetTipoBajaActivo = Me.cbotipobaja.ParametroDet
      _activo.Activo_FechaBaja = Me.dtfecbaja.Value
      If _activo.Guardar() Then
        Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Eliminacion, String.Format("Baja activo {0} {1} {2} {3}", _activo.Activo_CodigoBarra, _activo.Descripcion, _activo.Activo_FechaBaja.ToShortDateString, _activo.TipoBajaActivoString))
      End If
    Next
    Me.Close()
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Baja Activos"

    Me.cbotipobaja.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipobaja.Parametro = Enumerados.EnumParametros.TipoBajaActivo
    Me.cbotipobaja.Llenar_Datos()


  End Sub
#End Region

End Class