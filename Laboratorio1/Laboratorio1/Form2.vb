Public Class Form2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim resultado, limite As Integer


        limite = Val(txtNum.Text)
        For numero As Integer = 1 To limite
            Dim sumaDivisores As Integer = 0

            For i As Integer = 1 To numero - 1
                If numero Mod i = 0 Then
                    sumaDivisores += i
                End If
            Next

            If sumaDivisores = numero Then
                Console.WriteLine(numero)
            End If

            txtResultado.Text = sumaDivisores
        Next

    End Sub
End Class

