Imports System.Data.SqlClient

Public Class MateriasController
    Dim sql As New SqlConnection(Conexao.conexao)
    Public Sub cadastrar(nome As String)

        Dim params() As SqlParameter = New SqlParameter() _
        {
            New SqlParameter("@materia_id", SqlDbType.Int) With {.Value = DBNull.Value},
            New SqlParameter("@materia_nome", SqlDbType.VarChar) With {.Value = nome}
        }

        Dim command As New SqlCommand()
        command.Connection = sql
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "TB_MATERIAS_GRAVAR"

        command.Parameters.AddRange(params)

        sql.Open()

        command.ExecuteNonQuery()

        sql.Close()
    End Sub
    Public Sub load()
        Dim strSQL As String = "TB_MATERIAS_LISTAR"
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, sql)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        Materias.DataGridView1.DataSource = table
    End Sub
End Class
