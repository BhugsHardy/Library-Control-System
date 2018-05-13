Imports MySql.Data.MySqlClient
Public Class frmRemoveMember
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub frmRemoveMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
            con.Open()
            Dim str As String
            str = "Delete from members Where MemberID = '" & txtmemberid.Text.ToString & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(str, con)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If

    End Sub
End Class