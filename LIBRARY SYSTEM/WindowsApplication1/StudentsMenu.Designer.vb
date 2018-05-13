<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentsMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORROWEDBOOKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMAILINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbNewImage = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWToolStripMenuItem, Me.SETTINGSToolStripMenuItem, Me.HELPToolStripMenuItem, Me.EMAILINGToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 41)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKSToolStripMenuItem, Me.BORROWEDBOOKSToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(93, 33)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'BOOKSToolStripMenuItem
        '
        Me.BOOKSToolStripMenuItem.Name = "BOOKSToolStripMenuItem"
        Me.BOOKSToolStripMenuItem.Size = New System.Drawing.Size(321, 34)
        Me.BOOKSToolStripMenuItem.Text = "BOOKS"
        '
        'BORROWEDBOOKSToolStripMenuItem
        '
        Me.BORROWEDBOOKSToolStripMenuItem.Name = "BORROWEDBOOKSToolStripMenuItem"
        Me.BORROWEDBOOKSToolStripMenuItem.Size = New System.Drawing.Size(321, 34)
        Me.BORROWEDBOOKSToolStripMenuItem.Text = "BORROWED BOOKS"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHANGEPASSWORDToolStripMenuItem})
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(149, 33)
        Me.SETTINGSToolStripMenuItem.Text = "SETTINGS"
        '
        'CHANGEPASSWORDToolStripMenuItem
        '
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(88, 33)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'EMAILINGToolStripMenuItem
        '
        Me.EMAILINGToolStripMenuItem.Name = "EMAILINGToolStripMenuItem"
        Me.EMAILINGToolStripMenuItem.Size = New System.Drawing.Size(152, 33)
        Me.EMAILINGToolStripMenuItem.Text = "EMAILING"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(83, 33)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'pbNewImage
        '
        Me.pbNewImage.Location = New System.Drawing.Point(0, 70)
        Me.pbNewImage.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pbNewImage.Name = "pbNewImage"
        Me.pbNewImage.Size = New System.Drawing.Size(894, 671)
        Me.pbNewImage.TabIndex = 1
        Me.pbNewImage.TabStop = False
        '
        'Timer1
        '
        '
        'frmStudentsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(911, 774)
        Me.Controls.Add(Me.pbNewImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmStudentsMenu"
        Me.Text = "Members Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORROWEDBOOKSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMAILINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbNewImage As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
