<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logout_confirmatiom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_logout = New System.Windows.Forms.Button()
        Me.Btn_stay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure, you want to logout?"
        '
        'Btn_logout
        '
        Me.Btn_logout.Location = New System.Drawing.Point(5, 47)
        Me.Btn_logout.Name = "Btn_logout"
        Me.Btn_logout.Size = New System.Drawing.Size(75, 23)
        Me.Btn_logout.TabIndex = 1
        Me.Btn_logout.Text = "Yes"
        Me.Btn_logout.UseVisualStyleBackColor = True
        '
        'Btn_stay
        '
        Me.Btn_stay.Location = New System.Drawing.Point(86, 47)
        Me.Btn_stay.Name = "Btn_stay"
        Me.Btn_stay.Size = New System.Drawing.Size(75, 23)
        Me.Btn_stay.TabIndex = 2
        Me.Btn_stay.Text = "No"
        Me.Btn_stay.UseVisualStyleBackColor = True
        '
        'Logout_confirmatiom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(190, 90)
        Me.Controls.Add(Me.Btn_stay)
        Me.Controls.Add(Me.Btn_logout)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Logout_confirmatiom"
        Me.Text = "Logout_confirmatiom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_logout As Button
    Friend WithEvents Btn_stay As Button
End Class
