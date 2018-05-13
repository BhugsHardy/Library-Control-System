Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim MySqlConn As MySqlConnection
    Dim Attempt As Integer = 3
    Dim optselect As String


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to exit the system", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            End
        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim cn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cn.ConnectionString = "server=localhost;userid=root;password=reason;database=library_system"
        cmd.Connection = cn
        cn.Open()
        Select Case (optselect)
            Case Is = 1
                optselect = "Librarian"
            Case Is = 2
                optselect = "Member"

        End Select

        cmd.CommandText = "select * from members where FirstName='" & txtusername.Text & "' and MemberID='" & txtpassword.Text & "' and Post='" & optselect & "' "
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            If optselect = "Librarian" Then
                frmstaffmenu.Show()
                Me.Hide()
            Else
                frmStudentsMenu.Show()
                Me.Hide()
            End If

        Else
                MsgBox("Ivalid details")
        End If
        cn.Close()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("If you are a student go and seek assistance from the librarian.If you are the librarian call 0784942650 or email howardmabhugu.3@gmail.com so that he assist you")
    End Sub

    Private Sub rbtnmember_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnmember.CheckedChanged
        optselect = 2
    End Sub

    Private Sub rbtnlibrarian_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnlibrarian.CheckedChanged
        optselect = 1
    End Sub
End Class