<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_info
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
        Me.Label_SIS = New System.Windows.Forms.Label()
        Me.Lbl_symbol = New System.Windows.Forms.Label()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Label_mobile = New System.Windows.Forms.Label()
        Me.Label_faculty = New System.Windows.Forms.Label()
        Me.Label_program = New System.Windows.Forms.Label()
        Me.Label_registration = New System.Windows.Forms.Label()
        Me.Label_address = New System.Windows.Forms.Label()
        Me.Label_phone = New System.Windows.Forms.Label()
        Me.Label_level = New System.Windows.Forms.Label()
        Me.Label_semester = New System.Windows.Forms.Label()
        Me.Label_DOB = New System.Windows.Forms.Label()
        Me.Txt_symbol = New System.Windows.Forms.TextBox()
        Me.Txt_registrstion = New System.Windows.Forms.TextBox()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Txt_mobile = New System.Windows.Forms.TextBox()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.Txt_DOB = New System.Windows.Forms.TextBox()
        Me.Txt_level = New System.Windows.Forms.TextBox()
        Me.Txt_phone = New System.Windows.Forms.TextBox()
        Me.Txt_semester = New System.Windows.Forms.TextBox()
        Me.Txt_program = New System.Windows.Forms.TextBox()
        Me.Txt_faculty = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_logout_student = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ChkBx_see = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_SIS
        '
        Me.Label_SIS.AutoSize = True
        Me.Label_SIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SIS.Location = New System.Drawing.Point(225, 28)
        Me.Label_SIS.Name = "Label_SIS"
        Me.Label_SIS.Size = New System.Drawing.Size(382, 25)
        Me.Label_SIS.TabIndex = 1
        Me.Label_SIS.Text = "STUDENT INFORMATION SYSTEM"
        '
        'Lbl_symbol
        '
        Me.Lbl_symbol.AutoSize = True
        Me.Lbl_symbol.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_symbol.Location = New System.Drawing.Point(105, 117)
        Me.Lbl_symbol.Name = "Lbl_symbol"
        Me.Lbl_symbol.Size = New System.Drawing.Size(83, 17)
        Me.Lbl_symbol.TabIndex = 14
        Me.Lbl_symbol.Text = "Symbol No. :"
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.Location = New System.Drawing.Point(107, 149)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(50, 17)
        Me.Label_name.TabIndex = 15
        Me.Label_name.Text = "Name :"
        '
        'Label_mobile
        '
        Me.Label_mobile.AutoSize = True
        Me.Label_mobile.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mobile.Location = New System.Drawing.Point(421, 146)
        Me.Label_mobile.Name = "Label_mobile"
        Me.Label_mobile.Size = New System.Drawing.Size(81, 17)
        Me.Label_mobile.TabIndex = 16
        Me.Label_mobile.Text = "Mobile No. :"
        '
        'Label_faculty
        '
        Me.Label_faculty.AutoSize = True
        Me.Label_faculty.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_faculty.Location = New System.Drawing.Point(421, 213)
        Me.Label_faculty.Name = "Label_faculty"
        Me.Label_faculty.Size = New System.Drawing.Size(54, 17)
        Me.Label_faculty.TabIndex = 17
        Me.Label_faculty.Text = "Faculty :"
        '
        'Label_program
        '
        Me.Label_program.AutoSize = True
        Me.Label_program.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_program.Location = New System.Drawing.Point(421, 243)
        Me.Label_program.Name = "Label_program"
        Me.Label_program.Size = New System.Drawing.Size(70, 17)
        Me.Label_program.TabIndex = 18
        Me.Label_program.Text = "Program : "
        '
        'Label_registration
        '
        Me.Label_registration.AutoSize = True
        Me.Label_registration.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_registration.Location = New System.Drawing.Point(421, 117)
        Me.Label_registration.Name = "Label_registration"
        Me.Label_registration.Size = New System.Drawing.Size(110, 17)
        Me.Label_registration.TabIndex = 19
        Me.Label_registration.Text = "Registration No. :"
        '
        'Label_address
        '
        Me.Label_address.AutoSize = True
        Me.Label_address.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_address.Location = New System.Drawing.Point(105, 186)
        Me.Label_address.Name = "Label_address"
        Me.Label_address.Size = New System.Drawing.Size(63, 17)
        Me.Label_address.TabIndex = 20
        Me.Label_address.Text = "Address :"
        '
        'Label_phone
        '
        Me.Label_phone.AutoSize = True
        Me.Label_phone.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_phone.Location = New System.Drawing.Point(421, 179)
        Me.Label_phone.Name = "Label_phone"
        Me.Label_phone.Size = New System.Drawing.Size(76, 17)
        Me.Label_phone.TabIndex = 21
        Me.Label_phone.Text = "Phone No. :"
        '
        'Label_level
        '
        Me.Label_level.AutoSize = True
        Me.Label_level.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_level.Location = New System.Drawing.Point(105, 246)
        Me.Label_level.Name = "Label_level"
        Me.Label_level.Size = New System.Drawing.Size(44, 17)
        Me.Label_level.TabIndex = 22
        Me.Label_level.Text = "Level :"
        '
        'Label_semester
        '
        Me.Label_semester.AutoSize = True
        Me.Label_semester.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_semester.Location = New System.Drawing.Point(105, 277)
        Me.Label_semester.Name = "Label_semester"
        Me.Label_semester.Size = New System.Drawing.Size(69, 17)
        Me.Label_semester.TabIndex = 23
        Me.Label_semester.Text = "Semester :"
        '
        'Label_DOB
        '
        Me.Label_DOB.AutoSize = True
        Me.Label_DOB.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DOB.Location = New System.Drawing.Point(105, 216)
        Me.Label_DOB.Name = "Label_DOB"
        Me.Label_DOB.Size = New System.Drawing.Size(89, 17)
        Me.Label_DOB.TabIndex = 24
        Me.Label_DOB.Text = "Date of Birth :"
        '
        'Txt_symbol
        '
        Me.Txt_symbol.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_symbol.Location = New System.Drawing.Point(193, 111)
        Me.Txt_symbol.Name = "Txt_symbol"
        Me.Txt_symbol.Size = New System.Drawing.Size(192, 23)
        Me.Txt_symbol.TabIndex = 25
        Me.Txt_symbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_registrstion
        '
        Me.Txt_registrstion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_registrstion.Location = New System.Drawing.Point(530, 111)
        Me.Txt_registrstion.Name = "Txt_registrstion"
        Me.Txt_registrstion.Size = New System.Drawing.Size(173, 23)
        Me.Txt_registrstion.TabIndex = 26
        Me.Txt_registrstion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(193, 143)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(192, 23)
        Me.Txt_name.TabIndex = 27
        Me.Txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_mobile
        '
        Me.Txt_mobile.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mobile.Location = New System.Drawing.Point(530, 143)
        Me.Txt_mobile.Name = "Txt_mobile"
        Me.Txt_mobile.Size = New System.Drawing.Size(173, 23)
        Me.Txt_mobile.TabIndex = 28
        Me.Txt_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_address
        '
        Me.Txt_address.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_address.Location = New System.Drawing.Point(193, 176)
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(192, 23)
        Me.Txt_address.TabIndex = 29
        Me.Txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_DOB
        '
        Me.Txt_DOB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DOB.Location = New System.Drawing.Point(193, 210)
        Me.Txt_DOB.Name = "Txt_DOB"
        Me.Txt_DOB.Size = New System.Drawing.Size(192, 23)
        Me.Txt_DOB.TabIndex = 30
        Me.Txt_DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_level
        '
        Me.Txt_level.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_level.Location = New System.Drawing.Point(193, 240)
        Me.Txt_level.Name = "Txt_level"
        Me.Txt_level.Size = New System.Drawing.Size(192, 23)
        Me.Txt_level.TabIndex = 31
        Me.Txt_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_phone
        '
        Me.Txt_phone.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_phone.Location = New System.Drawing.Point(530, 176)
        Me.Txt_phone.Name = "Txt_phone"
        Me.Txt_phone.Size = New System.Drawing.Size(173, 23)
        Me.Txt_phone.TabIndex = 32
        Me.Txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_semester
        '
        Me.Txt_semester.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_semester.Location = New System.Drawing.Point(193, 271)
        Me.Txt_semester.Name = "Txt_semester"
        Me.Txt_semester.Size = New System.Drawing.Size(192, 23)
        Me.Txt_semester.TabIndex = 33
        Me.Txt_semester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_program
        '
        Me.Txt_program.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_program.Location = New System.Drawing.Point(530, 240)
        Me.Txt_program.Name = "Txt_program"
        Me.Txt_program.Size = New System.Drawing.Size(173, 23)
        Me.Txt_program.TabIndex = 34
        Me.Txt_program.Text = "Bachelors"
        Me.Txt_program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_faculty
        '
        Me.Txt_faculty.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_faculty.Location = New System.Drawing.Point(530, 210)
        Me.Txt_faculty.Name = "Txt_faculty"
        Me.Txt_faculty.Size = New System.Drawing.Size(173, 23)
        Me.Txt_faculty.TabIndex = 35
        Me.Txt_faculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox1.Location = New System.Drawing.Point(13, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Panel_logout_student
        '
        Me.Panel_logout_student.Location = New System.Drawing.Point(589, 84)
        Me.Panel_logout_student.Name = "Panel_logout_student"
        Me.Panel_logout_student.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_student.TabIndex = 38
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StudentInformationSystem.My.Resources.Resources.png_transparent_computer_icons_service_technology_setting_miscellaneous_service_business_thumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(694, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.StudentInformationSystem.My.Resources.Resources.images__1_
        Me.PictureBox3.Location = New System.Drawing.Point(658, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'ChkBx_see
        '
        Me.ChkBx_see.AutoSize = True
        Me.ChkBx_see.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBx_see.Location = New System.Drawing.Point(108, 84)
        Me.ChkBx_see.Name = "ChkBx_see"
        Me.ChkBx_see.Size = New System.Drawing.Size(90, 21)
        Me.ChkBx_see.TabIndex = 39
        Me.ChkBx_see.Text = "See details"
        Me.ChkBx_see.UseVisualStyleBackColor = True
        '
        'Student_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChkBx_see)
        Me.Controls.Add(Me.Panel_logout_student)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Txt_faculty)
        Me.Controls.Add(Me.Txt_program)
        Me.Controls.Add(Me.Txt_semester)
        Me.Controls.Add(Me.Txt_phone)
        Me.Controls.Add(Me.Txt_level)
        Me.Controls.Add(Me.Txt_DOB)
        Me.Controls.Add(Me.Txt_address)
        Me.Controls.Add(Me.Txt_mobile)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_registrstion)
        Me.Controls.Add(Me.Txt_symbol)
        Me.Controls.Add(Me.Label_DOB)
        Me.Controls.Add(Me.Label_semester)
        Me.Controls.Add(Me.Label_level)
        Me.Controls.Add(Me.Label_phone)
        Me.Controls.Add(Me.Label_address)
        Me.Controls.Add(Me.Label_registration)
        Me.Controls.Add(Me.Label_program)
        Me.Controls.Add(Me.Label_faculty)
        Me.Controls.Add(Me.Label_mobile)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Lbl_symbol)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Student_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_info"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_SIS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_symbol As Label
    Friend WithEvents Label_name As Label
    Friend WithEvents Label_mobile As Label
    Friend WithEvents Label_faculty As Label
    Friend WithEvents Label_program As Label
    Friend WithEvents Label_registration As Label
    Friend WithEvents Label_address As Label
    Friend WithEvents Label_phone As Label
    Friend WithEvents Label_level As Label
    Friend WithEvents Label_semester As Label
    Friend WithEvents Label_DOB As Label
    Friend WithEvents Txt_symbol As TextBox
    Friend WithEvents Txt_registrstion As TextBox
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Txt_mobile As TextBox
    Friend WithEvents Txt_address As TextBox
    Friend WithEvents Txt_DOB As TextBox
    Friend WithEvents Txt_level As TextBox
    Friend WithEvents Txt_phone As TextBox
    Friend WithEvents Txt_semester As TextBox
    Friend WithEvents Txt_program As TextBox
    Friend WithEvents Txt_faculty As TextBox
    Friend WithEvents Panel_logout_student As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ChkBx_see As CheckBox
End Class
