﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5446
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Reglas
Imports System
Imports System.Xml
Imports System.Xml.Serialization


#Region "TransaccionBaja"
Partial Public Class TransaccionBaja
    Inherits _Database

    Private mTraBaj_Codigo As Integer = 0

    Private mUsuari_Codigo As String = ""

    Private mTraBaj_Observacion As String = ""

    Private mTraBaj_Fecha As DateTime = Now

    Private mParame_TipoBaja As Integer = 0

    Private mPardet_TipoBaja As Integer = 0

    Public Sub New()
        MyBase.New()
    End Sub

    <XmlAttribute()>
    Public Overridable Property TraBaj_Codigo() As Integer
        Get
            Return Me.mTraBaj_Codigo
        End Get
        Set(value As Integer)
            Me.mTraBaj_Codigo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property Usuari_Codigo() As String
        Get
            Return Me.mUsuari_Codigo
        End Get
        Set(value As String)
            Me.mUsuari_Codigo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property TraBaj_Observacion() As String
        Get
            Return Me.mTraBaj_Observacion
        End Get
        Set(value As String)
            Me.mTraBaj_Observacion = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property TraBaj_Fecha() As DateTime
        Get
            Return Me.mTraBaj_Fecha
        End Get
        Set(value As DateTime)
            Me.mTraBaj_Fecha = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property Parame_TipoBaja() As Integer
        Get
            Return Me.mParame_TipoBaja
        End Get
        Set(value As Integer)
            Me.mParame_TipoBaja = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()>
    Public Overridable Property Pardet_TipoBaja() As Integer
        Get
            Return Me.mPardet_TipoBaja
        End Get
        Set(value As Integer)
            Me.mPardet_TipoBaja = value
            EsModificado = True
        End Set
    End Property
End Class
#End Region
