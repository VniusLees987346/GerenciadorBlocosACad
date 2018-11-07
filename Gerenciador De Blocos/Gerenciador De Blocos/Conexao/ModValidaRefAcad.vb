Imports Autodesk.AutoCAD.Interop


Module ModValidaRefAcad
    Public acd As AcadApplication


    Public Sub ValidaRefAcad()
        Try
            acd = GetObject(, "AutoCAD.Application")
        Catch
            acd = CreateObject("AutoCAD.Application")
        End Try
        CarregarLisps()

    End Sub
    Public Sub CarregarLisps()
        Dim path As New PathControle
        Dim LispFile As String = path.RetPathApp & "/G/Load/AppLoad.LSP"
        Dim Cmd As String = "(Load  " & Chr(34) & LispFile & Chr(34) & ")" & vbCr
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SendCommand(Cmd)
        TDwg.SetVariable("users3", path.RetPathApp)
    End Sub
    
End Module
