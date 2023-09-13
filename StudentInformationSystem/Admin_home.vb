Public Class Admin_home
    Private Sub Pic_logout_Click(sender As Object, e As EventArgs) Handles Pic_logout.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub Pic_set_ting_Click(sender As Object, e As EventArgs) Handles Pic_set_ting.Click
        Hide()
        Admin_changePassword.Show()
    End Sub

    Private Sub Pic_student_Click(sender As Object, e As EventArgs) Handles Pic_student.Click
        Me.Hide()
        Admin_Studentmngmnt.Show()
    End Sub

    Private Sub Pic_course_Click(sender As Object, e As EventArgs) Handles Pic_course.Click
        Me.Hide()
        Admin_Coursemngmnt.Show()
    End Sub

    Private Sub Pic_fee_Click(sender As Object, e As EventArgs) Handles Pic_fee.Click
        Me.Hide()
        Admin_feemngmnt.Show()
    End Sub
End Class