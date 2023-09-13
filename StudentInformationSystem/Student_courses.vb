Public Class Student_courses
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Student_home.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Student_course_view.show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Student_course_view.show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Available_courses.show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Available_courses.show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_student.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_student.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MsgBox("Not Designed yet.")
    End Sub
End Class