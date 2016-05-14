Public Class frmMain
    Public Sub updateAoB()
        Dim result As String = ""

        result &= transformValue(chkUnkHeroHealth.Checked, nudHeroHealth.Value, 8)
        result &= " " & transformValue(chkUnkHeroSpeed.Checked, nudHeroSpeed.Value, 8)
        result &= " " & transformValue(chkUnkHeroAttack.Checked, nudHeroAttack.Value, 8)
        result &= " " & transformValue(chkUnkHeroCasting.Checked, nudHeroCasting.Value, 8)
        result &= " " & transformValue(chkUnkHeroAbility1.Checked, nudHeroAbility1.Value, 8)
        result &= " " & transformValue(chkUnkHeroAbility2.Checked, nudHeroAbility2.Value, 8)
        result &= " " & transformValue(chkUnkDefenseHealth.Checked, nudDefenseHealth.Value, 8)
        result &= " " & transformValue(chkUnkDefenseAttack.Checked, nudDefenseAttack.Value, 8)
        result &= " " & transformValue(chkUnkDefenseDamage.Checked, nudDefenseDamage.Value, 8)
        result &= " " & transformValue(chkUnkDefenseCasting.Checked, nudDefenseCasting.Value, 8)
        result &= " ????????"
        result &= " " & transformValue(chkUnkResistGeneric.Checked, nudResistGeneric.Value, 8)
        result &= " ????????"
        result &= " " & transformValue(chkUnkResistPoison.Checked, nudResistPoison.Value, 8)
        result &= " ????????"
        result &= " " & transformValue(chkUnkResistFire.Checked, nudResistFire.Value, 8)
        result &= " ????????"
        result &= " " & transformValue(chkUnkResistLightning.Checked, nudResistLightning.Value, 8)
        result &= " " & transformValue(chkUnkItemDamage.Checked, nudItemDamage.Value, 8)
        result &= " " & transformValue(chkUnkItemProjCnt.Checked, nudItemProjCnt.Value, 8)
        result &= " " & transformValue(chkUnkItemProjSpeed.Checked, nudItemProjSpeed.Value, 8)
        result &= " ??"
        result &= transformValue(chkUnkItemEleType.Checked, elementTypeNumber(cmbItemEleType.SelectedItem), 2)
        result &= "????"
        result &= " " & transformValue(chkUnkItemEleDamage.Checked, nudItemEleDamage.Value, 8)
        result &= " ???????? ??????"
        result &= transformValue(chkUnkItemLocked.Checked, lockedStatus(chkItemLocked.Checked), 2)
        result &= " " & transformValue(chkUnkItemKnockback.Checked, nudItemKnockback.Value, 8)
        result &= " ????????"
        result &= " " & transformValue(chkUnkItemAmmoCap.Checked, nudItemAmmoCap.Value, 8)
        result &= " ???????? ???????? ????????"
        result &= " " & transformValue(chkUnkItemAttackSpeed.Checked, nudItemAttackSpeed.Value, 8)
        result &= " ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ????????"
        result &= " " & transformValue(chkUnkItemMaxLevel.Checked, nudItemMaxLevel.Value, 8)
        result &= " ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ???????? ????????"
        result &= " " & transformValue(chkUnkItemLevel.Checked, nudItemLevel.Value, 8)
        result &= " " & transformValue(chkUnkItemManaInvested.Checked, nudItemManaInvested.Value, 8)


        txtAoB.Text = result
    End Sub

    Public Function lockedStatus(status As Boolean) As Integer
        If status Then
            Return 128
        Else
            Return 0
        End If
    End Function

    Public Function lockedStatusReverse(num As Integer) As Boolean
        If num = 128 Then Return True Else Return False
    End Function

    Public Function elementTypeNumber(name As String) As Integer
        Select Case name
            Case "Poison"
                Return 226
            Case "Lightning"
                Return 212
            Case "Fire"
                Return 220
        End Select
        Return 0
    End Function

    Public Function elementIndexFromNumber(num As Integer) As Integer
        For i = 0 To cmbItemEleType.Items.Count - 1
            If num = elementTypeNumber(cmbItemEleType.Items(i)) Then
                Return i
            End If
        Next
        ' in the event the number cannot be matched to anything at all, default to "None"
        Return 0
    End Function

    Public Function transformValue(state As Boolean, num As Integer, size As Integer) As String
        If state Then
            Return Strings.StrDup(size, "?")
        End If

        Dim result As String = Hex(num)
        Dim finalized As String = ""

        If result.Length Mod 2 = 1 Then
            result = "0" & result
        End If

        result = result.PadLeft(size, "0")

        For i = (result.Length - 2) To 0 Step -2
            finalized &= result.Substring(i, 2)
        Next

        Return finalized
    End Function

    Public Function transformValueReverse(num As String) As Integer
        If num.Contains("?") Then
            ' We're dealing with a section that are question marks in number, default to 0
            Return 0
        End If

        Dim finalized As String = ""

        For i = (num.Length - 2) To 0 Step -2
            finalized &= num.Substring(i, 2)
        Next

        Return CInt("&H" & finalized)
    End Function

    Private Sub tmrAoBUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAoBUpdate.Tick
        updateAoB()
    End Sub

    Private Sub txtAoB_Click(sender As Object, e As System.EventArgs) Handles txtAoB.Click, txtAoB.GotFocus
        txtAoB.SelectAll()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Initialize components
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Renderer = customMenuRenderer

        cmbItemEleType.SelectedIndex = 0

        Console.WriteLine(elementIndexFromNumber(212))
        Console.WriteLine(elementIndexFromNumber(226))
        Console.WriteLine(elementIndexFromNumber(220))
        Console.WriteLine(elementIndexFromNumber(0))
    End Sub

    Private Sub resetControlsIn(cntrlGrp As System.Windows.Forms.Control.ControlCollection)
        For Each cntrl As Control In cntrlGrp
            If TypeOf cntrl Is CheckBox Then
                If cntrl.Name.Contains("Unk") Then
                    Dim chkbox As CheckBox = cntrl
                    If cntrl.Name.Contains("UnkItemDamage") Or cntrl.Name.Contains("ItemEleDamage") Or cntrl.Name.Contains("ItemManaInvested") Then
                        chkbox.Checked = True
                    Else
                        chkbox.Checked = False
                    End If
                End If
            ElseIf TypeOf cntrl Is NumericUpDown Then
                Dim nud As NumericUpDown = cntrl
                nud.Value = 0
            End If
        Next
    End Sub

