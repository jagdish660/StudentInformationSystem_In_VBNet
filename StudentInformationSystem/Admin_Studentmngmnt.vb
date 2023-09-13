Public Class Admin_Studentmngmnt
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
        MsgBox("Not designed yet.")
    End Sub

    Private Sub Button_Studentmngmnt_Click(sender As Object, e As EventArgs) Handles Button_Studentmngmnt.Click
        Me.Show()
    End Sub

    Private Sub Button_coursemngmnt_Click(sender As Object, e As EventArgs) Handles Button_coursemngmnt.Click
        Me.Hide()
        Admin_Coursemngmnt.Show()
    End Sub

    Private Sub Button_feemngmnt_Click(sender As Object, e As EventArgs) Handles Button_feemngmnt.Click
        Me.Hide()
        Admin_feemngmnt.Show()
    End Sub

    Private Sub Pic_addnewStudent_Click(sender As Object, e As EventArgs) Handles Pic_addnewStudent.Click
        Me.Hide()
        Admin_addStudent.Show()
    End Sub

    Private Sub Pic_searchStudent_Click(sender As Object, e As EventArgs) Handles Pic_searchStudent.Click
        Me.Hide()
        Admin_searchStudent.Show()
    End Sub

    Private Sub Pic_updateStudent_Click(sender As Object, e As EventArgs) Handles Pic_updateStudent.Click
        Me.Hide()
        Admin_updateStudent.Show()
    End Sub

    Private Sub Pic_removeStudent_Click(sender As Object, e As EventArgs) Handles Pic_removeStudent.Click
        Me.Hide()
        Admin_removeStudent.Show()
    End Sub

    Private Sub Pic_back_Click(sender As Object, e As EventArgs) Handles Pic_back.Click
        Me.Hide()
        Admin_home.Show()
    End Sub
End Class