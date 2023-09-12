Public Class Form5
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim auto, resultado, total1, total2 As Integer

        auto = Val(txtCosto.Text)



        total1 = auto * 0.12 + auto
        total2 = total1 * 0.06
        resultado = total1 + total2


        txtCostoT.Text = resultado


    End Sub
End Class