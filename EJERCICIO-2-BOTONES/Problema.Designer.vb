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
        Me.ButtonProblemaSalir = New System.Windows.Forms.Button()
        Me.ButtonDatos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonProblemaSalir
        '
        Me.ButtonProblemaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonProblemaSalir.Location = New System.Drawing.Point(12, 82)
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
        Me.ButtonDatos.Text = "Ingresar Datos"
        Me.ButtonDatos.UseVisualStyleBackColor = True
        '
        'FormProblema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 130)
        Me.Controls.Add(Me.ButtonDatos)
        Me.Controls.Add(Me.ButtonProblemaSalir)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProblema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problema"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonProblemaSalir As Button
    Friend WithEvents ButtonDatos As Button
End Class
