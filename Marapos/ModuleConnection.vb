Imports System.Data.SqlClient

Module ModuleConnection
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Cmd As SqlCommand
    Public Dr As SqlDataReader

    Public Sub Connection()
        Conn = New SqlConnection("data source=DELL; initial catalog=DbMarapos; integrated security=true")
        Conn.Open()
    End Sub

End Module
