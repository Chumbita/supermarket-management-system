﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        rgTbContraseña = New TextBox()
        rgTbApellido = New TextBox()
        rgTbNombre = New TextBox()
        rgTbUsuario = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "Buscar Producto:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(188, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(188, 126)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(38, 172)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(565, 188)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(38, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 37)
        Button1.TabIndex = 4
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 20)
        Label3.TabIndex = 6
        Label3.Text = "Filtrar por categoría:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(383, 89)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(104, 24)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Por Código"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(493, 89)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 24)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Por Nombre"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(498, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 37)
        Button2.TabIndex = 9
        Button2.Text = "Restockear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(188, 377)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 37)
        Button3.TabIndex = 10
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(345, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 37)
        Button4.TabIndex = 11
        Button4.Text = "Editar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' rgTbContraseña
        ' 
        rgTbContraseña.Location = New Point(127, 155)
        rgTbContraseña.Name = "rgTbContraseña"
        rgTbContraseña.Size = New Size(199, 27)
        rgTbContraseña.TabIndex = 15
        ' 
        ' rgTbApellido
        ' 
        rgTbApellido.Location = New Point(127, 119)
        rgTbApellido.Name = "rgTbApellido"
        rgTbApellido.Size = New Size(199, 27)
        rgTbApellido.TabIndex = 14
        ' 
        ' rgTbNombre
        ' 
        rgTbNombre.Location = New Point(127, 83)
        rgTbNombre.Name = "rgTbNombre"
        rgTbNombre.Size = New Size(199, 27)
        rgTbNombre.TabIndex = 13
        ' 
        ' rgTbUsuario
        ' 
        rgTbUsuario.Location = New Point(127, 47)
        rgTbUsuario.Name = "rgTbUsuario"
        rgTbUsuario.Size = New Size(199, 27)
        rgTbUsuario.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 19
        Label6.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 18
        Label5.Text = "Marca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 17
        Label4.Text = "Código:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 16
        Label2.Text = "Nombre:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(127, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(199, 27)
        TextBox2.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 21
        Label7.Text = "Cantidad:"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(133, 256)
        Button5.Name = "Button5"
        Button5.Size = New Size(105, 37)
        Button5.TabIndex = 22
        Button5.Text = "Guardar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(rgTbContraseña)
        GroupBox1.Controls.Add(rgTbApellido)
        GroupBox1.Controls.Add(rgTbNombre)
        GroupBox1.Controls.Add(rgTbUsuario)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(643, 121)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 318)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 490)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents rgTbContraseña As TextBox
    Friend WithEvents rgTbApellido As TextBox
    Friend WithEvents rgTbNombre As TextBox
    Friend WithEvents rgTbUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class