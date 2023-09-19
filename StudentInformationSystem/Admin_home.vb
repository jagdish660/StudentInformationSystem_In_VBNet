Public Class Admin_home
    Public Property Username As String
    Private Sub Pic_logout_Click(sender As Object, e As EventArgs) Handles Pic_logout.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub Pic_set_ting_Click(sender As Object, e As EventArgs) Handles Pic_set_ting.Click
        Me.Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = Username
        }
        obj.Show()
    End Sub

    Private Sub Pic_student_Click(sender As Object, e As EventArgs) Handles Pic_student.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = Username
        }
        obj.Show()
    End Sub

    Private Sub Pic_course_Click(sender As Object, e As EventArgs) Handles Pic_course.Click
        Me.Hide()
        Dim obj As New Admin_Coursemngmnt With {
            .U_sername = Username
        }
        obj.Show()
    End Sub

    Private Sub Pic_fee_Click(sender As Object, e As EventArgs) Handles Pic_fee.Click
        Me.Hide()
        Dim obj As New Admin_feemngmnt With {
            .USERNAME_ = Username
        }
        obj.Show()
    End Sub

    Private Sub Panel_logout_admin_Paint(sender As Object, e As PaintEventArgs) Handles Panel_logout_admin.Paint

    End Sub

    Private Sub Admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class