#Region "MenuStrip"

#Region "CustomRenderer"
    Dim customMenuRenderer As New System.Windows.Forms.ToolStripProfessionalRenderer(New MenuStripRenderer)

    Public Class MenuStripRenderer
        Inherits ProfessionalColorTable
        Private ReadOnly background As System.Drawing.Color = Color.FromArgb(68, 77, 100)
        Private ReadOnly backgroundLight As System.Drawing.Color = Color.FromArgb(128, 77 + 60, 160)

        Public Overrides ReadOnly Property MenuItemSelected As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property SeparatorLight As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property SeparatorDark As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property MenuBorder As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripDropDownBackground As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientBegin As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientEnd As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientMiddle As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedHighlightBorder As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedBorder As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripBorder As System.Drawing.Color
            Get
                Return backgroundLight
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedHighlightBorder As System.Drawing.Color
            Get
                Return background
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedBorder As System.Drawing.Color
            Get
                Return background
            End Get
        End Property
    End Class
#End Region

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        sfd.Title = "Save Item Information To..."
        sfd.SupportMultiDottedExtensions = True
        sfd.ShowHelp = False
        sfd.OverwritePrompt = True
        sfd.RestoreDirectory = True
        sfd.Filter = "KDK|*.kdk"
        Dim res As DialogResult = sfd.ShowDialog()
        If sfd.FileName <> "" Then
            System.IO.File.WriteAllText(sfd.FileName.ToString(), txtAoB.Text)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        ofd.Title = "Open Item Information From..."
        ofd.SupportMultiDottedExtensions = True
        ofd.ShowHelp = False
        ofd.Filter = "KDK|*.kdk"
        Dim res As DialogResult = ofd.ShowDialog()
        Dim contents As String = ""
        If ofd.FileName = "" Then Return

        contents = System.IO.File.ReadAllText(ofd.FileName.ToString())

        Dim segments() As String = contents.Split(" ")

        If segments.Length <> 68 Then
            MessageBox.Show("File is invalid! Cannot be properly read. Missing or extra information." & Environment.NewLine & "Found " & segments.Length & " sections out of the expected 68", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Reset everything
        ResetAllToolStripMenuItem.PerformClick()

        ' Load in values
        nudHeroHealth.Value = transformValueReverse(segments(0))
        nudHeroSpeed.Value = transformValueReverse(segments(1))
        nudHeroAttack.Value = transformValueReverse(segments(2))
        nudHeroCasting.Value = transformValueReverse(segments(3))
        nudHeroAbility1.Value = transformValueReverse(segments(4))
        nudHeroAbility2.Value = transformValueReverse(segments(5))
        nudDefenseHealth.Value = transformValueReverse(segments(6))
        nudDefenseAttack.Value = transformValueReverse(segments(7))
        nudDefenseDamage.Value = transformValueReverse(segments(8))
        nudDefenseCasting.Value = transformValueReverse(segments(9))
        nudResistGeneric.Value = transformValueReverse(segments(11))
        nudResistPoison.Value = transformValueReverse(segments(13))
        nudResistFire.Value = transformValueReverse(segments(15))
        nudResistLightning.Value = transformValueReverse(segments(17))
        nudItemDamage.Value = transformValueReverse(segments(18))
        nudItemProjCnt.Value = transformValueReverse(segments(19))
        nudItemProjSpeed.Value = transformValueReverse(segments(20))
        cmbItemEleType.SelectedIndex = elementIndexFromNumber(transformValueReverse(segments(21).Substring(2, 2)))
        nudItemEleDamage.Value = transformValueReverse(segments(22))
        chkItemLocked.Checked = lockedStatusReverse(transformValueReverse(segments(24).Substring(5, 2)))
        nudItemKnockback.Value = transformValueReverse(segments(25))
        nudItemAmmoCap.Value = transformValueReverse(segments(27))
        nudItemAttackSpeed.Value = transformValueReverse(segments(31))
        nudItemMaxLevel.Value = transformValueReverse(segments(53))
        nudItemLevel.Value = transformValueReverse(segments(66))
        nudItemManaInvested.Value = transformValueReverse(segments(67))
    End Sub

    Private Sub AllOnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllOnToolStripMenuItem.Click
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is CheckBox Then
                If cntrl.Name.Contains("Unk") Then
                    Dim chkbox As CheckBox = cntrl
                    chkbox.Checked = True
                End If
            End If
        Next
    End Sub

    Private Sub AllOffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllOffToolStripMenuItem.Click
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is CheckBox Then
                If cntrl.Name.Contains("Unk") Then
                    Dim chkbox As CheckBox = cntrl
                    chkbox.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub ToggleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToggleToolStripMenuItem.Click
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is CheckBox Then
                If cntrl.Name.Contains("Unk") Then
                    Dim chkbox As CheckBox = cntrl
                    chkbox.Checked = Not chkbox.Checked
                End If
            End If
        Next
    End Sub

    Private Sub ResetAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetAllToolStripMenuItem.Click
        For Each cntrl As Control In Me.Controls
            resetControlsIn(cntrl.Controls)
        Next
        chkItemLocked.Checked = False
        cmbItemEleType.SelectedIndex = 0
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = CType(sender, ToolStripMenuItem).Checked
    End Sub

#End Region

#Region "chkUnk* CheckedChanged Handlers"
    Private Sub chkUnkHeroHealth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroHealth.CheckedChanged
        nudHeroHealth.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkHeroAttack_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroAttack.CheckedChanged
        nudHeroAttack.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkHeroSpeed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroSpeed.CheckedChanged
        nudHeroSpeed.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkHeroCasting_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroCasting.CheckedChanged
        nudHeroCasting.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkHeroAbility1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroAbility1.CheckedChanged
        nudHeroAbility1.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkHeroAbility2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkHeroAbility2.CheckedChanged
        nudHeroAbility2.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkDefenseHealth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkDefenseHealth.CheckedChanged
        nudDefenseHealth.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkDefenseAttack_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkDefenseAttack.CheckedChanged
        nudDefenseAttack.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkDefenseDamage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkDefenseDamage.CheckedChanged
        nudDefenseDamage.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkDefenseCasting_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkDefenseCasting.CheckedChanged
        nudDefenseCasting.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkResistGeneric_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkResistGeneric.CheckedChanged
        nudResistGeneric.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkResistPoison_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkResistPoison.CheckedChanged
        nudResistPoison.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkResistFire_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkResistFire.CheckedChanged
        nudResistFire.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkResistLightning_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkResistLightning.CheckedChanged
        nudResistLightning.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkItemDamage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemDamage.CheckedChanged
        nudItemDamage.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkItemProjCnt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemProjCnt.CheckedChanged
        nudItemProjCnt.Enabled = Not sender.Checked
    End Sub

    Private Sub chkUnkItemProjSpeed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemProjSpeed.CheckedChanged
        nudItemProjSpeed.Enabled = Not chkUnkItemProjSpeed.Checked
    End Sub

    Private Sub chkUnkItemEleType_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemEleType.CheckedChanged
        cmbItemEleType.Enabled = Not chkUnkItemEleType.Checked
    End Sub

    Private Sub chkUnkItemEleDamage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemEleDamage.CheckedChanged
        nudItemEleDamage.Enabled = Not chkUnkItemEleDamage.Checked
    End Sub

    Private Sub chkUnkItemLocked_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemLocked.CheckedChanged
        chkItemLocked.Enabled = Not chkUnkItemLocked.Checked
    End Sub

    Private Sub chkUnkItemKnockback_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemKnockback.CheckedChanged
        nudItemKnockback.Enabled = Not chkUnkItemKnockback.Checked
    End Sub

    Private Sub chkUnkItemAmmoCap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemAmmoCap.CheckedChanged
        nudItemAmmoCap.Enabled = Not chkUnkItemAmmoCap.Checked
    End Sub

    Private Sub chkUnkItemAttackSpeed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemAttackSpeed.CheckedChanged
        nudItemAttackSpeed.Enabled = Not chkUnkItemAttackSpeed.Checked
    End Sub

    Private Sub chkUnkItemMaxLevel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemMaxLevel.CheckedChanged
        nudItemMaxLevel.Enabled = Not chkUnkItemMaxLevel.Checked
    End Sub

    Private Sub chkUnkItemLevel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemLevel.CheckedChanged
        nudItemLevel.Enabled = Not chkUnkItemLevel.Checked
    End Sub

    Private Sub chkUnkItemManaInvested_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnkItemManaInvested.CheckedChanged
        nudItemManaInvested.Enabled = Not chkUnkItemManaInvested.Checked
    End Sub
#End Region 'chkUnk* CheckedChanged Handlers

    Private Sub AoBCompareToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AoBCompareToolStripMenuItem.Click
        frmCompare.Show()
    End Sub
End Class
