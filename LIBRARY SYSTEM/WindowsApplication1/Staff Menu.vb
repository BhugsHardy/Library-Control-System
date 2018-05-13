Public Class frmstaffmenu
    Private Sub VIEWSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWSToolStripMenuItem.Click

    End Sub

    Private Sub frmstaffmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmrslide.Start()
    End Sub

    Private Sub tmrslide_Tick(sender As Object, e As EventArgs) Handles tmrslide.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)

        Dim i As Integer = 1

        Dim number(max - 1) As Integer

        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        tmrslide.Interval = number(i)
        i += 1

        ChangeImage()

    End Sub
    Private Sub ChangeImage()

        Static Dim iImage1 As Integer
        Select Case iImage1
            Case 0

                pbNewImage.Visible = True
                pbNewImage.Image = My.Resources.b1
                iImage1 += 1
            Case 1
                pbNewImage.Visible = True
                pbNewImage.Image = My.Resources.b2
                iImage1 += 1
            Case 2

                pbNewImage.Visible = True
                pbNewImage.Image = My.Resources.b3
                iImage1 += 1
            Case 3

                pbNewImage.Visible = True
                pbNewImage.Image = My.Resources.b4
                iImage1 += 1
            Case 4

                pbNewImage.Visible = True
                pbNewImage.Image = My.Resources.b5
                iImage1 = 0

        End Select
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub EMAILINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMAILINGToolStripMenuItem.Click
        frmemail.Show()
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        frmchange.Show()
    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click
        MsgBox("This is Nkulumane library system menu." & vbNewLine & "1.ADD- is used to add Members and Books inthe System" & vbNewLine & "2.TRANSACTION-Used for Borrowing Books and Returning Books" & vbNewLine & "3. VIEW- is used to view books inthe system, borrowed books and list of members." & vbNewLine & "4.SETTINGS-is used to change password." & vbNewLine & "5. EMAILING- is used to send emails if there is need to")
    End Sub

    Private Sub VIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click

    End Sub

    Private Sub BOOKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKSToolStripMenuItem.Click
        frmlistofbooks.Show()
    End Sub

    Private Sub MEMBERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERSToolStripMenuItem.Click
        frmListOfMembers.Show()
    End Sub

    Private Sub BORROWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BORROWToolStripMenuItem.Click
        frmborrow.Show()
    End Sub

    Private Sub RETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETURNToolStripMenuItem.Click
        frmreturns.Show()
    End Sub

    Private Sub BOOKSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BOOKSToolStripMenuItem1.Click
        frmaddbooks.Show()
    End Sub

    Private Sub MEMBERSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEMBERSToolStripMenuItem1.Click
        frmmembers.Show()
    End Sub

    Private Sub BORROWEDBOOKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BORROWEDBOOKSToolStripMenuItem.Click
        frmBorrowed.Show()
    End Sub
End Class