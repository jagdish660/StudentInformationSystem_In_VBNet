<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Coursemngmnt
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
        Me.Label_SIS = New System.Windows.Forms.Label()
        Me.Panel_logout_admin = New System.Windows.Forms.Panel()
        Me.Button_coursemngmnt = New System.Windows.Forms.Button()
        Me.Button_feemngmnt = New System.Windows.Forms.Button()
        Me.Button_Studentmngmnt = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label_addcourse = New System.Windows.Forms.Label()
        Me.Label_updateCourse = New System.Windows.Forms.Label()
        Me.Label_searchCourse = New System.Windows.Forms.Label()
        Me.Label_removeCourse = New System.Windows.Forms.Label()
        Me.PictureBox_search = New System.Windows.Forms.PictureBox()
        Me.PictureBox_update = New System.Windows.Forms.PictureBox()
        Me.PictureBox_remove = New System.Windows.Forms.PictureBox()
        Me.PictureBox_add = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_back = New System.Windows.Forms.PictureBox()
        Me.Label_course_search = New System.Windows.Forms.Label()
        Me.Txt_courseSearch = New System.Windows.Forms.TextBox()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label_code = New System.Windows.Forms.Label()
        Me.Txt_code = New System.Windows.Forms.TextBox()
        Me.Label_program = New System.Windows.Forms.Label()
        Me.Txt_program = New System.Windows.Forms.TextBox()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Label_semester = New System.Windows.Forms.Label()
        Me.Label_credit = New System.Windows.Forms.Label()
        Me.Button_submitADD = New System.Windows.Forms.Button()
        Me.Cmb_semester = New System.Windows.Forms.ComboBox()
        Me.Cmb_faculty = New System.Windows.Forms.ComboBox()
        Me.Cmb_credit = New System.Windows.Forms.ComboBox()
        Me.PictureBox_Course_back = New System.Windows.Forms.PictureBox()
        Me.Dgv_course_delete = New System.Windows.Forms.DataGridView()
        Me.Button_courseSEARCH_dgv = New System.Windows.Forms.Button()
        Me.ButtonCOURSEREMOVE = New System.Windows.Forms.Button()
        Me.ButtonCOURSEupdate = New System.Windows.Forms.Button()
        Me.Button_submit_delete = New System.Windows.Forms.Button()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.Button_delete_NO = New System.Windows.Forms.Button()
        Me.Button_delete_YES = New System.Windows.Forms.Button()
        Me.Label_Delete_verification = New System.Windows.Forms.Label()
        Me.Button_submitUpdate = New System.Windows.Forms.Button()
        Me.Label_faculty = New System.Windows.Forms.Label()
        Me.Label_level = New System.Windows.Forms.Label()
        Me.Cmb_level = New System.Windows.Forms.ComboBox()
        Me.Dgv_search_result = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_remove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Course_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_course_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_search_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_SIS
        '
        Me.Label_SIS.AutoSize = True
        Me.Label_SIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SIS.Location = New System.Drawing.Point(225, 28)
        Me.Label_SIS.Name = "Label_SIS"
        Me.Label_SIS.Size = New System.Drawing.Size(382, 25)
        Me.Label_SIS.TabIndex = 14
        Me.Label_SIS.Text = "STUDENT INFORMATION SYSTEM"
        '
        'Panel_logout_admin
        '
        Me.Panel_logout_admin.Location = New System.Drawing.Point(595, 84)
        Me.Panel_logout_admin.Name = "Panel_logout_admin"
        Me.Panel_logout_admin.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_admin.TabIndex = 19
        '
        'Button_coursemngmnt
        '
        Me.Button_coursemngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_coursemngmnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_coursemngmnt.Location = New System.Drawing.Point(104, 116)
        Me.Button_coursemngmnt.Name = "Button_coursemngmnt"
        Me.Button_coursemngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_coursemngmnt.TabIndex = 27
        Me.Button_coursemngmnt.Text = "Course"
        Me.Button_coursemngmnt.UseVisualStyleBackColor = True
        '
        'Button_feemngmnt
        '
        Me.Button_feemngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_feemngmnt.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Button_feemngmnt.Location = New System.Drawing.Point(174, 116)
        Me.Button_feemngmnt.Name = "Button_feemngmnt"
        Me.Button_feemngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_feemngmnt.TabIndex = 26
        Me.Button_feemngmnt.Text = "Fee"
        Me.Button_feemngmnt.UseVisualStyleBackColor = True
        '
        'Button_Studentmngmnt
        '
        Me.Button_Studentmngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Studentmngmnt.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Button_Studentmngmnt.Location = New System.Drawing.Point(34, 116)
        Me.Button_Studentmngmnt.Name = "Button_Studentmngmnt"
        Me.Button_Studentmngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_Studentmngmnt.TabIndex = 25
        Me.Button_Studentmngmnt.Text = "Student"
        Me.Button_Studentmngmnt.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(34, 116)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 244)
        Me.ListBox1.TabIndex = 24
        '
        'Label_addcourse
        '
        Me.Label_addcourse.AutoSize = True
        Me.Label_addcourse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_addcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_addcourse.Location = New System.Drawing.Point(55, 216)
        Me.Label_addcourse.Name = "Label_addcourse"
        Me.Label_addcourse.Size = New System.Drawing.Size(72, 13)
        Me.Label_addcourse.TabIndex = 32
        Me.Label_addcourse.Text = "Add Course"
        '
        'Label_updateCourse
        '
        Me.Label_updateCourse.AutoSize = True
        Me.Label_updateCourse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_updateCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_updateCourse.Location = New System.Drawing.Point(46, 331)
        Me.Label_updateCourse.Name = "Label_updateCourse"
        Me.Label_updateCourse.Size = New System.Drawing.Size(91, 13)
        Me.Label_updateCourse.TabIndex = 33
        Me.Label_updateCourse.Text = "Update Course"
        '
        'Label_searchCourse
        '
        Me.Label_searchCourse.AutoSize = True
        Me.Label_searchCourse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_searchCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_searchCourse.Location = New System.Drawing.Point(148, 216)
        Me.Label_searchCourse.Name = "Label_searchCourse"
        Me.Label_searchCourse.Size = New System.Drawing.Size(90, 13)
        Me.Label_searchCourse.TabIndex = 34
        Me.Label_searchCourse.Text = "Search Course"
        '
        'Label_removeCourse
        '
        Me.Label_removeCourse.AutoSize = True
        Me.Label_removeCourse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_removeCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_removeCourse.Location = New System.Drawing.Point(145, 332)
        Me.Label_removeCourse.Name = "Label_removeCourse"
        Me.Label_removeCourse.Size = New System.Drawing.Size(96, 13)
        Me.Label_removeCourse.TabIndex = 35
        Me.Label_removeCourse.Text = "Remove Course"
        '
        'PictureBox_search
        '
        Me.PictureBox_search.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox_search.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336994241615607445_m__1_
        Me.PictureBox_search.Location = New System.Drawing.Point(147, 145)
        Me.PictureBox_search.Name = "PictureBox_search"
        Me.PictureBox_search.Size = New System.Drawing.Size(90, 75)
        Me.PictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_search.TabIndex = 31
        Me.PictureBox_search.TabStop = False
        '
        'PictureBox_update
        '
        Me.PictureBox_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox_update.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470868_m
        Me.PictureBox_update.Location = New System.Drawing.Point(40, 258)
        Me.PictureBox_update.Name = "PictureBox_update"
        Me.PictureBox_update.Size = New System.Drawing.Size(100, 75)
        Me.PictureBox_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_update.TabIndex = 30
        Me.PictureBox_update.TabStop = False
        '
        'PictureBox_remove
        '
        Me.PictureBox_remove.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox_remove.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470867_m
        Me.PictureBox_remove.Location = New System.Drawing.Point(146, 258)
        Me.PictureBox_remove.Name = "PictureBox_remove"
        Me.PictureBox_remove.Size = New System.Drawing.Size(90, 75)
        Me.PictureBox_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_remove.TabIndex = 29
        Me.PictureBox_remove.TabStop = False
        '
        'PictureBox_add
        '
        Me.PictureBox_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox_add.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470866_m
        Me.PictureBox_add.Location = New System.Drawing.Point(40, 145)
        Me.PictureBox_add.Name = "PictureBox_add"
        Me.PictureBox_add.Size = New System.Drawing.Size(100, 75)
        Me.PictureBox_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_add.TabIndex = 28
        Me.PictureBox_add.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.StudentInformationSystem.My.Resources.Resources.images__1_
        Me.PictureBox3.Location = New System.Drawing.Point(664, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox_back
        '
        Me.PictureBox_back.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox_back.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox_back.Name = "PictureBox_back"
        Me.PictureBox_back.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_back.TabIndex = 15
        Me.PictureBox_back.TabStop = False
        '
        'Label_course_search
        '
        Me.Label_course_search.AutoSize = True
        Me.Label_course_search.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_course_search.Location = New System.Drawing.Point(268, 122)
        Me.Label_course_search.Name = "Label_course_search"
        Me.Label_course_search.Size = New System.Drawing.Size(90, 17)
        Me.Label_course_search.TabIndex = 36
        Me.Label_course_search.Text = "Course code :"
        Me.Label_course_search.Visible = False
        '
        'Txt_courseSearch
        '
        Me.Txt_courseSearch.Location = New System.Drawing.Point(363, 122)
        Me.Txt_courseSearch.Name = "Txt_courseSearch"
        Me.Txt_courseSearch.Size = New System.Drawing.Size(117, 20)
        Me.Txt_courseSearch.TabIndex = 37
        Me.Txt_courseSearch.Visible = False
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(364, 183)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(308, 20)
        Me.Txt_name.TabIndex = 40
        Me.Txt_name.Visible = False
        '
        'Label_code
        '
        Me.Label_code.AutoSize = True
        Me.Label_code.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_code.Location = New System.Drawing.Point(268, 155)
        Me.Label_code.Name = "Label_code"
        Me.Label_code.Size = New System.Drawing.Size(85, 16)
        Me.Label_code.TabIndex = 39
        Me.Label_code.Text = "Course code :"
        Me.Label_code.Visible = False
        '
        'Txt_code
        '
        Me.Txt_code.Location = New System.Drawing.Point(364, 154)
        Me.Txt_code.Name = "Txt_code"
        Me.Txt_code.Size = New System.Drawing.Size(117, 20)
        Me.Txt_code.TabIndex = 42
        Me.Txt_code.Visible = False
        '
        'Label_program
        '
        Me.Label_program.AutoSize = True
        Me.Label_program.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_program.Location = New System.Drawing.Point(268, 283)
        Me.Label_program.Name = "Label_program"
        Me.Label_program.Size = New System.Drawing.Size(63, 16)
        Me.Label_program.TabIndex = 41
        Me.Label_program.Text = "Program :"
        Me.Label_program.Visible = False
        '
        'Txt_program
        '
        Me.Txt_program.Location = New System.Drawing.Point(364, 281)
        Me.Txt_program.Name = "Txt_program"
        Me.Txt_program.Size = New System.Drawing.Size(121, 20)
        Me.Txt_program.TabIndex = 44
        Me.Txt_program.Visible = False
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.Location = New System.Drawing.Point(268, 183)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(88, 16)
        Me.Label_name.TabIndex = 43
        Me.Label_name.Text = "Course name :"
        Me.Label_name.Visible = False
        '
        'Label_semester
        '
        Me.Label_semester.AutoSize = True
        Me.Label_semester.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_semester.Location = New System.Drawing.Point(268, 318)
        Me.Label_semester.Name = "Label_semester"
        Me.Label_semester.Size = New System.Drawing.Size(66, 16)
        Me.Label_semester.TabIndex = 45
        Me.Label_semester.Text = "Semester :"
        Me.Label_semester.Visible = False
        '
        'Label_credit
        '
        Me.Label_credit.AutoSize = True
        Me.Label_credit.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_credit.Location = New System.Drawing.Point(268, 355)
        Me.Label_credit.Name = "Label_credit"
        Me.Label_credit.Size = New System.Drawing.Size(77, 16)
        Me.Label_credit.TabIndex = 47
        Me.Label_credit.Text = "Credit hour :"
        Me.Label_credit.Visible = False
        '
        'Button_submitADD
        '
        Me.Button_submitADD.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_submitADD.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submitADD.Location = New System.Drawing.Point(439, 388)
        Me.Button_submitADD.Name = "Button_submitADD"
        Me.Button_submitADD.Size = New System.Drawing.Size(64, 25)
        Me.Button_submitADD.TabIndex = 49
        Me.Button_submitADD.Text = "Submit"
        Me.Button_submitADD.UseVisualStyleBackColor = False
        Me.Button_submitADD.Visible = False
        '
        'Cmb_semester
        '
        Me.Cmb_semester.FormattingEnabled = True
        Me.Cmb_semester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.Cmb_semester.Location = New System.Drawing.Point(364, 315)
        Me.Cmb_semester.Name = "Cmb_semester"
        Me.Cmb_semester.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_semester.TabIndex = 50
        Me.Cmb_semester.Visible = False
        '
        'Cmb_faculty
        '
        Me.Cmb_faculty.FormattingEnabled = True
        Me.Cmb_faculty.Items.AddRange(New Object() {"Science & Technology", "Management"})
        Me.Cmb_faculty.Location = New System.Drawing.Point(364, 213)
        Me.Cmb_faculty.Name = "Cmb_faculty"
        Me.Cmb_faculty.Size = New System.Drawing.Size(179, 21)
        Me.Cmb_faculty.TabIndex = 51
        Me.Cmb_faculty.Visible = False
        '
        'Cmb_credit
        '
        Me.Cmb_credit.FormattingEnabled = True
        Me.Cmb_credit.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Cmb_credit.Location = New System.Drawing.Point(364, 349)
        Me.Cmb_credit.Name = "Cmb_credit"
        Me.Cmb_credit.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_credit.TabIndex = 52
        Me.Cmb_credit.Visible = False
        '
        'PictureBox_Course_back
        '
        Me.PictureBox_Course_back.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox_Course_back.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox_Course_back.Name = "PictureBox_Course_back"
        Me.PictureBox_Course_back.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox_Course_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Course_back.TabIndex = 53
        Me.PictureBox_Course_back.TabStop = False
        Me.PictureBox_Course_back.Visible = False
        '
        'Dgv_course_delete
        '
        Me.Dgv_course_delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_course_delete.Location = New System.Drawing.Point(270, 150)
        Me.Dgv_course_delete.Name = "Dgv_course_delete"
        Me.Dgv_course_delete.Size = New System.Drawing.Size(515, 169)
        Me.Dgv_course_delete.TabIndex = 54
        Me.Dgv_course_delete.Visible = False
        '
        'Button_courseSEARCH_dgv
        '
        Me.Button_courseSEARCH_dgv.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_courseSEARCH_dgv.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_courseSEARCH_dgv.Location = New System.Drawing.Point(487, 119)
        Me.Button_courseSEARCH_dgv.Name = "Button_courseSEARCH_dgv"
        Me.Button_courseSEARCH_dgv.Size = New System.Drawing.Size(56, 25)
        Me.Button_courseSEARCH_dgv.TabIndex = 55
        Me.Button_courseSEARCH_dgv.Text = "Search"
        Me.Button_courseSEARCH_dgv.UseVisualStyleBackColor = False
        Me.Button_courseSEARCH_dgv.Visible = False
        '
        'ButtonCOURSEREMOVE
        '
        Me.ButtonCOURSEREMOVE.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonCOURSEREMOVE.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCOURSEREMOVE.Location = New System.Drawing.Point(487, 118)
        Me.ButtonCOURSEREMOVE.Name = "ButtonCOURSEREMOVE"
        Me.ButtonCOURSEREMOVE.Size = New System.Drawing.Size(56, 25)
        Me.ButtonCOURSEREMOVE.TabIndex = 56
        Me.ButtonCOURSEREMOVE.Text = "Search"
        Me.ButtonCOURSEREMOVE.UseVisualStyleBackColor = False
        Me.ButtonCOURSEREMOVE.Visible = False
        '
        'ButtonCOURSEupdate
        '
        Me.ButtonCOURSEupdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonCOURSEupdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCOURSEupdate.Location = New System.Drawing.Point(487, 116)
        Me.ButtonCOURSEupdate.Name = "ButtonCOURSEupdate"
        Me.ButtonCOURSEupdate.Size = New System.Drawing.Size(56, 25)
        Me.ButtonCOURSEupdate.TabIndex = 57
        Me.ButtonCOURSEupdate.Text = "Search"
        Me.ButtonCOURSEupdate.UseVisualStyleBackColor = False
        Me.ButtonCOURSEupdate.Visible = False
        '
        'Button_submit_delete
        '
        Me.Button_submit_delete.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_submit_delete.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submit_delete.Location = New System.Drawing.Point(642, 325)
        Me.Button_submit_delete.Name = "Button_submit_delete"
        Me.Button_submit_delete.Size = New System.Drawing.Size(64, 25)
        Me.Button_submit_delete.TabIndex = 58
        Me.Button_submit_delete.Text = "Delete"
        Me.Button_submit_delete.UseVisualStyleBackColor = False
        Me.Button_submit_delete.Visible = False
        '
        'Button_reset
        '
        Me.Button_reset.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_reset.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_reset.Location = New System.Drawing.Point(521, 325)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(64, 25)
        Me.Button_reset.TabIndex = 59
        Me.Button_reset.Text = "Reset"
        Me.Button_reset.UseVisualStyleBackColor = False
        Me.Button_reset.Visible = False
        '
        'Button_delete_NO
        '
        Me.Button_delete_NO.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_delete_NO.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_delete_NO.Location = New System.Drawing.Point(629, 386)
        Me.Button_delete_NO.Name = "Button_delete_NO"
        Me.Button_delete_NO.Size = New System.Drawing.Size(65, 27)
        Me.Button_delete_NO.TabIndex = 62
        Me.Button_delete_NO.Text = "NO"
        Me.Button_delete_NO.UseVisualStyleBackColor = False
        Me.Button_delete_NO.Visible = False
        '
        'Button_delete_YES
        '
        Me.Button_delete_YES.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_delete_YES.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_delete_YES.Location = New System.Drawing.Point(539, 386)
        Me.Button_delete_YES.Name = "Button_delete_YES"
        Me.Button_delete_YES.Size = New System.Drawing.Size(65, 27)
        Me.Button_delete_YES.TabIndex = 61
        Me.Button_delete_YES.Text = "YES"
        Me.Button_delete_YES.UseVisualStyleBackColor = False
        Me.Button_delete_YES.Visible = False
        '
        'Label_Delete_verification
        '
        Me.Label_Delete_verification.AutoSize = True
        Me.Label_Delete_verification.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delete_verification.Location = New System.Drawing.Point(517, 366)
        Me.Label_Delete_verification.Name = "Label_Delete_verification"
        Me.Label_Delete_verification.Size = New System.Drawing.Size(204, 17)
        Me.Label_Delete_verification.TabIndex = 60
        Me.Label_Delete_verification.Text = "Are you sure you want to delete ?"
        Me.Label_Delete_verification.Visible = False
        '
        'Button_submitUpdate
        '
        Me.Button_submitUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_submitUpdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submitUpdate.Location = New System.Drawing.Point(439, 388)
        Me.Button_submitUpdate.Name = "Button_submitUpdate"
        Me.Button_submitUpdate.Size = New System.Drawing.Size(64, 25)
        Me.Button_submitUpdate.TabIndex = 63
        Me.Button_submitUpdate.Text = "Submit"
        Me.Button_submitUpdate.UseVisualStyleBackColor = False
        Me.Button_submitUpdate.Visible = False
        '
        'Label_faculty
        '
        Me.Label_faculty.AutoSize = True
        Me.Label_faculty.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_faculty.Location = New System.Drawing.Point(267, 216)
        Me.Label_faculty.Name = "Label_faculty"
        Me.Label_faculty.Size = New System.Drawing.Size(53, 16)
        Me.Label_faculty.TabIndex = 65
        Me.Label_faculty.Text = "Faculty :"
        Me.Label_faculty.Visible = False
        '
        'Label_level
        '
        Me.Label_level.AutoSize = True
        Me.Label_level.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_level.Location = New System.Drawing.Point(267, 250)
        Me.Label_level.Name = "Label_level"
        Me.Label_level.Size = New System.Drawing.Size(43, 16)
        Me.Label_level.TabIndex = 66
        Me.Label_level.Text = "Level :"
        Me.Label_level.Visible = False
        '
        'Cmb_level
        '
        Me.Cmb_level.FormattingEnabled = True
        Me.Cmb_level.Items.AddRange(New Object() {"Bachelors", "Masters"})
        Me.Cmb_level.Location = New System.Drawing.Point(363, 247)
        Me.Cmb_level.Name = "Cmb_level"
        Me.Cmb_level.Size = New System.Drawing.Size(122, 21)
        Me.Cmb_level.TabIndex = 68
        Me.Cmb_level.Visible = False
        '
        'Dgv_search_result
        '
        Me.Dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_search_result.Location = New System.Drawing.Point(270, 150)
        Me.Dgv_search_result.Name = "Dgv_search_result"
        Me.Dgv_search_result.Size = New System.Drawing.Size(515, 263)
        Me.Dgv_search_result.TabIndex = 69
        Me.Dgv_search_result.Visible = False
        '
        'Admin_Coursemngmnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dgv_search_result)
        Me.Controls.Add(Me.Cmb_level)
        Me.Controls.Add(Me.Label_level)
        Me.Controls.Add(Me.Label_faculty)
        Me.Controls.Add(Me.Button_submitUpdate)
        Me.Controls.Add(Me.Button_delete_NO)
        Me.Controls.Add(Me.Button_delete_YES)
        Me.Controls.Add(Me.Label_Delete_verification)
        Me.Controls.Add(Me.Button_reset)
        Me.Controls.Add(Me.Button_submit_delete)
        Me.Controls.Add(Me.ButtonCOURSEupdate)
        Me.Controls.Add(Me.ButtonCOURSEREMOVE)
        Me.Controls.Add(Me.Button_courseSEARCH_dgv)
        Me.Controls.Add(Me.Dgv_course_delete)
        Me.Controls.Add(Me.PictureBox_Course_back)
        Me.Controls.Add(Me.Cmb_credit)
        Me.Controls.Add(Me.Cmb_faculty)
        Me.Controls.Add(Me.Cmb_semester)
        Me.Controls.Add(Me.Button_submitADD)
        Me.Controls.Add(Me.Label_credit)
        Me.Controls.Add(Me.Label_semester)
        Me.Controls.Add(Me.Txt_program)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Txt_code)
        Me.Controls.Add(Me.Label_program)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Label_code)
        Me.Controls.Add(Me.Txt_courseSearch)
        Me.Controls.Add(Me.Label_course_search)
        Me.Controls.Add(Me.Label_removeCourse)
        Me.Controls.Add(Me.Label_searchCourse)
        Me.Controls.Add(Me.Label_updateCourse)
        Me.Controls.Add(Me.Label_addcourse)
        Me.Controls.Add(Me.PictureBox_search)
        Me.Controls.Add(Me.PictureBox_update)
        Me.Controls.Add(Me.PictureBox_remove)
        Me.Controls.Add(Me.PictureBox_add)
        Me.Controls.Add(Me.Button_coursemngmnt)
        Me.Controls.Add(Me.Button_feemngmnt)
        Me.Controls.Add(Me.Button_Studentmngmnt)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox_back)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_Coursemngmnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Coursemngmnt"
        CType(Me.PictureBox_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_remove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Course_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_course_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_search_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_back As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button_coursemngmnt As Button
    Friend WithEvents Button_feemngmnt As Button
    Friend WithEvents Button_Studentmngmnt As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox_add As PictureBox
    Friend WithEvents PictureBox_remove As PictureBox
    Friend WithEvents PictureBox_update As PictureBox
    Friend WithEvents PictureBox_search As PictureBox
    Friend WithEvents Label_addcourse As Label
    Friend WithEvents Label_updateCourse As Label
    Friend WithEvents Label_searchCourse As Label
    Friend WithEvents Label_removeCourse As Label
    Friend WithEvents Label_course_search As Label
    Friend WithEvents Txt_courseSearch As TextBox
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label_code As Label
    Friend WithEvents Txt_code As TextBox
    Friend WithEvents Label_program As Label
    Friend WithEvents Txt_program As TextBox
    Friend WithEvents Label_name As Label
    Friend WithEvents Label_semester As Label
    Friend WithEvents Label_credit As Label
    Friend WithEvents Button_submitADD As Button
    Friend WithEvents Cmb_semester As ComboBox
    Friend WithEvents Cmb_faculty As ComboBox
    Friend WithEvents Cmb_credit As ComboBox
    Friend WithEvents PictureBox_Course_back As PictureBox
    Friend WithEvents Dgv_course_delete As DataGridView
    Friend WithEvents Button_courseSEARCH_dgv As Button
    Friend WithEvents ButtonCOURSEREMOVE As Button
    Friend WithEvents ButtonCOURSEupdate As Button
    Friend WithEvents Button_submit_delete As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Button_delete_NO As Button
    Friend WithEvents Button_delete_YES As Button
    Friend WithEvents Label_Delete_verification As Label
    Friend WithEvents Button_submitUpdate As Button
    Friend WithEvents Label_faculty As Label
    Friend WithEvents Label_level As Label
    Friend WithEvents Cmb_level As ComboBox
    Friend WithEvents Dgv_search_result As DataGridView
End Class
