Imports MySqlConnector
'﻿Imports System.Windows
Public Class Admin_login
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
            Dim command As New MySqlCommand("SELECT * FROM `employee` WHERE  `admin_id` = '" & Txt_username_admin.Text & "' AND `password` = '" & Txt_password_admin.Text & "'", con)
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
                con.Close()
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
            If Txt_username_admin.Text = "" And Txt_password_admin.Text = "" Then
                MsgBox("Enter data fields to login")
            Else
                Dim command As New MySqlCommand("SELECT `admin_id`, `password` FROM `admin` WHERE `admin_id` = '" & Txt_username_admin.Text & "' AND `password` = '" & Txt_password_admin.Text & "'", con)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count = 0 Then
                    MessageBox.Show("Invalid Username Or Password")
                Else
                    Check()
                    Me.Hide()
                    Admin_home.Show()
                End If
            End If
        Catch ex As System.IO.IOException
            Console.WriteLine("Exception : {0}", ex)
        Catch ex As Exception
            Console.WriteLine("Exception : {0}", ex)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("WIll be added later.")
    End Sub

    Private Sub Admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class