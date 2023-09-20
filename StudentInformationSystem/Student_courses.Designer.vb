<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_courses
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox_enrolled = New System.Windows.Forms.PictureBox()
        Me.PictureBox_fee = New System.Windows.Forms.PictureBox()
        Me.PictureBox_courses = New System.Windows.Forms.PictureBox()
        Me.PictureBox_back = New System.Windows.Forms.PictureBox()
        Me.Panel_logout_student = New System.Windows.Forms.Panel()
        Me.PictureBox_logout = New System.Windows.Forms.PictureBox()
        Me.DGV_enrolled_Courses = New System.Windows.Forms.DataGridView()
        Me.Label_course = New System.Windows.Forms.Label()
        Me.Label_fee = New System.Windows.Forms.Label()
        Me.Dgv_available_courses = New System.Windows.Forms.DataGridView()
        Me.Dgv_fee = New System.Windows.Forms.DataGridView()
        Me.Label_program = New System.Windows.Forms.Label()
        Me.Cmb_program = New System.Windows.Forms.ComboBox()
        Me.Button_search = New System.Windows.Forms.Button()
        CType(Me.PictureBox_enrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_fee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_enrolled_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_available_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_fee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(79, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Enrolled course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(73, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Available courses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(88, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fee details"
        '
        'PictureBox_enrolled
        '
        Me.PictureBox_enrolled.Image = Global.StudentInformationSystem.My.Resources.Resources._309_3099036_completed_course_finished_work_icon_download
        Me.PictureBox_enrolled.Location = New System.Drawing.Point(68, 115)
        Me.PictureBox_enrolled.Name = "PictureBox_enrolled"
        Me.PictureBox_enrolled.Size = New System.Drawing.Size(100, 63)
        Me.PictureBox_enrolled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_enrolled.TabIndex = 16
        Me.PictureBox_enrolled.TabStop = False
        '
        'PictureBox_fee
        '
        Me.PictureBox_fee.Image = Global.StudentInformationSystem.My.Resources.Resources._61_616906_ticket_icon_png_tickets_icon_transparent_png
        Me.PictureBox_fee.Location = New System.Drawing.Point(68, 254)
        Me.PictureBox_fee.Name = "PictureBox_fee"
        Me.PictureBox_fee.Size = New System.Drawing.Size(100, 63)
        Me.PictureBox_fee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_fee.TabIndex = 15
        Me.PictureBox_fee.TabStop = False
        '
        'PictureBox_courses
        '
        Me.PictureBox_courses.Image = Global.StudentInformationSystem.My.Resources.Resources.courses2
        Me.PictureBox_courses.Location = New System.Drawing.Point(68, 184)
        Me.PictureBox_courses.Name = "PictureBox_courses"
        Me.PictureBox_courses.Size = New System.Drawing.Size(100, 63)
        Me.PictureBox_courses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_courses.TabIndex = 14
        Me.PictureBox_courses.TabStop = False
        '
        'PictureBox_back
        '
        Me.PictureBox_back.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox_back.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox_back.Name = "PictureBox_back"
        Me.PictureBox_back.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_back.TabIndex = 13
        Me.PictureBox_back.TabStop = False
        '
        'Panel_logout_student
        '
        Me.Panel_logout_student.Location = New System.Drawing.Point(592, 85)
        Me.Panel_logout_student.Name = "Panel_logout_student"
        Me.Panel_logout_student.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_student.TabIndex = 22
        '
        'PictureBox_logout
        '
        Me.PictureBox_logout.Image = Global.StudentInformationSystem.My.Resources.Resources.images__1_
        Me.PictureBox_logout.Location = New System.Drawing.Point(661, 49)
        Me.PictureBox_logout.Name = "PictureBox_logout"
        Me.PictureBox_logout.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logout.TabIndex = 20
        Me.PictureBox_logout.TabStop = False
        '
        'DGV_enrolled_Courses
        '
        Me.DGV_enrolled_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_enrolled_Courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGV_enrolled_Courses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_enrolled_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_enrolled_Courses.Location = New System.Drawing.Point(207, 165)
        Me.DGV_enrolled_Courses.Name = "DGV_enrolled_Courses"
        Me.DGV_enrolled_Courses.Size = New System.Drawing.Size(572, 273)
        Me.DGV_enrolled_Courses.TabIndex = 23
        Me.DGV_enrolled_Courses.Visible = False
        '
        'Label_course
        '
        Me.Label_course.AutoSize = True
        Me.Label_course.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_course.Location = New System.Drawing.Point(204, 115)
        Me.Label_course.Name = "Label_course"
        Me.Label_course.Size = New System.Drawing.Size(63, 17)
        Me.Label_course.TabIndex = 24
        Me.Label_course.Text = "Courses :"
        Me.Label_course.Visible = False
        '
        'Label_fee
        '
        Me.Label_fee.AutoSize = True
        Me.Label_fee.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fee.Location = New System.Drawing.Point(204, 115)
        Me.Label_fee.Name = "Label_fee"
        Me.Label_fee.Size = New System.Drawing.Size(36, 17)
        Me.Label_fee.TabIndex = 27
        Me.Label_fee.Text = "FEE :"
        Me.Label_fee.Visible = False
        '
        'Dgv_available_courses
        '
        Me.Dgv_available_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_available_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dgv_available_courses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv_available_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_available_courses.Location = New System.Drawing.Point(207, 165)
        Me.Dgv_available_courses.Name = "Dgv_available_courses"
        Me.Dgv_available_courses.Size = New System.Drawing.Size(572, 284)
        Me.Dgv_available_courses.TabIndex = 25
        Me.Dgv_available_courses.Visible = False
        '
        'Dgv_fee
        '
        Me.Dgv_fee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_fee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dgv_fee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv_fee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_fee.Location = New System.Drawing.Point(207, 165)
        Me.Dgv_fee.Name = "Dgv_fee"
        Me.Dgv_fee.Size = New System.Drawing.Size(572, 82)
        Me.Dgv_fee.TabIndex = 28
        Me.Dgv_fee.Visible = False
        '
        'Label_program
        '
        Me.Label_program.AutoSize = True
        Me.Label_program.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_program.Location = New System.Drawing.Point(272, 133)
        Me.Label_program.Name = "Label_program"
        Me.Label_program.Size = New System.Drawing.Size(62, 16)
        Me.Label_program.TabIndex = 29
        Me.Label_program.Text = "Program :"
        Me.Label_program.Visible = False
        '
        'Cmb_program
        '
        Me.Cmb_program.FormattingEnabled = True
        Me.Cmb_program.Items.AddRange(New Object() {"BBA", "BCA", "BEIT"})
        Me.Cmb_program.Location = New System.Drawing.Point(340, 131)
        Me.Cmb_program.Name = "Cmb_program"
        Me.Cmb_program.Size = New System.Drawing.Size(109, 21)
        Me.Cmb_program.TabIndex = 31
        Me.Cmb_program.Visible = False
        '
        'Button_search
        '
        Me.Button_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_search.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search.Location = New System.Drawing.Point(456, 127)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(66, 28)
        Me.Button_search.TabIndex = 32
        Me.Button_search.Text = "Search"
        Me.Button_search.UseVisualStyleBackColor = False
        Me.Button_search.Visible = False
        '
        'Student_courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Cmb_program)
        Me.Controls.Add(Me.Label_program)
        Me.Controls.Add(Me.Dgv_fee)
        Me.Controls.Add(Me.Label_fee)
        Me.Controls.Add(Me.Dgv_available_courses)
        Me.Controls.Add(Me.Label_course)
        Me.Controls.Add(Me.DGV_enrolled_Courses)
        Me.Controls.Add(Me.Panel_logout_student)
        Me.Controls.Add(Me.PictureBox_logout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox_enrolled)
        Me.Controls.Add(Me.PictureBox_fee)
        Me.Controls.Add(Me.PictureBox_courses)
        Me.Controls.Add(Me.PictureBox_back)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Student_courses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_courses"
        CType(Me.PictureBox_enrolled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_fee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_enrolled_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_available_courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_fee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_SIS As Label
    Friend WithEvents PictureBox_back As PictureBox
    Friend WithEvents PictureBox_courses As PictureBox
    Friend WithEvents PictureBox_fee As PictureBox
    Friend WithEvents PictureBox_enrolled As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_logout_student As Panel
    Friend WithEvents PictureBox_logout As PictureBox
    Friend WithEvents DGV_enrolled_Courses As DataGridView
    Friend WithEvents Label_course As Label
    Friend WithEvents Label_fee As Label
    Friend WithEvents Dgv_available_courses As DataGridView
    Friend WithEvents Dgv_fee As DataGridView
    Friend WithEvents Label_program As Label
    Friend WithEvents Cmb_program As ComboBox
    Friend WithEvents Button_search As Button
End Class
