<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddbooks
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
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbooktitle = New System.Windows.Forms.TextBox()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtbookid
        '
        Me.txtbookid.Location = New System.Drawing.Point(198, 75)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.ReadOnly = True
        Me.txtbookid.Size = New System.Drawing.Size(239, 27)
        Me.txtbookid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SAVE BOOKS HERE"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Blue
        Me.btnadd.Location = New System.Drawing.Point(42, 381)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(125, 34)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BOOK ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BOOK TITLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PUBLISHER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SUBJECT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 270)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "AUTHOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 320)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "DATE RECEIVED"
        '
        'txtbooktitle
        '
        Me.txtbooktitle.Location = New System.Drawing.Point(198, 118)
        Me.txtbooktitle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbooktitle.Name = "txtbooktitle"
        Me.txtbooktitle.Size = New System.Drawing.Size(239, 27)
        Me.txtbooktitle.TabIndex = 9
        '
        'txtpublisher
        '
        Me.txtpublisher.Location = New System.Drawing.Point(198, 162)
        Me.txtpublisher.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(239, 27)
        Me.txtpublisher.TabIndex = 10
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(198, 208)
        Me.txtsubject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(239, 27)
        Me.txtsubject.TabIndex = 11
        '
        'txtauthor
        '
        Me.txtauthor.Location = New System.Drawing.Point(198, 262)
        Me.txtauthor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(239, 27)
        Me.txtauthor.TabIndex = 12
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Lime
        Me.btnnext.Location = New System.Drawing.Point(177, 381)
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
        Me.btnfind.Location = New System.Drawing.Point(312, 381)
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
        Me.btnexit.Location = New System.Drawing.Point(177, 449)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 34)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(198, 312)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(200, 27)
        Me.dtpdate.TabIndex = 17
        '
        'frmaddbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(468, 513)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.txtbooktitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbookid)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmaddbooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addbooks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbookid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbooktitle As TextBox
    Friend WithEvents txtpublisher As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtauthor As TextBox
    Friend WithEvents btnnext As Button
    Friend WithEvents btnfind As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents dtpdate As DateTimePicker
End Class
