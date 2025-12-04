Imports System.Data.SqlClient
Public Class Form1

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close() 'ceramos la ventana cuando le dan al boton cerrar'
    End Sub
    'variables para arrastrar la ventana'
    Dim ex, ey As Integer 'coordenadaz internas del mouse pa saber donde arrastro la ventana'
    Dim Arrastre As Boolean ' si estoy arrastrando o no'

    Private Sub panellTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panellTitulo.MouseDown
        ex = e.X 'guardamos la pos X cuando le dan click'
        ey = e.Y 'guardamos la pos Y tambien obvio'
        Arrastre = True 'permite arrastrar la ventana'
    End Sub

    Private Sub panellTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panellTitulo.MouseMove
        ' movemos la ventana dependiendo de como arrastre el mouse'
        If Arrastre Then Location = Me.PointToScreen(New Point(Form1.MousePosition.X - Location.X - ex, Form1.MousePosition.Y - Location.Y - ey))
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelcontenido.Visible = True 'mostramos el panel datos xq vamos a meter datos nuevos'
        panelDatos.Visible = False 'mostramos el panel datos xq vamos a meter datos nuevos'

        btnGuardar.Enabled = True 'habilitamos guardar'
        btnModificar.Enabled = False 'desactivamos modificar'
        lblIdentidad.Focus() 'ponemos el cursor directo en txtidentidad'
    End Sub
    Private Sub panellTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles panellTitulo.MouseUp
        Arrastre = False 'ya no arrastramos la ventana'
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGuardar.Enabled = False 'cuando cancela, activamos de nuevo guardar'
        btnModificar.Enabled = True 'habilitamos modificar'
        panelcontenido.Visible = False 'mostramos el panel datos xq vamos a meter datos nuevos'
        panelDatos.Visible = True 'ocultamos el panel de datos para ver el grid'
        limpiarcampos() 'borramos todos los espacios'
    End Sub
    Private Sub limpiarcampos()
        'metodo vaciar espacio ojo VACIAR NO LIMPIAR'
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
        txtObservaciones.Clear()
    End Sub
    Private Sub panellTitulo_Paint(sender As Object, e As PaintEventArgs) Handles panellTitulo.Paint
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cmd As New SqlCommand
        ' revisa que los datos no vengan vacios'
        If txtNombre.Text <> " " And txtIdentidad.Text <> " " Then
            Try
                CONECTAR_BIBLIOTECA() 'abrimos la conexion con la BD'
                cmd = New SqlCommand("Insertar_Lector", CONEXION) 'comando que llama el procediminto almacenado '
                cmd.CommandType = 4 '4 = Stored Procedure’
                'mandamos los valores al procedimiento sobre cada parámetro '
                cmd.Parameters.AddWithValue("@idLector", txtIdentidad.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text)
                cmd.ExecuteNonQuery() 'ejecutamos la insercion ejecutando la consulta'
                DESCONECTAR_BIBLIOTECA() 'cerramos la conexion después de cada proceso'
                panelDatos.Visible = False 'quitamos el panel datos'
                limpiarcampos() 'limpiamos los espacios'
                mostrar() 'recargamos el grid de los datos'
            Catch ex As Exception
                MessageBox.Show("OCURRIO UN ERROR GUARDANDO EL LECTOR" & vbCrLf & vbCrLf &
 ex.Message, "GUARDAR LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("LLENE IDENTIDAD Y NOMBRE COMPLETO, SON OBLIGATORIOS",
 "SISTEMA LECTORES",
 MessageBoxButtons.OK,
 MessageBoxIcon.Warning) 'warning icono de advertencai’
        End If
    End Sub
    Sub mostrar()
        'metodo par mostrar todos los lectores en el grid'

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            panelcontenido.Visible = False 'mostramos el panel datos xq vamos a meter datos nuevos'
            panelDatos.Visible = True 'ocultamos el panel de datos para ver el grid'
            CONECTAR_BIBLIOTECA()
            da = New SqlDataAdapter("Mostrar_Lector", CONEXION)
            da.Fill(dt)
            dataLectores.DataSource = dt
            DESCONECTAR_BIBLIOTECA()
            'configuramos las columnas'
            If dataLectores.Columns.Count >= 0 Then
                dataLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                dataLectores.Columns(0).Width = 35 'debes calcular el espacio para cada registro’
                dataLectores.Columns(1).Width = 120
                dataLectores.Columns(2).Width = 200
                dataLectores.Columns(3).Width = 100
                dataLectores.Columns(4).Width = 300
                dataLectores.Columns(5).Width = 300
                'modificar algunas propiedades de al interfaz'
                dataLectores.EnableHeadersVisualStyles = False
                Dim estiloEncabezado As New DataGridViewCellStyle
                estiloEncabezado.BackColor = Color.White
                estiloEncabezado.ForeColor = Color.Black
                estiloEncabezado.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                dataLectores.ColumnHeadersDefaultCellStyle = estiloEncabezado
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub buscar()
        'buscar por nombre o identidad, datos principale'
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            CONECTAR_BIBLIOTECA()
            da = New SqlDataAdapter("Buscar_Lector", CONEXION) 'procedimiento almacenado de busqueda’
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", txtBuscar.Text)
            da.Fill(dt)
            dataLectores.DataSource = dt
            DESCONECTAR_BIBLIOTECA()
            'mismo formato que metodo mostrar'
            If dataLectores.Columns.Count >= 0 Then
                dataLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                dataLectores.Columns(0).Width = 35
                dataLectores.Columns(1).Width = 120
                dataLectores.Columns(2).Width = 200
                dataLectores.Columns(3).Width = 100
                dataLectores.Columns(4).Width = 300
                dataLectores.Columns(5).Width = 300
                dataLectores.EnableHeadersVisualStyles = False
                Dim estiloEncabezado As New DataGridViewCellStyle
                estiloEncabezado.BackColor = Color.White
                estiloEncabezado.ForeColor = Color.Black
                estiloEncabezado.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                dataLectores.ColumnHeadersDefaultCellStyle = estiloEncabezado
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar() 'detecta escritura en e ltext y ejechuta la búsqueda '
        panelDatos.Visible = False
    End Sub
    Private Sub frmLECTORES_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar() 'cuando abre la ventana cargamos la lista de registros'
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'modifibcar sobre registros existentes '
        Dim cmd As New SqlCommand
        If lblNombre.Text <> " " And lblIdentidad.Text <> " " Then
            Try
                CONECTAR_BIBLIOTECA()
                cmd = New SqlCommand("Editar_Lector", CONEXION)
                cmd.CommandType = 4
                'se modifican directamente sobre cada espacio y se actualizalos datos'
                cmd.Parameters.AddWithValue("@idLector", txtIdentidad.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text)
                cmd.ExecuteNonQuery()
                DESCONECTAR_BIBLIOTECA()
                panelDatos.Visible = False
                limpiarcampos()
                mostrar()
            Catch ex As Exception
                MessageBox.Show("ERROR MODIFICANDO EL LECTOR," & vbCrLf & vbCrLf &
 ex.Message, "MODIFICAR LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("LLENE IDENTIDAD Y NOMBRE COMPLETO, OBLIGATORIO",
 "SISTEMA LECTORES",
 MessageBoxButtons.OK,
 MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub dataLectores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellDoubleClick
        'cuando hacen doble clic cargamos los datos pa modificar'
        panelcontenido.Visible = True
        Try
            'ojo no se toma en cuenta la posicion 0 porque es el sitio del botón de eliminar’
            txtIdentidad.Text = dataLectores.SelectedCells.Item(1).Value
            txtNombre.Text = dataLectores.SelectedCells.Item(2).Value
            txtTelefono.Text = dataLectores.SelectedCells.Item(3).Value
            txtDireccion.Text = dataLectores.SelectedCells.Item(4).Value
            txtObservaciones.Text = dataLectores.SelectedCells.Item(5).Value
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dataLectores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellContentClick

        'Evitar error al hacer click en encabezados'
        If e.RowIndex < 0 Then Exit Sub

        'Verifica que la columna es la de eliminar'
        If e.ColumnIndex = dataLectores.Columns("Eliminar").Index Then

            Dim resultado = MessageBox.Show(
            "¿DESEAS ELIMINAR ESTE REGISTRO?",
            "ELIMINAR LECTOR",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question
        )

            If resultado <> DialogResult.OK Then Exit Sub

            Try
                '*** OBTENER EL ID DE MANERA SEGURA ***'
                Dim idLector As String = dataLectores.Rows(e.RowIndex).Cells(1).Value.ToString()

                CONECTAR_BIBLIOTECA()

                Dim cmd As New SqlCommand("Eliminar_Lector", CONEXION)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idLector", idLector)
                cmd.ExecuteNonQuery()

                DESCONECTAR_BIBLIOTECA()

                MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                mostrar()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try

        End If
    End Sub
End Class
