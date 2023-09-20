<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_feemngmnt
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
        Me.Txt_total_paid = New System.Windows.Forms.TextBox()
        Me.Txt_this_payment = New System.Windows.Forms.TextBox()
        Me.Button_coursemngmnt = New System.Windows.Forms.Button()
        Me.Button_feemngmnt = New System.Windows.Forms.Button()
        Me.Button_Studentmngmnt = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label_searchFee = New System.Windows.Forms.Label()
        Me.Label_updateFEE = New System.Windows.Forms.Label()
        Me.PictureBox_update = New System.Windows.Forms.PictureBox()
        Me.Pic_searchfee = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_back = New System.Windows.Forms.PictureBox()
        Me.Txt_symbol = New System.Windows.Forms.TextBox()
        Me.Button_update_search = New System.Windows.Forms.Button()
        Me.Label_symbol = New System.Windows.Forms.Label()
        Me.Label_TotalFEE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_tobepaid = New System.Windows.Forms.Label()
        Me.Label_this = New System.Windows.Forms.Label()
        Me.Label_due = New System.Windows.Forms.Label()
        Me.Label_installment = New System.Windows.Forms.Label()
        Me.Label_paid = New System.Windows.Forms.Label()
        Me.Label_discount = New System.Windows.Forms.Label()
        Me.Txt_discount = New System.Windows.Forms.TextBox()
        Me.Txt_toBePaid = New System.Windows.Forms.TextBox()
        Me.Txt_installments = New System.Windows.Forms.TextBox()
        Me.Txt_fee_due = New System.Windows.Forms.TextBox()
        Me.Txt_total_fee = New System.Windows.Forms.TextBox()
        Me.Button_search_symbol = New System.Windows.Forms.Button()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Button_submit = New System.Windows.Forms.Button()
        Me.PictureBox_backbuttons = New System.Windows.Forms.PictureBox()
        Me.Panel_logout_admin.SuspendLayout()
        CType(Me.PictureBox_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_searchfee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_backbuttons, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_logout_admin.Controls.Add(Me.Txt_total_paid)
        Me.Panel_logout_admin.Location = New System.Drawing.Point(595, 84)
        Me.Panel_logout_admin.Name = "Panel_logout_admin"
        Me.Panel_logout_admin.Size = New System.Drawing.Size(190, 90)
        Me.Panel_logout_admin.TabIndex = 19
        '
        'Txt_total_paid
        '
        Me.Txt_total_paid.Location = New System.Drawing.Point(18, 72)
        Me.Txt_total_paid.Name = "Txt_total_paid"
        Me.Txt_total_paid.ReadOnly = True
        Me.Txt_total_paid.Size = New System.Drawing.Size(113, 20)
        Me.Txt_total_paid.TabIndex = 48
        Me.Txt_total_paid.Visible = False
        Me.Txt_total_paid.WordWrap = False
        '
        'Txt_this_payment
        '
        Me.Txt_this_payment.Location = New System.Drawing.Point(613, 193)
        Me.Txt_this_payment.Name = "Txt_this_payment"
        Me.Txt_this_payment.Size = New System.Drawing.Size(113, 20)
        Me.Txt_this_payment.TabIndex = 47
        Me.Txt_this_payment.Visible = False
        Me.Txt_this_payment.WordWrap = False
        '
        'Button_coursemngmnt
        '
        Me.Button_coursemngmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_coursemngmnt.ForeColor = System.Drawing.SystemColors.ControlDark
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
        Me.Button_feemngmnt.ForeColor = System.Drawing.SystemColors.ControlText
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
        'Label_searchFee
        '
        Me.Label_searchFee.AutoSize = True
        Me.Label_searchFee.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_searchFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_searchFee.Location = New System.Drawing.Point(45, 214)
        Me.Label_searchFee.Name = "Label_searchFee"
        Me.Label_searchFee.Size = New System.Drawing.Size(95, 12)
        Me.Label_searchFee.TabIndex = 29
        Me.Label_searchFee.Text = "Search Fee Detail"
        '
        'Label_updateFEE
        '
        Me.Label_updateFEE.AutoSize = True
        Me.Label_updateFEE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_updateFEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_updateFEE.Location = New System.Drawing.Point(45, 304)
        Me.Label_updateFEE.Name = "Label_updateFEE"
        Me.Label_updateFEE.Size = New System.Drawing.Size(96, 12)
        Me.Label_updateFEE.TabIndex = 31
        Me.Label_updateFEE.Text = "Update Fee Detail"
        '
        'PictureBox_update
        '
        Me.PictureBox_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox_update.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470871_m
        Me.PictureBox_update.Location = New System.Drawing.Point(43, 231)
        Me.PictureBox_update.Name = "PictureBox_update"
        Me.PictureBox_update.Size = New System.Drawing.Size(100, 73)
        Me.PictureBox_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_update.TabIndex = 30
        Me.PictureBox_update.TabStop = False
        '
        'Pic_searchfee
        '
        Me.Pic_searchfee.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Pic_searchfee.Image = Global.StudentInformationSystem.My.Resources.Resources.photo_6336619316740470870_m
        Me.Pic_searchfee.Location = New System.Drawing.Point(43, 145)
        Me.Pic_searchfee.Name = "Pic_searchfee"
        Me.Pic_searchfee.Size = New System.Drawing.Size(100, 73)
        Me.Pic_searchfee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_searchfee.TabIndex = 28
        Me.Pic_searchfee.TabStop = False
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
        'Txt_symbol
        '
        Me.Txt_symbol.Location = New System.Drawing.Point(355, 113)
        Me.Txt_symbol.Name = "Txt_symbol"
        Me.Txt_symbol.Size = New System.Drawing.Size(113, 20)
        Me.Txt_symbol.TabIndex = 35
        Me.Txt_symbol.Visible = False
        '
        'Button_update_search
        '
        Me.Button_update_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_update_search.Location = New System.Drawing.Point(478, 111)
        Me.Button_update_search.Name = "Button_update_search"
        Me.Button_update_search.Size = New System.Drawing.Size(60, 23)
        Me.Button_update_search.TabIndex = 36
        Me.Button_update_search.Text = "Search"
        Me.Button_update_search.UseVisualStyleBackColor = True
        Me.Button_update_search.Visible = False
        '
        'Label_symbol
        '
        Me.Label_symbol.AutoSize = True
        Me.Label_symbol.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_symbol.Location = New System.Drawing.Point(266, 116)
        Me.Label_symbol.Name = "Label_symbol"
        Me.Label_symbol.Size = New System.Drawing.Size(86, 17)
        Me.Label_symbol.TabIndex = 37
        Me.Label_symbol.Text = "Symbol No. :"
        Me.Label_symbol.Visible = False
        '
        'Label_TotalFEE
        '
        Me.Label_TotalFEE.AutoSize = True
        Me.Label_TotalFEE.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalFEE.Location = New System.Drawing.Point(278, 201)
        Me.Label_TotalFEE.Name = "Label_TotalFEE"
        Me.Label_TotalFEE.Size = New System.Drawing.Size(72, 17)
        Me.Label_TotalFEE.TabIndex = 38
        Me.Label_TotalFEE.Text = "Total FEE : "
        Me.Label_TotalFEE.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 39
        '
        'Label_tobepaid
        '
        Me.Label_tobepaid.AutoSize = True
        Me.Label_tobepaid.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tobepaid.Location = New System.Drawing.Point(271, 281)
        Me.Label_tobepaid.Name = "Label_tobepaid"
        Me.Label_tobepaid.Size = New System.Drawing.Size(79, 17)
        Me.Label_tobepaid.TabIndex = 40
        Me.Label_tobepaid.Text = "To be paid :"
        Me.Label_tobepaid.Visible = False
        '
        'Label_this
        '
        Me.Label_this.AutoSize = True
        Me.Label_this.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_this.Location = New System.Drawing.Point(500, 196)
        Me.Label_this.Name = "Label_this"
        Me.Label_this.Size = New System.Drawing.Size(104, 17)
        Me.Label_this.TabIndex = 41
        Me.Label_this.Text = "This installment :"
        Me.Label_this.Visible = False
        '
        'Label_due
        '
        Me.Label_due.AutoSize = True
        Me.Label_due.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_due.Location = New System.Drawing.Point(500, 240)
        Me.Label_due.Name = "Label_due"
        Me.Label_due.Size = New System.Drawing.Size(61, 17)
        Me.Label_due.TabIndex = 42
        Me.Label_due.Text = "Fee due :"
        Me.Label_due.Visible = False
        '
        'Label_installment
        '
        Me.Label_installment.AutoSize = True
        Me.Label_installment.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_installment.Location = New System.Drawing.Point(500, 278)
        Me.Label_installment.Name = "Label_installment"
        Me.Label_installment.Size = New System.Drawing.Size(84, 17)
        Me.Label_installment.TabIndex = 43
        Me.Label_installment.Text = "Installments :"
        Me.Label_installment.Visible = False
        '
        'Label_paid
        '
        Me.Label_paid.AutoSize = True
        Me.Label_paid.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_paid.Location = New System.Drawing.Point(500, 159)
        Me.Label_paid.Name = "Label_paid"
        Me.Label_paid.Size = New System.Drawing.Size(74, 17)
        Me.Label_paid.TabIndex = 44
        Me.Label_paid.Text = "Total paid :"
        Me.Label_paid.Visible = False
        '
        'Label_discount
        '
        Me.Label_discount.AutoSize = True
        Me.Label_discount.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_discount.Location = New System.Drawing.Point(271, 243)
        Me.Label_discount.Name = "Label_discount"
        Me.Label_discount.Size = New System.Drawing.Size(65, 17)
        Me.Label_discount.TabIndex = 45
        Me.Label_discount.Text = "Discount :"
        Me.Label_discount.Visible = False
        '
        'Txt_discount
        '
        Me.Txt_discount.Location = New System.Drawing.Point(355, 240)
        Me.Txt_discount.Name = "Txt_discount"
        Me.Txt_discount.ReadOnly = True
        Me.Txt_discount.Size = New System.Drawing.Size(113, 20)
        Me.Txt_discount.TabIndex = 46
        Me.Txt_discount.Visible = False
        Me.Txt_discount.WordWrap = False
        '
        'Txt_toBePaid
        '
        Me.Txt_toBePaid.Location = New System.Drawing.Point(355, 278)
        Me.Txt_toBePaid.Name = "Txt_toBePaid"
        Me.Txt_toBePaid.ReadOnly = True
        Me.Txt_toBePaid.Size = New System.Drawing.Size(113, 20)
        Me.Txt_toBePaid.TabIndex = 49
        Me.Txt_toBePaid.Visible = False
        Me.Txt_toBePaid.WordWrap = False
        '
        'Txt_installments
        '
        Me.Txt_installments.Location = New System.Drawing.Point(613, 275)
        Me.Txt_installments.Name = "Txt_installments"
        Me.Txt_installments.ReadOnly = True
        Me.Txt_installments.Size = New System.Drawing.Size(113, 20)
        Me.Txt_installments.TabIndex = 50
        Me.Txt_installments.Visible = False
        Me.Txt_installments.WordWrap = False
        '
        'Txt_fee_due
        '
        Me.Txt_fee_due.Location = New System.Drawing.Point(613, 237)
        Me.Txt_fee_due.Name = "Txt_fee_due"
        Me.Txt_fee_due.ReadOnly = True
        Me.Txt_fee_due.Size = New System.Drawing.Size(113, 20)
        Me.Txt_fee_due.TabIndex = 51
        Me.Txt_fee_due.Visible = False
        Me.Txt_fee_due.WordWrap = False
        '
        'Txt_total_fee
        '
        Me.Txt_total_fee.Location = New System.Drawing.Point(355, 198)
        Me.Txt_total_fee.Name = "Txt_total_fee"
        Me.Txt_total_fee.ReadOnly = True
        Me.Txt_total_fee.Size = New System.Drawing.Size(113, 20)
        Me.Txt_total_fee.TabIndex = 52
        Me.Txt_total_fee.Visible = False
        Me.Txt_total_fee.WordWrap = False
        '
        'Button_search_symbol
        '
        Me.Button_search_symbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search_symbol.Location = New System.Drawing.Point(478, 112)
        Me.Button_search_symbol.Name = "Button_search_symbol"
        Me.Button_search_symbol.Size = New System.Drawing.Size(60, 23)
        Me.Button_search_symbol.TabIndex = 53
        Me.Button_search_symbol.Text = "Search"
        Me.Button_search_symbol.UseVisualStyleBackColor = True
        Me.Button_search_symbol.Visible = False
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(338, 158)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.ReadOnly = True
        Me.Txt_name.Size = New System.Drawing.Size(156, 20)
        Me.Txt_name.TabIndex = 55
        Me.Txt_name.Visible = False
        Me.Txt_name.WordWrap = False
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.Location = New System.Drawing.Point(278, 159)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(54, 17)
        Me.Label_name.TabIndex = 54
        Me.Label_name.Text = "Name : "
        Me.Label_name.Visible = False
        '
        'Button_submit
        '
        Me.Button_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submit.Location = New System.Drawing.Point(666, 301)
        Me.Button_submit.Name = "Button_submit"
        Me.Button_submit.Size = New System.Drawing.Size(60, 23)
        Me.Button_submit.TabIndex = 56
        Me.Button_submit.Text = "Submit"
        Me.Button_submit.UseVisualStyleBackColor = True
        Me.Button_submit.Visible = False
        '
        'PictureBox_backbuttons
        '
        Me.PictureBox_backbuttons.Image = Global.StudentInformationSystem.My.Resources.Resources.pngtree_back_vector_icon_png_image_470452
        Me.PictureBox_backbuttons.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox_backbuttons.Name = "PictureBox_backbuttons"
        Me.PictureBox_backbuttons.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox_backbuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_backbuttons.TabIndex = 57
        Me.PictureBox_backbuttons.TabStop = False
        Me.PictureBox_backbuttons.Visible = False
        '
        'Admin_feemngmnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox_backbuttons)
        Me.Controls.Add(Me.Button_submit)
        Me.Controls.Add(Me.Txt_this_payment)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Button_search_symbol)
        Me.Controls.Add(Me.Txt_total_fee)
        Me.Controls.Add(Me.Txt_fee_due)
        Me.Controls.Add(Me.Txt_installments)
        Me.Controls.Add(Me.Txt_toBePaid)
        Me.Controls.Add(Me.Txt_discount)
        Me.Controls.Add(Me.Label_discount)
        Me.Controls.Add(Me.Label_paid)
        Me.Controls.Add(Me.Label_installment)
        Me.Controls.Add(Me.Label_due)
        Me.Controls.Add(Me.Label_this)
        Me.Controls.Add(Me.Label_tobepaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_TotalFEE)
        Me.Controls.Add(Me.Label_symbol)
        Me.Controls.Add(Me.Button_update_search)
        Me.Controls.Add(Me.Txt_symbol)
        Me.Controls.Add(Me.Label_updateFEE)
        Me.Controls.Add(Me.PictureBox_update)
        Me.Controls.Add(Me.Label_searchFee)
        Me.Controls.Add(Me.Pic_searchfee)
        Me.Controls.Add(Me.Button_coursemngmnt)
        Me.Controls.Add(Me.Button_feemngmnt)
        Me.Controls.Add(Me.Button_Studentmngmnt)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox_back)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_feemngmnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_feemngmnt"
        Me.Panel_logout_admin.ResumeLayout(False)
        Me.Panel_logout_admin.PerformLayout()
        CType(Me.PictureBox_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_searchfee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_backbuttons, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Pic_searchfee As PictureBox
    Friend WithEvents Label_searchFee As Label
    Friend WithEvents PictureBox_update As PictureBox
    Friend WithEvents Label_updateFEE As Label
    Friend WithEvents Txt_symbol As TextBox
    Friend WithEvents Button_update_search As Button
    Friend WithEvents Label_symbol As Label
    Friend WithEvents Label_TotalFEE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_tobepaid As Label
    Friend WithEvents Label_this As Label
    Friend WithEvents Label_due As Label
    Friend WithEvents Label_installment As Label
    Friend WithEvents Label_paid As Label
    Friend WithEvents Label_discount As Label
    Friend WithEvents Txt_this_payment As TextBox
    Friend WithEvents Txt_discount As TextBox
    Friend WithEvents Txt_total_paid As TextBox
    Friend WithEvents Txt_toBePaid As TextBox
    Friend WithEvents Txt_installments As TextBox
    Friend WithEvents Txt_fee_due As TextBox
    Friend WithEvents Txt_total_fee As TextBox
    Friend WithEvents Button_search_symbol As Button
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label_name As Label
    Friend WithEvents Button_submit As Button
    Friend WithEvents PictureBox_backbuttons As PictureBox
End Class
