Imports Autodesk.AutoCAD.Interop
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Runtime

Public Class FuncoesLisp
    Private Shared user As String

    Property NomeSim() As String
        Get
            NomeSim = user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    <LispFunction("CriaSimbolo_BlocoEx")> _
    Function CriaSimbolo_BlocoEx(ByVal rsB As ResultBuffer) As ResultBuffer
        Dim acdApp As AcadApplication
        Dim acdDcm As AcadDocument
        Dim path As New PathControle
        acdApp = New AcadApplication
        acdApp.Visible = True
        acdDcm = acdApp.ActiveDocument
        acdDcm.SetVariable("users3", path.RetPathApp)
        Dim caminho As String
        Dim rbfReturn As New ResultBuffer
        Try
            acdDcm.SendCommand("(setq oldsdi (getvar ""sdi"" ))" & vbCr)
            acdDcm.SendCommand("(setvar ""sdi"" 1 )" & vbCr)
            Dim arrNetAssemblyFile As TypedValue() = rsB.AsArray()
            caminho = arrNetAssemblyFile(0).Value.ToString
            caminho = Replace(caminho, "\", "/")
            acdDcm.SendCommand("(command ""open"" " & Chr(34) & caminho & Chr(34) & " )" & vbCr)
            acdDcm.SendCommand("(load " & Chr(34) & path.RetPathApp & "/G/GB.vlx" & Chr(34) & " ) " & vbCr)
            acdDcm.SetVariable("users3", path.RetPathApp)
            acdDcm.SetVariable("users1", user)
            acdDcm.SendCommand("(criaBlocoSimboloEx)" & vbCr)
            acdDcm.SendCommand("(setvar ""sdi"" oldsdi )" & vbCr)
            acdDcm.SendCommand("(command ""qsave"" )" & vbCr)
            acdApp.Quit()
            ValidaRefAcad()
            Return Nothing
        Catch
            rbfReturn.Add(New TypedValue(&H138D, "Catch Error"))
            Return Nothing
        End Try

    End Function


End Class
