<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmembers
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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmemberid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtfonnumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnmemb = New System.Windows.Forms.RadioButton()
        Me.rbtnlib = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Blue
        Me.btnadd.Location = New System.Drawing.Point(34, 444)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(125, 34)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MEMBER ID"
        '
        'txtmemberid
        '
        Me.txtmemberid.Location = New System.Drawing.Point(190, 63)
        Me.txtmemberid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.ReadOnly = True
        Me.txtmemberid.Size = New System.Drawing.Size(264, 27)
        Me.txtmemberid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SURNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 324)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 361)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PHONE NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-MAIL"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(190, 99)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(264, 27)
        Me.txtfirstname.TabIndex = 8
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(190, 136)
        Me.txtsurname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(264, 27)
        Me.txtsurname.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(190, 392)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(264, 27)
        Me.txtemail.TabIndex = 10
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(190, 316)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(264, 27)
        Me.txtaddress.TabIndex = 11
        '
        'txtfonnumber
        '
        Me.txtfonnumber.Location = New System.Drawing.Point(190, 358)
        Me.txtfonnumber.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtfonnumber.Name = "txtfonnumber"
        Me.txtfonnumber.Size = New System.Drawing.Size(264, 27)
        Me.txtfonnumber.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnfemale)
        Me.GroupBox1.Controls.Add(Me.rbtnmale)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 176)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(153, 120)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GENDER"
        '
        'rbtnfemale
        '
        Me.rbtnfemale.AutoSize = True
        Me.rbtnfemale.Location = New System.Drawing.Point(10, 70)
        Me.rbtnfemale.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtnfemale.Name = "rbtnfemale"
        Me.rbtnfemale.Size = New System.Drawing.Size(91, 23)
        Me.rbtnfemale.TabIndex = 1
        Me.rbtnfemale.TabStop = True
        Me.rbtnfemale.Text = "FEMALE"
        Me.rbtnfemale.UseVisualStyleBackColor = True
        '
        'rbtnmale
        '
        Me.rbtnmale.AutoSize = True
        Me.rbtnmale.Location = New System.Drawing.Point(5, 23)
        Me.rbtnmale.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(72, 23)
        Me.rbtnmale.TabIndex = 0
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "MALE"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Lime
        Me.btnnext.Location = New System.Drawing.Point(180, 444)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(125, 34)
        Me.btnnext.TabIndex = 14
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnfind
        '
        Me.btnfind.BackColor = System.Drawing.Color.Yellow
        Me.btnfind.Location = New System.Drawing.Point(329, 444)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(125, 34)
        Me.btnfind.TabIndex = 15
        Me.btnfind.Text = "FIND"
        Me.btnfind.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Location = New System.Drawing.Point(329, 520)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 34)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Magenta
        Me.btnprint.Location = New System.Drawing.Point(34, 520)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(125, 34)
        Me.btnprint.TabIndex = 17
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ADD MEMBERS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnmemb)
        Me.GroupBox2.Controls.Add(Me.rbtnlib)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 188)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(153, 120)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POST"
        '
        'rbtnmemb
        '
        Me.rbtnmemb.AutoSize = True
        Me.rbtnmemb.Location = New System.Drawing.Point(10, 70)
        Me.rbtnmemb.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtnmemb.Name = "rbtnmemb"
        Me.rbtnmemb.Size = New System.Drawing.Size(98, 23)
        Me.rbtnmemb.TabIndex = 1
        Me.rbtnmemb.TabStop = True
        Me.rbtnmemb.Text = "MEMBER"
        Me.rbtnmemb.UseVisualStyleBackColor = True
        '
        'rbtnlib
        '
        Me.rbtnlib.AutoSize = True
        Me.rbtnlib.Location = New System.Drawing.Point(5, 23)
        Me.rbtnlib.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbtnlib.Name = "rbtnlib"
        Me.rbtnlib.Size = New System.Drawing.Size(121, 23)
        Me.rbtnlib.TabIndex = 0
        Me.rbtnlib.TabStop = True
        Me.rbtnlib.Text = "LIBRARIAN"
        Me.rbtnlib.UseVisualStyleBackColor = True
        '
        'frmmembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(503, 570)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtfonnumber)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmemberid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnadd)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmmembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmemberid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtfonnumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents btnnext As Button
    Friend WithEvents btnfind As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnmemb As RadioButton
    Friend WithEvents rbtnlib As RadioButton
End Class
