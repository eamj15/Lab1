<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstVotos = New System.Windows.Forms.ListBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(454, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de Votos"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(382, 260)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(147, 23)
        Me.txtCantidad.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(39, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(337, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ingrese la cantidad de votos"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(382, 164)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(147, 23)
        Me.txtNum.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(119, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ingrese el nombre"
        '
        'lstVotos
        '
        Me.lstVotos.FormattingEnabled = True
        Me.lstVotos.ItemHeight = 15
        Me.lstVotos.Location = New System.Drawing.Point(710, 129)
        Me.lstVotos.Name = "lstVotos"
        Me.lstVotos.Size = New System.Drawing.Size(333, 229)
        Me.lstVotos.TabIndex = 16
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIngresar.Location = New System.Drawing.Point(502, 499)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(136, 58)
        Me.btnIngresar.TabIndex = 17
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1225, 679)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lstVotos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstVotos As ListBox
    Friend WithEvents btnIngresar As Button
End Class
