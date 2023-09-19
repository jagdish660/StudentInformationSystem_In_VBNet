Imports MySqlConnector
Public Class Admin_searchStudent
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Try
            Dgv_search_result.Visible = True
            ' Dim username As String = Txt_symbol_search.Text
            Dim query As String = "SELECT `s_no`,`registration`,`name`,`address`,`date of birth`,`phone`,`mobile`,`faculty`,`level`,`program`,`semester` FROM `student` WHERE `s_no` = @Username OR `username` = @Username"

            'Using con As New MySqlConnection("YourConnectionString")
            Con.Open()

            Dim command As New MySqlCommand(query, Con)
            command.Parameters.AddWithValue("@Username", Txt_symbol_search.Text)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Bind the DataGridView to the DataTable
            Dgv_search_result.DataSource = table
            Dgv_search_result.Refresh()
            'End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Admin_searchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class