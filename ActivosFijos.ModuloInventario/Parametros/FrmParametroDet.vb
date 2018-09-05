Imports Infoware.Datos
'Imports Infoware.Reglas.General
Imports Infoware.Controles.Base

Imports Infoware.Controles.General
Imports ActivosFijos.Reglas

Public Class FrmParametroDet
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

  Private menumtipoobjeto As WWTSParametroDetList.enumTipoObjeto = WWTSParametroDetList.enumTipoObjeto.Nada
  Public Property enumtipoobjeto() As WWTSParametroDetList.enumTipoObjeto
    Get
      Return menumtipoobjeto
    End Get
    Set(ByVal value As WWTSParametroDetList.enumTipoObjeto)
      menumtipoobjeto = value
    End Set
  End Property

  Private mPrimero As Boolean = True

  Public Sub Refrescar_forma() Implements IMantenimiento.Refrescar_forma
    If Not mParametroDet Is Nothing Then
      Me.Text = mParametroDet.Parametro.Parame_Descripcion
      Me.txtdescripcion.Text = mParametroDet.Pardet_Descripcion
      Me.pnldatostr1.Visible = mParametroDet.Parametro.TieneDatoStr1
      If mParametroDet.Parametro.TieneDatoStr1 Then
        Me.lbl_datostr1.Text = mParametroDet.Parametro.Parame_LeyendaDatoStr1
        Me.txt_datostr1.Text = mParametroDet.Pardet_DatoStr1
      Else
        If mPrimero Then
          Me.Height -= Me.pnldatostr1.Height
        End If
      End If
      Me.pnldatoint.Visible = mParametroDet.Parametro.TieneDatoInt1
      If mParametroDet.Parametro.TieneDatoInt1 Then
        Me.lbl_datoint1.Text = mParametroDet.Parametro.Parame_LeyendaDatoInt1
        Me.txtdatoint1.Value = mParametroDet.Pardet_DatoInt1
      Else
        If mPrimero Then
          Me.Height -= Me.pnldatoint.Height
        End If
      End If
      Me.pnldatodec.Visible = mParametroDet.Parametro.TieneDatoDec1
      If mParametroDet.Parametro.TieneDatoDec1 Then
        Me.lbl_datodec1.Text = mParametroDet.Parametro.Parame_LeyendaDatoDec1
        Me.txtdatodec1.Value = mParametroDet.Pardet_DatoDec1
      Else
        If mPrimero Then
          Me.Height -= Me.pnldatodec.Height
        End If
      End If
      Me.pnldatoley.Visible = mParametroDet.Parametro.TieneDatoLeyenda
      If mParametroDet.Parametro.TieneDatoLeyenda Then
        Me.lbl_datoley1.Text = mParametroDet.Parametro.Parame_LeyendaLeyenda
        Me.txtdatoley1.Text = mParametroDet.Pardet_Leyenda
      Else
        If mPrimero Then
          Me.Height -= Me.pnldatoley.Height
        End If
      End If
      Me.pnldatobit1.Visible = mParametroDet.Parametro.TieneDatoBit1
      If mParametroDet.Parametro.TieneDatoBit1 Then
        Me.checkdatobit1.Text = mParametroDet.Parametro.Parame_LeyendaDatoBit1
        Me.checkdatobit1.Checked = mParametroDet.Pardet_DatoBit1
      Else
        If mPrimero Then
          Me.Height -= Me.pnldatobit1.Height
        End If
      End If

      If mParametroDet.Parametro.ParametroPadre Is Nothing Then
        Me.pnlpadre.Visible = False
        If mPrimero Then
          Me.Height -= Me.pnlpadre.Height
        End If
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

    mPrimero = False
  End Sub

  Private Sub FrmParametroDet_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    Try
      Select Case mDireccion
        Case IMantenimiento.Accion.Ingreso, IMantenimiento.Accion.Modificacion
          If Not mParametroDet Is Nothing Then
            mParametroDet.Pardet_Descripcion = Me.txtdescripcion.Text
            If mParametroDet.Parametro.TieneDatoStr1 Then
              mParametroDet.Pardet_DatoStr1 = Me.txt_datostr1.Text
            End If
            If mParametroDet.Parametro.TieneDatoInt1 Then
              mParametroDet.Pardet_DatoInt1 = Me.txtdatoint1.Value
            End If
            If mParametroDet.Parametro.TieneDatoDec1 Then
              mParametroDet.Pardet_DatoDec1 = Me.txtdatodec1.Value
            End If
            If mParametroDet.Parametro.TieneDatoLeyenda Then
              mParametroDet.Pardet_Leyenda = Me.txtdatoley1.Text
            End If
            If mParametroDet.Parametro.TieneDatoBit1 Then
              mParametroDet.Pardet_DatoBit1 = Me.checkdatobit1.Checked
            End If
            If pnlpadre.Visible Then
              mParametroDet.PardetPadre = Me.ComboBoxParametroDet1.ParametroDet
            End If
            Select Case menumtipoobjeto
              Case WWTSParametroDetList.enumTipoObjeto.Natural
                mParametroDet.Parame_Padre = 110
                mParametroDet.Pardet_Padre = 1
              Case WWTSParametroDetList.enumTipoObjeto.Juridica
                mParametroDet.Parame_Padre = 110
                mParametroDet.Pardet_Padre = 2
            End Select
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
End Class
