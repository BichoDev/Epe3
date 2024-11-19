Imports MySql.Data.MySqlClient

Public Class FormRepuestos
    ' Cadena de conexión a la base de datos MySQL
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    ' Cargar el formulario y mostrar los repuestos existentes
    Private Sub FormRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
    End Sub

    ' Función para cargar los repuestos en el DataGridView
    Private Sub CargarRepuestos()
        Dim query As String = "SELECT * FROM repuestos"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvRepuestos.DataSource = table
            End Using
        End Using
    End Sub

    ' Función para agregar un nuevo repuesto
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validar que todos los campos obligatorios estén llenos
        If String.IsNullOrWhiteSpace(txtNombreRepuesto.Text) OrElse String.IsNullOrWhiteSpace(txtCantidadStock.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioUnitario.Text) OrElse String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return
        End If

        ' Validar que el campo de cantidad sea un número entero positivo
        Dim cantidad As Integer
        If Not Integer.TryParse(txtCantidadStock.Text, cantidad) OrElse cantidad < 0 Then
            MessageBox.Show("La cantidad debe ser un número entero positivo.")
            Return
        End If

        ' Validar que el precio unitario sea un número decimal positivo
        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecioUnitario.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("El precio unitario debe ser un valor decimal positivo.")
            Return
        End If

        ' Validar que no se ingrese un repuesto duplicado (por nombre)
        If ExisteRepuesto(txtNombreRepuesto.Text) Then
            MessageBox.Show("Ya existe un repuesto con este nombre.")
            Return
        End If

        ' Insertar el nuevo repuesto en la base de datos
        Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@NombreRepuesto, @CantidadStock, @PrecioUnitario, @Proveedor)"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NombreRepuesto", txtNombreRepuesto.Text)
                cmd.Parameters.AddWithValue("@CantidadStock", txtCantidadStock.Text)
                cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text)
                cmd.Parameters.AddWithValue("@Proveedor", txtProveedor.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Repuesto agregado correctamente.")
                CargarRepuestos() ' Actualiza la vista de repuestos
            End Using
        End Using
    End Sub

    ' Función para verificar si ya existe un repuesto con el mismo nombre
    Private Function ExisteRepuesto(nombreRepuesto As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM repuestos WHERE NombreRepuesto=@NombreRepuesto"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NombreRepuesto", nombreRepuesto)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Función para actualizar un repuesto existente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Validar que se haya seleccionado un repuesto
        If String.IsNullOrWhiteSpace(txtRepuestoID.Text) Then
            MessageBox.Show("Seleccione un repuesto para actualizar.")
            Return
        End If

        ' Validar que todos los campos obligatorios estén llenos
        If String.IsNullOrWhiteSpace(txtNombreRepuesto.Text) OrElse String.IsNullOrWhiteSpace(txtCantidadStock.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioUnitario.Text) OrElse String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return
        End If

        ' Validar que el campo de cantidad sea un número entero positivo
        Dim cantidad As Integer
        If Not Integer.TryParse(txtCantidadStock.Text, cantidad) OrElse cantidad < 0 Then
            MessageBox.Show("La cantidad debe ser un número entero positivo.")
            Return
        End If

        ' Validar que el precio unitario sea un número decimal positivo
        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecioUnitario.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("El precio unitario debe ser un valor decimal positivo.")
            Return
        End If

        ' Actualizar el repuesto en la base de datos
        Dim query As String = "UPDATE repuestos SET NombreRepuesto=@NombreRepuesto, CantidadStock=@CantidadStock, PrecioUnitario=@PrecioUnitario, Proveedor=@Proveedor WHERE RepuestoID=@RepuestoID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NombreRepuesto", txtNombreRepuesto.Text)
                cmd.Parameters.AddWithValue("@CantidadStock", txtCantidadStock.Text)
                cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text)
                cmd.Parameters.AddWithValue("@Proveedor", txtProveedor.Text)
                cmd.Parameters.AddWithValue("@RepuestoID", txtRepuestoID.Text)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Repuesto actualizado correctamente.")
                    CargarRepuestos()
                Else
                    MessageBox.Show("No se encontró el repuesto especificado.")
                End If
            End Using
        End Using
    End Sub

    ' Función para eliminar un repuesto
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtRepuestoID.Text) Then
            MessageBox.Show("Seleccione un repuesto para eliminar.")
            Return
        End If

        Dim query As String = "DELETE FROM repuestos WHERE RepuestoID=@RepuestoID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RepuestoID", txtRepuestoID.Text)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Repuesto eliminado correctamente.")
                    CargarRepuestos()
                Else
                    MessageBox.Show("No se encontró el repuesto especificado.")
                End If
            End Using
        End Using
    End Sub

    ' Función para buscar repuestos por nombre o ID
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = "SELECT * FROM repuestos WHERE (RepuestoID=@RepuestoID OR @RepuestoID='') AND (NombreRepuesto LIKE @NombreRepuesto OR @NombreRepuesto='')"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RepuestoID", If(String.IsNullOrWhiteSpace(txtRepuestoID.Text), "", txtRepuestoID.Text))
                cmd.Parameters.AddWithValue("@NombreRepuesto", "%" & txtNombreRepuesto2.Text & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvRepuestos.DataSource = table
            End Using
        End Using
    End Sub

    ' Función para cerrar sesión y regresar al formulario de enlaces
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Me.Close()
        Dim formEnlaces As New FormEnlaces(LoginForm.TipoUsuario, LoginForm.Username)
        formEnlaces.Show()
    End Sub

End Class
