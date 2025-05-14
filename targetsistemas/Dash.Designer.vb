<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dash))
        MenuStrip1 = New MenuStrip()
        ATIVIDADE01ToolStripMenuItem = New ToolStripMenuItem()
        ATIVIDADE02ToolStripMenuItem = New ToolStripMenuItem()
        ATIVIDADE03ToolStripMenuItem = New ToolStripMenuItem()
        ATIVIDADE03ToolStripMenuItem1 = New ToolStripMenuItem()
        ATIVIDADE05ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ATIVIDADE01ToolStripMenuItem, ATIVIDADE02ToolStripMenuItem, ATIVIDADE03ToolStripMenuItem, ATIVIDADE03ToolStripMenuItem1, ATIVIDADE05ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(567, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ATIVIDADE01ToolStripMenuItem
        ' 
        ATIVIDADE01ToolStripMenuItem.Name = "ATIVIDADE01ToolStripMenuItem"
        ATIVIDADE01ToolStripMenuItem.Size = New Size(93, 20)
        ATIVIDADE01ToolStripMenuItem.Text = "ATIVIDADE_01"
        ' 
        ' ATIVIDADE02ToolStripMenuItem
        ' 
        ATIVIDADE02ToolStripMenuItem.Name = "ATIVIDADE02ToolStripMenuItem"
        ATIVIDADE02ToolStripMenuItem.Size = New Size(93, 20)
        ATIVIDADE02ToolStripMenuItem.Text = "ATIVIDADE_02"
        ' 
        ' ATIVIDADE03ToolStripMenuItem
        ' 
        ATIVIDADE03ToolStripMenuItem.Name = "ATIVIDADE03ToolStripMenuItem"
        ATIVIDADE03ToolStripMenuItem.Size = New Size(93, 20)
        ATIVIDADE03ToolStripMenuItem.Text = "ATIVIDADE_03"
        ' 
        ' ATIVIDADE03ToolStripMenuItem1
        ' 
        ATIVIDADE03ToolStripMenuItem1.Name = "ATIVIDADE03ToolStripMenuItem1"
        ATIVIDADE03ToolStripMenuItem1.Size = New Size(93, 20)
        ATIVIDADE03ToolStripMenuItem1.Text = "ATIVIDADE_04"
        ' 
        ' ATIVIDADE05ToolStripMenuItem
        ' 
        ATIVIDADE05ToolStripMenuItem.Name = "ATIVIDADE05ToolStripMenuItem"
        ATIVIDADE05ToolStripMenuItem.Size = New Size(93, 20)
        ATIVIDADE05ToolStripMenuItem.Text = "ATIVIDADE_05"
        ' 
        ' Dash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(49), CByte(51))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(567, 333)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Dash"
        Text = "Target Sistemas - PROCESSO SELETIVO"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ATIVIDADE01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATIVIDADE02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATIVIDADE03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATIVIDADE03ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ATIVIDADE05ToolStripMenuItem As ToolStripMenuItem
End Class
