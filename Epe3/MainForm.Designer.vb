<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        lblWelcome = New Label()
        BtnCerrarSesion = New Button()
        dvgUsuarios = New DataGridView()
        BtnCrearUsuario = New Button()
        BtnModificarUsuario = New Button()
        BtnEliminarUsuario = New Button()
        txtRut = New TextBox()
        txtCorreo = New TextBox()
        txtContraseña = New TextBox()
        txtTipo = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(dvgUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(127, 353)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 25)
        lblWelcome.TabIndex = 0
        ' 
        ' BtnCerrarSesion
        ' 
        BtnCerrarSesion.Location = New Point(23, 398)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New Size(185, 34)
        BtnCerrarSesion.TabIndex = 1
        BtnCerrarSesion.Text = "Cerrar Sesion"
        BtnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' dvgUsuarios
        ' 
        dvgUsuarios.AllowUserToAddRows = False
        dvgUsuarios.AllowUserToDeleteRows = False
        dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgUsuarios.Location = New Point(23, 22)
        dvgUsuarios.Name = "dvgUsuarios"
        dvgUsuarios.ReadOnly = True
        dvgUsuarios.RowHeadersWidth = 62
        dvgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dvgUsuarios.Size = New Size(436, 310)
        dvgUsuarios.TabIndex = 2
        ' 
        ' BtnCrearUsuario
        ' 
        BtnCrearUsuario.Location = New Point(593, 348)
        BtnCrearUsuario.Name = "BtnCrearUsuario"
        BtnCrearUsuario.Size = New Size(153, 34)
        BtnCrearUsuario.TabIndex = 3
        BtnCrearUsuario.Text = "Crear Usuario"
        BtnCrearUsuario.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarUsuario
        ' 
        BtnModificarUsuario.Location = New Point(593, 308)
        BtnModificarUsuario.Name = "BtnModificarUsuario"
        BtnModificarUsuario.Size = New Size(153, 34)
        BtnModificarUsuario.TabIndex = 4
        BtnModificarUsuario.Text = "Editar Usuario"
        BtnModificarUsuario.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarUsuario
        ' 
        BtnEliminarUsuario.Location = New Point(593, 268)
        BtnEliminarUsuario.Name = "BtnEliminarUsuario"
        BtnEliminarUsuario.Size = New Size(153, 34)
        BtnEliminarUsuario.TabIndex = 5
        BtnEliminarUsuario.Text = "Eliminar Usuario"
        BtnEliminarUsuario.UseVisualStyleBackColor = True
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(596, 22)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(150, 31)
        txtRut.TabIndex = 6
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(596, 76)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(150, 31)
        txtCorreo.TabIndex = 7
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(596, 128)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(150, 31)
        txtContraseña.TabIndex = 8
        txtContraseña.UseSystemPasswordChar = True
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(596, 188)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(150, 31)
        txtTipo.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(527, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 25)
        Label1.TabIndex = 10
        Label1.Text = "Rut:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(500, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 11
        Label2.Text = "Correo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(465, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 12
        Label3.Text = "Contraseña:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(519, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 13
        Label4.Text = "Tipo:"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 476)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTipo)
        Controls.Add(txtContraseña)
        Controls.Add(txtCorreo)
        Controls.Add(txtRut)
        Controls.Add(BtnEliminarUsuario)
        Controls.Add(BtnModificarUsuario)
        Controls.Add(BtnCrearUsuario)
        Controls.Add(dvgUsuarios)
        Controls.Add(BtnCerrarSesion)
        Controls.Add(lblWelcome)
        Name = "MainForm"
        Text = "MainForm"
        CType(dvgUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents dvgUsuarios As DataGridView
    Friend WithEvents BtnCrearUsuario As Button
    Friend WithEvents BtnModificarUsuario As Button
    Friend WithEvents BtnEliminarUsuario As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
