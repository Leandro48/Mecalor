Public Class Notas
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load = New NotasController
        load.load()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New NotasController
        cadastrar.cadastrar(MetroTextBox2.Text, MetroTextBox3.Text, MetroTextBox4.Text, MetroTextBox5.Text)
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Notas.ActiveForm.Close()
    End Sub
End Class