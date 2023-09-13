<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Studentmngmnt
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button_Studentmngmnt = New System.Windows.Forms.Button()
        Me.Button_feemngmnt = New System.Windows.Forms.Button()
        Me.Button_coursemngmnt = New System.Windows.Forms.Button()
        Me.Label_addStudent = New System.Windows.Forms.Label()
        Me.Label_UpdateStudent = New System.Windows.Forms.Label()
        Me.Label_RemoveStudent = New System.Windows.Forms.Label()
        Me.Label_SearchStudent = New System.Windows.Forms.Label()
        Me.Pic_searchStudent = New System.Windows.Forms.PictureBox()
        Me.Pic_removeStudent = New System.Windows.Forms.PictureBox()
        Me.Pic_updateStudent = New System.Windows.Forms.PictureBox()
        Me.Pic_addnewStudent = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Pic_back = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_searchStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_removeStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_updateStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_addnewStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(34, 116)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 244)
        Me.ListBox1.TabIndex = 20
        '
        'Button_Studentmngmnt
        '
        Me.Button_Studentmngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Studentmngmnt.Location = New System.Drawing.Point(34, 116)
        Me.Button_Studentmngmnt.Name = "Button_Studentmngmnt"
        Me.Button_Studentmngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_Studentmngmnt.TabIndex = 21
        Me.Button_Studentmngmnt.Text = "Student"
        Me.Button_Studentmngmnt.UseVisualStyleBackColor = True
        '
        'Button_feemngmnt
        '
        Me.Button_feemngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_feemngmnt.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Button_feemngmnt.Location = New System.Drawing.Point(174, 116)
        Me.Button_feemngmnt.Name = "Button_feemngmnt"
        Me.Button_feemngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_feemngmnt.TabIndex = 22
        Me.Button_feemngmnt.Text = "Fee"
        Me.Button_feemngmnt.UseVisualStyleBackColor = True
        '
        'Button_coursemngmnt
        '
        Me.Button_coursemngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_coursemngmnt.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Button_coursemngmnt.Location = New System.Drawing.Point(104, 116)
        Me.Button_coursemngmnt.Name = "Button_coursemngmnt"
        Me.Button_coursemngmnt.Size = New System.Drawing.Size(70, 23)
        Me.Button_coursemngmnt.TabIndex = 23
        Me.Button_coursemngmnt.Text = "Course"
        Me.Button_coursemngmnt.UseVisualStyleBackColor = True
        '
        'Label_addStudent
        '
        Me.Label_addStudent.AutoSize = True
        Me.Label_addStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_addStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_addStudent.Location = New System.Drawing.Point(39, 216)
        Me.Label_addStudent.Name = "Label_addStudent"
        Me.Label_addStudent.Size = New System.Drawing.Size(106, 13)
        Me.Label_addStudent.TabIndex = 27
        Me.Label_addStudent.Text = "Add New Student"
        '
        'Label_UpdateStudent
        '
        Me.Label_UpdateStudent.AutoSize = True
        Me.Label_UpdateStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_UpdateStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UpdateStudent.Location = New System.Drawing.Point(42, 324)
        Me.Label_UpdateStudent.Name = "Label_UpdateStudent"
        Me.Label_UpdateStudent.Size = New System.Drawing.Size(96, 13)
        Me.Label_UpdateStudent.TabIndex = 28
        Me.Label_UpdateStudent.Text = "Update Student"
        '
        'Label_RemoveStudent
        '
        Me.Label_RemoveStudent.AutoSize = True
        Me.Label_RemoveStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_RemoveStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RemoveStudent.Location = New System.Drawing.Point(142, 216)
        Me.Label_RemoveStudent.Name = "Label_RemoveStudent"
        Me.Label_RemoveStudent.Size = New System.Drawing.Size(101, 13)
        Me.Label_RemoveStudent.TabIndex = 29
        Me.Label_RemoveStudent.Text = "Remove Student"
        '
        'Label_SearchStudent
        '
        Me.Label_SearchStudent.AutoSize = True
        Me.Label_SearchStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_SearchStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SearchStudent.Location = New System.Drawing.Point(145, 322)
        Me.Label_SearchStudent.Name = "Label_SearchStudent"
        Me.Label_SearchStudent.Size = New System.Drawing.Size(95, 13)
        Me.Label_SearchStudent.TabIndex = 31
        Me.Label_SearchStudent.Text = "Search Student"
        '
        'Pic_searchStudent
        '
        Me.Pic_searchStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Pic_searchStudent.Image = Global.StudentInformationSystem.My.Resources.Resources.download__2_
        Me.Pic_searchStudent.Location = New System.Drawing.Point(149, 249)
        Me.Pic_searchStudent.Name = "Pic_searchStudent"
        Me.Pic_searchStudent.Size = New System.Drawing.Size(90, 75)
        Me.Pic_searchStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_searchStudent.TabIndex = 30
        Me.Pic_searchStudent.TabStop = False
        '
        'Pic_removeStudent
        '
        Me.Pic_removeStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Pic_removeStudent.Image = Global.StudentInformationSystem.My.Resources.Resources._732584_200
        Me.Pic_removeStudent.Location = New System.Drawing.Point(147, 143)
        Me.Pic_removeStudent.Name = "Pic_removeStudent"
        Me.Pic_removeStudent.Size = New System.Drawing.Size(90, 75)
        Me.Pic_removeStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_removeStudent.TabIndex = 26
        Me.Pic_removeStudent.TabStop = False
        '
        'Pic_updateStudent
        '
        Me.Pic_updateStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Pic_updateStudent.Image = Global.StudentInformationSystem.My.Resources.Resources._847987_200
        Me.Pic_updateStudent.Location = New System.Drawing.Point(43, 249)
        Me.Pic_updateStudent.Name = "Pic_updateStudent"
        Me.Pic_updateStudent.Size = New System.Drawing.Size(100, 75)
        Me.Pic_updateStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_updateStudent.TabIndex = 25
        Me.Pic_updateStudent.TabStop = False
        '
        'Pic_addnewStudent
        '
        Me.Pic_addnewStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Pic_addnewStudent.Image = Global.StudentInformationSystem.My.Resources.Resources._847977_200
        Me.Pic_addnewStudent.Location = New System.Drawing.Point(41, 143)
        Me.Pic_addnewStudent.Name = "Pic_addnewStudent"
        Me.Pic_addnewStudent.Size = New System.Drawing.Size(100, 75)
        Me.Pic_addnewStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_addnewStudent.TabIndex = 24
        Me.Pic_addnewStudent.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StudentInformationSystem.My.Resources.Resources.png_transparent_computer_icons_service_technology_setting_miscellaneous_service_business_thumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(700, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
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
        'Pic_back
        '
        Me.Pic_back.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.Pic_back.Location = New System.Drawing.Point(12, 69)
        Me.Pic_back.Name = "Pic_back"
        Me.Pic_back.Size = New System.Drawing.Size(32, 30)
        Me.Pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_back.TabIndex = 15
        Me.Pic_back.TabStop = False
        '
        'Admin_Studentmngmnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_SearchStudent)
        Me.Controls.Add(Me.Pic_searchStudent)
        Me.Controls.Add(Me.Label_RemoveStudent)
        Me.Controls.Add(Me.Label_UpdateStudent)
        Me.Controls.Add(Me.Label_addStudent)
        Me.Controls.Add(Me.Pic_removeStudent)
        Me.Controls.Add(Me.Pic_updateStudent)
        Me.Controls.Add(Me.Pic_addnewStudent)
        Me.Controls.Add(Me.Button_coursemngmnt)
        Me.Controls.Add(Me.Button_feemngmnt)
        Me.Controls.Add(Me.Button_Studentmngmnt)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Pic_back)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_Studentmngmnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Studentmngmnt"
        CType(Me.Pic_searchStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_removeStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_updateStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_addnewStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic_back As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button_Studentmngmnt As Button
    Friend WithEvents Button_feemngmnt As Button
    Friend WithEvents Button_coursemngmnt As Button
    Friend WithEvents Pic_addnewStudent As PictureBox
    Friend WithEvents Pic_updateStudent As PictureBox
    Friend WithEvents Pic_removeStudent As PictureBox
    Friend WithEvents Label_addStudent As Label
    Friend WithEvents Label_UpdateStudent As Label
    Friend WithEvents Label_RemoveStudent As Label
    Friend WithEvents Pic_searchStudent As PictureBox
    Friend WithEvents Label_SearchStudent As Label
End Class
