<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumenVentas
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
        dgvVentas = New DataGridView()
        btnFiltrarVentas = New Button()
        btnRegistrarNuevaVenta = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cmbFechasVentas = New ComboBox()
        cmbNombreClientes = New ComboBox()
        cmbNombreRepuesto = New ComboBox()
        CType(dgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVentas
        ' 
        dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVentas.Location = New Point(29, 26)
        dgvVentas.Name = "dgvVentas"
        dgvVentas.RowHeadersWidth = 62
        dgvVentas.Size = New Size(360, 225)
        dgvVentas.TabIndex = 0
        ' 
        ' btnFiltrarVentas
        ' 
        btnFiltrarVentas.Location = New Point(530, 26)
        btnFiltrarVentas.Name = "btnFiltrarVentas"
        btnFiltrarVentas.Size = New Size(112, 34)
        btnFiltrarVentas.TabIndex = 4
        btnFiltrarVentas.Text = "Filtrar por"
        btnFiltrarVentas.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarNuevaVenta
        ' 
        btnRegistrarNuevaVenta.Location = New Point(29, 350)
        btnRegistrarNuevaVenta.Name = "btnRegistrarNuevaVenta"
        btnRegistrarNuevaVenta.Size = New Size(166, 34)
        btnRegistrarNuevaVenta.TabIndex = 5
        btnRegistrarNuevaVenta.Text = "Nueva Venta"
        btnRegistrarNuevaVenta.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(416, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 6
        Label1.Text = "Nombre Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(416, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 25)
        Label2.TabIndex = 7
        Label2.Text = "Nombre Repuesto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(416, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 25)
        Label3.TabIndex = 8
        Label3.Text = "Fecha"
        ' 
        ' cmbFechasVentas
        ' 
        cmbFechasVentas.FormattingEnabled = True
        cmbFechasVentas.Location = New Point(416, 274)
        cmbFechasVentas.Name = "cmbFechasVentas"
        cmbFechasVentas.Size = New Size(182, 33)
        cmbFechasVentas.TabIndex = 9
        ' 
        ' cmbNombreClientes
        ' 
        cmbNombreClientes.FormattingEnabled = True
        cmbNombreClientes.Location = New Point(416, 103)
        cmbNombreClientes.Name = "cmbNombreClientes"
        cmbNombreClientes.Size = New Size(182, 33)
        cmbNombreClientes.TabIndex = 10
        ' 
        ' cmbNombreRepuesto
        ' 
        cmbNombreRepuesto.FormattingEnabled = True
        cmbNombreRepuesto.Location = New Point(416, 190)
        cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        cmbNombreRepuesto.Size = New Size(182, 33)
        cmbNombreRepuesto.TabIndex = 11
        ' 
        ' FormResumenVentas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmbNombreRepuesto)
        Controls.Add(cmbNombreClientes)
        Controls.Add(cmbFechasVentas)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRegistrarNuevaVenta)
        Controls.Add(btnFiltrarVentas)
        Controls.Add(dgvVentas)
        Name = "FormResumenVentas"
        Text = "FormResumenVentas"
        CType(dgvVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnFiltrarVentas As Button
    Friend WithEvents btnRegistrarNuevaVenta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFechasVentas As ComboBox
    Friend WithEvents cmbNombreClientes As ComboBox
    Friend WithEvents cmbNombreRepuesto As ComboBox
End Class
