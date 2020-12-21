<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Botones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Botones))
        Me.btnUno = New System.Windows.Forms.Button()
        Me.GroupBoxSuma = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.TextNum2 = New System.Windows.Forms.TextBox()
        Me.TextNum1 = New System.Windows.Forms.TextBox()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.LabelNumero2 = New System.Windows.Forms.Label()
        Me.LabelNumero1 = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonProblema = New System.Windows.Forms.Button()
        Me.GroupBoxSuma.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUno
        '
        Me.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUno.Location = New System.Drawing.Point(12, 13)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(218, 23)
        Me.btnUno.TabIndex = 0
        Me.btnUno.Text = "Saludar"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'GroupBoxSuma
        '
        Me.GroupBoxSuma.Controls.Add(Me.TextBoxResultado)
        Me.GroupBoxSuma.Controls.Add(Me.TextNum2)
        Me.GroupBoxSuma.Controls.Add(Me.TextNum1)
        Me.GroupBoxSuma.Controls.Add(Me.Sumar)
        Me.GroupBoxSuma.Controls.Add(Me.LabelNumero2)
        Me.GroupBoxSuma.Controls.Add(Me.LabelNumero1)
        Me.GroupBoxSuma.Location = New System.Drawing.Point(13, 42)
        Me.GroupBoxSuma.Name = "GroupBoxSuma"
        Me.GroupBoxSuma.Size = New System.Drawing.Size(217, 152)
        Me.GroupBoxSuma.TabIndex = 1
        Me.GroupBoxSuma.TabStop = False
        Me.GroupBoxSuma.Text = "Operación Suma"
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.Enabled = False
        Me.TextBoxResultado.Location = New System.Drawing.Point(27, 89)
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.Size = New System.Drawing.Size(166, 23)
        Me.TextBoxResultado.TabIndex = 5
        Me.TextBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNum2
        '
        Me.TextNum2.Location = New System.Drawing.Point(137, 60)
        Me.TextNum2.Name = "TextNum2"
        Me.TextNum2.Size = New System.Drawing.Size(57, 23)
        Me.TextNum2.TabIndex = 4
        '
        'TextNum1
        '
        Me.TextNum1.Location = New System.Drawing.Point(26, 60)
        Me.TextNum1.Name = "TextNum1"
        Me.TextNum1.Size = New System.Drawing.Size(57, 23)
        Me.TextNum1.TabIndex = 3
        '
        'Sumar
        '
        Me.Sumar.Location = New System.Drawing.Point(27, 118)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(168, 23)
        Me.Sumar.TabIndex = 2
        Me.Sumar.Text = "Sumar"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'LabelNumero2
        '
        Me.LabelNumero2.AutoSize = True
        Me.LabelNumero2.Location = New System.Drawing.Point(134, 30)
        Me.LabelNumero2.Name = "LabelNumero2"
        Me.LabelNumero2.Size = New System.Drawing.Size(60, 15)
        Me.LabelNumero2.TabIndex = 1
        Me.LabelNumero2.Text = "Número 2"
        '
        'LabelNumero1
        '
        Me.LabelNumero1.AutoSize = True
        Me.LabelNumero1.Location = New System.Drawing.Point(26, 30)
        Me.LabelNumero1.Name = "LabelNumero1"
        Me.LabelNumero1.Size = New System.Drawing.Size(60, 15)
        Me.LabelNumero1.TabIndex = 0
        Me.LabelNumero1.Text = "Número 1"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 260)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(218, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonProblema
        '
        Me.ButtonProblema.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonProblema.Location = New System.Drawing.Point(12, 214)
        Me.ButtonProblema.Name = "ButtonProblema"
        Me.ButtonProblema.Size = New System.Drawing.Size(218, 23)
        Me.ButtonProblema.TabIndex = 3
        Me.ButtonProblema.Text = "Abrir Problema"
        Me.ButtonProblema.UseVisualStyleBackColor = True
        '
        'Botones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 295)
        Me.Controls.Add(Me.ButtonProblema)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.GroupBoxSuma)
        Me.Controls.Add(Me.btnUno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Botones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EJERCICIO 2"
        Me.GroupBoxSuma.ResumeLayout(False)
        Me.GroupBoxSuma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUno As Button
    Friend WithEvents GroupBoxSuma As GroupBox
    Friend WithEvents LabelNumero2 As Label
    Friend WithEvents LabelNumero1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextNum1 As TextBox
    Friend WithEvents Sumar As Button
    Friend WithEvents TextNum2 As TextBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents TextBoxResultado As TextBox
    Friend WithEvents ButtonProblema As Button
End Class
