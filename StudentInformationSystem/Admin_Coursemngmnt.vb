Public Class Admin_Coursemngmnt
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Switchpanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Admin_changePassword.Show()
    End Sub

    Private Sub Button_Studentmngmnt_Click(sender As Object, e As EventArgs) Handles Button_Studentmngmnt.Click
        Me.Hide()
        Admin_Studentmngmnt.Show()
    End Sub

    Private Sub Button_coursemngmnt_Click(sender As Object, e As EventArgs) Handles Button_coursemngmnt.Click
        Me.Show()
    End Sub

    Private Sub Button_feemngmnt_Click(sender As Object, e As EventArgs) Handles Button_feemngmnt.Click
        Me.Hide()
        Admin_feemngmnt.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Admin_home.Show()
    End Sub
End Class