Imports MySql.Data.MySqlClient
Imports SpeechLib
Public Class frmborrow
    Dim con As New MySqlConnection
    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim optselection As Integer
    Dim condition As String
    Dim alarmTime As Date  'The time of the alarm
    Dim deadline As Integer 'The amount of time after which the alarm will become extremely annoying
    Dim messageText As String  'The alarm's message
    Dim alarmNameText As String  'The alarm's name
    Dim speaker As New SpVoice 'This will instantinize a new "voice" for this app to speak through
    Dim alarmIsSet As Boolean = False 'Will determine whether alarm is set or not
    Dim annoyingMode As Boolean = False 'Will force the user to pay attention to what the alarm is telling him to do
    Dim dr As MySqlDataReader
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtsubject.TextChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
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
                .CommandText = "insert into borrowed(MemberID,BookID,Title,Subject,Status,DateIssued,DueDate) values ('" & txtxmemberid.Text & "','" & txtbookid.Text & "','" & txttitle.Text & "','" & txtsubject.Text & "','" & condition & "', '" & dtpdate.Text & "','" & dtpdate1.Text & "')"
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Borrowing process failed")
                Else
                    MsgBox("Books successfully Borrowed")

                End If
            End With
            Dim str As String
            str = "Delete from books Where BookID = '" & txtbookid.Text.ToString & "'"
            Dim cd As MySqlCommand = New MySqlCommand(str, con)
            Try
                cd.ExecuteNonQuery()
                cd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        alarmIsSet = True
        Timer1.Enabled = True
        Me.Visible = False 'Hides the form

        alarmTime = dtpdate1.Text
        deadline = 1
        messageText = "The book with id " & txtbookid.Text & " given to member with member id" & txtxmemberid.Text & " is due today"
        alarmNameText = "Book due"

        'Convert's the user's "deadline" (minutes) to milliseconds for use in timer2
        Timer2.Interval = deadline * 60 * 1000

        'Demo of how to use NotifyIcons
        NotifyIcon1.BalloonTipTitle = "Alarm Set - - Please make sure your volume is unmuted"
        NotifyIcon1.BalloonTipText = "An Alarm has been set for " & alarmTime & ". Named : " & alarmNameText & ". With the message : " & messageText
        NotifyIcon1.ShowBalloonTip(2000)
        con.Close()


    End Sub

    Private Sub rbtngood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtngood.CheckedChanged
        optselection = 1
    End Sub

    Private Sub rbtnbad_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnbad.CheckedChanged
        optselection = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Clock.LocalTime.TimeOfDay.ToString.Substring(0, 5) = alarmTime.TimeOfDay.ToString.Substring(0, 5) Then
            speaker.Speak("Don't be alarmed, this is just an alarm ha ha ha.  You have set an alarm named. " & alarmNameText & ". with the message. " & messageText)
            Timer1.Enabled = False

            If InputBox("say 'yes I want to stop this alarm' to stop this alarm").ToLower.Contains("yes i want to stop this alarm") Then
                End
            Else
                speaker.Speak("This will get really annoying in " & deadline & " minutes")
            End If

            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        annoyingMode = True
        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True

        For a As Integer = 0 To 5 'It seems like there is a max limit to how many controls can be removed from a form at a time o.O, safe way = do it 6 timese
            For Each lol As Control In Me.Controls 'Removes each control on the form
                Me.Controls.Remove(lol)
            Next
        Next

        Timer3.Enabled = True

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        speaker.Rate = 3 'Makes it speak faster
        speaker.Speak(alarmNameText & " " & messageText)
        Beep() 'Nothing is more annoying than a beep;)
        My.Computer.Keyboard.SendKeys(Keys.VolumeUp) 'Sends a key to turn to volume up

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub frmborrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpdate.Format = DateTimePickerFormat.Custom
        dtpdate.CustomFormat = "yyyy/mm/dd"
        dtpdate1.Format = DateTimePickerFormat.Custom
        dtpdate1.CustomFormat = "yyyy/mm/dd"
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        txtbookid.Clear()
        txtsubject.Clear()
        txttitle.Clear()
        txtxmemberid.Clear()

    End Sub
End Class