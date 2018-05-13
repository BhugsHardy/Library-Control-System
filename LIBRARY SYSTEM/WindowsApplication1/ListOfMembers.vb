Imports MySql.Data.MySqlClient
Public Class frmListOfMembers
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand


    Private Sub VIEWSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWSToolStripMenuItem.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            con.Open()
            Dim Query As String
            Query = "Select *from library_system.members"
            cmd = New MySqlCommand(Query, con)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataset)

            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            con.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub COUNTMEMBERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COUNTMEMBERSToolStripMenuItem.Click
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            i = +i
            txtoutput.Text = "We have" & i & " members inthe system"
        Next

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        frmRemoveMember.Show()
    End Sub
End Class