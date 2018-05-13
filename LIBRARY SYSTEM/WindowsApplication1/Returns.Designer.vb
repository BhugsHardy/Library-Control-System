<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturns
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
        Me.btndone = New System.Windows.Forms.Button()
        Me.grpcondition = New System.Windows.Forms.GroupBox()
        Me.txtbad = New System.Windows.Forms.RadioButton()
        Me.txtgood = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.txtbooktitle = New System.Windows.Forms.TextBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.grpcondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbookid
        '
        Me.txtbookid.Location = New System.Drawing.Point(188, 47)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(164, 27)
        Me.txtbookid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = """Returning a book is another way of being honest"""
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.Color.Blue
        Me.btndone.Location = New System.Drawing.Point(39, 405)
        Me.btndone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(125, 34)
        Me.btndone.TabIndex = 2
        Me.btndone.Text = "DONE"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'grpcondition
        '
        Me.grpcondition.Controls.Add(Me.txtbad)
        Me.grpcondition.Controls.Add(Me.txtgood)
        Me.grpcondition.Location = New System.Drawing.Point(89, 274)
        Me.grpcondition.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpcondition.Name = "grpcondition"
        Me.grpcondition.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpcondition.Size = New System.Drawing.Size(220, 123)
        Me.grpcondition.TabIndex = 3
        Me.grpcondition.TabStop = False
        Me.grpcondition.Text = "CONDITION"
        '
        'txtbad
        '
        Me.txtbad.AutoSize = True
        Me.txtbad.Location = New System.Drawing.Point(10, 61)
        Me.txtbad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbad.Name = "txtbad"
        Me.txtbad.Size = New System.Drawing.Size(62, 23)
        Me.txtbad.TabIndex = 1
        Me.txtbad.TabStop = True
        Me.txtbad.Text = "BAD"
        Me.txtbad.UseVisualStyleBackColor = True
        '
        'txtgood
        '
        Me.txtgood.AutoSize = True
        Me.txtgood.Location = New System.Drawing.Point(10, 28)
        Me.txtgood.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtgood.Name = "txtgood"
        Me.txtgood.Size = New System.Drawing.Size(75, 23)
        Me.txtgood.TabIndex = 0
        Me.txtgood.TabStop = True
        Me.txtgood.Text = "GOOD"
        Me.txtgood.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BOOK ID"
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Lime
        Me.btnnext.Location = New System.Drawing.Point(174, 405)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(125, 34)
        Me.btnnext.TabIndex = 5
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Fuchsia
        Me.btnprint.Location = New System.Drawing.Point(309, 405)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(125, 34)
        Me.btnprint.TabIndex = 6
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Location = New System.Drawing.Point(174, 447)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 34)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BOOK TITLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 235)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DATE RECEIVED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "AUTHOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 157)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SUBJECT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "PUBLISHER"
        '
        'txtauthor
        '
        Me.txtauthor.Location = New System.Drawing.Point(188, 194)
        Me.txtauthor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(164, 27)
        Me.txtauthor.TabIndex = 13
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(188, 149)
        Me.txtsubject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(164, 27)
        Me.txtsubject.TabIndex = 14
        '
        'txtpublisher
        '
        Me.txtpublisher.Location = New System.Drawing.Point(188, 115)
        Me.txtpublisher.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(164, 27)
        Me.txtpublisher.TabIndex = 15
        '
        'txtbooktitle
        '
        Me.txtbooktitle.Location = New System.Drawing.Point(188, 80)
        Me.txtbooktitle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbooktitle.Name = "txtbooktitle"
        Me.txtbooktitle.Size = New System.Drawing.Size(164, 27)
        Me.txtbooktitle.TabIndex = 16
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(188, 229)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(164, 27)
        Me.dtpdate.TabIndex = 17
        '
        'frmreturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(654, 512)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.txtbooktitle)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpcondition)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbookid)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmreturns"
        Me.Text = "Returns"
        Me.grpcondition.ResumeLayout(False)
        Me.grpcondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbookid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btndone As Button
    Friend WithEvents grpcondition As GroupBox
    Friend WithEvents txtbad As RadioButton
    Friend WithEvents txtgood As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtauthor As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtpublisher As TextBox
    Friend WithEvents txtbooktitle As TextBox
    Friend WithEvents dtpdate As DateTimePicker
End Class
