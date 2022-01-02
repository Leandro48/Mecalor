Public Class Materias
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
    Private Sub Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TB_MATERIAS_LISTARTableAdapter1.Fill(Me.DB_ESCOLADataSet1.TB_MATERIAS_LISTAR)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New MateriasController
        cadastrar.cadastrar(MetroTextBox2.Text)
        GroupBox1.Visible = False
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Materias.ActiveForm.Close()
    End Sub

    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        GroupBox1.Visible = True
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        MetroTextBox1.Text = row.Cells(0).Value.ToString()
        MetroTextBox2.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim excluir = New MateriasController
        excluir.deletar(MetroTextBox1.Text)
        GroupBox1.Visible = False
    End Sub
End Class