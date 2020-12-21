Public Class Botones
    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        MsgBox("Hola a todos", MsgBoxStyle.Exclamation, "saludo")
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
        End
    End Sub
End Class
