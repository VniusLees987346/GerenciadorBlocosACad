Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.DatabaseServices

Public Class Class1

    <CommandMethod("ChamTelaSimbolos")> Public Sub ChamTelaSimbolos()
        Dim TelaSimbolos As New TelaSimbolos
        TelaSimbolos.Show()
    End Sub
    <CommandMethod("ChamTelaClasse")> Public Sub ChamTelaClasse()
        Dim TelaClasse As New TelaClasse
        TelaClasse.Show()
    End Sub
    <CommandMethod("ChamTelaNatureza")> Public Sub ChamTelaNatureza()
        Dim TelaNatureza As New TelaNatureza
        TelaNatureza.Show()
    End Sub
    <CommandMethod("ChamTelaDesenhaSim")> Public Sub ChamTelaDesenhaSim()
        Dim DesenhaSim As New DesenhaSimbolo
        DesenhaSim.Show()
    End Sub

End Class
