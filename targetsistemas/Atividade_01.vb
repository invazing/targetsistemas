Public Class Atividade_01
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim INDICE As Integer = 13
        Dim SOMA As Integer = 0
        Dim K As Integer = 0

        While K < INDICE
            K += 1
            SOMA += K
        End While

        MsgBox("RESULTADO É: " + SOMA.ToString, MsgBoxStyle.Information, Title:="RESPOSTA DA QUESTÃO")
    End Sub
End Class