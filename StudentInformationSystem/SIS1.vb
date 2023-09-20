Public Class SIS1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Strtprgrm.Click
        Dim STUDENTINFO As String = 1
        Dim form2 As New Student_login(STUDENTINFO)
        If List1.SelectedItem IsNot Nothing AndAlso List1.SelectedItem.ToString() = "Admin" Then
            SwitchPanel(Admin_login)
        Else

            SwitchPanel(form2)
        End If
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_login.Controls.Clear()
        Form.TopLevel = False
        Panel_login.Controls.Add(Form)
        Form.Show()
    End Sub
End Class
