<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListOfMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VIEWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COUNTMEMBERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtoutput = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(548, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUMBER OF MEMBERS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWSToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.COUNTMEMBERSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 41)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VIEWSToolStripMenuItem
        '
        Me.VIEWSToolStripMenuItem.Name = "VIEWSToolStripMenuItem"
        Me.VIEWSToolStripMenuItem.Size = New System.Drawing.Size(93, 33)
        Me.VIEWSToolStripMenuItem.Text = "VIEW"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'COUNTMEMBERSToolStripMenuItem
        '
        Me.COUNTMEMBERSToolStripMenuItem.Name = "COUNTMEMBERSToolStripMenuItem"
        Me.COUNTMEMBERSToolStripMenuItem.Size = New System.Drawing.Size(238, 33)
        Me.COUNTMEMBERSToolStripMenuItem.Text = "COUNT MEMBERS"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(83, 33)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'txtoutput
        '
        Me.txtoutput.Location = New System.Drawing.Point(820, 4)
        Me.txtoutput.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.Size = New System.Drawing.Size(196, 30)
        Me.txtoutput.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(996, 648)
        Me.DataGridView1.TabIndex = 4
        '
        'frmListOfMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(1074, 782)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmListOfMembers"
        Me.Text = "ListOfMembers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtoutput As TextBox
    Friend WithEvents VIEWSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COUNTMEMBERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
End Class
