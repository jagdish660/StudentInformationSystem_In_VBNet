Public Class Logout_confirmatiom
    Private Sub Btn_logout_Click(sender As Object, e As EventArgs) Handles Btn_logout.Click
        Dim user_name As String = 1
        Dim form2 As New Student_info(user_name)
        Me.Hide()
        Admin_home.Hide()
        Student_home.Hide()
        Student_courses.Hide()
        form2.Hide()
        Admin_Coursemngmnt.Hide()
        Admin_Studentmngmnt.Hide()
        Admin_feemngmnt.Hide()
        Admin_changePassword.Hide()
        Admin_addStudent.Hide()
        Admin_removeStudent.Hide()
        Admin_searchStudent.Hide()
        Admin_updateStudent.Hide()
        SIS1.Show()
    End Sub

    Private Sub Btn_stay_Click(sender As Object, e As EventArgs) Handles Btn_stay.Click
        Me.Hide()

    End Sub
End Class