<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_updateStudent
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
        Me.Panel_logout_admin = New System.Windows.Forms.Panel()
        Me.Label_SIS = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.Label_ = New System.Windows.Forms.Label()
        Me.Label_symbolSearch = New System.Windows.Forms.Label()
        Me.Txt_symbol_search = New System.Windows.Forms.TextBox()
        Me.Label_DOB = New System.Windows.Forms.Label()
        Me.Label_address = New System.Windows.Forms.Label()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Label_registration = New System.Windows.Forms.Label()
        Me.Label_symbol_ = New System.Windows.Forms.Label()
        Me.Txt_symbol = New System.Windows.Forms.TextBox()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Txt_registration = New System.Windows.Forms.TextBox()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Txt_fee = New System.Windows.Forms.TextBox()
        Me.Txt_discount = New System.Windows.Forms.TextBox()
        Me.Label_faculty = New System.Windows.Forms.Label()
        Me.Label_program = New System.Windows.Forms.Label()
        Me.Label_lev = New System.Windows.Forms.Label()
        Me.Label_fee = New System.Windows.Forms.Label()
        Me.Label_discount = New System.Windows.Forms.Label()
        Me.Label_semester = New System.Windows.Forms.Label()
        Me.Txt_phone = New System.Windows.Forms.TextBox()
        Me.Txt_mobile = New System.Windows.Forms.TextBox()
        Me.Label_phone = New System.Windows.Forms.Label()
        Me.Label_mobile = New System.Windows.Forms.Label()
        Me.Cmb_Faculty = New System.Windows.Forms.ComboBox()
        Me.Cmb_semester = New System.Windows.Forms.ComboBox()
        Me.Cmb_program = New System.Windows.Forms.ComboBox()
        Me.Cmb_level = New System.Windows.Forms.ComboBox()
        Me.Button_submit = New System.Windows.Forms.Button()
        Me.Dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.Txt_pwdd = New System.Windows.Forms.TextBox()
        Me.Label_password = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_logout_admin
        '
        Me.Panel_logout_admin.Location = New System.Drawing.Point(595, 84)
        Me.Panel_logout_admin.Name = "Panel_logout_admin"
        Me.Panel_logout_admin.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_admin.TabIndex = 21
        '
        'Label_SIS
        '
        Me.Label_SIS.AutoSize = True
        Me.Label_SIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SIS.Location = New System.Drawing.Point(225, 28)
        Me.Label_SIS.Name = "Label_SIS"
        Me.Label_SIS.Size = New System.Drawing.Size(382, 25)
        Me.Label_SIS.TabIndex = 17
        Me.Label_SIS.Text = "STUDENT INFORMATION SYSTEM"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.StudentInformationSystem.My.Resources.Resources.images__1_
        Me.PictureBox3.Location = New System.Drawing.Point(664, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox1.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.Location = New System.Drawing.Point(65, 293)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(50, 17)
        Me.Label_name.TabIndex = 22
        Me.Label_name.Text = "Name :"
        Me.Label_name.Visible = False
        '
        'Button_search
        '
        Me.Button_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search.Location = New System.Drawing.Point(476, 92)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(64, 29)
        Me.Button_search.TabIndex = 29
        Me.Button_search.Text = "Search"
        Me.Button_search.UseVisualStyleBackColor = False
        '
        'Label_
        '
        Me.Label_.AutoSize = True
        Me.Label_.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_.Location = New System.Drawing.Point(301, 69)
        Me.Label_.Name = "Label_"
        Me.Label_.Size = New System.Drawing.Size(148, 17)
        Me.Label_.TabIndex = 28
        Me.Label_.Text = "Search specific student :"
        '
        'Label_symbolSearch
        '
        Me.Label_symbolSearch.AutoSize = True
        Me.Label_symbolSearch.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_symbolSearch.Location = New System.Drawing.Point(218, 99)
        Me.Label_symbolSearch.Name = "Label_symbolSearch"
        Me.Label_symbolSearch.Size = New System.Drawing.Size(86, 17)
        Me.Label_symbolSearch.TabIndex = 27
        Me.Label_symbolSearch.Text = "Symbol No. :"
        '
        'Txt_symbol_search
        '
        Me.Txt_symbol_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_symbol_search.Location = New System.Drawing.Point(310, 98)
        Me.Txt_symbol_search.Name = "Txt_symbol_search"
        Me.Txt_symbol_search.Size = New System.Drawing.Size(148, 23)
        Me.Txt_symbol_search.TabIndex = 26
        '
        'Label_DOB
        '
        Me.Label_DOB.AutoSize = True
        Me.Label_DOB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DOB.Location = New System.Drawing.Point(65, 355)
        Me.Label_DOB.Name = "Label_DOB"
        Me.Label_DOB.Size = New System.Drawing.Size(89, 17)
        Me.Label_DOB.TabIndex = 34
        Me.Label_DOB.Text = "Date of Birth :"
        Me.Label_DOB.Visible = False
        '
        'Label_address
        '
        Me.Label_address.AutoSize = True
        Me.Label_address.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_address.Location = New System.Drawing.Point(65, 323)
        Me.Label_address.Name = "Label_address"
        Me.Label_address.Size = New System.Drawing.Size(63, 17)
        Me.Label_address.TabIndex = 35
        Me.Label_address.Text = "Address :"
        Me.Label_address.Visible = False
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_username.Location = New System.Drawing.Point(65, 229)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(74, 17)
        Me.Label_username.TabIndex = 36
        Me.Label_username.Text = "Username :"
        Me.Label_username.Visible = False
        '
        'Label_registration
        '
        Me.Label_registration.AutoSize = True
        Me.Label_registration.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_registration.Location = New System.Drawing.Point(65, 198)
        Me.Label_registration.Name = "Label_registration"
        Me.Label_registration.Size = New System.Drawing.Size(110, 17)
        Me.Label_registration.TabIndex = 37
        Me.Label_registration.Text = "Registration No. :"
        Me.Label_registration.Visible = False
        '
        'Label_symbol_
        '
        Me.Label_symbol_.AutoSize = True
        Me.Label_symbol_.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_symbol_.Location = New System.Drawing.Point(65, 167)
        Me.Label_symbol_.Name = "Label_symbol_"
        Me.Label_symbol_.Size = New System.Drawing.Size(83, 17)
        Me.Label_symbol_.TabIndex = 38
        Me.Label_symbol_.Text = "Symbol No. :"
        Me.Label_symbol_.Visible = False
        '
        'Txt_symbol
        '
        Me.Txt_symbol.Location = New System.Drawing.Point(177, 164)
        Me.Txt_symbol.Name = "Txt_symbol"
        Me.Txt_symbol.ReadOnly = True
        Me.Txt_symbol.Size = New System.Drawing.Size(180, 20)
        Me.Txt_symbol.TabIndex = 39
        Me.Txt_symbol.Visible = False
        '
        'Txt_username
        '
        Me.Txt_username.Location = New System.Drawing.Point(177, 226)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.ReadOnly = True
        Me.Txt_username.Size = New System.Drawing.Size(180, 20)
        Me.Txt_username.TabIndex = 47
        Me.Txt_username.Visible = False
        '
        'Txt_registration
        '
        Me.Txt_registration.Location = New System.Drawing.Point(177, 195)
        Me.Txt_registration.Name = "Txt_registration"
        Me.Txt_registration.ReadOnly = True
        Me.Txt_registration.Size = New System.Drawing.Size(180, 20)
        Me.Txt_registration.TabIndex = 48
        Me.Txt_registration.Visible = False
        '
        'Txt_address
        '
        Me.Txt_address.Location = New System.Drawing.Point(177, 321)
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(180, 20)
        Me.Txt_address.TabIndex = 51
        Me.Txt_address.Visible = False
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(177, 290)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(180, 20)
        Me.Txt_name.TabIndex = 49
        Me.Txt_name.Visible = False
        '
        'Txt_fee
        '
        Me.Txt_fee.Location = New System.Drawing.Point(550, 321)
        Me.Txt_fee.Name = "Txt_fee"
        Me.Txt_fee.Size = New System.Drawing.Size(164, 20)
        Me.Txt_fee.TabIndex = 63
        Me.Txt_fee.Visible = False
        '
        'Txt_discount
        '
        Me.Txt_discount.Location = New System.Drawing.Point(550, 352)
        Me.Txt_discount.Name = "Txt_discount"
        Me.Txt_discount.Size = New System.Drawing.Size(164, 20)
        Me.Txt_discount.TabIndex = 62
        Me.Txt_discount.Visible = False
        '
        'Label_faculty
        '
        Me.Label_faculty.AutoSize = True
        Me.Label_faculty.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_faculty.Location = New System.Drawing.Point(433, 200)
        Me.Label_faculty.Name = "Label_faculty"
        Me.Label_faculty.Size = New System.Drawing.Size(54, 17)
        Me.Label_faculty.TabIndex = 57
        Me.Label_faculty.Text = "Faculty :"
        Me.Label_faculty.Visible = False
        '
        'Label_program
        '
        Me.Label_program.AutoSize = True
        Me.Label_program.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_program.Location = New System.Drawing.Point(433, 262)
        Me.Label_program.Name = "Label_program"
        Me.Label_program.Size = New System.Drawing.Size(66, 17)
        Me.Label_program.TabIndex = 56
        Me.Label_program.Text = "Program :"
        Me.Label_program.Visible = False
        '
        'Label_lev
        '
        Me.Label_lev.AutoSize = True
        Me.Label_lev.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_lev.Location = New System.Drawing.Point(433, 231)
        Me.Label_lev.Name = "Label_lev"
        Me.Label_lev.Size = New System.Drawing.Size(44, 17)
        Me.Label_lev.TabIndex = 55
        Me.Label_lev.Text = "Level :"
        Me.Label_lev.Visible = False
        '
        'Label_fee
        '
        Me.Label_fee.AutoSize = True
        Me.Label_fee.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fee.Location = New System.Drawing.Point(433, 325)
        Me.Label_fee.Name = "Label_fee"
        Me.Label_fee.Size = New System.Drawing.Size(68, 17)
        Me.Label_fee.TabIndex = 54
        Me.Label_fee.Text = "Total FEE :"
        Me.Label_fee.Visible = False
        '
        'Label_discount
        '
        Me.Label_discount.AutoSize = True
        Me.Label_discount.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_discount.Location = New System.Drawing.Point(433, 356)
        Me.Label_discount.Name = "Label_discount"
        Me.Label_discount.Size = New System.Drawing.Size(65, 17)
        Me.Label_discount.TabIndex = 53
        Me.Label_discount.Text = "Discount :"
        Me.Label_discount.Visible = False
        '
        'Label_semester
        '
        Me.Label_semester.AutoSize = True
        Me.Label_semester.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_semester.Location = New System.Drawing.Point(433, 294)
        Me.Label_semester.Name = "Label_semester"
        Me.Label_semester.Size = New System.Drawing.Size(69, 17)
        Me.Label_semester.TabIndex = 52
        Me.Label_semester.Text = "Semester :"
        Me.Label_semester.Visible = False
        '
        'Txt_phone
        '
        Me.Txt_phone.Location = New System.Drawing.Point(177, 383)
        Me.Txt_phone.Name = "Txt_phone"
        Me.Txt_phone.Size = New System.Drawing.Size(180, 20)
        Me.Txt_phone.TabIndex = 67
        Me.Txt_phone.Visible = False
        '
        'Txt_mobile
        '
        Me.Txt_mobile.Location = New System.Drawing.Point(550, 164)
        Me.Txt_mobile.Name = "Txt_mobile"
        Me.Txt_mobile.Size = New System.Drawing.Size(164, 20)
        Me.Txt_mobile.TabIndex = 66
        Me.Txt_mobile.Visible = False
        '
        'Label_phone
        '
        Me.Label_phone.AutoSize = True
        Me.Label_phone.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_phone.Location = New System.Drawing.Point(65, 386)
        Me.Label_phone.Name = "Label_phone"
        Me.Label_phone.Size = New System.Drawing.Size(76, 17)
        Me.Label_phone.TabIndex = 65
        Me.Label_phone.Text = "Phone No. :"
        Me.Label_phone.Visible = False
        '
        'Label_mobile
        '
        Me.Label_mobile.AutoSize = True
        Me.Label_mobile.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mobile.Location = New System.Drawing.Point(433, 167)
        Me.Label_mobile.Name = "Label_mobile"
        Me.Label_mobile.Size = New System.Drawing.Size(56, 17)
        Me.Label_mobile.TabIndex = 64
        Me.Label_mobile.Text = "Mobile :"
        Me.Label_mobile.Visible = False
        '
        'Cmb_Faculty
        '
        Me.Cmb_Faculty.FormattingEnabled = True
        Me.Cmb_Faculty.Items.AddRange(New Object() {"Science & Technology"})
        Me.Cmb_Faculty.Location = New System.Drawing.Point(549, 197)
        Me.Cmb_Faculty.Name = "Cmb_Faculty"
        Me.Cmb_Faculty.Size = New System.Drawing.Size(165, 21)
        Me.Cmb_Faculty.TabIndex = 68
        Me.Cmb_Faculty.Visible = False
        '
        'Cmb_semester
        '
        Me.Cmb_semester.FormattingEnabled = True
        Me.Cmb_semester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.Cmb_semester.Location = New System.Drawing.Point(550, 288)
        Me.Cmb_semester.Name = "Cmb_semester"
        Me.Cmb_semester.Size = New System.Drawing.Size(165, 21)
        Me.Cmb_semester.TabIndex = 69
        Me.Cmb_semester.Visible = False
        '
        'Cmb_program
        '
        Me.Cmb_program.FormattingEnabled = True
        Me.Cmb_program.Items.AddRange(New Object() {"BCA", "BEIT"})
        Me.Cmb_program.Location = New System.Drawing.Point(549, 257)
        Me.Cmb_program.Name = "Cmb_program"
        Me.Cmb_program.Size = New System.Drawing.Size(165, 21)
        Me.Cmb_program.TabIndex = 70
        Me.Cmb_program.Visible = False
        '
        'Cmb_level
        '
        Me.Cmb_level.FormattingEnabled = True
        Me.Cmb_level.Items.AddRange(New Object() {"Bachelors"})
        Me.Cmb_level.Location = New System.Drawing.Point(549, 225)
        Me.Cmb_level.Name = "Cmb_level"
        Me.Cmb_level.Size = New System.Drawing.Size(165, 21)
        Me.Cmb_level.TabIndex = 71
        Me.Cmb_level.Visible = False
        '
        'Button_submit
        '
        Me.Button_submit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submit.Location = New System.Drawing.Point(650, 387)
        Me.Button_submit.Name = "Button_submit"
        Me.Button_submit.Size = New System.Drawing.Size(64, 29)
        Me.Button_submit.TabIndex = 72
        Me.Button_submit.Text = "Submit"
        Me.Button_submit.UseVisualStyleBackColor = False
        Me.Button_submit.Visible = False
        '
        'Dtp_DOB
        '
        Me.Dtp_DOB.Location = New System.Drawing.Point(176, 353)
        Me.Dtp_DOB.Name = "Dtp_DOB"
        Me.Dtp_DOB.Size = New System.Drawing.Size(181, 20)
        Me.Dtp_DOB.TabIndex = 73
        Me.Dtp_DOB.Visible = False
        '
        'Txt_pwdd
        '
        Me.Txt_pwdd.Location = New System.Drawing.Point(176, 259)
        Me.Txt_pwdd.Name = "Txt_pwdd"
        Me.Txt_pwdd.Size = New System.Drawing.Size(180, 20)
        Me.Txt_pwdd.TabIndex = 75
        Me.Txt_pwdd.Visible = False
        '
        'Label_password
        '
        Me.Label_password.AutoSize = True
        Me.Label_password.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_password.Location = New System.Drawing.Point(64, 262)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(71, 17)
        Me.Label_password.TabIndex = 74
        Me.Label_password.Text = "Password :"
        Me.Label_password.Visible = False
        '
        'Admin_updateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_pwdd)
        Me.Controls.Add(Me.Label_password)
        Me.Controls.Add(Me.Dtp_DOB)
        Me.Controls.Add(Me.Button_submit)
        Me.Controls.Add(Me.Cmb_level)
        Me.Controls.Add(Me.Cmb_program)
        Me.Controls.Add(Me.Cmb_semester)
        Me.Controls.Add(Me.Cmb_Faculty)
        Me.Controls.Add(Me.Txt_phone)
        Me.Controls.Add(Me.Txt_mobile)
        Me.Controls.Add(Me.Label_phone)
        Me.Controls.Add(Me.Label_mobile)
        Me.Controls.Add(Me.Txt_fee)
        Me.Controls.Add(Me.Txt_discount)
        Me.Controls.Add(Me.Label_faculty)
        Me.Controls.Add(Me.Label_program)
        Me.Controls.Add(Me.Label_lev)
        Me.Controls.Add(Me.Label_fee)
        Me.Controls.Add(Me.Label_discount)
        Me.Controls.Add(Me.Label_semester)
        Me.Controls.Add(Me.Txt_address)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_registration)
        Me.Controls.Add(Me.Txt_username)
        Me.Controls.Add(Me.Txt_symbol)
        Me.Controls.Add(Me.Label_symbol_)
        Me.Controls.Add(Me.Label_registration)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.Label_address)
        Me.Controls.Add(Me.Label_DOB)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Label_)
        Me.Controls.Add(Me.Label_symbolSearch)
        Me.Controls.Add(Me.Txt_symbol_search)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_updateStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_updateStudent"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Label_name As Label
    Friend WithEvents Button_search As Button
    Friend WithEvents Label_ As Label
    Friend WithEvents Label_symbolSearch As Label
    Friend WithEvents Txt_symbol_search As TextBox
    Friend WithEvents Label_DOB As Label
    Friend WithEvents Label_address As Label
    Friend WithEvents Label_username As Label
    Friend WithEvents Label_registration As Label
    Friend WithEvents Label_symbol_ As Label
    Friend WithEvents Txt_symbol As TextBox
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txt_registration As TextBox
    Friend WithEvents Txt_address As TextBox
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Txt_fee As TextBox
    Friend WithEvents Txt_discount As TextBox
    Friend WithEvents Label_faculty As Label
    Friend WithEvents Label_program As Label
    Friend WithEvents Label_lev As Label
    Friend WithEvents Label_fee As Label
    Friend WithEvents Label_discount As Label
    Friend WithEvents Label_semester As Label
    Friend WithEvents Txt_phone As TextBox
    Friend WithEvents Txt_mobile As TextBox
    Friend WithEvents Label_phone As Label
    Friend WithEvents Label_mobile As Label
    Friend WithEvents Cmb_Faculty As ComboBox
    Friend WithEvents Cmb_semester As ComboBox
    Friend WithEvents Cmb_program As ComboBox
    Friend WithEvents Cmb_level As ComboBox
    Friend WithEvents Button_submit As Button
    Friend WithEvents Dtp_DOB As DateTimePicker
    Friend WithEvents Txt_pwdd As TextBox
    Friend WithEvents Label_password As Label
End Class
