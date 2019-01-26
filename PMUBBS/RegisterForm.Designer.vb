<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSignup
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
        Me.btnRegister2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPasswordNEW = New System.Windows.Forms.Label()
        Me.lblUsernameNEW = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegister2
        '
        Me.btnRegister2.Location = New System.Drawing.Point(102, 168)
        Me.btnRegister2.Name = "btnRegister2"
        Me.btnRegister2.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister2.TabIndex = 11
        Me.btnRegister2.Text = "Register"
        Me.btnRegister2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(123, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'lblPasswordNEW
        '
        Me.lblPasswordNEW.AutoSize = True
        Me.lblPasswordNEW.Location = New System.Drawing.Point(35, 107)
        Me.lblPasswordNEW.Name = "lblPasswordNEW"
        Me.lblPasswordNEW.Size = New System.Drawing.Size(82, 13)
        Me.lblPasswordNEW.TabIndex = 8
        Me.lblPasswordNEW.Text = "NEW Password"
        '
        'lblUsernameNEW
        '
        Me.lblUsernameNEW.AutoSize = True
        Me.lblUsernameNEW.Location = New System.Drawing.Point(33, 71)
        Me.lblUsernameNEW.Name = "lblUsernameNEW"
        Me.lblUsernameNEW.Size = New System.Drawing.Size(84, 13)
        Me.lblUsernameNEW.TabIndex = 7
        Me.lblUsernameNEW.Text = "NEW Username"
        '
        'formSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(Me.btnRegister2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPasswordNEW)
        Me.Controls.Add(Me.lblUsernameNEW)
        Me.Name = "formSignup"
        Me.Text = "Sign up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegister2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPasswordNEW As Label
    Friend WithEvents lblUsernameNEW As Label
End Class
