Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class AlunosController
    Dim adapter As New OleDbDataAdapter
    Dim sql As New SqlConnection(Conexao.conexao)
    Dim data_adapter As SqlDataAdapter

    Public Sub cadastrar(matricula As Integer, nome As String, nascimento As Date, cpf As String, ativo As Boolean, curso As Integer)

        Dim params() As SqlParameter = New SqlParameter() _
        {
            New SqlParameter("@aluno_id", SqlDbType.Int) With {.Value = DBNull.Value},
            New SqlParameter("@aluno_matricula", SqlDbType.Int) With {.Value = matricula},
            New SqlParameter("@aluno_nome", SqlDbType.VarChar) With {.Value = nome},
            New SqlParameter("@aluno_dat_nascimento", SqlDbType.DateTime) With {.Value = nascimento},
            New SqlParameter("@aluno_ativo", SqlDbType.Bit) With {.Value = ativo},
            New SqlParameter("@aluno_cpf", SqlDbType.Char) With {.Value = cpf},
            New SqlParameter("@curso_id", SqlDbType.Int) With {.Value = curso}
        }

        Dim command As New SqlCommand()
        command.Connection = sql
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "TB_ALUNOS_GRAVAR"

        command.Parameters.AddRange(params)

        sql.Open()

        command.ExecuteNonQuery()

        sql.Close()
    End Sub

    Public Sub load()
        Dim strSQL As String = "TB_ALUNOS_LISTAR"
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, sql)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        Alunos.DataGridView1.DataSource = table
    End Sub

End Class
