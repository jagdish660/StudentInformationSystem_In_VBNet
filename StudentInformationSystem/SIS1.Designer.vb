<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIS1
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
        Me.List1 = New System.Windows.Forms.ComboBox()
        Me.Btn_Strtprgrm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_login = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT INFORMATION SYSTEM"
        '
        'List1
        '
        Me.List1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.FormattingEnabled = True
        Me.List1.Items.AddRange(New Object() {"Admin", "Student/Parents"})
        Me.List1.Location = New System.Drawing.Point(108, 156)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(137, 25)
        Me.List1.TabIndex = 1
        '
        'Btn_Strtprgrm
        '
        Me.Btn_Strtprgrm.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Strtprgrm.Location = New System.Drawing.Point(141, 183)
        Me.Btn_Strtprgrm.Name = "Btn_Strtprgrm"
        Me.Btn_Strtprgrm.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Strtprgrm.TabIndex = 2
        Me.Btn_Strtprgrm.Text = "Confirm"
        Me.Btn_Strtprgrm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "You're logging in as:"
        '
        'Panel_login
        '
        Me.Panel_login.Location = New System.Drawing.Point(323, 78)
        Me.Panel_login.Name = "Panel_login"
        Me.Panel_login.Size = New System.Drawing.Size(450, 200)
        Me.Panel_login.TabIndex = 4
        '
        'SIS1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Strtprgrm)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SIS1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIS1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents List1 As ComboBox
    Friend WithEvents Btn_Strtprgrm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_login As Panel
End Class
