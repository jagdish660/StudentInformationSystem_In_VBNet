Imports MySqlConnector
Public Class Admin_feemngmnt
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

    Private Sub Button_feemngmnt_Click(sender As Object, e As EventArgs) Handles Button_feemngmnt.Click
        Me.Show()
    End Sub

    Private Sub Button_coursemngmnt_Click(sender As Object, e As EventArgs) Handles Button_coursemngmnt.Click
        Me.Hide()
        Dim obj As New Admin_Coursemngmnt With {
            .U_sername = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Button_Studentmngmnt_Click(sender As Object, e As EventArgs) Handles Button_Studentmngmnt.Click
        Me.Hide()
        Dim obj As New Admin_Studentmngmnt With {
            .USERNAME_ = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_back.Click
        Me.Hide()
        Dim obj As New Admin_home With {
            .Username = USERNAME_
        }
        obj.Show()
    End Sub

    Private Sub Pic_searchfee_Click(sender As Object, e As EventArgs) Handles Pic_searchfee.Click
        Button_update_search.Visible = False
        Label_symbol.Visible = True
        Txt_this_payment.Text = ""
        Txt_this_payment.Visible = False
        Txt_symbol.Visible = True
        Txt_symbol.Text = ""
        Button_search_symbol.Visible = True
        Button_submit.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox_update.Click
        Button_search_symbol.Visible = False
        Label_symbol.Visible = True
        Txt_symbol.Visible = True
        Txt_symbol.Text = ""
        Button_update_search.Visible = True
    End Sub

    Private Sub Button_search_symbol_Click(sender As Object, e As EventArgs) Handles Button_search_symbol.Click
        Try
            Con.Open()

            ' Use parameterized queries
            Dim symbol As String = Txt_symbol.Text
            Dim selectFeeQuery As String = "SELECT * FROM `fee` WHERE `S_no` = @Symbol"
            Dim selectStudentQuery As String = "SELECT name FROM `student` WHERE `S_no` = @Symbol"

            Dim adapterFee As New MySqlDataAdapter(New MySqlCommand(selectFeeQuery, Con))
            adapterFee.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim tableFee As New DataTable()
            Dim unused1 = adapterFee.Fill(tableFee)

            Dim adapterStudent As New MySqlDataAdapter(New MySqlCommand(selectStudentQuery, Con))
            adapterStudent.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim tableStudent As New DataTable()
            Dim unused2 = adapterStudent.Fill(tableStudent)

            If tableFee.Rows.Count = 0 Then
                Txt_symbol.Text = ""
                MsgBox("Record not found.")
            Else
                Label_name.Visible = True
                Txt_name.Visible = True
                Label_discount.Visible = True
                Txt_discount.Visible = True
                Label_due.Visible = True
                Txt_fee_due.Visible = True
                Label_installment.Visible = True
                Txt_installments.Visible = True
                Label_paid.Visible = True
                Txt_total_paid.Visible = True
                '    Label_this.Visible = True
                '    Txt_this_payment.Visible = True
                Label_TotalFEE.Visible = True
                Txt_total_fee.Visible = True
                Label_tobepaid.Visible = True
                Txt_toBePaid.Visible = True
                PictureBox_back.Visible = False

                Dim name As String = tableStudent.Rows(0)("name").ToString()
                Dim totalFEE As String = tableFee.Rows(0)("total_fee").ToString()
                Dim discount As String = tableFee.Rows(0)("discount").ToString()
                Dim ToBePaid As String = tableFee.Rows(0)("totalfeetobepay").ToString()
                Dim TotalPaid As String = tableFee.Rows(0)("totalpaid").ToString()
                Dim FeeDue As String = tableFee.Rows(0)("fee_due").ToString()
                Dim installments As String = tableFee.Rows(0)("installments").ToString()

                Txt_name.Text = name
                Txt_total_fee.Text = totalFEE
                Txt_discount.Text = discount
                Txt_toBePaid.Text = ToBePaid
                Txt_total_paid.Text = TotalPaid
                Txt_fee_due.Text = FeeDue
                Txt_installments.Text = installments
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_submit.Click
        Dim sql As String
        Dim i As Integer

        Try
            If Txt_this_payment.Text < 0 Then
                MsgBox("Invalid amount entered. ")
                Txt_this_payment.Text = ""

            Else

                Con.Open()
                sql = "UPDATE `fee` SET `S_no`=@Symbol, `Total_fee`=@TotalFee, `Discount`=@Discount, `TotalFeeTOBePay`=@TotalFeeToBePaid, `TotalPaid`=(TotalPaid + @ThisPayment), `Installments`=(Installments + 1), `Fee_due`=(Fee_due - @ThisPayment) WHERE `s_no` = @Symbol"
                Dim mysc As New MySqlCommand(sql, Con)

                ' Add parameters to the query
                mysc.Parameters.AddWithValue("@TotalFee", Txt_total_fee.Text)
                mysc.Parameters.AddWithValue("@Discount", Txt_discount.Text)
                mysc.Parameters.AddWithValue("@TotalFeeToBePaid", Txt_toBePaid.Text)
                mysc.Parameters.AddWithValue("@ThisPayment", Txt_this_payment.Text)
                mysc.Parameters.AddWithValue("@Installments", Txt_installments.Text)
                mysc.Parameters.AddWithValue("@FeeDue", Txt_fee_due.Text)
                mysc.Parameters.AddWithValue("@Symbol", Txt_symbol.Text)

                i = mysc.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Fee updated successfully!")
                    Txt_this_payment.Text = ""

                Else
                    MsgBox("Something went wrong. ")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button_update_search_Click(sender As Object, e As EventArgs) Handles Button_update_search.Click
        Try
            Con.Open()
            PictureBox_backbuttons.Visible = True
            ' Use parameterized queries
            Dim symbol As String = Txt_symbol.Text
            Dim selectFeeQuery As String = "SELECT * FROM `fee` WHERE `S_no` = @Symbol"
            Dim selectStudentQuery As String = "SELECT name FROM `student` WHERE `S_no` = @Symbol"

            Dim adapterFee As New MySqlDataAdapter(New MySqlCommand(selectFeeQuery, Con))
            adapterFee.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim tableFee As New DataTable()
            Dim unused1 = adapterFee.Fill(tableFee)

            Dim adapterStudent As New MySqlDataAdapter(New MySqlCommand(selectStudentQuery, Con))
            adapterStudent.SelectCommand.Parameters.AddWithValue("@Symbol", symbol)

            Dim tableStudent As New DataTable()
            Dim unused2 = adapterStudent.Fill(tableStudent)

            If tableFee.Rows.Count = 0 Then
                Txt_symbol.Text = ""
                MsgBox("Record not found.")
            Else
                Label_name.Visible = True
                Txt_name.Visible = True
                Label_discount.Visible = True
                Txt_discount.Visible = True
                Label_due.Visible = True
                Txt_fee_due.Visible = True
                Label_installment.Visible = True
                Txt_installments.Visible = True
                Label_paid.Visible = True
                Txt_total_paid.Visible = True
                Label_this.Visible = True
                Txt_this_payment.Visible = True
                Label_TotalFEE.Visible = True
                Txt_total_fee.Visible = True
                Label_tobepaid.Visible = True
                Txt_toBePaid.Visible = True
                Button_submit.Visible = True
                PictureBox_back.Visible = False

                Dim name As String = tableStudent.Rows(0)("name").ToString()
                Dim totalFEE As String = tableFee.Rows(0)("total_fee").ToString()
                Dim discount As String = tableFee.Rows(0)("discount").ToString()
                Dim ToBePaid As String = tableFee.Rows(0)("totalfeetobepay").ToString()
                Dim TotalPaid As String = tableFee.Rows(0)("totalpaid").ToString()
                Dim FeeDue As String = tableFee.Rows(0)("fee_due").ToString()
                Dim installments As String = tableFee.Rows(0)("installments").ToString()

                Txt_name.Text = name
                Txt_total_fee.Text = totalFEE
                Txt_discount.Text = discount
                Txt_toBePaid.Text = ToBePaid
                Txt_total_paid.Text = TotalPaid
                Txt_fee_due.Text = FeeDue
                Txt_installments.Text = installments
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox_backbuttons.Click
        Txt_symbol.Text = ""
        Label_name.Visible = False
        Txt_name.Visible = False
        Label_discount.Visible = False
        Txt_discount.Visible = False
        Label_due.Visible = False
        Txt_fee_due.Visible = False
        Label_installment.Visible = False
        Txt_installments.Visible = False
        Label_paid.Visible = False
        Txt_total_paid.Visible = False
        Label_this.Visible = False
        Txt_this_payment.Visible = False
        Label_TotalFEE.Visible = False
        Txt_total_fee.Visible = False
        Label_tobepaid.Visible = False
        Txt_toBePaid.Visible = False
        Button_submit.Visible = False
        Txt_symbol.Visible = False
        Label_symbol.Visible = False
        Button_search_symbol.Visible = False
        PictureBox_backbuttons.Visible = False
        PictureBox_back.Visible = True
    End Sub

    Private Sub Admin_feemngmnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class