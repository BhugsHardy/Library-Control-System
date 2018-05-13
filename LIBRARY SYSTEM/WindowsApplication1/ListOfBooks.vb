Imports MySql.Data.MySqlClient
Public Class frmlistofbooks
    Dim con As New MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub frmlistofbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click
        con.ConnectionString = ("server=localhost;userid=root;password=reason;database=library_system")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            con.Open()
            Dim Query As String
            Query = "Select *from library_system.books"
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

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        frmRemove.Show()
    End Sub

    Private Sub STOCKTAKEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOCKTAKEToolStripMenuItem.Click
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            i = +i
            txtbokksavailable.Text = "We have" & i & " books inthe system"
        Next


    End Sub

    Private Sub QUITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUITToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub BORROWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BORROWToolStripMenuItem.Click
        frmborrow.Show()
    End Sub
End Class