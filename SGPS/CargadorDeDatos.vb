﻿Imports MySql.Data.MySqlClient
Public Class CargadorDeDatos
    Public Sub CargaDeUsuarios()
        Dim miConexion As MySqlConnection
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Try
            miConexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
            query = "SELECT * FROM usuarios"
            cmd = New MySqlCommand(query, miConexion)
            miConexion.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim id As Integer = reader.GetInt32(0)
                Dim usuario As String = reader.GetString(1)
                Dim nombre As String = reader.GetString(2)
                Dim contraseña As String = reader.GetString(3)
                Dim nuevoUsuario As Usuario

                nuevoUsuario = New Cliente(id, usuario, nombre, contraseña)

                miSupermercado.AgregarUsuario(nuevoUsuario)
            End While

            reader.Close()
            cmd.Dispose()
            miConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message)
        End Try
    End Sub
    Public Sub CargaDeProductos()
        Dim miConexion As MySqlConnection
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Try
            miConexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
            query = "SELECT * FROM categorias"
            cmd = New MySqlCommand(query, miConexion)
            miConexion.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim idCategoria As Integer = reader.GetInt16(0)
                Dim nombreCategoria As String = reader.GetString(1)
                Dim categoria As New Categoria(idCategoria, nombreCategoria)
                miSupermercado.AgregarCategoria(categoria)
            End While

            reader.Close()

            query = "SELECT * FROM  productos"
            cmd = New MySqlCommand(query, miConexion)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim codigo As Integer = reader.GetInt32(0)
                Dim nombre As String = reader.GetString(1)
                Dim marca As String = reader.GetString(2)
                Dim precio As Double = reader.GetDouble(3)
                Dim cantidad As Integer = reader.GetInt32(4)
                Dim nombreCategoria As Integer = reader.GetInt16(5)

                Dim producto As New Producto(codigo, nombre, marca, precio, cantidad, nombreCategoria)

                For Each categoria As Categoria In miSupermercado._categorias
                    If categoria._id = producto._categoria Then
                        categoria._productos.Add(producto)
                        Exit For
                    End If
                Next
            End While

            reader.Close()
            cmd.Dispose()
            miConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub
    Public Sub MostrarProductos(dgv As DataGridView)
        dgv.Rows.Clear()

        For Each categoria As Categoria In miSupermercado._categorias
            For Each producto As Producto In categoria._productos
                Dim codigo As Integer = CInt(producto._codigo)
                dgv.Rows.Add(codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad, categoria._nombre)
            Next
        Next
    End Sub
    Public Sub MostrarCategorias(cb As ComboBox)
        cb.Items.Clear()
        cb.Items.Add("")
        For Each categoria As Categoria In miSupermercado._categorias
            cb.Items.Add(categoria._nombre)
        Next
    End Sub
End Class
