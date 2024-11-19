<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentaRepuestos
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
        cmbNombreRepuesto = New ComboBox()
        cmbCliente = New ComboBox()
        txtCantidadVendida = New TextBox()
        txtTotal = New TextBox()
        dtpFechaVenta = New DateTimePicker()
        btnRegistrarVenta = New Button()
        btnVerResumen = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnVerStock = New Button()
        btnCalcularTotal = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAgregarCliente = New Button()
        SuspendLayout()
        ' 
        ' cmbNombreRepuesto
        ' 
        cmbNombreRepuesto.FormattingEnabled = True
        cmbNombreRepuesto.Location = New Point(241, 35)
        cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        cmbNombreRepuesto.Size = New Size(197, 33)
        cmbNombreRepuesto.TabIndex = 0
        ' 
        ' cmbCliente
        ' 
        cmbCliente.FormattingEnabled = True
        cmbCliente.Location = New Point(240, 90)
        cmbCliente.Name = "cmbCliente"
        cmbCliente.Size = New Size(198, 33)
        cmbCliente.TabIndex = 1
        ' 
        ' txtCantidadVendida
        ' 
        txtCantidadVendida.Location = New Point(241, 210)
        txtCantidadVendida.Name = "txtCantidadVendida"
        txtCantidadVendida.Size = New Size(150, 31)
        txtCantidadVendida.TabIndex = 2
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(241, 268)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(150, 31)
        txtTotal.TabIndex = 3
        ' 
        ' dtpFechaVenta
        ' 
        dtpFechaVenta.Location = New Point(240, 154)
        dtpFechaVenta.Name = "dtpFechaVenta"
        dtpFechaVenta.Size = New Size(198, 31)
        dtpFechaVenta.TabIndex = 4
        ' 
        ' btnRegistrarVenta
        ' 
        btnRegistrarVenta.Location = New Point(481, 371)
        btnRegistrarVenta.Name = "btnRegistrarVenta"
        btnRegistrarVenta.Size = New Size(181, 34)
        btnRegistrarVenta.TabIndex = 5
        btnRegistrarVenta.Text = "Registrar Venta"
        btnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnVerResumen
        ' 
        btnVerResumen.Location = New Point(553, 93)
        btnVerResumen.Name = "btnVerResumen"
        btnVerResumen.Size = New Size(204, 34)
        btnVerResumen.TabIndex = 6
        btnVerResumen.Text = "Ver Resumen Ventas"
        btnVerResumen.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 7
        Label1.Text = "Cantidad Venta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 8
        Label2.Text = "Total"
        ' 
        ' btnVerStock
        ' 
        btnVerStock.Location = New Point(408, 207)
        btnVerStock.Name = "btnVerStock"
        btnVerStock.Size = New Size(148, 34)
        btnVerStock.TabIndex = 9
        btnVerStock.Text = "Verificar Stock"
        btnVerStock.UseVisualStyleBackColor = True
        ' 
        ' btnCalcularTotal
        ' 
        btnCalcularTotal.Location = New Point(408, 265)
        btnCalcularTotal.Name = "btnCalcularTotal"
        btnCalcularTotal.Size = New Size(148, 34)
        btnCalcularTotal.TabIndex = 10
        btnCalcularTotal.Text = "Calcular Total"
        btnCalcularTotal.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 25)
        Label3.TabIndex = 11
        Label3.Text = "Nombre Repuesto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(66, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 25)
        Label4.TabIndex = 12
        Label4.Text = "Cliente "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(66, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 25)
        Label5.TabIndex = 13
        Label5.Text = "Fecha de venta"
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Location = New Point(97, 371)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(205, 34)
        btnAgregarCliente.TabIndex = 14
        btnAgregarCliente.Text = "Crear Cliente"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' FormVentaRepuestos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAgregarCliente)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnCalcularTotal)
        Controls.Add(btnVerStock)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnVerResumen)
        Controls.Add(btnRegistrarVenta)
        Controls.Add(dtpFechaVenta)
        Controls.Add(txtTotal)
        Controls.Add(txtCantidadVendida)
        Controls.Add(cmbCliente)
        Controls.Add(cmbNombreRepuesto)
        Name = "FormVentaRepuestos"
        Text = "FormVentaRepuestos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbNombreRepuesto As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents txtCantidadVendida As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents btnVerResumen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerStock As Button
    Friend WithEvents btnCalcularTotal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregarCliente As Button
End Class
