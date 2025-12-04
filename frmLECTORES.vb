Imports System.Data.SqlClient
Public Class Form1
    'este evento estaba solo pa probar la conexion '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load 'SOLO PAAR PROBAR LA CONEXION
        CONECTAR_BIBLIOTECA()
        MsgBox("CONEXION EXITOSA A LA BASE DE DATOS", MsgBoxStyle.Information, "CONEXION EXITOSA")
    End Sub

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
        panelDatos.Visible = True 'mostramos el panel datos xq vamos a meter datos nuevos'
        btnGuardar.Enabled = True 'habilitamos guardar'
        btnModificar.Enabled = False 'desactivamos modificar'
        lblIdentidad.Focus() 'ponemos el cursor directo en txtidentidad'
    End Sub
    Private Sub panellTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles panellTitulo.MouseUp
        Arrastre = False 'ya no arrastramos la ventana'
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGuardar.Enabled = True 'cuando cancela, activamos de nuevo guardar'
        btnModificar.Enabled = True 'habilitamos modificar'
        panelDatos.Visible = False 'ocultamos el panel de datos para ver el grid'
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
        If lblNombre.Text <> " " And lblIdentidad.Text <> " " Then
            Try
                CONECTAR_BIBLIOTECA() 'abrimos la conexion con la BD'
                cmd = New SqlCommand("Insertar_Lector", CONEXION) 'comando que llama el procediminto almacenado '
                cmd.CommandType = 4 '4 = Stored Procedure’
                'mandamos los valores al procedimiento sobre cada parámetro '
                cmd.Parameters.AddWithValue("@idLector", lblIdentidad.Text)
                cmd.Parameters.AddWithValue("@Nombre", lblNombre.Text)
                cmd.Parameters.AddWithValue("@Telefono", lblTelefono.Text)
                cmd.Parameters.AddWithValue("@Direccion", lblDireccion.Text)
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
                cmd.Parameters.AddWithValue("@idLector", lblIdentidad.Text)
                cmd.Parameters.AddWithValue("@Nombre", lblNombre.Text)
                cmd.Parameters.AddWithValue("@Telefono", lblTelefono.Text)
                cmd.Parameters.AddWithValue("@Direccion", lblDireccion.Text)
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
    Private Sub dataLectores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellContentDoubleClick
        'cuando hacen doble clic cargamos los datos pa modificar'
        panelDatos.Visible = True
        Try
            'ojo no se toma en cuenta la posicion 0 porque es el sitio del botón de eliminar’
            lblIdentidad.Text = dataLectores.SelectedCells.Item(1).Value
            lblNombre.Text = dataLectores.SelectedCells.Item(2).Value
            lblTelefono.Text = dataLectores.SelectedCells.Item(3).Value
            lblDireccion.Text = dataLectores.SelectedCells.Item(4).Value
            txtObservaciones.Text = dataLectores.SelectedCells.Item(5).Value
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dataLectores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellContentClick
        'detectamos click en el boton eliminar dentro del grid'
        If e.ColumnIndex = dataLectores.Columns.Item("Eliminar").Index Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿DESEAS ELIMINAR ESTE REGISTRO? ",
 "ELIMINAR LECTOR?",
 MessageBoxButtons.OKCancel,
 MessageBoxIcon.Question)
            If resultado = DialogResult.OK Then
                Dim cmd As New SqlCommand
                Try
                    CONECTAR_BIBLIOTECA()
                    cmd = New SqlCommand("Eliminar_Lector", CONEXION)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idLector", dataLectores.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    DESCONECTAR_BIBLIOTECA()
                    mostrar() 'actualizamos la tabla '
                Catch ex As Exception
                    MessageBox.Show("NO SE PUDO ELIMINAR EL LECTOR" & vbCrLf & vbCrLf &
 ex.Message, "ELIMINAR LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MsgBox("OPERACIÓN CANCELADA", vbInformation + vbOKOnly, "ELIMINACION CANCELADA")
            End If
        End If
    End Sub
End Class




