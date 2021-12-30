Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class NotasController
    Dim adapter As New OleDbDataAdapter
    Dim sql As New SqlConnection(Conexao.conexao)
    Dim da_sp As SqlDataAdapter
    Public Sub cadastrar(aluno As Integer, materia As Integer, data As Date, nota As Decimal)

        Dim params() As SqlParameter = New SqlParameter() _
        {
            New SqlParameter("@nota_id", SqlDbType.Int) With {.Value = DBNull.Value},
            New SqlParameter("@aluno_id", SqlDbType.Int) With {.Value = aluno},
            New SqlParameter("@materia_id", SqlDbType.Int) With {.Value = materia},
            New SqlParameter("@data", SqlDbType.DateTime) With {.Value = data},
            New SqlParameter("@nota", SqlDbType.Bit) With {.Value = nota}
        }

        Dim command As New SqlCommand()
        command.Connection = sql
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "TB_NOTAS_GRAVAR"

        command.Parameters.AddRange(params)

        sql.Open()

        command.ExecuteNonQuery()

        sql.Close()
    End Sub

    Public Sub load()
        Dim strSQL As String = "TB_NOTAS_LISTAR"
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, sql)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        Notas.DataGridView1.DataSource = table
    End Sub
End Class
