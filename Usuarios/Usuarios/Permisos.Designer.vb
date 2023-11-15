<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBasesDatos = New System.Windows.Forms.ComboBox()
        Me.cmbTabla = New System.Windows.Forms.ComboBox()
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDenegar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.chbSelect = New System.Windows.Forms.CheckBox()
        Me.chbDelete = New System.Windows.Forms.CheckBox()
        Me.chbUpdate = New System.Windows.Forms.CheckBox()
        Me.chbInsert = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tabla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ususarios"
        '
        'cmbBasesDatos
        '
        Me.cmbBasesDatos.FormattingEnabled = True
        Me.cmbBasesDatos.Location = New System.Drawing.Point(58, 48)
        Me.cmbBasesDatos.Name = "cmbBasesDatos"
        Me.cmbBasesDatos.Size = New System.Drawing.Size(164, 21)
        Me.cmbBasesDatos.TabIndex = 3
        '
        'cmbTabla
        '
        Me.cmbTabla.FormattingEnabled = True
        Me.cmbTabla.Location = New System.Drawing.Point(58, 88)
        Me.cmbTabla.Name = "cmbTabla"
        Me.cmbTabla.Size = New System.Drawing.Size(164, 21)
        Me.cmbTabla.TabIndex = 4
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.FormattingEnabled = True
        Me.cmbUsuarios.Location = New System.Drawing.Point(58, 128)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(164, 21)
        Me.cmbUsuarios.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDenegar)
        Me.GroupBox1.Controls.Add(Me.btnAsignar)
        Me.GroupBox1.Controls.Add(Me.chbSelect)
        Me.GroupBox1.Controls.Add(Me.chbDelete)
        Me.GroupBox1.Controls.Add(Me.chbUpdate)
        Me.GroupBox1.Controls.Add(Me.chbInsert)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 198)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permisos"
        '
        'btnDenegar
        '
        Me.btnDenegar.Location = New System.Drawing.Point(6, 156)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(158, 23)
        Me.btnDenegar.TabIndex = 5
        Me.btnDenegar.Text = "Denegar"
        Me.btnDenegar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(6, 127)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(158, 23)
        Me.btnAsignar.TabIndex = 4
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'chbSelect
        '
        Me.chbSelect.AutoSize = True
        Me.chbSelect.Location = New System.Drawing.Point(20, 103)
        Me.chbSelect.Name = "chbSelect"
        Me.chbSelect.Size = New System.Drawing.Size(56, 17)
        Me.chbSelect.TabIndex = 3
        Me.chbSelect.Text = "Select"
        Me.chbSelect.UseVisualStyleBackColor = True
        '
        'chbDelete
        '
        Me.chbDelete.AutoSize = True
        Me.chbDelete.Location = New System.Drawing.Point(20, 79)
        Me.chbDelete.Name = "chbDelete"
        Me.chbDelete.Size = New System.Drawing.Size(57, 17)
        Me.chbDelete.TabIndex = 2
        Me.chbDelete.Text = "Delete"
        Me.chbDelete.UseVisualStyleBackColor = True
        '
        'chbUpdate
        '
        Me.chbUpdate.AutoSize = True
        Me.chbUpdate.Location = New System.Drawing.Point(20, 55)
        Me.chbUpdate.Name = "chbUpdate"
        Me.chbUpdate.Size = New System.Drawing.Size(61, 17)
        Me.chbUpdate.TabIndex = 1
        Me.chbUpdate.Text = "Update"
        Me.chbUpdate.UseVisualStyleBackColor = True
        '
        'chbInsert
        '
        Me.chbInsert.AutoSize = True
        Me.chbInsert.Location = New System.Drawing.Point(20, 31)
        Me.chbInsert.Name = "chbInsert"
        Me.chbInsert.Size = New System.Drawing.Size(52, 17)
        Me.chbInsert.TabIndex = 0
        Me.chbInsert.Text = "Insert"
        Me.chbInsert.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.txtEdad)
        Me.GroupBox2.Controls.Add(Me.txtApellido2)
        Me.GroupBox2.Controls.Add(Me.txtApellido1)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 404)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conprobacion"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightCoral
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(331, 342)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 31)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.LightCoral
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(207, 342)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 31)
        Me.btnEditar.TabIndex = 25
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightCoral
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(331, 299)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 31)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LightCoral
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(83, 342)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(118, 31)
        Me.btnBorrar.TabIndex = 23
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightCoral
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(207, 299)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 31)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.LightCoral
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(83, 299)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 31)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.LightCoral
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(207, 253)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(242, 24)
        Me.txtEdad.TabIndex = 22
        '
        'txtApellido2
        '
        Me.txtApellido2.BackColor = System.Drawing.Color.LightCoral
        Me.txtApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(207, 193)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(242, 24)
        Me.txtApellido2.TabIndex = 21
        '
        'txtApellido1
        '
        Me.txtApellido1.BackColor = System.Drawing.Color.LightCoral
        Me.txtApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(207, 136)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(242, 24)
        Me.txtApellido1.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.LightCoral
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(207, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 24)
        Me.txtNombre.TabIndex = 19
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.LightCoral
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(207, 31)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(242, 24)
        Me.txtId.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellido 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Apellido 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ID"
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.cmbTabla)
        Me.Controls.Add(Me.cmbBasesDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Permisos"
        Me.Text = "Permisos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBasesDatos As ComboBox
    Friend WithEvents cmbTabla As ComboBox
    Friend WithEvents cmbUsuarios As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDenegar As Button
    Friend WithEvents btnAsignar As Button
    Friend WithEvents chbSelect As CheckBox
    Friend WithEvents chbDelete As CheckBox
    Friend WithEvents chbUpdate As CheckBox
    Friend WithEvents chbInsert As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
