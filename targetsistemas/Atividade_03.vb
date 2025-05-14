Imports System.IO
Imports Newtonsoft.Json
Imports System.Linq

Public Class Atividade_03

    ' variaveis_publicas
    Dim dia As Integer
    Dim valor As Double
    Dim caminhoArquivo As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            caminhoArquivo = OpenFileDialog1.FileName
        End If

        If Not File.Exists(caminhoArquivo) Then
            MessageBox.Show("Arquivo não encontrado.")
            Return
        End If

        Dim json As String = File.ReadAllText(caminhoArquivo)
        Dim dados = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(json)
        Dim valoresValidos As New List(Of Double)

        For Each item In dados
            Dim valor As Double = Convert.ToDouble(item("valor"))
            If valor > 0 Then
                valoresValidos.Add(valor)
            End If
        Next

        Dim menorValor = valoresValidos.Min()
        Dim maiorValor = valoresValidos.Max()
        Dim media = valoresValidos.Average()

        ' Dias acima da Media está em desenvolvimento
        Dim resultado As String = "===== RELATÓRIO =====" & vbCrLf &
            "Menor faturamento: R$ " & menorValor.ToString("F2") & vbCrLf &
            "Maior faturamento: R$ " & maiorValor.ToString("F2") & vbCrLf &
            "Dias acima da média: " & vbCrLf &
            "====================="


        MessageBox.Show(resultado, "Resultado")

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class
