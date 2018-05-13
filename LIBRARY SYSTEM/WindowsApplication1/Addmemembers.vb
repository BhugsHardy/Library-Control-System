Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class frmmembers
    Dim con As New MySqlConnection
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim optselection, gender, post As String
    Public strSql As String
    Dim dr As MySqlDataAdapter

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged

    End Sub

    Private Sub rbtnmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnmale.CheckedChanged
        optselection = 1
    End Sub

    Private Sub rbtnfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnfemale.CheckedChanged
        optselection = 2
    End Sub

    Private Sub rbtnlib_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnlib.CheckedChanged
        optselection = 3
    End Sub

    Private Sub rbtnmemb_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnmemb.CheckedChanged
        optselection = 4
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        If optselection = 1 Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        If optselection = 3 Then
            post = "Librarian"
        Else
            post = "Member"
        End If
        Try
            'we open Connection
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "insert into members(Post,FirstName,Surname,Gender,Address,PhoneNumber,Email) values ('" & post & "','" & txtfirstname.Text & "','" & txtsurname.Text & "','" & gender & "', '" & txtaddress.Text & "','" & txtfonnumber.Text & "', '" & txtemail.Text & "')"
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Member hasnt been Inserted!")
                Else
                    MsgBox("Member Successfully entered inthe system")

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        txtaddress.Text = ""
        txtemail.Text = ""
        txtmemberid.Text = ""
        txtfirstname.Text = ""
        txtfonnumber.Text = ""
        txtsurname.Text = ""

    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        con.Open()
        Try
            Dim dr As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM members WHERE (FirstName = '" & txtfirstname.Text & "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                txtmemberid.Text = dr("MemberID").ToString
                txtfirstname.Text = dr("FirstName").ToString
                txtsurname.Text = dr("Surname").ToString
                gender = dr("Gender").ToString
                txtaddress.Text = dr("Address").ToString
                txtfonnumber.Text = dr("PhoneNumber").ToString
                txtemail.Text = dr("Email").ToString

            End While
            If dr.HasRows Then
                MsgBox("Member found")
            Else
                MsgBox("Member not inthe system")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub frmmembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class