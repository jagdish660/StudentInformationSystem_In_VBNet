Imports MySqlConnector
Public Class Admin_Coursemngmnt
    Public Property U_sername As String
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = U_sername
        }
        obj.Show()
    End Sub

    Private Sub Button_Studentmngmnt_Click(sender As Object, e As EventArgs) Handles Button_Studentmngmnt.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = U_sername
        }
        obj.Show()
    End Sub

    Private Sub Button_coursemngmnt_Click(sender As Object, e As EventArgs) Handles Button_coursemngmnt.Click
        Me.Show()
    End Sub

    Private Sub Button_feemngmnt_Click(sender As Object, e As EventArgs) Handles Button_feemngmnt.Click
        Me.Hide()
        Dim obj As New Admin_feemngmnt With {
            .USERNAME_ = U_sername
        }
        obj.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_back.Click
        Me.Hide()
        Dim obj As New Admin_home With {
            .Username = U_sername
        }
        obj.Show()
    End Sub

    Private Sub Admin_Coursemngmnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox_Course_back_Click(sender As Object, e As EventArgs) Handles PictureBox_Course_back.Click
        PictureBox_Course_back.Visible = False
        Label_searchCourse.Visible = True
        Label_course_search.Visible = False
        Txt_courseSearch.Visible = False
        Label_code.Visible = False
        Txt_code.Visible = False
        Label_credit.Visible = False
        Label_name.Visible = False
        Txt_name.Visible = False
        Label_program.Visible = False
        Txt_program.Visible = False
        Label_level.Visible = False
        Cmb_level.Visible = False
        Cmb_credit.Visible = False
        Cmb_semester.Visible = False
        Cmb_faculty.Visible = False
        Label_faculty.Visible = False
        Button_submitADD.Visible = False
        PictureBox_back.Visible = True
        Dgv_course.Visible = False
        Button_submitUpdate.Visible = False
        ButtonCOURSEREMOVE.Visible = False
        ButtonCOURSEupdate.Visible = False
        Button_courseSEARCH_dgv.Visible = False
        Label_Delete_verification.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Button_reset.Visible = False
        Button_submitADD.Visible = False
        Button_submitUpdate.Visible = False
        Button_submit_delete.Visible = False
        Label_Delete_verification.Visible = False
    End Sub

    Private Sub PictureBox_add_Click(sender As Object, e As EventArgs) Handles PictureBox_add.Click
        PictureBox_back.Visible = False
        PictureBox_Course_back.Visible = True
        Label_course_search.Visible = False
        Txt_courseSearch.Visible = False
        Button_courseSEARCH_dgv.Visible = False
        ButtonCOURSEupdate.Visible = False
        ButtonCOURSEREMOVE.Visible = False
        Dgv_course.Visible = False
        Label_code.Visible = True
        Txt_code.Visible = True
        Txt_code.ReadOnly = False
        Label_name.Visible = True
        Txt_name.Visible = True
        Label_faculty.Visible = True
        Cmb_faculty.Visible = True
        Label_program.Visible = True
        Txt_program.Visible = True
        Label_level.Visible = True
        Cmb_level.Visible = True
        Label_semester.Visible = True
        Cmb_semester.Visible = True
        Label_credit.Visible = True
        Cmb_credit.Visible = True
        Button_submitADD.Visible = True
        Button_submitUpdate.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Button_submit_delete.Visible = False
        Button_reset.Visible = False
        Label_Delete_verification.Visible = False
        Txt_name.Text = ""
        Txt_code.Text = ""
        Cmb_credit.Text = ""
        Cmb_faculty.Text = ""
        Cmb_level.Text = ""
        Cmb_semester.Text = ""
        Txt_program.Text = ""
        Txt_courseSearch.Text = ""
    End Sub

    Private Sub PictureBox_search_Click(sender As Object, e As EventArgs) Handles PictureBox_search.Click
        PictureBox_back.Visible = False
        PictureBox_Course_back.Visible = True
        ButtonCOURSEupdate.Visible = False
        Button_courseSEARCH_dgv.Visible = True
        ButtonCOURSEREMOVE.Visible = False
        Label_course_search.Visible = True
        Txt_courseSearch.Visible = True
        Label_code.Visible = False
        Txt_code.Visible = False
        Label_name.Visible = False
        Txt_name.Visible = False
        Label_faculty.Visible = False
        Cmb_faculty.Visible = False
        Label_program.Visible = False
        Txt_program.Visible = False
        Label_level.Visible = False
        Cmb_level.Visible = False
        Label_semester.Visible = False
        Cmb_semester.Visible = False
        Label_credit.Visible = False
        Cmb_credit.Visible = False
        Button_submitADD.Visible = False
        Button_submitUpdate.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Button_reset.Visible = False
        Label_Delete_verification.Visible = False
        Button_submit_delete.Visible = False

    End Sub

    Private Sub Button_courseSEARCH_dgv_Click(sender As Object, e As EventArgs) Handles Button_courseSEARCH_dgv.Click
        Try
            Button_reset.Visible = True
            Dgv_course.Visible = True
            ' Dim username As String = Txt_symbol_search.Text
            Dim query As String = "SELECT * FROM `coursedata` WHERE `coursecode` = @Code "

            'Using con As New MySqlConnection("YourConnectionString")
            Con.Open()

            Dim command As New MySqlCommand(query, Con)
            command.Parameters.AddWithValue("@Code", Txt_courseSearch.Text)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Bind the DataGridView to the DataTable
            Dgv_course.DataSource = table
            Dgv_course.Refresh()
            'End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally

            Con.Close()
        End Try
    End Sub

    Private Sub PictureBox_remove_Click(sender As Object, e As EventArgs) Handles PictureBox_remove.Click
        PictureBox_back.Visible = False
        PictureBox_Course_back.Visible = True
        ButtonCOURSEupdate.Visible = False
        Button_courseSEARCH_dgv.Visible = False
        ButtonCOURSEREMOVE.Visible = True
        Label_course_search.Visible = True
        Txt_courseSearch.Visible = True
        Dgv_course.Visible = False
        Label_code.Visible = False
        Txt_code.Visible = False
        Label_name.Visible = False
        Txt_name.Visible = False
        Cmb_faculty.Visible = False
        Label_faculty.Visible = False
        Label_program.Visible = False
        Txt_program.Visible = False
        Label_level.Visible = False
        Cmb_level.Visible = False
        Cmb_semester.Visible = False
        Label_semester.Visible = False
        Cmb_credit.Visible = False
        Label_credit.Visible = False
        Button_submitADD.Visible = False
        Button_submitUpdate.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Button_reset.Visible = False
        Label_Delete_verification.Visible = False
        Button_submit_delete.Visible = False
    End Sub

    Private Sub PictureBox_update_Click(sender As Object, e As EventArgs) Handles PictureBox_update.Click
        PictureBox_back.Visible = False
        PictureBox_Course_back.Visible = True
        ButtonCOURSEupdate.Visible = True
        Button_courseSEARCH_dgv.Visible = False
        ButtonCOURSEREMOVE.Visible = False
        Label_course_search.Visible = True
        Txt_courseSearch.Visible = True
        Dgv_course.Visible = False
        Label_code.Visible = False
        Txt_code.Visible = False
        Label_name.Visible = False
        Txt_name.Visible = False
        Cmb_faculty.Visible = False
        Label_faculty.Visible = False
        Label_program.Visible = False
        Txt_program.Visible = False
        Label_level.Visible = False
        Cmb_level.Visible = False
        Label_semester.Visible = False
        Cmb_semester.Visible = False
        Cmb_credit.Visible = False
        Label_credit.Visible = False
        Button_submitADD.Visible = False
        Button_submitUpdate.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Button_reset.Visible = False
        Label_Delete_verification.Visible = False
        Button_submit_delete.Visible = False
    End Sub

    Private Sub ButtonCOURSEupdate_Click(sender As Object, e As EventArgs) Handles ButtonCOURSEupdate.Click
        Try
            Con.Open()
            Dim symbol As String = Txt_courseSearch.Text
            Dim query As String = "SELECT * FROM coursedata WHERE CourseCode = @Symbol"

            Dim adapter As New MySqlDataAdapter(New MySqlCommand(query, Con))
            adapter.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim table As New DataTable()
            Dim unused = adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)
                Button_reset.Visible = True
                Label_code.Visible = True
                Txt_code.Visible = True
                Txt_code.ReadOnly = True
                Label_name.Visible = True
                Txt_name.Visible = True
                Cmb_faculty.Visible = True
                Label_faculty.Visible = True
                Label_program.Visible = True
                Txt_program.Visible = True
                Label_level.Visible = True
                Cmb_level.Visible = True
                Label_semester.Visible = True
                Cmb_semester.Visible = True
                Label_credit.Visible = True
                Cmb_credit.Visible = True
                Button_submitUpdate.Visible = True
                Txt_code.Text = row("CourseCode").ToString()
                Txt_name.Text = row("Course").ToString()
                Cmb_faculty.Text = row("Faculty").ToString()
                Txt_program.Text = row("Program").ToString()
                Cmb_level.Text = row("Level").ToString()
                Cmb_semester.Text = row("Semester").ToString()
                Cmb_credit.Text = row("CreditHours").ToString()
            Else
                Txt_name.Text = ""
                Txt_code.Text = ""
                Cmb_credit.Text = ""
                Cmb_faculty.Text = ""
                Cmb_level.Text = ""
                Cmb_semester.Text = ""
                Txt_program.Text = ""
                Txt_courseSearch.Text = ""
                MsgBox("Record not found.")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)

        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Dgv_course.DataSource = Nothing
        Button_submit_delete.Visible = False
        Button_reset.Visible = False
        Label_Delete_verification.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Txt_code.Text = ""
        Txt_courseSearch.Text = ""
        Txt_name.Text = ""
        Txt_program.Text = ""
        Cmb_credit.Text = ""
        Cmb_faculty.Text = ""
        Cmb_semester.Text = ""
        Cmb_level.Text = ""
    End Sub

    Private Sub Button_submit_delete_Click(sender As Object, e As EventArgs) Handles Button_submit_delete.Click
        Button_reset.Visible = True
        Label_Delete_verification.Visible = True
        Button_delete_NO.Visible = True
        Button_delete_YES.Visible = True
    End Sub

    Private Sub Button_submit_Click(sender As Object, e As EventArgs) Handles Button_submitADD.Click
        Try
            Con.Open()
            Dim sql As String = "INSERT INTO `coursedata` (`CourseCode`, `Course`, `Faculty`, `Program`, `Level`, `Semester`, `CreditHours`) VALUES (@Code, @Name, @Faculty, @Program, @Level, @Semester, @Credit)"
            Dim mysc As New MySqlCommand(sql, Con)

            mysc.Parameters.AddWithValue("@Code", Txt_code.Text)
            mysc.Parameters.AddWithValue("@Name", Txt_name.Text)
            mysc.Parameters.AddWithValue("@Faculty", Cmb_faculty.Text)
            mysc.Parameters.AddWithValue("@Program", Txt_program.Text)
            mysc.Parameters.AddWithValue("@Level", Cmb_level.Text)
            mysc.Parameters.AddWithValue("@Semester", Cmb_semester.Text)
            mysc.Parameters.AddWithValue("@Credit", Cmb_credit.Text)
            Dim i As Integer = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                ' Clear the input fields or perform other necessary actions
                Txt_code.Text = ""
                Cmb_credit.Text = ""
                Txt_name.Text = ""
                Txt_program.Text = ""
                Cmb_level.Text = ""
                Cmb_faculty.Text = ""
            Else
                MsgBox("Something went wrong.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message) ' Corrected the error message format
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button_delete_NO_Click(sender As Object, e As EventArgs) Handles Button_delete_NO.Click
        Label_Delete_verification.Visible = False
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
    End Sub

    Private Sub Button_search_course_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonCOURSEREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonCOURSEREMOVE.Click
        Try
            Button_submit_delete.Visible = True
            Button_reset.Visible = True
            Dgv_course.Visible = True
            ' Dim username As String = Txt_symbol_search.Text
            Dim query As String = "SELECT * FROM `coursedata` WHERE `coursecode` = @Code "

            'Using con As New MySqlConnection("YourConnectionString")
            Con.Open()

            Dim command As New MySqlCommand(query, Con)
            command.Parameters.AddWithValue("@Code", Txt_courseSearch.Text)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Bind the DataGridView to the DataTable
            Dgv_course.DataSource = table
            Dgv_course.Refresh()
            'End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button_submitUpdate_Click(sender As Object, e As EventArgs) Handles Button_submitUpdate.Click
        PictureBox_back.Visible = False
        PictureBox_Course_back.Visible = True
        Label_course_search.Visible = True
        Dgv_course.Visible = False
        Button_delete_YES.Visible = False
        Button_delete_NO.Visible = False
        Txt_courseSearch.Visible = True
        ButtonCOURSEupdate.Visible = True
        Button_courseSEARCH_dgv.Visible = False
        ButtonCOURSEREMOVE.Visible = False
        Label_code.Visible = False
        Txt_code.Visible = False
        Label_name.Visible = False
        Txt_name.Visible = False
        Label_faculty.Visible = False
        Cmb_faculty.Visible = False
        Label_program.Visible = False
        Txt_program.Visible = False
        Label_level.Visible = False
        Cmb_level.Visible = False
        Label_semester.Visible = False
        Cmb_semester.Visible = False
        Label_credit.Visible = False
        Cmb_credit.Visible = False
        Button_submitADD.Visible = False
        Txt_code.ReadOnly = True
        Dim sql As String
        Dim i As Integer
        Try
            Con.Open()
            sql = "UPDATE `COURSEDATA` SET `Course`=@Name, `Faculty`= @Faculty, `Program`= @Program, `Level` = @Level, `Semester`=@Semester, `CreditHours`=@Credit, WHERE `CourseCode` = @CCREDIT"

            Dim mysc As New MySqlCommand(sql, Con)
            mysc.Parameters.AddWithValue("@Name", Txt_name.Text)
            mysc.Parameters.AddWithValue("@Faculty", Cmb_faculty.Text)
            mysc.Parameters.AddWithValue("@Program", Txt_program.Text)
            mysc.Parameters.AddWithValue("@Level", Cmb_level.Text)
            mysc.Parameters.AddWithValue("@Semester", Cmb_semester.Text)
            mysc.Parameters.AddWithValue("@Credit", Cmb_credit.Text)
            mysc.Parameters.AddWithValue("@CCREDIT", Txt_courseSearch.Text)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Student details updated successfully!")
                Txt_code.Text = ""
                Txt_name.Text = ""
                Txt_program.Text = ""
                Cmb_credit.Text = ""
                Cmb_faculty.Text = ""
                Txt_courseSearch.Text = ""
                Cmb_level.Text = ""
                Cmb_semester.Text = ""
            ElseIf i = 0 Then
                MsgBox("No matching student found with the specified symbol.")
            Else
                MsgBox("Something went wrong.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button_delete_YES_Click(sender As Object, e As EventArgs) Handles Button_delete_YES.Click

        Dim i As Integer
        Try
            Con.Open()
            ' Step 1: Delete fee records for the student
            Dim sql As String = "DELETE FROM `coursedata` WHERE `coursecode` = @Symbol"
            Dim mysc As New MySqlCommand(sql, Con)
            mysc.Parameters.AddWithValue("@Symbol", Txt_courseSearch.Text)
            i = mysc.ExecuteNonQuery()
            Dim sql1 As String = "SELECT * FROM `coursedata` WHERE `coursecode` = @Symbol"
            Dim reader As MySqlDataReader
            Dim mysc3 As New MySqlCommand(sql1, Con)
            reader = mysc3.ExecuteReader()

            If reader.Read() Then
                MsgBox("Something went wrong. Please try again.")
            Else
                MsgBox("Course details deleted successfully.")
                Dgv_course.Visible = False
                Button_reset.Visible = False
                Button_submit_delete.Visible = False
                Label_Delete_verification.Visible = False
                Button_delete_NO.Visible = False
                Button_delete_YES.Visible = False
            End If

            reader.Close()
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dgv_course.DataSource = Nothing
            Con.Close()
        End Try
    End Sub
End Class