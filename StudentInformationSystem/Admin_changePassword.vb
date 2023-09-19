Imports MySqlConnector

Public Class Admin_changePassword
    Public Property USERNAME_ As String

    Private Sub Button_searchAdmin_Click(sender As Object, e As EventArgs)
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
            If Txt_oldPWD.Text <> Txt_newPWD1.Text Then ' Use <> to check for inequality
                If Txt_newPWD1.Text = Txt_newPWD2.Text Then
                    Dim commandText As String = "UPDATE `admin` SET `password` = @NewPassword WHERE `admin_id` = @AdminID AND `password` = @OldPassword"
                    Using updateCommand As New MySqlCommand(commandText, Con)
                        updateCommand.Parameters.AddWithValue("@NewPassword", Txt_newPWD1.Text)
                        updateCommand.Parameters.AddWithValue("@AdminID", USERNAME_)
                        updateCommand.Parameters.AddWithValue("@OldPassword", Txt_oldPWD.Text)

                        Con.Open()
                        Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Password updated successfully
                            MsgBox("Password has been updated successfully!")
                            Txt_newPWD1.Text = ""
                            Txt_newPWD2.Text = ""
                            Txt_oldPWD.Text = ""
                            Me.Hide()
                            Dim obj As New Admin_home With {
                                .Username = USERNAME_
                            }
                            obj.Show()
                        Else
                            ' No rows were updated, indicating invalid admin ID or old password
                            MsgBox("Invalid old password. Please check and try again.")
                        End If
                    End Using
                Else
                    MsgBox("New password doesn't match.")
                End If
            Else
                MsgBox("New password mustn't match the old password.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
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

    Private Sub Admin_changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class