Imports System.Data.SqlClient

Public Class Form1


    Dim conexionSQL As SqlConnection
    Dim comandoSQL As SqlCommand
    Dim lecturaSQL As SqlDataReader
    Dim adapatadorSQL As SqlDataAdapter
    Dim tablaSQL As DataTable
    Dim sentenciaSQL As String
    Dim respuestaSQL As Integer
    Dim idEmpleado As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sentenciaSQL = "select cveEmpleado from empleados"
        conectar()
        comandoSQL = New SqlCommand(sentenciaSQL, conexionSQL)
        lecturaSQL = comandoSQL.ExecuteReader
        While lecturaSQL.Read
            cmbEmpleado.Items.Add(lecturaSQL(0))
        End While
        conexionSQL.Close()
    End Sub

    Public Sub conectar()
        conexionSQL = New SqlConnection
        conexionSQL.ConnectionString = "server=DESKTOP-B9ESO0B;database = ISR;integrated security = true"
        conexionSQL.Open()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        idEmpleado = cmbEmpleado.SelectedItem
        sentenciaSQL = "sp_ISR_3 '" + idEmpleado + "'"
        tablaSQL = New DataTable
        adapatadorSQL = New SqlDataAdapter(sentenciaSQL, conexionSQL)
        adapatadorSQL.Fill(tablaSQL)
        dgvRegistroISR.DataSource = tablaSQL
        conexionSQL.Close()

    End Sub
End Class
