Module Conexao
    Public Function conexao()
        Dim dbProvider As String = "Data Source=DESKTOP-LEDTEEK;Initial Catalog=DB_ESCOLA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Return dbProvider
    End Function
End Module
