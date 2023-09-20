Imports MySqlConnector
Public Class Student_courses
    Public Property User__name
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_back.Click
        Me.Hide()
        Student_home1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox_enrolled.Click
        Try
            Label_fee.Visible = False
            Dgv_available_courses.Visible = False
            Dgv_fee.Visible = False
            Label_course.Visible = True
            DGV_enrolled_Courses.Visible = True
            Label_program.Visible = False
            Cmb_program.Visible = False
            Button_search.Visible = False
            ' Retrieve the program of the currently logged-in student
            Dim enrolled_course As String
            Con.Open()
            Dim programQuery As String = "SELECT `program` FROM student WHERE `username` = @Username"
            Dim programCommand As New MySqlCommand(programQuery, Con)
            programCommand.Parameters.AddWithValue("@Username", User__name)
            enrolled_course = programCommand.ExecuteScalar()?.ToString()

            ' Check if the program was retrieved successfully
            If Not String.IsNullOrEmpty(enrolled_course) Then
                ' Use the retrieved program to fetch enrolled courses
                Dim query As String = "SELECT `coursecode`,`course`,`semester`,`credithours` FROM `coursedata` WHERE `program` = @EnrolledProgram"
                Dim command As New MySqlCommand(query, Con)
                command.Parameters.AddWithValue("@EnrolledProgram", enrolled_course)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Bind the DataGridView to the DataTable
                DGV_enrolled_Courses.DataSource = table
                DGV_enrolled_Courses.Refresh()
            Else
                MsgBox("Program information not found for the user.")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox_courses.Click
        Dgv_available_courses.DataSource = Nothing
        Try
            Label_program.Visible = True
            Cmb_program.Visible = True
            Button_search.Visible = True
            Dgv_fee.Visible = False
            Label_course.Visible = True
            Dgv_available_courses.Visible = True
            Label_fee.Visible = False
            DGV_enrolled_Courses.Visible = False
            Cmb_program.Text = ""
            ' Dim username As String = Txt_symbol_search.Text
            Dim query As String = "SELECT * FROM `coursedata` WHERE 1"

            'Using con As New MySqlConnection("YourConnectionString")
            Con.Open()

            Dim command As New MySqlCommand(query, Con)
            command.Parameters.AddWithValue("@Username", User__name)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Bind the DataGridView to the DataTable
            Dgv_available_courses.DataSource = table
            Dgv_available_courses.Refresh()
            'End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox_logout.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_student.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_student.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim obj As New Student_change_password
        Hide()
        obj.User_name_ = User__name
        obj.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox_fee.Click
        Try
            Label_program.Visible = False
            Cmb_program.Visible = False
            Button_search.Visible = False
            Label_fee.Visible = True
            DGV_enrolled_Courses.Visible = False
            Label_course.Visible = False
            Dgv_available_courses.Visible = False
            Dgv_fee.Visible = True
            ' Retrieve the serial number first
            Dim serial As String = ""

            Using Con
                Con.Open()
                Dim serialQuery As String = "SELECT s_no FROM `student` WHERE `username` = @Username"
                Dim command1 As New MySqlCommand(serialQuery, Con)
                command1.Parameters.AddWithValue("@Username", User__name)
                Dim reader As MySqlDataReader = command1.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    serial = reader("s_no").ToString()
                End If

                reader.Close()

                ' Now that you have the serial number, you can use it in the query
                Dim query As String = "SELECT `Total_fee`,`Discount`,`totalpaid`,`fee_due` FROM `fee` WHERE s_no = @Serial"
                Dim command As New MySqlCommand(query, Con)
                command.Parameters.AddWithValue("@Serial", serial)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Bind the DataGridView to the DataTable
                Dgv_fee.DataSource = table
                Dgv_fee.Refresh()
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Student_courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Dgv_fee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_fee.CellContentClick

    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Dgv_available_courses.DataSource = Nothing
        Label_program.Visible = True
        Cmb_program.Visible = True
        Button_search.Visible = True
        Try
            Dgv_fee.Visible = False
            Label_course.Visible = True
            Dgv_available_courses.Visible = True
            Label_fee.Visible = False
            DGV_enrolled_Courses.Visible = False
            ' Dim username As String = Txt_symbol_search.Text
            Dim query As String = "SELECT * FROM `coursedata` WHERE `program`='" & Cmb_program.Text & "'"

            'Using con As New MySqlConnection("YourConnectionString")
            Con.Open()

            Dim command As New MySqlCommand(query, Con)
            command.Parameters.AddWithValue("@Username", User__name)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Bind the DataGridView to the DataTable
            Dgv_available_courses.DataSource = table
            Dgv_available_courses.Refresh()
            'End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
End Class