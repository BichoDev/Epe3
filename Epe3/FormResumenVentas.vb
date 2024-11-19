Imports MySql.Data.MySqlClient

Public Class FormResumenVentas
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"
    Private clientesRut As New Dictionary(Of String, String) ' Para almacenar el nombre y el RUT correspondiente

    Private Sub FormResumenVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarResumenVentas()
        CargarFechasVentas() ' Cargar las fechas únicas al cargar el formulario
        CargarClientes() ' Cargar clientes al inicio
        CargarRepuestos() ' Cargar repuestos al inicio
    End Sub

    ' Cargar el resumen de ventas completo
    Private Sub CargarResumenVentas(Optional filter As String = "")
        Dim query As String = "SELECT * FROM ventasrepuestos" & filter
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvVentas.DataSource = table
            End Using
        End Using
    End Sub

    ' Cargar fechas únicas de ventas
    Private Sub CargarFechasVentas()
        Dim query As String = "SELECT DISTINCT DATE(FechaVenta) AS Fecha FROM ventasrepuestos ORDER BY Fecha"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Limpiar fechas anteriores
                cmbFechasVentas.Items.Clear()

                ' Agregar fechas únicas al ComboBox
                While reader.Read()
                    cmbFechasVentas.Items.Add(reader.GetDateTime("Fecha").ToString("yyyy-MM-dd"))
                End While
            End Using
        End Using
    End Sub

    ' Cargar clientes en cmbNombreClientes
    Private Sub CargarClientes()
        Dim query As String = "SELECT Rut, CONCAT(Nombre, ' ', ApellidoP, ' ', ApellidoM) AS NombreCompleto FROM clientes"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Limpiar clientes anteriores
                cmbNombreClientes.Items.Clear()
                clientesRut.Clear() ' Limpiar el diccionario

                ' Agregar clientes al ComboBox
                While reader.Read()
                    Dim rut As String = reader.GetString("Rut")
                    Dim nombreCompleto As String = reader.GetString("NombreCompleto")
                    cmbNombreClientes.Items.Add(nombreCompleto)
                    clientesRut(nombreCompleto) = rut ' Guardar el RUT correspondiente
                End While
            End Using
        End Using
    End Sub

    ' Cargar repuestos en cmbNombreRepuesto
    Private Sub CargarRepuestos()
        Dim query As String = "SELECT NombreRepuesto FROM repuestos"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Limpiar repuestos anteriores
                cmbNombreRepuesto.Items.Clear()

                ' Agregar repuestos al ComboBox
                While reader.Read()
                    cmbNombreRepuesto.Items.Add(reader.GetString("NombreRepuesto"))
                End While
            End Using
        End Using
    End Sub

    ' Filtrar las ventas
    Private Sub btnFiltrarVentas_Click(sender As Object, e As EventArgs) Handles btnFiltrarVentas.Click
        Dim filter As String = " WHERE 1=1"

        If cmbNombreClientes.SelectedItem IsNot Nothing Then
            Dim nombreCliente As String = cmbNombreClientes.SelectedItem.ToString()
            If clientesRut.ContainsKey(nombreCliente) Then
                Dim rutCliente As String = clientesRut(nombreCliente) ' Obtener el RUT correspondiente
                filter &= " AND Cliente = '" & rutCliente & "'" ' Filtrar por RUT
            End If
        End If
        If cmbNombreRepuesto.SelectedItem IsNot Nothing Then
            filter &= " AND NombreRepuesto = '" & cmbNombreRepuesto.SelectedItem.ToString() & "'"
        End If
        If cmbFechasVentas.SelectedItem IsNot Nothing Then
            filter &= " AND FechaVenta = '" & cmbFechasVentas.SelectedItem.ToString() & "'"
        End If

        CargarResumenVentas(filter)
    End Sub

    Private Sub btnRegistrarNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarNuevaVenta.Click
        Dim registroForm As New FormVentaRepuestos()
        registroForm.Show()
        Me.Hide()
    End Sub
End Class
