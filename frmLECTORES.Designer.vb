Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    ' NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    ' Se puede modificar usando el Diseñador de Windows Forms.
    ' No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        panelbusqueda = New Panel()
        PictureBox1 = New PictureBox() ' Usaremos este como un ícono de lupa moderno
        txtBuscar = New TextBox()
        panelcontenido = New Panel()
        btnCancelar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        txtObservaciones = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtNombre = New TextBox()
        txtIdentidad = New TextBox()
        lblObservaciones = New Label()
        lblDireccion = New Label()
        lblTelefono = New Label()
        lblNombre = New Label()
        lblIdentidad = New Label()
        panellTitulo = New Panel()
        btnCerrar = New Button()
        lblLectores = New Label()
        panelDatos = New Panel()
        dataLectores = New DataGridView()
        panellateral = New Panel()
        btnNuevo = New PictureBox() ' Usaremos este como un ícono de 'Agregar'
        Eliminar = New DataGridViewButtonColumn()

        panelbusqueda.SuspendLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        panelcontenido.SuspendLayout()
        panellTitulo.SuspendLayout()
        panelDatos.SuspendLayout()
        CType(dataLectores, System.ComponentModel.ISupportInitialize).BeginInit()
        panellateral.SuspendLayout()
        CType(btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        '
        ' Colores de Acento
        '
        Dim ColorFondoClaro As Color = Color.FromArgb(240, 240, 240) ' Gris Claro
        Dim ColorAcentoPrimario As Color = Color.FromArgb(33, 150, 243) ' Azul Moderno
        Dim ColorAcentoSecundario As Color = Color.FromArgb(76, 175, 80) ' Verde (Para Guardar)
        Dim ColorTextoOscuro As Color = Color.FromArgb(51, 51, 51) ' Gris Oscuro

        '
        ' panellTitulo - CABECERA
        '
        panellTitulo.BackColor = ColorAcentoPrimario
        panellTitulo.Controls.Add(btnCerrar)
        panellTitulo.Controls.Add(lblLectores)
        panellTitulo.Dock = DockStyle.Top
        panellTitulo.Size = New Size(621, 49)
        panellTitulo.TabIndex = 16

        '
        ' btnCerrar
        '
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.Transparent
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCerrar.ForeColor = Color.White
        btnCerrar.Location = New Point(585, 0)
        btnCerrar.Size = New Size(36, 35)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "X"
        btnCerrar.UseVisualStyleBackColor = False

        '
        ' lblLectores
        '
        lblLectores.AutoSize = True
        lblLectores.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblLectores.ForeColor = Color.White
        lblLectores.Location = New Point(15, 8)
        lblLectores.TabIndex = 2
        lblLectores.Text = "Gestión de Lectores"

        '
        ' panelbusqueda - BÚSQUEDA
        '
        panelbusqueda.BackColor = ColorFondoClaro
        panelbusqueda.Controls.Add(PictureBox1)
        panelbusqueda.Controls.Add(txtBuscar)
        panelbusqueda.Dock = DockStyle.Top
        panelbusqueda.Location = New Point(0, 49)
        panelbusqueda.Size = New Size(621, 60)
        panelbusqueda.TabIndex = 17

        '
        ' PictureBox1 (Icono de Búsqueda)
        '
        ' Idealmente aquí se cargaría un ícono de lupa
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(20, 18)
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False

        '
        ' txtBuscar
        '
        txtBuscar.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Font = New Font("Segoe UI", 10.0F)
        txtBuscar.Location = New Point(45, 18)
        txtBuscar.BorderStyle = BorderStyle.None ' Borde plano o nulo
        txtBuscar.Padding = New Padding(5)
        txtBuscar.Size = New Size(540, 20)
        txtBuscar.TabIndex = 0
        ' Texto de ayuda (Placeholder) en el evento Enter/Leave
        txtBuscar.Text = "Buscar por Identidad o Nombre..."

        '
        ' panelDatos - VISTA DE LISTA (Ocupa la mayor parte del espacio)
        '
        panelDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelDatos.Location = New Point(0, 109)
        panelDatos.Controls.Add(dataLectores)
        panelDatos.Size = New Size(621, 382)
        panelDatos.TabIndex = 19

        '
        ' dataLectores - GRILLA DE DATOS
        '
        dataLectores.AllowUserToAddRows = False
        dataLectores.AllowUserToDeleteRows = False
        dataLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataLectores.BackgroundColor = Color.White
        dataLectores.BorderStyle = BorderStyle.None ' Borde eliminado
        dataLectores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal ' Líneas horizontales suaves

        ' Estilo de encabezado
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = ColorFondoClaro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = ColorTextoOscuro
        DataGridViewCellStyle1.SelectionBackColor = ColorFondoClaro
        DataGridViewCellStyle1.SelectionForeColor = ColorTextoOscuro
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dataLectores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dataLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataLectores.ColumnHeadersHeight = 35

        ' Estilo de las filas
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = ColorTextoOscuro
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 230, 255) ' Azul muy claro al seleccionar
        DataGridViewCellStyle2.SelectionForeColor = ColorTextoOscuro
        dataLectores.DefaultCellStyle = DataGridViewCellStyle2

        ' Estilo para filas alternas (mayor contraste visual)
        dataLectores.RowsDefaultCellStyle.BackColor = Color.White
        dataLectores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248) ' Gris casi blanco

        dataLectores.GridColor = Color.LightGray ' Color suave para la línea
        dataLectores.RowHeadersVisible = False ' Oculta las flechas de selección
        dataLectores.Location = New Point(10, 10)
        dataLectores.Dock = DockStyle.Fill
        dataLectores.Columns.AddRange(New DataGridViewColumn() {Eliminar})

        '
        ' Eliminar (Columna de Botón)
        '
        Eliminar.HeaderText = "Acción"
        Eliminar.Name = "Eliminar"
        Eliminar.Text = "Eliminar"
        Eliminar.UseColumnTextForButtonValue = True
        Eliminar.Width = 80 ' Tamaño fijo para la acción

        '
        ' panellateral - PANEL DE ACCIONES FLOTANTE (Reemplazado por botones en la grilla o arriba)
        ' Este panel puede ser el que muestre el formulario de edición/nuevo en una vista Master-Detail
        ' Por ahora lo dejo para contener btnNuevo, pero recomiendo integrar btnNuevo en panelbusqueda
        '
        panellateral.Controls.Add(btnNuevo)
        panellateral.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panellateral.Location = New Point(580, 109)
        panellateral.Size = New Size(40, 40)
        panellateral.BackColor = Color.Transparent ' Hago el panel transparente

        '
        ' btnNuevo (Ícono de +)
        '
        ' Posiciona el botón '+' de forma flotante y visible.
        btnNuevo.BackColor = ColorAcentoSecundario ' Color de acento Verde
        btnNuevo.Location = New Point(0, 0)
        btnNuevo.Size = New Size(40, 40)
        btnNuevo.SizeMode = PictureBoxSizeMode.CenterImage ' Centrar la imagen
        btnNuevo.Cursor = Cursors.Hand
        ' Idealmente la imagen (resources.GetObject) debería ser un icono '+' blanco.
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image) ' Asumiendo que es un ícono de "+"
        btnNuevo.TabIndex = 0
        btnNuevo.TabStop = False


        '
        ' panelcontenido - FORMULARIO DE EDICIÓN/DETALLE
        '
        panelcontenido.BackColor = Color.White
        panelcontenido.Controls.Add(btnCancelar)
        panelcontenido.Controls.Add(btnModificar)
        panelcontenido.Controls.Add(btnGuardar)
        panelcontenido.Controls.Add(txtObservaciones)
        panelcontenido.Controls.Add(txtDireccion)
        panelcontenido.Controls.Add(txtTelefono)
        panelcontenido.Controls.Add(txtNombre)
        panelcontenido.Controls.Add(txtIdentidad)
        panelcontenido.Controls.Add(lblObservaciones)
        panelcontenido.Controls.Add(lblDireccion)
        panelcontenido.Controls.Add(lblTelefono)
        panelcontenido.Controls.Add(lblNombre)
        panelcontenido.Controls.Add(lblIdentidad)
        panelcontenido.Dock = DockStyle.Fill ' Ocupa todo el espacio para simular que aparece por encima o al lado
        panelcontenido.Location = New Point(0, 109) ' Se superpone con panelDatos, necesitarías un Toggle
        panelcontenido.Size = New Size(621, 382) ' Redimensionado para la nueva distribución

        '
        ' Etiquetas (Estilo ligero)
        '
        Dim labelFont As New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Dim labelColor As Color = Color.Gray

        lblIdentidad.AutoSize = True
        lblIdentidad.Font = labelFont
        lblIdentidad.ForeColor = labelColor
        lblIdentidad.Location = New Point(20, 40)
        lblIdentidad.Text = "Nº Identidad:"

        lblNombre.AutoSize = True
        lblNombre.Font = labelFont
        lblNombre.ForeColor = labelColor
        lblNombre.Location = New Point(20, 80)
        lblNombre.Text = "Nombre completo:"

        lblTelefono.AutoSize = True
        lblTelefono.Font = labelFont
        lblTelefono.ForeColor = labelColor
        lblTelefono.Location = New Point(20, 120)
        lblTelefono.Text = "Teléfono:"

        lblDireccion.AutoSize = True
        lblDireccion.Font = labelFont
        lblDireccion.ForeColor = labelColor
        lblDireccion.Location = New Point(20, 160)
        lblDireccion.Text = "Dirección:"

        lblObservaciones.AutoSize = True
        lblObservaciones.Font = labelFont
        lblObservaciones.ForeColor = labelColor
        lblObservaciones.Location = New Point(20, 200)
        lblObservaciones.Text = "Observaciones:"


        '
        ' TextBoxes (Estilo plano)
        '
        Dim textboxFont As New Font("Segoe UI", 10.0F)
        Dim textboxWidth As Integer = 450
        Dim offsetX As Integer = 150 ' Distancia X para las cajas de texto

        txtIdentidad.Location = New Point(offsetX, 38)
        txtIdentidad.Size = New Size(textboxWidth, 23)
        txtIdentidad.Font = textboxFont
        txtIdentidad.BorderStyle = BorderStyle.FixedSingle ' Borde simple para delimitar

        txtNombre.Location = New Point(offsetX, 78)
        txtNombre.Size = New Size(textboxWidth, 23)
        txtNombre.Font = textboxFont
        txtNombre.BorderStyle = BorderStyle.FixedSingle

        txtTelefono.Location = New Point(offsetX, 118)
        txtTelefono.Size = New Size(textboxWidth, 23)
        txtTelefono.Font = textboxFont
        txtTelefono.BorderStyle = BorderStyle.FixedSingle

        txtDireccion.Location = New Point(offsetX, 158)
        txtDireccion.Size = New Size(textboxWidth, 23)
        txtDireccion.Font = textboxFont
        txtDireccion.BorderStyle = BorderStyle.FixedSingle

        txtObservaciones.Location = New Point(offsetX, 198)
        txtObservaciones.Multiline = True
        txtObservaciones.Size = New Size(textboxWidth, 70)
        txtObservaciones.Font = textboxFont
        txtObservaciones.BorderStyle = BorderStyle.FixedSingle


        '
        ' Botones de Formulario (Estilo Moderno)
        '
        Dim buttonSize As New Size(100, 35)
        Dim buttonFont As New Font("Segoe UI", 10.0F, FontStyle.Bold)

        ' Botón Primario: Guardar (Azul)
        btnGuardar.Location = New Point(offsetX, 310)
        btnGuardar.Size = buttonSize
        btnGuardar.Text = "Guardar"
        btnGuardar.Font = buttonFont
        btnGuardar.BackColor = ColorAcentoSecundario ' Verde para acciones positivas
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.FlatAppearance.BorderSize = 0

        ' Botón Secundario: Modificar (Acento)
        btnModificar.Location = New Point(offsetX + 110, 310)
        btnModificar.Size = buttonSize
        btnModificar.Text = "Modificar"
        btnModificar.Font = buttonFont
        btnModificar.BackColor = ColorAcentoPrimario ' Azul
        btnModificar.ForeColor = Color.White
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.FlatAppearance.BorderSize = 0

        ' Botón Neutro: Cancelar (Gris)
        btnCancelar.Location = New Point(offsetX + 220, 310)
        btnCancelar.Size = buttonSize
        btnCancelar.Text = "Cancelar"
        btnCancelar.Font = buttonFont
        btnCancelar.BackColor = Color.LightGray
        btnCancelar.ForeColor = ColorTextoOscuro
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.FlatAppearance.BorderSize = 0


        '
        ' Form1
        '
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(621, 491)
        Controls.Add(panellateral) ' Traigo el botón Nuevo al frente
        Controls.Add(panelDatos) ' Este panel debería ser visible por defecto (Lista)
        Controls.Add(panelcontenido) ' Este panel debe estar oculto o aparecer al lado (Detalle)
        Controls.Add(panelbusqueda)
        Controls.Add(panellTitulo)
        Font = New Font("Segoe UI", 9.0F) ' Fuente general del formulario
        Name = "Form1"
        Text = "frmLECTORES"

        ' Lógica de Vistas:
        ' Si quieres que solo se vea la lista al inicio, añade:
        ' panelcontenido.Visible = False

        ' O si quieres una vista dividida:
        ' panelDatos.Dock = DockStyle.Left
        ' panelDatos.Width = 350
        ' panelcontenido.Dock = DockStyle.Fill

        panelbusqueda.ResumeLayout(False)
        panelbusqueda.PerformLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        panelcontenido.ResumeLayout(False)
        panelcontenido.PerformLayout()
        panellTitulo.ResumeLayout(False)
        panellTitulo.PerformLayout()
        panelDatos.ResumeLayout(False)
        CType(dataLectores, System.ComponentModel.ISupportInitialize).EndInit()
        panellateral.ResumeLayout(False)
        CType(btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelbusqueda As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents panelcontenido As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents panellTitulo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblLectores As Label
    Friend WithEvents panelDatos As Panel
    Friend WithEvents dataLectores As DataGridView
    Friend WithEvents panellateral As Panel
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents Eliminar As DataGridViewButtonColumn

End Class