Public Class Atividade_04
    Private Sub Atividade_04_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sp, rj, mg, es, outros As Double

        ' Validação com TryParse
        If Not Double.TryParse(TextBox1.Text, sp) Then sp = 0
        If Not Double.TryParse(TextBox2.Text, rj) Then rj = 0
        If Not Double.TryParse(TextBox3.Text, mg) Then mg = 0
        If Not Double.TryParse(TextBox4.Text, es) Then es = 0
        If Not Double.TryParse(TextBox5.Text, outros) Then outros = 0

        ' Cria o dicionário com os valores
        Dim estados As New Dictionary(Of String, Double) From {
            {"SP", sp},
            {"RJ", rj},
            {"MG", mg},
            {"ES", es},
            {"Outros", outros}
        }

        Dim total = estados.Values.Sum()

        If total = 0 Then
            MessageBox.Show("O valor total não pode ser zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Calcula e exibe os percentuais
        sp_label.Text = "SP: " & Math.Round((sp / total) * 100, 2).ToString() & "%"
        rj_label.Text = "RJ: " & Math.Round((rj / total) * 100, 2).ToString() & "%"
        mg_label.Text = "MG: " & Math.Round((mg / total) * 100, 2).ToString() & "%"
        es_label.Text = "ES: " & Math.Round((es / total) * 100, 2).ToString() & "%"
        outros_label.Text = "Outros: " & Math.Round((outros / total) * 100, 2).ToString() & "%"
    End Sub

End Class