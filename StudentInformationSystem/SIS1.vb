Public Class SIS1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Strtprgrm.Click
        If List1.SelectedItem IsNot Nothing AndAlso List1.SelectedItem.ToString() = "Admin" Then
            SwitchPanel(admin_login)
        Else
            SwitchPanel(Student_login)
        End If
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_login.Controls.Clear()
        Form.TopLevel = False
        Panel_login.Controls.Add(Form)
        Form.Show()
    End Sub
End Class
