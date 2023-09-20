Imports MySqlConnector
Public Class Admin_forgot_password
    Private Sub PictureBox_back_Click(sender As Object, e As EventArgs) Handles PictureBox_back.Click
        Me.Hide()
        SIS1.Show()
    End Sub

    Private Sub Admin_forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        Dim adminid As String = Txt_adminID.Text
        Try
            Con.Open()
            Dim sql As String = "SELECT * FROM admin WHERE admin_id = @username"

            ' Create a MySqlCommand with parameterized query
            Dim cmd As New MySqlCommand(sql, Con)
            cmd.Parameters.AddWithValue("@username", adminid)

            Dim adapter As New MySqlDataAdapter(cmd)

            Dim table As New DataTable()
            Dim rowsAffected As Integer = adapter.Fill(table)

            If rowsAffected <= 0 Then
                ' No matching username found
                MsgBox("Invalid Admin ID entered. Try Again.")
                Me.Hide()
                SIS1.Show()
            Else
                Label_DOB.Visible = True
                Label_name.Visible = True
                Label_newped1.Visible = True
                Label_newpwd.Visible = True
                Txt_name.Visible = True
                Txt_newpwd.Visible = True
                Txt_newpwd1.Visible = True
                Dtp_DOB.Visible = True
                Btn_submit.Visible = True
            End If

        Catch ex As Exception
            ' Display the error message
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click
        Try
            ' Check if the new passwords match
            If Txt_newpwd1.Text = Txt_newpwd.Text Then
                ' Debugging: Print out parameter values
                Console.WriteLine("Admin ID: " & Txt_adminID.Text)
                Console.WriteLine("Name: " & Txt_name.Text)
                Console.WriteLine("DOB: " & Dtp_DOB.Value.ToString("yyyy-MM-dd"))

                ' Check if the user details match
                Dim commandText As String = "UPDATE `admin` SET `password` = @NewPassword WHERE `admin_id` = @AdminID AND `name` = @Name AND `DateofBirth` = @DOB"
                Using updateCommand As New MySqlCommand(commandText, Con)
                    updateCommand.Parameters.AddWithValue("@NewPassword", Txt_newpwd.Text)
                    updateCommand.Parameters.AddWithValue("@AdminID", Txt_adminID.Text)
                    updateCommand.Parameters.AddWithValue("@DOB", Dtp_DOB.Value.ToString("yyyy-MM-dd"))
                    updateCommand.Parameters.AddWithValue("@Name", Txt_name.Text)
                    Con.Open()
                    Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Password updated successfully
                        MsgBox("Password has been updated successfully!")
                        Txt_newpwd1.Text = ""
                        Txt_newpwd.Text = ""
                        Me.Hide()
                        SIS1.Show()
                    Else
                        ' No rows were updated, indicating invalid admin ID, date of birth, or name
                        MsgBox("Invalid admin ID, date of birth, or name. Please check and try again.")
                    End If
                End Using
            Else
                MsgBox("New passwords don't match.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
        End Try


    End Sub
End Class