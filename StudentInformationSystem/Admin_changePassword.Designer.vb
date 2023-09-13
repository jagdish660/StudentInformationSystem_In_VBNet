<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_changePassword
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_id = New System.Windows.Forms.Label()
        Me.Labelnew2 = New System.Windows.Forms.Label()
        Me.Labelnew1 = New System.Windows.Forms.Label()
        Me.Label_old1 = New System.Windows.Forms.Label()
        Me.Txt_adminidSearch = New System.Windows.Forms.TextBox()
        Me.Txt_newPWD2 = New System.Windows.Forms.TextBox()
        Me.Txt_newPWD1 = New System.Windows.Forms.TextBox()
        Me.Txt_oldPWD = New System.Windows.Forms.TextBox()
        Me.Button_searchAdmin = New System.Windows.Forms.Button()
        Me.ButtonSubmitPWDchnge = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StudentInformationSystem.My.Resources.Resources.png_transparent_computer_icons_service_technology_setting_miscellaneous_service_business_thumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(700, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
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
        'Label_id
        '
        Me.Label_id.AutoSize = True
        Me.Label_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_id.Location = New System.Drawing.Point(63, 127)
        Me.Label_id.Name = "Label_id"
        Me.Label_id.Size = New System.Drawing.Size(77, 15)
        Me.Label_id.TabIndex = 22
        Me.Label_id.Text = "Admin ID : "
        '
        'Labelnew2
        '
        Me.Labelnew2.AutoSize = True
        Me.Labelnew2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnew2.Location = New System.Drawing.Point(63, 278)
        Me.Labelnew2.Name = "Labelnew2"
        Me.Labelnew2.Size = New System.Drawing.Size(148, 15)
        Me.Labelnew2.TabIndex = 23
        Me.Labelnew2.Text = "Enter new password : "
        Me.Labelnew2.Visible = False
        '
        'Labelnew1
        '
        Me.Labelnew1.AutoSize = True
        Me.Labelnew1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnew1.Location = New System.Drawing.Point(63, 232)
        Me.Labelnew1.Name = "Labelnew1"
        Me.Labelnew1.Size = New System.Drawing.Size(148, 15)
        Me.Labelnew1.TabIndex = 24
        Me.Labelnew1.Text = "Enter new password : "
        Me.Labelnew1.Visible = False
        '
        'Label_old1
        '
        Me.Label_old1.AutoSize = True
        Me.Label_old1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_old1.Location = New System.Drawing.Point(63, 189)
        Me.Label_old1.Name = "Label_old1"
        Me.Label_old1.Size = New System.Drawing.Size(142, 15)
        Me.Label_old1.TabIndex = 25
        Me.Label_old1.Text = "Enter old password : "
        Me.Label_old1.Visible = False
        '
        'Txt_adminidSearch
        '
        Me.Txt_adminidSearch.Location = New System.Drawing.Point(147, 121)
        Me.Txt_adminidSearch.Name = "Txt_adminidSearch"
        Me.Txt_adminidSearch.Size = New System.Drawing.Size(142, 20)
        Me.Txt_adminidSearch.TabIndex = 26
        '
        'Txt_newPWD2
        '
        Me.Txt_newPWD2.Location = New System.Drawing.Point(216, 273)
        Me.Txt_newPWD2.Name = "Txt_newPWD2"
        Me.Txt_newPWD2.Size = New System.Drawing.Size(142, 20)
        Me.Txt_newPWD2.TabIndex = 27
        Me.Txt_newPWD2.Visible = False
        '
        'Txt_newPWD1
        '
        Me.Txt_newPWD1.Location = New System.Drawing.Point(217, 227)
        Me.Txt_newPWD1.Name = "Txt_newPWD1"
        Me.Txt_newPWD1.Size = New System.Drawing.Size(142, 20)
        Me.Txt_newPWD1.TabIndex = 28
        Me.Txt_newPWD1.Visible = False
        '
        'Txt_oldPWD
        '
        Me.Txt_oldPWD.Location = New System.Drawing.Point(217, 184)
        Me.Txt_oldPWD.Name = "Txt_oldPWD"
        Me.Txt_oldPWD.Size = New System.Drawing.Size(142, 20)
        Me.Txt_oldPWD.TabIndex = 29
        Me.Txt_oldPWD.Visible = False
        '
        'Button_searchAdmin
        '
        Me.Button_searchAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_searchAdmin.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_searchAdmin.Location = New System.Drawing.Point(319, 117)
        Me.Button_searchAdmin.Name = "Button_searchAdmin"
        Me.Button_searchAdmin.Size = New System.Drawing.Size(75, 27)
        Me.Button_searchAdmin.TabIndex = 30
        Me.Button_searchAdmin.Text = "Proceed"
        Me.Button_searchAdmin.UseVisualStyleBackColor = False
        '
        'ButtonSubmitPWDchnge
        '
        Me.ButtonSubmitPWDchnge.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonSubmitPWDchnge.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmitPWDchnge.Location = New System.Drawing.Point(249, 315)
        Me.ButtonSubmitPWDchnge.Name = "ButtonSubmitPWDchnge"
        Me.ButtonSubmitPWDchnge.Size = New System.Drawing.Size(75, 28)
        Me.ButtonSubmitPWDchnge.TabIndex = 31
        Me.ButtonSubmitPWDchnge.Text = "Submit"
        Me.ButtonSubmitPWDchnge.UseVisualStyleBackColor = False
        Me.ButtonSubmitPWDchnge.Visible = False
        '
        'Admin_changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSubmitPWDchnge)
        Me.Controls.Add(Me.Button_searchAdmin)
        Me.Controls.Add(Me.Txt_oldPWD)
        Me.Controls.Add(Me.Txt_newPWD1)
        Me.Controls.Add(Me.Txt_newPWD2)
        Me.Controls.Add(Me.Txt_adminidSearch)
        Me.Controls.Add(Me.Label_old1)
        Me.Controls.Add(Me.Labelnew1)
        Me.Controls.Add(Me.Labelnew2)
        Me.Controls.Add(Me.Label_id)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_changePassword"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Label_id As Label
    Friend WithEvents Labelnew2 As Label
    Friend WithEvents Labelnew1 As Label
    Friend WithEvents Label_old1 As Label
    Friend WithEvents Txt_adminidSearch As TextBox
    Friend WithEvents Txt_newPWD2 As TextBox
    Friend WithEvents Txt_newPWD1 As TextBox
    Friend WithEvents Txt_oldPWD As TextBox
    Friend WithEvents Button_searchAdmin As Button
    Friend WithEvents ButtonSubmitPWDchnge As Button
End Class
