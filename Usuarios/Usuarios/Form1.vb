Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

    Dim comandoSql As SqlCommand
    Dim lectrorSql As SqlDataReader
    Dim sentenciaSql As String
    Dim respuesta As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sentenciaSql = "select name from sysdatabases order by name"
        conectar()
        comandoSql = New SqlCommand(sentenciaSql, conexion)
        lectrorSql = comandoSql.ExecuteReader
        While lectrorSql.Read
            cmbBasesDeDatos.Items.Add(lectrorSql(0))
        End While
        conexion.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text
        basededatos = cmbBasesDeDatos.SelectedItem

        Try

            conectar_usuario()

            MsgBox("Bienvenido")
            Permisos.Show()
            Me.Hide()

        Catch ex As Exception

            MsgBox("No puedes acceder")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Nuevo.Show()
        Me.Hide()


    End Sub
End Class
