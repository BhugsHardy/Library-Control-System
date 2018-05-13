<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwlcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwlcome))
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.trmprogressbar = New System.Windows.Forms.Timer(Me.components)
        Me.grpdata = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtserver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tick1 = New System.Windows.Forms.CheckBox()
        Me.grpdata.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.LawnGreen
        Me.btnopen.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.ForeColor = System.Drawing.Color.Blue
        Me.btnopen.Location = New System.Drawing.Point(40, 255)
        Me.btnopen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(124, 34)
        Me.btnopen.TabIndex = 0
        Me.btnopen.Text = "OPEN"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NKULUMANE LIBRARY SYSTEM"
        '
        'prgBar
        '
        Me.prgBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.prgBar.Location = New System.Drawing.Point(40, 213)
        Me.prgBar.Margin = New System.Windows.Forms.Padding(4)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(693, 34)
        Me.prgBar.TabIndex = 2
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnhelp.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Location = New System.Drawing.Point(297, 255)
        Me.btnhelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(124, 34)
        Me.btnhelp.TabIndex = 3
        Me.btnhelp.Text = "HELP"
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(609, 255)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(124, 34)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'trmprogressbar
        '
        '
        'grpdata
        '
        Me.grpdata.Controls.Add(Me.txtpassword)
        Me.grpdata.Controls.Add(Me.txtuserid)
        Me.grpdata.Controls.Add(Me.Label4)
        Me.grpdata.Controls.Add(Me.Label3)
        Me.grpdata.Controls.Add(Me.txtserver)
        Me.grpdata.Controls.Add(Me.Label2)
        Me.grpdata.Location = New System.Drawing.Point(168, 70)
        Me.grpdata.Name = "grpdata"
        Me.grpdata.Size = New System.Drawing.Size(350, 122)
        Me.grpdata.TabIndex = 5
        Me.grpdata.TabStop = False
        Me.grpdata.Text = "Database Details"
        Me.grpdata.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(106, 90)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(163, 27)
        Me.txtpassword.TabIndex = 5
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(106, 53)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(163, 27)
        Me.txtuserid.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserId"
        '
        'txtserver
        '
        Me.txtserver.Location = New System.Drawing.Point(106, 20)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(163, 27)
        Me.txtserver.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Server"
        '
        'tick1
        '
        Me.tick1.AutoSize = True
        Me.tick1.Checked = True
        Me.tick1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tick1.Location = New System.Drawing.Point(40, 41)
        Me.tick1.Name = "tick1"
        Me.tick1.Size = New System.Drawing.Size(633, 23)
        Me.tick1.TabIndex = 6
        Me.tick1.Text = "UnTick this if u are running this system for the first time in a new machine"
        Me.tick1.UseVisualStyleBackColor = True
        '
        'frmwlcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(781, 302)
        Me.Controls.Add(Me.tick1)
        Me.Controls.Add(Me.grpdata)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnopen)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmwlcome"
        Me.Text = "WELCOME"
        Me.grpdata.ResumeLayout(False)
        Me.grpdata.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnopen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents prgBar As ProgressBar
    Friend WithEvents btnhelp As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents trmprogressbar As Timer
    Friend WithEvents grpdata As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtserver As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents tick1 As CheckBox
End Class
