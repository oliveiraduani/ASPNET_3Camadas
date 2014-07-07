Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class AcessoDB
    Private Shared Function GetDbConnection() As SqlConnection
        Try
            Dim conString As String = ConfigurationManager.ConnectionStrings("conexaoClienteSQLServer").ConnectionString
            Dim connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function ExecuteReader(ByVal sql As String) As IDataReader
        Dim reader As IDataReader = Nothing
        Using connection As SqlConnection = GetDbConnection()
            Try
                Using command As New SqlCommand(sql, connection)
                    reader = command.ExecuteReader()
                End Using
            Catch ex As Exception
                Throw
            End Try
            Return reader
        End Using
    End Function
    Public Function ExecuteNonQuery(ByVal sql As String) As Integer
        Dim i As Integer = -1
        Using connection As SqlConnection = GetDbConnection()
            Try
                Using command As New SqlCommand(sql, connection)
                    i = command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw
            End Try
            Return i
        End Using
    End Function
    Public Shared Function ExecuteDataSet(ByVal sql As String) As DataSet
        Dim ds As DataSet = Nothing
        Using connection As SqlConnection = GetDbConnection()
            Try
                Using Command As New SqlCommand(sql, connection)
                    ds = ExecuteDataSet()
                End Using
            Catch ex As Exception
                Throw
            End Try
            Return ds
        End Using
    End Function
    Public Shared Function ExecuteDataSet() As DataSet
        Dim da As SqlDataAdapter = Nothing
        Dim cmd As IDbCommand = New SqlCommand()
        Dim ds As DataSet = Nothing
        Try
            da = New SqlDataAdapter()
            da.SelectCommand = CType(cmd, SqlCommand)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Overloads Shared Function GetDataTable(ByVal sql As String, ByVal parameterNames() As String, ByVal parameterVals() As String) As DataTable
        Using connection As SqlConnection = GetDbConnection()
            Using da As SqlDataAdapter = New SqlDataAdapter(sql, connection)
                Dim table As New DataTable
                FillParameters(da.SelectCommand, parameterNames, parameterVals)
                da.Fill(table)
                Return table
            End Using
        End Using
    End Function
    Public Overloads Shared Function GetDataTable(ByVal sql As String) As DataTable
        Using connection As SqlConnection = GetDbConnection()
            Using da As New SqlDataAdapter(sql, connection)
                Dim table As New DataTable
                da.Fill(table)
                Return table
            End Using
        End Using
    End Function
    Public Shared Function SelectScalar(ByVal sql As String, ByVal parameterNames() As String, ByVal parameterVals() As String) As String
        Using connection As SqlConnection = GetDbConnection()
            Using command As SqlCommand = New SqlCommand(sql, connection)
                FillParameters(command, parameterNames, parameterVals)
                Return CStr(command.ExecuteScalar)
            End Using
        End Using
    End Function
    Public Shared Function SelectScalar(ByVal sql As String) As String
        Using connection As SqlConnection = GetDbConnection()
            Using command As New SqlCommand(sql, connection)
                Return CStr(command.ExecuteScalar)
            End Using
        End Using
    End Function
    Public Shared Function CRUD(ByVal sql As String, ByVal parameterNames() As String, ByVal parameterVals() As String) As Integer
        Try
            Using connection As SqlConnection = GetDbConnection()
                Using command As New SqlCommand(sql, connection)
                    FillParameters(command, parameterNames, parameterVals)
                    Return command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Shared Sub FillParameters(ByVal command As SqlCommand, ByVal parameterNames As String(), ByVal parameterVals As String())
        Try
            If parameterNames IsNot Nothing Then
                For i = 0 To parameterNames.Length - 1
                    command.Parameters.AddWithValue(parameterNames(i), parameterVals(i))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
