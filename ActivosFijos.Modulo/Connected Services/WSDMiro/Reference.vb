﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace WSDMiro
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://middleware.jbank.topsystems/", ConfigurationName:="WSDMiro.TopazMiddleWareWS")>  _
    Public Interface TopazMiddleWareWS
        
        'CODEGEN: Generating message contract since the operation execute is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function execute(ByVal request As WSDMiro.executeRequest) As WSDMiro.executeResponse1
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function executeAsync(ByVal request As WSDMiro.executeRequest) As System.Threading.Tasks.Task(Of WSDMiro.executeResponse1)
        
        'CODEGEN: Generating message contract since the operation undo is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function undo(ByVal request As WSDMiro.undoRequest) As WSDMiro.undoResponse1
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function undoAsync(ByVal request As WSDMiro.undoRequest) As System.Threading.Tasks.Task(Of WSDMiro.undoResponse1)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://middleware.jbank.topsystems/")>  _
    Partial Public Class execute
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private executionInfoField As String
        
        Private requestField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property executionInfo() As String
            Get
                Return Me.executionInfoField
            End Get
            Set
                Me.executionInfoField = value
                Me.RaisePropertyChanged("executionInfo")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property request() As String
            Get
                Return Me.requestField
            End Get
            Set
                Me.requestField = value
                Me.RaisePropertyChanged("request")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://middleware.jbank.topsystems/")>  _
    Partial Public Class undoResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private undoResultField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property undoResult() As String
            Get
                Return Me.undoResultField
            End Get
            Set
                Me.undoResultField = value
                Me.RaisePropertyChanged("undoResult")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://middleware.jbank.topsystems/")>  _
    Partial Public Class undo
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private executionInfoField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property executionInfo() As String
            Get
                Return Me.executionInfoField
            End Get
            Set
                Me.executionInfoField = value
                Me.RaisePropertyChanged("executionInfo")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://middleware.jbank.topsystems/")>  _
    Partial Public Class executeResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private executeResultField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property executeResult() As String
            Get
                Return Me.executeResultField
            End Get
            Set
                Me.executeResultField = value
                Me.RaisePropertyChanged("executeResult")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class executeRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://middleware.jbank.topsystems/", Order:=0)>  _
        Public execute As WSDMiro.execute
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal execute As WSDMiro.execute)
            MyBase.New
            Me.execute = execute
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class executeResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://middleware.jbank.topsystems/", Order:=0)>  _
        Public executeResponse As WSDMiro.executeResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal executeResponse As WSDMiro.executeResponse)
            MyBase.New
            Me.executeResponse = executeResponse
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class undoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://middleware.jbank.topsystems/", Order:=0)>  _
        Public undo As WSDMiro.undo
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal undo As WSDMiro.undo)
            MyBase.New
            Me.undo = undo
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class undoResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://middleware.jbank.topsystems/", Order:=0)>  _
        Public undoResponse As WSDMiro.undoResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal undoResponse As WSDMiro.undoResponse)
            MyBase.New
            Me.undoResponse = undoResponse
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface TopazMiddleWareWSChannel
        Inherits WSDMiro.TopazMiddleWareWS, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class TopazMiddleWareWSClient
        Inherits System.ServiceModel.ClientBase(Of WSDMiro.TopazMiddleWareWS)
        Implements WSDMiro.TopazMiddleWareWS
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSDMiro_TopazMiddleWareWS_execute(ByVal request As WSDMiro.executeRequest) As WSDMiro.executeResponse1 Implements WSDMiro.TopazMiddleWareWS.execute
            Return MyBase.Channel.execute(request)
        End Function
        
        Public Function execute(ByVal execute1 As WSDMiro.execute) As WSDMiro.executeResponse
            Dim inValue As WSDMiro.executeRequest = New WSDMiro.executeRequest()
            inValue.execute = execute1
            Dim retVal As WSDMiro.executeResponse1 = CType(Me,WSDMiro.TopazMiddleWareWS).execute(inValue)
            Return retVal.executeResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSDMiro_TopazMiddleWareWS_executeAsync(ByVal request As WSDMiro.executeRequest) As System.Threading.Tasks.Task(Of WSDMiro.executeResponse1) Implements WSDMiro.TopazMiddleWareWS.executeAsync
            Return MyBase.Channel.executeAsync(request)
        End Function
        
        Public Function executeAsync(ByVal execute As WSDMiro.execute) As System.Threading.Tasks.Task(Of WSDMiro.executeResponse1)
            Dim inValue As WSDMiro.executeRequest = New WSDMiro.executeRequest()
            inValue.execute = execute
            Return CType(Me,WSDMiro.TopazMiddleWareWS).executeAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSDMiro_TopazMiddleWareWS_undo(ByVal request As WSDMiro.undoRequest) As WSDMiro.undoResponse1 Implements WSDMiro.TopazMiddleWareWS.undo
            Return MyBase.Channel.undo(request)
        End Function
        
        Public Function undo(ByVal undo1 As WSDMiro.undo) As WSDMiro.undoResponse
            Dim inValue As WSDMiro.undoRequest = New WSDMiro.undoRequest()
            inValue.undo = undo1
            Dim retVal As WSDMiro.undoResponse1 = CType(Me,WSDMiro.TopazMiddleWareWS).undo(inValue)
            Return retVal.undoResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSDMiro_TopazMiddleWareWS_undoAsync(ByVal request As WSDMiro.undoRequest) As System.Threading.Tasks.Task(Of WSDMiro.undoResponse1) Implements WSDMiro.TopazMiddleWareWS.undoAsync
            Return MyBase.Channel.undoAsync(request)
        End Function
        
        Public Function undoAsync(ByVal undo As WSDMiro.undo) As System.Threading.Tasks.Task(Of WSDMiro.undoResponse1)
            Dim inValue As WSDMiro.undoRequest = New WSDMiro.undoRequest()
            inValue.undo = undo
            Return CType(Me,WSDMiro.TopazMiddleWareWS).undoAsync(inValue)
        End Function
    End Class
End Namespace
