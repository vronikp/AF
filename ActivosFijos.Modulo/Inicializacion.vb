Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports System.IO

Public Class Inicializacion
  Implements Infoware.Consola.Base.IAplicacion

  Public Shared Sub main()
    'ejecutar ica
    Dim RutaICA As String = LeerClave()

    If Not My.Computer.FileSystem.FileExists(RutaICA) Then
      If MsgBox("No se pudo encontrar el Infoware.Consola.Administrator, ¿Desea encontrarlo usted mismo?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Dim ofd As New OpenFileDialog
        ofd.Filter = "ICA (Infoware.Consola.Administrativa.exe)|Infoware.Consola.Administrativa.exe|Todos los archivos (*.*)|*.*"

        If ofd.ShowDialog = DialogResult.OK Then
          RutaICA = ofd.FileName
          GuardarClave(RutaICA)
          My.Settings.Save()
        Else
          End
        End If
      Else
        MsgBox("Debe instalar el Infoware.Consola.Adminitrator antes de poder utilizar el sistema", MsgBoxStyle.Exclamation, "Información")
        End
      End If
    End If
    Dim mProcess As System.Diagnostics.Process
    mProcess = New System.Diagnostics.Process
    mProcess.StartInfo.FileName = RutaICA
    mProcess.StartInfo.Arguments = String.Format("""{0}""", System.Reflection.Assembly.GetExecutingAssembly.Location)
    'mProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    mProcess.EnableRaisingEvents = False

    mProcess.Start()
    End
    'mProcess.WaitForExit()
    'Do
    '  If Not mProcess.HasExited Then
    '  End If
    'Loop While Not mProcess.WaitForExit(1000)
  End Sub

  Public Shared Sub GuardarClave(ByVal valor As String)
    Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Integra2b")
    Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    Dim configFile As String
    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    My.Computer.FileSystem.WriteAllText(configFile, valor, False)
  End Sub

  Public Shared Function LeerClave() As String
    Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Integra2b")
    Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    Dim configFile As String
    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    Dim result As String = ""
    Try
      result = My.Computer.FileSystem.ReadAllText(configFile)
    Catch ex As Exception

    End Try

    Return result
  End Function

  Public Function Validacion(ByVal _Usuario As Infoware.Reglas.General.Usuario) As Boolean Implements Infoware.Consola.Base.IAplicacion.Validacion
    'MsgBox("Todo ok")
    Return True
  End Function

  'Public Sub CargarListaModulos(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal) Implements Infoware.Consola.Base.IAplicacion.CargarListaModulos
  '  If _Principal.Sistema.Usuario.Restricciones.Rango(700, 799) Then
  '    _Principal.LeftSpine1.Items.Add(_Principal.CrearBotonModulo("Roles de pago", My.Resources.Resources.pagos.ToBitmap, New IAplicacion.DelegadoCargarModulos(AddressOf CargarModulo)))
  '  End If
  'End Sub

  'Public Sub CargarModulo(ByVal _Principal As Infoware.Consola.Base.FrmPrincipal)
  '  _Principal.Text = "Roles de pago"
  '  Dim f As New FrmMenuRol(_Principal.Sistema)
  '  _Principal.Cargar_IModulo(f)
  'End Sub

  'Public Function CargarListaNuevos() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionNuevo) Implements Infoware.Consola.Base.IAplicacion.CargarListaNuevos
  '  Dim result As New List(Of OpcionNuevo)
  '  'result.Add(New OpcionNuevo("Roles de pago", My.Resources.pagos.ToBitmap, New Infoware.Consola.Base.OpcionNuevo.DelegadoCargarOpcion(AddressOf NuevoAfiliado), Enumerados.EnumOpciones.Afiliados))

  '  Return result
  'End Function

  ''Sub NuevoAfiliado(ByVal _Sistema As Sistema)
  ''  Dim f As New FrmMantenimientoAfiliado(_Sistema, Enumerados.EnumOpciones.Afiliados)
  ''  f.Afiliado = New WWTS.Fidelizacion.Reglas.Afiliado(_Sistema.OperadorDatos, True)
  ''  f.ShowDialog()
  ''End Sub

  'Public Function CargarListaBuscar() As System.Collections.Generic.List(Of Infoware.Consola.Base.OpcionBuscar) Implements Infoware.Consola.Base.IAplicacion.CargarListaBuscar
  '  Dim result As New List(Of OpcionBuscar)
  '  'result.Add(New OpcionBuscar("Afiliado", New Infoware.Consola.Base.OpcionBuscar.DelegadoCargarOpcion(AddressOf BuscarAfiliado), Enumerados.EnumOpciones.Afiliados))

  '  Return result
  'End Function

  ''Sub BuscarAfiliado(ByVal _Sistema As Sistema, ByVal _Texto As String)
  ''  Dim f As New FrmListaAfiliados(_Sistema, Enumerados.EnumOpciones.Afiliados, False)

  ''  f.Filtro = _Texto
  ''  f.ShowDialog()
  ''End Sub

  Public Function CargarListaGrupoOpciones(ByVal _Sistema As Infoware.Consola.Base.Sistema) As System.Collections.Generic.List(Of Infoware.Consola.Base.GrupoOpcion) Implements Infoware.Consola.Base.IAplicacion.CargarListaGrupoOpciones
    Dim _grupos As New List(Of GrupoOpcion)

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.General) Then
      _grupos.AddRange(New Loader().CargarModuloGeneral(_Sistema))
    End If
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.ActivosFijos) Then
      _grupos.AddRange(New Loader().CargarModuloActivoFijo(_Sistema))
    End If
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
      _grupos.AddRange(New Loader().CargarModuloSeguridad(_Sistema))
    End If
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
      _grupos.AddRange(New Loader().CargarModuloConfiguracion(_Sistema))
    End If

    Return _grupos
  End Function
End Class
