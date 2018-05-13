Imports MySql.Data.MySqlClient
Public Class frmreturns
    Dim con As New MySqlConnection
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim optselection As Integer
    Dim condition As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        If optselection = 1 Then
            condition = "Good"
        Else
            condition = "Bad"

        End If

        Try
            'we open Connection
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "delete from borrowed where BookID ='" & txtbookid.Text & "'"
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Returning book failed")
                Else
                    MsgBox("Books successfully Returned")

                End If
            End With
            With cmd
                .Connection = con
                .CommandText = "insert into books(BookTitle,Publisher,Subject,Author,DateReceived) values ('" & txtbooktitle.Text & "','" & txtpublisher.Text & "','" & txtsubject.Text & "', '" & txtauthor.Text & "','" & dtpdate.Text & "')"
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Borrowing process failed")
                Else
                    MsgBox("Books successfully Borrowed")

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Private Sub txtbad_CheckedChanged(sender As Object, e As EventArgs) Handles txtbad.CheckedChanged
        optselection = 1
    End Sub

    Private Sub txtgood_CheckedChanged(sender As Object, e As EventArgs) Handles txtgood.CheckedChanged
        optselection = 2
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        txtbookid.Clear()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub frmreturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpdate.Format = DateTimePickerFormat.Custom
        dtpdate.CustomFormat = "yyyy/mm/dd"
    End Sub
End Class