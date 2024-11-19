<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarCliente
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
        txtComuna = New TextBox()
        txtRut = New TextBox()
        txtNombre = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtApellidoM = New TextBox()
        txtApellidoP = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnGuardarCliente = New Button()
        SuspendLayout()
        ' 
        ' txtComuna
        ' 
        txtComuna.Location = New Point(217, 394)
        txtComuna.Name = "txtComuna"
        txtComuna.Size = New Size(150, 31)
        txtComuna.TabIndex = 0
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(217, 130)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(150, 31)
        txtRut.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(217, 178)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 31)
        txtNombre.TabIndex = 2
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(217, 310)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(150, 31)
        txtDireccion.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(217, 351)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(150, 31)
        txtTelefono.TabIndex = 4
        ' 
        ' txtApellidoM
        ' 
        txtApellidoM.Location = New Point(217, 267)
        txtApellidoM.Name = "txtApellidoM"
        txtApellidoM.Size = New Size(150, 31)
        txtApellidoM.TabIndex = 5
        ' 
        ' txtApellidoP
        ' 
        txtApellidoP.Location = New Point(217, 221)
        txtApellidoP.Name = "txtApellidoP"
        txtApellidoP.Size = New Size(150, 31)
        txtApellidoP.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 25)
        Label1.TabIndex = 7
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 9
        Label3.Text = "Apellido Paterno"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 25)
        Label4.TabIndex = 10
        Label4.Text = "Apelido Materno"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 11
        Label5.Text = "Direccion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 354)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 25)
        Label6.TabIndex = 12
        Label6.Text = "Telefono"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 25)
        Label7.TabIndex = 13
        Label7.Text = "Comuna"
        ' 
        ' btnGuardarCliente
        ' 
        btnGuardarCliente.Location = New Point(454, 237)
        btnGuardarCliente.Name = "btnGuardarCliente"
        btnGuardarCliente.Size = New Size(149, 61)
        btnGuardarCliente.TabIndex = 14
        btnGuardarCliente.Text = "Registrar Cliente"
        btnGuardarCliente.UseVisualStyleBackColor = True
        ' 
        ' FormAgregarCliente
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardarCliente)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtApellidoP)
        Controls.Add(txtApellidoM)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtNombre)
        Controls.Add(txtRut)
        Controls.Add(txtComuna)
        Name = "FormAgregarCliente"
        Text = "FormAgregarCliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtComuna As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardarCliente As Button
End Class
