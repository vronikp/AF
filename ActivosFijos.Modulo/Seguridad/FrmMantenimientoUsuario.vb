Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoUsuario

#Region "Parametros"
  Public Property Usuarios() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mUsuario As WWTSUsuario = Nothing
  Public Property Usuario() As WWTSUsuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As WWTSUsuario)
      mUsuario = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Usuarios As New WWTSUsuarioList
        _Usuarios.Add(mUsuario)
        MyBase.BindingSource1.DataSource = GetType(WWTSUsuario)
        MyBase.BindingSource1.DataSource = _Usuarios
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mUsuario = Usuarios.Current
    Me.chkcopiarrestricciones.Checked = False
    Me.txtcodigo.Text = mUsuario.Usuari_Codigo
    Me.txtdescripcion.Text = mUsuario.Usuari_Descripcion
    Me.txtmensaje.Text = mUsuario.Usuari_Mensaje
    Me.txtcontrasena.Text = mUsuario.Usuari_Password
    Me.chkactivo.Checked = mUsuario.Usuari_Activo

    Me.chkregentsal.Checked = mUsuario.Usuari_RegEntSal
    Me.chkmoddat.Checked = mUsuario.Usuari_RegIngModEli
    Me.chkregimp.Checked = mUsuario.Usuari_RegImp
    Me.chkmaniconf.Checked = mUsuario.Usuari_RegConfidencial

    Me.CtlRestricciones1.Usuario = mUsuario

    Me.txtcodigo.Enabled = mUsuario.EsNuevo
    Me.chkcambiocontrasena.Checked = mUsuario.EsNuevo
    Me.chkcambiocontrasena.Visible = Not mUsuario.EsNuevo

    Me.chkempleado.Checked = mUsuario.Empleado IsNot Nothing
    Me.CtlBuscaEmpleado1.Empleado = mUsuario.Empleado

    Me.chkubicacion.Checked = mUsuario.PardetUbicacion IsNot Nothing
    Me.CtlUbicacionActivo1.ParametroDet = mUsuario.PardetUbicacion

    Me.chkcambiocustodio.Checked = mUsuario.Usuari_RequerirAprobacionCambioCustodio

    Me.chkcambcontrpr.Checked = mUsuario.Usuari_CambiarContrasena
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mUsuario.EsNuevo
    If _esnuevo AndAlso Usuarios.Current IsNot Nothing Then
      Usuarios.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Usuarios eventos"
  Private Sub FrmMantenimientoUsuario_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Usuario As WWTSUsuario = New WWTSUsuario(Sistema.OperadorDatos, True)
    e.NewObject = _Usuario
  End Sub

  Private Sub FrmMantenimientoUsuario_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoUsuario_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    Me.CtlRestricciones1.EndEdit()

    mUsuario.Usuari_Codigo = Me.txtcodigo.Text
    mUsuario.Usuari_Descripcion = Me.txtdescripcion.Text
    mUsuario.Usuari_Mensaje = Me.txtmensaje.Text
    mUsuario.Usuari_Password = Me.txtcontrasena.Text
    mUsuario.Usuari_Activo = Me.chkactivo.Checked

    mUsuario.Usuari_RegEntSal = Me.chkregentsal.Checked
    mUsuario.Usuari_RegIngModEli = Me.chkmoddat.Checked
    mUsuario.Usuari_RegImp = Me.chkregimp.Checked
    mUsuario.Usuari_RegConfidencial = Me.chkmaniconf.Checked

    If Me.chkempleado.Checked Then
      mUsuario.Empleado = Me.CtlBuscaEmpleado1.Empleado
    Else
      mUsuario.Empleado = Nothing
    End If
    If Me.chkubicacion.Checked Then
      mUsuario.PardetUbicacion = Me.CtlUbicacionActivo1.ParametroDet
    Else
      mUsuario.PardetUbicacion = Nothing
    End If
    mUsuario.Usuari_RequerirAprobacionCambioCustodio = Me.chkcambiocustodio.Checked
    mUsuario.Usuari_CambiarContrasena = Me.chkcambcontrpr.Checked
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mUsuario.EsNuevo
    If mUsuario.Usuari_Codigo = Restriccion.Usuari_Codigo Then
      If Not mUsuario.Restricciones.Buscar(Enumerados.EnumOpciones.Usuarios).Restri_Modificacion Then
        MsgBox("No se puede quitar el privilegio de modificación de usuarios a si mismo, debe hacerlo otro usuario", MsgBoxStyle.Critical, "Error")
        Return False
      End If
    End If

    If mUsuario.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mUsuario.Usuari_Descripcion)

      If Not _esnuevo AndAlso Me.chkcambiocontrasena.Checked Then
        mUsuario.CambiarContrasena()
      End If
      If mUsuario.Usuari_Codigo = Restriccion.Usuari_Codigo Then
        MsgBox("Los cambios efectuados serán efectivos en el próximo reinicio del sistema", MsgBoxStyle.Information, "Información")
      End If
      Return True
    Else
      'Usuarios.CancelEdit()
      MsgBox("No se puede guardar Usuario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoUsuario_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mUsuario.Usuari_Codigo = Me.Restriccion.Usuari_Codigo Then
      MsgBox("No se puede eliminar el usuario actual", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If mUsuario.Eliminar() AndAlso Usuarios.Current IsNot Nothing Then
      Usuarios.RemoveCurrent()
      Me.Close()
    Else
      'Usuarios.CancelEdit()
      MsgBox("No se puede eliminar Usuario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoUsuario_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUsuario_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

  Private Sub chkcambiocontrasena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcambiocontrasena.CheckedChanged, chkcambcontrpr.CheckedChanged, chkactivo.CheckedChanged, chkcambiocustodio.CheckedChanged
    Me.txtcontrasena.Enabled = Me.chkcambiocontrasena.Checked
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Usuario"

    Me.CtlBuscaEmpleado1.SoloActivos = True
    Me.CtlBuscaEmpleado1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaEmpleado1.Llenar_Datos()

    Me.CtlUbicacionActivo1.llenar_Datos()

    Me.ComboBoxUsuario1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxUsuario1.Llenar_datos()
  End Sub

#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub


  Private Sub ComboBoxUsuario1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxUsuario1.SelectedIndexChanged
    If Me.chkcopiarrestricciones.Checked AndAlso Me.ComboBoxUsuario1.Usuario.Usuari_Codigo <> mUsuario.Usuari_Codigo Then
      For Each _restriccionf As Restriccion In Me.ComboBoxUsuario1.Usuario.Restricciones
        For Each _restricciono As Restriccion In mUsuario.Restricciones
          If _restriccionf.Pardet_Opciones = _restricciono.Pardet_Opciones Then
            _restricciono.Restri_Ingreso = _restriccionf.Restri_Ingreso
            _restricciono.Restri_Lectura = _restriccionf.Restri_Lectura
            _restricciono.Restri_Modificacion = _restriccionf.Restri_Modificacion
            _restricciono.Restri_Eliminacion = _restriccionf.Restri_Eliminacion
            _restricciono.Restri_Impresion = _restriccionf.Restri_Impresion
            _restricciono.Restri_VerConfidencial = _restriccionf.Restri_VerConfidencial
          End If
        Next
      Next
      Me.CtlRestricciones1.Invalidate()
    End If
  End Sub

  Private Sub chkcopiarrestricciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcopiarrestricciones.CheckedChanged
    Me.ComboBoxUsuario1.Enabled = Me.chkcopiarrestricciones.Checked
  End Sub

  Private Sub FrmMantenimientoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub chkempleado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkempleado.CheckedChanged
    Me.CtlBuscaEmpleado1.Enabled = Me.chkempleado.Checked
  End Sub

  Private Sub chkubicacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkubicacion.CheckedChanged
    Me.CtlUbicacionActivo1.Enabled = Me.chkubicacion.Checked
  End Sub
End Class
