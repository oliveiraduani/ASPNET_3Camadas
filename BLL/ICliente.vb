Imports DTO

Public Interface ICliente(Of T)

    Function ExibirTodos() As DataTable
    Function Exibir() As List(Of T)
    Sub Incluir(ByVal obj As T)
    Sub Alterar(ByVal obj As T)
    Sub Excluir(ByVal obj As T)
    Function Consultar(ByVal nome As String) As DataTable
    Function ConsultarPorID(ByVal id As Integer) As DataTable
    Function GetClienteId(ByVal id As Integer) As Cliente

End Interface
