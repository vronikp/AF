Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class CtlBuscaEntidad2
  Public ReadOnly Property Sistema() As Sistema
    Get
      Return CType(Me.ParentForm, FrmFormaBase).Sistema
    End Get
  End Property

  Public Event CambioEntidad As EventHandler

  Public Enum EnumTipoEntidad
    Persona = 0
    EntidadNatural = 1
    EntidadJuridica = 2
  End Enum

  Private mOperadorDatos As OperadorDatos
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
    End Set
  End Property

  Private mTipoEntidad As EnumTipoEntidad = EnumTipoEntidad.Persona
  Public Property TipoEntidad() As EnumTipoEntidad
    Get
      Return mTipoEntidad
    End Get
    Set(ByVal value As EnumTipoEntidad)
      mTipoEntidad = value
    End Set
  End Property

  Public Property EntidadText() As String
    Get
      Return Me.btn_entidad.Text
    End Get
    Set(ByVal value As String)
      Me.btn_entidad.Text = value
    End Set
  End Property

  Private mEntidad As Entidad = Nothing
  <System.ComponentModel.Browsable(False)> _
  Public Property Entidad() As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      'If value IsNot Nothing Then
      llenar_datos()
      'End If
    End Set
  End Property

  <System.ComponentModel.Browsable(False)> _
  Public Property EntidadNatural() As EntidadNatural
    Get
      If mEntidad Is Nothing Then
        Return Nothing
      Else
        Return mEntidad.Entidadnatural
      End If
    End Get
    Set(ByVal value As EntidadNatural)
      If value IsNot Nothing Then
        Entidad = value.Entidad
      End If
    End Set
  End Property

  <System.ComponentModel.Browsable(False)> _
  Public Property EntidadJuridica() As EntidadJuridica
    Get
      If mEntidad Is Nothing Then
        Return Nothing
      Else
        Return mEntidad.Entidadjuridica
      End If
    End Get
    Set(ByVal value As EntidadJuridica)
      If value IsNot Nothing Then
        Entidad = value.Entidad
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mEntidad Is Nothing Then
      Me.TextBox1.Text = String.Empty
      Exit Sub
    End If

    Me.TextBox1.Text = mEntidad.NombreCompleto
  End Sub

  Private Sub btn_entidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entidad.Click, BuscarToolStripMenuItem.Click
    Dim f As New FrmListaPersonas(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListadoPersonas)
    f.EsBusqueda = True
    f.TipoPersona = mTipoEntidad
    If Not mTipoEntidad = EnumTipoEntidad.Persona Then
      f.PuedeElegirEntidad = False
    End If
    f.OperadorDatos = mOperadorDatos
    f.Persona = mEntidad
    If f.ShowDialog() = DialogResult.OK Then
      Entidad = f.Persona
      RaiseEvent CambioEntidad(Me, Nothing)
    End If
  End Sub

  Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
    Entidad = Nothing
    RaiseEvent CambioEntidad(Me, Nothing)
  End Sub

  Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    Dim f As New FrmMantenimientoPersona(Sistema, Enumerados.EnumOpciones.ListadoPersonas)
    f.Persona = New Entidad(Sistema.OperadorDatos, True)
    f.ShowDialog()

    If f.persona IsNot Nothing AndAlso Not f.Persona.EsNuevo Then
      mEntidad = f.Persona
      llenar_datos()
    End If

    f.Dispose()
  End Sub
End Class
