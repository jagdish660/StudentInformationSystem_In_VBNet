Imports MySqlConnector

Public Class Student_login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CHKBX_showpassword.CheckedChanged
        Txt_pwd_student.UseSystemPasswordChar = False = CHKBX_showpassword.Checked
        Txt_pwd_student.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SIS1.Show()
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Try
            If Txt_usnme_student.Text = "" And Txt_pwd_student.Text = "" Then
                MsgBox("Enter data fields to login")
            Else
                'Dim con As MySqlConnection
                Dim command As New MySqlCommand("SELECT `admin_id`, `password` FROM `admin` WHERE `admin_id` = '" & Txt_usnme_student.Text & "' AND `password` = '" & Txt_pwd_student.Text & "'", con)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count = 0 Then
                    MessageBox.Show("Invalid Username Or Password")
                Else
                    con.Close()
                    MessageBox.Show("Login Sucessfull!!!")
                    SIS1.Hide()
                    Me.Hide()
                    Admin_home.Show()
                End If

                If Txt_pwd_student.Text = table.Rows(0)("password").ToString And Txt_usnme_student.Text = table.Rows(0)("admin_id").ToString Then
                    SIS1.Hide()
                    Me.Hide()
                    Admin_home.Show()
                Else
                    MessageBox.Show("Invalid Username Or Password")
                End If
            End If
        Catch ex As System.IO.IOException
            Console.WriteLine("Exception :{0}", ex)
        Catch ex As Exception
            Console.WriteLine("Exception :{0}", ex)
        End Try
    End Sub

    'Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
    '   Try
    '       If String.IsNullOrWhiteSpace(Txt_usnme_student.Text) Or String.IsNullOrWhiteSpace(Txt_pwd_student.Text) Then
    '           MsgBox("Enter both username and password to login")
    '      Else
    '           Dim connectionString As String = "YourConnectionStringHere" ' Replace with your database connection string
    '           Using con As New MySqlConnection(connectionString)
    '               con.Open()
    '              Dim query As String = "SELECT `admin_id`, `password` FROM `admin` WHERE `admin_id` = @username AND `password` = @password"
    '               Using command As New MySqlCommand(query, con)
    '                   Command.Parameters.AddWithValue("@username", Txt_usnme_student.Text)
    '                   command.Parameters.AddWithValue("@password", Txt_pwd_student.Text) ' You should hash the password before storing it in the database
    '                   Dim reader As MySqlDataReader = command.ExecuteReader()
    '                   If reader.HasRows Then
    '                       MessageBox.Show("Login Successful!!!")
    '                       SIS1.Hide()
    '                       Me.Hide()
    '                       Admin_home.Show()
    '                  Else
    '                      MessageBox.Show("Invalid Username Or Password")
    '                  End If
    '               End Using
    '           End Using
    '       End If
    '   Catch ex As Exception
    '       MessageBox.Show("An error occurred: " & ex.Message)
    '   End Try
    'End Sub

End Class