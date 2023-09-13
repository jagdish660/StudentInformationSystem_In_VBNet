Public Class Student_home
    Private ReadOnly user_name As String

    Public Sub New()
    End Sub

    Public Sub New(user_name As String)
        Me.user_name = user_name
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_student.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_student.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Student_change_password.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim form2 As New Student_info(user_name)
        Me.Hide()
        form2.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Student_courses.Show()
    End Sub
End Class