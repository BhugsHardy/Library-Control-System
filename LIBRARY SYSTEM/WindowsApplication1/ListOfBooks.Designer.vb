<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlistofbooks
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKTAKEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORROWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbokksavailable = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1236, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(631, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BOOKS AVAILABLE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWToolStripMenuItem, Me.STOCKTAKEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.BORROWToolStripMenuItem, Me.QUITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 41)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(93, 33)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'STOCKTAKEToolStripMenuItem
        '
        Me.STOCKTAKEToolStripMenuItem.Name = "STOCKTAKEToolStripMenuItem"
        Me.STOCKTAKEToolStripMenuItem.Size = New System.Drawing.Size(169, 33)
        Me.STOCKTAKEToolStripMenuItem.Text = "STOCKTAKE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'BORROWToolStripMenuItem
        '
        Me.BORROWToolStripMenuItem.Name = "BORROWToolStripMenuItem"
        Me.BORROWToolStripMenuItem.Size = New System.Drawing.Size(136, 33)
        Me.BORROWToolStripMenuItem.Text = "BORROW"
        '
        'QUITToolStripMenuItem
        '
        Me.QUITToolStripMenuItem.Name = "QUITToolStripMenuItem"
        Me.QUITToolStripMenuItem.Size = New System.Drawing.Size(83, 33)
        Me.QUITToolStripMenuItem.Text = "EXIT"
        '
        'txtbokksavailable
        '
        Me.txtbokksavailable.Location = New System.Drawing.Point(888, 11)
        Me.txtbokksavailable.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtbokksavailable.Name = "txtbokksavailable"
        Me.txtbokksavailable.Size = New System.Drawing.Size(196, 30)
        Me.txtbokksavailable.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 431)
        Me.DataGridView1.TabIndex = 4
        '
        'frmlistofbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(1280, 702)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtbokksavailable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmlistofbooks"
        Me.Text = "ListOfBooks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STOCKTAKEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORROWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QUITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtbokksavailable As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
