Imports MySql.Data.MySqlClient

Public Class FormAgregarCliente
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    ' Evento para guardar el cliente
    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidoP As String = txtApellidoP.Text
        Dim apellidoM As String = txtApellidoM.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim comuna As String = txtComuna.Text

        If ValidateFields(rut, nombre, apellidoP, direccion, telefono, comuna) Then
            Dim query As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) VALUES (@Rut, @Nombre, @ApellidoP, @ApellidoM, @Direccion, @Telefono, @Comuna)"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Rut", rut)
                    cmd.Parameters.AddWithValue("@Nombre", nombre)
                    cmd.Parameters.AddWithValue("@ApellidoP", apellidoP)
                    cmd.Parameters.AddWithValue("@ApellidoM", apellidoM)
                    cmd.Parameters.AddWithValue("@Direccion", direccion)
                    cmd.Parameters.AddWithValue("@Telefono", telefono)
                    cmd.Parameters.AddWithValue("@Comuna", comuna)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cliente agregado exitosamente.")
                End Using
            End Using
        End If

        ' Cerrar el formulario después de agregar el cliente
        Me.Close()
    End Sub

    ' Validación de campos
    Private Function ValidateFields(rut As String, nombre As String, apellidoP As String, direccion As String, telefono As String, comuna As String) As Boolean
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("El campo 'Rut' no puede estar vacío.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("El campo 'Nombre' no puede estar vacío.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(apellidoP) Then
            MessageBox.Show("El campo 'Apellido Paterno' no puede estar vacío.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(direccion) Then
            MessageBox.Show("El campo 'Dirección' no puede estar vacío.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(telefono) Then
            MessageBox.Show("El campo 'Teléfono' no puede estar vacío.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("El campo 'Comuna' no puede estar vacío.")
            Return False
        End If
        Return True
    End Function
End Class
