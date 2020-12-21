Public Class Botones
    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        MsgBox("Hola a todos", MsgBoxStyle.Exclamation, "Saludo")
    End Sub
    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim num1, num2, suma As Integer
        num1 = TextNum1.Text
        num2 = TextNum2.Text
        suma = num1 + num2
        MsgBox(num1 & "+" & num2 & "=" & suma, MsgBoxStyle.Exclamation, "Resultado")
        TextBoxResultado.Text = (num1 & "+" & num2 & "=" & suma)

    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub

    Private Sub ButtonProblema_Click(sender As Object, e As EventArgs) Handles ButtonProblema.Click
        Dim AbrirFormularioProblema As DialogResult
        AbrirFormularioProblema = MessageBox.Show("Realmente desea abrir el Formulario Problema",
                                 "Abrir Problema",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (AbrirFormularioProblema = DialogResult.Yes) Then
            FormProblema.Show()
        End If
    End Sub

    Private Sub Botones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class