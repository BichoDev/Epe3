Public Class FormEnlaces

    ' Variable para almacenar el tipo de usuario y el nombre de usuario que viene desde el LoginForm
    Private _tipoUsuario As String
    Private _username As String

    ' Constructor para recibir el tipo de usuario y nombre desde el LoginForm
    Public Sub New(tipoUsuario As String, username As String)
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()

        ' Asigna los valores de tipo de usuario y nombre
        _tipoUsuario = tipoUsuario
        _username = username
    End Sub

    ' Evento del botón que redirige al formulario según el tipo de usuario
    Private Sub BtnUsuarioForm_Click(sender As Object, e As EventArgs) Handles BtnUsuarioForm.Click
        ' Redirigir según el tipo de usuario
        Select Case _tipoUsuario
            Case "Gerente"
                Dim mainForm As New MainForm(_username)
                mainForm.Show()
            Case "Administrador"
                Dim formAdministrador As New FormAdministrador(_username)
                formAdministrador.Show()
            Case "Analista"
                Dim formAnalista As New FormAnalista(_username)
                formAnalista.Show()
            Case "Aseguradora"
                Dim formAseguradora As New FormAseguradora(_username)
                formAseguradora.Show()
            Case "Mecanico"
                Dim formMecanico As New FormMecanico(_username)
                formMecanico.Show()
            Case "Vendedor"
                Dim formVendedor As New FormVendedor(_username)
                formVendedor.Show()
            Case Else
                MessageBox.Show("Tipo de usuario no reconocido.")
        End Select

        ' Ocultar el formulario actual después de abrir el nuevo
        Me.Hide()
    End Sub

    ' Evento del botón que redirige al formulario de repuestos
    Private Sub BtnRepuestosForm_Click(sender As Object, e As EventArgs) Handles BtnRepuestosForm.Click
        Dim formRepuestos As New FormRepuestos()
        formRepuestos.Show()

        ' Ocultar el formulario actual después de abrir el formulario de repuestos
        Me.Hide()
    End Sub

    Private Sub FormEnlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles BtnCambiarUsuario.Click
        ' Cerrar el formulario de enlaces
        Me.Close()

        ' Mostrar el formulario de login
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
    ' Evento del botón que redirige al formulario de ventas de repuestos
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim formVentaRepuestos As New FormVentaRepuestos()
        formVentaRepuestos.Show()

        ' Ocultar el formulario actual después de abrir el formulario de ventas de repuestos
        Me.Hide()
    End Sub

    Private Sub btnSiniestros_Click(sender As Object, e As EventArgs) Handles btnSiniestros.Click
        Dim formSiniestros As New FormSiniestros()
        formSiniestros.Show()

        Me.Hide()
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        Dim formSolicitudes As New FormSolicitudes()
        formSolicitudes.Show()

        Me.Hide()

    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click

        Dim formAgregarCliente As New FormAgregarCliente()
        formAgregarCliente.ShowDialog()
    End Sub
End Class
