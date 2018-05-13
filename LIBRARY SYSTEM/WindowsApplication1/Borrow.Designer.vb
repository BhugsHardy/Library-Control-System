<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmborrow
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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.grpcondition = New System.Windows.Forms.GroupBox()
        Me.rbtnbad = New System.Windows.Forms.RadioButton()
        Me.rbtngood = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtxmemberid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.dtpdate1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.grpcondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Blue
        Me.btnadd.Location = New System.Drawing.Point(38, 501)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(125, 34)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'grpcondition
        '
        Me.grpcondition.Controls.Add(Me.rbtnbad)
        Me.grpcondition.Controls.Add(Me.rbtngood)
        Me.grpcondition.Location = New System.Drawing.Point(121, 312)
        Me.grpcondition.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpcondition.Name = "grpcondition"
        Me.grpcondition.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpcondition.Size = New System.Drawing.Size(162, 146)
        Me.grpcondition.TabIndex = 1
        Me.grpcondition.TabStop = False
        Me.grpcondition.Text = "CONDITION"
        '
        'rbtnbad
        '
        Me.rbtnbad.AutoSize = True
        Me.rbtnbad.Location = New System.Drawing.Point(32, 75)
        Me.rbtnbad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtnbad.Name = "rbtnbad"
        Me.rbtnbad.Size = New System.Drawing.Size(62, 23)
        Me.rbtnbad.TabIndex = 1
        Me.rbtnbad.TabStop = True
        Me.rbtnbad.Text = "BAD"
        Me.rbtnbad.UseVisualStyleBackColor = True
        '
        'rbtngood
        '
        Me.rbtngood.AutoSize = True
        Me.rbtngood.Location = New System.Drawing.Point(32, 28)
        Me.rbtngood.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtngood.Name = "rbtngood"
        Me.rbtngood.Size = New System.Drawing.Size(75, 23)
        Me.rbtngood.TabIndex = 0
        Me.rbtngood.TabStop = True
        Me.rbtngood.Text = "GOOD"
        Me.rbtngood.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = """Borrowing  a book is your right"""
        '
        'txtxmemberid
        '
        Me.txtxmemberid.Location = New System.Drawing.Point(200, 57)
        Me.txtxmemberid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtxmemberid.Name = "txtxmemberid"
        Me.txtxmemberid.Size = New System.Drawing.Size(164, 27)
        Me.txtxmemberid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MEMBER'S ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BOOK ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TITLE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SUBJECT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 228)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DATE ISSUED"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 270)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DUE DATE"
        '
        'txtbookid
        '
        Me.txtbookid.Location = New System.Drawing.Point(200, 94)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(164, 27)
        Me.txtbookid.TabIndex = 8
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(200, 143)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(164, 27)
        Me.txttitle.TabIndex = 9
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(200, 177)
        Me.txtsubject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(164, 27)
        Me.txtsubject.TabIndex = 10
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Lime
        Me.btnnext.Location = New System.Drawing.Point(173, 501)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(125, 34)
        Me.btnnext.TabIndex = 13
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Fuchsia
        Me.btnprint.Location = New System.Drawing.Point(308, 501)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(125, 34)
        Me.btnprint.TabIndex = 14
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Location = New System.Drawing.Point(173, 571)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 34)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'dtpdate1
        '
        Me.dtpdate1.Location = New System.Drawing.Point(200, 262)
        Me.dtpdate1.Name = "dtpdate1"
        Me.dtpdate1.Size = New System.Drawing.Size(200, 27)
        Me.dtpdate1.TabIndex = 16
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(200, 222)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(200, 27)
        Me.dtpdate.TabIndex = 17
        '
        'frmborrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(477, 658)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.dtpdate1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.txtbookid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtxmemberid)
        Me.Controls.Add(Me.grpcondition)
        Me.Controls.Add(Me.btnadd)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmborrow"
        Me.Text = "Borrow"
        Me.grpcondition.ResumeLayout(False)
        Me.grpcondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents grpcondition As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtxmemberid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbookid As TextBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents rbtnbad As RadioButton
    Friend WithEvents rbtngood As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents dtpdate1 As DateTimePicker
    Friend WithEvents dtpdate As DateTimePicker
End Class
