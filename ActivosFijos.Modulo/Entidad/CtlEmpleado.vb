Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
'Imports WWTS.Controles.Base

Imports Infoware.Controles.General
Imports ActivosFijos.Reglas

Public Class CtlEmpleado
  Private mOperadorDatos As OperadorDatos
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        Me.ComboBoxTipoSangre.OperadorDatos = value
        Me.ComboBoxTipoSangre.Parametro = Enumerados.EnumParametros.TipoSangre
        Me.ComboBoxTipoSangre.Llenar_Datos()

        Me.CtlUbicacion1.OperadorDatos = value
        Me.CtlUbicacion1.llenar_datos()

        Me.ComboBoxTipoEmpleado.OperadorDatos = value
        Me.ComboBoxTipoEmpleado.Parametro = Enumerados.EnumParametros.TipoEmpleado
        Me.ComboBoxTipoEmpleado.Llenar_Datos()

        Me.ComboBoxFormaPagoRol.OperadorDatos = value
        Me.ComboBoxFormaPagoRol.Parametro = Enumerados.EnumParametros.FormaPagoRol
        Me.ComboBoxFormaPagoRol.Llenar_Datos()

        Me.ComboBoxBanco.OperadorDatos = value
        Me.ComboBoxBanco.Parametro = Enumerados.EnumParametros.Banco
        Me.ComboBoxBanco.Llenar_Datos()

        Me.ComboBoxTipoCtaBancaria.OperadorDatos = value
        Me.ComboBoxTipoCtaBancaria.Parametro = Enumerados.EnumParametros.TipoCtaBan
        Me.ComboBoxTipoCtaBancaria.Llenar_Datos()

        Me.ComboBoxDiscapacidad.OperadorDatos = value
        Me.ComboBoxDiscapacidad.Parametro = Enumerados.EnumParametros.TipoDiscapacidad
        Me.ComboBoxDiscapacidad.Llenar_Datos()

        Me.ComboBoxSeguroCorporativo.OperadorDatos = value
        Me.ComboBoxSeguroCorporativo.Parametro = Enumerados.EnumParametros.SeguroCorporativo
        Me.ComboBoxSeguroCorporativo.Llenar_Datos()
        
        Me.cboSectorDomicilio.OperadorDatos = value
        Me.cboSectorDomicilio.Parametro = Enumerados.EnumParametros.SectorDomicilio
        Me.cboSectorDomicilio.Llenar_Datos()

        Me.cboNacionalidad.OperadorDatos = value
        Me.cboNacionalidad.Parametro = Enumerados.EnumParametros.Nacionalidad
        Me.cboNacionalidad.Llenar_Datos()
      End If
    End Set
  End Property

  Private mEmpleado As Empleado = Nothing
  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal value As Empleado)
      mEmpleado = value
      'If value IsNot Nothing Then
      Llenar_datos()
      'End If
    End Set
  End Property

  Public Sub Llenar_datos()
    If mEmpleado Is Nothing Then
      Me.Enabled = False
      Exit Sub
    End If
    Me.Enabled = True
    Me.CtlEntidadNatural1.Entidad = mEmpleado.Entidadnatural.Entidad

    Me.txtprimaria.Text = mEmpleado.Emplea_Primaria
    Me.txtprianio.Text = mEmpleado.Emplea_Primariaanio
    Me.txtsecundaria.Text = mEmpleado.Emplea_Secundaria
    Me.txtsecanio.Text = mEmpleado.Emplea_Secundariaanio
    Me.txtbachiller.Text = mEmpleado.Emplea_Bachiller
    Me.txtsuperior.Text = mEmpleado.Emplea_Superior
    Me.txtsupanio.Text = mEmpleado.Emplea_Superioranio
    Me.txttitulo.Text = mEmpleado.Emplea_Titulo
    Me.txtcursos.Text = mEmpleado.Emplea_Cursos
    Me.txtrefper.Text = mEmpleado.Emplea_ReferPersonales
    Me.txtreflab.Text = mEmpleado.Emplea_ReferLaborales

    Me.chkVisible.Checked = mEmpleado.Emplea_Visible
    Me.ComboBoxTipoSangre.ParametroDet = mEmpleado.PardetTipoSangre
    Me.CtlUbicacion1.Parroquia = mEmpleado.PardetParroquia
    Me.txtavisoemer.Text = mEmpleado.Emplea_Emergencia
    Me.txtenfermedad.Text = mEmpleado.Emplea_Enfermedad
    Me.chkexclfam.Checked = mEmpleado.Emplea_ExcluirFamiliares
    Me.ComboBoxTipoEmpleado.ParametroDet = mEmpleado.PardetTipoEmpleado
    Me.ComboBoxFormaPagoRol.ParametroDet = mEmpleado.PardetFormaPagoRol
    Me.ComboBoxBanco.ParametroDet = mEmpleado.PardetBanco
    Me.ComboBoxTipoCtaBancaria.ParametroDet = mEmpleado.PardetTipoCtaBancaria
    Me.ComboBoxDiscapacidad.ParametroDet = mEmpleado.PardetTipoDiscapacidad
    Me.ComboBoxSeguroCorporativo.ParametroDet = mEmpleado.PardetSeguroCorporativo
    Me.chkdiscaauditiva.Checked = mEmpleado.Emplea_DiscaAuditiva
    Me.chkdiscafisica.Checked = mEmpleado.Emplea_DiscaFisica
    Me.chkdiscaintelectual.Checked = mEmpleado.Emplea_DiscaIntelectual
    Me.chkdiscalinguistica.Checked = mEmpleado.Emplea_DiscaLenguaje
    Me.chkdiscapsicologica.Checked = mEmpleado.Emplea_DiscaPsicologica
    Me.chkdiscavisual.Checked = mEmpleado.Emplea_DiscaVisual

    Me.txtnumcta.Text = mEmpleado.Emplea_NumeroCuentaBancaria
    Me.txtpresquirog.Value = mEmpleado.Emplea_DesctoPrestQuirogMensual
    Me.txtjubpatronal.Value = mEmpleado.Emplea_JubilacionPatronal
    Me.dtfecafiliess.Value = mEmpleado.Emplea_FechaAfiliacionIESS

    Me.CtlFotoPersona1.Imagen = Me.Empleado.Entidadnatural.Entidad.Entida_Imagen

    Me.cboSectorDomicilio.ParametroDet = mEmpleado.PardetSectorDomicilio
    Me.cboNacionalidad.ParametroDet = mEmpleado.PardetNacionalidad

    If Me.txtbachiller.Text <> String.Empty Then
      chckBachiller.Checked = True
    End If

    If Me.txttitulo.Text <> String.Empty Then
      chckTitulo.Checked = True
    End If
  End Sub

  Public Sub Mapear_datos()
    Me.CtlEntidadNatural1.Mapear_datos()
    mEmpleado.Entidadnatural.Entidad = Me.CtlEntidadNatural1.Entidad

    mEmpleado.Emplea_Visible = Me.chkVisible.Checked
    mEmpleado.Emplea_Primaria = Me.txtprimaria.Text
    mEmpleado.Emplea_Primariaanio = Me.txtprianio.Text
    mEmpleado.Emplea_Secundaria = Me.txtsecundaria.Text
    mEmpleado.Emplea_Secundariaanio = Me.txtsecanio.Text
    'mEmpleado.Emplea_Bachiller = Me.txtbachiller.Text
    mEmpleado.Emplea_Superior = Me.txtsuperior.Text
    mEmpleado.Emplea_Superioranio = Me.txtsupanio.Text
    'mEmpleado.Emplea_Titulo = Me.txttitulo.Text
    mEmpleado.Emplea_Cursos = Me.txtcursos.Text
    mEmpleado.Emplea_ReferPersonales = Me.txtrefper.Text
    mEmpleado.Emplea_ReferLaborales = Me.txtreflab.Text

    mEmpleado.PardetTipoSangre = Me.ComboBoxTipoSangre.ParametroDet
    mEmpleado.PardetParroquia = Me.CtlUbicacion1.Parroquia
    mEmpleado.Emplea_Emergencia = Me.txtavisoemer.Text
    mEmpleado.Emplea_Enfermedad = Me.txtenfermedad.Text
    mEmpleado.Emplea_ExcluirFamiliares = Me.chkexclfam.Checked
    mEmpleado.PardetTipoEmpleado = Me.ComboBoxTipoEmpleado.ParametroDet
    mEmpleado.PardetFormaPagoRol = Me.ComboBoxFormaPagoRol.ParametroDet
    mEmpleado.PardetBanco = Me.ComboBoxBanco.ParametroDet
    mEmpleado.PardetTipoCtaBancaria = Me.ComboBoxTipoCtaBancaria.ParametroDet
    mEmpleado.PardetTipoDiscapacidad = Me.ComboBoxDiscapacidad.ParametroDet
    mEmpleado.PardetSeguroCorporativo = Me.ComboBoxSeguroCorporativo.ParametroDet
    mEmpleado.Emplea_DiscaAuditiva = Me.chkdiscaauditiva.Checked
    mEmpleado.Emplea_DiscaFisica = Me.chkdiscafisica.Checked
    mEmpleado.Emplea_DiscaIntelectual = Me.chkdiscaintelectual.Checked
    mEmpleado.Emplea_DiscaLenguaje = Me.chkdiscalinguistica.Checked
    mEmpleado.Emplea_DiscaPsicologica = Me.chkdiscapsicologica.Checked
    mEmpleado.Emplea_DiscaVisual = Me.chkdiscavisual.Checked

    mEmpleado.Emplea_NumeroCuentaBancaria = Me.txtnumcta.Text
    mEmpleado.Emplea_DesctoPrestQuirogMensual = Me.txtpresquirog.Value
    mEmpleado.Emplea_JubilacionPatronal = Me.txtjubpatronal.Value
    mEmpleado.Emplea_FechaAfiliacionIESS = Me.dtfecafiliess.Value

    mEmpleado.PardetSectorDomicilio = Me.cboSectorDomicilio.ParametroDet
    mEmpleado.PardetNacionalidad = Me.cboNacionalidad.ParametroDet
    If chckBachiller.Checked Then
      mEmpleado.Emplea_Bachiller = Me.txtbachiller.Text
    Else
      mEmpleado.Emplea_Bachiller = String.Empty
    End If

    If chckTitulo.Checked Then
      mEmpleado.Emplea_Titulo = Me.txttitulo.Text
    Else
      mEmpleado.Emplea_Titulo = String.Empty
    End If
  End Sub

  Private Sub CtlFotoPersona1_CambioImagen(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlFotoPersona1.CambioImagen
    Try
      Me.Empleado.Entidadnatural.Entidad.ArchivoImagen = Me.CtlFotoPersona1.ArchivoImagen
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CtlEntidadNatural1_Repetido(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlEntidadNatural1.Repetido
    Me.Empleado.Entidadnatural = Me.CtlEntidadNatural1.Entidad.Entidadnatural
  End Sub

  'Private guardo As Boolean = True
  Function Guardar_datos() As Boolean
    Try
      'guardo = True
      Mapear_datos()
      Dim _esnuevo As Boolean = mEmpleado.EsNuevo
      If mEmpleado.Guardar() Then
        Return True
      End If
    Catch ex As Exception
      MsgBox("No se puede guardar Empleado" & Environment.NewLine & ex.Message & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End Try
    Return False
  End Function

  Private Sub chckBachiller_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckBachiller.CheckedChanged
    If chckBachiller.Checked Then
      Me.txtbachiller.Enabled = True
    Else
      Me.txtbachiller.Enabled = False
    End If
  End Sub

  Private Sub chckTitulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckTitulo.CheckedChanged
    If chckTitulo.Checked Then
      Me.txttitulo.Enabled = True
      Me.txtEspecializacion.Enabled = True
    Else
      Me.txttitulo.Enabled = False
      Me.txtEspecializacion.Enabled = False
    End If
  End Sub
End Class
