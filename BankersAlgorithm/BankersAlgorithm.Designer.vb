<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankersAlgorithm
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtMax_2 = New System.Windows.Forms.TextBox()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResources = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtProcess_1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProcess_2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoldTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProcess_3 = New System.Windows.Forms.TextBox()
        Me.txtMax_1 = New System.Windows.Forms.TextBox()
        Me.txtMax_3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHold_1 = New System.Windows.Forms.TextBox()
        Me.txtHold_2 = New System.Windows.Forms.TextBox()
        Me.txtHold_3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNeed_1 = New System.Windows.Forms.TextBox()
        Me.txtNeed_2 = New System.Windows.Forms.TextBox()
        Me.txtNeed_3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(464, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(418, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 18)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "="
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(37, 234)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 32)
        Me.btnStart.TabIndex = 20
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtMax_2
        '
        Me.txtMax_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax_2.Location = New System.Drawing.Point(171, 92)
        Me.txtMax_2.Name = "txtMax_2"
        Me.txtMax_2.Size = New System.Drawing.Size(100, 27)
        Me.txtMax_2.TabIndex = 6
        Me.txtMax_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAvailable
        '
        Me.txtAvailable.BackColor = System.Drawing.Color.Coral
        Me.txtAvailable.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailable.Location = New System.Drawing.Point(171, 202)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.ReadOnly = True
        Me.txtAvailable.Size = New System.Drawing.Size(100, 27)
        Me.txtAvailable.TabIndex = 19
        Me.txtAvailable.TabStop = False
        Me.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(418, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 18)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Available:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process"
        '
        'txtResources
        '
        Me.txtResources.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResources.Location = New System.Drawing.Point(37, 202)
        Me.txtResources.Name = "txtResources"
        Me.txtResources.Size = New System.Drawing.Size(100, 27)
        Me.txtResources.TabIndex = 17
        Me.txtResources.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(418, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 18)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Resources:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(7, 290)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(429, 108)
        Me.lblStatus.TabIndex = 51
        Me.lblStatus.Text = "RESULT"
        Me.lblStatus.Visible = False
        '
        'txtProcess_1
        '
        Me.txtProcess_1.BackColor = System.Drawing.Color.Chocolate
        Me.txtProcess_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess_1.Location = New System.Drawing.Point(37, 57)
        Me.txtProcess_1.Name = "txtProcess_1"
        Me.txtProcess_1.ReadOnly = True
        Me.txtProcess_1.Size = New System.Drawing.Size(100, 27)
        Me.txtProcess_1.TabIndex = 1
        Me.txtProcess_1.TabStop = False
        Me.txtProcess_1.Text = "A"
        Me.txtProcess_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(284, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 18)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "-"
        '
        'txtProcess_2
        '
        Me.txtProcess_2.BackColor = System.Drawing.Color.Chocolate
        Me.txtProcess_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess_2.Location = New System.Drawing.Point(37, 92)
        Me.txtProcess_2.Name = "txtProcess_2"
        Me.txtProcess_2.ReadOnly = True
        Me.txtProcess_2.Size = New System.Drawing.Size(100, 27)
        Me.txtProcess_2.TabIndex = 2
        Me.txtProcess_2.TabStop = False
        Me.txtProcess_2.Text = "B"
        Me.txtProcess_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(284, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 18)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Max"
        '
        'txtHoldTotal
        '
        Me.txtHoldTotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtHoldTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoldTotal.Location = New System.Drawing.Point(307, 162)
        Me.txtHoldTotal.Name = "txtHoldTotal"
        Me.txtHoldTotal.ReadOnly = True
        Me.txtHoldTotal.Size = New System.Drawing.Size(100, 27)
        Me.txtHoldTotal.TabIndex = 39
        Me.txtHoldTotal.TabStop = False
        Me.txtHoldTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.txtMax_2)
        Me.GroupBox1.Controls.Add(Me.txtAvailable)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtResources)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProcess_1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtProcess_2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtProcess_3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHoldTotal)
        Me.GroupBox1.Controls.Add(Me.txtMax_1)
        Me.GroupBox1.Controls.Add(Me.txtMax_3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHold_1)
        Me.GroupBox1.Controls.Add(Me.txtHold_2)
        Me.GroupBox1.Controls.Add(Me.txtHold_3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNeed_1)
        Me.GroupBox1.Controls.Add(Me.txtNeed_2)
        Me.GroupBox1.Controls.Add(Me.txtNeed_3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 281)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(284, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 18)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "-"
        '
        'txtProcess_3
        '
        Me.txtProcess_3.BackColor = System.Drawing.Color.Chocolate
        Me.txtProcess_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess_3.Location = New System.Drawing.Point(37, 130)
        Me.txtProcess_3.Name = "txtProcess_3"
        Me.txtProcess_3.ReadOnly = True
        Me.txtProcess_3.Size = New System.Drawing.Size(100, 27)
        Me.txtProcess_3.TabIndex = 3
        Me.txtProcess_3.TabStop = False
        Me.txtProcess_3.Text = "C"
        Me.txtProcess_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMax_1
        '
        Me.txtMax_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax_1.Location = New System.Drawing.Point(171, 57)
        Me.txtMax_1.Name = "txtMax_1"
        Me.txtMax_1.Size = New System.Drawing.Size(100, 27)
        Me.txtMax_1.TabIndex = 5
        Me.txtMax_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMax_3
        '
        Me.txtMax_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax_3.Location = New System.Drawing.Point(171, 130)
        Me.txtMax_3.Name = "txtMax_3"
        Me.txtMax_3.Size = New System.Drawing.Size(100, 27)
        Me.txtMax_3.TabIndex = 7
        Me.txtMax_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hold"
        '
        'txtHold_1
        '
        Me.txtHold_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHold_1.Location = New System.Drawing.Point(307, 57)
        Me.txtHold_1.Name = "txtHold_1"
        Me.txtHold_1.Size = New System.Drawing.Size(100, 27)
        Me.txtHold_1.TabIndex = 9
        Me.txtHold_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHold_2
        '
        Me.txtHold_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHold_2.Location = New System.Drawing.Point(307, 92)
        Me.txtHold_2.Name = "txtHold_2"
        Me.txtHold_2.Size = New System.Drawing.Size(100, 27)
        Me.txtHold_2.TabIndex = 10
        Me.txtHold_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHold_3
        '
        Me.txtHold_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHold_3.Location = New System.Drawing.Point(307, 130)
        Me.txtHold_3.Name = "txtHold_3"
        Me.txtHold_3.Size = New System.Drawing.Size(100, 27)
        Me.txtHold_3.TabIndex = 11
        Me.txtHold_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(471, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Need"
        '
        'txtNeed_1
        '
        Me.txtNeed_1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNeed_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeed_1.Location = New System.Drawing.Point(441, 57)
        Me.txtNeed_1.Name = "txtNeed_1"
        Me.txtNeed_1.ReadOnly = True
        Me.txtNeed_1.Size = New System.Drawing.Size(100, 27)
        Me.txtNeed_1.TabIndex = 13
        Me.txtNeed_1.TabStop = False
        Me.txtNeed_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNeed_2
        '
        Me.txtNeed_2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNeed_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeed_2.Location = New System.Drawing.Point(441, 92)
        Me.txtNeed_2.Name = "txtNeed_2"
        Me.txtNeed_2.ReadOnly = True
        Me.txtNeed_2.Size = New System.Drawing.Size(100, 27)
        Me.txtNeed_2.TabIndex = 14
        Me.txtNeed_2.TabStop = False
        Me.txtNeed_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNeed_3
        '
        Me.txtNeed_3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNeed_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeed_3.Location = New System.Drawing.Point(441, 130)
        Me.txtNeed_3.Name = "txtNeed_3"
        Me.txtNeed_3.ReadOnly = True
        Me.txtNeed_3.Size = New System.Drawing.Size(100, 27)
        Me.txtNeed_3.TabIndex = 15
        Me.txtNeed_3.TabStop = False
        Me.txtNeed_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(479, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BankersAlgorithm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 448)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BankersAlgorithm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banker's Algorithm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtMax_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResources As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtProcess_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProcess_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHoldTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProcess_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMax_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMax_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHold_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHold_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHold_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNeed_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNeed_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNeed_3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
