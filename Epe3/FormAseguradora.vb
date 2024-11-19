Imports MySql.Data.MySqlClient

Public Class FormAseguradora
    Private userName As String ' Variable para almacenar el correo del usuario
    Private connectionString As String = "Server=localhost;Database=epe3;Uid=root;Pwd=;" ' Ajusta según tu configuración
    Private connection As New MySqlConnection(connectionString)

    ' Constructor que recibe el correo del usuario como parámetro
    Public Sub New(correo As String)
        ' Validar que el correo no sea vacío o nulo
        If String.IsNullOrWhiteSpace(correo) Then
            Throw New ArgumentNullException("correo", "El correo no puede ser nulo o vacío.")
        End If

        ' Llamada al diseñador del formulario
        InitializeComponent()

        ' Asignar el correo del usuario a la variable de clase
        Me.userName = correo
    End Sub


    ' Evento que se ejecuta cuando se carga el formulario principal
    Private Sub FormAseguradora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar un saludo personalizado en el Label lblWelcome
        lblWelcome.Text = "Bienvenido, " & userName & "!"
        LoadData() ' Cargar datos de usuarios en el DataGridView
    End Sub

    ' Cargar los datos de la tabla 'usuarios' en el DataGridView
    Private Sub LoadData()
        Try
            connection.Open()
            Dim query As String = "SELECT Rut, Correo, Contraseña, Tipo FROM usuarios"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dvgUsuarios.DataSource = table ' Asignar la tabla 'usuarios' al DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Este evento permite modificar cómo se muestran las celdas en tiempo de ejecución
    Private Sub dvgUsuarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dvgUsuarios.CellFormatting
        ' Verificar si la columna que se está formateando es la de "Contraseña"
        If dvgUsuarios.Columns(e.ColumnIndex).Name = "Contraseña" Then
            ' Mostrar los asteriscos en lugar de la contraseña real
            If e.Value IsNot Nothing Then
                e.Value = New String("*"c, e.Value.ToString().Length)
                e.FormattingApplied = True ' Indicar que el formato fue aplicado
            End If
        End If
    End Sub

    ' Validar que los campos no estén vacíos
    Private Function ValidateFields(rut As String, correo As String, contraseña As String, tipo As String) As Boolean
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("El campo 'Rut' no puede estar en blanco.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(correo) Then
            MessageBox.Show("El campo 'Correo' no puede estar en blanco.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(contraseña) Then
            MessageBox.Show("El campo 'Contraseña' no puede estar en blanco.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(tipo) Then
            MessageBox.Show("El campo 'Tipo' no puede estar en blanco.")
            Return False
        End If
        Return True
    End Function

    ' Evento de clic para crear un nuevo usuario
    Private Sub BtnCrearUsuario_Click(sender As Object, e As EventArgs) Handles BtnCrearUsuario.Click
        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim tipo As String = txtTipo.Text

        If ValidateFields(rut, correo, contraseña, tipo) Then
            Try
                connection.Open()
                Dim query As String = "INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@Rut, @Correo, @Contraseña, @Tipo)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Rut", rut)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@Contraseña", contraseña)
                cmd.Parameters.AddWithValue("@Tipo", tipo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario creado correctamente.")
                LoadData() ' Recargar los datos en el DataGridView
            Catch ex As Exception
                MessageBox.Show("Error al crear usuario: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        LoadData()
    End Sub

    ' Evento de clic para modificar un usuario existente
    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click
        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim tipo As String = txtTipo.Text

        If ValidateFields(rut, correo, contraseña, tipo) Then
            Try
                connection.Open()
                Dim query As String = "UPDATE usuarios SET Correo = @Correo, Contraseña = @Contraseña, Tipo = @Tipo WHERE Rut = @Rut"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Rut", rut)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@Contraseña", contraseña)
                cmd.Parameters.AddWithValue("@Tipo", tipo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario modificado correctamente.")
                LoadData() ' Recargar los datos en el DataGridView
            Catch ex As Exception
                MessageBox.Show("Error al modificar usuario: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        LoadData()
    End Sub

    ' Evento de clic para eliminar un usuario
    Private Sub BtnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BtnEliminarUsuario.Click
        Dim rut As String = txtRut.Text

        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe ingresar el 'Rut' del usuario a eliminar.")
        Else
            Try
                connection.Open()
                Dim query As String = "DELETE FROM usuarios WHERE Rut = @Rut"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Rut", rut)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario eliminado correctamente.")
                LoadData() ' Recargar los datos en el DataGridView
            Catch ex As Exception
                MessageBox.Show("Error al eliminar usuario: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        LoadData()
    End Sub

    ' Evento de clic para cerrar sesión
    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        ' Cerrar el formulario principal y mostrar el formulario de login
        Dim loginForm As New LoginForm()
        loginForm.Show() ' Mostrar el formulario de login
        Me.Hide() ' Ocultar el formulario
    End Sub

    ' Evento para seleccionar un usuario en el DataGridView y cargar los datos en los campos de texto
    Private Sub dvgUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dvgUsuarios.SelectionChanged
        If dvgUsuarios.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dvgUsuarios.SelectedRows(0)
            txtRut.Text = selectedRow.Cells("Rut").Value.ToString()
            txtCorreo.Text = selectedRow.Cells("Correo").Value.ToString()
            txtContraseña.Text = selectedRow.Cells("Contraseña").Value.ToString()
            txtTipo.Text = selectedRow.Cells("Tipo").Value.ToString()
        End If
    End Sub
End Class
