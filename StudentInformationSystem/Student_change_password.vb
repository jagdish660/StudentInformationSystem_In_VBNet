Imports MySqlConnector
Public Class Student_change_password
    Private Const PWDCHANGESTRINGG As String = "Password changed successfully. "

    Private Sub ButtonSubmitPWDchnge_Click(sender As Object, e As EventArgs) Handles ButtonSubmitPWDchnge.Click
        Try
            If Txt_adminidSearch.Text IsNot "" Then
                If Txt_oldPWD.Text IsNot Txt_newPWD1 AndAlso Txt_newPWD1.Text = Txt_newPWD2.Text Then
                    CHNGEPSWD()
                End If
            Else
                Dim unused2 = MsgBox("Enter data field to proceed.")
            End If
        Catch ex As MySqlException
            Dim unused = MsgBox("MySQL error : " & ex.Message)
        Catch ex As Exception
            Dim unused4 = MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub CHNGEPSWD()
        Using selectCommand As New MySqlCommand(commandText:=$"UPDATE `student` SET `password` = '" & Txt_newPWD1.Text & "' WHERE `admin_id` = '" & Txt_adminidSearch.Text & "'", Con)
            Dim table As New DataTable()
            Dim unused1 = New MySqlDataAdapter(selectCommand).Fill(table)
            If table.Rows.Count = 0 Then
                Dim unused3 = MsgBox(PWDCHANGESTRINGG)
                Txt_newPWD1.Text = ""
                Txt_newPWD2.Text = ""
                Txt_oldPWD.Text = ""
                Hide()
                SIS1.Show()
            Else
                Dim unused5 = MsgBox("Invalid admin ID.   Enter valid username and try again.")
            End If
        End Using
    End Sub
End Class