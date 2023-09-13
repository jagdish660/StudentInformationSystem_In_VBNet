Imports MySqlConnector
'﻿Imports System.Windows
Public Class Admin_login
    Private Const aV As String = ""

    Private Sub CHKBX_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CHKBX_showpassword.CheckedChanged
        Txt_password_admin.UseSystemPasswordChar = False = CHKBX_showpassword.Checked
        Txt_password_admin.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SIS1.Show()
    End Sub

    Public Sub Check()
        Try
            Dim command As New MySqlCommand("SELECT * FROM `admin` WHERE  `admin_id` = '" & Txt_username_admin.Text & "' AND `password` = '" & Txt_password_admin.Text & "'", Con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                'Dim userType As String = table.Rows(0)("type").ToString
                'If userType = "Staff" Then
                'Admin_home.Show()
                'Dim name As String = table.Rows(0)("name").ToString
                'Dim dept As String = table.Rows(0)("department").ToString
                'globalvariables.name = name
                'globalvariables.depart = dept
                'globalvariables.typ = userType
                'Me.Hide()
                'Else userType = "Project Manager"
                Con.Close()
                Admin_home.Show()
                Dim name As String = table.Rows(0)("admin_id").ToString
                Dim pwd As String = table.Rows(0)("password").ToString
                Me.Hide()
                'End If
            Else
                MsgBox("Record not found")
            End If
        Catch ex As System.IO.IOException
            Console.WriteLine("Exception :{0}", ex)
        Catch ex As Exception
            Console.WriteLine("Exception : {0}", ex)
        End Try
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Try
            If Txt_username_admin.Text IsNot "" And Txt_password_admin.Text IsNot "" Then
                Using table As New DataTable()
                    Dim unused1 = New MySqlDataAdapter(New MySqlCommand(commandText:=$"SELECT `admin_id`, `password` FROM `admin` WHERE `admin_id` = '{Txt_username_admin.Text}' AND `password` = '{Txt_password_admin.Text}'", Con)).Fill(table)
                    Select Case table.Rows.Count
                        Case 0
                            Dim unused3 = MessageBox.Show("Invalid Username Or Password")
                        Case Else
                            Txt_password_admin.Text = aV
                            Txt_username_admin.Text = aV
                            'Check()
                            SIS1.Hide()
                            Hide()
                            Admin_home.Show()
                    End Select
                End Using
            Else
                Dim unused2 = MsgBox("Enter data fields to login")
            End If
        Catch ex As IO.IOException
            Dim unused = MsgBox(ex.Message)
        Catch ex As Exception
            Dim unused4 = MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("WIll be added later.")
    End Sub

    Private Sub Admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class