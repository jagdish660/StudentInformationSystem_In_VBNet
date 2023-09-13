<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_pwd_student = New System.Windows.Forms.TextBox()
        Me.Txt_usnme_student = New System.Windows.Forms.TextBox()
        Me.CHKBX_showpassword = New System.Windows.Forms.CheckBox()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'Txt_pwd_student
        '
        Me.Txt_pwd_student.Location = New System.Drawing.Point(196, 70)
        Me.Txt_pwd_student.Name = "Txt_pwd_student"
        Me.Txt_pwd_student.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_pwd_student.Size = New System.Drawing.Size(142, 20)
        Me.Txt_pwd_student.TabIndex = 2
        '
        'Txt_usnme_student
        '
        Me.Txt_usnme_student.Location = New System.Drawing.Point(196, 46)
        Me.Txt_usnme_student.Name = "Txt_usnme_student"
        Me.Txt_usnme_student.Size = New System.Drawing.Size(142, 20)
        Me.Txt_usnme_student.TabIndex = 3
        '
        'CHKBX_showpassword
        '
        Me.CHKBX_showpassword.AutoSize = True
        Me.CHKBX_showpassword.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKBX_showpassword.Location = New System.Drawing.Point(126, 101)
        Me.CHKBX_showpassword.Name = "CHKBX_showpassword"
        Me.CHKBX_showpassword.Size = New System.Drawing.Size(114, 20)
        Me.CHKBX_showpassword.TabIndex = 4
        Me.CHKBX_showpassword.Text = "Show password?"
        Me.CHKBX_showpassword.UseVisualStyleBackColor = True
        '
        'Btn_login
        '
        Me.Btn_login.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.Location = New System.Drawing.Point(196, 125)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(75, 26)
        Me.Btn_login.TabIndex = 5
        Me.Btn_login.Text = "LogIn"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Student_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.CHKBX_showpassword)
        Me.Controls.Add(Me.Txt_usnme_student)
        Me.Controls.Add(Me.Txt_pwd_student)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Student_login"
        Me.ShowIcon = False
        Me.Text = "Student_login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_pwd_student As TextBox
    Friend WithEvents Txt_usnme_student As TextBox
    Friend WithEvents CHKBX_showpassword As CheckBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
