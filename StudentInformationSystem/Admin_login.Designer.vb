<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_login
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
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.CHKBX_showpassword = New System.Windows.Forms.CheckBox()
        Me.Txt_username_admin = New System.Windows.Forms.TextBox()
        Me.Txt_password_admin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_login
        '
        Me.Btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.Location = New System.Drawing.Point(190, 136)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(75, 27)
        Me.Btn_login.TabIndex = 11
        Me.Btn_login.Text = "LogIn"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'CHKBX_showpassword
        '
        Me.CHKBX_showpassword.AutoSize = True
        Me.CHKBX_showpassword.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKBX_showpassword.Location = New System.Drawing.Point(116, 103)
        Me.CHKBX_showpassword.Name = "CHKBX_showpassword"
        Me.CHKBX_showpassword.Size = New System.Drawing.Size(114, 20)
        Me.CHKBX_showpassword.TabIndex = 10
        Me.CHKBX_showpassword.Text = "Show password?"
        Me.CHKBX_showpassword.UseVisualStyleBackColor = True
        '
        'Txt_username_admin
        '
        Me.Txt_username_admin.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_username_admin.Location = New System.Drawing.Point(186, 45)
        Me.Txt_username_admin.Name = "Txt_username_admin"
        Me.Txt_username_admin.Size = New System.Drawing.Size(155, 23)
        Me.Txt_username_admin.TabIndex = 9
        '
        'Txt_password_admin
        '
        Me.Txt_password_admin.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_password_admin.Location = New System.Drawing.Point(186, 72)
        Me.Txt_password_admin.Name = "Txt_password_admin"
        Me.Txt_password_admin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_password_admin.Size = New System.Drawing.Size(155, 23)
        Me.Txt_password_admin.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username :"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(250, 103)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Admin_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 200)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.CHKBX_showpassword)
        Me.Controls.Add(Me.Txt_username_admin)
        Me.Controls.Add(Me.Txt_password_admin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_login"
        Me.Text = "Admin_login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_login As Button
    Friend WithEvents CHKBX_showpassword As CheckBox
    Friend WithEvents Txt_username_admin As TextBox
    Friend WithEvents Txt_password_admin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
