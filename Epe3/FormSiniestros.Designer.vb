<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiniestros
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtRut = New TextBox()
        txtRutCompania = New TextBox()
        txtDetalle = New TextBox()
        txtSiniestroID = New TextBox()
        cmbEstadoSiniestro = New ComboBox()
        cmbEstadoSeguro = New ComboBox()
        dtpFechaSiniestro = New DateTimePicker()
        dgvSiniestros = New DataGridView()
        btnRegistrar = New Button()
        btnMostrarTodos = New Button()
        btnBuscar = New Button()
        btnActualizarEstado = New Button()
        txtBuscarRut = New TextBox()
        cmbBuscarEstado = New ComboBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnCerrarSesion = New Button()
        CType(dgvSiniestros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 0
        Label1.Text = "Siniestro ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 25)
        Label2.TabIndex = 1
        Label2.Text = "Detalle del Siniestro"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 25)
        Label3.TabIndex = 2
        Label3.Text = "Estado del Siniestro"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 25)
        Label4.TabIndex = 3
        Label4.Text = "Fecha del Siniestro"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 25)
        Label5.TabIndex = 4
        Label5.Text = "Rut Compañia"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 25)
        Label6.TabIndex = 5
        Label6.Text = "Rut Cliente"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 25)
        Label7.TabIndex = 6
        Label7.Text = "Estado del seguro"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(254, 229)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(150, 31)
        txtRut.TabIndex = 7
        ' 
        ' txtRutCompania
        ' 
        txtRutCompania.Location = New Point(254, 184)
        txtRutCompania.Name = "txtRutCompania"
        txtRutCompania.Size = New Size(150, 31)
        txtRutCompania.TabIndex = 8
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Location = New Point(254, 58)
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(150, 31)
        txtDetalle.TabIndex = 9
        ' 
        ' txtSiniestroID
        ' 
        txtSiniestroID.Location = New Point(254, 19)
        txtSiniestroID.Name = "txtSiniestroID"
        txtSiniestroID.Size = New Size(150, 31)
        txtSiniestroID.TabIndex = 10
        ' 
        ' cmbEstadoSiniestro
        ' 
        cmbEstadoSiniestro.FormattingEnabled = True
        cmbEstadoSiniestro.Location = New Point(254, 96)
        cmbEstadoSiniestro.Name = "cmbEstadoSiniestro"
        cmbEstadoSiniestro.Size = New Size(182, 33)
        cmbEstadoSiniestro.TabIndex = 11
        ' 
        ' cmbEstadoSeguro
        ' 
        cmbEstadoSeguro.FormattingEnabled = True
        cmbEstadoSeguro.Location = New Point(254, 274)
        cmbEstadoSeguro.Name = "cmbEstadoSeguro"
        cmbEstadoSeguro.Size = New Size(182, 33)
        cmbEstadoSeguro.TabIndex = 12
        ' 
        ' dtpFechaSiniestro
        ' 
        dtpFechaSiniestro.Location = New Point(254, 143)
        dtpFechaSiniestro.Name = "dtpFechaSiniestro"
        dtpFechaSiniestro.Size = New Size(300, 31)
        dtpFechaSiniestro.TabIndex = 13
        ' 
        ' dgvSiniestros
        ' 
        dgvSiniestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiniestros.Location = New Point(34, 381)
        dgvSiniestros.Name = "dgvSiniestros"
        dgvSiniestros.RowHeadersWidth = 62
        dgvSiniestros.Size = New Size(1012, 225)
        dgvSiniestros.TabIndex = 14
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(34, 341)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(112, 34)
        btnRegistrar.TabIndex = 15
        btnRegistrar.Text = "Registrar Siniestro"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarTodos
        ' 
        btnMostrarTodos.Location = New Point(363, 341)
        btnMostrarTodos.Name = "btnMostrarTodos"
        btnMostrarTodos.Size = New Size(112, 34)
        btnMostrarTodos.TabIndex = 16
        btnMostrarTodos.Text = "Mostrar Todos"
        btnMostrarTodos.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(624, 226)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 34)
        btnBuscar.TabIndex = 17
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarEstado
        ' 
        btnActualizarEstado.Location = New Point(193, 341)
        btnActualizarEstado.Name = "btnActualizarEstado"
        btnActualizarEstado.Size = New Size(112, 34)
        btnActualizarEstado.TabIndex = 18
        btnActualizarEstado.Text = "Actualizar estado"
        btnActualizarEstado.UseVisualStyleBackColor = True
        ' 
        ' txtBuscarRut
        ' 
        txtBuscarRut.Location = New Point(624, 96)
        txtBuscarRut.Name = "txtBuscarRut"
        txtBuscarRut.Size = New Size(150, 31)
        txtBuscarRut.TabIndex = 19
        ' 
        ' cmbBuscarEstado
        ' 
        cmbBuscarEstado.FormattingEnabled = True
        cmbBuscarEstado.Location = New Point(624, 170)
        cmbBuscarEstado.Name = "cmbBuscarEstado"
        cmbBuscarEstado.Size = New Size(182, 33)
        cmbBuscarEstado.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(620, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 25)
        Label8.TabIndex = 21
        Label8.Text = "Buscar por;"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(622, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 25)
        Label9.TabIndex = 22
        Label9.Text = "Rut cliente"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(624, 142)
        Label10.Name = "Label10"
        Label10.Size = New Size(166, 25)
        Label10.TabIndex = 23
        Label10.Text = "Estado del siniestro"
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Location = New Point(624, 315)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(112, 34)
        btnCerrarSesion.TabIndex = 24
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' FormSiniestros
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 667)
        Controls.Add(btnCerrarSesion)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(cmbBuscarEstado)
        Controls.Add(txtBuscarRut)
        Controls.Add(btnActualizarEstado)
        Controls.Add(btnBuscar)
        Controls.Add(btnMostrarTodos)
        Controls.Add(btnRegistrar)
        Controls.Add(dgvSiniestros)
        Controls.Add(dtpFechaSiniestro)
        Controls.Add(cmbEstadoSeguro)
        Controls.Add(cmbEstadoSiniestro)
        Controls.Add(txtSiniestroID)
        Controls.Add(txtDetalle)
        Controls.Add(txtRutCompania)
        Controls.Add(txtRut)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormSiniestros"
        Text = "FormSiniestros"
        CType(dgvSiniestros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtRutCompania As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtSiniestroID As TextBox
    Friend WithEvents cmbEstadoSiniestro As ComboBox
    Friend WithEvents cmbEstadoSeguro As ComboBox
    Friend WithEvents dtpFechaSiniestro As DateTimePicker
    Friend WithEvents dgvSiniestros As DataGridView
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnMostrarTodos As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnActualizarEstado As Button
    Friend WithEvents txtBuscarRut As TextBox
    Friend WithEvents cmbBuscarEstado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCerrarSesion As Button
End Class
