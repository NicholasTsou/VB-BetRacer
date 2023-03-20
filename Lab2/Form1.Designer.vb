<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_char5 = New System.Windows.Forms.RadioButton()
        Me.rb_char2 = New System.Windows.Forms.RadioButton()
        Me.rb_char3 = New System.Windows.Forms.RadioButton()
        Me.rb_char4 = New System.Windows.Forms.RadioButton()
        Me.rb_char1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_startmoney = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tb_placebet = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tb_moneyleft = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.pb_2 = New System.Windows.Forms.ProgressBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pb_5 = New System.Windows.Forms.ProgressBar()
        Me.pb_4 = New System.Windows.Forms.ProgressBar()
        Me.pb_3 = New System.Windows.Forms.ProgressBar()
        Me.pb_1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_standing2 = New System.Windows.Forms.Label()
        Me.lbl_standing5 = New System.Windows.Forms.Label()
        Me.lbl_standing4 = New System.Windows.Forms.Label()
        Me.lbl_standing3 = New System.Windows.Forms.Label()
        Me.lbl_standing1 = New System.Windows.Forms.Label()
        Me.lbl_round = New System.Windows.Forms.Label()
        Me.btn_placebet = New System.Windows.Forms.Button()
        Me.btn_startrace = New System.Windows.Forms.Button()
        Me.btn_nextround = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rb_char5)
        Me.GroupBox1.Controls.Add(Me.rb_char2)
        Me.GroupBox1.Controls.Add(Me.rb_char3)
        Me.GroupBox1.Controls.Add(Me.rb_char4)
        Me.GroupBox1.Controls.Add(Me.rb_char1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick Your Character"
        '
        'rb_char5
        '
        Me.rb_char5.Image = CType(resources.GetObject("rb_char5.Image"), System.Drawing.Image)
        Me.rb_char5.Location = New System.Drawing.Point(495, 26)
        Me.rb_char5.Name = "rb_char5"
        Me.rb_char5.Size = New System.Drawing.Size(89, 58)
        Me.rb_char5.TabIndex = 4
        Me.rb_char5.TabStop = True
        Me.rb_char5.Text = "green"
        Me.rb_char5.UseVisualStyleBackColor = True
        '
        'rb_char2
        '
        Me.rb_char2.Image = CType(resources.GetObject("rb_char2.Image"), System.Drawing.Image)
        Me.rb_char2.Location = New System.Drawing.Point(146, 26)
        Me.rb_char2.Name = "rb_char2"
        Me.rb_char2.Size = New System.Drawing.Size(89, 58)
        Me.rb_char2.TabIndex = 3
        Me.rb_char2.TabStop = True
        Me.rb_char2.Text = "red"
        Me.rb_char2.UseVisualStyleBackColor = True
        '
        'rb_char3
        '
        Me.rb_char3.Image = CType(resources.GetObject("rb_char3.Image"), System.Drawing.Image)
        Me.rb_char3.Location = New System.Drawing.Point(268, 26)
        Me.rb_char3.Name = "rb_char3"
        Me.rb_char3.Size = New System.Drawing.Size(89, 58)
        Me.rb_char3.TabIndex = 2
        Me.rb_char3.TabStop = True
        Me.rb_char3.Text = "blue"
        Me.rb_char3.UseVisualStyleBackColor = True
        '
        'rb_char4
        '
        Me.rb_char4.Image = CType(resources.GetObject("rb_char4.Image"), System.Drawing.Image)
        Me.rb_char4.Location = New System.Drawing.Point(382, 26)
        Me.rb_char4.Name = "rb_char4"
        Me.rb_char4.Size = New System.Drawing.Size(89, 58)
        Me.rb_char4.TabIndex = 1
        Me.rb_char4.TabStop = True
        Me.rb_char4.Text = "pink"
        Me.rb_char4.UseVisualStyleBackColor = True
        '
        'rb_char1
        '
        Me.rb_char1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rb_char1.ForeColor = System.Drawing.Color.White
        Me.rb_char1.Image = Global.Lab2.My.Resources.Resources.icons8_pacman_48
        Me.rb_char1.Location = New System.Drawing.Point(36, 26)
        Me.rb_char1.Name = "rb_char1"
        Me.rb_char1.Size = New System.Drawing.Size(89, 58)
        Me.rb_char1.TabIndex = 0
        Me.rb_char1.TabStop = True
        Me.rb_char1.Text = "yellow"
        Me.rb_char1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tb_startmoney)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Start Money"
        '
        'tb_startmoney
        '
        Me.tb_startmoney.Location = New System.Drawing.Point(17, 27)
        Me.tb_startmoney.Name = "tb_startmoney"
        Me.tb_startmoney.Size = New System.Drawing.Size(172, 27)
        Me.tb_startmoney.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tb_placebet)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(428, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Place Bet"
        '
        'tb_placebet
        '
        Me.tb_placebet.Location = New System.Drawing.Point(17, 27)
        Me.tb_placebet.Name = "tb_placebet"
        Me.tb_placebet.Size = New System.Drawing.Size(172, 27)
        Me.tb_placebet.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.tb_moneyleft)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(222, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Money Left"
        '
        'tb_moneyleft
        '
        Me.tb_moneyleft.Location = New System.Drawing.Point(17, 27)
        Me.tb_moneyleft.Name = "tb_moneyleft"
        Me.tb_moneyleft.Size = New System.Drawing.Size(172, 27)
        Me.tb_moneyleft.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.pb_2)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.pb_5)
        Me.GroupBox5.Controls.Add(Me.pb_4)
        Me.GroupBox5.Controls.Add(Me.pb_3)
        Me.GroupBox5.Controls.Add(Me.pb_1)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(782, 396)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Racers"
        '
        'pb_2
        '
        Me.pb_2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_2.ForeColor = System.Drawing.Color.Yellow
        Me.pb_2.Location = New System.Drawing.Point(80, 117)
        Me.pb_2.Minimum = 1
        Me.pb_2.Name = "pb_2"
        Me.pb_2.Size = New System.Drawing.Size(624, 37)
        Me.pb_2.TabIndex = 15
        Me.pb_2.Value = 1
        '
        'Label15
        '
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(710, 311)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 58)
        Me.Label15.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(710, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 58)
        Me.Label14.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(710, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 58)
        Me.Label13.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(710, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 58)
        Me.Label12.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(710, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 58)
        Me.Label11.TabIndex = 10
        '
        'pb_5
        '
        Me.pb_5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_5.ForeColor = System.Drawing.Color.Yellow
        Me.pb_5.Location = New System.Drawing.Point(80, 324)
        Me.pb_5.Minimum = 1
        Me.pb_5.Name = "pb_5"
        Me.pb_5.Size = New System.Drawing.Size(624, 37)
        Me.pb_5.TabIndex = 9
        Me.pb_5.Value = 1
        '
        'pb_4
        '
        Me.pb_4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_4.ForeColor = System.Drawing.Color.Yellow
        Me.pb_4.Location = New System.Drawing.Point(80, 252)
        Me.pb_4.Minimum = 1
        Me.pb_4.Name = "pb_4"
        Me.pb_4.Size = New System.Drawing.Size(624, 37)
        Me.pb_4.TabIndex = 8
        Me.pb_4.Value = 1
        '
        'pb_3
        '
        Me.pb_3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_3.ForeColor = System.Drawing.Color.Yellow
        Me.pb_3.Location = New System.Drawing.Point(80, 191)
        Me.pb_3.Minimum = 1
        Me.pb_3.Name = "pb_3"
        Me.pb_3.Size = New System.Drawing.Size(624, 37)
        Me.pb_3.TabIndex = 7
        Me.pb_3.Value = 1
        '
        'pb_1
        '
        Me.pb_1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_1.ForeColor = System.Drawing.Color.Yellow
        Me.pb_1.Location = New System.Drawing.Point(80, 45)
        Me.pb_1.Minimum = 1
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(624, 37)
        Me.pb_1.TabIndex = 5
        Me.pb_1.Value = 1
        '
        'Label5
        '
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(13, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 58)
        Me.Label5.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(13, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 58)
        Me.Label4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(13, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 58)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(13, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 58)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Image = Global.Lab2.My.Resources.Resources.icons8_pacman_48
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 58)
        Me.Label1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.lbl_standing2)
        Me.GroupBox6.Controls.Add(Me.lbl_standing5)
        Me.GroupBox6.Controls.Add(Me.lbl_standing4)
        Me.GroupBox6.Controls.Add(Me.lbl_standing3)
        Me.GroupBox6.Controls.Add(Me.lbl_standing1)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(830, 206)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(137, 396)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Standings"
        '
        'lbl_standing2
        '
        Me.lbl_standing2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_standing2.Location = New System.Drawing.Point(45, 117)
        Me.lbl_standing2.Name = "lbl_standing2"
        Me.lbl_standing2.Size = New System.Drawing.Size(46, 34)
        Me.lbl_standing2.TabIndex = 4
        Me.lbl_standing2.Text = "1ST"
        '
        'lbl_standing5
        '
        Me.lbl_standing5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_standing5.Location = New System.Drawing.Point(45, 335)
        Me.lbl_standing5.Name = "lbl_standing5"
        Me.lbl_standing5.Size = New System.Drawing.Size(46, 34)
        Me.lbl_standing5.TabIndex = 3
        Me.lbl_standing5.Text = "1ST"
        '
        'lbl_standing4
        '
        Me.lbl_standing4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_standing4.Location = New System.Drawing.Point(45, 244)
        Me.lbl_standing4.Name = "lbl_standing4"
        Me.lbl_standing4.Size = New System.Drawing.Size(46, 34)
        Me.lbl_standing4.TabIndex = 2
        Me.lbl_standing4.Text = "1ST"
        '
        'lbl_standing3
        '
        Me.lbl_standing3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_standing3.Location = New System.Drawing.Point(45, 191)
        Me.lbl_standing3.Name = "lbl_standing3"
        Me.lbl_standing3.Size = New System.Drawing.Size(46, 34)
        Me.lbl_standing3.TabIndex = 1
        Me.lbl_standing3.Text = "1ST"
        '
        'lbl_standing1
        '
        Me.lbl_standing1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_standing1.Location = New System.Drawing.Point(45, 45)
        Me.lbl_standing1.Name = "lbl_standing1"
        Me.lbl_standing1.Size = New System.Drawing.Size(46, 34)
        Me.lbl_standing1.TabIndex = 0
        Me.lbl_standing1.Text = "1ST"
        '
        'lbl_round
        '
        Me.lbl_round.BackColor = System.Drawing.Color.Transparent
        Me.lbl_round.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_round.ForeColor = System.Drawing.Color.White
        Me.lbl_round.Location = New System.Drawing.Point(702, 21)
        Me.lbl_round.Name = "lbl_round"
        Me.lbl_round.Size = New System.Drawing.Size(265, 72)
        Me.lbl_round.TabIndex = 10
        Me.lbl_round.Text = "ROUND: X"
        '
        'btn_placebet
        '
        Me.btn_placebet.BackColor = System.Drawing.Color.Black
        Me.btn_placebet.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_placebet.ForeColor = System.Drawing.Color.White
        Me.btn_placebet.Location = New System.Drawing.Point(747, 96)
        Me.btn_placebet.Name = "btn_placebet"
        Me.btn_placebet.Size = New System.Drawing.Size(157, 31)
        Me.btn_placebet.TabIndex = 11
        Me.btn_placebet.Text = "Place Your Bet"
        Me.btn_placebet.UseVisualStyleBackColor = False
        '
        'btn_startrace
        '
        Me.btn_startrace.BackColor = System.Drawing.Color.Black
        Me.btn_startrace.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_startrace.ForeColor = System.Drawing.Color.White
        Me.btn_startrace.Location = New System.Drawing.Point(747, 132)
        Me.btn_startrace.Name = "btn_startrace"
        Me.btn_startrace.Size = New System.Drawing.Size(157, 31)
        Me.btn_startrace.TabIndex = 12
        Me.btn_startrace.Text = "Start Race"
        Me.btn_startrace.UseVisualStyleBackColor = False
        '
        'btn_nextround
        '
        Me.btn_nextround.BackColor = System.Drawing.Color.Black
        Me.btn_nextround.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_nextround.ForeColor = System.Drawing.Color.White
        Me.btn_nextround.Location = New System.Drawing.Point(747, 169)
        Me.btn_nextround.Name = "btn_nextround"
        Me.btn_nextround.Size = New System.Drawing.Size(157, 31)
        Me.btn_nextround.TabIndex = 13
        Me.btn_nextround.Text = "Next Round"
        Me.btn_nextround.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 250
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 250
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 250
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 635)
        Me.Controls.Add(Me.btn_nextround)
        Me.Controls.Add(Me.btn_startrace)
        Me.Controls.Add(Me.btn_placebet)
        Me.Controls.Add(Me.lbl_round)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pacman Gambling"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_char5 As RadioButton
    Friend WithEvents rb_char2 As RadioButton
    Friend WithEvents rb_char3 As RadioButton
    Friend WithEvents rb_char4 As RadioButton
    Friend WithEvents rb_char1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_startmoney As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tb_placebet As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tb_moneyleft As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents pb_5 As ProgressBar
    Friend WithEvents pb_4 As ProgressBar
    Friend WithEvents pb_3 As ProgressBar
    Friend WithEvents pb_1 As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_standing2 As Label
    Friend WithEvents lbl_standing5 As Label
    Friend WithEvents lbl_standing4 As Label
    Friend WithEvents lbl_standing3 As Label
    Friend WithEvents lbl_standing1 As Label
    Friend WithEvents lbl_round As Label
    Friend WithEvents btn_placebet As Button
    Friend WithEvents btn_startrace As Button
    Friend WithEvents btn_nextround As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents pb_2 As ProgressBar
End Class
