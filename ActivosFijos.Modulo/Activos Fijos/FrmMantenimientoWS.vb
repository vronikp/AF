Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports PDFco.Security.Cryptography.RijndaelCryptography


Public Class FrmMantenimientoWS

#Region "Parametros"
  Private mParametroServicioWeb As WWTSParametroDet = Nothing
  Public crypto As PDFco.Security.Cryptography.RijndaelCryptography

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    If mParametroServicioWeb Is Nothing Then
      Exit Sub
    End If

    Me.txtUrlWS.Text = mParametroServicioWeb.Pardet_DatoStr1
    Me.txtUsuario.Text = mParametroServicioWeb.Pardet_DatoStr2
    Dim cyphertext As String = ""
    crypto.Decrypt(mParametroServicioWeb.Pardet_DatoStr3, cyphertext)
    Me.txtClave.Text = cyphertext
    Me.txtIDSesion.Value = mParametroServicioWeb.Pardet_DatoInt1
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoWS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Return mParametroServicioWeb.EsModificado
  End Function
#End Region


#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoWS_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mParametroServicioWeb.Pardet_DatoStr1 = Me.txtUrlWS.Text
    mParametroServicioWeb.Pardet_DatoStr2 = Me.txtUsuario.Text
    Dim cyphertext As String = ""
    crypto.Encrypt(Me.txtClave.Text, cyphertext)
    mParametroServicioWeb.Pardet_DatoStr3 = cyphertext
    mParametroServicioWeb.Pardet_DatoInt1 = Me.txtIDSesion.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_Datos()
      If Not mParametroServicioWeb.Guardar() Then
        Throw New Exception("No se puede guardar la configuración del servicio web.")
      End If
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, mParametroServicioWeb.Pardet_DatoStr1 + " Usuario: " + mParametroServicioWeb.Pardet_DatoStr2)
      mParametroServicioWeb.EsModificado = True
      Return True
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function


#End Region



#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ConfigurarWS)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoWS_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ConfigurarWS)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoWS_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Componentes"
    mParametroServicioWeb = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumOpciones.Sistema, 2)
    crypto = New PDFco.Security.Cryptography.RijndaelCryptography()
    crypto.KeySize = 256
    crypto.Key = System.Convert.FromBase64String("DaxnZbh41G4MZUL1ojySjZUP/vp7Me1ynsls8lQTCy8=")
    crypto.IV = System.Convert.FromBase64String("HHL9FfbG+xVcm16fFxYqRA==")

    llenar_datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

  End Sub

End Class
