Imports System.Data.SqlClient

Public Class CursosController
    Dim sql As New SqlConnection(Conexao.conexao)
    Public Sub cadastrar(nome As String)

        Dim params() As SqlParameter = New SqlParameter() _
        {
            New SqlParameter("@curso_id", SqlDbType.Int) With {.Value = DBNull.Value},
            New SqlParameter("@curso_nome", SqlDbType.VarChar) With {.Value = nome}
        }

        Dim command As New SqlCommand()
        command.Connection = sql
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "TB_CURSOS_GRAVAR"

        command.Parameters.AddRange(params)

        sql.Open()

        command.ExecuteNonQuery()

        sql.Close()
    End Sub

    Public Sub deletar(curso_id As Integer)
        Dim params() As SqlParameter = New SqlParameter() _
        {
            New SqlParameter("@curso_id", SqlDbType.Int) With {.Value = curso_id}
        }

        Dim command As New SqlCommand()
        command.Connection = sql
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "TB_CURSOS_DELETE"

        command.Parameters.AddRange(params)

        sql.Open()

        command.ExecuteNonQuery()

        sql.Close()

    End Sub

    Public Sub load()
        Dim strSQL As String = "TB_CURSOS_LISTAR"
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, sql)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        Notas.DataGridView1.DataSource = table
    End Sub
End Class
