<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnProblema5 = New System.Windows.Forms.Button()
        Me.btnProblema6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn3.Location = New System.Drawing.Point(739, 160)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(220, 121)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Problema 3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Yellow
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn4.Location = New System.Drawing.Point(1050, 160)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(220, 121)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "Problema 4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn2.Location = New System.Drawing.Point(437, 160)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(220, 121)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Problema 2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(590, 54)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(249, 45)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Laboratorio N1"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.RosyBrown
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn1.Location = New System.Drawing.Point(132, 160)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(220, 121)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Problema 1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnProblema5
        '
        Me.btnProblema5.BackColor = System.Drawing.Color.YellowGreen
        Me.btnProblema5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProblema5.Location = New System.Drawing.Point(324, 383)
        Me.btnProblema5.Name = "btnProblema5"
        Me.btnProblema5.Size = New System.Drawing.Size(220, 121)
        Me.btnProblema5.TabIndex = 5
        Me.btnProblema5.Text = "Problema 5"
        Me.btnProblema5.UseVisualStyleBackColor = False
        '
        'btnProblema6
        '
        Me.btnProblema6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnProblema6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProblema6.Location = New System.Drawing.Point(807, 383)
        Me.btnProblema6.Name = "btnProblema6"
        Me.btnProblema6.Size = New System.Drawing.Size(220, 121)
        Me.btnProblema6.TabIndex = 6
        Me.btnProblema6.Text = "Problema 6"
        Me.btnProblema6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1462, 861)
        Me.Controls.Add(Me.btnProblema6)
        Me.Controls.Add(Me.btnProblema5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btn3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btnProblema5 As Button
    Friend WithEvents btnProblema6 As Button
End Class
