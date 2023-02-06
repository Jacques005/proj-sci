Imports System.Net.Security

Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            picChoc.Visible = True
        ElseIf ListBox1.SelectedIndex = 0 = False Then
            picChoc.Visible = False
        End If

        If ListBox1.SelectedIndex = 1 Then
            picV.Visible = True
        ElseIf ListBox1.SelectedIndex = 1 = False Then
            picV.Visible = False
        End If

        If ListBox1.SelectedIndex = 2 Then
            picM.Visible = True
        ElseIf ListBox1.SelectedIndex = 2 = False Then
            picM.Visible = False
        End If

        If ListBox1.SelectedIndex = 3 Then
            picS.Visible = True
        ElseIf ListBox1.SelectedIndex = 3 = False Then
            picS.Visible = False
        End If

        If ListBox1.SelectedIndex = 4 Then
            picC.Visible = True
        ElseIf ListBox1.SelectedIndex = 4 = False Then
            picC.Visible = False
        End If
    End Sub
End Class
