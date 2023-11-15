Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1

    Public conexion As SqlConnection
    Public conexion_usuario As SqlConnection

    Public usuario As String
    Public basededatos As String
    Public contraseña As String
    Public tabla As String

    Public Sub conectar()
        conexion = New SqlConnection
        conexion.ConnectionString = "server=DESKTOP-B9ESO0B; database = master; integrated security = true"
        conexion.Open()
    End Sub

    Public Sub conectar_usuario()
        conexion_usuario = New SqlConnection
        conexion_usuario.ConnectionString = "Server=DESKTOP-B9ESO0B;Database=" & basededatos & ";Integrated Security=false;User ID=" & usuario & ";Password=" & contraseña
        conexion_usuario.Open()
    End Sub

End Module
