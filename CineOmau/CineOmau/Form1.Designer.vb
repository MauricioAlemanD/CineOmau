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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINEOMAU"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(190, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Correo Electronico:"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.DimGray
        Me.txtCorreo.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(196, 155)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(372, 35)
        Me.txtCorreo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(190, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.DimGray
        Me.txtContraseña.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(196, 243)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(372, 35)
        Me.txtContraseña.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.DarkRed
        Me.btnIngresar.Font = New System.Drawing.Font("Gadugi", 20.25!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresar.Location = New System.Drawing.Point(196, 302)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(372, 38)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DarkRed
        Me.btnRegistrar.Font = New System.Drawing.Font("Gadugi", 20.25!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(196, 366)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(372, 38)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Font = New System.Drawing.Font("Gadugi", 20.25!)
        Me.btnSalir.ForeColor = System.Drawing.Color.Silver
        Me.btnSalir.Location = New System.Drawing.Point(691, 400)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 38)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
End Class
