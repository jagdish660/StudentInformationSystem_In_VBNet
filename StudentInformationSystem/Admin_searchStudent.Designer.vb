<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_searchStudent
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
        Me.Panel_logout_admin = New System.Windows.Forms.Panel()
        Me.Label_SIS = New System.Windows.Forms.Label()
        Me.Txt_symbol_search = New System.Windows.Forms.TextBox()
        Me.Label_symbolSearch = New System.Windows.Forms.Label()
        Me.Label_ = New System.Windows.Forms.Label()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Dgv_search_result = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_search_result, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Txt_symbol_search
        '
        Me.Txt_symbol_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_symbol_search.Location = New System.Drawing.Point(384, 98)
        Me.Txt_symbol_search.Name = "Txt_symbol_search"
        Me.Txt_symbol_search.Size = New System.Drawing.Size(129, 23)
        Me.Txt_symbol_search.TabIndex = 22
        '
        'Label_symbolSearch
        '
        Me.Label_symbolSearch.AutoSize = True
        Me.Label_symbolSearch.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_symbolSearch.Location = New System.Drawing.Point(208, 101)
        Me.Label_symbolSearch.Name = "Label_symbolSearch"
        Me.Label_symbolSearch.Size = New System.Drawing.Size(168, 17)
        Me.Label_symbolSearch.TabIndex = 23
        Me.Label_symbolSearch.Text = "Username or Symbol No. :"
        '
        'Label_
        '
        Me.Label_.AutoSize = True
        Me.Label_.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_.Location = New System.Drawing.Point(301, 69)
        Me.Label_.Name = "Label_"
        Me.Label_.Size = New System.Drawing.Size(148, 17)
        Me.Label_.TabIndex = 24
        Me.Label_.Text = "Search specific student :"
        '
        'Button_search
        '
        Me.Button_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search.Location = New System.Drawing.Point(519, 94)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(64, 29)
        Me.Button_search.TabIndex = 25
        Me.Button_search.Text = "Search"
        Me.Button_search.UseVisualStyleBackColor = False
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
        'Dgv_search_result
        '
        Me.Dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_search_result.Location = New System.Drawing.Point(12, 156)
        Me.Dgv_search_result.Name = "Dgv_search_result"
        Me.Dgv_search_result.Size = New System.Drawing.Size(776, 169)
        Me.Dgv_search_result.TabIndex = 27
        Me.Dgv_search_result.Visible = False
        '
        'Admin_searchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dgv_search_result)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Label_)
        Me.Controls.Add(Me.Label_symbolSearch)
        Me.Controls.Add(Me.Txt_symbol_search)
        Me.Controls.Add(Me.Panel_logout_admin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_SIS)
        Me.Name = "Admin_searchStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_searchStudent"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_search_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_logout_admin As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_SIS As Label
    Friend WithEvents Txt_symbol_search As TextBox
    Friend WithEvents Label_symbolSearch As Label
    Friend WithEvents Label_ As Label
    Friend WithEvents Button_search As Button
    Friend WithEvents Dgv_search_result As DataGridView
End Class
