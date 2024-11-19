Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' Cadena de conexión a la base de datos MySQL
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    ' Variables privadas para almacenar el nombre de usuario y tipo
    Private _username As String
    Private _tipoUsuario As String

    ' Evento de clic en el botón de login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Validar que el nombre de usuario y la contraseña no estén vacíos
        If String.IsNullOrWhiteSpace(username) And String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Por favor ingresa un correo y una contraseña.")
            Return
        End If
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Por favor ingrese un correo.")
            Return
        End If
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Por favor ingrese una contraseña")
            Return
        End If

        ' Validar el login y obtener el tipo de usuario
        If ValidateLogin(username, password, _tipoUsuario) Then
            MessageBox.Show("Login exitoso")
            _username = username ' Almacenar el nombre de usuario en la variable privada
            Me.Hide() ' Ocultar el formulario de login

            ' Abrir el formulario correspondiente según el tipo de usuario
            Select Case _tipoUsuario
                Case "Gerente"
                    Dim mainForm As New MainForm(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case "Administrador"
                    Dim formAdministrador As New FormAdministrador(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case "Analista"
                    Dim formAnalista As New FormAnalista(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case "Aseguradora"
                    Dim formAseguradora As New FormAseguradora(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case "Mecanico"
                    Dim formMecanico As New FormMecanico(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case "Vendedor"
                    Dim formVendedor As New FormVendedor(_username)
                    Dim formEnlaces As New FormEnlaces(_tipoUsuario, _username) ' Crear una instancia de FormEnlaces
                    formEnlaces.Show()
                Case Else
                    MessageBox.Show("Tipo de usuario no reconocido.")
            End Select
        Else
            MessageBox.Show("Correo o contraseña incorrectos")
        End If
    End Sub

    ' Función para validar el login en la base de datos MySQL
    Private Function ValidateLogin(correo As String, contraseña As String, ByRef tipoUsuario As String) As Boolean
        Dim query As String = "SELECT Tipo FROM usuarios WHERE Correo=@Correo AND Contraseña=@Contraseña"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@Contraseña", contraseña)

                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    tipoUsuario = result.ToString()
                    Return True
                End If
                Return False
            End Using
        End Using
    End Function

    ' Propiedad para obtener el correo del usuario
    Public ReadOnly Property Username As String
        Get
            Return _username ' Devolver el valor de la variable privada
        End Get
    End Property

    ' Propiedad para obtener el tipo de usuario
    Public ReadOnly Property TipoUsuario As String
        Get
            Return _tipoUsuario ' Devolver el valor de la variable privada
        End Get
    End Property

End Class
