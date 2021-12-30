Public Class Alunos
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
    Private Sub Alunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load = New AlunosController
        load.load()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New AlunosController
        cadastrar.cadastrar(MetroTextBox2.Text, MetroTextBox3.Text, MetroTextBox4.Text, MetroTextBox5.Text, MetroCheckBox1.Checked, MetroTextBox7.Text)
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Alunos.ActiveForm.Close()
    End Sub
End Class