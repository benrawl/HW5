<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevConferenceRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevConferenceRegistration))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNumberOfEmployees = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpboxPrevAttended = New System.Windows.Forms.GroupBox()
        Me.txtNumberOfEmployees = New System.Windows.Forms.TextBox()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxPrevAttended.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblTitle.Location = New System.Drawing.Point(34, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Company Developer Conference Signup"
        '
        'lblNumberOfEmployees
        '
        Me.lblNumberOfEmployees.AutoSize = True
        Me.lblNumberOfEmployees.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfEmployees.Location = New System.Drawing.Point(88, 116)
        Me.lblNumberOfEmployees.Name = "lblNumberOfEmployees"
        Me.lblNumberOfEmployees.Size = New System.Drawing.Size(102, 16)
        Me.lblNumberOfEmployees.TabIndex = 1
        Me.lblNumberOfEmployees.Text = "# Of Employees:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 293)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'grpboxPrevAttended
        '
        Me.grpboxPrevAttended.Controls.Add(Me.radNo)
        Me.grpboxPrevAttended.Controls.Add(Me.radYes)
        Me.grpboxPrevAttended.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxPrevAttended.Location = New System.Drawing.Point(91, 160)
        Me.grpboxPrevAttended.Name = "grpboxPrevAttended"
        Me.grpboxPrevAttended.Size = New System.Drawing.Size(169, 92)
        Me.grpboxPrevAttended.TabIndex = 3
        Me.grpboxPrevAttended.TabStop = False
        Me.grpboxPrevAttended.Text = "Previously Attended?"
        '
        'txtNumberOfEmployees
        '
        Me.txtNumberOfEmployees.Location = New System.Drawing.Point(292, 113)
        Me.txtNumberOfEmployees.Name = "txtNumberOfEmployees"
        Me.txtNumberOfEmployees.Size = New System.Drawing.Size(20, 22)
        Me.txtNumberOfEmployees.TabIndex = 4
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radYes.Location = New System.Drawing.Point(15, 44)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(49, 20)
        Me.radYes.TabIndex = 0
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNo.Location = New System.Drawing.Point(15, 68)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(46, 20)
        Me.radNo.TabIndex = 5
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(271, 174)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 201)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Red
        Me.lblTotalCost.Location = New System.Drawing.Point(156, 61)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 16)
        Me.lblTotalCost.TabIndex = 8
        '
        'frmDevConferenceRegistration
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberOfEmployees)
        Me.Controls.Add(Me.grpboxPrevAttended)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNumberOfEmployees)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDevConferenceRegistration"
        Me.Text = "App Developer's Conference Registration For Companies"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxPrevAttended.ResumeLayout(False)
        Me.grpboxPrevAttended.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNumberOfEmployees As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpboxPrevAttended As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents txtNumberOfEmployees As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As Label
End Class
