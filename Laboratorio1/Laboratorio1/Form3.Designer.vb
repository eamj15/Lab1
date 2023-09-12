<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstMujeres = New System.Windows.Forms.ListBox()
        Me.lstHombres = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(959, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 37)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(622, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 37)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Genero"
        '
        'lstMujeres
        '
        Me.lstMujeres.FormattingEnabled = True
        Me.lstMujeres.ItemHeight = 15
        Me.lstMujeres.Location = New System.Drawing.Point(381, 242)
        Me.lstMujeres.Name = "lstMujeres"
        Me.lstMujeres.Size = New System.Drawing.Size(165, 64)
        Me.lstMujeres.TabIndex = 19
        Me.lstMujeres.Tag = ""
        '
        'lstHombres
        '
        Me.lstHombres.FormattingEnabled = True
        Me.lstHombres.ItemHeight = 15
        Me.lstHombres.Location = New System.Drawing.Point(117, 242)
        Me.lstHombres.Name = "lstHombres"
        Me.lstHombres.Size = New System.Drawing.Size(156, 64)
        Me.lstHombres.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(352, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 37)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mujeres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Hombres"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(1051, 242)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(135, 23)
        Me.txtEdad.TabIndex = 15
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(631, 434)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(135, 29)
        Me.btnComenzar.TabIndex = 14
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(720, 242)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(135, 23)
        Me.txtGenero.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(282, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(976, 45)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Determinando la cantidad de hombres y mujeres con su porcentaje"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1437, 681)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstMujeres)
        Me.Controls.Add(Me.lstHombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtGenero)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstMujeres As ListBox
    Friend WithEvents lstHombres As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnComenzar As Button
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label5 As Label
End Class
