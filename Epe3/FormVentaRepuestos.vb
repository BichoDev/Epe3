Imports MySql.Data.MySqlClient

Public Class FormVentaRepuestos
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    ' Cargar el formulario y mostrar los repuestos existentes
    Private Sub FormVentaRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
        CargarClientes()
    End Sub

    ' Función para cargar los repuestos en un ComboBox
    Private Sub CargarRepuestos()
        Dim query As String = "SELECT NombreRepuesto, PrecioUnitario, CantidadStock FROM repuestos"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbNombreRepuesto.DataSource = table
                cmbNombreRepuesto.DisplayMember = "NombreRepuesto"
                cmbNombreRepuesto.ValueMember = "NombreRepuesto"
            End Using
        End Using
    End Sub

    ' Cargar clientes en ComboBox
    Private Sub CargarClientes()
        Dim query As String = "SELECT Rut, Nombre FROM clientes"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbCliente.DataSource = table
                cmbCliente.DisplayMember = "Nombre"
                cmbCliente.ValueMember = "Rut"
            End Using
        End Using
    End Sub

    ' Calcular el total
    Private Sub btnCalcularTotal_Click(sender As Object, e As EventArgs) Handles btnCalcularTotal.Click
        Dim cantidadVendida As Integer
        Dim precioUnitario As Decimal

        If Integer.TryParse(txtCantidadVendida.Text, cantidadVendida) AndAlso cantidadVendida > 0 Then
            ' Obtener el precio unitario del repuesto seleccionado
            Dim query As String = "SELECT PrecioUnitario FROM repuestos WHERE NombreRepuesto = @NombreRepuesto"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NombreRepuesto", cmbNombreRepuesto.SelectedValue)
                    conn.Open()
                    precioUnitario = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using

            ' Calcular y mostrar el total
            Dim total As Decimal = cantidadVendida * precioUnitario
            txtTotal.Text = total.ToString("F2")
        Else
            MessageBox.Show("Ingrese una cantidad válida.")
        End If
    End Sub

    ' Registrar la venta de repuestos
    Private Sub btnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Dim cantidadVendida As Integer
        Dim totalVenta As Decimal

        If Integer.TryParse(txtCantidadVendida.Text, cantidadVendida) AndAlso Decimal.TryParse(txtTotal.Text, totalVenta) Then
            ' Verificar el stock disponible
            Dim stockDisponible As Integer = ObtenerStockRepuesto(cmbNombreRepuesto.SelectedValue.ToString())
            If stockDisponible < cantidadVendida Then
                MessageBox.Show("No hay stock suficiente para realizar esta venta.")
                Return
            End If

            ' Insertar la venta en la base de datos
            Dim query As String = "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) VALUES (@NombreRepuesto, @CantidadVendida, @Cliente, @FechaVenta, @Total)"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NombreRepuesto", cmbNombreRepuesto.SelectedValue)
                    cmd.Parameters.AddWithValue("@CantidadVendida", cantidadVendida)
                    cmd.Parameters.AddWithValue("@Cliente", cmbCliente.SelectedValue)
                    cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Total", totalVenta)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Reducir el stock de repuestos
            ActualizarStock(cmbNombreRepuesto.SelectedValue.ToString(), stockDisponible - cantidadVendida)

            ' Verificar si se necesita enviar una alerta por bajo stock
            If stockDisponible - cantidadVendida <= 3 Then
                MessageBox.Show("Alerta: El stock del repuesto " & cmbNombreRepuesto.Text & " es bajo (3 o menos unidades).")
            End If

            MessageBox.Show("Venta registrada exitosamente.")
        Else
            MessageBox.Show("Por favor, ingrese los datos de la venta correctamente.")
        End If
    End Sub

    ' Función para obtener el stock actual del repuesto
    Private Function ObtenerStockRepuesto(nombreRepuesto As String) As Integer
        Dim query As String = "SELECT CantidadStock FROM repuestos WHERE NombreRepuesto = @NombreRepuesto"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NombreRepuesto", nombreRepuesto)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ' Función para actualizar el stock del repuesto
    Private Sub ActualizarStock(nombreRepuesto As String, nuevoStock As Integer)
        Dim query As String = "UPDATE repuestos SET CantidadStock = @NuevoStock WHERE NombreRepuesto = @NombreRepuesto"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NuevoStock", nuevoStock)
                cmd.Parameters.AddWithValue("@NombreRepuesto", nombreRepuesto)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Botón para mostrar el stock disponible del repuesto seleccionado
    Private Sub btnVerStock_Click(sender As Object, e As EventArgs) Handles btnVerStock.Click
        Dim stockDisponible As Integer = ObtenerStockRepuesto(cmbNombreRepuesto.SelectedValue.ToString())
        MessageBox.Show("El stock disponible de " & cmbNombreRepuesto.Text & " es: " & stockDisponible.ToString())
    End Sub

    Private Sub btnVerResumen_Click(sender As Object, e As EventArgs) Handles btnVerResumen.Click
        Dim formResumenVentas As New FormResumenVentas()
        formResumenVentas.Show()

        ' Ocultar el formulario actual después de abrir el formulario de ventas de repuestos
        Me.Hide()
    End Sub

    ' Evento Click para abrir el formulario de agregar cliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim formAgregarCliente As New FormAgregarCliente()
        formAgregarCliente.ShowDialog()

        ' Recargar la lista de clientes después de agregar uno nuevo
        CargarClientes()
    End Sub

End Class
