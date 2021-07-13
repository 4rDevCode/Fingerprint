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
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.fpicture = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.deviceSerial = New System.Windows.Forms.Label()
        Me.prompt = New System.Windows.Forms.Label()
        Me.btnVerify = New System.Windows.Forms.Button()
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(502, 263)
        Me.txtTemplate.Multiline = True
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(424, 82)
        Me.txtTemplate.TabIndex = 31
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(345, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 21)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(502, 116)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(95, 39)
        Me.btnRegister.TabIndex = 30
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'fpicture
        '
        Me.fpicture.BackColor = System.Drawing.SystemColors.Window
        Me.fpicture.Location = New System.Drawing.Point(176, 105)
        Me.fpicture.Name = "fpicture"
        Me.fpicture.Size = New System.Drawing.Size(268, 283)
        Me.fpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.fpicture.TabIndex = 28
        Me.fpicture.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(499, 247)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Template: "
        '
        'deviceSerial
        '
        Me.deviceSerial.AutoSize = True
        Me.deviceSerial.Location = New System.Drawing.Point(499, 225)
        Me.deviceSerial.Name = "deviceSerial"
        Me.deviceSerial.Size = New System.Drawing.Size(76, 13)
        Me.deviceSerial.TabIndex = 26
        Me.deviceSerial.Text = "Device Serial: "
        '
        'prompt
        '
        Me.prompt.AutoSize = True
        Me.prompt.Location = New System.Drawing.Point(173, 401)
        Me.prompt.Name = "prompt"
        Me.prompt.Size = New System.Drawing.Size(50, 13)
        Me.prompt.TabIndex = 27
        Me.prompt.Text = "Ready ..."
        '
        'btnVerify
        '
        Me.btnVerify.Enabled = False
        Me.btnVerify.Location = New System.Drawing.Point(603, 117)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(95, 38)
        Me.btnVerify.TabIndex = 24
        Me.btnVerify.Text = "&Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 519)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.fpicture)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.deviceSerial)
        Me.Controls.Add(Me.prompt)
        Me.Controls.Add(Me.btnVerify)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtTemplate As TextBox
    Private WithEvents btnClear As Button
    Private WithEvents btnRegister As Button
    Private WithEvents fpicture As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents deviceSerial As Label
    Private WithEvents prompt As Label
    Private WithEvents btnVerify As Button
End Class
