Imports MySqlConnector
Public Class Admin_login
    Private Sub CHKBX_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CHKBX_showpassword.CheckedChanged
        Txt_password_admin.UseSystemPasswordChar = False = CHKBX_showpassword.Checked
        Txt_password_admin.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SIS1.Show()
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Try
            If Txt_username_admin.Text IsNot "" And Txt_password_admin.Text IsNot "" Then
                Using table As New DataTable()
                    Dim unused1 = New MySqlDataAdapter(New MySqlCommand(commandText:=$"SELECT `admin_id`, `password` FROM `admin` WHERE `admin_id` = '{Txt_username_admin.Text}' AND `password` = '{Txt_password_admin.Text}'", Con)).Fill(table)
                    Select Case table.Rows.Count
                        Case 0
                            Dim unused3 = MessageBox.Show("Invalid Username Or Password")
                        Case Else
                            SIS1.Hide()
                            Hide()
                            Dim obj As New Admin_home With {
                                .Username = Txt_username_admin.Text
                            }
                            obj.Show()
                            Txt_password_admin.Text = ""
                            Txt_username_admin.Text = ""
                    End Select
                End Using
            Else
                Dim unused2 = MsgBox("Enter data fields to login")
            End If
        Catch ex As Exception
            Dim unused4 = MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        SIS1.Hide()
        Admin_forgot_password.Show()
    End Sub

    Private Sub Admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class