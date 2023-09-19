Public Class Admin_Studentmngmnt
    Public Property USERNAME_ As String
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Button_Studentmngmnt_Click(sender As Object, e As EventArgs) Handles Button_Studentmngmnt.Click
        Me.Show()
    End Sub

    Private Sub Button_coursemngmnt_Click(sender As Object, e As EventArgs) Handles Button_coursemngmnt.Click
        Me.Hide()
        Dim obj As New Admin_Coursemngmnt With {
            .U_sername = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Button_feemngmnt_Click(sender As Object, e As EventArgs) Handles Button_feemngmnt.Click
        Me.Hide()
        Dim obj As New Admin_feemngmnt With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_addnewStudent_Click(sender As Object, e As EventArgs) Handles Pic_addnewStudent.Click
        Me.Hide()
        Dim obj As New Admin_addStudent With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_searchStudent_Click(sender As Object, e As EventArgs) Handles Pic_searchStudent.Click
        Me.Hide()
        Dim obj As New Admin_searchStudent With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_updateStudent_Click(sender As Object, e As EventArgs) Handles Pic_updateStudent.Click
        Me.Hide()
        Dim obj As New Admin_updateStudent With {
            .User__name = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_removeStudent_Click(sender As Object, e As EventArgs) Handles Pic_removeStudent.Click
        Me.Hide()
        Dim obj As New Admin_removeStudent With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_back_Click(sender As Object, e As EventArgs) Handles Pic_back.Click
        Me.Hide()
        Dim obj As New Admin_home With {
            .Username = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Admin_Studentmngmnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class