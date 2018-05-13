Imports MySql.Data.MySqlClient
Public Class frmchange
    Dim con As New MySqlConnection
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        Try
            'we open Connection
            con.Open()
            If txtnewpassword.Text = txtrepeat.Text Then


                With cmd
                    .Connection = con
                    .CommandText = "Update members SET MemberId = '" & txtnewpassword.Text & "' WHERE FirstName = '" & txtusername.Text & "'"
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MsgBox("Password successfully changed")
                    Else
                        MsgBox("Password successfully changed")

                    End If
                End With
            Else
                MsgBox("Your new passwods do not match ")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
End Class
