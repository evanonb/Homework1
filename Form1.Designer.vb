<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrenchNumbers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Header = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Subheader = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Header.AutoSize = True
        Me.Header.Location = New System.Drawing.Point(126, 75)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(255, 13)
        Me.Header.TabIndex = 0
        Me.Header.Text = "Do you know the French words for the numbers 1-5?"
        Me.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(103, 131)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(43, 35)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Subheader
        '
        Me.Subheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Subheader.AutoSize = True
        Me.Subheader.Location = New System.Drawing.Point(164, 88)
        Me.Subheader.Name = "Subheader"
        Me.Subheader.Size = New System.Drawing.Size(178, 13)
        Me.Subheader.TabIndex = 2
        Me.Subheader.Text = "Click the buttons below to see them."
        Me.Subheader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(167, 131)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(43, 35)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(232, 131)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(43, 35)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(299, 131)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(43, 35)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(368, 131)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(43, 35)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'lblFrench
        '
        Me.lblFrench.AutoSize = True
        Me.lblFrench.BackColor = System.Drawing.Color.LightCoral
        Me.lblFrench.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrench.Location = New System.Drawing.Point(228, 198)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(66, 24)
        Me.lblFrench.TabIndex = 7
        Me.lblFrench.Text = "Label1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFrenchNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 340)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.Subheader)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Header)
        Me.Name = "frmFrenchNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents Subheader As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents lblFrench As Label
    Friend WithEvents btnExit As Button
End Class
