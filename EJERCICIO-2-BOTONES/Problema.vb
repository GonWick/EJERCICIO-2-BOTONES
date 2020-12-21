Public Class FormProblema
    Private Sub ButtonProblemaSalir_Click(sender As Object, e As EventArgs) Handles ButtonProblemaSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub ButtonDatos_Click(sender As Object, e As EventArgs) Handles ButtonDatos.Click
        'Declaramos la variable nombre
        Dim nombre As String
        'Entrada de datos mediante un inputbox
        nombre = InputBox("Ingrese Nombre ",
                         "Registro de Datos Personales",
                         "Nombre", 100, 0)
        MessageBox.Show("Bienvenido Usuario: " + nombre,
                        "Registro de Datos Personales",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub
End Class