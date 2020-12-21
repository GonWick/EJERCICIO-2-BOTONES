<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProblema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProblema))
        Me.ButtonProblemaSalir = New System.Windows.Forms.Button()
        Me.ButtonDatos = New System.Windows.Forms.Button()
        Me.TextBoxDatos = New System.Windows.Forms.TextBox()
        Me.ButtonWarning = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonProblemaSalir
        '
        Me.ButtonProblemaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonProblemaSalir.Location = New System.Drawing.Point(11, 111)
        Me.ButtonProblemaSalir.Name = "ButtonProblemaSalir"
        Me.ButtonProblemaSalir.Size = New System.Drawing.Size(213, 39)
        Me.ButtonProblemaSalir.TabIndex = 0
        Me.ButtonProblemaSalir.Text = "Salir"
        Me.ButtonProblemaSalir.UseVisualStyleBackColor = True
        '
        'ButtonDatos
        '
        Me.ButtonDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDatos.Location = New System.Drawing.Point(12, 12)
        Me.ButtonDatos.Name = "ButtonDatos"
        Me.ButtonDatos.Size = New System.Drawing.Size(213, 64)
        Me.ButtonDatos.TabIndex = 1
        Me.ButtonDatos.Text = "Ingresar Usuario"
        Me.ButtonDatos.UseVisualStyleBackColor = True
        '
        'TextBoxDatos
        '
        Me.TextBoxDatos.Enabled = False
        Me.TextBoxDatos.Location = New System.Drawing.Point(12, 82)
        Me.TextBoxDatos.Name = "TextBoxDatos"
        Me.TextBoxDatos.Size = New System.Drawing.Size(151, 23)
        Me.TextBoxDatos.TabIndex = 2
        Me.TextBoxDatos.Text = "Ingrese Usuario"
        Me.TextBoxDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonWarning
        '
        Me.ButtonWarning.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonWarning.Location = New System.Drawing.Point(172, 84)
        Me.ButtonWarning.Name = "ButtonWarning"
        Me.ButtonWarning.Size = New System.Drawing.Size(51, 20)
        Me.ButtonWarning.TabIndex = 3
        Me.ButtonWarning.Text = "X"
        Me.ButtonWarning.UseVisualStyleBackColor = True
        '
        'FormProblema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 159)
        Me.Controls.Add(Me.ButtonWarning)
        Me.Controls.Add(Me.TextBoxDatos)
        Me.Controls.Add(Me.ButtonDatos)
        Me.Controls.Add(Me.ButtonProblemaSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProblema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonProblemaSalir As Button
    Friend WithEvents ButtonDatos As Button
    Friend WithEvents TextBoxDatos As TextBox
    Friend WithEvents ButtonWarning As Button
End Class
