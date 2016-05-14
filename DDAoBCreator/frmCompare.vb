Public Class frmCompare
    Private Declare Auto Function RtfScroll Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByRef lParam As System.Drawing.Point) As Integer
    Private Const WM_USER = &H400
    Private Const EM_GETSCROLLPOS = WM_USER + 221
    Private Const EM_SETSCROLLPOS = WM_USER + 222

    Private Sub btnCompareFalse_Click(sender As System.Object, e As System.EventArgs) Handles btnCompare.Click
        If rtbL.TextLength <> rtbR.TextLength Then
            MessageBox.Show("AoB's do not match in length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim lList() As String = rtbL.Text.Split(" ")
        Dim rList() As String = rtbR.Text.Split(" ")

        If lList.Length <> rList.Length Then
            MessageBox.Show("AoB's length do not match. Ensure there are no extra spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        pbStatus.Maximum = lList.Length
        pbStatus.Value = 0

        For i As Integer = 0 To lList.Length - 1 Step 1
            pbStatus.Value = i
            If MarkDifferencesToolStripMenuItem.Checked And lList(i) <> rList(i) Then
                ' Format this specific location: (i * 2) + i to (i * 2) + i + 2
                rtbL.Select((i * 2) + i, 2)
                rtbR.Select((i * 2) + i, 2)

                rtbL.SelectionBackColor = Color.Red
                rtbR.SelectionBackColor = Color.Red

                rtbL.Select(0, 0)
                rtbR.Select(0, 0)
            End If
            If MarkSameToolStripMenuItem.Checked And lList(i) = rList(i) Then
                rtbL.Select((i * 2) + i, 2)
                rtbR.Select((i * 2) + i, 2)

                rtbL.SelectionBackColor = Color.Green
                rtbR.SelectionBackColor = Color.Green

                rtbL.Select(0, 0)
                rtbR.Select(0, 0)
            End If
        Next

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Dim rtfFont As Font = rtbL.Font
        rtbL.SelectAll()
        rtbL.SelectionBackColor = Me.BackColor
        rtbR.SelectAll()
        rtbR.SelectionBackColor = Me.BackColor
        rtbL.Select(0, 0)
        rtbR.Select(0, 0)
    End Sub

    Private Sub frmCompare_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmCompare_Resize(sender, e)
        pbStatus.ForeColor = Color.White
    End Sub

    Private Sub frmCompare_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        SplitContainer1.SplitterDistance = Me.Width / 2
    End Sub

    Private Sub rtbL_VScroll(sender As Object, e As System.EventArgs) Handles rtbL.VScroll
        Dim res As System.Drawing.Point
        RtfScroll(rtbL.Handle, EM_GETSCROLLPOS, 0, res)
        RtfScroll(rtbR.Handle, EM_SETSCROLLPOS, 0, res)
    End Sub

    Private Sub rtbR_VScroll(sender As Object, e As System.EventArgs) Handles rtbR.VScroll
        Dim res As System.Drawing.Point
        RtfScroll(rtbR.Handle, EM_GETSCROLLPOS, 0, res)
        RtfScroll(rtbL.Handle, EM_SETSCROLLPOS, 0, res)
    End Sub

    Private Sub btnCompareTrue_Click(sender As System.Object, e As System.EventArgs)
        If rtbL.TextLength <> rtbR.TextLength Then
            MessageBox.Show("AoB's do not match in length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim lList() As String = rtbL.Text.Split(" ")
        Dim rList() As String = rtbR.Text.Split(" ")

        If lList.Length <> rList.Length Then
            MessageBox.Show("AoB's length do not match. Ensure there are no extra spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        For i As Integer = 0 To lList.Length - 1 Step 1
            If lList(i) = rList(i) Then
                ' Format this specific location: (i * 2) + (i - 1) to (i * 2) + (i - 1) + 2
                rtbL.Select((i * 2) + i, 2)
                rtbR.Select((i * 2) + i, 2)

                rtbL.SelectionBackColor = Color.Green
                rtbR.SelectionBackColor = Color.Green

                rtbL.Select(0, 0)
                rtbR.Select(0, 0)
            End If
        Next
    End Sub
End Class