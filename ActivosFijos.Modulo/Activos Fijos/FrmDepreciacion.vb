Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Infoware.Reportes
Imports ActivosFijos.Reglas
Imports Microsoft.Office.Interop
Imports System.Reflection

Public Class FrmDepreciacion

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
    MyBase.Tabla = "Depreciación"

    Me.btneliminar.Enabled = Restriccion.Restri_Eliminacion

    Me.cbofrecuenciadepreciacion.OperadorDatos = Sistema.OperadorDatos
    Me.cbofrecuenciadepreciacion.Parametro = Enumerados.EnumParametros.FrecuenciaDepreciacion
    Me.cbofrecuenciadepreciacion.Llenar_Datos()

    Me.cbotipodepreciacion.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipodepreciacion.Parametro = Enumerados.EnumParametros.TipoDepreciacion
    Me.cbotipodepreciacion.Llenar_Datos()
  End Sub
#End Region

  Private Sub cbofrecuenciadepreciacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbofrecuenciadepreciacion.SelectedIndexChanged
    If Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual Then
      Me.dtperiodo.CustomFormat = "yyyy/MM"
    Else
      Me.dtperiodo.CustomFormat = "yyyy/MM/dd"
    End If
  End Sub

  Private mDepreciacion As Depreciacion = Nothing

  Private Sub btngenerar_Click(sender As System.Object, e As System.EventArgs) Handles btngenerar.Click
    Dim mDeprec_Codigo As String
    If Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual Then
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMM")
    Else
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMMdd")
    End If

    Try
      mDepreciacion = New Depreciacion(Sistema.OperadorDatos, Me.cbofrecuenciadepreciacion.ParametroDet.Parame_Codigo, Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia, Me.cbotipodepreciacion.ParametroDet.Parame_Codigo, Me.cbotipodepreciacion.ParametroDet.Pardet_Secuencia, mDeprec_Codigo)
    Catch ex As Exception
      mDepreciacion = New Depreciacion(Sistema.OperadorDatos, True)
      mDepreciacion.PardetFrecuenciaDepreciacion = Me.cbofrecuenciadepreciacion.ParametroDet
      mDepreciacion.PardetTipoDepreciacion = Me.cbotipodepreciacion.ParametroDet
      mDepreciacion.Deprec_Codigo = mDeprec_Codigo
    End Try

    Try
      If mDepreciacion.Deprec_esProyeccion Then
        mDepreciacion.Eliminar()

        mDepreciacion = New Depreciacion(Sistema.OperadorDatos, True)
        mDepreciacion.PardetFrecuenciaDepreciacion = Me.cbofrecuenciadepreciacion.ParametroDet
        mDepreciacion.PardetTipoDepreciacion = Me.cbotipodepreciacion.ParametroDet
        mDepreciacion.Deprec_Codigo = mDeprec_Codigo
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
      Exit Sub
    End Try

    bsdepreciacion.DataSource = Nothing
    Me.dgdepreciacion.DataSource = bsdepreciacion
    Me.dgdepreciacion.AutoDiscover()

    If Not mDepreciacion.Guardar Then
      MsgBox(Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    Else
      MsgBox("Proceso terminado", MsgBoxStyle.Information, "Información")
    End If
  End Sub

  Private Sub btnimprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnimprimir.Click
    Dim _depreciacion As Depreciacion
    Dim mDeprec_Codigo As String
    If Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual Then
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMM")
    Else
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMMdd")
    End If

    Try
      _depreciacion = New Depreciacion(Sistema.OperadorDatos, Me.cbofrecuenciadepreciacion.ParametroDet.Parame_Codigo, Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia, Me.cbotipodepreciacion.ParametroDet.Parame_Codigo, Me.cbotipodepreciacion.ParametroDet.Pardet_Secuencia, mDeprec_Codigo)
    Catch ex As Exception
      Exit Sub
    End Try

    Dim f As New FrmReporteDepreciacion(Sistema, Restriccion)
    f.Depreciacion = _depreciacion
    f.ShowDialog()
  End Sub

  Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.Depreciacion)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "Proc_Depreciacion_Exportar")
    f.Valores = New Object() {Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia, IIf(Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual, Me.dtperiodo.Value.ToString("yyyyMM"), Me.dtperiodo.Value.ToString("yyyyMMdd")), Me.dtperiodo.Value.Date.AddDays(-Me.dtperiodo.Value.Date.Day + 1).AddMonths(1).AddDays(-1)}
    'f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbriadminrElemento)
    f.ShowDialog()
  End Sub

  Private Sub btngenerartxt_Click(sender As System.Object, e As System.EventArgs) Handles btngenerartxt.Click
    Dim _coddeprec As String = IIf(Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual, Me.dtperiodo.Value.ToString("yyyyMM"), Me.dtperiodo.Value.ToString("yyyyMMdd"))

    Dim ds As New DataTable
    Dim bReturn As Boolean = False
    With Sistema.OperadorDatos
      .AgregarParametro("@accion", Nothing)
      .AgregarParametro("@cbo_Frecuencia_Depreciacion", Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia)
      .AgregarParametro("@cbo_Mostrar", 1)
      .AgregarParametro("@cba_Codigo_Depreciacion", _coddeprec)
      .AgregarParametro("@Fecha_ultimo_dia_mes", Me.dtperiodo.Value.Date.AddDays(-Me.dtperiodo.Value.Date.Day + 1).AddMonths(1).AddDays(-1))
      .Procedimiento = "Proc_Depreciacion_Exportar"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()

    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      Dim _archivotxt As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, String.Format("{0}{1}{2}.txt", Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Descripcion.Trim.Substring(0, 3), Me.cbotipodepreciacion.ParametroDet.Pardet_Descripcion.Trim.Substring(0, 3), _coddeprec.Trim))

      Dim fila = 0
      Dim errorcont = 0
      My.Computer.FileSystem.WriteAllText(_archivotxt, "", False)
      For Each _dr As DataRow In ds.Rows
        Dim _texto As String = ""
        fila += 1
        For col As Integer = 1 To ds.Columns.Count
          Try
            _texto = _texto + CStr(_dr(col - 1)).Replace(",", ".") + ";"
          Catch ex As Exception
            If Not _texto.Substring(0, 10) = ">>>Error! " Then
              _texto = ">>>Error! " + _texto + "<Error>;"
            End If

            errorcont += 1
          End Try
        Next
        _texto = _texto + vbCrLf
        My.Computer.FileSystem.WriteAllText(_archivotxt, _texto, True)
      Next
      Shell("Notepad " + _archivotxt, AppWinStyle.NormalFocus, False)
    End If
  End Sub

  Private Sub btneliminar_Click(sender As System.Object, e As System.EventArgs) Handles btneliminar.Click
    Dim mDeprec_Codigo As String
    If Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual Then
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMM")
    Else
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMMdd")
    End If

    Try
      mDepreciacion = New Depreciacion(Sistema.OperadorDatos, Me.cbofrecuenciadepreciacion.ParametroDet.Parame_Codigo, Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia, Me.cbotipodepreciacion.ParametroDet.Parame_Codigo, Me.cbotipodepreciacion.ParametroDet.Pardet_Secuencia, mDeprec_Codigo)
    Catch ex As Exception
      MsgBox("No existe depreciación", MsgBoxStyle.Critical, "Error")
    End Try

    Try
      If mDepreciacion.Eliminar() Then
        MsgBox("Proceso terminado", MsgBoxStyle.Information, "Información")
        Me.bsdepreciacion.DataSource = Nothing
        Me.cbofrecuenciadepreciacion.Select()
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrar.Click
    Dim mDeprec_Codigo As String
    If Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia = Enumerados.enumFrecuenciaDepreciacion.Mensual Then
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMM")
    Else
      mDeprec_Codigo = Me.dtperiodo.Value.ToString("yyyyMMdd")
    End If

    Try
      mDepreciacion = New Depreciacion(Sistema.OperadorDatos, Me.cbofrecuenciadepreciacion.ParametroDet.Parame_Codigo, Me.cbofrecuenciadepreciacion.ParametroDet.Pardet_Secuencia, Me.cbotipodepreciacion.ParametroDet.Parame_Codigo, Me.cbotipodepreciacion.ParametroDet.Pardet_Secuencia, mDeprec_Codigo)

      bsdepreciacion.DataSource = Nothing
      Me.dgdepreciacion.DataSource = bsdepreciacion
      Me.dgdepreciacion.AutoDiscover()

      Me.bsdepreciacion.DataSource = DepreciacionDetList.ObtenerLista(mDepreciacion)
      Me.dgdepreciacion.DataSource = bsdepreciacion

      Me.dgdepreciacion.AutoDiscover()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
      Exit Sub
    End Try

  End Sub
End Class