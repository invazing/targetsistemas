Public Class Atividade_02
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numero As Integer = TextBox1.Text ' pode ser alterado para testar outros valores
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim pertence As Boolean = False

        While a <= numero
            If a = numero Then
                pertence = True
                Exit While
            End If
            Dim temp = a + b
            a = b
            b = temp
        End While

        If pertence Then
            MsgBox("O número " & numero & " pertence à sequência de Fibonacci.")
        Else
            MsgBox("O número " & numero & " NÃO pertence à sequência de Fibonacci.")
        End If
    End Sub
End Class