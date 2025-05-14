Public Class Atividade_05
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String = TextBox1.Text
        Dim invertida As String = ""

        For i As Integer = texto.Length - 1 To 0 Step -1
            invertida &= texto(i)
        Next

        MsgBox("TEXTO INVERTIDO É: " & invertida)
    End Sub

End Class