Public Class Available_courses
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Student_courses.Show()
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
End Class