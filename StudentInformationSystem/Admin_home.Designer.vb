<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_home
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
        Me.Panel_logout_admin = New System.Windows.Forms.Panel()
        Me.Label_student = New System.Windows.Forms.Label()
        Me.Label_course = New System.Windows.Forms.Label()
        Me.Label_fee = New System.Windows.Forms.Label()
        Me.Pic_course = New System.Windows.Forms.PictureBox()
        Me.Pic_fee = New System.Windows.Forms.PictureBox()
        Me.Pic_student = New System.Windows.Forms.PictureBox()
        Me.Pic_set_ting = New System.Windows.Forms.PictureBox()
        Me.Pic_logout = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_course, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_fee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_set_ting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_SIS
        '
        Me.Label_SIS.AutoSize = True
        Me.Label_SIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SIS.Location = New System.Drawing.Point(224, 27)
        Me.Label_SIS.Name = "Label_SIS"
        Me.Label_SIS.Size = New System.Drawing.Size(382, 25)
        Me.Label_SIS.TabIndex = 2
        Me.Label_SIS.Text = "STUDENT INFORMATION SYSTEM"
        '
        'Panel_logout_admin
        '
        Me.Panel_logout_admin.Location = New System.Drawing.Point(589, 84)
        Me.Panel_logout_admin.Name = "Panel_logout_admin"
        Me.Panel_logout_admin.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_admin.TabIndex = 3
        '
        'Label_student
        '
        Me.Label_student.AutoSize = True
        Me.Label_student.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_student.Location = New System.Drawing.Point(82, 157)
        Me.Label_student.Name = "Label_student"
        Me.Label_student.Size = New System.Drawing.Size(63, 15)
        Me.Label_student.TabIndex = 7
        Me.Label_student.Text = "Students"
        '
        'Label_course
        '
        Me.Label_course.AutoSize = True
        Me.Label_course.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_course.Location = New System.Drawing.Point(81, 249)
        Me.Label_course.Name = "Label_course"
        Me.Label_course.Size = New System.Drawing.Size(59, 15)
        Me.Label_course.TabIndex = 8
        Me.Label_course.Text = "Courses"
        '
        'Label_fee
        '
        Me.Label_fee.AutoSize = True
        Me.Label_fee.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fee.Location = New System.Drawing.Point(94, 331)
        Me.Label_fee.Name = "Label_fee"
        Me.Label_fee.Size = New System.Drawing.Size(33, 15)
        Me.Label_fee.TabIndex = 9
        Me.Label_fee.Text = "FEE"
        '
        'Pic_course
        '
        Me.Pic_course.Image = Global.StudentInformationSystem.My.Resources.Resources.download
        Me.Pic_course.Location = New System.Drawing.Point(62, 175)
        Me.Pic_course.Name = "Pic_course"
        Me.Pic_course.Size = New System.Drawing.Size(100, 90)
        Me.Pic_course.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_course.TabIndex = 6
        Me.Pic_course.TabStop = False
        '
        'Pic_fee
        '
        Me.Pic_fee.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470872_m
        Me.Pic_fee.Location = New System.Drawing.Point(62, 266)
        Me.Pic_fee.Name = "Pic_fee"
        Me.Pic_fee.Size = New System.Drawing.Size(100, 81)
        Me.Pic_fee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_fee.TabIndex = 5
        Me.Pic_fee.TabStop = False
        '
        'Pic_student
        '
        Me.Pic_student.Image = Global.StudentInformationSystem.My.Resources.Resources.images2
        Me.Pic_student.Location = New System.Drawing.Point(62, 84)
        Me.Pic_student.Name = "Pic_student"
        Me.Pic_student.Size = New System.Drawing.Size(100, 90)
        Me.Pic_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_student.TabIndex = 4
        Me.Pic_student.TabStop = False
        '
        'Pic_set_ting
        '
        Me.Pic_set_ting.Image = Global.StudentInformationSystem.My.Resources.Resources.png_transparent_computer_icons_service_technology_setting_miscellaneous_service_business_thumbnail
        Me.Pic_set_ting.Location = New System.Drawing.Point(694, 48)
        Me.Pic_set_ting.Name = "Pic_set_ting"
        Me.Pic_set_ting.Size = New System.Drawing.Size(26, 27)
        Me.Pic_set_ting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_set_ting.TabIndex = 1
        Me.Pic_set_ting.TabStop = False
        '
        'Pic_logout
        '
        Me.Pic_logout.Image = Global.StudentInformationSystem.My.Resources.Resources.images__1_
        Me.Pic_logout.Location = New System.Drawing.Point(658, 48)
        Me.Pic_logout.Name = "Pic_logout"
        Me.Pic_logout.Size = New System.Drawing.Size(30, 27)
        Me.Pic_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_logout.TabIndex = 0
        Me.Pic_logout.TabStop = False
        '
        'Admin_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_fee)
        Me.Controls.Add(Me.Label_course)
        Me.Controls.Add(Me.Label_student)
        Me.Controls.Add(Me.Pic_course)
        Me.Controls.Add(Me.Pic_fee)
        Me.Controls.Add(Me.Pic_student)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.Label_SIS)
        Me.Controls.Add(Me.Pic_set_ting)
        Me.Controls.Add(Me.Pic_logout)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Admin_home"
        Me.Text = "Admin_home"
        CType(Me.Pic_course, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_fee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_set_ting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic_logout As PictureBox
    Friend WithEvents Pic_set_ting As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents Pic_student As PictureBox
    Friend WithEvents Pic_fee As PictureBox
    Friend WithEvents Pic_course As PictureBox
    Friend WithEvents Label_student As Label
    Friend WithEvents Label_course As Label
    Friend WithEvents Label_fee As Label
End Class
