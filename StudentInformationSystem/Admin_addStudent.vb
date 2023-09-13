Imports MySqlConnector
Public Class Admin_addStudent
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Admin_changePassword.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Admin_Studentmngmnt.Show()
    End Sub

    Private Sub Admin_addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        TXT_Symbol.Text = ""
        TXT_Registrstion.Text = ""
        TXT_Name.Text = ""
        TXT_Address.Text = ""
        TXT_DOB.Text = ""
        TXT_username.Text = ""
        TXT_password.Text = ""
        TXT_mobile.Text = ""
        TXT_phone.Text = ""
        TXT_faculty.Text = ""
        TXT_level.Text = ""
        TXT_program.Text = ""
        TXT_fee.Text = ""
        TXT_discount.Text = ""
    End Sub

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles Button_Submit.Click
        Try
            Dim sql As String
            Dim i As Integer

            Con.Open()
            sql = "INSERT INTO `student` (`S_no`, `Registration`, `username`, `password`, `Name`, `Address`, `Date of Birth`, `phone`, `Mobile`, `Faculty`, `Level`, `Program`, `Semester`, `Fee`, `Discount`) VALUES ('" & TXT_Symbol.Text & "', '" & TXT_Registrstion.Text & "', '" & TXT_username.Text & "', '" & TXT_password.Text & "', '" & TXT_Name.Text & "', '" & TXT_Address.Text & "', '" & TXT_DOB.Text & "', '" & TXT_phone.Text & "', '" & TXT_mobile.Text & "', '" & TXT_faculty.Text & "', '" & TXT_level.Text & "', '" & TXT_program.Text & "', '" & TXT_semester.Text & "', '" & TXT_fee.Text & "', '" & TXT_discount.Text & "')"

            Dim mysc As New MySqlCommand(sql, Con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                Admin_Studentmngmnt.Show()
                Me.Close()
            End If
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub
End Class