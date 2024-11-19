Imports MySql.Data.MySqlClient

Public Class FormSiniestros
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;" ' Configura según tu base de datos

    ' Cargar el formulario y configurar opciones iniciales
    Private Sub FormSiniestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSiniestros()
        cmbEstadoSiniestro.Items.AddRange({"Activo", "Pendiente", "Finalizado"})
        cmbEstadoSeguro.Items.AddRange({"Vigente", "Inactivo"})
        cmbBuscarEstado.Items.AddRange({"Activo", "Pendiente", "Finalizado"})
    End Sub

    ' Función para cargar siniestros en el DataGridView
    Private Sub CargarSiniestros()
        Try
            Dim query As String = "SELECT * FROM siniestro"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvSiniestros.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los siniestros: " & ex.Message)
        End Try
    End Sub

    ' Función para actualizar el estado de un siniestro
    ' Función para actualizar el detalle, estado de siniestro y estado de seguro
    Private Sub btnActualizarEstado_Click(sender As Object, e As EventArgs) Handles btnActualizarEstado.Click
        If dgvSiniestros.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona un siniestro para actualizar.")
            Return
        End If

        Dim siniestroID As Integer
        Try
            siniestroID = Convert.ToInt32(dgvSiniestros.SelectedRows(0).Cells("SiniestroID").Value)
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID del siniestro: " & ex.Message)
            Return
        End Try

        ' Validar los campos obligatorios
        If String.IsNullOrWhiteSpace(txtDetalle.Text) OrElse
       cmbEstadoSiniestro.SelectedIndex = -1 OrElse
       cmbEstadoSeguro.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, completa todos los campos obligatorios.")
            Return
        End If

        Dim nuevoEstadoSiniestro As String = cmbEstadoSiniestro.SelectedItem.ToString()
        Dim nuevoEstadoSeguro As String = cmbEstadoSeguro.SelectedItem.ToString()
        Dim nuevoDetalle As String = txtDetalle.Text

        Dim query As String = "UPDATE siniestro 
                           SET Estado_Siniestro = @Estado_Siniestro, 
                               Estado_Seguro = @Estado_Seguro, 
                               Detalle = @Detalle 
                           WHERE SiniestroID = @SiniestroID"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Asignar los parámetros a la consulta
                    cmd.Parameters.AddWithValue("@Estado_Siniestro", nuevoEstadoSiniestro)
                    cmd.Parameters.AddWithValue("@Estado_Seguro", nuevoEstadoSeguro)
                    cmd.Parameters.AddWithValue("@Detalle", nuevoDetalle)
                    cmd.Parameters.AddWithValue("@SiniestroID", siniestroID)

                    ' Ejecutar la consulta
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("El siniestro se actualizó correctamente.")
                    Else
                        MessageBox.Show("No se encontró el siniestro a actualizar.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el siniestro: " & ex.Message)
        End Try

        ' Recargar datos y mostrar cambios en el DataGridView
        CargarSiniestros()
        SeleccionarFilaPorID(siniestroID)
    End Sub


    ' Función para seleccionar la fila actualizada en el DataGridView
    Private Sub SeleccionarFilaPorID(siniestroID As Integer)
        For Each row As DataGridViewRow In dgvSiniestros.Rows
            If Convert.ToInt32(row.Cells("SiniestroID").Value) = siniestroID Then
                row.Selected = True
                dgvSiniestros.FirstDisplayedScrollingRowIndex = row.Index
                Exit For
            End If
        Next
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim formLogin As New LoginForm()
        formLogin.Show()

        Me.Hide()
    End Sub
End Class
