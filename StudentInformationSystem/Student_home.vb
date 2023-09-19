Public Class Student_home1
    Public Property User_name As String
    Public username__ As String = User_name
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
        Dim obj As New Student_change_password
        Me.Hide()
        obj.User_name_ = User_name
        obj.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox_myInfo.Click
        Dim obj1 As New Student_info
        Me.Hide()
        obj1.User_name = User_name
        obj1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox_course.Click
        Dim obj As New Student_courses
        Me.Hide()
        obj.user__name = User_name
        obj.Show()
    End Sub

    Private Sub Student_home1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class