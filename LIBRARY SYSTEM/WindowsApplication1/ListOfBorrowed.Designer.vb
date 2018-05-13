<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VIEWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtboorowednumber = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Blue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 40)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(870, 645)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List Of Borrowed Books"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWSToolStripMenuItem, Me.COUNTToolStripMenuItem, Me.RETURNToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(899, 41)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VIEWSToolStripMenuItem
        '
        Me.VIEWSToolStripMenuItem.Name = "VIEWSToolStripMenuItem"
        Me.VIEWSToolStripMenuItem.Size = New System.Drawing.Size(93, 33)
        Me.VIEWSToolStripMenuItem.Text = "VIEW"
        '
        'COUNTToolStripMenuItem
        '
        Me.COUNTToolStripMenuItem.Name = "COUNTToolStripMenuItem"
        Me.COUNTToolStripMenuItem.Size = New System.Drawing.Size(111, 33)
        Me.COUNTToolStripMenuItem.Text = "COUNT"
        '
        'RETURNToolStripMenuItem
        '
        Me.RETURNToolStripMenuItem.Name = "RETURNToolStripMenuItem"
        Me.RETURNToolStripMenuItem.Size = New System.Drawing.Size(126, 33)
        Me.RETURNToolStripMenuItem.Text = "RETURN"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(83, 33)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'txtboorowednumber
        '
        Me.txtboorowednumber.Location = New System.Drawing.Point(679, 12)
        Me.txtboorowednumber.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtboorowednumber.Multiline = True
        Me.txtboorowednumber.Name = "txtboorowednumber"
        Me.txtboorowednumber.Size = New System.Drawing.Size(196, 23)
        Me.txtboorowednumber.TabIndex = 4
        '
        'frmBorrowed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(899, 688)
        Me.Controls.Add(Me.txtboorowednumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmBorrowed"
        Me.Text = "List of Borrowed Books"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtboorowednumber As TextBox
    Friend WithEvents VIEWSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COUNTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
