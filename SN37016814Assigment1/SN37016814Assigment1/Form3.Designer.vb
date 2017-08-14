<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Events_form
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
        Me.lblEvents = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblRegfee = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumlaps = New System.Windows.Forms.Label()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.EventDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtLaps = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEvents
        '
        Me.lblEvents.AutoSize = True
        Me.lblEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvents.Location = New System.Drawing.Point(166, 22)
        Me.lblEvents.Name = "lblEvents"
        Me.lblEvents.Size = New System.Drawing.Size(116, 32)
        Me.lblEvents.TabIndex = 0
        Me.lblEvents.Text = "Events "
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(12, 75)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(93, 17)
        Me.lblEventName.TabIndex = 1
        Me.lblEventName.Text = "Event Name :"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(19, 118)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(86, 17)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Event Date :"
        '
        'lblRegfee
        '
        Me.lblRegfee.AutoSize = True
        Me.lblRegfee.Location = New System.Drawing.Point(54, 156)
        Me.lblRegfee.Name = "lblRegfee"
        Me.lblRegfee.Size = New System.Drawing.Size(44, 17)
        Me.lblRegfee.TabIndex = 3
        Me.lblRegfee.Text = " Fee :"
        Me.lblRegfee.UseWaitCursor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(28, 191)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(70, 17)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 5
        '
        'lblNumlaps
        '
        Me.lblNumlaps.AutoSize = True
        Me.lblNumlaps.Location = New System.Drawing.Point(51, 234)
        Me.lblNumlaps.Name = "lblNumlaps"
        Me.lblNumlaps.Size = New System.Drawing.Size(47, 17)
        Me.lblNumlaps.TabIndex = 6
        Me.lblNumlaps.Text = "Laps :"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(111, 75)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(251, 22)
        Me.txtEventName.TabIndex = 7
        '
        'EventDate
        '
        Me.EventDate.Location = New System.Drawing.Point(111, 118)
        Me.EventDate.Name = "EventDate"
        Me.EventDate.Size = New System.Drawing.Size(251, 22)
        Me.EventDate.TabIndex = 8
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(111, 153)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(251, 22)
        Me.txtFee.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(111, 191)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(251, 22)
        Me.txtLocation.TabIndex = 10
        '
        'txtLaps
        '
        Me.txtLaps.Location = New System.Drawing.Point(111, 234)
        Me.txtLaps.Name = "txtLaps"
        Me.txtLaps.Size = New System.Drawing.Size(251, 22)
        Me.txtLaps.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(111, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 34)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(208, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 34)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 34)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Events_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 354)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLaps)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.EventDate)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.lblNumlaps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblRegfee)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblEvents)
        Me.Name = "Events_form"
        Me.Text = "Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEvents As System.Windows.Forms.Label
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents lblRegfee As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumlaps As System.Windows.Forms.Label
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents EventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtLaps As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
