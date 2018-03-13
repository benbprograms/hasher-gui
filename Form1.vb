Imports System.Threading.Thread
Public Class Form1

    Private Sub hash_Click(sender As System.Object, e As System.EventArgs) Handles hash.Click
        vars.tobehash = input.Text
        vars.hash = hasher.GetHash(vars.tobehash)
        While Not wait.Value = wait.Maximum
            wait.Value += 5
            Sleep(100)
            output.Text = vars.hash
        End While
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        MsgBox("this program will hash using MD5" & vbNewLine & "MD5 is no longer considered secure!", MsgBoxStyle.Information, IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))
        Me.Show()
    End Sub

    Private Sub wait_Click(sender As System.Object, e As System.EventArgs) Handles wait.Click

    End Sub
End Class
