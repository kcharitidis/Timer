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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passedSecondsLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.passedMinutesLabel = New System.Windows.Forms.Label()
        Me.passedHoursLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctimehourLabel = New System.Windows.Forms.Label()
        Me.ctimeMinuteLabel = New System.Windows.Forms.Label()
        Me.ctimeSecondLabel = New System.Windows.Forms.Label()
        Me.stimeHourLabel = New System.Windows.Forms.Label()
        Me.stimeMinuteLabel = New System.Windows.Forms.Label()
        Me.stimeSecondLabel = New System.Windows.Forms.Label()
        Me.etimehourLabel = New System.Windows.Forms.Label()
        Me.etimeMinuteLabel = New System.Windows.Forms.Label()
        Me.etimeSecondLabel = New System.Windows.Forms.Label()
        Me.ltimeHourLabel = New System.Windows.Forms.Label()
        Me.ltimeMinuteLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ltimeSecondLabel = New System.Windows.Forms.Label()
        Me.secondspassedLabel = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.starthourtb = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.startmintb = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.whours = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Time:"
        '
        'passedSecondsLabel
        '
        Me.passedSecondsLabel.AutoSize = True
        Me.passedSecondsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.passedSecondsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passedSecondsLabel.Location = New System.Drawing.Point(239, 118)
        Me.passedSecondsLabel.Name = "passedSecondsLabel"
        Me.passedSecondsLabel.Size = New System.Drawing.Size(26, 17)
        Me.passedSecondsLabel.TabIndex = 1
        Me.passedSecondsLabel.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Time Passed:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'passedMinutesLabel
        '
        Me.passedMinutesLabel.AutoSize = True
        Me.passedMinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.passedMinutesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passedMinutesLabel.Location = New System.Drawing.Point(190, 118)
        Me.passedMinutesLabel.Name = "passedMinutesLabel"
        Me.passedMinutesLabel.Size = New System.Drawing.Size(26, 17)
        Me.passedMinutesLabel.TabIndex = 6
        Me.passedMinutesLabel.Text = "00"
        '
        'passedHoursLabel
        '
        Me.passedHoursLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passedHoursLabel.AutoSize = True
        Me.passedHoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.passedHoursLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passedHoursLabel.Location = New System.Drawing.Point(145, 118)
        Me.passedHoursLabel.Name = "passedHoursLabel"
        Me.passedHoursLabel.Size = New System.Drawing.Size(26, 17)
        Me.passedHoursLabel.TabIndex = 7
        Me.passedHoursLabel.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Current Time:"
        '
        'ctimehourLabel
        '
        Me.ctimehourLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctimehourLabel.AutoSize = True
        Me.ctimehourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ctimehourLabel.Location = New System.Drawing.Point(145, 94)
        Me.ctimehourLabel.Name = "ctimehourLabel"
        Me.ctimehourLabel.Size = New System.Drawing.Size(26, 17)
        Me.ctimehourLabel.TabIndex = 11
        Me.ctimehourLabel.Text = "00"
        '
        'ctimeMinuteLabel
        '
        Me.ctimeMinuteLabel.AutoSize = True
        Me.ctimeMinuteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ctimeMinuteLabel.Location = New System.Drawing.Point(190, 94)
        Me.ctimeMinuteLabel.Name = "ctimeMinuteLabel"
        Me.ctimeMinuteLabel.Size = New System.Drawing.Size(26, 17)
        Me.ctimeMinuteLabel.TabIndex = 10
        Me.ctimeMinuteLabel.Text = "00"
        '
        'ctimeSecondLabel
        '
        Me.ctimeSecondLabel.AutoSize = True
        Me.ctimeSecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ctimeSecondLabel.Location = New System.Drawing.Point(239, 94)
        Me.ctimeSecondLabel.Name = "ctimeSecondLabel"
        Me.ctimeSecondLabel.Size = New System.Drawing.Size(26, 17)
        Me.ctimeSecondLabel.TabIndex = 9
        Me.ctimeSecondLabel.Text = "00"
        '
        'stimeHourLabel
        '
        Me.stimeHourLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stimeHourLabel.AutoSize = True
        Me.stimeHourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.stimeHourLabel.Location = New System.Drawing.Point(145, 46)
        Me.stimeHourLabel.Name = "stimeHourLabel"
        Me.stimeHourLabel.Size = New System.Drawing.Size(26, 17)
        Me.stimeHourLabel.TabIndex = 14
        Me.stimeHourLabel.Text = "00"
        '
        'stimeMinuteLabel
        '
        Me.stimeMinuteLabel.AutoSize = True
        Me.stimeMinuteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.stimeMinuteLabel.Location = New System.Drawing.Point(190, 46)
        Me.stimeMinuteLabel.Name = "stimeMinuteLabel"
        Me.stimeMinuteLabel.Size = New System.Drawing.Size(26, 17)
        Me.stimeMinuteLabel.TabIndex = 13
        Me.stimeMinuteLabel.Text = "00"
        '
        'stimeSecondLabel
        '
        Me.stimeSecondLabel.AutoSize = True
        Me.stimeSecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.stimeSecondLabel.Location = New System.Drawing.Point(239, 46)
        Me.stimeSecondLabel.Name = "stimeSecondLabel"
        Me.stimeSecondLabel.Size = New System.Drawing.Size(26, 17)
        Me.stimeSecondLabel.TabIndex = 12
        Me.stimeSecondLabel.Text = "00"
        '
        'etimehourLabel
        '
        Me.etimehourLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etimehourLabel.AutoSize = True
        Me.etimehourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.etimehourLabel.Location = New System.Drawing.Point(145, 70)
        Me.etimehourLabel.Name = "etimehourLabel"
        Me.etimehourLabel.Size = New System.Drawing.Size(26, 17)
        Me.etimehourLabel.TabIndex = 17
        Me.etimehourLabel.Text = "00"
        '
        'etimeMinuteLabel
        '
        Me.etimeMinuteLabel.AutoSize = True
        Me.etimeMinuteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.etimeMinuteLabel.Location = New System.Drawing.Point(190, 70)
        Me.etimeMinuteLabel.Name = "etimeMinuteLabel"
        Me.etimeMinuteLabel.Size = New System.Drawing.Size(26, 17)
        Me.etimeMinuteLabel.TabIndex = 16
        Me.etimeMinuteLabel.Text = "00"
        '
        'etimeSecondLabel
        '
        Me.etimeSecondLabel.AutoSize = True
        Me.etimeSecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.etimeSecondLabel.Location = New System.Drawing.Point(239, 70)
        Me.etimeSecondLabel.Name = "etimeSecondLabel"
        Me.etimeSecondLabel.Size = New System.Drawing.Size(26, 17)
        Me.etimeSecondLabel.TabIndex = 15
        Me.etimeSecondLabel.Text = "00"
        '
        'ltimeHourLabel
        '
        Me.ltimeHourLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ltimeHourLabel.AutoSize = True
        Me.ltimeHourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ltimeHourLabel.ForeColor = System.Drawing.Color.Red
        Me.ltimeHourLabel.Location = New System.Drawing.Point(145, 142)
        Me.ltimeHourLabel.Name = "ltimeHourLabel"
        Me.ltimeHourLabel.Size = New System.Drawing.Size(26, 17)
        Me.ltimeHourLabel.TabIndex = 21
        Me.ltimeHourLabel.Text = "00"
        '
        'ltimeMinuteLabel
        '
        Me.ltimeMinuteLabel.AutoSize = True
        Me.ltimeMinuteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ltimeMinuteLabel.ForeColor = System.Drawing.Color.Red
        Me.ltimeMinuteLabel.Location = New System.Drawing.Point(190, 142)
        Me.ltimeMinuteLabel.Name = "ltimeMinuteLabel"
        Me.ltimeMinuteLabel.Size = New System.Drawing.Size(26, 17)
        Me.ltimeMinuteLabel.TabIndex = 20
        Me.ltimeMinuteLabel.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Time Left:"
        '
        'ltimeSecondLabel
        '
        Me.ltimeSecondLabel.AutoSize = True
        Me.ltimeSecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ltimeSecondLabel.ForeColor = System.Drawing.Color.Red
        Me.ltimeSecondLabel.Location = New System.Drawing.Point(239, 142)
        Me.ltimeSecondLabel.Name = "ltimeSecondLabel"
        Me.ltimeSecondLabel.Size = New System.Drawing.Size(26, 17)
        Me.ltimeSecondLabel.TabIndex = 18
        Me.ltimeSecondLabel.Text = "00"
        '
        'secondspassedLabel
        '
        Me.secondspassedLabel.AutoSize = True
        Me.secondspassedLabel.BackColor = System.Drawing.Color.Transparent
        Me.secondspassedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.secondspassedLabel.Location = New System.Drawing.Point(145, 177)
        Me.secondspassedLabel.Name = "secondspassedLabel"
        Me.secondspassedLabel.Size = New System.Drawing.Size(0, 18)
        Me.secondspassedLabel.TabIndex = 22
        Me.secondspassedLabel.UseMnemonic = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(71, 174)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(194, 23)
        Me.ProgressBar1.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(175, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(222, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(175, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(220, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.Location = New System.Drawing.Point(175, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(222, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(175, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = ":"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.starthourtb, Me.ToolStripLabel1, Me.startmintb, Me.ToolStripSeparator1, Me.ToolStripLabel3, Me.whours, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(329, 26)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 23)
        Me.ToolStripLabel2.Text = "Start Time:"
        '
        'starthourtb
        '
        Me.starthourtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.starthourtb.MaxLength = 100
        Me.starthourtb.Name = "starthourtb"
        Me.starthourtb.Size = New System.Drawing.Size(40, 26)
        Me.starthourtb.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(10, 23)
        Me.ToolStripLabel1.Text = ":"
        '
        'startmintb
        '
        Me.startmintb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.startmintb.Name = "startmintb"
        Me.startmintb.Size = New System.Drawing.Size(40, 26)
        Me.startmintb.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(76, 23)
        Me.ToolStripLabel3.Text = "Work Hours: "
        '
        'whours
        '
        Me.whours.Name = "whours"
        Me.whours.Size = New System.Drawing.Size(40, 26)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.ToolStripButton1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripButton1.Text = "Run"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 226)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.secondspassedLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ltimeHourLabel)
        Me.Controls.Add(Me.ltimeMinuteLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ltimeSecondLabel)
        Me.Controls.Add(Me.etimehourLabel)
        Me.Controls.Add(Me.etimeMinuteLabel)
        Me.Controls.Add(Me.etimeSecondLabel)
        Me.Controls.Add(Me.stimeHourLabel)
        Me.Controls.Add(Me.stimeMinuteLabel)
        Me.Controls.Add(Me.stimeSecondLabel)
        Me.Controls.Add(Me.ctimehourLabel)
        Me.Controls.Add(Me.ctimeMinuteLabel)
        Me.Controls.Add(Me.ctimeSecondLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passedHoursLabel)
        Me.Controls.Add(Me.passedMinutesLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passedSecondsLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Timer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passedSecondsLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents passedMinutesLabel As System.Windows.Forms.Label
    Friend WithEvents passedHoursLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ctimehourLabel As System.Windows.Forms.Label
    Friend WithEvents ctimeMinuteLabel As System.Windows.Forms.Label
    Friend WithEvents ctimeSecondLabel As System.Windows.Forms.Label
    Friend WithEvents stimeHourLabel As System.Windows.Forms.Label
    Friend WithEvents stimeMinuteLabel As System.Windows.Forms.Label
    Friend WithEvents stimeSecondLabel As System.Windows.Forms.Label
    Friend WithEvents etimehourLabel As System.Windows.Forms.Label
    Friend WithEvents etimeMinuteLabel As System.Windows.Forms.Label
    Friend WithEvents etimeSecondLabel As System.Windows.Forms.Label
    Friend WithEvents ltimeHourLabel As System.Windows.Forms.Label
    Friend WithEvents ltimeMinuteLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ltimeSecondLabel As System.Windows.Forms.Label
    Friend WithEvents secondspassedLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents starthourtb As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents startmintb As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents whours As System.Windows.Forms.ToolStripTextBox

End Class
