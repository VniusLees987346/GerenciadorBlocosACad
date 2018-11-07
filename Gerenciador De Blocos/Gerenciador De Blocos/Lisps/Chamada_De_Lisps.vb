Imports Autodesk.AutoCAD.Interop

Public Class Chamada_De_Lisps
    
    Public Sub CriaSimbolo(ByVal acdApp As AcadApplication)
        Dim TDwg As AcadDocument
        TDwg = acdApp.ActiveDocument
        TDwg.SendCommand("(CriaSimbolo)" & vbCr)
    End Sub
    Public Sub CriaSimboloEx(ByVal acdApp As AcadApplication)
        Dim TDwg As AcadDocument
        TDwg = acdApp.ActiveDocument
        TDwg.SendCommand("(CriaSimboloEx)" & vbCr)
    End Sub
    Public Sub DesenhaSimbolo(ByVal acdApp As AcadApplication)
        Dim TDwg As AcadDocument
        TDwg = acdApp.ActiveDocument
        TDwg.SendCommand("InsereSimbolo" & vbCr)
    End Sub

End Class
