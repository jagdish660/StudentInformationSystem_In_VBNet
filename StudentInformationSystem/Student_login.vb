Imports MySqlConnector
Public Class Student_login
    'Public globalvariables As Object
    'Public user_name As String = globalvariables.usrnm
    'Public pass_word As String = globalvariables.psswrd

    Private ReadOnly user_name As String

    Public Sub New(ByVal user_name As String)
        InitializeComponent()
        Me.user_name = user_name
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CHKBX_showpassword.CheckedChanged
        Txt_pwd_student.UseSystemPasswordChar = False = CHKBX_showpassword.Checked
        Txt_pwd_student.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        SIS1.Show()
    End Sub

    Public Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Try
            If Txt_usnme_student.Text IsNot "" Or Txt_pwd_student.Text IsNot "" Then
                Using table As New DataTable()
                    Dim command As New MySqlCommand("SELECT `username`, `password` FROM `student` WHERE `username` = '" & Txt_usnme_student.Text & "' AND `password` = '" & Txt_pwd_student.Text & "'", Con)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(table)
                    End Using
                    Select Case table.Rows.Count
                        Case 0
                            Dim unused3 = MessageBox.Show("Invalid Username Or Password")
                        Case Else
                            Dim obj As New Student_home1
                            'Check()
                            SIS1.Hide()
                            Me.Hide()
                            obj.User_name = Txt_usnme_student.Text
                            obj.Show()
                            Txt_usnme_student.Text = ""
                            Txt_pwd_student.Text = ""
                    End Select
                End Using
            Else
                Dim unused = MsgBox("Enter data fields to login")
            End If
        Catch ex As Exception
            Dim unused1 = MsgBox(ex.Message)
        Finally
            Con.Close()
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
    '                       Student_home1.Show()
    '                  Else
    '                      MessageBox.Show("Invalid Username Or Password")
    '                  End If
    '               End Using
    '           End Using
    '       End If
    '   Catch ex As Exception
    '       MsgBox(ex.Message)
    '   End Try
    'End Sub

End Class