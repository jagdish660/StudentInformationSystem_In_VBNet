<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_forgot_password
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
        Me.PictureBox_back = New System.Windows.Forms.PictureBox()
        Me.Label_adminID = New System.Windows.Forms.Label()
        Me.Txt_adminID = New System.Windows.Forms.TextBox()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Txt_newpwd = New System.Windows.Forms.TextBox()
        Me.Label_newpwd = New System.Windows.Forms.Label()
        Me.Label_DOB = New System.Windows.Forms.Label()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Txt_newpwd1 = New System.Windows.Forms.TextBox()
        Me.Label_newped1 = New System.Windows.Forms.Label()
        Me.Dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.Btn_submit = New System.Windows.Forms.Button()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label_adminID
        '
        Me.Label_adminID.AutoSize = True
        Me.Label_adminID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_adminID.Location = New System.Drawing.Point(177, 122)
        Me.Label_adminID.Name = "Label_adminID"
        Me.Label_adminID.Size = New System.Drawing.Size(66, 13)
        Me.Label_adminID.TabIndex = 16
        Me.Label_adminID.Text = "Admin ID :"
        '
        'Txt_adminID
        '
        Me.Txt_adminID.Location = New System.Drawing.Point(260, 119)
        Me.Txt_adminID.Name = "Txt_adminID"
        Me.Txt_adminID.Size = New System.Drawing.Size(126, 20)
        Me.Txt_adminID.TabIndex = 17
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Location = New System.Drawing.Point(392, 114)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(69, 29)
        Me.Btn_search.TabIndex = 18
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Txt_newpwd
        '
        Me.Txt_newpwd.Location = New System.Drawing.Point(302, 273)
        Me.Txt_newpwd.MaxLength = 16
        Me.Txt_newpwd.Name = "Txt_newpwd"
        Me.Txt_newpwd.Size = New System.Drawing.Size(180, 20)
        Me.Txt_newpwd.TabIndex = 20
        Me.Txt_newpwd.Visible = False
        '
        'Label_newpwd
        '
        Me.Label_newpwd.AutoSize = True
        Me.Label_newpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_newpwd.Location = New System.Drawing.Point(177, 276)
        Me.Label_newpwd.Name = "Label_newpwd"
        Me.Label_newpwd.Size = New System.Drawing.Size(109, 13)
        Me.Label_newpwd.TabIndex = 19
        Me.Label_newpwd.Text = "Enter new password :"
        Me.Label_newpwd.Visible = False
        '
        'Label_DOB
        '
        Me.Label_DOB.AutoSize = True
        Me.Label_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DOB.Location = New System.Drawing.Point(177, 234)
        Me.Label_DOB.Name = "Label_DOB"
        Me.Label_DOB.Size = New System.Drawing.Size(87, 13)
        Me.Label_DOB.TabIndex = 21
        Me.Label_DOB.Text = "Enter your DOB :"
        Me.Label_DOB.Visible = False
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(302, 190)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(180, 20)
        Me.Txt_name.TabIndex = 24
        Me.Txt_name.Visible = False
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.Location = New System.Drawing.Point(177, 192)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(106, 13)
        Me.Label_name.TabIndex = 23
        Me.Label_name.Text = "Enter your full name :"
        Me.Label_name.Visible = False
        '
        'Txt_newpwd1
        '
        Me.Txt_newpwd1.Location = New System.Drawing.Point(302, 314)
        Me.Txt_newpwd1.MaxLength = 16
        Me.Txt_newpwd1.Name = "Txt_newpwd1"
        Me.Txt_newpwd1.Size = New System.Drawing.Size(180, 20)
        Me.Txt_newpwd1.TabIndex = 26
        Me.Txt_newpwd1.Visible = False
        '
        'Label_newped1
        '
        Me.Label_newped1.AutoSize = True
        Me.Label_newped1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_newped1.Location = New System.Drawing.Point(177, 317)
        Me.Label_newped1.Name = "Label_newped1"
        Me.Label_newped1.Size = New System.Drawing.Size(125, 13)
        Me.Label_newped1.TabIndex = 25
        Me.Label_newped1.Text = "Re-enter new password :"
        Me.Label_newped1.Visible = False
        '
        'Dtp_DOB
        '
        Me.Dtp_DOB.Location = New System.Drawing.Point(302, 234)
        Me.Dtp_DOB.Name = "Dtp_DOB"
        Me.Dtp_DOB.Size = New System.Drawing.Size(180, 20)
        Me.Dtp_DOB.TabIndex = 27
        Me.Dtp_DOB.Visible = False
        '
        'Btn_submit
        '
        Me.Btn_submit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_submit.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_submit.Location = New System.Drawing.Point(408, 360)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(111, 29)
        Me.Btn_submit.TabIndex = 28
        Me.Btn_submit.Text = "Change Password"
        Me.Btn_submit.UseVisualStyleBackColor = False
        Me.Btn_submit.Visible = False
        '
        'Admin_forgot_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Dtp_DOB)
        Me.Controls.Add(Me.Txt_newpwd1)
        Me.Controls.Add(Me.Label_newped1)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Label_DOB)
        Me.Controls.Add(Me.Txt_newpwd)
        Me.Controls.Add(Me.Label_newpwd)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Txt_adminID)
        Me.Controls.Add(Me.Label_adminID)
        Me.Controls.Add(Me.PictureBox_back)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_forgot_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_forgot_password"
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_back As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Label_adminID As Label
    Friend WithEvents Txt_adminID As TextBox
    Friend WithEvents Btn_search As Button
    Friend WithEvents Txt_newpwd As TextBox
    Friend WithEvents Label_newpwd As Label
    Friend WithEvents Label_DOB As Label
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label_name As Label
    Friend WithEvents Txt_newpwd1 As TextBox
    Friend WithEvents Label_newped1 As Label
    Friend WithEvents Dtp_DOB As DateTimePicker
    Friend WithEvents Btn_submit As Button
End Class
