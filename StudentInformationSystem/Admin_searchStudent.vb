'Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Admin_searchStudent
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Admin_Studentmngmnt.Show()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_search_result.CellContentClick
        Try
            '    Dim con As MySqlConnection
            Dim connectionString As String = "DataSource "
            Dim command As New MySqlCommand("SELECT `s_no`,`registration`,`name`,`address`,`date of birth`,`phone`,`mobile`,`faculty`,`level`,`program`,`semester` FROM `student` ", Con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            'Dgv_search_result.DataSource.table
            Dgv_search_result.DataMember = "student"
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Try
            '   Dim con As MySqlConnection
            Dim command As New MySqlCommand("SELECT `s_no`,`registration`,`name`,`address`,`date of birth`,`phone`,`mobile`,`faculty`,`level`,`program`,`semester` FROM `student` WHERE `username` = '" & Txt_symbol_search.Text & "'", Con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            'Dgv_search_result.DataSource.table
            Dgv_search_result.DataMember = "student"
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Admin_changePassword.Show()
    End Sub
End Class