﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lgTbUsuario = New TextBox()
        lgTbContraseña = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        GroupBox1 = New GroupBox()
        btnRegister = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        rgTbUsuario = New TextBox()
        rgTbNombre = New TextBox()
        rgTbApellido = New TextBox()
        rgTbContraseña = New TextBox()
        gbRegistrar = New GroupBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        gbRegistrar.SuspendLayout()
        SuspendLayout()
        ' 
        ' lgTbUsuario
        ' 
        lgTbUsuario.Location = New Point(37, 83)
        lgTbUsuario.Name = "lgTbUsuario"
        lgTbUsuario.Size = New Size(223, 29)
        lgTbUsuario.TabIndex = 0
        ' 
        ' lgTbContraseña
        ' 
        lgTbContraseña.Location = New Point(37, 138)
        lgTbContraseña.Name = "lgTbContraseña"
        lgTbContraseña.Size = New Size(223, 29)
        lgTbContraseña.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña:"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(37, 186)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(224, 30)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Iniciar Sesión"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnRegister)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lgTbContraseña)
        GroupBox1.Controls.Add(lgTbUsuario)
        GroupBox1.Location = New Point(63, 119)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(303, 279)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Iniciar Sesión"
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(37, 223)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(224, 30)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Registrarse"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 21)
        Label3.TabIndex = 5
        Label3.Text = "Usuario:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 21)
        Label4.TabIndex = 7
        Label4.Text = "Nombre:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 21)
        Label5.TabIndex = 8
        Label5.Text = "Apellido:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 21)
        Label6.TabIndex = 9
        Label6.Text = "Contraseña:"
        ' 
        ' rgTbUsuario
        ' 
        rgTbUsuario.Location = New Point(140, 51)
        rgTbUsuario.Name = "rgTbUsuario"
        rgTbUsuario.Size = New Size(223, 29)
        rgTbUsuario.TabIndex = 2
        ' 
        ' rgTbNombre
        ' 
        rgTbNombre.Location = New Point(140, 91)
        rgTbNombre.Name = "rgTbNombre"
        rgTbNombre.Size = New Size(223, 29)
        rgTbNombre.TabIndex = 3
        ' 
        ' rgTbApellido
        ' 
        rgTbApellido.Location = New Point(140, 131)
        rgTbApellido.Name = "rgTbApellido"
        rgTbApellido.Size = New Size(223, 29)
        rgTbApellido.TabIndex = 4
        ' 
        ' rgTbContraseña
        ' 
        rgTbContraseña.Location = New Point(140, 171)
        rgTbContraseña.Name = "rgTbContraseña"
        rgTbContraseña.Size = New Size(223, 29)
        rgTbContraseña.TabIndex = 5
        ' 
        ' gbRegistrar
        ' 
        gbRegistrar.Controls.Add(Button1)
        gbRegistrar.Controls.Add(rgTbContraseña)
        gbRegistrar.Controls.Add(rgTbApellido)
        gbRegistrar.Controls.Add(rgTbNombre)
        gbRegistrar.Controls.Add(rgTbUsuario)
        gbRegistrar.Controls.Add(Label6)
        gbRegistrar.Controls.Add(Label5)
        gbRegistrar.Controls.Add(Label4)
        gbRegistrar.Controls.Add(Label3)
        gbRegistrar.Location = New Point(443, 119)
        gbRegistrar.Name = "gbRegistrar"
        gbRegistrar.Size = New Size(397, 279)
        gbRegistrar.TabIndex = 13
        gbRegistrar.TabStop = False
        gbRegistrar.Text = "Registrar Usuario"
        gbRegistrar.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(89, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 30)
        Button1.TabIndex = 7
        Button1.Text = "Registrarse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(893, 538)
        Controls.Add(gbRegistrar)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbRegistrar.ResumeLayout(False)
        gbRegistrar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lgTbUsuario As TextBox
    Friend WithEvents lgTbContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rgTbUsuario As TextBox
    Friend WithEvents rgTbNombre As TextBox
    Friend WithEvents rgTbApellido As TextBox
    Friend WithEvents rgTbContraseña As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents gbRegistrar As GroupBox
    Friend WithEvents Button1 As Button

End Class