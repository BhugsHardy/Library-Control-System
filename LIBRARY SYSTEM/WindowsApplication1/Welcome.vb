Imports MySql.Data.MySqlClient
Public Class frmwlcome
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to exit the system", MsgBoxStyle.YesNo, MessageBoxIcon.Warning)
        If ask = MsgBoxResult.Yes Then
            End
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        MsgBox("The sytem you are about to open is a library sytem that manages the borowing and returning of books inthe library.Call this 0784942650 for assistance or email howardmabhugu.3@gmail.com")
    End Sub

    Private Sub btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen.Click
        If tick1.Checked = True Then
            trmprogressbar.Start()
        Else
            Dim cn As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim result As Integer
            Dim sql As String = "CREATE DATABASE  library_system "

            Try
                cn.ConnectionString = ("server=" & txtserver.Text & ";userid=" & txtuserid.Text & ";password=" & txtpassword.Text & "")
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandText = sql
                    'Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                    result = cmd.ExecuteNonQuery
                    If result = 0 Then

                        MsgBox("No Database created!")
                    Else

                        MsgBox("Database created Successfully!")

                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim createSql As String
            Try
                cn = New MySqlConnection("server=localhost;userid=root;password=reason;database=library_system")
                cn.Open()
                createSql = "CREATE TABLE members (MemberID int AUTO_INCREMENT,Post varchar(20),FirstName varchar(45),Surname varchar(45),Gender varchar(15),Address varchar(200),PhoneNumber int,Email varchar(200),PRIMARY KEY Member (MemberID))"
                Dim cmds As New MySqlCommand(createSql, cn)
                cmds.ExecuteNonQuery()
                cmds.Dispose()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            cn.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
            Try
                'we open Connection
                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandText = "insert into members (MemberID,Post,FirstName,Surname,Gender,Address,PhoneNumber,Email) values ('210692353', 'Librarian','N0161388M','Mabhugu','Male','456 Mpandawana','078492659','howardmabhugu.3@gmailcom')"
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MsgBox("Failed to add books inthe system")
                    Else
                        MsgBox("Process successfully added inthe Library")
                        trmprogressbar.Start()

                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            cn.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles prgBar.Click

    End Sub

    Private Sub trmprogressbar_Tick(sender As Object, e As EventArgs) Handles trmprogressbar.Tick
        prgBar.Increment(5)
        If prgBar.Value = 100 Then
            trmprogressbar.Stop()
            frmLogin.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub frmwlcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tick1_CheckedChanged(sender As Object, e As EventArgs) Handles tick1.CheckedChanged
        If tick1.Checked = False Then
            Dim ask As MsgBoxResult
            ask = MsgBox("This option must only be selected if you are running the system for the first time.Are you running the system for th first time?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning)
            If ask = MsgBoxResult.Yes Then
                grpdata.Show()
            Else
                tick1.Checked = True
            End If

        Else
            grpdata.Hide()
        End If
    End Sub
End Class
