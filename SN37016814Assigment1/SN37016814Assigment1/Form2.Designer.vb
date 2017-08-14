<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member_Form
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
        Me.MemberInfo = New System.Windows.Forms.GroupBox()
        Me.textMemNumber = New System.Windows.Forms.TextBox()
        Me.RaceResults = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtOutstandingFee = New System.Windows.Forms.TextBox()
        Me.lblOutstandingfee = New System.Windows.Forms.Label()
        Me.MembershipDate = New System.Windows.Forms.DateTimePicker()
        Me.lblMembershipDate = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.GroupBox()
        Me.rbtFimale = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.Birthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.textLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.textFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMemNumber = New System.Windows.Forms.Label()
        Me.lblTitleMembers = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.MemberInfo.SuspendLayout()
        Me.RaceResults.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gender.SuspendLayout()
        Me.SuspendLayout()
        '
        'MemberInfo
        '
        Me.MemberInfo.Controls.Add(Me.textMemNumber)
        Me.MemberInfo.Controls.Add(Me.RaceResults)
        Me.MemberInfo.Controls.Add(Me.txtOutstandingFee)
        Me.MemberInfo.Controls.Add(Me.lblOutstandingfee)
        Me.MemberInfo.Controls.Add(Me.MembershipDate)
        Me.MemberInfo.Controls.Add(Me.lblMembershipDate)
        Me.MemberInfo.Controls.Add(Me.Gender)
        Me.MemberInfo.Controls.Add(Me.Birthdate)
        Me.MemberInfo.Controls.Add(Me.lblBirthdate)
        Me.MemberInfo.Controls.Add(Me.textLastName)
        Me.MemberInfo.Controls.Add(Me.lblLastName)
        Me.MemberInfo.Controls.Add(Me.textFirstName)
        Me.MemberInfo.Controls.Add(Me.lblFirstName)
        Me.MemberInfo.Controls.Add(Me.lblMemNumber)
        Me.MemberInfo.Location = New System.Drawing.Point(12, 64)
        Me.MemberInfo.Name = "MemberInfo"
        Me.MemberInfo.Size = New System.Drawing.Size(499, 548)
        Me.MemberInfo.TabIndex = 0
        Me.MemberInfo.TabStop = False
        Me.MemberInfo.Text = "Members Information "
        '
        'textMemNumber
        '
        Me.textMemNumber.Location = New System.Drawing.Point(159, 43)
        Me.textMemNumber.Name = "textMemNumber"
        Me.textMemNumber.Size = New System.Drawing.Size(238, 22)
        Me.textMemNumber.TabIndex = 16
        '
        'RaceResults
        '
        Me.RaceResults.Controls.Add(Me.DataGridView1)
        Me.RaceResults.Location = New System.Drawing.Point(22, 366)
        Me.RaceResults.Name = "RaceResults"
        Me.RaceResults.Size = New System.Drawing.Size(375, 157)
        Me.RaceResults.TabIndex = 15
        Me.RaceResults.TabStop = False
        Me.RaceResults.Text = "Race Results"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(363, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Race"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Position"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'txtOutstandingFee
        '
        Me.txtOutstandingFee.Location = New System.Drawing.Point(159, 334)
        Me.txtOutstandingFee.Name = "txtOutstandingFee"
        Me.txtOutstandingFee.Size = New System.Drawing.Size(238, 22)
        Me.txtOutstandingFee.TabIndex = 14
        '
        'lblOutstandingfee
        '
        Me.lblOutstandingfee.AutoSize = True
        Me.lblOutstandingfee.Location = New System.Drawing.Point(22, 334)
        Me.lblOutstandingfee.Name = "lblOutstandingfee"
        Me.lblOutstandingfee.Size = New System.Drawing.Size(121, 17)
        Me.lblOutstandingfee.TabIndex = 13
        Me.lblOutstandingfee.Text = "Outstanding Fee :"
        '
        'MembershipDate
        '
        Me.MembershipDate.Location = New System.Drawing.Point(159, 285)
        Me.MembershipDate.Name = "MembershipDate"
        Me.MembershipDate.Size = New System.Drawing.Size(238, 22)
        Me.MembershipDate.TabIndex = 12
        '
        'lblMembershipDate
        '
        Me.lblMembershipDate.AutoSize = True
        Me.lblMembershipDate.Location = New System.Drawing.Point(19, 285)
        Me.lblMembershipDate.Name = "lblMembershipDate"
        Me.lblMembershipDate.Size = New System.Drawing.Size(131, 17)
        Me.lblMembershipDate.TabIndex = 11
        Me.lblMembershipDate.Text = "Membership Date : "
        '
        'Gender
        '
        Me.Gender.Controls.Add(Me.rbtFimale)
        Me.Gender.Controls.Add(Me.rbtMale)
        Me.Gender.Location = New System.Drawing.Point(159, 198)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(238, 65)
        Me.Gender.TabIndex = 8
        Me.Gender.TabStop = False
        Me.Gender.Text = "Gender "
        '
        'rbtFimale
        '
        Me.rbtFimale.AutoSize = True
        Me.rbtFimale.Location = New System.Drawing.Point(90, 30)
        Me.rbtFimale.Name = "rbtFimale"
        Me.rbtFimale.Size = New System.Drawing.Size(70, 21)
        Me.rbtFimale.TabIndex = 10
        Me.rbtFimale.TabStop = True
        Me.rbtFimale.Text = "Fimale"
        Me.rbtFimale.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Location = New System.Drawing.Point(6, 30)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(59, 21)
        Me.rbtMale.TabIndex = 9
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'Birthdate
        '
        Me.Birthdate.Location = New System.Drawing.Point(159, 160)
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Size = New System.Drawing.Size(238, 22)
        Me.Birthdate.TabIndex = 7
        Me.Birthdate.Value = New Date(2017, 9, 9, 0, 0, 0, 0)
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(62, 165)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(95, 17)
        Me.lblBirthdate.TabIndex = 6
        Me.lblBirthdate.Text = "Date of Birth :"
        '
        'textLastName
        '
        Me.textLastName.Location = New System.Drawing.Point(159, 124)
        Me.textLastName.Name = "textLastName"
        Me.textLastName.Size = New System.Drawing.Size(238, 22)
        Me.textLastName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(73, 127)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(84, 17)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name :"
        '
        'textFirstName
        '
        Me.textFirstName.Location = New System.Drawing.Point(159, 86)
        Me.textFirstName.Name = "textFirstName"
        Me.textFirstName.Size = New System.Drawing.Size(238, 22)
        Me.textFirstName.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(73, 86)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(84, 17)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name :"
        '
        'lblMemNumber
        '
        Me.lblMemNumber.AutoSize = True
        Me.lblMemNumber.Location = New System.Drawing.Point(10, 43)
        Me.lblMemNumber.Name = "lblMemNumber"
        Me.lblMemNumber.Size = New System.Drawing.Size(147, 17)
        Me.lblMemNumber.TabIndex = 0
        Me.lblMemNumber.Text = "Membership Number :"
        '
        'lblTitleMembers
        '
        Me.lblTitleMembers.AutoSize = True
        Me.lblTitleMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMembers.Location = New System.Drawing.Point(140, 25)
        Me.lblTitleMembers.Name = "lblTitleMembers"
        Me.lblTitleMembers.Size = New System.Drawing.Size(431, 32)
        Me.lblTitleMembers.TabIndex = 1
        Me.lblTitleMembers.Text = "Members Management System"
        Me.lblTitleMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(564, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 47)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(564, 214)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(128, 47)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(564, 319)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 47)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'member_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 624)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTitleMembers)
        Me.Controls.Add(Me.MemberInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "member_Form"
        Me.Text = "Members Form"
        Me.MemberInfo.ResumeLayout(False)
        Me.MemberInfo.PerformLayout()
        Me.RaceResults.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gender.ResumeLayout(False)
        Me.Gender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MemberInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Birthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents textLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents textFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMemNumber As System.Windows.Forms.Label
    Friend WithEvents lblTitleMembers As System.Windows.Forms.Label
    Friend WithEvents lblMembershipDate As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFimale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtOutstandingFee As System.Windows.Forms.TextBox
    Friend WithEvents lblOutstandingfee As System.Windows.Forms.Label
    Friend WithEvents MembershipDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RaceResults As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents textMemNumber As System.Windows.Forms.TextBox
End Class
