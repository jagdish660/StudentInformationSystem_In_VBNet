Imports MySqlConnector
Public Class Admin_removeStudent
    Public Property USERNAME_ As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

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
        Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Button_deleteStudent_Click(sender As Object, e As EventArgs) Handles Button_deleteStudent.Click
        Label_Delete_verification.Visible = True
        Button_delete_YES.Visible = True
        Button_delete_NO.Visible = -True
    End Sub

    Private Sub Button_delete_YES_Click(sender As Object, e As EventArgs) Handles Button_delete_YES.Click
        Dim i, j As Integer
        Try
            Con.Open()
            ' Step 1: Delete fee records for the student
            Dim sql2 As String = "DELETE FROM `fee` WHERE `S_no` = @Symbol"
            Dim mysc1 As New MySqlCommand(sql2, Con)
            mysc1.Parameters.AddWithValue("@Symbol", Txt_student_Search.Text)
            j = mysc1.ExecuteNonQuery()
            Dim sql As String = "DELETE FROM `student` WHERE `S_no` = @Symbol"
            Dim mysc As New MySqlCommand(sql, Con)
            mysc.Parameters.AddWithValue("@Symbol", Txt_student_Search.Text)
            i = mysc.ExecuteNonQuery()
            Dim sql1 As String = "SELECT * FROM `student` WHERE `S_NO` = @Symbol"
            Dim reader As MySqlDataReader
            Dim mysc3 As New MySqlCommand(sql1, Con)
            mysc3.Parameters.AddWithValue("@Symbol", Txt_student_Search.Text)
            reader = mysc3.ExecuteReader()

            If reader.Read() Then
                MsgBox("Something went wrong. Please try again.")
            Else
                MsgBox("Student detail deleted successfully.")
                Txt_student_Search.Text = ""
                DGV_student.Visible = False
                Button_deleteStudent.Visible = False
                Button_delete_NO.Visible = False
                Button_delete_YES.Visible = False
                Button_reset.Visible = False
                Label_Delete_verification.Visible = False
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DGV_student.DataSource = Nothing
            Con.Close()
        End Try

    End Sub

    Private Sub Button_searchAdmin_Click(sender As Object, e As EventArgs) Handles Button_searchAdmin.Click
        Try
            ' Dim sql As String
            Dim i As Integer
            Dim username As String = Txt_student_Search.Text
            Dim query As String = "SELECT * FROM `student` WHERE `S_no` = @Username"
            Con.Open()

            ' Create MySqlCommand object with the SQL query
            Dim command As New MySqlCommand(query, Con)

            ' Assign a value to the @Username parameter
            command.Parameters.AddWithValue("@Username", username)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the DataGridView to the DataTable
            DGV_student.DataSource = table

            i = CInt(command.ExecuteScalar())

            If i > 0 Then
                DGV_student.Visible = True
                Button_deleteStudent.Visible = True
                Button_reset.Visible = True
            Else
                ' Record not found
                Txt_student_Search.Text = ""
                MsgBox("Record not found.")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button_delete_NO_Click(sender As Object, e As EventArgs) Handles Button_delete_NO.Click
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Label_Delete_verification.Visible = False
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        DGV_student.DataSource = Nothing
        Button_delete_NO.Visible = False
        Button_delete_YES.Visible = False
        Label_Delete_verification.Visible = False
    End Sub

    Private Sub Admin_removeStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class