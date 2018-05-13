<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchange
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
        Me.btnchange = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.txtrepeat = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.Blue
        Me.btnchange.Location = New System.Drawing.Point(67, 290)
        Me.btnchange.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(150, 41)
        Me.btnchange.TabIndex = 0
        Me.btnchange.Text = "CHANGE"
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = """YOUR PASSWORD IS YOR SECRET"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(364, 64)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(196, 30)
        Me.txtusername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NEW PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "REPEAT NEW PASSWORD"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(364, 122)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(196, 30)
        Me.txtpassword.TabIndex = 7
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Location = New System.Drawing.Point(364, 173)
        Me.txtnewpassword.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(196, 30)
        Me.txtnewpassword.TabIndex = 8
        '
        'txtrepeat
        '
        Me.txtrepeat.Location = New System.Drawing.Point(364, 219)
        Me.txtrepeat.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtrepeat.Name = "txtrepeat"
        Me.txtrepeat.Size = New System.Drawing.Size(196, 30)
        Me.txtrepeat.TabIndex = 9
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Lime
        Me.btnexit.Location = New System.Drawing.Point(410, 290)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(150, 41)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'frmchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b3
        Me.ClientSize = New System.Drawing.Size(622, 377)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtrepeat)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnchange)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmchange"
        Me.Text = "CHANGE PASSWORD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnchange As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtnewpassword As TextBox
    Friend WithEvents txtrepeat As TextBox
    Friend WithEvents btnexit As Button
End Class
