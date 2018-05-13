Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class frmemail
    Dim con As New MySqlConnection
    Dim result As Integer

    Dim optselection, gender As String
    Public strSql As String
    Dim dr As MySqlDataAdapter
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmemail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtimport_Click(sender As Object, e As EventArgs) Handles txtimport.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        con.Open()
        Dim dr As MySqlDataReader
        Dim str As String
        str = "SELECT * FROM members WHERE (FirstName = '" & txtrecname.Text & "')"
        Dim cmd As MySqlCommand = New MySqlCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read()

            txtemail.Text = dr("Email").ToString

        End While
        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress(txtemail.Text)
            EmailMessage.To.Add(txtemail.Text)
            EmailMessage.Subject = txtsubject.Text
            EmailMessage.Body = txtbody.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(txtemail.Text, txtyourpassword.Text)
            SMTP.Send(EmailMessage)
            MsgBox("Message successfully send")
        Catch ex As Exception

        End Try
    End Sub



End Class