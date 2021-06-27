'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace XamlStaticHelperNamespace
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")>  _
    Friend Class _XamlStaticHelper
        
        Private Shared schemaContextField As System.WeakReference
        
        Private Shared assemblyListField As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
        
        Friend Shared ReadOnly Property SchemaContext() As System.Xaml.XamlSchemaContext
            Get
                Dim xsc As System.Xaml.XamlSchemaContext = Nothing
                If (Not (schemaContextField) Is Nothing) Then
                    xsc = CType(schemaContextField.Target,System.Xaml.XamlSchemaContext)
                    If (Not (xsc) Is Nothing) Then
                        Return xsc
                    End If
                End If
                If (AssemblyList.Count > 0) Then
                    xsc = New System.Xaml.XamlSchemaContext(AssemblyList)
                Else
                    xsc = New System.Xaml.XamlSchemaContext()
                End If
                schemaContextField = New System.WeakReference(xsc)
                Return xsc
            End Get
        End Property
        
        Friend Shared ReadOnly Property AssemblyList() As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
            Get
                If (assemblyListField Is Nothing) Then
                    assemblyListField = LoadAssemblies
                End If
                Return assemblyListField
            End Get
        End Property
        
        Private Shared Function LoadAssemblies() As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
            Dim assemblyList As System.Collections.Generic.IList(Of System.Reflection.[Assembly]) = New System.Collections.Generic.List(Of System.Reflection.[Assembly])()
            assemblyList.Add(Load("Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"))
            assemblyList.Add(Load("PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e"& _ 
                        "35"))
            assemblyList.Add(Load("PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856a"& _ 
                        "d364e35"))
            assemblyList.Add(Load("System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11"& _ 
                        "d50a3a"))
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b"& _ 
                        "77a5c561934e089"))
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"& _ 
                        ""))
            assemblyList.Add(Load("System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856a"& _ 
                        "d364e35"))
            assemblyList.Add(Load("System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619"& _ 
                        "34e089"))
            assemblyList.Add(Load("System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08"& _ 
                        "9"))
            assemblyList.Add(Load("UIAutomationProvider, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad"& _ 
                        "364e35"))
            assemblyList.Add(Load("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"))
            assemblyList.Add(Load("WindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf385"& _ 
                        "6ad364e35"))
            assemblyList.Add(Load("BPL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("EntityFramework, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08"& _ 
                        "9"))
            assemblyList.Add(Load("Microsoft.Office.Interop.Excel, Version=14.0.0.0, Culture=neutral, PublicKeyToken"& _ 
                        "=71e9bce111e9429c"))
            assemblyList.Add(Load("Microsoft.Office.Tools.Common, Version=10.0.0.0, Culture=neutral, PublicKeyToken="& _ 
                        "b03f5f7f11d50a3a"))
            assemblyList.Add(Load("Microsoft.Office.Tools.Common.v4.0.Utilities, Version=10.0.0.0, Culture=neutral, "& _ 
                        "PublicKeyToken=b03f5f7f11d50a3a"))
            assemblyList.Add(Load("Microsoft.Office.Tools, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7"& _ 
                        "f11d50a3a"))
            assemblyList.Add(Load("Microsoft.Office.Tools.Excel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b"& _ 
                        "03f5f7f11d50a3a"))
            assemblyList.Add(Load("Microsoft.Office.Tools.v4.0.Framework, Version=10.0.0.0, Culture=neutral, PublicK"& _ 
                        "eyToken=b03f5f7f11d50a3a"))
            assemblyList.Add(Load("Microsoft.VisualStudio.Tools.Applications.Runtime, Version=10.0.0.0, Culture=neut"& _ 
                        "ral, PublicKeyToken=b03f5f7f11d50a3a"))
            assemblyList.Add(Load("MouseKeyboardActivityMonitor, Version=3.0.1.9579, Culture=neutral, PublicKeyToken"& _ 
                        "=null"))
            assemblyList.Add(Load("office, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c"))
            assemblyList.Add(Load("SapExlBPL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("SelectionPane, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("SQLDataHandler, Version=1.0.4674.14442, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"))
            assemblyList.Add(Load("Interop.ADODB, Version=6.1.0.0, Culture=neutral, PublicKeyToken=null"))
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly)
            Return assemblyList
        End Function
        
        Private Shared Function Load(ByVal assemblyNameVal As String) As System.Reflection.[Assembly]
            Dim assemblyName As System.Reflection.AssemblyName = New System.Reflection.AssemblyName(assemblyNameVal)
            Dim publicKeyToken() As Byte = assemblyName.GetPublicKeyToken
            Dim asm As System.Reflection.[Assembly] = Nothing
            Try 
                asm = System.Reflection.Assembly.Load(assemblyName.FullName)
            Catch __exception As System.Exception
                Dim shortName As System.Reflection.AssemblyName = New System.Reflection.AssemblyName(assemblyName.Name)
                If (Not (publicKeyToken) Is Nothing) Then
                    shortName.SetPublicKeyToken(publicKeyToken)
                End If
                asm = System.Reflection.Assembly.Load(shortName)
            End Try
            Return asm
        End Function
    End Class
End Namespace