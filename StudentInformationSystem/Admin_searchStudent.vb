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
End Class