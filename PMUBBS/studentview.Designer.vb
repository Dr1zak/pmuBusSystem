<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentview
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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnUnRegister = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.txtArrival = New System.Windows.Forms.TextBox()
        Me.txtDispatch = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.lblDispatch = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.btnSource = New System.Windows.Forms.Label()
        Me.lblBusesList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(269, 156)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(47, 13)
        Me.lblFilter.TabIndex = 41
        Me.lblFilter.Text = "Filter By:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 40
        '
        'btnUnRegister
        '
        Me.btnUnRegister.Location = New System.Drawing.Point(102, 165)
        Me.btnUnRegister.Name = "btnUnRegister"
        Me.btnUnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnUnRegister.TabIndex = 39
        Me.btnUnRegister.Text = "Un-Register"
        Me.btnUnRegister.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(14, 165)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 38
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(332, 194)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 37
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"By Bus Number", "By Source", "By Destination"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(322, 139)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(97, 49)
        Me.CheckedListBox1.TabIndex = 36
        '
        'txtArrival
        '
        Me.txtArrival.Location = New System.Drawing.Point(276, 70)
        Me.txtArrival.Name = "txtArrival"
        Me.txtArrival.Size = New System.Drawing.Size(100, 20)
        Me.txtArrival.TabIndex = 35
        '
        'txtDispatch
        '
        Me.txtDispatch.Location = New System.Drawing.Point(276, 32)
        Me.txtDispatch.Name = "txtDispatch"
        Me.txtDispatch.Size = New System.Drawing.Size(100, 20)
        Me.txtDispatch.TabIndex = 34
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(141, 71)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 20)
        Me.txtDestination.TabIndex = 33
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(141, 32)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(100, 20)
        Me.txtSource.TabIndex = 32
        '
        'lblArrival
        '
        Me.lblArrival.AutoSize = True
        Me.lblArrival.Location = New System.Drawing.Point(273, 54)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(62, 13)
        Me.lblArrival.TabIndex = 31
        Me.lblArrival.Text = "Arrival Time"
        '
        'lblDispatch
        '
        Me.lblDispatch.AutoSize = True
        Me.lblDispatch.Location = New System.Drawing.Point(273, 16)
        Me.lblDispatch.Name = "lblDispatch"
        Me.lblDispatch.Size = New System.Drawing.Size(75, 13)
        Me.lblDispatch.TabIndex = 30
        Me.lblDispatch.Text = "Dispatch Time"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(138, 55)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(60, 13)
        Me.lblDestination.TabIndex = 29
        Me.lblDestination.Text = "Destination"
        '
        'btnSource
        '
        Me.btnSource.AutoSize = True
        Me.btnSource.Location = New System.Drawing.Point(138, 16)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(41, 13)
        Me.btnSource.TabIndex = 28
        Me.btnSource.Text = "Source"
        '
        'lblBusesList
        '
        Me.lblBusesList.AutoSize = True
        Me.lblBusesList.Location = New System.Drawing.Point(11, 15)
        Me.lblBusesList.Name = "lblBusesList"
        Me.lblBusesList.Size = New System.Drawing.Size(67, 13)
        Me.lblBusesList.TabIndex = 27
        Me.lblBusesList.Text = "List of Buses"
        '
        'studentview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 239)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnUnRegister)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.txtArrival)
        Me.Controls.Add(Me.txtDispatch)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblArrival)
        Me.Controls.Add(Me.lblDispatch)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.lblBusesList)
        Me.Name = "studentview"
        Me.Text = "studentview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilter As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnUnRegister As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents txtArrival As TextBox
    Friend WithEvents txtDispatch As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtSource As TextBox
    Friend WithEvents lblArrival As Label
    Friend WithEvents lblDispatch As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents btnSource As Label
    Friend WithEvents lblBusesList As Label
End Class
