<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnmember = New System.Windows.Forms.RadioButton()
        Me.rbtnlibrarian = New System.Windows.Forms.RadioButton()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnlogin.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(48, 371)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(125, 31)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER YOUR CREDENTIALS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b3
        Me.GroupBox1.Controls.Add(Me.rbtnmember)
        Me.GroupBox1.Controls.Add(Me.rbtnlibrarian)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(123, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(147, 92)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Post"
        '
        'rbtnmember
        '
        Me.rbtnmember.AutoSize = True
        Me.rbtnmember.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.rbtnmember.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbtnmember.Location = New System.Drawing.Point(10, 63)
        Me.rbtnmember.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.rbtnmember.Name = "rbtnmember"
        Me.rbtnmember.Size = New System.Drawing.Size(93, 23)
        Me.rbtnmember.TabIndex = 1
        Me.rbtnmember.Text = "Member"
        Me.rbtnmember.UseVisualStyleBackColor = False
        '
        'rbtnlibrarian
        '
        Me.rbtnlibrarian.AutoSize = True
        Me.rbtnlibrarian.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.rbtnlibrarian.ForeColor = System.Drawing.Color.Navy
        Me.rbtnlibrarian.Location = New System.Drawing.Point(10, 26)
        Me.rbtnlibrarian.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.rbtnlibrarian.Name = "rbtnlibrarian"
        Me.rbtnlibrarian.Size = New System.Drawing.Size(100, 23)
        Me.rbtnlibrarian.TabIndex = 0
        Me.rbtnlibrarian.Text = "Librarian"
        Me.rbtnlibrarian.UseVisualStyleBackColor = False
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(245, 248)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(164, 25)
        Me.txtusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 305)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(245, 299)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(164, 25)
        Me.txtpassword.TabIndex = 5
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Crimson
        Me.btnexit.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(294, 371)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 31)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.LawnGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(34, 449)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 17)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "forgot password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b3
        Me.ClientSize = New System.Drawing.Size(483, 475)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogin)
        Me.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "frmLogin"
        Me.Text = "LOGIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnlibrarian As RadioButton
    Friend WithEvents txtusername As TextBox
    Friend WithEvents rbtnmember As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnexit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
