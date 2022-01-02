Public Class Alunos
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub
    Private Sub Alunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TB_ALUNOS_LISTARTableAdapter1.Fill(Me.DB_ESCOLADataSet1.TB_ALUNOS_LISTAR)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim cadastrar = New AlunosController
        cadastrar.cadastrar(MetroTextBox2.Text, MetroTextBox3.Text, MetroTextBox4.Text, MetroTextBox5.Text, MetroCheckBox1.Checked, MetroTextBox7.Text)
        GroupBox1.Visible = False
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Alunos.ActiveForm.Close()
    End Sub
    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        GroupBox1.Visible = True
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        MetroTextBox1.Text = row.Cells(0).Value.ToString()
        MetroTextBox2.Text = row.Cells(1).Value.ToString()
        MetroTextBox3.Text = row.Cells(2).Value.ToString()
        MetroTextBox4.Text = row.Cells(3).Value.ToString()
        MetroTextBox5.Text = row.Cells(4).Value.ToString()
        MetroCheckBox1.Checked = row.Cells(5).Value
        MetroTextBox7.Text = row.Cells(6).Value.ToString()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim excluir = New AlunosController
        excluir.deletar(MetroTextBox1.Text)
        GroupBox1.Visible = False
    End Sub

End Class