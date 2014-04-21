Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmInventariarActivo
  Private mInventario As Inventario = Nothing
  Public Property Inventario As Inventario
    Get
      Return mInventario
    End Get
    Set(value As Inventario)
      mInventario = value
      Me.CtlUbicacionActivo1.PardetRaiz = mInventario.PardetUbicacion
      Me.CtlUbicacionActivo1.llenar_Datos()
    End Set
  End Property

  Public ReadOnly Property Activo As Activo
    Get
      Return BindingSource1.Current
    End Get
  End Property

  Private Sub BindingSource1_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource1.CurrentChanged
    llenar_datos()
  End Sub

  Sub llenar_datos()
    If Activo Is Nothing Then
      Exit Sub
    End If
    Me.pnlactivo.Visible = True
    If Activo.EsNuevo Then
      Activo.Activo_CodigoBarra = Me.txtcodigobarra.Text
      Activo.Activo_Serie = Me.txtserie.Text
      Me.CtlActivo1.Activo = Activo
      Me.CtlActivo1.CtlUbicacionActivo1.ParametroDet = Me.CtlUbicacionActivo1.ParametroDet
      Me.CtlActivo1.CtlBuscaCustodio.Empleado = Me.CtlBuscaCustodio.Empleado
    Else
      Me.CtlActivo1.Activo = Activo
    End If
  End Sub

  Private Sub lnkCambiarCustodioUbicacion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    If Activo Is Nothing Then
      Exit Sub
    End If

    Dim mactivos As New ActivoList
    mactivos.Add(Activo)

    Dim mtransaccion As New TransaccionActivo(Sistema.OperadorDatos, True)
    mtransaccion.Activos = mactivos

    Dim f As New FrmMantenimientoTransaccionActivo(Sistema, Enumerados.EnumOpciones.ListadoTransaccionActivos)
    f.TransaccionActivo = mtransaccion
    f.Custodio = Activo.CustodioActual
    f.Ubicacion = Activo.UbicacionActual
    f.ShowDialog()

    Activo.Recargar()
    llenar_datos()
  End Sub


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    FrmListaActivos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmListaActivos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Tabla = "Inventariar activo"

    Me.CtlUbicacionActivo1.PardetRaiz = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo).PardetUbicacion
    Me.CtlUbicacionActivo1.llenar_Datos()

    Me.CtlBuscaCustodio.SoloActivos = True
    Me.CtlBuscaCustodio.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaCustodio.TipoEmpleado = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoEmpleado, Enumerados.enumTipoEmpleado.Custodio)
    Me.CtlBuscaCustodio.Llenar_Datos()

    Me.pnlactivo.Visible = False
    Me.CtlActivo1.Activo = New Activo(Sistema.OperadorDatos, True)
  End Sub
