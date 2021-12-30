Public Class Materias
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
    Private Sub Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load = New MateriasController
        load.load()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New MateriasController
        cadastrar.cadastrar(MetroTextBox2.Text)
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Materias.ActiveForm.Close()
    End Sub
End Class