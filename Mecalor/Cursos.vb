Public Class Cursos
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load = New CursosController
        load.load()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New CursosController
        cadastrar.cadastrar(MetroTextBox2.Text)
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Cursos.ActiveForm.Close()
    End Sub
End Class