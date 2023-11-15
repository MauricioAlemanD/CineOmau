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
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.dgvRegistroISR = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvRegistroISR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(262, 27)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(309, 21)
        Me.cmbEmpleado.TabIndex = 0
        '
        'dgvRegistroISR
        '
        Me.dgvRegistroISR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistroISR.Location = New System.Drawing.Point(12, 74)
        Me.dgvRegistroISR.Name = "dgvRegistroISR"
        Me.dgvRegistroISR.Size = New System.Drawing.Size(776, 364)
        Me.dgvRegistroISR.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(597, 27)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular ISR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Calcualar ISR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvRegistroISR)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvRegistroISR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents dgvRegistroISR As DataGridView
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
End Class