#End Region

  Private Sub btnbuscaractivos_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscaractivos.Click
    If Me.CtlUbicacionActivo1.ParametroDet Is Nothing OrElse Not Me.CtlUbicacionActivo1.ParametroDet.Parame_Codigo = Enumerados.EnumParametros.UbicacionActivo Then
      MsgBox("Debe seleccionar una ubicación", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If Me.CtlBuscaCustodio.Empleado Is Nothing Then
      MsgBox("Debe seleccionar un custodio", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If String.IsNullOrWhiteSpace(Me.txtcodigobarra.Text + Me.txtserie.Text) Then
      MsgBox("Debe ingresar un código de barras o serie para continuar", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    Dim activos As ActivoList
    activos = ActivoList.ObtenerLista(Sistema.OperadorDatos, Me.txtcodigobarra.Text, "", Me.txtserie.Text, "", Nothing, Nothing, "", Nothing, Nothing, Nothing, Nothing, Nothing, True, -1, DateTime.Now, DateTime.Now, Nothing)

    If activos.Count = 0 Then
      MsgBox("No existe el activo, Se registrará como nuevo", MsgBoxStyle.Information, "Información")
      activos.Add(New Activo(Sistema.OperadorDatos, True))
    End If

    Me.BindingSource1.DataSource = activos
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
    Me.pnlactivo.Visible = False
  End Sub

  Private Sub btninventariar_Click(sender As System.Object, e As System.EventArgs) Handles btninventariar.Click
    Dim invdet As InventarioDet = Nothing

    If Activo Is Nothing Then
      Exit Sub
    End If

    If Activo.EsNuevo Then
      Try
        Me.CtlActivo1.Mapear_datos()
        If Me.CtlActivo1.Guardar Then
          invdet = New InventarioDet(Sistema.OperadorDatos, True)
          invdet.Inventario = mInventario
          invdet.Activocustodio = Me.CtlActivo1.Activo.ActivoCustodioActual
          invdet.Activoubicacion = Me.CtlActivo1.Activo.ActivoUbicacionActual
          invdet.InvDet_Activo = True
          invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.EncontradoNuevo)
          Me.CtlActivo1.Activo.Recargar()
          Me.CtlActivo1.llenar_datos()
        Else
          MsgBox(Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
          Exit Sub
        End If
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Exit Sub
      End Try
    Else
      Try
        Me.CtlActivo1.Guardar()
        invdet = New InventarioDet(Sistema.OperadorDatos, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario, Activo.Activo_Codigo)
        If Not invdet.Pardet_EstadoInventario = Enumerados.enumEstadoInventarioActivo.NoInventariado Then
          MsgBox("El activo ya fue inventariado", MsgBoxStyle.Critical, "Error")
          Exit Sub
        End If
        invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.Inventariado)
      Catch ex As Exception
        invdet = New InventarioDet(Sistema.OperadorDatos, True)
        invdet.Inventario = mInventario
        invdet.Activocustodio = Activo.ActivoCustodioActual
        invdet.Activoubicacion = Activo.ActivoUbicacionActual
        invdet.InvDet_Activo = True
        invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.EncontradoExistente)
      End Try
    End If

    If invdet Is Nothing Then
      Exit Sub
    End If

    If invdet.Guardar(Me.CtlBuscaCustodio.Empleado.Entida_Codigo, Me.CtlUbicacionActivo1.ParametroDet.Parame_Codigo, Me.CtlUbicacionActivo1.ParametroDet.Pardet_Secuencia) Then
      'Me.Close()
      MsgBox("Inventario correctamente registrado", MsgBoxStyle.Information, "Información")
      Me.pnlactivo.Visible = False
    Else
      MsgBox(invdet.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
  End Sub

  Private Sub btnnuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevo.Click
    If Me.CtlUbicacionActivo1.ParametroDet Is Nothing OrElse Not Me.CtlUbicacionActivo1.ParametroDet.Parame_Codigo = Enumerados.EnumParametros.UbicacionActivo Then
      MsgBox("Debe seleccionar una ubicación", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If Me.CtlBuscaCustodio.Empleado Is Nothing Then
      MsgBox("Debe seleccionar un custodio", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    Dim activos As New ActivoList
    activos.Add(New Activo(Sistema.OperadorDatos, True))
    Me.BindingSource1.DataSource = activos
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub btnNoInventariado_Click(sender As System.Object, e As System.EventArgs) Handles btnNoInventariado.Click
    Dim invdet As InventarioDet = Nothing
    Try
      invdet = New InventarioDet(Sistema.OperadorDatos, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario, Activo.Activo_Codigo)
      If invdet.Pardet_EstadoInventario = Enumerados.enumEstadoInventarioActivo.NoInventariado Then
        MsgBox("El activo ya tiene el estado No Inventariado", MsgBoxStyle.Critical, "Error")
        Exit Sub
      End If
      invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.NoInventariado)
      If invdet.Guardar() Then
        MsgBox("Activo fue No Inventariado con éxito", MsgBoxStyle.Information, "Información")
      Else
        MsgBox(invdet.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      End If
    Catch ex As Exception
      MsgBox("No existe el activo en el inventario actual", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End Try

  End Sub
End Class