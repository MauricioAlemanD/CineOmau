﻿Imports System.Data.SqlClient

Public Class Nuevo

    Dim comandoSql As SqlCommand
    Dim lectrorSql As SqlDataReader
    Dim sentenciaSql As String
    Dim respuesta As Integer

    Private Sub Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sentenciaSql = "select name from sysdatabases"
        conectar()
        comandoSql = New SqlCommand(sentenciaSql, conexion)
        lectrorSql = comandoSql.ExecuteReader
        While lectrorSql.Read
            cmbBasesDeDatos.Items.Add(lectrorSql(0))
        End While
        conexion.Close()

    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        Try
            usuario = txtUsuario.Text
            contraseña = txtContraseña.Text
            basededatos = cmbBasesDeDatos.SelectedItem
            sentenciaSql = "CREATE LOGIN [" + usuario + "] WITH PASSWORD=N'" + contraseña + "' MUST_CHANGE, DEFAULT_DATABASE=[" + basededatos + "], CHECK_EXPIRATION=ON, CHECK_POLICY=ON"
            conectar()
            comandoSql = New SqlCommand(sentenciaSql, conexion)
            respuesta = comandoSql.ExecuteNonQuery
            conexion.Close()

            sentenciaSql = "USE [" + basededatos + "] ; CREATE USER[" + usuario + "] WITH DEFAULT_SCHEMA=[dbo]"
            conectar()
            comandoSql = New SqlCommand(sentenciaSql, conexion)
            respuesta = comandoSql.ExecuteNonQuery
            conexion.Close()
            MsgBox("Usuario creado")
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al crear usuario")
        End Try

    End Sub
End Class