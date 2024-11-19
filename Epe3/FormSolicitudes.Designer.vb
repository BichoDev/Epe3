<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudes
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
        txtDescripcionProblema = New TextBox()
        cmbEstado = New ComboBox()
        cmbBuscarEstado = New ComboBox()
        dtpFechaSolicitud = New DateTimePicker()
        btnRegistrar = New Button()
        btnBuscar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        dgvSolicitudes = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cmbRut = New ComboBox()
        cmbFiltrarRut = New ComboBox()
        cmbRutEmpleado = New ComboBox()
        cmbSiniestroID = New ComboBox()
        btnCerrarSesion = New Button()
        CType(dgvSolicitudes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDescripcionProblema
        ' 
        txtDescripcionProblema.Location = New Point(178, 72)
        txtDescripcionProblema.Name = "txtDescripcionProblema"
        txtDescripcionProblema.Size = New Size(182, 31)
        txtDescripcionProblema.TabIndex = 2
        ' 
        ' cmbEstado
        ' 
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(178, 226)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(182, 33)
        cmbEstado.TabIndex = 5
        ' 
        ' cmbBuscarEstado
        ' 
        cmbBuscarEstado.FormattingEnabled = True
        cmbBuscarEstado.Location = New Point(941, 58)
        cmbBuscarEstado.Name = "cmbBuscarEstado"
        cmbBuscarEstado.Size = New Size(182, 33)
        cmbBuscarEstado.TabIndex = 6
        ' 
        ' dtpFechaSolicitud
        ' 
        dtpFechaSolicitud.Location = New Point(535, 25)
        dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        dtpFechaSolicitud.Size = New Size(300, 31)
        dtpFechaSolicitud.TabIndex = 7
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(405, 178)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(112, 34)
        btnRegistrar.TabIndex = 8
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(979, 202)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 34)
        btnBuscar.TabIndex = 9
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(748, 174)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(112, 34)
        btnActualizar.TabIndex = 10
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(569, 175)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 34)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.TopCenter
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' dgvSolicitudes
        ' 
        dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSolicitudes.Location = New Point(34, 271)
        dgvSolicitudes.Name = "dgvSolicitudes"
        dgvSolicitudes.RowHeadersWidth = 62
        dgvSolicitudes.Size = New Size(801, 206)
        dgvSolicitudes.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 25)
        Label1.TabIndex = 13
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(387, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 25)
        Label2.TabIndex = 14
        Label2.Text = "Fecha Solicitud"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(979, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 25)
        Label3.TabIndex = 15
        Label3.Text = "Buscar Estado"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 25)
        Label4.TabIndex = 16
        Label4.Text = "Estado"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 25)
        Label5.TabIndex = 17
        Label5.Text = "Descripcion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(48, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 25)
        Label6.TabIndex = 18
        Label6.Text = "Siniestro ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(48, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 25)
        Label7.TabIndex = 19
        Label7.Text = "Rut Empleado"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(979, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 25)
        Label8.TabIndex = 20
        Label8.Text = "Buscar Rut"
        ' 
        ' cmbRut
        ' 
        cmbRut.FormattingEnabled = True
        cmbRut.Location = New Point(178, 21)
        cmbRut.Name = "cmbRut"
        cmbRut.Size = New Size(182, 33)
        cmbRut.TabIndex = 21
        ' 
        ' cmbFiltrarRut
        ' 
        cmbFiltrarRut.FormattingEnabled = True
        cmbFiltrarRut.Location = New Point(941, 145)
        cmbFiltrarRut.Name = "cmbFiltrarRut"
        cmbFiltrarRut.Size = New Size(182, 33)
        cmbFiltrarRut.TabIndex = 22
        ' 
        ' cmbRutEmpleado
        ' 
        cmbRutEmpleado.FormattingEnabled = True
        cmbRutEmpleado.Location = New Point(178, 179)
        cmbRutEmpleado.Name = "cmbRutEmpleado"
        cmbRutEmpleado.Size = New Size(182, 33)
        cmbRutEmpleado.TabIndex = 23
        ' 
        ' cmbSiniestroID
        ' 
        cmbSiniestroID.FormattingEnabled = True
        cmbSiniestroID.Location = New Point(178, 127)
        cmbSiniestroID.Name = "cmbSiniestroID"
        cmbSiniestroID.Size = New Size(182, 33)
        cmbSiniestroID.TabIndex = 24
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Location = New Point(1001, 346)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(112, 34)
        btnCerrarSesion.TabIndex = 25
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' FormSolicitudes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1151, 489)
        Controls.Add(btnCerrarSesion)
        Controls.Add(cmbSiniestroID)
        Controls.Add(cmbRutEmpleado)
        Controls.Add(cmbFiltrarRut)
        Controls.Add(cmbRut)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvSolicitudes)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnBuscar)
        Controls.Add(btnRegistrar)
        Controls.Add(dtpFechaSolicitud)
        Controls.Add(cmbBuscarEstado)
        Controls.Add(cmbEstado)
        Controls.Add(txtDescripcionProblema)
        Name = "FormSolicitudes"
        Text = "FormSolicitudes"
        CType(dgvSolicitudes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtDescripcionProblema As TextBox
    Friend WithEvents txtRutEmpleado As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbBuscarEstado As ComboBox
    Friend WithEvents dtpFechaSolicitud As DateTimePicker
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbRut As ComboBox
    Friend WithEvents cmbFiltrarRut As ComboBox
    Friend WithEvents cmbRutEmpleado As ComboBox
    Friend WithEvents cmbSiniestroID As ComboBox
    Friend WithEvents btnCerrarSesion As Button
End Class
