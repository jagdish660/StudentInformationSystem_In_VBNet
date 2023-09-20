Imports MySqlConnector
Public Class Student_home1
    Public Property User_name As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_student.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_student.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim obj As New Student_change_password
        Me.Hide()
        obj.User_name_ = User_name
        obj.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox_myInfo.Click
        Dim obj1 As New Student_info
        Me.Hide()
        obj1.User_name = User_name
        obj1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox_course.Click
        Dim obj As New Student_courses
        Me.Hide()
        obj.User__name = User_name
        obj.Show()
    End Sub

    Private Sub Student_home1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Con.Open()
            Dim sql As String = "SELECT name FROM student WHERE username = @username"

            ' Create a MySqlCommand with parameterized query
            Dim cmd As New MySqlCommand(sql, Con)
            cmd.Parameters.AddWithValue("@username", User_name)

            Dim adapter As New MySqlDataAdapter(cmd)

            Dim table As New DataTable()
            Dim rowsAffected As Integer = adapter.Fill(table)

            If rowsAffected > 0 Then
                ' Assuming that 'name' is in the first row and first column of the result
                Label_usernamee.Text = table.Rows(0)(0).ToString()
            Else
                ' No matching username found
                Label_usernamee.Text = "Username not found."
            End If

        Catch ex As Exception
            ' Display the error message
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub
End Class