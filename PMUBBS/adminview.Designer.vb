<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminview
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lblBusesList = New System.Windows.Forms.Label()
        Me.btnSource = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblDispatch = New System.Windows.Forms.Label()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtDispatch = New System.Windows.Forms.TextBox()
        Me.txtArrival = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnAddBus = New System.Windows.Forms.Button()
        Me.btnRemoveBus = New System.Windows.Forms.Button()
        Me.btnUpdateInfo = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"By Bus Number", "By Source", "By Destination"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(368, 126)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(97, 49)
        Me.CheckedListBox1.TabIndex = 0
        '
        'lblBusesList
        '
        Me.lblBusesList.AutoSize = True
        Me.lblBusesList.Location = New System.Drawing.Point(9, 17)
        Me.lblBusesList.Name = "lblBusesList"
        Me.lblBusesList.Size = New System.Drawing.Size(67, 13)
        Me.lblBusesList.TabIndex = 1
        Me.lblBusesList.Text = "List of Buses"
        '
        'btnSource
        '
        Me.btnSource.AutoSize = True
        Me.btnSource.Location = New System.Drawing.Point(136, 18)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(41, 13)
        Me.btnSource.TabIndex = 2
        Me.btnSource.Text = "Source"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(136, 58)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(60, 13)
        Me.lblDestination.TabIndex = 3
        Me.lblDestination.Text = "Destination"
        '
        'lblDispatch
        '
        Me.lblDispatch.AutoSize = True
        Me.lblDispatch.Location = New System.Drawing.Point(258, 18)
        Me.lblDispatch.Name = "lblDispatch"
        Me.lblDispatch.Size = New System.Drawing.Size(75, 13)
        Me.lblDispatch.TabIndex = 4
        Me.lblDispatch.Text = "Dispatch Time"
        '
        'lblArrival
        '
        Me.lblArrival.AutoSize = True
        Me.lblArrival.Location = New System.Drawing.Point(258, 57)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(62, 13)
        Me.lblArrival.TabIndex = 5
        Me.lblArrival.Text = "Arrival Time"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(139, 34)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(100, 20)
        Me.txtSource.TabIndex = 6
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(139, 74)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 20)
        Me.txtDestination.TabIndex = 7
        '
        'txtDispatch
        '
        Me.txtDispatch.Location = New System.Drawing.Point(261, 34)
        Me.txtDispatch.Name = "txtDispatch"
        Me.txtDispatch.Size = New System.Drawing.Size(100, 20)
        Me.txtDispatch.TabIndex = 8
        '
        'txtArrival
        '
        Me.txtArrival.Location = New System.Drawing.Point(261, 73)
        Me.txtArrival.Name = "txtArrival"
        Me.txtArrival.Size = New System.Drawing.Size(100, 20)
        Me.txtArrival.TabIndex = 9
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(378, 181)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 11
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnAddBus
        '
        Me.btnAddBus.Location = New System.Drawing.Point(12, 152)
        Me.btnAddBus.Name = "btnAddBus"
        Me.btnAddBus.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBus.TabIndex = 12
        Me.btnAddBus.Text = "Add Bus"
        Me.btnAddBus.UseVisualStyleBackColor = True
        '
        'btnRemoveBus
        '
        Me.btnRemoveBus.Location = New System.Drawing.Point(93, 152)
        Me.btnRemoveBus.Name = "btnRemoveBus"
        Me.btnRemoveBus.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveBus.TabIndex = 13
        Me.btnRemoveBus.Text = "Remove Bus"
        Me.btnRemoveBus.UseVisualStyleBackColor = True
        '
        'btnUpdateInfo
        '
        Me.btnUpdateInfo.Location = New System.Drawing.Point(174, 152)
        Me.btnUpdateInfo.Name = "btnUpdateInfo"
        Me.btnUpdateInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateInfo.TabIndex = 14
        Me.btnUpdateInfo.Text = "Update Bus"
        Me.btnUpdateInfo.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 15
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(315, 149)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(47, 13)
        Me.lblFilter.TabIndex = 27
        Me.lblFilter.Text = "Filter By:"
        '
        'adminview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 224)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnUpdateInfo)
        Me.Controls.Add(Me.btnRemoveBus)
        Me.Controls.Add(Me.btnAddBus)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.txtArrival)
        Me.Controls.Add(Me.txtDispatch)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblArrival)
        Me.Controls.Add(Me.lblDispatch)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.lblBusesList)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "adminview"
        Me.Text = "adminview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents lblBusesList As Label
    Friend WithEvents btnSource As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblDispatch As Label
    Friend WithEvents lblArrival As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtDispatch As TextBox
    Friend WithEvents txtArrival As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnAddBus As Button
    Friend WithEvents btnRemoveBus As Button
    Friend WithEvents btnUpdateInfo As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblFilter As Label
End Class
