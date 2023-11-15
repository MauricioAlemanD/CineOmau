Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Permisos

    Dim comandoSql As SqlCommand
    Dim lectrorSql As SqlDataReader
    Dim sentenciaSql As String
    Dim respuesta As Integer

    Dim id As String
    Dim nombre As String
    Dim apellido1 As String
    Dim apellido2 As String
    Dim edad As String

    Dim accion As String

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        sentenciaSql = "select name from sysdatabases"
        comandoSql = New SqlCommand(sentenciaSql, conexion)
        lectrorSql = comandoSql.ExecuteReader

        While lectrorSql.Read

            cmbBasesDatos.Items.Add(lectrorSql(0))

        End While
        conexion.Close()

    End Sub

    Private Sub cmbBasesDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBasesDatos.SelectedIndexChanged

        cmbTabla.Items.Clear()
        basededatos = cmbBasesDatos.SelectedItem
        sentenciaSql = "use " + basededatos + "; select table_name from information_schema.tables"
        conectar()
        comandoSql = New SqlCommand(sentenciaSql, conexion)
        lectrorSql = comandoSql.ExecuteReader

        While lectrorSql.Read
            cmbTabla.Items.Add(lectrorSql(0))
        End While
        conexion.Close()

        cmbUsuarios.Items.Clear()
        basededatos = cmbBasesDatos.SelectedItem
        sentenciaSql = "use " + basededatos + "; SELECT NAME FROM sysusers WHERE uid < 16384 and uid > 4"
        conectar()
        comandoSql = New SqlCommand(sentenciaSql, conexion)
        lectrorSql = comandoSql.ExecuteReader

        While lectrorSql.Read
            cmbUsuarios.Items.Add(lectrorSql(0))
        End While
        conexion.Close()


    End Sub

    Private Sub cmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedIndexChanged

        contraseña = InputBox("Escribe tu contraseña")

    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try

            tabla = cmbTabla.SelectedItem
            usuario = cmbUsuarios.SelectedItem

            If chbInsert.Checked Then
                sentenciaSql = "USE " + basededatos + ";GRANT INSERT ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbUpdate.Checked Then
                sentenciaSql = "USE " + basededatos + ";GRANT UPDATE ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbDelete.Checked Then
                sentenciaSql = "USE " + basededatos + ";GRANT DELETE ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbSelect.Checked Then
                sentenciaSql = "USE " + basededatos + ";GRANT SELECT ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            MsgBox("Permisos asignados a " + usuario + "en la tabla " + tabla)

        Catch ex As Exception

            MsgBox("Error al asignar permisos" + ex.Message)

        End Try

    End Sub

    Private Sub btnDenegar_Click(sender As Object, e As EventArgs) Handles btnDenegar.Click
        Try

            tabla = cmbTabla.SelectedItem
            usuario = cmbUsuarios.SelectedItem

            If chbInsert.Checked Then
                sentenciaSql = "USE " + basededatos + ";DENY INSERT ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbUpdate.Checked Then
                sentenciaSql = "USE " + basededatos + "; DENY UPDATE ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbDelete.Checked Then
                sentenciaSql = "USE " + basededatos + "; DENY DELETE ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            If chbSelect.Checked Then
                sentenciaSql = "USE " + basededatos + "; DENY SELECT ON [dbo].[" + tabla + "] TO [" + usuario + "] AS [dbo]"
                conectar()
                comandoSql = New SqlCommand(sentenciaSql, conexion)
                respuesta = comandoSql.ExecuteNonQuery
                conexion.Close()
            End If

            MsgBox("Permisos denegados a " + usuario + "en la tabla " + tabla)

        Catch ex As Exception

            MsgBox("Error al denegar permisos" + ex.Message)

        End Try
    End Sub

    '##########################################################'

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            id = txtId.Text
            nombre = UCase(txtNombre.Text)
            apellido1 = UCase(txtApellido1.Text)
            apellido2 = UCase(txtApellido2.Text)
            edad = txtEdad.Text

            If accion = "nuevo" Then

                conectar_usuario()
                sentenciaSql = "use Alumnos; insert into datos values ('" + id + "','" + nombre + "','" + apellido1 + "','" + apellido2 + "','" + edad + "')"
                comandoSql = New SqlCommand(sentenciaSql, conexion_usuario)
                respuesta = comandoSql.ExecuteNonQuery
                conexion_usuario.Close()

                MsgBox("Registro guardado")

            End If

            If accion = "editar" Then
                conectar_usuario()
                sentenciaSql = "use Alumnos; update datos SET nombre = '" + txtNombre.Text + "', apellido1 = '" + txtApellido1.Text + "', apellido2 = '" + txtApellido2.Text + "', edad = '" + txtEdad.Text + "' WHERE id = '" + txtId.Text + "'"
                comandoSql = New SqlCommand(sentenciaSql, conexion_usuario)
                respuesta = comandoSql.ExecuteNonQuery
                conexion_usuario.Close()
                MsgBox("Registro editado")

            End If

            txtId.Enabled = False
            txtNombre.Enabled = False
            txtApellido1.Enabled = False
            txtApellido2.Enabled = False
            txtEdad.Enabled = False
        Catch ex As Exception

            MsgBox("No se ha podido acceder a la tabla, no tienes permisos")

        End Try


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = "nuevo"
        txtId.Clear()
        txtNombre.Clear()
        txtApellido1.Clear()
        txtApellido2.Clear()
        txtEdad.Clear()

        txtId.Enabled = True
        txtNombre.Enabled = True
        txtApellido1.Enabled = True
        txtApellido2.Enabled = True
        txtEdad.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try

            id = InputBox("Escribe el ID a buscar ")
            sentenciaSql = "use Alumnos; SELECT * FROM DATOS WHERE ID ='" + id + "'"
            conectar_usuario()
            comandoSql = New SqlCommand(sentenciaSql, conexion_usuario)
            lectrorSql = comandoSql.ExecuteReader

            If lectrorSql.Read Then
                txtId.Text = lectrorSql(0)
                txtNombre.Text = lectrorSql(1)
                txtApellido1.Text = lectrorSql(2)
                txtApellido2.Text = lectrorSql(3)
                txtEdad.Text = lectrorSql(4)
            Else
                MsgBox("El dato no existe")
            End If

        Catch ex As Exception

            MsgBox("No se ha podido acceder a la tabla ya que no tienes permisos")

        End Try


    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try

            respuesta = MessageBox.Show("Datos", "Realmente quieres borrar el registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = vbYes Then

                id = txtId.Text
                sentenciaSql = "delete from datos where id ='" + id + "'"
                conectar_usuario()
                comandoSql = New SqlCommand(sentenciaSql, conexion_usuario)
                respuesta = comandoSql.ExecuteNonQuery
                conexion_usuario.Close()

                txtId.Clear()
                txtNombre.Clear()
                txtApellido1.Clear()
                txtApellido2.Clear()
                txtEdad.Clear()


            End If


        Catch ex As Exception

            MsgBox("No se ha podido acceder a la tabla por que no tienes permisos")

        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        accion = "editar"
        txtId.Enabled = True
        txtNombre.Enabled = True
        txtApellido1.Enabled = True
        txtApellido2.Enabled = True
        txtEdad.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub cmbTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTabla.SelectedIndexChanged

    End Sub
End Class