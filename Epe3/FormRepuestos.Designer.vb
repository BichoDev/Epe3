<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRepuestos
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
        txtRepuestoID = New TextBox()
        txtProveedor = New TextBox()
        txtNombreRepuesto = New TextBox()
        txtCantidadStock = New TextBox()
        txtPrecioUnitario = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnBuscar = New Button()
        dgvRepuestos = New DataGridView()
        BtnCerrarSesion = New Button()
        txtNombreRepuesto2 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRepuestoID
        ' 
        txtRepuestoID.Location = New Point(687, 284)
        txtRepuestoID.Name = "txtRepuestoID"
        txtRepuestoID.Size = New Size(150, 31)
        txtRepuestoID.TabIndex = 0
        ' 
        ' txtProveedor
        ' 
        txtProveedor.Location = New Point(203, 308)
        txtProveedor.Name = "txtProveedor"
        txtProveedor.Size = New Size(150, 31)
        txtProveedor.TabIndex = 1
        ' 
        ' txtNombreRepuesto
        ' 
        txtNombreRepuesto.Location = New Point(203, 116)
        txtNombreRepuesto.Name = "txtNombreRepuesto"
        txtNombreRepuesto.Size = New Size(150, 31)
        txtNombreRepuesto.TabIndex = 2
        ' 
        ' txtCantidadStock
        ' 
        txtCantidadStock.Location = New Point(203, 180)
        txtCantidadStock.Name = "txtCantidadStock"
        txtCantidadStock.Size = New Size(150, 31)
        txtCantidadStock.TabIndex = 3
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.Location = New Point(203, 242)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(150, 31)
        txtPrecioUnitario.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(714, 330)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 5
        Label1.Text = "ID Repuesto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 25)
        Label2.TabIndex = 6
        Label2.Text = "Nombre Repuesto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 25)
        Label3.TabIndex = 7
        Label3.Text = "Cantidad Stock"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 25)
        Label4.TabIndex = 8
        Label4.Text = "Precio Unitario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 25)
        Label5.TabIndex = 9
        Label5.Text = "Proveedor"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(40, 375)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(112, 34)
        btnAgregar.TabIndex = 10
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(203, 375)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(112, 34)
        btnActualizar.TabIndex = 11
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(40, 438)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 34)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(604, 375)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 34)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "Filtrar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvRepuestos
        ' 
        dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRepuestos.Location = New Point(392, 12)
        dgvRepuestos.Name = "dgvRepuestos"
        dgvRepuestos.RowHeadersWidth = 62
        dgvRepuestos.Size = New Size(536, 223)
        dgvRepuestos.TabIndex = 14
        ' 
        ' BtnCerrarSesion
        ' 
        BtnCerrarSesion.Location = New Point(203, 438)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New Size(155, 34)
        BtnCerrarSesion.TabIndex = 15
        BtnCerrarSesion.Text = "Cerrar Sesion"
        BtnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' txtNombreRepuesto2
        ' 
        txtNombreRepuesto2.Location = New Point(459, 284)
        txtNombreRepuesto2.Name = "txtNombreRepuesto2"
        txtNombreRepuesto2.Size = New Size(150, 31)
        txtNombreRepuesto2.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(459, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 25)
        Label6.TabIndex = 6
        Label6.Text = "Nombre Repuesto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(604, 248)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 25)
        Label7.TabIndex = 17
        Label7.Text = "Filtrar por"
        ' 
        ' FormRepuestos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(979, 509)
        Controls.Add(Label7)
        Controls.Add(txtNombreRepuesto2)
        Controls.Add(BtnCerrarSesion)
        Controls.Add(dgvRepuestos)
        Controls.Add(btnBuscar)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(txtCantidadStock)
        Controls.Add(txtNombreRepuesto)
        Controls.Add(txtProveedor)
        Controls.Add(txtRepuestoID)
        Name = "FormRepuestos"
        Text = "FormRepuestos"
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRepuestoID As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtNombreRepuesto As TextBox
    Friend WithEvents txtCantidadStock As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvRepuestos As DataGridView
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents txtNombreRepuesto2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
