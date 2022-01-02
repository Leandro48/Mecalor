Public Class Notas
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TB_NOTAS_LISTARTableAdapter.Fill(Me.DB_ESCOLADataSet.TB_NOTAS_LISTAR)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New NotasController
        cadastrar.cadastrar(MetroTextBox2.Text, MetroTextBox3.Text, MetroTextBox4.Text, MetroTextBox5.Text)
        GroupBox1.Visible = False
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Notas.ActiveForm.Close()
    End Sub

    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        GroupBox1.Visible = True
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        MetroTextBox1.Text = row.Cells(0).Value.ToString()
        MetroTextBox2.Text = row.Cells(1).Value.ToString()
        MetroTextBox3.Text = row.Cells(2).Value.ToString()
        MetroTextBox4.Text = row.Cells(3).Value.ToString()
        MetroTextBox5.Text = row.Cells(4).Value.ToString()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim excluir = New NotasController
        excluir.deletar(MetroTextBox1.Text)
        GroupBox1.Visible = False
    End Sub
End Class