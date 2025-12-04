<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        panelbusqueda = New Panel()
        PictureBox1 = New PictureBox()
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
        n_identidad = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        telefono = New DataGridViewTextBoxColumn()
        direccion = New DataGridViewTextBoxColumn()
        panellateral = New Panel()
        btnNuevo = New PictureBox()
        panelbusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelcontenido.SuspendLayout()
        panellTitulo.SuspendLayout()
        panelDatos.SuspendLayout()
        CType(dataLectores, ComponentModel.ISupportInitialize).BeginInit()
        panellateral.SuspendLayout()
        CType(btnNuevo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelbusqueda
        ' 
        panelbusqueda.Controls.Add(PictureBox1)
        panelbusqueda.Controls.Add(txtBuscar)
        panelbusqueda.Location = New Point(0, 46)
        panelbusqueda.Name = "panelbusqueda"
        panelbusqueda.Size = New Size(621, 66)
        panelbusqueda.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(37, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 50)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(130, 22)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(404, 23)
        txtBuscar.TabIndex = 0
        ' 
        ' panelcontenido
        ' 
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
        panelcontenido.Location = New Point(0, 111)
        panelcontenido.Name = "panelcontenido"
        panelcontenido.Size = New Size(621, 379)
        panelcontenido.TabIndex = 18
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(382, 312)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 36)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(261, 312)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(102, 36)
        btnModificar.TabIndex = 11
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(141, 312)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(102, 36)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(171, 215)
        txtObservaciones.Multiline = True
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.Size = New Size(413, 72)
        txtObservaciones.TabIndex = 9
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(171, 160)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(413, 23)
        txtDireccion.TabIndex = 8
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(171, 117)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(413, 23)
        txtTelefono.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(171, 79)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(413, 23)
        txtNombre.TabIndex = 6
        ' 
        ' txtIdentidad
        ' 
        txtIdentidad.Location = New Point(171, 40)
        txtIdentidad.Name = "txtIdentidad"
        txtIdentidad.Size = New Size(413, 23)
        txtIdentidad.TabIndex = 5
        ' 
        ' lblObservaciones
        ' 
        lblObservaciones.AutoSize = True
        lblObservaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblObservaciones.Location = New Point(21, 213)
        lblObservaciones.Name = "lblObservaciones"
        lblObservaciones.Size = New Size(127, 20)
        lblObservaciones.TabIndex = 4
        lblObservaciones.Text = "Observaciones"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblDireccion.Location = New Point(21, 163)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(84, 20)
        lblDireccion.TabIndex = 3
        lblDireccion.Text = "Direccion"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblTelefono.Location = New Point(21, 120)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(79, 20)
        lblTelefono.TabIndex = 2
        lblTelefono.Text = "Telefono"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblNombre.Location = New Point(21, 82)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(149, 20)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre completo"
        ' 
        ' lblIdentidad
        ' 
        lblIdentidad.AutoSize = True
        lblIdentidad.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblIdentidad.Location = New Point(21, 43)
        lblIdentidad.Name = "lblIdentidad"
        lblIdentidad.Size = New Size(102, 20)
        lblIdentidad.TabIndex = 0
        lblIdentidad.Text = "N Identidad"
        ' 
        ' panellTitulo
        ' 
        panellTitulo.Controls.Add(btnCerrar)
        panellTitulo.Controls.Add(lblLectores)
        panellTitulo.Location = New Point(0, 0)
        panellTitulo.Name = "panellTitulo"
        panellTitulo.Size = New Size(621, 49)
        panellTitulo.TabIndex = 16
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(573, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(36, 35)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "X"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblLectores
        ' 
        lblLectores.AutoSize = True
        lblLectores.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLectores.Location = New Point(34, 8)
        lblLectores.Name = "lblLectores"
        lblLectores.Size = New Size(114, 29)
        lblLectores.TabIndex = 2
        lblLectores.Text = "Lectores"
        ' 
        ' panelDatos
        ' 
        panelDatos.Controls.Add(dataLectores)
        panelDatos.Location = New Point(35, 47)
        panelDatos.Name = "panelDatos"
        panelDatos.Size = New Size(473, 443)
        panelDatos.TabIndex = 19
        ' 
        ' dataLectores
        ' 
        dataLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataLectores.Columns.AddRange(New DataGridViewColumn() {n_identidad, nombre, telefono, direccion})
        dataLectores.Location = New Point(3, 4)
        dataLectores.Name = "dataLectores"
        dataLectores.Size = New Size(450, 366)
        dataLectores.TabIndex = 0
        ' 
        ' n_identidad
        ' 
        n_identidad.HeaderText = "N Identidad"
        n_identidad.Name = "n_identidad"
        n_identidad.ReadOnly = True
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.Name = "nombre"
        nombre.ReadOnly = True
        ' 
        ' telefono
        ' 
        telefono.HeaderText = "Telefono"
        telefono.Name = "telefono"
        telefono.ReadOnly = True
        ' 
        ' direccion
        ' 
        direccion.HeaderText = "Direccion"
        direccion.Name = "direccion"
        direccion.ReadOnly = True
        ' 
        ' panellateral
        ' 
        panellateral.Controls.Add(btnNuevo)
        panellateral.Location = New Point(508, 45)
        panellateral.Name = "panellateral"
        panellateral.Size = New Size(113, 443)
        panellateral.TabIndex = 20
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(6, 174)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(98, 82)
        btnNuevo.TabIndex = 0
        btnNuevo.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(621, 491)
        Controls.Add(panelcontenido)
        Controls.Add(panelbusqueda)
        Controls.Add(panellTitulo)
        Controls.Add(panelDatos)
        Controls.Add(panellateral)
        Name = "Form1"
        Text = "frmLECTORES"
        panelbusqueda.ResumeLayout(False)
        panelbusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelcontenido.ResumeLayout(False)
        panelcontenido.PerformLayout()
        panellTitulo.ResumeLayout(False)
        panellTitulo.PerformLayout()
        panelDatos.ResumeLayout(False)
        CType(dataLectores, ComponentModel.ISupportInitialize).EndInit()
        panellateral.ResumeLayout(False)
        CType(btnNuevo, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents n_identidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents panellateral As Panel
    Friend WithEvents btnNuevo As PictureBox
End Class
