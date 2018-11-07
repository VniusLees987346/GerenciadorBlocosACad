Imports Autodesk.AutoCAD.Interop


Public Class initialize
    Dim acd As AcadApplication
    Private Sub initialize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        acd = New AcadApplication
        acd.Visible = True

        CarregarLisps()
        CarregarNet()
        CarregarMenus()

        Me.Dispose()
    End Sub

    Public Sub CarregarLisps()

        Dim LispFile As String = RetornaCaminho() & "/G/Load/AppLoad.LSP"
        Dim Cmd As String = "(load" & Chr(34) & LispFile & Chr(34) & ")" & vbCr
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SetVariable("users3", RetornaCaminho())
        TDwg.SendCommand(Cmd)

    End Sub
    Public Sub CarregarNet()

        Dim NetFile As String = RetornaCaminho() & "/Gerenciador de Blocos"
        Dim Cmd As String = "(Command  " & Chr(34) & "netload" & Chr(34) & " " & Chr(34) & NetFile & Chr(34) & ")" & vbCr
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SendCommand(Cmd)

    End Sub
    Public Sub CarregarMenus()

        Dim MenuFile As String = RetornaCaminho() & "/G/Load/Menus Gerenciador de Blocos.cuix"
        Dim Cmd As String = "(MenuLoad_" & Chr(34) & MenuFile & Chr(34) & ")" & vbCr
        Dim TDwg As AcadDocument
        TDwg = acd.ActiveDocument
        TDwg.SendCommand(Cmd)

    End Sub

    Public Function RetornaCaminho()
        Dim cam As String = Application.StartupPath
        If cam Like "*\" Then
            Dim tamanho As Integer = Len(cam) - 1
            cam = Mid(cam, 1, tamanho)
        End If
        Dim camTratado As String =  Replace(cam, "\", "/")
        Return camTratado
    End Function

End Class
