Imports DTO
Public Interface ILogin(Of T)

    Function ExibirTodos() As DataTable
    Function Exibir() As List(Of T)
    Sub Incluir(ByVal obj As T)
    Sub Alterar(ByVal obj As T)
    Sub Excluir(ByVal obj As T)
    Function Consultar(ByVal Nome As String) As DataTable
    Function ConsultarPorID(ByVal id As Integer) As DataTable
    Function GetLoginID(ByVal id As Integer) As Login

End Interface
