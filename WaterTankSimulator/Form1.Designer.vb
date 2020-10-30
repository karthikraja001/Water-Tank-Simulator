<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.startFlow = New System.Windows.Forms.Button()
        Me.tank = New System.Windows.Forms.Timer(Me.components)
        Me.tankPercent = New System.Windows.Forms.ProgressBar()
        Me.textOnly = New System.Windows.Forms.Label()
        Me.stopFlow = New System.Windows.Forms.Button()
        Me.tube1 = New System.Windows.Forms.PictureBox()
        Me.tube2 = New System.Windows.Forms.PictureBox()
        Me.waterHatch = New System.Windows.Forms.PictureBox()
        Me.startMotor = New System.Windows.Forms.Button()
        Me.stopMotor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.motor = New System.Windows.Forms.Timer(Me.components)
        Me.tankCapacity = New System.Windows.Forms.Label()
        Me.caption = New System.Windows.Forms.Label()
        Me.percent = New System.Windows.Forms.Label()
        Me.head = New System.Windows.Forms.Button()
        CType(Me.tube1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tube2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.waterHatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'startFlow
        '
        Me.startFlow.Cursor = System.Windows.Forms.Cursors.Default
        Me.startFlow.Location = New System.Drawing.Point(292, 506)
        Me.startFlow.Name = "startFlow"
        Me.startFlow.Size = New System.Drawing.Size(157, 48)
        Me.startFlow.TabIndex = 3
        Me.startFlow.Text = "Open Pipe"
        Me.startFlow.UseVisualStyleBackColor = True
        '
        'tank
        '
        Me.tank.Enabled = True
        Me.tank.Interval = 500
        '
        'tankPercent
        '
        Me.tankPercent.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tankPercent.Location = New System.Drawing.Point(106, 441)
        Me.tankPercent.Name = "tankPercent"
        Me.tankPercent.Size = New System.Drawing.Size(343, 35)
        Me.tankPercent.TabIndex = 4
        Me.tankPercent.Value = 100
        '
        'textOnly
        '
        Me.textOnly.AutoSize = True
        Me.textOnly.Location = New System.Drawing.Point(232, 403)
        Me.textOnly.Name = "textOnly"
        Me.textOnly.Size = New System.Drawing.Size(93, 20)
        Me.textOnly.TabIndex = 5
        Me.textOnly.Text = "Water Level"
        '
        'stopFlow
        '
        Me.stopFlow.Location = New System.Drawing.Point(106, 500)
        Me.stopFlow.Name = "stopFlow"
        Me.stopFlow.Size = New System.Drawing.Size(157, 54)
        Me.stopFlow.TabIndex = 6
        Me.stopFlow.Text = "Close Pipe"
        Me.stopFlow.UseVisualStyleBackColor = True
        '
        'tube1
        '
        Me.tube1.BackColor = System.Drawing.SystemColors.GrayText
        Me.tube1.Location = New System.Drawing.Point(446, 197)
        Me.tube1.Name = "tube1"
        Me.tube1.Size = New System.Drawing.Size(403, 31)
        Me.tube1.TabIndex = 7
        Me.tube1.TabStop = False
        '
        'tube2
        '
        Me.tube2.BackColor = System.Drawing.SystemColors.GrayText
        Me.tube2.Location = New System.Drawing.Point(816, 197)
        Me.tube2.Name = "tube2"
        Me.tube2.Size = New System.Drawing.Size(33, 357)
        Me.tube2.TabIndex = 7
        Me.tube2.TabStop = False
        '
        'waterHatch
        '
        Me.waterHatch.BackColor = System.Drawing.SystemColors.HotTrack
        Me.waterHatch.Location = New System.Drawing.Point(816, 533)
        Me.waterHatch.Name = "waterHatch"
        Me.waterHatch.Size = New System.Drawing.Size(224, 119)
        Me.waterHatch.TabIndex = 8
        Me.waterHatch.TabStop = False
        '
        'startMotor
        '
        Me.startMotor.Location = New System.Drawing.Point(880, 428)
        Me.startMotor.Name = "startMotor"
        Me.startMotor.Size = New System.Drawing.Size(92, 48)
        Me.startMotor.TabIndex = 9
        Me.startMotor.Text = "Start Motor "
        Me.startMotor.UseVisualStyleBackColor = True
        '
        'stopMotor
        '
        Me.stopMotor.Location = New System.Drawing.Point(1014, 428)
        Me.stopMotor.Name = "stopMotor"
        Me.stopMotor.Size = New System.Drawing.Size(92, 50)
        Me.stopMotor.TabIndex = 9
        Me.stopMotor.Text = "Stop Motor"
        Me.stopMotor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Location = New System.Drawing.Point(106, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 300)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(106, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(343, 30)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'motor
        '
        Me.motor.Enabled = True
        Me.motor.Interval = 500
        '
        'tankCapacity
        '
        Me.tankCapacity.AutoSize = True
        Me.tankCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tankCapacity.Location = New System.Drawing.Point(892, 140)
        Me.tankCapacity.Name = "tankCapacity"
        Me.tankCapacity.Size = New System.Drawing.Size(69, 37)
        Me.tankCapacity.TabIndex = 11
        Me.tankCapacity.Text = "100"
        '
        'caption
        '
        Me.caption.AutoSize = True
        Me.caption.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.caption.Location = New System.Drawing.Point(455, 140)
        Me.caption.Name = "caption"
        Me.caption.Size = New System.Drawing.Size(431, 37)
        Me.caption.TabIndex = 12
        Me.caption.Text = "Water Availablity in the tank:-"
        '
        'percent
        '
        Me.percent.AutoSize = True
        Me.percent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.percent.Location = New System.Drawing.Point(958, 140)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(45, 37)
        Me.percent.TabIndex = 11
        Me.percent.Text = "%"
        '
        'head
        '
        Me.head.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.head.Location = New System.Drawing.Point(453, 13)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(490, 54)
        Me.head.TabIndex = 13
        Me.head.Text = "Water Tank Simulator"
        Me.head.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 664)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.caption)
        Me.Controls.Add(Me.percent)
        Me.Controls.Add(Me.tankCapacity)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.stopMotor)
        Me.Controls.Add(Me.startMotor)
        Me.Controls.Add(Me.waterHatch)
        Me.Controls.Add(Me.tube2)
        Me.Controls.Add(Me.tube1)
        Me.Controls.Add(Me.stopFlow)
        Me.Controls.Add(Me.textOnly)
        Me.Controls.Add(Me.tankPercent)
        Me.Controls.Add(Me.startFlow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tube1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tube2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.waterHatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startFlow As Button
    Friend WithEvents tank As Timer
    Friend WithEvents tankPercent As ProgressBar
    Friend WithEvents textOnly As Label
    Friend WithEvents stopFlow As Button
    Friend WithEvents tube1 As PictureBox
    Friend WithEvents tube2 As PictureBox
    Friend WithEvents waterHatch As PictureBox
    Friend WithEvents startMotor As Button
    Friend WithEvents stopMotor As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents motor As Timer
    Friend WithEvents tankCapacity As Label
    Friend WithEvents caption As Label
    Friend WithEvents percent As Label
    Friend WithEvents head As Button
End Class
