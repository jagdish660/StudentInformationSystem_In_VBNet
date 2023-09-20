Imports MySqlConnector
Public Class Admin_updateStudent
    Public Property User__name As String
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SwitchPanel(Logout_confirmatiom)
    End Sub

    Private Sub SwitchPanel(ByVal Form As Form)
        Panel_logout_admin.Controls.Clear()
        Form.TopLevel = False
        Panel_logout_admin.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = User__name
        }
        obj.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = User__name
        }
        obj.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label_registration.Click

    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click

        Try
            Con.Open()
            Dim symbol As String = Txt_symbol_search.Text
            Dim query As String = "SELECT s.*, f.total_fee, f.discount FROM student s LEFT JOIN fee f ON s.S_no = f.S_no WHERE s.S_no = @Symbol"

            Dim adapter As New MySqlDataAdapter(New MySqlCommand(query, Con))
            adapter.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim table As New DataTable()
            Dim unused = adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)
                Label_symbol_.Visible = True
                Txt_symbol.Visible = True
                Label_name.Visible = True
                Txt_name.Visible = True
                Label_address.Visible = True
                Txt_address.Visible = True
                Label_discount.Visible = True
                Txt_discount.Visible = True
                Label_DOB.Visible = True
                Dtp_DOB.Visible = True
                Label_faculty.Visible = True
                Label_fee.Visible = True
                Txt_fee.Visible = True
                Label_mobile.Visible = True
                Txt_mobile.Visible = True
                Label_phone.Visible = True
                Txt_email.Visible = True
                Label_registration.Visible = True
                Txt_registration.Visible = True
                Label_username.Visible = True
                Txt_username.Visible = True
                Cmb_Faculty.Visible = True
                Label_password.Visible = True
                Txt_pwdd.Visible = True
                Label_lev.Visible = True
                Cmb_level.Visible = True

                Label_program.Visible = True
                Cmb_program.Visible = True
                Label_semester.Visible = True
                Cmb_semester.Visible = True
                Button_submit.Visible = True
                Txt_name.Text = row("name").ToString()
                Txt_fee.Text = row("total_fee").ToString()
                Txt_discount.Text = row("discount").ToString()
                Txt_symbol.Text = row("S_no").ToString()
                Txt_registration.Text = row("registration").ToString()
                Txt_pwdd.Text = row("Password").ToString()
                Txt_username.Text = row("username").ToString()
                Txt_address.Text = row("address").ToString()
                Dtp_DOB.Text = row("Date of Birth").ToString()
                Txt_mobile.Text = row("mobile").ToString()
                Txt_email.Text = row("email address").ToString()
                Cmb_Faculty.Text = row("faculty").ToString()
                Cmb_level.Text = row("level").ToString()
                Cmb_program.Text = row("program").ToString()
                Cmb_semester.Text = row("semester").ToString()
            Else
                ' Clear the fields if no matching record is found
                Txt_name.Text = ""
                Txt_fee.Text = ""
                Txt_discount.Text = ""
                Txt_registration.Text = ""
                Txt_username.Text = ""
                Txt_address.Text = ""
                Dtp_DOB.Text = ""
                Txt_pwdd.Text = ""
                Txt_mobile.Text = ""
                Txt_email.Text = ""
                Cmb_Faculty.Text = ""
                Cmb_level.Text = ""
                Cmb_program.Text = ""
                Cmb_semester.Text = ""

                Txt_symbol.Text = ""
                MsgBox("Record not found.")
            End If
        Catch ex As Exception
            ' Handle the exception (e.g., log it)
            MsgBox("An error occurred: " & ex.Message)
            MsgBox("An error occurred: " & ex.ToString())

        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button_submit_Click(sender As Object, e As EventArgs) Handles Button_submit.Click
        Dim sql, sql1 As String
        Try
            Con.Open()
            Sql = "UPDATE `student` SET `Password` = @Password, `Name` = @Name, `Address` = @Address, `Date of Birth` = @DOB, `email address` = @email_address, `Mobile` = @Mobile, `Faculty` = @Faculty, `Level` = @Level, `Program` = @Program, `Semester` = @Semester, `Fee` = @Fee, `Discount` = @Discount WHERE `s_no` = @Symbol"
            sql1 = "UPDATE `fee` SET `Total_fee` = @Fee1, `Discount` = @Discount1, `Totalfeetobepay` = (@Fee1 - @Discount1), `Fee_due` = (@Fee1 - @Discount1 - @Totalpaid) WHERE `s_no` = @Symbol1"

            Dim mysc As New MySqlCommand(Sql, Con)
            Dim mysc1 As New MySqlCommand(sql1, Con)

            ' Add parameters to the queries
            mysc.Parameters.AddWithValue("@Symbol", Txt_symbol_search.Text)
            mysc.Parameters.AddWithValue("@Password", Txt_pwdd.Text)
            mysc.Parameters.AddWithValue("@Name", Txt_name.Text)
            mysc.Parameters.AddWithValue("@Address", Txt_address.Text)
            mysc.Parameters.AddWithValue("@email_address", Txt_email.Text)
            mysc.Parameters.AddWithValue("@Mobile", Txt_mobile.Text)
            mysc.Parameters.AddWithValue("@Faculty", Cmb_Faculty.Text)
            mysc.Parameters.AddWithValue("@Level", Cmb_level.Text)
            mysc.Parameters.AddWithValue("@Program", Cmb_program.Text)
            mysc.Parameters.AddWithValue("@Semester", Cmb_semester.Text)
            mysc.Parameters.AddWithValue("@Fee", Txt_fee.Text)
            mysc.Parameters.AddWithValue("@Discount", Txt_discount.Text)

            mysc1.Parameters.AddWithValue("@Fee1", Txt_fee.Text)
            mysc1.Parameters.AddWithValue("@Discount1", Txt_discount.Text)
            mysc1.Parameters.AddWithValue("@Symbol1", Txt_symbol_search.Text)
            mysc1.Parameters.AddWithValue("@Totalpaid", "")

            ' Convert Txt_DOB.Text to DateTime
            Dim dob As DateTime
            If DateTime.TryParse(Dtp_DOB.Text, dob) Then
                mysc.Parameters.AddWithValue("@DOB", dob)
            Else
                ' Handle invalid date input
                MsgBox("Invalid Date of Birth format. Please use a valid date format.")
                Con.Close()
                Return
            End If

            Dim j As Integer = mysc1.ExecuteNonQuery()
            Dim i As Integer = mysc.ExecuteNonQuery()

            If i > 0 And j > 0 Then
                MsgBox("Student details updated successfully!")
                ' Clear the form fields or perform other necessary actions
                ' ...
            ElseIf i = 0 And j = 0 Then
                MsgBox("No matching student found with the specified symbol.")
            Else
                MsgBox("Something went wrong.")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Admin_updateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class