Imports MySqlConnector
Public Class Student_info

    Public Property User_name As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form1 As New Student_home1()
        Hide()
        form1.Show()
    End Sub

    Private Sub Student_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM student WHERE `Username` = @usernme"

            Dim adapter As New MySqlDataAdapter(New MySqlCommand(query, Con))
            adapter.SelectCommand.Parameters.AddWithValue("@usernme", User_name)

            Dim table As New DataTable()
            Dim unused = adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)
                Txt_name.Text = row("name").ToString()
                Txt_registrstion.Text = row("registration").ToString()
                Txt_symbol.Text = row("S_no").ToString()
                Txt_username.Text = row("Username").ToString()
                Txt_address.Text = row("address").ToString()
                Dtp_DOB.Text = row("Date of Birth").ToString() ' Use backticks or square brackets for column names with spaces
                Txt_mobile.Text = row("mobile").ToString()
                Txt_phone.Text = row("email address").ToString()
                Txt_faculty.Text = row("faculty").ToString()
                Txt_level.Text = row("level").ToString()
                Txt_program.Text = row("program").ToString()
                Txt_semester.Text = row("semester").ToString()
            Else
                ' Clear the fields if no matching record is found
                Txt_name.Text = ""
                Txt_username.Text = ""
                Txt_address.Text = ""
                Dtp_DOB.Text = ""
                Txt_mobile.Text = ""
                Txt_phone.Text = ""
                Txt_faculty.Text = ""
                Txt_level.Text = ""
                Txt_program.Text = ""
                Txt_semester.Text = ""
                Txt_registrstion.Text = ""
                Txt_symbol.Text = ""
                MsgBox("Record not found.")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_student.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_student.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim obj As New Student_change_password
        Hide()
        obj.User_name_ = User_name
        obj.Show()
    End Sub

End Class