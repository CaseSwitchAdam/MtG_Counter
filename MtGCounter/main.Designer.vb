<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.player1add = New System.Windows.Forms.Button()
        Me.player1sub = New System.Windows.Forms.Button()
        Me.player1set = New System.Windows.Forms.TextBox()
        Me.player2set = New System.Windows.Forms.TextBox()
        Me.player2sub = New System.Windows.Forms.Button()
        Me.player2add = New System.Windows.Forms.Button()
        Me.player3set = New System.Windows.Forms.TextBox()
        Me.player3sub = New System.Windows.Forms.Button()
        Me.player3add = New System.Windows.Forms.Button()
        Me.player4set = New System.Windows.Forms.TextBox()
        Me.player4sub = New System.Windows.Forms.Button()
        Me.player4add = New System.Windows.Forms.Button()
        Me.healthdefaults = New System.Windows.Forms.ComboBox()
        Me.resethealth = New System.Windows.Forms.Button()
        Me.dielabel = New System.Windows.Forms.Label()
        Me.coin = New System.Windows.Forms.Button()
        Me.coinlabel = New System.Windows.Forms.Label()
        Me.die = New System.Windows.Forms.Button()
        Me.random1 = New System.Windows.Forms.TextBox()
        Me.randomlabel1 = New System.Windows.Forms.Label()
        Me.randomlabel2 = New System.Windows.Forms.Label()
        Me.random2 = New System.Windows.Forms.TextBox()
        Me.definedrandomlabel = New System.Windows.Forms.Label()
        Me.randomgen = New System.Windows.Forms.Button()
        Me.playerlist1 = New System.Windows.Forms.ListBox()
        Me.playerlist2 = New System.Windows.Forms.ListBox()
        Me.playerlist3 = New System.Windows.Forms.ListBox()
        Me.playerlist4 = New System.Windows.Forms.ListBox()
        Me.player1update = New System.Windows.Forms.Button()
        Me.player2update = New System.Windows.Forms.Button()
        Me.player3update = New System.Windows.Forms.Button()
        Me.player4update = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.autoupdate = New System.Windows.Forms.CheckBox()
        Me.clear1 = New System.Windows.Forms.Button()
        Me.clear2 = New System.Windows.Forms.Button()
        Me.clear3 = New System.Windows.Forms.Button()
        Me.clear4 = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.by = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.ticker = New System.Windows.Forms.Label()
        Me.Startstop = New System.Windows.Forms.Button()
        Me.timereset = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player1add
        '
        Me.player1add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1add.Location = New System.Drawing.Point(32, 38)
        Me.player1add.Name = "player1add"
        Me.player1add.Size = New System.Drawing.Size(32, 32)
        Me.player1add.TabIndex = 0
        Me.player1add.Text = "+"
        Me.player1add.UseVisualStyleBackColor = True
        '
        'player1sub
        '
        Me.player1sub.Location = New System.Drawing.Point(64, 38)
        Me.player1sub.Name = "player1sub"
        Me.player1sub.Size = New System.Drawing.Size(32, 32)
        Me.player1sub.TabIndex = 1
        Me.player1sub.Text = "-"
        Me.player1sub.UseVisualStyleBackColor = True
        '
        'player1set
        '
        Me.player1set.Location = New System.Drawing.Point(32, 80)
        Me.player1set.Name = "player1set"
        Me.player1set.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.player1set.Size = New System.Drawing.Size(64, 20)
        Me.player1set.TabIndex = 3
        Me.player1set.Text = "20"
        Me.player1set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'player2set
        '
        Me.player2set.Location = New System.Drawing.Point(102, 80)
        Me.player2set.Name = "player2set"
        Me.player2set.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.player2set.Size = New System.Drawing.Size(64, 20)
        Me.player2set.TabIndex = 8
        Me.player2set.Text = "20"
        Me.player2set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'player2sub
        '
        Me.player2sub.Location = New System.Drawing.Point(134, 38)
        Me.player2sub.Name = "player2sub"
        Me.player2sub.Size = New System.Drawing.Size(32, 32)
        Me.player2sub.TabIndex = 6
        Me.player2sub.Text = "-"
        Me.player2sub.UseVisualStyleBackColor = True
        '
        'player2add
        '
        Me.player2add.Location = New System.Drawing.Point(102, 38)
        Me.player2add.Name = "player2add"
        Me.player2add.Size = New System.Drawing.Size(32, 32)
        Me.player2add.TabIndex = 5
        Me.player2add.Text = "+"
        Me.player2add.UseVisualStyleBackColor = True
        '
        'player3set
        '
        Me.player3set.Location = New System.Drawing.Point(172, 80)
        Me.player3set.Name = "player3set"
        Me.player3set.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.player3set.Size = New System.Drawing.Size(64, 20)
        Me.player3set.TabIndex = 12
        Me.player3set.Text = "20"
        Me.player3set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'player3sub
        '
        Me.player3sub.Location = New System.Drawing.Point(204, 38)
        Me.player3sub.Name = "player3sub"
        Me.player3sub.Size = New System.Drawing.Size(32, 32)
        Me.player3sub.TabIndex = 10
        Me.player3sub.Text = "-"
        Me.player3sub.UseVisualStyleBackColor = True
        '
        'player3add
        '
        Me.player3add.Location = New System.Drawing.Point(172, 38)
        Me.player3add.Name = "player3add"
        Me.player3add.Size = New System.Drawing.Size(32, 32)
        Me.player3add.TabIndex = 9
        Me.player3add.Text = "+"
        Me.player3add.UseVisualStyleBackColor = True
        '
        'player4set
        '
        Me.player4set.Location = New System.Drawing.Point(242, 80)
        Me.player4set.Name = "player4set"
        Me.player4set.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.player4set.Size = New System.Drawing.Size(64, 20)
        Me.player4set.TabIndex = 16
        Me.player4set.Text = "20"
        Me.player4set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'player4sub
        '
        Me.player4sub.Location = New System.Drawing.Point(274, 38)
        Me.player4sub.Name = "player4sub"
        Me.player4sub.Size = New System.Drawing.Size(32, 32)
        Me.player4sub.TabIndex = 14
        Me.player4sub.Text = "-"
        Me.player4sub.UseVisualStyleBackColor = True
        '
        'player4add
        '
        Me.player4add.Location = New System.Drawing.Point(242, 38)
        Me.player4add.Name = "player4add"
        Me.player4add.Size = New System.Drawing.Size(32, 32)
        Me.player4add.TabIndex = 13
        Me.player4add.Text = "+"
        Me.player4add.UseVisualStyleBackColor = True
        '
        'healthdefaults
        '
        Me.healthdefaults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.healthdefaults.FormattingEnabled = True
        Me.healthdefaults.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40"})
        Me.healthdefaults.Location = New System.Drawing.Point(312, 80)
        Me.healthdefaults.Name = "healthdefaults"
        Me.healthdefaults.Size = New System.Drawing.Size(80, 21)
        Me.healthdefaults.TabIndex = 17
        Me.healthdefaults.Text = "20"
        '
        'resethealth
        '
        Me.resethealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resethealth.Location = New System.Drawing.Point(312, 38)
        Me.resethealth.Name = "resethealth"
        Me.resethealth.Size = New System.Drawing.Size(80, 32)
        Me.resethealth.TabIndex = 18
        Me.resethealth.Text = "Set Health"
        Me.resethealth.UseVisualStyleBackColor = True
        '
        'dielabel
        '
        Me.dielabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dielabel.AutoSize = True
        Me.dielabel.BackColor = System.Drawing.Color.Transparent
        Me.dielabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dielabel.Location = New System.Drawing.Point(379, 132)
        Me.dielabel.Name = "dielabel"
        Me.dielabel.Size = New System.Drawing.Size(14, 13)
        Me.dielabel.TabIndex = 20
        Me.dielabel.Text = "0"
        '
        'coin
        '
        Me.coin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.coin.Image = Global.mtgcounter.My.Resources.Resources.coin
        Me.coin.Location = New System.Drawing.Point(312, 176)
        Me.coin.Name = "coin"
        Me.coin.Size = New System.Drawing.Size(64, 64)
        Me.coin.TabIndex = 21
        Me.coin.UseVisualStyleBackColor = True
        '
        'coinlabel
        '
        Me.coinlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coinlabel.AutoSize = True
        Me.coinlabel.BackColor = System.Drawing.Color.Transparent
        Me.coinlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coinlabel.Location = New System.Drawing.Point(379, 202)
        Me.coinlabel.Name = "coinlabel"
        Me.coinlabel.Size = New System.Drawing.Size(14, 13)
        Me.coinlabel.TabIndex = 22
        Me.coinlabel.Text = "0"
        '
        'die
        '
        Me.die.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.die.BackColor = System.Drawing.Color.Transparent
        Me.die.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.die.Image = Global.mtgcounter.My.Resources.Resources.die
        Me.die.Location = New System.Drawing.Point(312, 106)
        Me.die.Name = "die"
        Me.die.Size = New System.Drawing.Size(64, 64)
        Me.die.TabIndex = 19
        Me.die.UseVisualStyleBackColor = False
        '
        'random1
        '
        Me.random1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.random1.Location = New System.Drawing.Point(312, 329)
        Me.random1.Name = "random1"
        Me.random1.Size = New System.Drawing.Size(64, 20)
        Me.random1.TabIndex = 23
        Me.random1.Text = "0"
        '
        'randomlabel1
        '
        Me.randomlabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.randomlabel1.AutoSize = True
        Me.randomlabel1.BackColor = System.Drawing.Color.Transparent
        Me.randomlabel1.Location = New System.Drawing.Point(309, 313)
        Me.randomlabel1.Name = "randomlabel1"
        Me.randomlabel1.Size = New System.Drawing.Size(49, 13)
        Me.randomlabel1.TabIndex = 24
        Me.randomlabel1.Text = "Between"
        '
        'randomlabel2
        '
        Me.randomlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.randomlabel2.AutoSize = True
        Me.randomlabel2.BackColor = System.Drawing.Color.Transparent
        Me.randomlabel2.Location = New System.Drawing.Point(309, 352)
        Me.randomlabel2.Name = "randomlabel2"
        Me.randomlabel2.Size = New System.Drawing.Size(25, 13)
        Me.randomlabel2.TabIndex = 25
        Me.randomlabel2.Text = "and"
        '
        'random2
        '
        Me.random2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.random2.Location = New System.Drawing.Point(312, 368)
        Me.random2.Name = "random2"
        Me.random2.Size = New System.Drawing.Size(64, 20)
        Me.random2.TabIndex = 26
        Me.random2.Text = "0"
        '
        'definedrandomlabel
        '
        Me.definedrandomlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.definedrandomlabel.AutoSize = True
        Me.definedrandomlabel.BackColor = System.Drawing.Color.Transparent
        Me.definedrandomlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.definedrandomlabel.Location = New System.Drawing.Point(379, 272)
        Me.definedrandomlabel.Name = "definedrandomlabel"
        Me.definedrandomlabel.Size = New System.Drawing.Size(14, 13)
        Me.definedrandomlabel.TabIndex = 27
        Me.definedrandomlabel.Text = "0"
        '
        'randomgen
        '
        Me.randomgen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.randomgen.Location = New System.Drawing.Point(312, 246)
        Me.randomgen.Name = "randomgen"
        Me.randomgen.Size = New System.Drawing.Size(64, 64)
        Me.randomgen.TabIndex = 28
        Me.randomgen.Text = "Generate Random"
        Me.randomgen.UseVisualStyleBackColor = True
        '
        'playerlist1
        '
        Me.playerlist1.FormattingEnabled = True
        Me.playerlist1.Location = New System.Drawing.Point(32, 144)
        Me.playerlist1.Name = "playerlist1"
        Me.playerlist1.Size = New System.Drawing.Size(64, 251)
        Me.playerlist1.TabIndex = 29
        '
        'playerlist2
        '
        Me.playerlist2.FormattingEnabled = True
        Me.playerlist2.Location = New System.Drawing.Point(102, 144)
        Me.playerlist2.Name = "playerlist2"
        Me.playerlist2.Size = New System.Drawing.Size(64, 251)
        Me.playerlist2.TabIndex = 30
        '
        'playerlist3
        '
        Me.playerlist3.FormattingEnabled = True
        Me.playerlist3.Location = New System.Drawing.Point(172, 144)
        Me.playerlist3.Name = "playerlist3"
        Me.playerlist3.Size = New System.Drawing.Size(64, 251)
        Me.playerlist3.TabIndex = 31
        '
        'playerlist4
        '
        Me.playerlist4.FormattingEnabled = True
        Me.playerlist4.Location = New System.Drawing.Point(242, 144)
        Me.playerlist4.Name = "playerlist4"
        Me.playerlist4.Size = New System.Drawing.Size(64, 251)
        Me.playerlist4.TabIndex = 32
        '
        'player1update
        '
        Me.player1update.ForeColor = System.Drawing.Color.Black
        Me.player1update.Location = New System.Drawing.Point(32, 106)
        Me.player1update.Name = "player1update"
        Me.player1update.Size = New System.Drawing.Size(64, 32)
        Me.player1update.TabIndex = 33
        Me.player1update.Text = "Update"
        Me.player1update.UseVisualStyleBackColor = True
        '
        'player2update
        '
        Me.player2update.Location = New System.Drawing.Point(102, 106)
        Me.player2update.Name = "player2update"
        Me.player2update.Size = New System.Drawing.Size(64, 32)
        Me.player2update.TabIndex = 34
        Me.player2update.Text = "Update"
        Me.player2update.UseVisualStyleBackColor = True
        '
        'player3update
        '
        Me.player3update.Location = New System.Drawing.Point(172, 106)
        Me.player3update.Name = "player3update"
        Me.player3update.Size = New System.Drawing.Size(64, 32)
        Me.player3update.TabIndex = 35
        Me.player3update.Text = "Update"
        Me.player3update.UseVisualStyleBackColor = True
        '
        'player4update
        '
        Me.player4update.Location = New System.Drawing.Point(242, 106)
        Me.player4update.Name = "player4update"
        Me.player4update.Size = New System.Drawing.Size(64, 32)
        Me.player4update.TabIndex = 36
        Me.player4update.Text = "Update"
        Me.player4update.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.Text = "Player 1"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "Player 2"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(172, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.Text = "Player 3"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(242, 12)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(64, 20)
        Me.TextBox4.TabIndex = 40
        Me.TextBox4.Text = "Player 4"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'autoupdate
        '
        Me.autoupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.autoupdate.AutoSize = True
        Me.autoupdate.BackColor = System.Drawing.Color.Transparent
        Me.autoupdate.Location = New System.Drawing.Point(312, 14)
        Me.autoupdate.Name = "autoupdate"
        Me.autoupdate.Size = New System.Drawing.Size(86, 17)
        Me.autoupdate.TabIndex = 41
        Me.autoupdate.Text = "Auto Update"
        Me.autoupdate.UseVisualStyleBackColor = False
        '
        'clear1
        '
        Me.clear1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clear1.Location = New System.Drawing.Point(32, 401)
        Me.clear1.Name = "clear1"
        Me.clear1.Size = New System.Drawing.Size(64, 32)
        Me.clear1.TabIndex = 42
        Me.clear1.Text = "Clear"
        Me.clear1.UseVisualStyleBackColor = True
        '
        'clear2
        '
        Me.clear2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clear2.Location = New System.Drawing.Point(102, 401)
        Me.clear2.Name = "clear2"
        Me.clear2.Size = New System.Drawing.Size(64, 32)
        Me.clear2.TabIndex = 43
        Me.clear2.Text = "Clear"
        Me.clear2.UseVisualStyleBackColor = True
        '
        'clear3
        '
        Me.clear3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clear3.Location = New System.Drawing.Point(172, 401)
        Me.clear3.Name = "clear3"
        Me.clear3.Size = New System.Drawing.Size(64, 32)
        Me.clear3.TabIndex = 44
        Me.clear3.Text = "Clear"
        Me.clear3.UseVisualStyleBackColor = True
        '
        'clear4
        '
        Me.clear4.Location = New System.Drawing.Point(242, 401)
        Me.clear4.Name = "clear4"
        Me.clear4.Size = New System.Drawing.Size(64, 32)
        Me.clear4.TabIndex = 45
        Me.clear4.Text = "Clear"
        Me.clear4.UseVisualStyleBackColor = True
        '
        'timer1
        '
        Me.timer1.Interval = 3000
        '
        'timer2
        '
        Me.timer2.Interval = 3000
        '
        'timer3
        '
        Me.timer3.Interval = 3000
        '
        'timer4
        '
        Me.timer4.Interval = 3000
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(32, 439)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown1.TabIndex = 47
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown2.Location = New System.Drawing.Point(102, 439)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown2.TabIndex = 48
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown3.Location = New System.Drawing.Point(172, 439)
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown3.TabIndex = 49
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown4.Location = New System.Drawing.Point(242, 439)
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown4.TabIndex = 50
        '
        'by
        '
        Me.by.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.by.AutoSize = True
        Me.by.BackColor = System.Drawing.Color.Transparent
        Me.by.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.by.Location = New System.Drawing.Point(12, 462)
        Me.by.Name = "by"
        Me.by.Size = New System.Drawing.Size(181, 13)
        Me.by.TabIndex = 46
        Me.by.Text = "Designed by: Lukke100 and linkfan_"
        Me.by.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'time
        '
        Me.time.Interval = 1000
        '
        'ticker
        '
        Me.ticker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ticker.AutoSize = True
        Me.ticker.Location = New System.Drawing.Point(330, 426)
        Me.ticker.Name = "ticker"
        Me.ticker.Size = New System.Drawing.Size(28, 13)
        Me.ticker.TabIndex = 52
        Me.ticker.Text = "0:00"
        '
        'Startstop
        '
        Me.Startstop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Startstop.Location = New System.Drawing.Point(312, 401)
        Me.Startstop.Name = "Startstop"
        Me.Startstop.Size = New System.Drawing.Size(64, 24)
        Me.Startstop.TabIndex = 53
        Me.Startstop.Text = "Start/Stop"
        Me.Startstop.UseVisualStyleBackColor = True
        '
        'timereset
        '
        Me.timereset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timereset.Location = New System.Drawing.Point(312, 439)
        Me.timereset.Name = "timereset"
        Me.timereset.Size = New System.Drawing.Size(64, 24)
        Me.timereset.TabIndex = 54
        Me.timereset.Text = "Reset"
        Me.timereset.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.timereset)
        Me.Controls.Add(Me.Startstop)
        Me.Controls.Add(Me.ticker)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.by)
        Me.Controls.Add(Me.clear4)
        Me.Controls.Add(Me.clear3)
        Me.Controls.Add(Me.clear2)
        Me.Controls.Add(Me.clear1)
        Me.Controls.Add(Me.autoupdate)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.player4update)
        Me.Controls.Add(Me.player3update)
        Me.Controls.Add(Me.player2update)
        Me.Controls.Add(Me.player1update)
        Me.Controls.Add(Me.playerlist4)
        Me.Controls.Add(Me.playerlist3)
        Me.Controls.Add(Me.playerlist2)
        Me.Controls.Add(Me.playerlist1)
        Me.Controls.Add(Me.randomgen)
        Me.Controls.Add(Me.definedrandomlabel)
        Me.Controls.Add(Me.random2)
        Me.Controls.Add(Me.randomlabel2)
        Me.Controls.Add(Me.randomlabel1)
        Me.Controls.Add(Me.random1)
        Me.Controls.Add(Me.coinlabel)
        Me.Controls.Add(Me.coin)
        Me.Controls.Add(Me.dielabel)
        Me.Controls.Add(Me.die)
        Me.Controls.Add(Me.resethealth)
        Me.Controls.Add(Me.healthdefaults)
        Me.Controls.Add(Me.player4set)
        Me.Controls.Add(Me.player4sub)
        Me.Controls.Add(Me.player4add)
        Me.Controls.Add(Me.player3set)
        Me.Controls.Add(Me.player3sub)
        Me.Controls.Add(Me.player3add)
        Me.Controls.Add(Me.player2set)
        Me.Controls.Add(Me.player2sub)
        Me.Controls.Add(Me.player2add)
        Me.Controls.Add(Me.player1set)
        Me.Controls.Add(Me.player1sub)
        Me.Controls.Add(Me.player1add)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "MtG Counter"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents player1add As System.Windows.Forms.Button
    Friend WithEvents player1sub As System.Windows.Forms.Button
    Friend WithEvents player1set As System.Windows.Forms.TextBox
    Friend WithEvents player2set As System.Windows.Forms.TextBox
    Friend WithEvents player2sub As System.Windows.Forms.Button
    Friend WithEvents player2add As System.Windows.Forms.Button
    Friend WithEvents player3set As System.Windows.Forms.TextBox
    Friend WithEvents player3sub As System.Windows.Forms.Button
    Friend WithEvents player3add As System.Windows.Forms.Button
    Friend WithEvents player4set As System.Windows.Forms.TextBox
    Friend WithEvents player4sub As System.Windows.Forms.Button
    Friend WithEvents player4add As System.Windows.Forms.Button
    Friend WithEvents healthdefaults As System.Windows.Forms.ComboBox
    Friend WithEvents resethealth As System.Windows.Forms.Button
    Friend WithEvents die As System.Windows.Forms.Button
    Friend WithEvents dielabel As System.Windows.Forms.Label
    Friend WithEvents coin As System.Windows.Forms.Button
    Friend WithEvents coinlabel As System.Windows.Forms.Label
    Friend WithEvents random1 As System.Windows.Forms.TextBox
    Friend WithEvents randomlabel1 As System.Windows.Forms.Label
    Friend WithEvents randomlabel2 As System.Windows.Forms.Label
    Friend WithEvents random2 As System.Windows.Forms.TextBox
    Friend WithEvents definedrandomlabel As System.Windows.Forms.Label
    Friend WithEvents randomgen As System.Windows.Forms.Button
    Friend WithEvents playerlist1 As System.Windows.Forms.ListBox
    Friend WithEvents playerlist2 As System.Windows.Forms.ListBox
    Friend WithEvents playerlist3 As System.Windows.Forms.ListBox
    Friend WithEvents playerlist4 As System.Windows.Forms.ListBox
    Friend WithEvents player1update As System.Windows.Forms.Button
    Friend WithEvents player2update As System.Windows.Forms.Button
    Friend WithEvents player3update As System.Windows.Forms.Button
    Friend WithEvents player4update As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents autoupdate As System.Windows.Forms.CheckBox
    Friend WithEvents clear1 As System.Windows.Forms.Button
    Friend WithEvents clear2 As System.Windows.Forms.Button
    Friend WithEvents clear3 As System.Windows.Forms.Button
    Friend WithEvents clear4 As System.Windows.Forms.Button
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents timer2 As System.Windows.Forms.Timer
    Friend WithEvents timer3 As System.Windows.Forms.Timer
    Friend WithEvents timer4 As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents by As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.Timer
    Friend WithEvents ticker As System.Windows.Forms.Label
    Friend WithEvents Startstop As System.Windows.Forms.Button
    Friend WithEvents timereset As System.Windows.Forms.Button

End Class
