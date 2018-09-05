Imports Infoware.Datos
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
Imports Infoware.Controles.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmParametroDetFile
  Implements IMantenimiento

  Private mDireccion As IMantenimiento.Accion
  Public Property Direccion() As IMantenimiento.Accion Implements IMantenimiento.Direccion
    Get
      Return mDireccion
    End Get
    Set(ByVal value As IMantenimiento.Accion)
      mDireccion = value
      Refrescar_forma()
    End Set
  End Property

  Private mParametroDet As WWTSParametroDet
  Public Property ParametroDet() As WWTSParametroDet
    Get
      Return mParametroDet
    End Get
    Set(ByVal value As WWTSParametroDet)
      mParametroDet = value
      Refrescar_forma()
    End Set
  End Property

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not mParametroDet Is Nothing Then
      Me.Text = mParametroDet.Parametro.Parame_Descripcion
      Me.txtdescripcion.Text = mParametroDet.Pardet_Descripcion
      Me.lnkarchivo.Text = mParametroDet.Pardet_DatoStr1
      If mParametroDet.Parametro.ParametroPadre Is Nothing Then
        Me.pnlpadre.Visible = False
      Else
        Me.pnlpadre.Visible = True
        Me.ComboBoxParametroDet1.Parametro = mParametroDet.Parametro.Parame_Padre
        Me.lbl_parametro.Text = mParametroDet.Parametro.ParametroPadre.Parame_Descripcion
        Me.ComboBoxParametroDet1.OperadorDatos = mParametroDet.OperadorDatos
        Me.ComboBoxParametroDet1.Llenar_Datos()
        Me.ComboBoxParametroDet1.ParametroDet = mParametroDet.PardetPadre
      End If
    End If
    Me.txtdescripcion.Enabled = True
    Me.ComboBoxParametroDet1.Enabled = True

    Select Case mDireccion
      Case IMantenimiento.Accion.Ingreso
        MyBase.TextoAceptar = "Ingresar"
      Case IMantenimiento.Accion.Eliminacion
        Me.txtdescripcion.Enabled = False
        Me.ComboBoxParametroDet1.Enabled = False
        MyBase.TextoAceptar = "Eliminar"
      Case IMantenimiento.Accion.Modificacion
        MyBase.TextoAceptar = "Modificar"
    End Select
  End Sub

  Private Sub FrmParametroDetFile_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Not mParametroDet Is Nothing Then
            mParametroDet.Pardet_Descripcion = Me.txtdescripcion.Text
            mParametroDet.Pardet_DatoStr1 = Me.lnkarchivo.Text
            mParametroDet.ArchivoImagen = Me.lnkarchivo.Tag
            If pnlpadre.Visible Then
              mParametroDet.PardetPadre = Me.ComboBoxParametroDet1.ParametroDet
            End If
          End If
          If Not mParametroDet.Guardar() Then
            Throw New Exception(mParametroDet.OperadorDatos.MsgError)
          End If
        Case IMantenimiento.Accion.Eliminacion
          If Not mParametroDet.Eliminar() Then
            Throw New Exception(mParametroDet.OperadorDatos.MsgError)
          End If
      End Select
    Catch ex As Exception
      MsgBox("No se pudo completar la operación" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnarchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarchivo.Click
    With OpenFileDialog1
      .Filter = "Todos los archivos (*.*)|*.*|Documentos de Word (*.doc;*.docx)|*.doc;*.docx|Documentos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
      .FilterIndex = 1
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Me.lnkarchivo.Text = My.Computer.FileSystem.GetFileInfo(.FileName).Name
        Me.lnkarchivo.Tag = .FileName
        'mParametroDet.ArchivoImagen = .FileName
        'mParametroDet.Pardet_DatoStr1 = My.Computer.FileSystem.GetFileInfo(.FileName).Name
      End If
    End With
  End Sub

  Private Sub lnkarchivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkarchivo.LinkClicked
    If Not String.IsNullOrEmpty(Me.lnkarchivo.Tag) OrElse Not String.IsNullOrEmpty(mParametroDet.Pardet_ImagenFile) Then
      Dim archivo As String
      If Not String.IsNullOrEmpty(Me.lnkarchivo.Tag) Then
        archivo = Me.lnkarchivo.Tag
      Else
        archivo = Me.ParametroDet.Pardet_ImagenFile
      End If

      Dim mProcess As New System.Diagnostics.Process
      mProcess.StartInfo.FileName = archivo
      mProcess.StartInfo.Arguments = ""
      mProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
      mProcess.EnableRaisingEvents = True
      mProcess.Start()
    End If
  End Sub
End Class
