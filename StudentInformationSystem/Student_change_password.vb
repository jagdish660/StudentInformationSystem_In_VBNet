Imports MySqlConnector
Public Class Student_change_password
    Public Property User_name_ As String

    Private Sub ButtonSubmitPWDchnge_Click(sender As Object, e As EventArgs) Handles ButtonSubmitPWDchnge.Click
        Try
            If Txt_oldPWD.Text IsNot Txt_newPWD1 Then
                If Txt_newPWD1.Text = Txt_newPWD2.Text Then
                    CHNGEPSWD()
                Else
                    MsgBox("New password doesn't match.")
                End If
            Else
                MsgBox("New password mustn't match the old password. ")
            End If
        Catch ex As MySqlException
            Dim unused = MsgBox("MySQL error : " & ex.Message)
        Catch ex As Exception
            Dim unused4 = MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub CHNGEPSWD()
        Try
            Con.Open()
            Dim commandText As String = $"UPDATE `student` SET `password` = @NewPassword WHERE `username` = @Username AND `password` = @OldPassword"
            Using updateCommand As New MySqlCommand(commandText, Con)
                updateCommand.Parameters.AddWithValue("@NewPassword", Txt_newPWD1.Text)
                updateCommand.Parameters.AddWithValue("@Username", User_name_)
                updateCommand.Parameters.AddWithValue("@OldPassword", Txt_oldPWD.Text)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Password updated successfully
                    MsgBox("Password has been updated successfully!")
                    Txt_newPWD1.Text = ""
                    Txt_newPWD2.Text = ""
                    Txt_oldPWD.Text = ""
                    Hide()
                    SIS1.Show()
                Else
                    ' No rows were updated, indicating invalid username or old password
                    MsgBox("Invalid old password. Please check and try again.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button_searchAdmin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Student_change_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class