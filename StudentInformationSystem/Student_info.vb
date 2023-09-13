Imports MySqlConnector
Public Class Student_info
    Private ReadOnly user_n_ame As String

    Public Sub New(user_name As String)
        If String.IsNullOrEmpty(user_name) Then
            Throw New ArgumentException($"'{NameOf(user_name)}' cannot be null or empty.", NameOf(user_name))
        End If

        InitializeComponent()
        Me.User_name = user_n_ame
    End Sub

    Public globalvariables As Object

    Public Property User_name As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form1 As New Student_home()
        Hide()
        form1.Show()
    End Sub

    Private Sub Student_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Not designed yet.")
    End Sub



    Private Sub ChkBx_see_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx_see.CheckedChanged
        SHOW_STUDENT_INFO()

    End Sub

    Private Sub SHOW_STUDENT_INFO()
        Try
            Dim adapter As New MySqlDataAdapter(New MySqlCommand("SELECT * FROM `employee` WHERE  `mobile` = '" & User_name & "' ", Con))
            Dim table As New DataTable()
            Dim unused1 = adapter.Fill(table)
            If table.Rows.Count > 0 Then

                Dim name As String = table.Rows(0)("name").ToString
                Dim address As String = table.Rows(0)("address").ToString
                Dim age As String = table.Rows(0)("Date of Birth").ToString
                Dim mobile As String = table.Rows(0)("mobile").ToString
                Dim id As String = table.Rows(0)("S_no").ToString
                Dim registration As String = table.Rows(0)("registration").ToString
                Dim department As String = table.Rows(0)("faculty").ToString
                Dim Level As String = table.Rows(0)("level").ToString
                Dim phone As String = table.Rows(0)("name").ToString
                Dim program As String = table.Rows(0)("name").ToString
                '   Dim name As String = table.Rows(0)("name").ToString
                Dim semester As String = table.Rows(0)("name").ToString

                Con.Close()
                Txt_name.Text = name
                Txt_DOB.Text = age
                Txt_mobile.Text = mobile
                Txt_symbol.Text = id
                Txt_faculty.Text = department
                Txt_level.Text = Level
                Txt_address.Text = address
                Txt_phone.Text = phone
                Txt_program.Text = program
                Txt_semester.Text = semester

            Else

            End If
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message)
        End Try
    End Sub
End Class