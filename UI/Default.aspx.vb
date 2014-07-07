Imports BLL
Imports DTO

Public Class _Default
    Inherits System.Web.UI.Page

    Dim _clienteBLL As New ClienteBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gvClientes.DataSource = _clienteBLL.ExibirTodos()
            gvClientes.DataBind()
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Dim _cliente As New Cliente
        Dim codigo As Integer = Convert.ToInt32(txtId.Text)
        Try
            _cliente = _clienteBLL.GetClienteId(codigo)
            txtNome.Text = _cliente.nome
            txtEndereco.Text = _cliente.endereco
            txtTelefone.Text = _cliente.telefone
            txtEmail.Text = _cliente.email
            txtObservacao.Text = _cliente.observacao
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim _cliente As New Cliente
        Try
            _cliente.nome = txtNome.Text
            _cliente.endereco = txtEndereco.Text
            _cliente.telefone = txtTelefone.Text
            _cliente.email = txtEmail.Text
            _cliente.observacao = txtObservacao.Text
            _clienteBLL.Incluir(_cliente)
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try

    End Sub

    Protected Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim _cliente As New Cliente
        Try
            _cliente.Id = Convert.ToInt32(txtId.Text)
            _cliente.nome = txtNome.Text
            _cliente.endereco = txtEndereco.Text
            _cliente.telefone = txtTelefone.Text
            _cliente.email = txtEmail.Text
            _cliente.observacao = txtObservacao.Text
            _clienteBLL.Alterar(_cliente)
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim _cliente As New Cliente
        Try
            _cliente.Id = Convert.ToInt32(txtId.Text)
            _clienteBLL.Excluir(_cliente)
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

    End Sub
End Class