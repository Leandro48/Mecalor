<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Arquivos = New System.Windows.Forms.MenuStrip()
        Me.ArquivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Arquivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Arquivos
        '
        Me.Arquivos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.Arquivos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivosToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.JanelaToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.Arquivos.Location = New System.Drawing.Point(20, 60)
        Me.Arquivos.Name = "Arquivos"
        Me.Arquivos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Arquivos.Size = New System.Drawing.Size(760, 24)
        Me.Arquivos.TabIndex = 1
        Me.Arquivos.Text = "MenuStrip1"
        '
        'ArquivosToolStripMenuItem
        '
        Me.ArquivosToolStripMenuItem.Name = "ArquivosToolStripMenuItem"
        Me.ArquivosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArquivosToolStripMenuItem.Text = "Arquivos"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriasToolStripMenuItem, Me.CursosToolStripMenuItem, Me.AlunosToolStripMenuItem, Me.NotasToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'JanelaToolStripMenuItem
        '
        Me.JanelaToolStripMenuItem.Name = "JanelaToolStripMenuItem"
        Me.JanelaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.JanelaToolStripMenuItem.Text = "Janela"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MateriasToolStripMenuItem.Text = "Matérias"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'AlunosToolStripMenuItem
        '
        Me.AlunosToolStripMenuItem.Name = "AlunosToolStripMenuItem"
        Me.AlunosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlunosToolStripMenuItem.Text = "Alunos"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NotasToolStripMenuItem.Text = "Notas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Arquivos)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Arquivos
        Me.Name = "Form1"
        Me.Text = "Escola - Mecalor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Arquivos.ResumeLayout(False)
        Me.Arquivos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Arquivos As MenuStrip
    Friend WithEvents ArquivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As ToolStripMenuItem
End Class
