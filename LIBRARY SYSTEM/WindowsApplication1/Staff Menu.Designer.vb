<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstaffmenu
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
        Me.tlspstaffmenu = New System.Windows.Forms.MenuStrip()
        Me.VIEWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEMBERSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORROWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEMBERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORROWEDBOOKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTIINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMAILINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrslide = New System.Windows.Forms.Timer(Me.components)
        Me.pbNewImage = New System.Windows.Forms.PictureBox()
        Me.tlspstaffmenu.SuspendLayout()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlspstaffmenu
        '
        Me.tlspstaffmenu.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlspstaffmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWSToolStripMenuItem, Me.TRANSACTIONToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.HELPToolStripMenuItem, Me.SETTIINGSToolStripMenuItem, Me.EMAILINGToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.tlspstaffmenu.Location = New System.Drawing.Point(0, 0)
        Me.tlspstaffmenu.Name = "tlspstaffmenu"
        Me.tlspstaffmenu.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.tlspstaffmenu.Size = New System.Drawing.Size(946, 41)
        Me.tlspstaffmenu.TabIndex = 0
        Me.tlspstaffmenu.Text = "MenuStrip1"
        '
        'VIEWSToolStripMenuItem
        '
        Me.VIEWSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKSToolStripMenuItem1, Me.MEMBERSToolStripMenuItem1})
        Me.VIEWSToolStripMenuItem.Name = "VIEWSToolStripMenuItem"
        Me.VIEWSToolStripMenuItem.Size = New System.Drawing.Size(77, 33)
        Me.VIEWSToolStripMenuItem.Text = "ADD"
        '
        'BOOKSToolStripMenuItem1
        '
        Me.BOOKSToolStripMenuItem1.Name = "BOOKSToolStripMenuItem1"
        Me.BOOKSToolStripMenuItem1.Size = New System.Drawing.Size(206, 34)
        Me.BOOKSToolStripMenuItem1.Text = "BOOKS"
        '
        'MEMBERSToolStripMenuItem1
        '
        Me.MEMBERSToolStripMenuItem1.Name = "MEMBERSToolStripMenuItem1"
        Me.MEMBERSToolStripMenuItem1.Size = New System.Drawing.Size(206, 34)
        Me.MEMBERSToolStripMenuItem1.Text = "MEMBERS"
        '
        'TRANSACTIONToolStripMenuItem
        '
        Me.TRANSACTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BORROWToolStripMenuItem, Me.RETURNToolStripMenuItem})
        Me.TRANSACTIONToolStripMenuItem.Name = "TRANSACTIONToolStripMenuItem"
        Me.TRANSACTIONToolStripMenuItem.Size = New System.Drawing.Size(203, 33)
        Me.TRANSACTIONToolStripMenuItem.Text = "TRANSACTION"
        '
        'BORROWToolStripMenuItem
        '
        Me.BORROWToolStripMenuItem.Name = "BORROWToolStripMenuItem"
        Me.BORROWToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.BORROWToolStripMenuItem.Text = "BORROW"
        '
        'RETURNToolStripMenuItem
        '
        Me.RETURNToolStripMenuItem.Name = "RETURNToolStripMenuItem"
        Me.RETURNToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.RETURNToolStripMenuItem.Text = "RETURN"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKSToolStripMenuItem, Me.MEMBERSToolStripMenuItem, Me.BORROWEDBOOKSToolStripMenuItem})
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
        'MEMBERSToolStripMenuItem
        '
        Me.MEMBERSToolStripMenuItem.Name = "MEMBERSToolStripMenuItem"
        Me.MEMBERSToolStripMenuItem.Size = New System.Drawing.Size(321, 34)
        Me.MEMBERSToolStripMenuItem.Text = "MEMBERS"
        '
        'BORROWEDBOOKSToolStripMenuItem
        '
        Me.BORROWEDBOOKSToolStripMenuItem.Name = "BORROWEDBOOKSToolStripMenuItem"
        Me.BORROWEDBOOKSToolStripMenuItem.Size = New System.Drawing.Size(321, 34)
        Me.BORROWEDBOOKSToolStripMenuItem.Text = "BORROWED BOOKS"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(88, 33)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'SETTIINGSToolStripMenuItem
        '
        Me.SETTIINGSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHANGEPASSWORDToolStripMenuItem})
        Me.SETTIINGSToolStripMenuItem.Name = "SETTIINGSToolStripMenuItem"
        Me.SETTIINGSToolStripMenuItem.Size = New System.Drawing.Size(161, 33)
        Me.SETTIINGSToolStripMenuItem.Text = "SETTIINGS"
        '
        'CHANGEPASSWORDToolStripMenuItem
        '
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD"
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
        'tmrslide
        '
        '
        'pbNewImage
        '
        Me.pbNewImage.Location = New System.Drawing.Point(12, 63)
        Me.pbNewImage.Name = "pbNewImage"
        Me.pbNewImage.Size = New System.Drawing.Size(922, 384)
        Me.pbNewImage.TabIndex = 1
        Me.pbNewImage.TabStop = False
        '
        'frmstaffmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(946, 459)
        Me.Controls.Add(Me.pbNewImage)
        Me.Controls.Add(Me.tlspstaffmenu)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.tlspstaffmenu
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmstaffmenu"
        Me.Text = "Staff Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlspstaffmenu.ResumeLayout(False)
        Me.tlspstaffmenu.PerformLayout()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlspstaffmenu As MenuStrip
    Friend WithEvents VIEWSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSACTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTIINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMAILINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrslide As Timer
    Friend WithEvents pbNewImage As PictureBox
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEMBERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORROWEDBOOKSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORROWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MEMBERSToolStripMenuItem1 As ToolStripMenuItem
End Class
