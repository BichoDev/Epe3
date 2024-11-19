Imports MySql.Data.MySqlClient

Public Class FormSolicitudes
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    ' Cargar el formulario
    Private Sub FormSolicitudesServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRutClientes()
        CargarRutEmpleados()
        CargarSiniestros()
        CargarSolicitudes()
        cmbEstado.Items.AddRange({"Recibida", "En Proceso", "Completado"})
        cmbBuscarEstado.Items.AddRange({"Recibida", "En Proceso", "Completado"})
    End Sub

    ' Cargar solicitudes de servicio en el DataGridView
    Private Sub CargarSolicitudes()
        Dim query As String = "
        SELECT s.SolicitudID, s.Rut, s.FechaSolicitud, s.DescripcionProblema, 
               s.Estado, si.SiniestroID AS IDSiniestro, s.RutEmpleado
        FROM solicitudesservicio s
        LEFT JOIN siniestro si ON s.Siniestroid = si.SiniestroID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Asegúrate de que las columnas estén correctamente definidas
                    dgvSolicitudes.DataSource = table

                    ' Opcional: Si necesitas cambiar el nombre de las columnas en el DataGridView
                    dgvSolicitudes.Columns("SolicitudID").HeaderText = "ID Solicitud"
                    dgvSolicitudes.Columns("Rut").HeaderText = "RUT Cliente"
                    dgvSolicitudes.Columns("FechaSolicitud").HeaderText = "Fecha de Solicitud"
                    dgvSolicitudes.Columns("DescripcionProblema").HeaderText = "Descripción del Problema"
                    dgvSolicitudes.Columns("Estado").HeaderText = "Estado"
                    dgvSolicitudes.Columns("IDSiniestro").HeaderText = "ID Siniestro"
                    dgvSolicitudes.Columns("RutEmpleado").HeaderText = "RUT Empleado"
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar solicitudes: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Cargar los RUTs de los clientes en el ComboBox
    Private Sub CargarRutClientes()
        Dim query As String = "SELECT Rut FROM clientes"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbRut.Items.Clear()
                        While reader.Read()
                            cmbRut.Items.Add(reader("Rut").ToString())
                            cmbFiltrarRut.Items.Add(reader("Rut").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar RUT de clientes: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Cargar los RUTs de los empleados en el ComboBox
    Private Sub CargarRutEmpleados()
        Dim query As String = "SELECT Rut FROM empleados"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbRutEmpleado.Items.Clear()
                        While reader.Read()
                            cmbRutEmpleado.Items.Add(reader("Rut").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar RUT de empleados: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Cargar los siniestros en el ComboBox (mostrando detalles pero guardando el ID)
    Private Sub CargarSiniestros()
        Dim query As String = "SELECT SiniestroID, Detalle FROM siniestro"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim siniestros As New Dictionary(Of Integer, String)
                        While reader.Read()
                            siniestros.Add(Convert.ToInt32(reader("SiniestroID")), reader("Detalle").ToString())
                        End While
                        cmbSiniestroID.DataSource = New BindingSource(siniestros, Nothing)
                        cmbSiniestroID.DisplayMember = "Value"
                        cmbSiniestroID.ValueMember = "Key"
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar siniestros: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Registrar una nueva solicitud de servicio
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If cmbRut.SelectedIndex = -1 OrElse cmbSiniestroID.SelectedIndex = -1 OrElse
           cmbRutEmpleado.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtDescripcionProblema.Text) OrElse
           cmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        Dim query As String = "INSERT INTO solicitudesservicio (Rut, FechaSolicitud, DescripcionProblema, Estado, Siniestroid, RutEmpleado) 
                               VALUES (@Rut, @FechaSolicitud, @DescripcionProblema, @Estado, @Siniestroid, @RutEmpleado)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Rut", cmbRut.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@FechaSolicitud", dtpFechaSolicitud.Value)
                    cmd.Parameters.AddWithValue("@DescripcionProblema", txtDescripcionProblema.Text)
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Siniestroid", DirectCast(cmbSiniestroID.SelectedItem, KeyValuePair(Of Integer, String)).Key)
                    cmd.Parameters.AddWithValue("@RutEmpleado", cmbRutEmpleado.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Solicitud registrada correctamente.")
                    CargarSolicitudes()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al registrar solicitud: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Cambiar el estado de una solicitud seleccionada
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If dgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una solicitud para actualizar.")
            Return
        End If

        ' Obtener el SolicitudID desde la fila seleccionada
        Dim solicitudID As Integer = Convert.ToInt32(dgvSolicitudes.SelectedRows(0).Cells("SolicitudID").Value)

        ' Obtener los nuevos valores de los campos del DataGridView
        Dim rutCliente As String = dgvSolicitudes.SelectedRows(0).Cells("Rut").Value.ToString()
        Dim fechaSolicitud As DateTime = Convert.ToDateTime(dgvSolicitudes.SelectedRows(0).Cells("FechaSolicitud").Value)
        Dim descripcionProblema As String = dgvSolicitudes.SelectedRows(0).Cells("DescripcionProblema").Value.ToString()
        Dim estado As String = dgvSolicitudes.SelectedRows(0).Cells("Estado").Value.ToString()
        Dim rutEmpleado As String = dgvSolicitudes.SelectedRows(0).Cells("RutEmpleado").Value.ToString()

        ' Validar que todos los campos necesarios estén llenos
        If String.IsNullOrWhiteSpace(descripcionProblema) OrElse String.IsNullOrEmpty(estado) OrElse String.IsNullOrEmpty(rutEmpleado) Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Mostrar los valores que se van a actualizar (esto puede ayudar a verificar si son correctos)
        MessageBox.Show($"Actualizando Solicitud {solicitudID}: {rutCliente}, {fechaSolicitud}, {descripcionProblema}, {estado}, {rutEmpleado}")

        ' Actualizar la solicitud en la base de datos, excepto el campo SiniestroID
        Dim query As String = "UPDATE solicitudesservicio SET 
                           Rut = @Rut, 
                           FechaSolicitud = @FechaSolicitud, 
                           DescripcionProblema = @DescripcionProblema, 
                           Estado = @Estado, 
                           RutEmpleado = @RutEmpleado 
                           WHERE SolicitudID = @SolicitudID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Comprobamos la conexión
                If conn.State = ConnectionState.Open Then
                    MessageBox.Show("Conexión exitosa a la base de datos.")
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Rut", rutCliente)
                    cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud)
                    cmd.Parameters.AddWithValue("@DescripcionProblema", descripcionProblema)
                    cmd.Parameters.AddWithValue("@Estado", estado)
                    cmd.Parameters.AddWithValue("@RutEmpleado", rutEmpleado)
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID)

                    ' Ejecutamos la consulta de actualización
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Comprobar si la consulta se ejecutó correctamente
                    If rowsAffected > 0 Then
                        MessageBox.Show("Solicitud actualizada correctamente.")
                    Else
                        MessageBox.Show("No se pudo actualizar la solicitud. ¿Verificaste el SolicitudID?")
                    End If

                    ' Recargar los datos en el DataGridView para mostrar los cambios
                    CargarSolicitudes()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar solicitud: " & ex.Message)
            End Try
        End Using
    End Sub




    ' Asignar valores a los controles según la fila seleccionada
    Private Sub dgvSolicitudes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSolicitudes.SelectionChanged
        If dgvSolicitudes.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvSolicitudes.SelectedRows(0)

            ' Asignar valores a los controles según la fila seleccionada
            cmbRut.SelectedItem = selectedRow.Cells("Rut").Value.ToString()
            dtpFechaSolicitud.Value = Convert.ToDateTime(selectedRow.Cells("FechaSolicitud").Value)
            txtDescripcionProblema.Text = selectedRow.Cells("DescripcionProblema").Value.ToString()
            cmbEstado.SelectedItem = selectedRow.Cells("Estado").Value.ToString()
            cmbRutEmpleado.SelectedItem = selectedRow.Cells("RutEmpleado").Value.ToString()

            ' Asignar el valor correcto para el SiniestroID
            Dim siniestroID As Integer = Convert.ToInt32(selectedRow.Cells("IDSiniestro").Value)
            For Each item As KeyValuePair(Of Integer, String) In DirectCast(cmbSiniestroID.DataSource, BindingSource).List
                If item.Key = siniestroID Then
                    cmbSiniestroID.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim formLogin As New LoginForm()
        formLogin.Show()

        Me.Hide()
    End Sub
End Class
