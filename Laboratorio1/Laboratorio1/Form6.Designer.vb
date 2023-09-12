<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbdEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbdCheque = New System.Windows.Forms.RadioButton()
        Me.rbdCredito = New System.Windows.Forms.RadioButton()
        Me.rbdClave = New System.Windows.Forms.RadioButton()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(569, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cajero"
        '
        'rbdEfectivo
        '
        Me.rbdEfectivo.AutoSize = True
        Me.rbdEfectivo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbdEfectivo.Location = New System.Drawing.Point(833, 165)
        Me.rbdEfectivo.Name = "rbdEfectivo"
        Me.rbdEfectivo.Size = New System.Drawing.Size(109, 34)
        Me.rbdEfectivo.TabIndex = 1
        Me.rbdEfectivo.Text = "Efectivo"
        Me.rbdEfectivo.UseVisualStyleBackColor = True
        '
        'rbdCheque
        '
        Me.rbdCheque.AutoSize = True
        Me.rbdCheque.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbdCheque.Location = New System.Drawing.Point(833, 199)
        Me.rbdCheque.Name = "rbdCheque"
        Me.rbdCheque.Size = New System.Drawing.Size(105, 34)
        Me.rbdCheque.TabIndex = 2
        Me.rbdCheque.Text = "Cheque"
        Me.rbdCheque.UseVisualStyleBackColor = True
        '
        'rbdCredito
        '
        Me.rbdCredito.AutoSize = True
        Me.rbdCredito.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbdCredito.Location = New System.Drawing.Point(833, 237)
        Me.rbdCredito.Name = "rbdCredito"
        Me.rbdCredito.Size = New System.Drawing.Size(204, 34)
        Me.rbdCredito.TabIndex = 3
        Me.rbdCredito.Text = "Tarjeta de Crédito"
        Me.rbdCredito.UseVisualStyleBackColor = True
        '
        'rbdClave
        '
        Me.rbdClave.AutoSize = True
        Me.rbdClave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbdClave.Location = New System.Drawing.Point(833, 273)
        Me.rbdClave.Name = "rbdClave"
        Me.rbdClave.Size = New System.Drawing.Size(154, 34)
        Me.rbdClave.TabIndex = 4
        Me.rbdClave.Text = "Tarjeta Clave"
        Me.rbdClave.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(419, 174)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(147, 23)
        Me.txtNum.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(156, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ingrese el precio"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(419, 270)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(147, 23)
        Me.txtCantidad.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(156, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingrese la cantidad"
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(396, 521)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.ReadOnly = True
        Me.txtPago.Size = New System.Drawing.Size(147, 23)
        Me.txtPago.TabIndex = 15
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.Location = New System.Drawing.Point(883, 455)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(154, 58)
        Me.btnCalcular.TabIndex = 16
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(146, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 32)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cantidad a Pagar"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(396, 455)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(147, 23)
        Me.txtDescuento.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(396, 396)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(147, 23)
        Me.txtTotal.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(95, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 32)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cantidad del descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(146, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 32)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Monto Inicial"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.Location = New System.Drawing.Point(1112, 455)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(137, 58)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1390, 677)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbdClave)
        Me.Controls.Add(Me.rbdCredito)
        Me.Controls.Add(Me.rbdCheque)
        Me.Controls.Add(Me.rbdEfectivo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbdEfectivo As RadioButton
    Friend WithEvents rbdCheque As RadioButton
    Friend WithEvents rbdCredito As RadioButton
    Friend WithEvents rbdClave As RadioButton
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpiar As Button
End Class
