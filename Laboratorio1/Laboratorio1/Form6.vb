Public Class Form6
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim precioProducto As Double
        Dim cantidadUnidades As Integer
        Dim descuentoEfectivo = 0.124
        Dim descuentoCheque = 0.086
        Dim descuentoClave = 0.045
        Dim descuentoCredito = 0.025
        Dim resultado As Integer


        precioProducto = Val(txtNum.Text)
        cantidadUnidades = Val(txtCantidad.Text)

        If rbdEfectivo.Checked Then
            resultado = precioProducto * cantidadUnidades * descuentoEfectivo

            txtTotal.Text = precioProducto
            txtDescuento.Text = descuentoEfectivo
            txtPago.Text = resultado

        ElseIf rbdCheque.Checked Then
            resultado = precioProducto * cantidadUnidades * descuentoCheque

            txtTotal.Text = precioProducto
            txtDescuento.Text = descuentoCheque
            txtPago.Text = resultado

        ElseIf rbdClave.Checked Then
            resultado = precioProducto * cantidadUnidades * descuentoClave
            txtTotal.Text = precioProducto
            txtDescuento.Text = descuentoClave
            txtPago.Text = resultado

        ElseIf rbdCredito.Checked Then
            resultado = precioProducto * cantidadUnidades * descuentoCredito
            txtTotal.Text = precioProducto
            txtDescuento.Text = descuentoCredito
            txtPago.Text = resultado
        End If









        txtTotal.Text = precioProducto
        txtDescuento.Text = descuentoEfectivo
        txtPago.Text = resultado

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPago.Clear()
        txtDescuento.Clear()
        txtTotal.Clear()
    End Sub
End Class