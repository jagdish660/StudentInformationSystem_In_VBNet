Imports MySqlConnector
Public Class Admin_addStudent
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
        Me.Hide()
        Dim obj As New Admin_changePassword With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Admin_addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        TXT_Symbol.Text = ""
        TXT_Registrstion.Text = ""
        TXT_Name.Text = ""
        TXT_Address.Text = ""
        Dtp_DOB.Text = ""
        TXT_username.Text = ""
        TXT_password.Text = ""
        TXT_mobile.Text = ""
        TXT_phone.Text = ""
        ComboBox_faculty.Text = ""
        ComboBox_level.Text = ""
        ComboBox_program.Text = ""
        ComboBox_semester.Text = ""
        TXT_fee.Text = ""
        Txt_discount.Text = ""
    End Sub

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles Button_Submit.Click
        Try
            If TXT_username.TextLength > 5 And TXT_password.TextLength > 5 Then
                If TXT_mobile.TextLength = 10 AndAlso IsNumeric(TXT_mobile.Text) Then
                    Dim dob As DateTime
                    If DateTime.TryParse(Dtp_DOB.Text, dob) Then
                        'Using Con As New MySqlConnection("YourConnectionString")
                        Con.Open()
                        Dim sql As String = "INSERT INTO `student` (`S_no`, `Registration`, `username`, `password`, `Name`, `Address`, `Date of Birth`, `Email Address`, `Mobile`, `Faculty`, `Level`, `Program`, `Semester`, `Fee`, `Discount`, `created by`) VALUES (@Symbol, @Registration, @Username, @Password, @Name, @Address, @DOB, @Phone, @Mobile, @Faculty, @Level, @Program, @Semester, @Fee, @Discount, @creator)"
                        Dim sql1 As String = "INSERT INTO `fee` (`S_no`, `Total_fee`, `Discount`, `TotalFeeTOBePay`, `TotalPaid`, `Installments`, `Fee_due`) VALUES (@Symbol, @TotalFee, @Discount, (@TotalFee - @Discount), @TotalPaid, @Installments, (@TotalFee - @Discount))"

                        Dim mysc As New MySqlCommand(sql, Con)
                        Dim mysc1 As New MySqlCommand(sql1, Con)

                        ' Set parameters
                        mysc.Parameters.AddWithValue("@Symbol", TXT_Symbol.Text)
                        mysc.Parameters.AddWithValue("@creator", USERNAME_)
                        mysc.Parameters.AddWithValue("@Registration", TXT_Registrstion.Text)
                        mysc.Parameters.AddWithValue("@Username", TXT_username.Text)
                        mysc.Parameters.AddWithValue("@Password", TXT_password.Text)
                        mysc.Parameters.AddWithValue("@Name", TXT_Name.Text)
                        mysc.Parameters.AddWithValue("@Address", TXT_Address.Text)
                        mysc.Parameters.AddWithValue("@DOB", dob)
                        mysc.Parameters.AddWithValue("@Phone", TXT_phone.Text)
                        mysc.Parameters.AddWithValue("@Mobile", TXT_mobile.Text)
                        mysc.Parameters.AddWithValue("@Faculty", ComboBox_faculty.Text)
                        mysc.Parameters.AddWithValue("@Level", ComboBox_level.Text)
                        mysc.Parameters.AddWithValue("@Program", ComboBox_program.Text)
                        mysc.Parameters.AddWithValue("@Semester", ComboBox_semester.Text)
                        mysc.Parameters.AddWithValue("@Fee", TXT_fee.Text)
                        mysc.Parameters.AddWithValue("@Discount", Txt_discount.Text)

                        mysc1.Parameters.AddWithValue("@Symbol", TXT_Symbol.Text)
                        mysc1.Parameters.AddWithValue("@TotalFee", TXT_fee.Text)
                        mysc1.Parameters.AddWithValue("@Discount", Txt_discount.Text)
                        mysc1.Parameters.AddWithValue("@TotalFeeToBePay", "")
                        mysc1.Parameters.AddWithValue("@TotalPaid", "")
                        mysc1.Parameters.AddWithValue("@Installments", "")
                        mysc1.Parameters.AddWithValue("@FeeDue", " ")

                        ' Execute queries
                        Dim i As Integer = mysc.ExecuteNonQuery()
                        Dim j As Integer = mysc1.ExecuteNonQuery()

                        If i > 0 And j > 0 Then
                            MsgBox("New record has been inserted successfully!")
                            ' Clear the input fields or perform other necessary actions
                            ' ...
                        Else
                            MsgBox("Something went wrong.")
                        End If
                    Else
                        MsgBox("Invalid Date of Birth format. Please use a valid date format.")
                    End If
                Else
                    MsgBox("Invalid mobile number provided.")
                End If
            Else
                MsgBox("Size of username or password doesn't meet the criteria.")
            End If
        Catch ex As Exception
            ' Log the exception for debugging
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub
End Class