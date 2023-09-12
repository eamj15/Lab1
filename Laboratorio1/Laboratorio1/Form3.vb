Public Class Form3
    Dim PH, PM, cent, h, m As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Dim edad, x As Integer
        x = Val(txtGenero.Text)
        edad = Val(txtEdad.Text)
        cent += 1

        If edad >= 40 And x = 1 Then
            h += 1
        End If

        If edad >= 18 And edad <= 25 And x = 2 Then
            m += 1
        End If



        If x = 1 Then
            MsgBox("Hombre " & edad)
            lstHombres.Items.Add(edad)
            PH = PH + 1
        ElseIf x = 2 Then
            MsgBox("Mujer " & edad)
            lstMujeres.Items.Add(edad)
            PM = PM + 1
        ElseIf x = 0 Then
            MsgBox("Hombres mayores a 40: " & h & " Mujeres entre 18 y 25: " & m)
            btnComenzar.Enabled = False
        End If
    End Sub
End Class