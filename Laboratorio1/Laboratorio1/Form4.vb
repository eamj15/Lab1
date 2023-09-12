Public Class Form4
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Integer

        numero = Val(txtNum.Text)

        While numero <> 1
            Console.Write(numero & ", ")
            If numero Mod 2 = 0 Then
                ' Si el número es par, divídelo por 2
                numero /= 2
            Else
                ' Si el número es impar, multiplica por 3 y suma 1
                numero = 3 * numero + 1
            End If
            lstNumero.Items.Add(numero)
        End While



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstNumero.Items.Clear()
    End Sub
End Class