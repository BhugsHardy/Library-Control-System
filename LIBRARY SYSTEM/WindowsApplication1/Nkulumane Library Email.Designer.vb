<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemail
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtyourpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtyouremail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtimport = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtrecname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbody = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.GroupBox1.Controls.Add(Me.txtyourpassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtyouremail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(993, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sender Details"
        '
        'txtyourpassword
        '
        Me.txtyourpassword.Location = New System.Drawing.Point(192, 72)
        Me.txtyourpassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtyourpassword.Name = "txtyourpassword"
        Me.txtyourpassword.Size = New System.Drawing.Size(654, 27)
        Me.txtyourpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your Password"
        '
        'txtyouremail
        '
        Me.txtyouremail.Location = New System.Drawing.Point(192, 28)
        Me.txtyouremail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtyouremail.Name = "txtyouremail"
        Me.txtyouremail.Size = New System.Drawing.Size(654, 27)
        Me.txtyouremail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Email"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.GroupBox2.Controls.Add(Me.txtimport)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtrecname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 175)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(993, 146)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receiver's Details"
        '
        'txtimport
        '
        Me.txtimport.BackColor = System.Drawing.Color.Blue
        Me.txtimport.Location = New System.Drawing.Point(858, 91)
        Me.txtimport.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtimport.Name = "txtimport"
        Me.txtimport.Size = New System.Drawing.Size(125, 38)
        Me.txtimport.TabIndex = 7
        Me.txtimport.Text = "IMPORT"
        Me.txtimport.UseVisualStyleBackColor = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(172, 91)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(654, 27)
        Me.txtemail.TabIndex = 4
        '
        'txtrecname
        '
        Me.txtrecname.Location = New System.Drawing.Point(172, 42)
        Me.txtrecname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtrecname.Name = "txtrecname"
        Me.txtrecname.Size = New System.Drawing.Size(654, 27)
        Me.txtrecname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Receiver Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Receiver Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images1
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtbody)
        Me.GroupBox3.Controls.Add(Me.txtsubject)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 341)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(993, 541)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(856, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 38)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SEND"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(805, 472)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SEND"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Message"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Subject"
        '
        'txtbody
        '
        Me.txtbody.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbody.Location = New System.Drawing.Point(10, 87)
        Me.txtbody.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbody.Multiline = True
        Me.txtbody.Name = "txtbody"
        Me.txtbody.Size = New System.Drawing.Size(971, 273)
        Me.txtbody.TabIndex = 3
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(172, 28)
        Me.txtsubject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(654, 27)
        Me.txtsubject.TabIndex = 2
        '
        'frmemail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(1103, 774)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmemail"
        Me.Text = "Nkulumane Library Email"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtyouremail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtyourpassword As TextBox
    Friend WithEvents txtimport As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtrecname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbody As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents Button2 As Button
End Class
