Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoParametroDet
#Region "IOpcion"
  Private Sub FrmMantenimientoParametroDet_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Me.PuedeGuardar = Restriccion.Restri_Modificacion
        Me.PuedeGuardarcerrar = Restriccion.Restri_Modificacion
        Me.PuedeGuardarnuevo = Restriccion.Restri_Ingreso
    End Sub
#End Region

#Region "Parametros"
  Public Property ParametroDetLists() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mParametroDet As WWTSParametroDet = Nothing
  Public Property ParametroDet() As WWTSParametroDet
    Get
      Return mParametroDet
    End Get
    Set(ByVal value As WWTSParametroDet)
      mParametroDet = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _ParametroDets As New WWTSParametroDetList
        _ParametroDets.Add(mParametroDet)
        MyBase.BindingSource1.DataSource = GetType(Infoware.Reglas.General.ParametroDet)
        MyBase.BindingSource1.DataSource = _ParametroDets
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

        
    mParametroDet = ParametroDetLists.Current
    MyBase.Tabla = mParametroDet.Parametro.Parame_Descripcion

    Me.txtdescripcion.Text = mParametroDet.Pardet_Descripcion

    Me.pnldatostr1.Visible = mParametroDet.Parametro.TieneDatoStr1
    If mParametroDet.Parametro.TieneDatoStr1 Then
      Me.lbl_datostr1.Text = mParametroDet.Parametro.Parame_LeyendaDatoStr1
      Me.txt_datostr1.Text = mParametroDet.Pardet_DatoStr1
    End If

    Me.pnldatostr2.Visible = mParametroDet.Parametro.TieneDatoStr2
    If mParametroDet.Parametro.TieneDatoStr2 Then
      Me.lbl_datostr2.Text = mParametroDet.Parametro.Parame_LeyendaDatoStr2
      Me.txt_datostr2.Text = mParametroDet.Pardet_DatoStr2
    End If

    Me.pnldatostr3.Visible = mParametroDet.Parametro.TieneDatoStr3
    If mParametroDet.Parametro.TieneDatoStr3 Then
      Me.lbl_datostr3.Text = mParametroDet.Parametro.Parame_LeyendaDatoStr3
      Me.txt_datostr3.Text = mParametroDet.Pardet_DatoStr3
    End If

    Me.pnlctactble1.Visible = mParametroDet.Parametro.TieneDatoCtaCtble1
    If mParametroDet.Parametro.TieneDatoCtaCtble1 Then
      Me.lblctactble1.Text = mParametroDet.Parametro.Parame_CtaCtble1
      Me.txtctactble1.Text = mParametroDet.CtaCtb_CtaCtble1
    End If

    Me.pnlctactble2.Visible = mParametroDet.Parametro.TieneDatoCtaCtble2
    If mParametroDet.Parametro.TieneDatoCtaCtble2 Then
      Me.lblctactble2.Text = mParametroDet.Parametro.Parame_CtaCtble2
      Me.txtctactble2.Text = mParametroDet.CtaCtb_CtaCtble2
    End If

    Me.pnldatoleyenda.Visible = mParametroDet.Parametro.TieneDatoLeyenda
    If mParametroDet.Parametro.TieneDatoLeyenda Then
      Me.lbl_datoleyenda.Text = mParametroDet.Parametro.Parame_LeyendaLeyenda
      Me.txt_datoleyenda.Text = mParametroDet.Pardet_Leyenda
    End If

    Me.pnldatoint.Visible = mParametroDet.Parametro.TieneDatoInt1
    If mParametroDet.Parametro.TieneDatoInt1 Then
      Me.lbl_datoint1.Text = mParametroDet.Parametro.Parame_LeyendaDatoInt1
      Me.txtdatoint1.Text = mParametroDet.Pardet_DatoInt1
    End If

    Me.pnldatobit.Visible = mParametroDet.Parametro.TieneDatoBit1
    If mParametroDet.Parametro.TieneDatoBit1 Then
      Me.txtdatobit1.Text = mParametroDet.Parametro.Parame_LeyendaDatoBit1
      Me.txtdatobit1.Checked = mParametroDet.Pardet_DatoBit1
    End If

    Me.pnldatoimg.Visible = mParametroDet.Parametro.TieneDatoImg1
    If mParametroDet.Parametro.TieneDatoImg1 Then
      Me.lbl_datoimg1.Text = mParametroDet.Parametro.Parame_LeyendaDatoImg1
      Try
        Me.PictureBox1.Imagen = mParametroDet.Pardet_Imagen
      Catch ex As Exception

      End Try
    End If

    Me.pnlpadre.Visible = False
    If mParametroDet.Parametro.ParametroPadre IsNot Nothing Then
      Me.pnlpadre.Visible = True
      Me.ComboBoxParametroDet1.Parametro = mParametroDet.Parametro.Parame_Padre
      Me.lbl_parametro.Text = mParametroDet.Parametro.ParametroPadre.Parame_Descripcion
      Me.ComboBoxParametroDet1.OperadorDatos = mParametroDet.OperadorDatos
      Me.ComboBoxParametroDet1.Llenar_Datos()
      Me.ComboBoxParametroDet1.ParametroDet = mParametroDet.PardetPadre
    End If

  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoParametroDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mParametroDet.EsNuevo
    If _esnuevo AndAlso ParametroDetLists.Current IsNot Nothing Then
      ParametroDetLists.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Personas eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _parametrodet As WWTSParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, mParametroDet.Parame_Codigo, True)
    e.NewObject = _parametrodet
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoParametroDet_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar

        e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mParametroDet.Pardet_Descripcion = Me.txtdescripcion.Text
    If mParametroDet.Parametro.TieneDatoStr1 Then
      mParametroDet.Pardet_DatoStr1 = Me.txt_datostr1.Text
    End If
    If mParametroDet.Parametro.TieneDatoStr2 Then
      mParametroDet.Pardet_DatoStr2 = Me.txt_datostr2.Text
    End If
    If mParametroDet.Parametro.TieneDatoStr3 Then
      mParametroDet.Pardet_DatoStr3 = Me.txt_datostr3.Text
    End If
    If mParametroDet.Parametro.TieneDatoCtaCtble1 Then
      mParametroDet.CtaCtb_CtaCtble1 = Me.txtctactble1.Text
    End If
    If mParametroDet.Parametro.TieneDatoCtaCtble2 Then
      mParametroDet.CtaCtb_CtaCtble2 = Me.txtctactble2.Text
    End If
    If mParametroDet.Parametro.TieneDatoLeyenda Then
      mParametroDet.Pardet_Leyenda = Me.txt_datoleyenda.Text
    End If
    If mParametroDet.Parametro.TieneDatoInt1 Then
      mParametroDet.Pardet_DatoInt1 = Me.txtdatoint1.Text
    End If
    If mParametroDet.Parametro.TieneDatoBit1 Then
      mParametroDet.Pardet_DatoBit1 = Me.txtdatobit1.Checked
    End If
    If pnlpadre.Visible Then
      mParametroDet.PardetPadre = Me.ComboBoxParametroDet1.ParametroDet
    End If
    'If mParametroDet.Parametro.TieneDatoimg1 Then
    '  mParametroDet.Pardet_Datoimg1 = Me.txtdatoimg1.Text
    'End If
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mParametroDet.EsNuevo
    If mParametroDet.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mParametroDet.Pardet_Descripcion)
      Return True
    Else
      'ParametroDets.CancelEdit()
      MsgBox("No se puede guardar Parametro" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoParametroDet_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mParametroDet.Eliminar() AndAlso ParametroDetLists.Current IsNot Nothing Then
      ParametroDetLists.RemoveCurrent()
      Me.Close()
    Else
      'ParametroDets.CancelEdit()
      MsgBox("No se puede eliminar Persona" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoParametroDet_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoParametroDet_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoParametroDet_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoParametroDet_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Parametros)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Parametros)
        MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FrmMantenimientoParametroDet_Inicializar(Me, Nothing)
    End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_datoimg1.Click

  End Sub

  Private Sub PictureBox1_CambioImagen(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.CambioImagen
    If mParametroDet IsNot Nothing Then
      mParametroDet.ArchivoImagen = Me.PictureBox1.ArchivoImagen
    End If
  End Sub

  Private Sub PictureBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Load

  End Sub
End Class
