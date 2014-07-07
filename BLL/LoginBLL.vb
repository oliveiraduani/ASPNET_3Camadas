Imports DAL
Imports DTO

Public Class LoginBLL
    Implements ILogin(Of Login)

    Public Sub Alterar(oLogin As Login) Implements ILogin(Of Login).Alterar
        Dim sql As String = ""
        Try
            Dim parametrosNomes(6) As String
            parametrosNomes(0) = "@Id"
            parametrosNomes(1) = "@Nome"
            parametrosNomes(2) = "@Sobrenome"
            parametrosNomes(3) = "@Login"
            parametrosNomes(4) = "@Senha"
            parametrosNomes(5) = "@Nivel_acesso"

            Dim parametrosValores(6) As String
            parametrosValores(0) = oLogin.Id
            parametrosValores(1) = oLogin.Nome
            parametrosValores(2) = oLogin.Sobrenome
            parametrosValores(3) = oLogin.Login
            parametrosValores(4) = oLogin.Senha
            parametrosValores(5) = oLogin.NivelAcesso

            sql = "UPDATE Clientes SET Nome=@Nome, sobrenome=@Sobrenome, login=@Login, senha=@Senha, nivel_acesso=@Nivel_acesso WHERE id=@id"
            AcessoDB.CRUD(sql, parametrosNomes, parametrosValores)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Consultar(Nome As String) As DataTable Implements ILogin(Of Login).Consultar
        Dim sql As String = "SELECT id,nome,sobrenome,login,senha,nivel_acesso FROM Login WHERE Nome LIKE '" & Nome & "%'" & "ORDER BY Nome"
        Try
            Return AcessoDB.GetDataTable(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarPorID(id As Integer) As DataTable Implements ILogin(Of Login).ConsultarPorID
        Dim sql As String = "SELECT id,nome,sobrenome,login,senha,nivel_acesso FROM Login WHERE id = " & id
        Try
            Return AcessoDB.GetDataTable(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetLogin(ByVal tabela As DataTable) As Login
        Try
            Dim _login As New Login
            If tabela.Rows.Count > 0 Then
                _login.Id = tabela.Rows(0).Item(0)
                _login.Nome = tabela.Rows(0).Item(1)
                _login.Sobrenome = tabela.Rows(0).Item(2)
                _login.Login = tabela.Rows(0).Item(3)
                _login.Senha = tabela.Rows(0).Item(4)
                _login.NivelAcesso = tabela.Rows(0).Item(5)
                Return _login
            Else
                _login = Nothing
                Return _login
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetListaLogin(ByVal tabela As DataTable) As List(Of Login)
        Try
            Dim listaLogin As New List(Of Login)
            Dim i As Integer = 0
            Dim registros = tabela.Rows.Count

            If registros > 0 Then

                For Each drRow As DataRow In tabela.Rows
                    Dim _login As New Login
                    _login.Id = tabela.Rows(i).Item(0)
                    _login.Nome = tabela.Rows(i).Item(1)
                    _login.Sobrenome = tabela.Rows(i).Item(2)
                    _login.Login = tabela.Rows(i).Item(3)
                    _login.Senha = tabela.Rows(i).Item(4)
                    _login.NivelAcesso = tabela.Rows(i).Item(5)
                    listaLogin.Add(_login)
                Next

                Return listaLogin
            Else
                listaLogin = Nothing
                Return listaLogin
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Excluir(oLogin As Login) Implements ILogin(Of Login).Excluir
        Dim sql As String = ""
        Try
            Dim parametrosNomes(0) As String
            parametrosNomes(0) = "@Login"

            Dim parametrosValores(0) As String
            parametrosValores(0) = oLogin.Id

            sql = "DELETE FROM Login WHERE id=@Id"
            AcessoDB.CRUD(sql, parametrosNomes, parametrosValores)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Exibir() As List(Of Login) Implements ILogin(Of Login).Exibir
        Try
            Dim sql As String = "SELECT * FROM Login"
            Dim tabela As New DataTable
            tabela = AcessoDB.GetDataTable(sql)
            Return GetListaLogin(tabela)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExibirTodos() As DataTable Implements ILogin(Of Login).ExibirTodos
        Dim sql As String = "SELECT * FROM Login"
        Try
            Return AcessoDB.GetDataTable(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetLoginID(id As Integer) As Login Implements ILogin(Of Login).GetLoginID
        Try
            Dim sql As String = "SELECT id,nome,sobrenome,login,senha,nivel_acesso FROM Login WHERE id = " & id
            Dim tabela As New DataTable
            tabela = AcessoDB.GetDataTable(sql)
            Return GetLogin(tabela)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Incluir(oLogin As Login) Implements ILogin(Of Login).Incluir
        Dim sql As String = ""
        Try
            Dim parametrosNomes(5) As String
            parametrosNomes(0) = "@Nome"
            parametrosNomes(1) = "@Sobrenome"
            parametrosNomes(2) = "@Login"
            parametrosNomes(3) = "@Senha"
            parametrosNomes(4) = "@Nivel_acesso"

            Dim parametrosValores(5) As String
            parametrosValores(0) = oLogin.Nome
            parametrosValores(1) = oLogin.Sobrenome
            parametrosValores(2) = oLogin.Login
            parametrosValores(3) = oLogin.Senha
            parametrosValores(4) = oLogin.NivelAcesso

            sql = "INSERT INTO Login(nome,sobrenome,login,senha,nivel_acesso) VALUES (@Nome,@Sobrenome,@Login,@Senha,@Nivel_acesso)"
            AcessoDB.CRUD(sql, parametrosNomes, parametrosValores)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
