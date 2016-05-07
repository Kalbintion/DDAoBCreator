<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleUnknownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpHero = New System.Windows.Forms.GroupBox()
        Me.chkUnkHeroAbility2 = New System.Windows.Forms.CheckBox()
        Me.chkUnkHeroAbility1 = New System.Windows.Forms.CheckBox()
        Me.chkUnkHeroCasting = New System.Windows.Forms.CheckBox()
        Me.chkUnkHeroSpeed = New System.Windows.Forms.CheckBox()
        Me.chkUnkHeroAttack = New System.Windows.Forms.CheckBox()
        Me.chkUnkHeroHealth = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudHeroAbility2 = New System.Windows.Forms.NumericUpDown()
        Me.nudHeroAbility1 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudHeroCasting = New System.Windows.Forms.NumericUpDown()
        Me.nudHeroSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudHeroAttack = New System.Windows.Forms.NumericUpDown()
        Me.nudHeroHealth = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDefense = New System.Windows.Forms.GroupBox()
        Me.chkUnkDefenseCasting = New System.Windows.Forms.CheckBox()
        Me.chkUnkDefenseDamage = New System.Windows.Forms.CheckBox()
        Me.chkUnkDefenseAttack = New System.Windows.Forms.CheckBox()
        Me.chkUnkDefenseHealth = New System.Windows.Forms.CheckBox()
        Me.nudDefenseCasting = New System.Windows.Forms.NumericUpDown()
        Me.nudDefenseDamage = New System.Windows.Forms.NumericUpDown()
        Me.nudDefenseAttack = New System.Windows.Forms.NumericUpDown()
        Me.nudDefenseHealth = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpResist = New System.Windows.Forms.GroupBox()
        Me.chkUnkResistLightning = New System.Windows.Forms.CheckBox()
        Me.chkUnkResistFire = New System.Windows.Forms.CheckBox()
        Me.chkUnkResistPoison = New System.Windows.Forms.CheckBox()
        Me.chkUnkResistGeneric = New System.Windows.Forms.CheckBox()
        Me.nudResistLightning = New System.Windows.Forms.NumericUpDown()
        Me.nudResistFire = New System.Windows.Forms.NumericUpDown()
        Me.nudResistPoison = New System.Windows.Forms.NumericUpDown()
        Me.nudResistGeneric = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpItem = New System.Windows.Forms.GroupBox()
        Me.chkUnkItemManaInvested = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemLevel = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemMaxLevel = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemAttackSpeed = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemAmmoCap = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemKnockback = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemLocked = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemEleDamage = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemEleType = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemProjSpeed = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemProjCnt = New System.Windows.Forms.CheckBox()
        Me.chkUnkItemDamage = New System.Windows.Forms.CheckBox()
        Me.nudItemManaInvested = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudItemLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nudItemMaxLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nudItemAttackSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nudItemAmmoCap = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nudItemKnockback = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkItemLocked = New System.Windows.Forms.CheckBox()
        Me.cmbItemEleType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudItemEleDamage = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudItemProjSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudItemProjCnt = New System.Windows.Forms.NumericUpDown()
        Me.nudItemDamage = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grpAoB = New System.Windows.Forms.GroupBox()
        Me.txtAoB = New System.Windows.Forms.TextBox()
        Me.tmrAoBUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.grpHero.SuspendLayout()
        CType(Me.nudHeroAbility2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeroAbility1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeroCasting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeroSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeroAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeroHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDefense.SuspendLayout()
        CType(Me.nudDefenseCasting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDefenseDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDefenseAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDefenseHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResist.SuspendLayout()
        CType(Me.nudResistLightning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudResistFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudResistPoison, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudResistGeneric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        CType(Me.nudItemManaInvested, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemMaxLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemAttackSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemAmmoCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemKnockback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemEleDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemProjSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemProjCnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAoB.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToggleUnknownToolStripMenuItem, Me.ResetAllToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ToggleUnknownToolStripMenuItem
        '
        Me.ToggleUnknownToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllOnToolStripMenuItem, Me.AllOffToolStripMenuItem, Me.ToggleToolStripMenuItem})
        Me.ToggleUnknownToolStripMenuItem.Name = "ToggleUnknownToolStripMenuItem"
        Me.ToggleUnknownToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ToggleUnknownToolStripMenuItem.Text = "Toggle &Unknown"
        '
        'AllOnToolStripMenuItem
        '
        Me.AllOnToolStripMenuItem.Name = "AllOnToolStripMenuItem"
        Me.AllOnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.AllOnToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AllOnToolStripMenuItem.Text = "All &On"
        '
        'AllOffToolStripMenuItem
        '
        Me.AllOffToolStripMenuItem.Name = "AllOffToolStripMenuItem"
        Me.AllOffToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.AllOffToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AllOffToolStripMenuItem.Text = "All O&ff"
        '
        'ToggleToolStripMenuItem
        '
        Me.ToggleToolStripMenuItem.Name = "ToggleToolStripMenuItem"
        Me.ToggleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ToggleToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ToggleToolStripMenuItem.Text = "&Toggle"
        '
        'ResetAllToolStripMenuItem
        '
        Me.ResetAllToolStripMenuItem.Name = "ResetAllToolStripMenuItem"
        Me.ResetAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetAllToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ResetAllToolStripMenuItem.Text = "&Reset All"
        '
        'grpHero
        '
        Me.grpHero.Controls.Add(Me.chkUnkHeroAbility2)
        Me.grpHero.Controls.Add(Me.chkUnkHeroAbility1)
        Me.grpHero.Controls.Add(Me.chkUnkHeroCasting)
        Me.grpHero.Controls.Add(Me.chkUnkHeroSpeed)
        Me.grpHero.Controls.Add(Me.chkUnkHeroAttack)
        Me.grpHero.Controls.Add(Me.chkUnkHeroHealth)
        Me.grpHero.Controls.Add(Me.Label10)
        Me.grpHero.Controls.Add(Me.nudHeroAbility2)
        Me.grpHero.Controls.Add(Me.nudHeroAbility1)
        Me.grpHero.Controls.Add(Me.Label9)
        Me.grpHero.Controls.Add(Me.nudHeroCasting)
        Me.grpHero.Controls.Add(Me.nudHeroSpeed)
        Me.grpHero.Controls.Add(Me.nudHeroAttack)
        Me.grpHero.Controls.Add(Me.nudHeroHealth)
        Me.grpHero.Controls.Add(Me.Label4)
        Me.grpHero.Controls.Add(Me.Label3)
        Me.grpHero.Controls.Add(Me.Label2)
        Me.grpHero.Controls.Add(Me.Label1)
        Me.grpHero.ForeColor = System.Drawing.Color.White
        Me.grpHero.Location = New System.Drawing.Point(14, 29)
        Me.grpHero.Name = "grpHero"
        Me.grpHero.Size = New System.Drawing.Size(216, 195)
        Me.grpHero.TabIndex = 1
        Me.grpHero.TabStop = False
        Me.grpHero.Text = "Hero"
        '
        'chkUnkHeroAbility2
        '
        Me.chkUnkHeroAbility2.AutoSize = True
        Me.chkUnkHeroAbility2.Location = New System.Drawing.Point(7, 169)
        Me.chkUnkHeroAbility2.Name = "chkUnkHeroAbility2"
        Me.chkUnkHeroAbility2.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroAbility2.TabIndex = 21
        Me.ttMain.SetToolTip(Me.chkUnkHeroAbility2, "Is Value Unknown?")
        Me.chkUnkHeroAbility2.UseVisualStyleBackColor = True
        '
        'chkUnkHeroAbility1
        '
        Me.chkUnkHeroAbility1.AutoSize = True
        Me.chkUnkHeroAbility1.Location = New System.Drawing.Point(7, 141)
        Me.chkUnkHeroAbility1.Name = "chkUnkHeroAbility1"
        Me.chkUnkHeroAbility1.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroAbility1.TabIndex = 20
        Me.ttMain.SetToolTip(Me.chkUnkHeroAbility1, "Is Value Unknown?")
        Me.chkUnkHeroAbility1.UseVisualStyleBackColor = True
        '
        'chkUnkHeroCasting
        '
        Me.chkUnkHeroCasting.AutoSize = True
        Me.chkUnkHeroCasting.Location = New System.Drawing.Point(7, 113)
        Me.chkUnkHeroCasting.Name = "chkUnkHeroCasting"
        Me.chkUnkHeroCasting.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroCasting.TabIndex = 19
        Me.ttMain.SetToolTip(Me.chkUnkHeroCasting, "Is Value Unknown?")
        Me.chkUnkHeroCasting.UseVisualStyleBackColor = True
        '
        'chkUnkHeroSpeed
        '
        Me.chkUnkHeroSpeed.AutoSize = True
        Me.chkUnkHeroSpeed.Location = New System.Drawing.Point(7, 85)
        Me.chkUnkHeroSpeed.Name = "chkUnkHeroSpeed"
        Me.chkUnkHeroSpeed.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroSpeed.TabIndex = 18
        Me.ttMain.SetToolTip(Me.chkUnkHeroSpeed, "Is Value Unknown?")
        Me.chkUnkHeroSpeed.UseVisualStyleBackColor = True
        '
        'chkUnkHeroAttack
        '
        Me.chkUnkHeroAttack.AutoSize = True
        Me.chkUnkHeroAttack.Location = New System.Drawing.Point(7, 57)
        Me.chkUnkHeroAttack.Name = "chkUnkHeroAttack"
        Me.chkUnkHeroAttack.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroAttack.TabIndex = 17
        Me.ttMain.SetToolTip(Me.chkUnkHeroAttack, "Is Value Unknown?")
        Me.chkUnkHeroAttack.UseVisualStyleBackColor = True
        '
        'chkUnkHeroHealth
        '
        Me.chkUnkHeroHealth.AutoSize = True
        Me.chkUnkHeroHealth.Location = New System.Drawing.Point(7, 29)
        Me.chkUnkHeroHealth.Name = "chkUnkHeroHealth"
        Me.chkUnkHeroHealth.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkHeroHealth.TabIndex = 16
        Me.ttMain.SetToolTip(Me.chkUnkHeroHealth, "Is Value Unknown?")
        Me.chkUnkHeroHealth.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(28, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Ability 2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label10, "Hero Ability 2 Stat")
        '
        'nudHeroAbility2
        '
        Me.nudHeroAbility2.Location = New System.Drawing.Point(105, 166)
        Me.nudHeroAbility2.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroAbility2.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroAbility2.Name = "nudHeroAbility2"
        Me.nudHeroAbility2.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroAbility2.TabIndex = 14
        Me.ttMain.SetToolTip(Me.nudHeroAbility2, "Hero Ability 2 Stat")
        '
        'nudHeroAbility1
        '
        Me.nudHeroAbility1.Location = New System.Drawing.Point(105, 138)
        Me.nudHeroAbility1.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroAbility1.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroAbility1.Name = "nudHeroAbility1"
        Me.nudHeroAbility1.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroAbility1.TabIndex = 13
        Me.ttMain.SetToolTip(Me.nudHeroAbility1, resources.GetString("nudHeroAbility1.ToolTip"))
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(28, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 25)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ability 1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label9, resources.GetString("Label9.ToolTip"))
        '
        'nudHeroCasting
        '
        Me.nudHeroCasting.Location = New System.Drawing.Point(105, 110)
        Me.nudHeroCasting.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroCasting.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroCasting.Name = "nudHeroCasting"
        Me.nudHeroCasting.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroCasting.TabIndex = 11
        Me.ttMain.SetToolTip(Me.nudHeroCasting, "Hero Casting Rate Stat")
        '
        'nudHeroSpeed
        '
        Me.nudHeroSpeed.Location = New System.Drawing.Point(105, 82)
        Me.nudHeroSpeed.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroSpeed.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroSpeed.Name = "nudHeroSpeed"
        Me.nudHeroSpeed.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroSpeed.TabIndex = 10
        Me.ttMain.SetToolTip(Me.nudHeroSpeed, "Hero Speed Stat")
        '
        'nudHeroAttack
        '
        Me.nudHeroAttack.Location = New System.Drawing.Point(105, 54)
        Me.nudHeroAttack.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroAttack.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroAttack.Name = "nudHeroAttack"
        Me.nudHeroAttack.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroAttack.TabIndex = 9
        Me.ttMain.SetToolTip(Me.nudHeroAttack, "Hero Damage Stat")
        '
        'nudHeroHealth
        '
        Me.nudHeroHealth.Location = New System.Drawing.Point(105, 26)
        Me.nudHeroHealth.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudHeroHealth.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudHeroHealth.Name = "nudHeroHealth"
        Me.nudHeroHealth.Size = New System.Drawing.Size(101, 20)
        Me.nudHeroHealth.TabIndex = 8
        Me.ttMain.SetToolTip(Me.nudHeroHealth, "Hero Health Stat")
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Casting"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label4, "Hero Casting Rate Stat")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Speed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label3, "Hero Speed Stat")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attack"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label2, "Hero Damage Stat")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Health"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label1, "Hero Health Stat")
        '
        'grpDefense
        '
        Me.grpDefense.Controls.Add(Me.chkUnkDefenseCasting)
        Me.grpDefense.Controls.Add(Me.chkUnkDefenseDamage)
        Me.grpDefense.Controls.Add(Me.chkUnkDefenseAttack)
        Me.grpDefense.Controls.Add(Me.chkUnkDefenseHealth)
        Me.grpDefense.Controls.Add(Me.nudDefenseCasting)
        Me.grpDefense.Controls.Add(Me.nudDefenseDamage)
        Me.grpDefense.Controls.Add(Me.nudDefenseAttack)
        Me.grpDefense.Controls.Add(Me.nudDefenseHealth)
        Me.grpDefense.Controls.Add(Me.Label5)
        Me.grpDefense.Controls.Add(Me.Label6)
        Me.grpDefense.Controls.Add(Me.Label7)
        Me.grpDefense.Controls.Add(Me.Label8)
        Me.grpDefense.ForeColor = System.Drawing.Color.White
        Me.grpDefense.Location = New System.Drawing.Point(14, 230)
        Me.grpDefense.Name = "grpDefense"
        Me.grpDefense.Size = New System.Drawing.Size(216, 140)
        Me.grpDefense.TabIndex = 12
        Me.grpDefense.TabStop = False
        Me.grpDefense.Text = "Defense"
        '
        'chkUnkDefenseCasting
        '
        Me.chkUnkDefenseCasting.AutoSize = True
        Me.chkUnkDefenseCasting.Location = New System.Drawing.Point(7, 113)
        Me.chkUnkDefenseCasting.Name = "chkUnkDefenseCasting"
        Me.chkUnkDefenseCasting.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkDefenseCasting.TabIndex = 25
        Me.ttMain.SetToolTip(Me.chkUnkDefenseCasting, "Is Value Unknown?")
        Me.chkUnkDefenseCasting.UseVisualStyleBackColor = True
        '
        'chkUnkDefenseDamage
        '
        Me.chkUnkDefenseDamage.AutoSize = True
        Me.chkUnkDefenseDamage.Location = New System.Drawing.Point(7, 85)
        Me.chkUnkDefenseDamage.Name = "chkUnkDefenseDamage"
        Me.chkUnkDefenseDamage.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkDefenseDamage.TabIndex = 24
        Me.ttMain.SetToolTip(Me.chkUnkDefenseDamage, "Is Value Unknown?")
        Me.chkUnkDefenseDamage.UseVisualStyleBackColor = True
        '
        'chkUnkDefenseAttack
        '
        Me.chkUnkDefenseAttack.AutoSize = True
        Me.chkUnkDefenseAttack.Location = New System.Drawing.Point(7, 57)
        Me.chkUnkDefenseAttack.Name = "chkUnkDefenseAttack"
        Me.chkUnkDefenseAttack.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkDefenseAttack.TabIndex = 23
        Me.ttMain.SetToolTip(Me.chkUnkDefenseAttack, "Is Value Unknown?")
        Me.chkUnkDefenseAttack.UseVisualStyleBackColor = True
        '
        'chkUnkDefenseHealth
        '
        Me.chkUnkDefenseHealth.AutoSize = True
        Me.chkUnkDefenseHealth.Location = New System.Drawing.Point(7, 29)
        Me.chkUnkDefenseHealth.Name = "chkUnkDefenseHealth"
        Me.chkUnkDefenseHealth.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkDefenseHealth.TabIndex = 22
        Me.ttMain.SetToolTip(Me.chkUnkDefenseHealth, "Is Value Unknown?")
        Me.chkUnkDefenseHealth.UseVisualStyleBackColor = True
        '
        'nudDefenseCasting
        '
        Me.nudDefenseCasting.Location = New System.Drawing.Point(105, 110)
        Me.nudDefenseCasting.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudDefenseCasting.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudDefenseCasting.Name = "nudDefenseCasting"
        Me.nudDefenseCasting.Size = New System.Drawing.Size(101, 20)
        Me.nudDefenseCasting.TabIndex = 11
        Me.ttMain.SetToolTip(Me.nudDefenseCasting, "Defense Area of Effect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Radius")
        '
        'nudDefenseDamage
        '
        Me.nudDefenseDamage.Location = New System.Drawing.Point(105, 82)
        Me.nudDefenseDamage.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudDefenseDamage.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudDefenseDamage.Name = "nudDefenseDamage"
        Me.nudDefenseDamage.Size = New System.Drawing.Size(101, 20)
        Me.nudDefenseDamage.TabIndex = 10
        Me.ttMain.SetToolTip(Me.nudDefenseDamage, "Defense Damage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Effect Strength")
        '
        'nudDefenseAttack
        '
        Me.nudDefenseAttack.Location = New System.Drawing.Point(105, 54)
        Me.nudDefenseAttack.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudDefenseAttack.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudDefenseAttack.Name = "nudDefenseAttack"
        Me.nudDefenseAttack.Size = New System.Drawing.Size(101, 20)
        Me.nudDefenseAttack.TabIndex = 9
        Me.ttMain.SetToolTip(Me.nudDefenseAttack, "Defense Attack Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Effect Speed")
        '
        'nudDefenseHealth
        '
        Me.nudDefenseHealth.Location = New System.Drawing.Point(105, 26)
        Me.nudDefenseHealth.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudDefenseHealth.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudDefenseHealth.Name = "nudDefenseHealth"
        Me.nudDefenseHealth.Size = New System.Drawing.Size(101, 20)
        Me.nudDefenseHealth.TabIndex = 8
        Me.ttMain.SetToolTip(Me.nudDefenseHealth, "Defense Health Boost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Lifespan")
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(28, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "AoE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label5, "Defense Area of Effect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Radius")
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(28, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Damage"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label6, "Defense Damage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Effect Strength")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(28, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Atk Rate"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label7, "Defense Attack Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Effect Speed")
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(28, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Health"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttMain.SetToolTip(Me.Label8, "Defense Health Boost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aura Lifespan")
        '
        'grpResist
        '
        Me.grpResist.Controls.Add(Me.chkUnkResistLightning)
        Me.grpResist.Controls.Add(Me.chkUnkResistFire)
        Me.grpResist.Controls.Add(Me.chkUnkResistPoison)
        Me.grpResist.Controls.Add(Me.chkUnkResistGeneric)
        Me.grpResist.Controls.Add(Me.nudResistLightning)
        Me.grpResist.Controls.Add(Me.nudResistFire)
        Me.grpResist.Controls.Add(Me.nudResistPoison)
        Me.grpResist.Controls.Add(Me.nudResistGeneric)
        Me.grpResist.Controls.Add(Me.Label11)
        Me.grpResist.Controls.Add(Me.Label12)
        Me.grpResist.Controls.Add(Me.Label13)
        Me.grpResist.Controls.Add(Me.Label14)
        Me.grpResist.ForeColor = System.Drawing.Color.White
        Me.grpResist.Location = New System.Drawing.Point(14, 377)
        Me.grpResist.Name = "grpResist"
        Me.grpResist.Size = New System.Drawing.Size(216, 140)
        Me.grpResist.TabIndex = 13
        Me.grpResist.TabStop = False
        Me.grpResist.Text = "Resistances"
        '
        'chkUnkResistLightning
        '
        Me.chkUnkResistLightning.AutoSize = True
        Me.chkUnkResistLightning.Location = New System.Drawing.Point(7, 113)
        Me.chkUnkResistLightning.Name = "chkUnkResistLightning"
        Me.chkUnkResistLightning.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkResistLightning.TabIndex = 29
        Me.ttMain.SetToolTip(Me.chkUnkResistLightning, "Is Value Unknown?")
        Me.chkUnkResistLightning.UseVisualStyleBackColor = True
        '
        'chkUnkResistFire
        '
        Me.chkUnkResistFire.AutoSize = True
        Me.chkUnkResistFire.Location = New System.Drawing.Point(7, 85)
        Me.chkUnkResistFire.Name = "chkUnkResistFire"
        Me.chkUnkResistFire.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkResistFire.TabIndex = 28
        Me.ttMain.SetToolTip(Me.chkUnkResistFire, "Is Value Unknown?")
        Me.chkUnkResistFire.UseVisualStyleBackColor = True
        '
        'chkUnkResistPoison
        '
        Me.chkUnkResistPoison.AutoSize = True
        Me.chkUnkResistPoison.Location = New System.Drawing.Point(7, 57)
        Me.chkUnkResistPoison.Name = "chkUnkResistPoison"
        Me.chkUnkResistPoison.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkResistPoison.TabIndex = 27
        Me.ttMain.SetToolTip(Me.chkUnkResistPoison, "Is Value Unknown?")
        Me.chkUnkResistPoison.UseVisualStyleBackColor = True
        '
        'chkUnkResistGeneric
        '
        Me.chkUnkResistGeneric.AutoSize = True
        Me.chkUnkResistGeneric.Location = New System.Drawing.Point(7, 30)
        Me.chkUnkResistGeneric.Name = "chkUnkResistGeneric"
        Me.chkUnkResistGeneric.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkResistGeneric.TabIndex = 26
        Me.ttMain.SetToolTip(Me.chkUnkResistGeneric, "Is Value Unknown?")
        Me.chkUnkResistGeneric.UseVisualStyleBackColor = True
        '
        'nudResistLightning
        '
        Me.nudResistLightning.Location = New System.Drawing.Point(105, 111)
        Me.nudResistLightning.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudResistLightning.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudResistLightning.Name = "nudResistLightning"
        Me.nudResistLightning.Size = New System.Drawing.Size(101, 20)
        Me.nudResistLightning.TabIndex = 11
        '
        'nudResistFire
        '
        Me.nudResistFire.Location = New System.Drawing.Point(105, 83)
        Me.nudResistFire.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudResistFire.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudResistFire.Name = "nudResistFire"
        Me.nudResistFire.Size = New System.Drawing.Size(101, 20)
        Me.nudResistFire.TabIndex = 10
        '
        'nudResistPoison
        '
        Me.nudResistPoison.Location = New System.Drawing.Point(105, 55)
        Me.nudResistPoison.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudResistPoison.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudResistPoison.Name = "nudResistPoison"
        Me.nudResistPoison.Size = New System.Drawing.Size(101, 20)
        Me.nudResistPoison.TabIndex = 9
        '
        'nudResistGeneric
        '
        Me.nudResistGeneric.Location = New System.Drawing.Point(105, 27)
        Me.nudResistGeneric.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudResistGeneric.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudResistGeneric.Name = "nudResistGeneric"
        Me.nudResistGeneric.Size = New System.Drawing.Size(101, 20)
        Me.nudResistGeneric.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(28, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Lightning"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(28, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 25)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Fire"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(28, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Poison"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(28, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Generic"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.chkUnkItemManaInvested)
        Me.grpItem.Controls.Add(Me.chkUnkItemLevel)
        Me.grpItem.Controls.Add(Me.chkUnkItemMaxLevel)
        Me.grpItem.Controls.Add(Me.chkUnkItemAttackSpeed)
        Me.grpItem.Controls.Add(Me.chkUnkItemAmmoCap)
        Me.grpItem.Controls.Add(Me.chkUnkItemKnockback)
        Me.grpItem.Controls.Add(Me.chkUnkItemLocked)
        Me.grpItem.Controls.Add(Me.chkUnkItemEleDamage)
        Me.grpItem.Controls.Add(Me.chkUnkItemEleType)
        Me.grpItem.Controls.Add(Me.chkUnkItemProjSpeed)
        Me.grpItem.Controls.Add(Me.chkUnkItemProjCnt)
        Me.grpItem.Controls.Add(Me.chkUnkItemDamage)
        Me.grpItem.Controls.Add(Me.nudItemManaInvested)
        Me.grpItem.Controls.Add(Me.Label26)
        Me.grpItem.Controls.Add(Me.nudItemLevel)
        Me.grpItem.Controls.Add(Me.Label25)
        Me.grpItem.Controls.Add(Me.nudItemMaxLevel)
        Me.grpItem.Controls.Add(Me.Label24)
        Me.grpItem.Controls.Add(Me.nudItemAttackSpeed)
        Me.grpItem.Controls.Add(Me.Label23)
        Me.grpItem.Controls.Add(Me.nudItemAmmoCap)
        Me.grpItem.Controls.Add(Me.Label22)
        Me.grpItem.Controls.Add(Me.nudItemKnockback)
        Me.grpItem.Controls.Add(Me.Label21)
        Me.grpItem.Controls.Add(Me.chkItemLocked)
        Me.grpItem.Controls.Add(Me.cmbItemEleType)
        Me.grpItem.Controls.Add(Me.Label15)
        Me.grpItem.Controls.Add(Me.nudItemEleDamage)
        Me.grpItem.Controls.Add(Me.Label16)
        Me.grpItem.Controls.Add(Me.nudItemProjSpeed)
        Me.grpItem.Controls.Add(Me.nudItemProjCnt)
        Me.grpItem.Controls.Add(Me.nudItemDamage)
        Me.grpItem.Controls.Add(Me.Label17)
        Me.grpItem.Controls.Add(Me.Label18)
        Me.grpItem.Controls.Add(Me.Label19)
        Me.grpItem.Controls.Add(Me.Label20)
        Me.grpItem.ForeColor = System.Drawing.Color.White
        Me.grpItem.Location = New System.Drawing.Point(236, 29)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(297, 355)
        Me.grpItem.TabIndex = 16
        Me.grpItem.TabStop = False
        Me.grpItem.Text = "Item"
        '
        'chkUnkItemManaInvested
        '
        Me.chkUnkItemManaInvested.AutoSize = True
        Me.chkUnkItemManaInvested.Checked = True
        Me.chkUnkItemManaInvested.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUnkItemManaInvested.Location = New System.Drawing.Point(17, 327)
        Me.chkUnkItemManaInvested.Name = "chkUnkItemManaInvested"
        Me.chkUnkItemManaInvested.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemManaInvested.TabIndex = 41
        Me.ttMain.SetToolTip(Me.chkUnkItemManaInvested, "Is Value Unknown?")
        Me.chkUnkItemManaInvested.UseVisualStyleBackColor = True
        '
        'chkUnkItemLevel
        '
        Me.chkUnkItemLevel.AutoSize = True
        Me.chkUnkItemLevel.Location = New System.Drawing.Point(17, 299)
        Me.chkUnkItemLevel.Name = "chkUnkItemLevel"
        Me.chkUnkItemLevel.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemLevel.TabIndex = 40
        Me.ttMain.SetToolTip(Me.chkUnkItemLevel, "Is Value Unknown?")
        Me.chkUnkItemLevel.UseVisualStyleBackColor = True
        '
        'chkUnkItemMaxLevel
        '
        Me.chkUnkItemMaxLevel.AutoSize = True
        Me.chkUnkItemMaxLevel.Location = New System.Drawing.Point(17, 271)
        Me.chkUnkItemMaxLevel.Name = "chkUnkItemMaxLevel"
        Me.chkUnkItemMaxLevel.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemMaxLevel.TabIndex = 39
        Me.ttMain.SetToolTip(Me.chkUnkItemMaxLevel, "Is Value Unknown?")
        Me.chkUnkItemMaxLevel.UseVisualStyleBackColor = True
        '
        'chkUnkItemAttackSpeed
        '
        Me.chkUnkItemAttackSpeed.AutoSize = True
        Me.chkUnkItemAttackSpeed.Location = New System.Drawing.Point(17, 243)
        Me.chkUnkItemAttackSpeed.Name = "chkUnkItemAttackSpeed"
        Me.chkUnkItemAttackSpeed.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemAttackSpeed.TabIndex = 38
        Me.ttMain.SetToolTip(Me.chkUnkItemAttackSpeed, "Is Value Unknown?")
        Me.chkUnkItemAttackSpeed.UseVisualStyleBackColor = True
        '
        'chkUnkItemAmmoCap
        '
        Me.chkUnkItemAmmoCap.AutoSize = True
        Me.chkUnkItemAmmoCap.Location = New System.Drawing.Point(17, 215)
        Me.chkUnkItemAmmoCap.Name = "chkUnkItemAmmoCap"
        Me.chkUnkItemAmmoCap.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemAmmoCap.TabIndex = 37
        Me.ttMain.SetToolTip(Me.chkUnkItemAmmoCap, "Is Value Unknown?")
        Me.chkUnkItemAmmoCap.UseVisualStyleBackColor = True
        '
        'chkUnkItemKnockback
        '
        Me.chkUnkItemKnockback.AutoSize = True
        Me.chkUnkItemKnockback.Location = New System.Drawing.Point(17, 187)
        Me.chkUnkItemKnockback.Name = "chkUnkItemKnockback"
        Me.chkUnkItemKnockback.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemKnockback.TabIndex = 36
        Me.ttMain.SetToolTip(Me.chkUnkItemKnockback, "Is Value Unknown?")
        Me.chkUnkItemKnockback.UseVisualStyleBackColor = True
        '
        'chkUnkItemLocked
        '
        Me.chkUnkItemLocked.AutoSize = True
        Me.chkUnkItemLocked.Location = New System.Drawing.Point(17, 164)
        Me.chkUnkItemLocked.Name = "chkUnkItemLocked"
        Me.chkUnkItemLocked.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemLocked.TabIndex = 35
        Me.ttMain.SetToolTip(Me.chkUnkItemLocked, "Is Value Unknown?")
        Me.chkUnkItemLocked.UseVisualStyleBackColor = True
        '
        'chkUnkItemEleDamage
        '
        Me.chkUnkItemEleDamage.AutoSize = True
        Me.chkUnkItemEleDamage.Checked = True
        Me.chkUnkItemEleDamage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUnkItemEleDamage.Location = New System.Drawing.Point(17, 136)
        Me.chkUnkItemEleDamage.Name = "chkUnkItemEleDamage"
        Me.chkUnkItemEleDamage.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemEleDamage.TabIndex = 34
        Me.ttMain.SetToolTip(Me.chkUnkItemEleDamage, "Is Value Unknown?")
        Me.chkUnkItemEleDamage.UseVisualStyleBackColor = True
        '
        'chkUnkItemEleType
        '
        Me.chkUnkItemEleType.AutoSize = True
        Me.chkUnkItemEleType.Location = New System.Drawing.Point(17, 108)
        Me.chkUnkItemEleType.Name = "chkUnkItemEleType"
        Me.chkUnkItemEleType.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemEleType.TabIndex = 33
        Me.ttMain.SetToolTip(Me.chkUnkItemEleType, "Is Value Unknown?")
        Me.chkUnkItemEleType.UseVisualStyleBackColor = True
        '
        'chkUnkItemProjSpeed
        '
        Me.chkUnkItemProjSpeed.AutoSize = True
        Me.chkUnkItemProjSpeed.Location = New System.Drawing.Point(17, 79)
        Me.chkUnkItemProjSpeed.Name = "chkUnkItemProjSpeed"
        Me.chkUnkItemProjSpeed.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemProjSpeed.TabIndex = 32
        Me.ttMain.SetToolTip(Me.chkUnkItemProjSpeed, "Is Value Unknown?")
        Me.chkUnkItemProjSpeed.UseVisualStyleBackColor = True
        '
        'chkUnkItemProjCnt
        '
        Me.chkUnkItemProjCnt.AutoSize = True
        Me.chkUnkItemProjCnt.Location = New System.Drawing.Point(17, 51)
        Me.chkUnkItemProjCnt.Name = "chkUnkItemProjCnt"
        Me.chkUnkItemProjCnt.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemProjCnt.TabIndex = 31
        Me.ttMain.SetToolTip(Me.chkUnkItemProjCnt, "Is Value Unknown?")
        Me.chkUnkItemProjCnt.UseVisualStyleBackColor = True
        '
        'chkUnkItemDamage
        '
        Me.chkUnkItemDamage.AutoSize = True
        Me.chkUnkItemDamage.Checked = True
        Me.chkUnkItemDamage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUnkItemDamage.Location = New System.Drawing.Point(17, 23)
        Me.chkUnkItemDamage.Name = "chkUnkItemDamage"
        Me.chkUnkItemDamage.Size = New System.Drawing.Size(15, 14)
        Me.chkUnkItemDamage.TabIndex = 30
        Me.ttMain.SetToolTip(Me.chkUnkItemDamage, "Is Value Unknown?")
        Me.chkUnkItemDamage.UseVisualStyleBackColor = True
        '
        'nudItemManaInvested
        '
        Me.nudItemManaInvested.Enabled = False
        Me.nudItemManaInvested.Location = New System.Drawing.Point(184, 325)
        Me.nudItemManaInvested.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemManaInvested.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemManaInvested.Name = "nudItemManaInvested"
        Me.nudItemManaInvested.Size = New System.Drawing.Size(101, 20)
        Me.nudItemManaInvested.TabIndex = 29
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(14, 322)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(163, 25)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Mana Invested"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemLevel
        '
        Me.nudItemLevel.Location = New System.Drawing.Point(184, 297)
        Me.nudItemLevel.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemLevel.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemLevel.Name = "nudItemLevel"
        Me.nudItemLevel.Size = New System.Drawing.Size(101, 20)
        Me.nudItemLevel.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(14, 294)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(163, 25)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Item Level"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemMaxLevel
        '
        Me.nudItemMaxLevel.Location = New System.Drawing.Point(184, 269)
        Me.nudItemMaxLevel.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemMaxLevel.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemMaxLevel.Name = "nudItemMaxLevel"
        Me.nudItemMaxLevel.Size = New System.Drawing.Size(101, 20)
        Me.nudItemMaxLevel.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(14, 266)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(163, 25)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Max Item Level"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemAttackSpeed
        '
        Me.nudItemAttackSpeed.Location = New System.Drawing.Point(184, 241)
        Me.nudItemAttackSpeed.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemAttackSpeed.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemAttackSpeed.Name = "nudItemAttackSpeed"
        Me.nudItemAttackSpeed.Size = New System.Drawing.Size(101, 20)
        Me.nudItemAttackSpeed.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(14, 238)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(163, 25)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Attack Speed"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemAmmoCap
        '
        Me.nudItemAmmoCap.Location = New System.Drawing.Point(184, 213)
        Me.nudItemAmmoCap.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemAmmoCap.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemAmmoCap.Name = "nudItemAmmoCap"
        Me.nudItemAmmoCap.Size = New System.Drawing.Size(101, 20)
        Me.nudItemAmmoCap.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(14, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(163, 25)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Ammo Cap/Grd Range"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemKnockback
        '
        Me.nudItemKnockback.Location = New System.Drawing.Point(184, 185)
        Me.nudItemKnockback.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemKnockback.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemKnockback.Name = "nudItemKnockback"
        Me.nudItemKnockback.Size = New System.Drawing.Size(101, 20)
        Me.nudItemKnockback.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(14, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(163, 25)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Knockbk/Grd Def Bst"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkItemLocked
        '
        Me.chkItemLocked.AutoSize = True
        Me.chkItemLocked.Location = New System.Drawing.Point(184, 164)
        Me.chkItemLocked.Name = "chkItemLocked"
        Me.chkItemLocked.Size = New System.Drawing.Size(15, 14)
        Me.chkItemLocked.TabIndex = 17
        Me.chkItemLocked.UseVisualStyleBackColor = True
        '
        'cmbItemEleType
        '
        Me.cmbItemEleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemEleType.FormattingEnabled = True
        Me.cmbItemEleType.Items.AddRange(New Object() {"None", "Poison", "Lightning", "Fire"})
        Me.cmbItemEleType.Location = New System.Drawing.Point(184, 104)
        Me.cmbItemEleType.Name = "cmbItemEleType"
        Me.cmbItemEleType.Size = New System.Drawing.Size(101, 22)
        Me.cmbItemEleType.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(14, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 25)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Locked?"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemEleDamage
        '
        Me.nudItemEleDamage.Enabled = False
        Me.nudItemEleDamage.Location = New System.Drawing.Point(184, 134)
        Me.nudItemEleDamage.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemEleDamage.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemEleDamage.Name = "nudItemEleDamage"
        Me.nudItemEleDamage.Size = New System.Drawing.Size(101, 20)
        Me.nudItemEleDamage.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(14, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 25)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Elemental Damage"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudItemProjSpeed
        '
        Me.nudItemProjSpeed.Location = New System.Drawing.Point(184, 76)
        Me.nudItemProjSpeed.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemProjSpeed.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemProjSpeed.Name = "nudItemProjSpeed"
        Me.nudItemProjSpeed.Size = New System.Drawing.Size(101, 20)
        Me.nudItemProjSpeed.TabIndex = 10
        '
        'nudItemProjCnt
        '
        Me.nudItemProjCnt.Location = New System.Drawing.Point(184, 48)
        Me.nudItemProjCnt.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemProjCnt.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemProjCnt.Name = "nudItemProjCnt"
        Me.nudItemProjCnt.Size = New System.Drawing.Size(101, 20)
        Me.nudItemProjCnt.TabIndex = 9
        '
        'nudItemDamage
        '
        Me.nudItemDamage.Enabled = False
        Me.nudItemDamage.Location = New System.Drawing.Point(184, 20)
        Me.nudItemDamage.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudItemDamage.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nudItemDamage.Name = "nudItemDamage"
        Me.nudItemDamage.Size = New System.Drawing.Size(101, 20)
        Me.nudItemDamage.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(14, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 25)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Elemental Type"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(14, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(163, 25)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Projectile Speed"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(14, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 25)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Proj Cnt/Grd Def Cnt"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(14, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Damage"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpAoB
        '
        Me.grpAoB.Controls.Add(Me.txtAoB)
        Me.grpAoB.ForeColor = System.Drawing.Color.White
        Me.grpAoB.Location = New System.Drawing.Point(236, 390)
        Me.grpAoB.Name = "grpAoB"
        Me.grpAoB.Size = New System.Drawing.Size(297, 187)
        Me.grpAoB.TabIndex = 17
        Me.grpAoB.TabStop = False
        Me.grpAoB.Text = "AoB"
        '
        'txtAoB
        '
        Me.txtAoB.Location = New System.Drawing.Point(8, 22)
        Me.txtAoB.Multiline = True
        Me.txtAoB.Name = "txtAoB"
        Me.txtAoB.ReadOnly = True
        Me.txtAoB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAoB.Size = New System.Drawing.Size(283, 159)
        Me.txtAoB.TabIndex = 0
        '
        'tmrAoBUpdate
        '
        Me.tmrAoBUpdate.Enabled = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 589)
        Me.Controls.Add(Me.grpAoB)
        Me.Controls.Add(Me.grpItem)
        Me.Controls.Add(Me.grpResist)
        Me.Controls.Add(Me.grpDefense)
        Me.Controls.Add(Me.grpHero)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Dungeon Defenders Item AoB Creator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpHero.ResumeLayout(False)
        Me.grpHero.PerformLayout()
        CType(Me.nudHeroAbility2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeroAbility1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeroCasting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeroSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeroAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeroHealth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDefense.ResumeLayout(False)
        Me.grpDefense.PerformLayout()
        CType(Me.nudDefenseCasting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDefenseDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDefenseAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDefenseHealth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResist.ResumeLayout(False)
        Me.grpResist.PerformLayout()
        CType(Me.nudResistLightning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudResistFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudResistPoison, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudResistGeneric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.nudItemManaInvested, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemMaxLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemAttackSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemAmmoCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemKnockback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemEleDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemProjSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemProjCnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemDamage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAoB.ResumeLayout(False)
        Me.grpAoB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpHero As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudHeroAbility2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHeroAbility1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudHeroCasting As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHeroSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHeroAttack As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHeroHealth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpDefense As System.Windows.Forms.GroupBox
    Friend WithEvents nudDefenseCasting As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDefenseDamage As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDefenseAttack As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDefenseHealth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grpResist As System.Windows.Forms.GroupBox
    Friend WithEvents nudResistLightning As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudResistFire As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudResistPoison As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudResistGeneric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grpItem As System.Windows.Forms.GroupBox
    Friend WithEvents cmbItemEleType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents nudItemEleDamage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nudItemProjSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudItemProjCnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudItemDamage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkItemLocked As System.Windows.Forms.CheckBox
    Friend WithEvents nudItemKnockback As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents nudItemAmmoCap As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nudItemManaInvested As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents nudItemLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents nudItemMaxLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents nudItemAttackSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents grpAoB As System.Windows.Forms.GroupBox
    Friend WithEvents txtAoB As System.Windows.Forms.TextBox
    Friend WithEvents chkUnkHeroAbility2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkHeroAbility1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkHeroCasting As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkHeroSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkHeroAttack As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkHeroHealth As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkDefenseCasting As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkDefenseDamage As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkDefenseAttack As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkDefenseHealth As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkResistLightning As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkResistFire As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkResistPoison As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkResistGeneric As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemManaInvested As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemLevel As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemMaxLevel As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemAttackSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemAmmoCap As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemKnockback As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemLocked As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemEleDamage As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemEleType As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemProjSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemProjCnt As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnkItemDamage As System.Windows.Forms.CheckBox
    Friend WithEvents tmrAoBUpdate As System.Windows.Forms.Timer
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToggleUnknownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents AllOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToggleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog

End Class
