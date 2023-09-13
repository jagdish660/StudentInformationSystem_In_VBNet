Imports MySqlConnector

Public Class Admin_changePassword
    Private Const PWDCHANGESTRINGG As String = "Password changed successfully. "

    Private Sub Button_searchAdmin_Click(sender As Object, e As EventArgs) Handles Button_searchAdmin.Click
        Label_old1.Visible = True
        Labelnew1.Visible = True
        Labelnew2.Visible = True
        Txt_newPWD1.Visible = True
        Txt_newPWD2.Visible = True
        Txt_oldPWD.Visible = True
        ButtonSubmitPWDchnge.Visible = True

    End Sub

    Private Sub ButtonSubmitPWDchnge_Click(sender As Object, e As EventArgs) Handles ButtonSubmitPWDchnge.Click
        Try
            If Txt_adminidSearch.Text IsNot "" Then
                If Txt_oldPWD.Text IsNot Txt_newPWD1 AndAlso Txt_newPWD1.Text = Txt_newPWD2.Text Then
                    Dim selectCommand As New MySqlCommand(commandText:=$"UPDATE `admin` SET `password` = '" & Txt_newPWD1.Text & "' WHERE `admin_id` = '" & Txt_adminidSearch.Text & "'
", Con)
                    Dim adapter As New MySqlDataAdapter(selectCommand)
                    Dim table As New DataTable()
                    Dim unused1 = adapter.Fill(table)
                    If table.Rows.Count = 0 Then
                        Dim unused3 = MsgBox(PWDCHANGESTRINGG)
                        Txt_newPWD1.Text = ""
                        Txt_newPWD2.Text = ""
                        Txt_oldPWD.Text = ""
                        Hide()
                        Admin_login.Show()
                    Else
                        Dim unused5 = MsgBox("Invalid admin ID.   Enter valid ADMIN ID and try again.")
                    End If
                End If
            Else
                Dim unused2 = MsgBox("Enter data field to proceed.")
            End If
        Catch ex As MySqlException
            Dim unused = MsgBox("MySQL error : " & ex.Message)
        Catch ex As Exception
            Dim unused4 = MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub
End Class