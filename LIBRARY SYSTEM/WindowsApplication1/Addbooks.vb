Imports MySql.Data.MySqlClient
Public Class frmaddbooks

    Dim con As New MySqlConnection
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        Try
            'we open Connection
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "insert into books(BookTitle,Publisher,Subject,Author,DateReceived) values ('" & txtbooktitle.Text & "','" & txtpublisher.Text & "','" & txtsubject.Text & "', '" & txtauthor.Text & "','" & dtpdate.Text & "')"
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Failed to add books inthe system")
                Else
                    MsgBox("Books successfully added inthe Library")

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        txtauthor.Text = ""
        txtbookid.Text = ""
        txtbooktitle.Text = ""
        dtpdate.Text = ""
        txtpublisher.Text = ""
        txtsubject.Text = ""


    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        con.Open()
        Try
            Dim dr As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM books WHERE (BookTitle = '" & txtbooktitle.Text & "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                txtbookid.Text = dr("BookID").ToString
                txtbooktitle.Text = dr("BookTitle").ToString
                txtpublisher.Text = dr("Publisher").ToString
                txtsubject.Text = dr("Subject").ToString
                txtauthor.Text = dr("Author").ToString
                dtpdate.Text = dr("DateReceived").ToString

            End While
            If dr.HasRows Then
                MsgBox("Book found")
            Else
                MsgBox("Book not available")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub frmaddbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpdate.Format = DateTimePickerFormat.Custom
        dtpdate.CustomFormat = "yyyy/mm/dd"
    End Sub
End Class