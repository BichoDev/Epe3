<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMecanico
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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTipo = New TextBox()
        txtContraseña = New TextBox()
        txtCorreo = New TextBox()
        txtRut = New TextBox()
        BtnEliminarUsuario = New Button()
        BtnModificarUsuario = New Button()
        BtnCrearUsuario = New Button()
        dvgUsuarios = New DataGridView()
        BtnCerrarSesion = New Button()
        lblWelcome = New Label()
        CType(dvgUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(535, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 55
        Label4.Text = "Tipo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(481, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 54
        Label3.Text = "Contraseña:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(516, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 53
        Label2.Text = "Correo:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(543, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 25)
        Label1.TabIndex = 52
        Label1.Text = "Rut:"
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(612, 186)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(150, 31)
        txtTipo.TabIndex = 51
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(612, 126)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(150, 31)
        txtContraseña.TabIndex = 50
        txtContraseña.UseSystemPasswordChar = True
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(612, 74)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(150, 31)
        txtCorreo.TabIndex = 49
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(612, 20)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(150, 31)
        txtRut.TabIndex = 48
        ' 
        ' BtnEliminarUsuario
        ' 
        BtnEliminarUsuario.Location = New Point(609, 266)
        BtnEliminarUsuario.Name = "BtnEliminarUsuario"
        BtnEliminarUsuario.Size = New Size(153, 34)
        BtnEliminarUsuario.TabIndex = 47
        BtnEliminarUsuario.Text = "Eliminar Usuario"
        BtnEliminarUsuario.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarUsuario
        ' 
        BtnModificarUsuario.Location = New Point(609, 306)
        BtnModificarUsuario.Name = "BtnModificarUsuario"
        BtnModificarUsuario.Size = New Size(153, 34)
        BtnModificarUsuario.TabIndex = 46
        BtnModificarUsuario.Text = "Editar Usuario"
        BtnModificarUsuario.UseVisualStyleBackColor = True
        ' 
        ' BtnCrearUsuario
        ' 
        BtnCrearUsuario.Location = New Point(609, 346)
        BtnCrearUsuario.Name = "BtnCrearUsuario"
        BtnCrearUsuario.Size = New Size(153, 34)
        BtnCrearUsuario.TabIndex = 45
        BtnCrearUsuario.Text = "Crear Usuario"
        BtnCrearUsuario.UseVisualStyleBackColor = True
        ' 
        ' dvgUsuarios
        ' 
        dvgUsuarios.AllowUserToAddRows = False
        dvgUsuarios.AllowUserToDeleteRows = False
        dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgUsuarios.Location = New Point(39, 20)
        dvgUsuarios.Name = "dvgUsuarios"
        dvgUsuarios.ReadOnly = True
        dvgUsuarios.RowHeadersWidth = 62
        dvgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dvgUsuarios.Size = New Size(436, 310)
        dvgUsuarios.TabIndex = 44
        ' 
        ' BtnCerrarSesion
        ' 
        BtnCerrarSesion.Location = New Point(39, 396)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New Size(185, 34)
        BtnCerrarSesion.TabIndex = 43
        BtnCerrarSesion.Text = "Cerrar Sesion"
        BtnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(143, 351)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 25)
        lblWelcome.TabIndex = 42
        ' 
        ' FormMecanico
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Name = "FormMecanico"
        Text = "FormMecanico"
        CType(dvgUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents BtnEliminarUsuario As Button
    Friend WithEvents BtnModificarUsuario As Button
    Friend WithEvents BtnCrearUsuario As Button
    Friend WithEvents dvgUsuarios As DataGridView
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents lblWelcome As Label
End Class
