﻿Public Class FormProducto
    Dim _producto As Producto
    Dim _dgv As DataGridView
    Dim _categoria As String
    Public Sub New(producto As Producto, categoria As String, dgv As DataGridView)
        InitializeComponent()
        Me._producto = producto
        Me._categoria = categoria
        Me._dgv = dgv
    End Sub
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNombre.Text = _producto._nombre
        tbMarca.Text = _producto._marca
        tbPrecio.Text = _producto._precio
        tbCantidad.Text = 1
        tbCategoria.Text = _categoria
    End Sub
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        _producto._cantidad -= CInt(tbCantidad.Text)
        Dim esNuevo = True
        For Each producto As Producto In _cliente._carrito._productos
            If _producto._codigo = producto._codigo Then
                producto._cantidad += CInt(tbCantidad.Text)
                esNuevo = False
                Exit For
            End If
        Next
        If esNuevo Then
            Dim productoSeleccionado = New Producto(_producto._codigo, _producto._nombre, _producto._marca, _producto._precio, tbCantidad.Text, _producto._categoria)
            _cliente.AgregarProducto(productoSeleccionado)
        End If
        _cliente._carrito.MostrarCarrito(_dgv)
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub tbCantidad_TextChanged(sender As Object, e As EventArgs) Handles tbCantidad.TextChanged
        If Not String.IsNullOrEmpty(tbCantidad.Text) Then
            If tbCantidad.Text > _producto._cantidad Then
                MsgBox("Stock insuficiente, ingrese una cantidad menor.")
                tbCantidad.Text = 1
            End If
        End If
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        If tbCantidad.Text <= _producto._cantidad Then
            tbCantidad.Text += 1
        End If
    End Sub

    Private Sub btnLess_Click(sender As Object, e As EventArgs) Handles btnLess.Click
        If tbCantidad.Text > 1 Then
            tbCantidad.Text -= 1
        End If
    End Sub
End Class