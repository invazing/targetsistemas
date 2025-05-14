<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atividade_04
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Atividade_04))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        sp_label = New Label()
        rj_label = New Label()
        mg_label = New Label()
        es_label = New Label()
        outros_label = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(229, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "RESPOSTA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(516, 135)
        Label1.TabIndex = 1
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 15)
        Label2.TabIndex = 2
        Label2.Text = "SP"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(215, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        TextBox1.Text = "67836.43"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(189, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 15)
        Label3.TabIndex = 4
        Label3.Text = "RJ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(189, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 15)
        Label4.TabIndex = 5
        Label4.Text = "MG"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(189, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 15)
        Label5.TabIndex = 6
        Label5.Text = "ES"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(215, 188)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        TextBox2.Text = "36678.66"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(215, 217)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        TextBox3.Text = "29229.88"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(215, 246)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 9
        TextBox4.Text = "27165.48"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(154, 278)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 10
        Label6.Text = "OUTROS"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(215, 275)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 11
        TextBox5.Text = "19849.53"
        ' 
        ' sp_label
        ' 
        sp_label.AutoSize = True
        sp_label.Location = New Point(338, 162)
        sp_label.Name = "sp_label"
        sp_label.Size = New Size(12, 15)
        sp_label.TabIndex = 12
        sp_label.Text = "*"
        ' 
        ' rj_label
        ' 
        rj_label.AutoSize = True
        rj_label.Location = New Point(338, 191)
        rj_label.Name = "rj_label"
        rj_label.Size = New Size(12, 15)
        rj_label.TabIndex = 13
        rj_label.Text = "*"
        ' 
        ' mg_label
        ' 
        mg_label.AutoSize = True
        mg_label.Location = New Point(338, 220)
        mg_label.Name = "mg_label"
        mg_label.Size = New Size(12, 15)
        mg_label.TabIndex = 14
        mg_label.Text = "*"
        ' 
        ' es_label
        ' 
        es_label.AutoSize = True
        es_label.Location = New Point(338, 249)
        es_label.Name = "es_label"
        es_label.Size = New Size(12, 15)
        es_label.TabIndex = 15
        es_label.Text = "*"
        ' 
        ' outros_label
        ' 
        outros_label.AutoSize = True
        outros_label.Location = New Point(338, 278)
        outros_label.Name = "outros_label"
        outros_label.Size = New Size(12, 15)
        outros_label.TabIndex = 16
        outros_label.Text = "*"
        ' 
        ' Atividade_04
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(543, 350)
        Controls.Add(outros_label)
        Controls.Add(es_label)
        Controls.Add(mg_label)
        Controls.Add(rj_label)
        Controls.Add(sp_label)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Atividade_04"
        Text = "Atividade_04"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents sp_label As Label
    Friend WithEvents rj_label As Label
    Friend WithEvents mg_label As Label
    Friend WithEvents es_label As Label
    Friend WithEvents outros_label As Label
End Class
