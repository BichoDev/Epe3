<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnlaces
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
        BtnUsuarioForm = New Button()
        BtnRepuestosForm = New Button()
        BtnCambiarUsuario = New Button()
        btnVentas = New Button()
        btnSiniestros = New Button()
        btnSolicitudes = New Button()
        btnCrearCliente = New Button()
        SuspendLayout()
        ' 
        ' BtnUsuarioForm
        ' 
        BtnUsuarioForm.Location = New Point(132, 173)
        BtnUsuarioForm.Name = "BtnUsuarioForm"
        BtnUsuarioForm.Size = New Size(112, 34)
        BtnUsuarioForm.TabIndex = 0
        BtnUsuarioForm.Text = "Usuarios"
        BtnUsuarioForm.UseVisualStyleBackColor = True
        ' 
        ' BtnRepuestosForm
        ' 
        BtnRepuestosForm.Location = New Point(478, 173)
        BtnRepuestosForm.Name = "BtnRepuestosForm"
        BtnRepuestosForm.Size = New Size(112, 34)
        BtnRepuestosForm.TabIndex = 1
        BtnRepuestosForm.Text = "Repuestos"
        BtnRepuestosForm.UseVisualStyleBackColor = True
        ' 
        ' BtnCambiarUsuario
        ' 
        BtnCambiarUsuario.Location = New Point(236, 325)
        BtnCambiarUsuario.Name = "BtnCambiarUsuario"
        BtnCambiarUsuario.Size = New Size(270, 34)
        BtnCambiarUsuario.TabIndex = 2
        BtnCambiarUsuario.Text = "Cambiar Usuario"
        BtnCambiarUsuario.UseVisualStyleBackColor = True
        ' 
        ' btnVentas
        ' 
        btnVentas.Location = New Point(82, 55)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(112, 34)
        btnVentas.TabIndex = 3
        btnVentas.Text = "Venta Repuestos"
        btnVentas.UseVisualStyleBackColor = True
        ' 
        ' btnSiniestros
        ' 
        btnSiniestros.Location = New Point(536, 55)
        btnSiniestros.Name = "btnSiniestros"
        btnSiniestros.Size = New Size(112, 34)
        btnSiniestros.TabIndex = 4
        btnSiniestros.Text = "Siniestros"
        btnSiniestros.UseVisualStyleBackColor = True
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.Location = New Point(297, 55)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(112, 34)
        btnSolicitudes.TabIndex = 5
        btnSolicitudes.Text = "Solicitudes"
        btnSolicitudes.UseVisualStyleBackColor = True
        ' 
        ' btnCrearCliente
        ' 
        btnCrearCliente.Location = New Point(309, 218)
        btnCrearCliente.Name = "btnCrearCliente"
        btnCrearCliente.Size = New Size(112, 34)
        btnCrearCliente.TabIndex = 6
        btnCrearCliente.Text = "Crear Cliente"
        btnCrearCliente.UseVisualStyleBackColor = True
        ' 
        ' FormEnlaces
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCrearCliente)
        Controls.Add(btnSolicitudes)
        Controls.Add(btnSiniestros)
        Controls.Add(btnVentas)
        Controls.Add(BtnCambiarUsuario)
        Controls.Add(BtnRepuestosForm)
        Controls.Add(BtnUsuarioForm)
        Name = "FormEnlaces"
        Text = "FormEnlaces"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnFormUsuarios As Button
    Friend WithEvents btnFormRepuestos As Button
    Friend WithEvents BtnUsuarioForm As Button
    Friend WithEvents BtnRepuestosForm As Button
    Friend WithEvents BtnCambiarUsuario As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnSiniestros As Button
    Friend WithEvents btnSolicitudes As Button
    Friend WithEvents btnCrearCliente As Button
End Class
