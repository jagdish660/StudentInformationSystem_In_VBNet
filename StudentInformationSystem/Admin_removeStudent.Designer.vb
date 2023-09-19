<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_removeStudent
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
        Me.Button_searchAdmin = New System.Windows.Forms.Button()
        Me.Txt_student_Search = New System.Windows.Forms.TextBox()
        Me.Label_symbol = New System.Windows.Forms.Label()
        Me.DGV_student = New System.Windows.Forms.DataGridView()
        Me.Button_deleteStudent = New System.Windows.Forms.Button()
        Me.Label_Delete_verification = New System.Windows.Forms.Label()
        Me.Button_delete_YES = New System.Windows.Forms.Button()
        Me.Button_delete_NO = New System.Windows.Forms.Button()
        Me.Button_reset = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_logout_admin
        '
        Me.Panel_logout_admin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_logout_admin.Location = New System.Drawing.Point(595, 84)
        Me.Panel_logout_admin.Name = "Panel_logout_admin"
        Me.Panel_logout_admin.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_admin.TabIndex = 21
        '
        'Label_SIS
        '
        Me.Label_SIS.AutoSize = True
        Me.Label_SIS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_SIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SIS.Location = New System.Drawing.Point(225, 28)
        Me.Label_SIS.Name = "Label_SIS"
        Me.Label_SIS.Size = New System.Drawing.Size(382, 25)
        Me.Label_SIS.TabIndex = 17
        Me.Label_SIS.Text = "STUDENT INFORMATION SYSTEM"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox1.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Button_searchAdmin
        '
        Me.Button_searchAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_searchAdmin.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_searchAdmin.Location = New System.Drawing.Point(325, 118)
        Me.Button_searchAdmin.Name = "Button_searchAdmin"
        Me.Button_searchAdmin.Size = New System.Drawing.Size(75, 27)
        Me.Button_searchAdmin.TabIndex = 33
        Me.Button_searchAdmin.Text = "Proceed"
        Me.Button_searchAdmin.UseVisualStyleBackColor = False
        '
        'Txt_student_Search
        '
        Me.Txt_student_Search.Location = New System.Drawing.Point(161, 122)
        Me.Txt_student_Search.Name = "Txt_student_Search"
        Me.Txt_student_Search.Size = New System.Drawing.Size(142, 20)
        Me.Txt_student_Search.TabIndex = 32
        '
        'Label_symbol
        '
        Me.Label_symbol.AutoSize = True
        Me.Label_symbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_symbol.Location = New System.Drawing.Point(63, 127)
        Me.Label_symbol.Name = "Label_symbol"
        Me.Label_symbol.Size = New System.Drawing.Size(92, 15)
        Me.Label_symbol.TabIndex = 31
        Me.Label_symbol.Text = "Symbol No. : "
        '
        'DGV_student
        '
        Me.DGV_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_student.Location = New System.Drawing.Point(28, 164)
        Me.DGV_student.Name = "DGV_student"
        Me.DGV_student.Size = New System.Drawing.Size(745, 150)
        Me.DGV_student.TabIndex = 34
        Me.DGV_student.Visible = False
        '
        'Button_deleteStudent
        '
        Me.Button_deleteStudent.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_deleteStudent.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_deleteStudent.Location = New System.Drawing.Point(663, 329)
        Me.Button_deleteStudent.Name = "Button_deleteStudent"
        Me.Button_deleteStudent.Size = New System.Drawing.Size(75, 27)
        Me.Button_deleteStudent.TabIndex = 35
        Me.Button_deleteStudent.Text = "Delete"
        Me.Button_deleteStudent.UseVisualStyleBackColor = False
        Me.Button_deleteStudent.Visible = False
        '
        'Label_Delete_verification
        '
        Me.Label_Delete_verification.AutoSize = True
        Me.Label_Delete_verification.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delete_verification.Location = New System.Drawing.Point(534, 370)
        Me.Label_Delete_verification.Name = "Label_Delete_verification"
        Me.Label_Delete_verification.Size = New System.Drawing.Size(204, 17)
        Me.Label_Delete_verification.TabIndex = 36
        Me.Label_Delete_verification.Text = "Are you sure you want to delete ?"
        Me.Label_Delete_verification.Visible = False
        '
        'Button_delete_YES
        '
        Me.Button_delete_YES.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_delete_YES.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_delete_YES.Location = New System.Drawing.Point(556, 390)
        Me.Button_delete_YES.Name = "Button_delete_YES"
        Me.Button_delete_YES.Size = New System.Drawing.Size(65, 27)
        Me.Button_delete_YES.TabIndex = 37
        Me.Button_delete_YES.Text = "YES"
        Me.Button_delete_YES.UseVisualStyleBackColor = False
        Me.Button_delete_YES.Visible = False
        '
        'Button_delete_NO
        '
        Me.Button_delete_NO.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_delete_NO.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_delete_NO.Location = New System.Drawing.Point(646, 390)
        Me.Button_delete_NO.Name = "Button_delete_NO"
        Me.Button_delete_NO.Size = New System.Drawing.Size(65, 27)
        Me.Button_delete_NO.TabIndex = 38
        Me.Button_delete_NO.Text = "NO"
        Me.Button_delete_NO.UseVisualStyleBackColor = False
        Me.Button_delete_NO.Visible = False
        '
        'Button_reset
        '
        Me.Button_reset.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_reset.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_reset.Location = New System.Drawing.Point(537, 329)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(75, 27)
        Me.Button_reset.TabIndex = 39
        Me.Button_reset.Text = "Reset"
        Me.Button_reset.UseVisualStyleBackColor = False
        Me.Button_reset.Visible = False
        '
        'Admin_removeStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_reset)
        Me.Controls.Add(Me.Button_delete_NO)
        Me.Controls.Add(Me.Button_delete_YES)
        Me.Controls.Add(Me.Label_Delete_verification)
        Me.Controls.Add(Me.Button_deleteStudent)
        Me.Controls.Add(Me.DGV_student)
        Me.Controls.Add(Me.Button_searchAdmin)
        Me.Controls.Add(Me.Txt_student_Search)
        Me.Controls.Add(Me.Label_symbol)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_removeStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_removeStudent"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Button_searchAdmin As Button
    Friend WithEvents Txt_student_Search As TextBox
    Friend WithEvents Label_symbol As Label
    Friend WithEvents DGV_student As DataGridView
    Friend WithEvents Button_deleteStudent As Button
    Friend WithEvents Label_Delete_verification As Label
    Friend WithEvents Button_delete_YES As Button
    Friend WithEvents Button_delete_NO As Button
    Friend WithEvents Button_reset As Button
End Class
