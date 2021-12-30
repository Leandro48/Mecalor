Public Class Form1
    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasToolStripMenuItem.Click
        Dim Materias As New Materias
        Materias.MdiParent = Me
        Materias.Show()
    End Sub

    Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click
        Dim Cursos As New Cursos
        Cursos.MdiParent = Me
        Cursos.Show()
    End Sub

    Private Sub AlunosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem.Click
        Dim Alunos As New Alunos
        Alunos.MdiParent = Me
        Alunos.Show()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        Dim Notas As New Notas
        Notas.MdiParent = Me
        Notas.Show()
    End Sub
End Class
