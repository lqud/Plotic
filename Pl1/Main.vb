Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.IO

Public Class Main
    Private Const SCALE_FACTOR As Single = 4.25
    Private Const UPDATE_PERIOD As Integer = 100
    Private Const VERSION As String = "Plotic v0.7"
    Private HeatPoints As New List(Of HeatPoint)()

    Private saveImagePath As String = ""
    Private paletteOverride As Boolean = False
    Dim intBurstCycle As Integer = 0
    Public Pl As New Plotic

    Private Sub exitApplication()
        Application.Exit()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainToolStripStatus.Text = VERSION
        Me.Text = VERSION

        'Check for a Palette file in the same directory, use if found, otherwise use internal resource
        Dim palettePath As String = Path.Combine(Directory.GetCurrentDirectory, "pal.png")
        If File.Exists(palettePath) Then
            paletteOverride = True
            Debug.WriteLine("FOUND: " & palettePath)
        Else
            paletteOverride = False
            Debug.WriteLine("NOT FOUND: " & palettePath)
        End If
        'Make call to check if a silent run will be done, then close the program.
        'CreateTemplateIni()
        Dim silentIniPath As String = Path.Combine(Directory.GetCurrentDirectory, "plotic_silent.ini")
        If File.Exists(silentIniPath) Then
            Debug.WriteLine("FOUND: " & silentIniPath)
            'Me.WindowState = FormWindowState.Minimized
            createSilentImage()
            'Me.Close()
        Else
            Debug.WriteLine("NOT FOUND: " & silentIniPath)
        End If

    End Sub
    Public Sub createSilentImage()
        Debug.WriteLine("Running...")
        'exitApplication()
        Debug.WriteLine("Shutting Down")
        btnStart_Click()
    End Sub
    Public Sub drawTitle(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        g.DrawString(txtGunName.Text, New Font("Arial", 90), greenBrush1, 800, 30)
        g.DrawString(txtDamage.Text, New Font("Consolas", 60), greenBrush1, 710, 130)

    End Sub
    Public Sub drawGrid(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim centerx = 1000
        Dim centy = 1680
        If radMeters.Checked = True Then
            Dim gridx = centerx
            Dim gridy = centy
            Dim direction = 1
            Dim direction1 = 1
            For a = 0 To 70
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                pen6.DashStyle = Drawing2D.DashStyle.Dot
                g.DrawLine(pen6, gridx, 0, gridx, 2000)
                If direction = 1 Then
                    gridx = gridx - Val(txtScale.Text) / (1 / numLineSpace.Value)
                    If gridx < 0 Then
                        direction = 0
                    End If
                Else
                    gridx = gridx + Val(txtScale.Text) / (1 / numLineSpace.Value)
                End If
            Next
            For i = 0 To 70
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                g.DrawLine(pen6, 0, gridy, 2000, gridy)
                If direction1 = 1 Then
                    gridy = gridy - Val(txtScale.Text) / (1 / numLineSpace.Value)
                    If gridy < 0 Then
                        direction1 = 0
                    End If
                Else
                    gridy = gridy + Val(txtScale.Text) / (1 / numLineSpace.Value)
                End If
            Next
        Else
            Dim gridx = centerx
            Dim gridy = centy
            Dim direction = 1
            Dim direction1 = 1
            For a = 0 To 400
                mainToolStripStatus.Text = "Drawing vertical grid, convert degrees->radians->meters " + a.ToString + "/400"
                Application.DoEvents()
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                pen6.DashStyle = Drawing2D.DashStyle.Dot
                g.DrawLine(pen6, gridx, 0, gridx, 2000)
                If direction = 1 Then
                    gridx = gridx - Val(txtScale.Text) * (Math.Atan((numLineSpace.Value / numMeters.Value)) * (180 / Math.PI))
                    If gridx < 0 Then
                        direction = 0
                    End If
                Else
                    gridx = gridx + Val(txtScale.Text) * (Math.Atan((numLineSpace.Value / numMeters.Value)) * (180 / Math.PI))
                End If
            Next
            For i = 0 To 400
                mainToolStripStatus.Text = "Drawing horizontal grid, convert degrees->radians->meters " + i.ToString + "/400"
                Application.DoEvents()
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                g.DrawLine(pen6, 0, gridy, 2000, gridy)
                If direction1 = 1 Then
                    gridy = gridy - Val(txtScale.Text) * (Math.Atan((numLineSpace.Value / numMeters.Value)) * (180 / Math.PI))
                    If gridy < 0 Then
                        direction1 = 0
                    End If
                Else
                    gridy = gridy + Val(txtScale.Text) * (Math.Atan((numLineSpace.Value / numMeters.Value)) * (180 / Math.PI))
                End If
            Next
        End If

    End Sub
    Public Sub drawAdjustments(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim hPos As Integer = 5
        g.DrawString("Adjustments", New Font("Consolas", 35), greenBrush1, hPos, 25)
        g.DrawString("Recoil V: " + numRecoilV.Value.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 70)
        g.DrawString("Recoil H: " + numRecoilH.Value.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 110)
        g.DrawString("Spread Min: " + numMin.Value.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 150)
        g.DrawString("Spread Inc: " + numInc.Value.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 190)
    End Sub
    Public Sub drawTTK(ByVal g As Graphics, ByVal Hit1 As Integer, ByVal Hit2 As Integer, ByVal Hit3 As Integer, ByVal Hit4 As Integer, ByVal Hit5 As Integer)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim hPos As Integer = 1550
        g.DrawString("Average Hit Rates", New Font("Consolas", 35), greenBrush1, (hPos - 20), 25)
        g.DrawString("1st Bullet: " + Hit1.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 70)
        g.DrawString("2nd Bullet: " + Hit2.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 110)
        g.DrawString("3rd Bullet: " + Hit3.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 150)
        g.DrawString("4th Bullet: " + Hit4.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 190)
        g.DrawString("5th Bullet: " + Hit5.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 230)
    End Sub
    Public Sub drawBars(ByVal g As Graphics)
        ' prnt("Draw bars")
        Dim pen1 As New System.Drawing.Pen(Color.YellowGreen, 30)
        Dim pen2 As New System.Drawing.Pen(Color.Black, 30)
        Dim scale = 1500
        Dim x1 = 40
        Dim y = 1800
        Dim x2 = 130
        Dim x3 = 220
        Dim height1 As Integer = CDbl(Val(txtRecoilLeft.Text)) * (scale - 400)
        Dim height2 As Integer = CDbl(Val(txtRecoilUp.Text)) * scale
        Dim height3 As Integer = CDbl(Val(txtRecoilRight.Text)) * (scale - 400)
        Dim height4 As Integer = CDbl(Val(txtFirstShot.Text)) * 500
        g.DrawRectangle(pen1, x1, y - height2, 30, height2)
        g.DrawRectangle(pen1, x2, y - height4, 30, height4)
        Dim greenBrush As New SolidBrush(Color.YellowGreen)
        g.DrawRectangle(pen1, 1000 - height1, 1900, height1 + height3, 30)
        g.DrawRectangle(pen2, 1000, 1900, 5, 30)
        Dim pen11 As New System.Drawing.Pen(Color.YellowGreen, 30)
        Dim scale1 = 3000
        Dim x11 = 1840
        Dim y1 = 1800
        Dim x12 = 1930
        Dim height11 As Integer = CDbl(Val(txtSpreadMin.Text)) * scale1
        Dim height12 As Integer = CDbl(Val(txtSpreadInc.Text)) * scale1
        g.DrawRectangle(pen11, x11, y - height11, 30, height11)
        g.DrawRectangle(pen11, x12, y - height12, 30, height12)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim txt As String = "UP"
        Dim the_font As New Font("Consolas", 60, FontStyle.Bold, GraphicsUnit.Pixel)
        Dim layout_rect As New RectangleF(0, 0, _
            90, 3750)
        Dim layout_rect2 As New RectangleF(0, 0, _
          180, 3810)
        Dim layout_rect3 As New RectangleF(0, 0, _
         1890, 3800)
        Dim layout_rect4 As New RectangleF(0, 0, _
         1980, 3800)
        Dim string_format As New StringFormat
        string_format.Alignment = StringAlignment.Center
        string_format.LineAlignment = StringAlignment.Near
        string_format.FormatFlags = _
            StringFormatFlags.DirectionVertical Or _
            StringFormatFlags.DirectionRightToLeft
        g.DrawString(txt, the_font, Brushes.YellowGreen, layout_rect, string_format)
        g.DrawString("First", the_font, Brushes.YellowGreen, layout_rect2, string_format)
        g.DrawString("Min.", the_font, Brushes.YellowGreen, layout_rect3, string_format)
        g.DrawString("Inc.", the_font, Brushes.YellowGreen, layout_rect4, string_format)
        Dim greenBrush5 As New SolidBrush(Color.YellowGreen)
        g.DrawString("Left Right", New Font("Consolas", 45), greenBrush5, 839, 1820)
        Dim pen111 As New System.Drawing.Pen(Color.YellowGreen, 30)
    End Sub

    Private Sub startSilent()
        intBurstCycle = 0

        'Disable all of the input boxes
        btnStart.Enabled = False

        Me.grpAttach.Enabled = False
        Me.grpMisc.Enabled = False
        Me.grpRecoil.Enabled = False
        Me.tabMain.Enabled = False
        Me.grpSpread.Enabled = False

        ' Enable to stop button
        btnStop.Enabled = True
        ' Start the Background Worker working
        HeatPoints.Clear()
        loadPloticINI()
        'BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub btnStart_Click() Handles btnStart.Click
        intBurstCycle = 0

        'Disable all of the input boxes
        btnStart.Enabled = False

        Me.grpAttach.Enabled = False
        Me.grpMisc.Enabled = False
        Me.grpRecoil.Enabled = False
        Me.tabMain.Enabled = False
        Me.grpSpread.Enabled = False

        ' Enable to stop button
        btnStop.Enabled = True
        ' Start the Background Worker working
        HeatPoints.Clear()
        loadPlotic()
        BackgroundWorker1.RunWorkerAsync()
        'BackgroundWorker2.RunWorkerAsync()
    End Sub
    Private Sub loadPlotic()
        Pl.RecoilUp = txtRecoilUp.Text
        Pl.RecoilLeft = txtRecoilLeft.Text
        Pl.RecoilRight = txtRecoilRight.Text
        Pl.SpreadInc = txtSpreadInc.Text
        Pl.SpreadMin = txtSpreadMin.Text
        Pl.Burst = txtBursts.Text
        Pl.BulletsPerBurst = numBulletsPerBurst.Value
        Pl.AdjRecoilH = numRecoilH.Value
        Pl.AdjRecoilV = numRecoilV.Value
        Pl.AdjSpreadInc = numInc.Value
        Pl.AdjSpreadMin = numMin.Value
        Pl.GunName = txtGunName.Text

    End Sub

    Private Sub loadPloticINI()
        Pl.RecoilUp = txtRecoilUp.Text
        Pl.RecoilLeft = txtRecoilLeft.Text
        Pl.RecoilRight = txtRecoilRight.Text
        Pl.SpreadInc = txtSpreadInc.Text
        Pl.SpreadMin = txtSpreadMin.Text
        Pl.Burst = txtBursts.Text
        Pl.BulletsPerBurst = numBulletsPerBurst.Value
        Pl.AdjRecoilH = numRecoilH.Value
        Pl.AdjRecoilV = numRecoilV.Value
        Pl.AdjSpreadInc = numInc.Value
        Pl.AdjSpreadMin = numMin.Value
        Pl.GunName = txtGunName.Text

    End Sub
    Public Function rndD(ByRef upper As Integer, ByRef lower As Integer) As Integer
        'TODO:Add error logic for zero division
        Dim Random = lower + CLng(Rnd() * 1000000) Mod (upper - lower) + 1
        Return Random
    End Function

    Private Sub btnSaveImage_Click() Handles btnSaveImage.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*"
        saveFileDialog1.FileName = "image.png"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            saveImagePath = saveFileDialog1.FileName
            chkSaveImage.Checked = True
        End If
    End Sub

    Private Sub UpdateAdjustments()
        lblAdjUp.Text = calculateAdjustment(CDbl(Val(txtRecoilUp.Text)), CDbl(Val(numRecoilV.Text))).ToString
        lblAdjRight.Text = calculateAdjustment(CDbl(Val(txtRecoilRight.Text)), CDbl(Val(numRecoilH.Text))).ToString
        lblAdjLeft.Text = calculateAdjustment(CDbl(Val(txtRecoilLeft.Text)), CDbl(Val(numRecoilH.Text))).ToString

        lblAdjMin.Text = calculateAdjustment(CDbl(Val(txtSpreadMin.Text)), (numMin.Value)).ToString
        lblAdjInc.Text = calculateAdjustment(CDbl(Val(txtSpreadInc.Text)), (numInc.Value)).ToString
    End Sub
    Private Sub Adjustment_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numRecoilH.ValueChanged, numRecoilV.ValueChanged, numInc.ValueChanged, numMin.ValueChanged
        UpdateAdjustments()
    End Sub
    Private Function calculateAdjustment(ByVal actor As Double, ByVal action As Double) As Double
        Return Math.Round((actor * (action / 100)) + (actor), 3)
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'TODO: Convert to arrays
        Dim aryHits(4) As Integer

        For i As Integer = 0 To 4
            aryHits(i) = 0
        Next
        Dim coord1x(Val(txtBursts.Text)) As Integer
        Dim coord1y(Val(txtBursts.Text)) As Integer
        Dim coord2x(Val(txtBursts.Text)) As Integer
        Dim coord2y(Val(txtBursts.Text)) As Integer
        Dim coord3x(Val(txtBursts.Text)) As Integer
        Dim coord3y(Val(txtBursts.Text)) As Integer
        Dim coord4x(Val(txtBursts.Text)) As Integer
        Dim coord4y(Val(txtBursts.Text)) As Integer
        Dim coord5x(Val(txtBursts.Text)) As Integer
        Dim coord5y(Val(txtBursts.Text)) As Integer
        Dim coord6x(Val(txtBursts.Text)) As Integer
        Dim coord6y(Val(txtBursts.Text)) As Integer

        'Make Adjustments to values
        Dim dblRecoilH As Double = calculateAdjustment(Pl.RecoilUp, Pl.AdjRecoilV)
        Dim dblRecoilR As Double = calculateAdjustment(Pl.RecoilRight, Pl.AdjRecoilH)
        Dim dblRecoilL As Double = calculateAdjustment(Pl.RecoilLeft, Pl.AdjRecoilH)

        Dim dblSpreadMin As Double = calculateAdjustment(Pl.SpreadMin, Pl.AdjSpreadMin)
        Dim dblSpreadInc As Double = calculateAdjustment(Pl.SpreadInc, Pl.AdjSpreadInc)

        Dim b As Bitmap = New Bitmap(2000, 2000)

        'Add the mask to the Plotic class
        Dim solMask As Bitmap = New Bitmap(My.Resources.sil_mask)
        Dim solscaledMask As New Bitmap(CInt(solMask.Width * SCALE_FACTOR), CInt(solMask.Height * SCALE_FACTOR))
        Dim soldestMask As Graphics = Graphics.FromImage(solscaledMask)
        soldestMask.DrawImage(solMask, 0, 0, solscaledMask.Width + 1, solscaledMask.Height + 1)
        Dim vittuMask As Integer = (1000 - (solscaledMask.Width / 2))
        Pl.Graphic.Clear(Color.Black)
        Pl.Graphic.DrawImage(solscaledMask, vittuMask, 1000)

        Dim sol As Bitmap = New Bitmap(My.Resources.sil_1)
        Dim solscaled As New Bitmap(CInt(sol.Width * SCALE_FACTOR), CInt(sol.Height * SCALE_FACTOR))
        Dim soldest As Graphics = Graphics.FromImage(solscaled)
        soldest.DrawImage(sol, 0, 0, solscaled.Width + 1, solscaled.Height + 1)

        Dim g As Graphics = Graphics.FromImage(b)
        If chkTimeToKill.Checked Then
            Dim vittu As Integer = (1000 - (solscaled.Width / 2))
            g.Clear(Color.Black)
            g.DrawImage(solscaled, vittu, 1000)
        Else
            g.Clear(Color.Black)
        End If
        If chkBars.Checked Then
            drawBars(g)
        End If
        If chkPrintAdj.Checked Then
            drawAdjustments(g)
        End If
        If chkDrawGrid.Checked Then
            drawGrid(g)
        End If
        Dim scale = Val(txtScale.Text)
        Dim montako = 0
        Dim upd = 0
        For ee = 0 To Pl.Burst
            If BackgroundWorker1.CancellationPending Then
                ' Set Cancel to True
                SetImage_ThreadSafe(b)
                e.Cancel = True
                Exit For
            End If

            upd += 1
            If upd = UPDATE_PERIOD Then
                upd = 0
                SetImage_ThreadSafe(b)
            End If
            addBurstCount_ThreadSafe()
            Dim uprecoil = 0
            montako += 1
            Dim multiplier = 10
            Dim spread = dblSpreadMin * scale
            Dim centerx = 1000
            Dim centy = 1680
            Dim iIntense As Byte
            For a = 0 To Int(Pl.BulletsPerBurst) - 1
                Dim pen1 As New System.Drawing.Pen(Color.DarkRed, 4)
                Select Case a
                    Case 0
                        pen1.Color = Color.YellowGreen
                        iIntense = CByte(15 * numIntensityScale.Value)
                    Case 1
                        pen1.Color = Color.Yellow
                        iIntense = CByte(12 * numIntensityScale.Value)
                    Case 2
                        pen1.Color = Color.Orange
                        iIntense = CByte(9 * numIntensityScale.Value)
                    Case 3
                        pen1.Color = Color.Red
                        iIntense = CByte(6 * numIntensityScale.Value)
                    Case 4
                        pen1.Color = Color.DarkRed
                        iIntense = CByte(3 * numIntensityScale.Value)
                End Select
                Dim radius
                Dim mul As Integer = 100000
                If chkScaleRadius.Checked = True Then
                    radius = spread * Math.Sqrt(rndD(1000, 0) / 1000)
                Else
                    radius = rndD(spread, 0)
                End If
                Dim angle = rndD(360, 0)
                Dim x As Integer = centerx + radius * Math.Cos(angle)
                Dim y As Integer = centy + radius * Math.Sin(angle)

                'Add Target to heatpoints
                HeatPoints.Add(New HeatPoint(x, y, iIntense))

                If Not chkTimeToKill.Checked Then
                    g.DrawEllipse(pen1, x, y, 7, 7)
                Else
                    'Debug.WriteLine((Val(colo.R) + Val(colo.G) + Val(colo.B)).ToString())
                    Select Case a
                        Case 0
                            If Pl.bulletHit(x, y) Then
                                aryHits(0) += 1
                            End If
                            coord1x(ee) = x
                            coord1y(ee) = y
                        Case 1
                            If Pl.bulletHit(x, y) Then
                                aryHits(1) += 1
                            End If
                            coord2x(ee) = x
                            coord2y(ee) = y
                        Case 2
                            If Pl.bulletHit(x, y) Then
                                aryHits(2) += 1
                            End If
                            coord3x(ee) = x
                            coord3y(ee) = y
                        Case 3
                            If Pl.bulletHit(x, y) Then
                                aryHits(3) += 1
                            End If
                            coord4x(ee) = x
                            coord4y(ee) = y
                        Case 4
                            If Pl.bulletHit(x, y) Then
                                aryHits(4) += 1
                            End If
                            coord5x(ee) = x
                            coord5y(ee) = y
                    End Select
                    g.DrawEllipse(pen1, x, y, 7, 7)
                End If

                Application.DoEvents()
                If chkMultiplyRecoil.Checked = True Then
                    If a = 0 Then
                        centy -= ((CDbl(Val(txtRecoilUp.Text)) * scale) * CDbl(Val(txtFirstShot.Text)) * numRecoilMultiplier.Value)
                    Else
                        centy -= ((CDbl(Val(txtRecoilUp.Text)) * scale) * numRecoilMultiplier.Value)
                    End If
                Else
                    If a = 0 Then
                        centy -= (CDbl(Val(txtRecoilUp.Text)) * scale) * CDbl(Val(txtFirstShot.Text))
                    Else
                        centy -= CDbl(Val(txtRecoilUp.Text)) * scale
                    End If
                End If
                centerx += rndD(1000 + CDbl(dblRecoilR * scale), 1000 - Int(CDbl(dblRecoilL) * scale)) - 1000
                spread += CDbl(dblSpreadInc) * scale
            Next
            'Update the Progress bar
            BackgroundWorker1.ReportProgress(Math.Round(CInt((ee / Pl.Burst) * 100), 0))
        Next
        Dim nl = Environment.NewLine
        Dim intBursts As Integer = Val(txtBursts.Text)
        If chkTimeToKill.Checked = True Then
            For a = 0 To intBursts - 1
                Dim pen1 As New System.Drawing.Pen(Color.YellowGreen, 4)
                Dim pen2 As New System.Drawing.Pen(Color.Yellow, 4)
                Dim pen3 As New System.Drawing.Pen(Color.Orange, 4)
                Dim pen4 As New System.Drawing.Pen(Color.Red, 4)
                Dim pen5 As New System.Drawing.Pen(Color.DarkRed, 4)

                g.DrawEllipse(pen1, coord1x(a), coord1y(a), 7, 7)
                g.DrawEllipse(pen2, coord2x(a), coord2y(a), 7, 7)
                g.DrawEllipse(pen3, coord3x(a), coord3y(a), 7, 7)
                g.DrawEllipse(pen4, coord4x(a), coord4y(a), 7, 7)
                g.DrawEllipse(pen5, coord5x(a), coord5y(a), 7, 7)

                Pl.Graphic.DrawEllipse(pen1, coord1x(a), coord1y(a), 7, 7)
                Pl.Graphic.DrawEllipse(pen2, coord2x(a), coord2y(a), 7, 7)
                Pl.Graphic.DrawEllipse(pen3, coord3x(a), coord3y(a), 7, 7)
                Pl.Graphic.DrawEllipse(pen4, coord4x(a), coord4y(a), 7, 7)
                Pl.Graphic.DrawEllipse(pen5, coord5x(a), coord5y(a), 7, 7)
            Next
            SetImage_ThreadSafe(b)
            Application.DoEvents()
            Debug.WriteLine("Bursts: " & intBursts)
            Debug.WriteLine("Hits #1: " & aryHits(0))
            SetHitRateText_ThreadSafe("1st. bullet: " + Math.Round((aryHits(0) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "2nd. bullet: " + Math.Round((aryHits(1) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "3rd. bullet: " + Math.Round((aryHits(2) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "4th. bullet: " + Math.Round((aryHits(3) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "5th. bullet: " + Math.Round((aryHits(4) / (intBursts + 1) * 100), 2).ToString + "%")

        End If
        If chkDrawTTK.Checked And chkTimeToKill.Checked Then
            drawTTK(g, Math.Round((aryHits(0) / (intBursts + 1) * 100), 2), Math.Round((aryHits(1) / (intBursts + 1) * 100), 2), Math.Round((aryHits(2) / (intBursts + 1) * 100), 2), Math.Round((aryHits(3) / (intBursts + 1) * 100), 2), Math.Round((aryHits(4) / (intBursts + 1) * 100), 2))
        End If
        If chkHeatMap.Checked Then
            SetOutPutText_ThreadSafe("Please wait... Creating heat map")
            Application.DoEvents()
            b = CreateIntensityMask(Pl.HeatMap, HeatPoints)
            ' Colorize the memory bitmap and assign it as the picture boxes image
            b = Colorize(b, 255, paletteOverride)
        End If
        If chkTitles.Checked Then
            drawTitle(g)
        End If
        SetImage_ThreadSafe(b)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            mainToolStripStatus.Text = "Cancelled"
            Debug.WriteLine("Worker 1 Cancelled")
        Else
            mainToolStripStatus.Text = "Completed"
            Debug.WriteLine("Worker 1 Completed")

            If chkSaveImage.Checked Then
                Debug.WriteLine("Saving Image")
                SetOutPutText_ThreadSafe("Please wait... Saving Image")
                Application.DoEvents()
                SaveImage()
            End If
        End If

        Me.btnStart.Enabled = True
        Me.btnStop.Enabled = False

        Me.grpAttach.Enabled = True
        Me.grpMisc.Enabled = True
        Me.grpRecoil.Enabled = True
        Me.tabMain.Enabled = True
        Me.grpSpread.Enabled = True
    End Sub
    Private Sub SaveImage()
        Dim b As Bitmap = picPlot.Image
        'Dim b As Bitmap = Pl.Image
        Dim greenBrush As New SolidBrush(Color.YellowGreen)
        Dim bm_source As New Bitmap(b)
        Dim bm_dest As New Bitmap( _
            CInt(bm_source.Width * SCALE_FACTOR), _
            CInt(bm_source.Height * SCALE_FACTOR))
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
        gr_dest.DrawImage(bm_source, 0, 0, _
            bm_dest.Width + 1, _
            bm_dest.Height + 1)
        Dim picDest As New Bitmap(bm_dest)
        Dim file = saveImagePath
        If chkSaveImage.Checked = True Then
        Else
            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\Plotic\") Then
            Else
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\Plotic\")

            End If
            file = My.Computer.FileSystem.SpecialDirectories.Temp + "\Plotic\" + txtRecoilUp.Text + ".png"
        End If
        b.Save(file)
        picDest.Save("C:\Temp\" + Pl.GunName + ".png")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "C:\Windows\System32\rundll32.exe"
        ProcessProperties.Arguments = """" + My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Windows Photo Viewer\PhotoViewer.dll"", ImageView_Fullscreen " + file
        ProcessProperties.WindowStyle = ProcessWindowStyle.Maximized
        picDest.Dispose()
        bm_dest.Dispose()
        mainToolStripStatus.Text = "Image Saved: " & saveImagePath
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        ' Is the Background Worker do some work?
        If BackgroundWorker1.IsBusy Then
            'If it supports cancellation, Cancel It
            If BackgroundWorker1.WorkerSupportsCancellation Then
                ' Tell the Background Worker to stop working.
                BackgroundWorker1.CancelAsync()
            End If
        End If
        If BackgroundWorker2.IsBusy Then
            'If it supports cancellation, Cancel It
            If BackgroundWorker2.WorkerSupportsCancellation Then
                ' Tell the Background Worker to stop working.
                BackgroundWorker2.CancelAsync()
            End If
        End If
    End Sub

    Delegate Sub SetOutPutText_Delegate(ByVal [text] As String)
    ' The delegates subroutine.
    Private Sub SetOutPutText_ThreadSafe(ByVal [text] As String)
        mainToolStripStatus.Text = [text]
    End Sub

    Delegate Sub SetHitRate_Delegate(ByVal [text] As String)
    ' The delegates subroutine.
    Private Sub SetHitRateText_ThreadSafe(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If txtHitRateResult.InvokeRequired Then
            Dim MyDelegate As New SetHitRate_Delegate(AddressOf SetHitRateText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[text]})
        Else
            txtHitRateResult.Text = [text]
        End If
    End Sub

    Delegate Sub addBurstCount_Delegate()
    ' The delegates subroutine.
    Private Sub addBurstCount_ThreadSafe()
        If lblBurstCounter.InvokeRequired Then
            Dim MyDelegate As New addBurstCount_Delegate(AddressOf addBurstCount_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {})
        Else
            lblBurstCounter.Text = "Burst " + intBurstCycle.ToString + " / " + Pl.Burst.ToString
            intBurstCycle += 1
        End If

    End Sub

    Delegate Sub SetImage_Delegate(ByVal [image] As Bitmap)
    ' The delegates subroutine.
    Private Sub SetImage_ThreadSafe(ByVal [image] As Bitmap)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If picPlot.InvokeRequired Then
            Dim MyDelegate As New SetImage_Delegate(AddressOf SetImage_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[image]})
        Else
            picPlot.Image = [image]
        End If
    End Sub

    Private Sub chkSaveImage_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chkSaveImage.Checked And saveImagePath = "" Then
            btnSaveImage_Click()
        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        System.Diagnostics.Process.Start("http://symthic.com")
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        ' Reserved for Distance calculations

    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If e.Cancelled Then
            mainToolStripStatus.Text = "Cancelled"
            Debug.WriteLine("Worker 2 Cancelled")
        Else
            mainToolStripStatus.Text = "Completed"
            Debug.WriteLine("Worker 2 Completed")
        End If
    End Sub

    Private Function CreateIntensityMask(bSurface As Bitmap, aHeatPoints As List(Of HeatPoint)) As Bitmap
        ' Create new graphics surface from memory bitmap
        Dim DrawSurface As Graphics = Graphics.FromImage(bSurface)

        ' Set background color to white so that pixels can be correctly colorized
        DrawSurface.Clear(Color.White)

        Dim hCount As Integer = 1
        ' Traverse heat point data and draw masks for each heat point
        For Each DataPoint As HeatPoint In aHeatPoints
            ' Render current heat point on draw surface
            DrawHeatPoint(DrawSurface, DataPoint, numHeatRadius.Value)
            BackgroundWorker1.ReportProgress(Math.Round((hCount / aHeatPoints.Count) * 100), 0)
            hCount += 1
        Next

        Return bSurface
    End Function
    Private Sub DrawHeatPoint(Canvas As Graphics, HeatPoint As HeatPoint, Radius As Integer)
        ' Create points generic list of points to hold circumference points
        Dim CircumferencePointsList As New List(Of Point)()

        ' Create an empty point to predefine the point struct used in the circumference loop
        Dim CircumferencePoint As Point

        ' Create an empty array that will be populated with points from the generic list
        Dim CircumferencePointsArray As Point()

        ' Calculate ratio to scale byte intensity range from 0-255 to 0-1
        Dim fRatio As Single = 1.0F / [Byte].MaxValue
        ' Precalulate half of byte max value
        Dim bHalf As Byte = [Byte].MaxValue \ 2
        ' Flip intensity on it's center value from low-high to high-low
        Dim iIntensity As Integer = (CInt(HeatPoint.Intensity) - ((CInt(HeatPoint.Intensity) - bHalf) * 2))
        ' Store scaled and flipped intensity value for use with gradient center location
        Dim fIntensity As Single = iIntensity * fRatio

        ' Loop through all angles of a circle
        ' Define loop variable as a double to prevent casting in each iteration
        ' Iterate through loop on 10 degree deltas, this can change to improve performance
        For i As Double = 0 To 360 Step 10
            ' Replace last iteration point with new empty point struct
            CircumferencePoint = New Point()

            ' Plot new point on the circumference of a circle of the defined radius
            ' Using the point coordinates, radius, and angle
            ' Calculate the position of this iterations point on the circle
            CircumferencePoint.X = Convert.ToInt32(HeatPoint.X + Radius * Math.Cos(ConvertDegreesToRadians(i)))
            CircumferencePoint.Y = Convert.ToInt32(HeatPoint.Y + Radius * Math.Sin(ConvertDegreesToRadians(i)))

            ' Add newly plotted circumference point to generic point list
            CircumferencePointsList.Add(CircumferencePoint)
        Next

        ' Populate empty points system array from generic points array list
        ' Do this to satisfy the datatype of the PathGradientBrush and FillPolygon methods
        CircumferencePointsArray = CircumferencePointsList.ToArray()

        ' Create new PathGradientBrush to create a radial gradient using the circumference points
        Dim GradientShaper As New PathGradientBrush(CircumferencePointsArray)

        ' Create new color blend to tell the PathGradientBrush what colors to use and where to put them
        Dim GradientSpecifications As New ColorBlend(3)

        ' Define positions of gradient colors, use intesity to adjust the middle color to
        ' show more mask or less mask
        GradientSpecifications.Positions = New Single(2) {0, fIntensity, 1}
        ' Define gradient colors and their alpha values, adjust alpha of gradient colors to match intensity
        GradientSpecifications.Colors = New Color(2) {Color.FromArgb(0, Color.White), Color.FromArgb(HeatPoint.Intensity, Color.Black), Color.FromArgb(HeatPoint.Intensity, Color.Black)}

        ' Pass off color blend to PathGradientBrush to instruct it how to generate the gradient
        GradientShaper.InterpolationColors = GradientSpecifications

        ' Draw polygon (circle) using our point array and gradient brush
        Canvas.FillPolygon(GradientShaper, CircumferencePointsArray)
    End Sub

    Private Function ConvertDegreesToRadians(degrees As Double) As Double
        Dim radians As Double = (Math.PI / 180) * degrees
        Return (radians)
    End Function

    Public Shared Function Colorize(Mask As Bitmap, Alpha As Byte, CustomPal As Boolean) As Bitmap
        ' Create new bitmap to act as a work surface for the colorization process
        Dim Output As New Bitmap(Mask.Width, Mask.Height, PixelFormat.Format32bppArgb)

        ' Create a graphics object from our memory bitmap so we can draw on it and clear it's drawing surface
        Dim Surface As Graphics = Graphics.FromImage(Output)
        Surface.Clear(Color.Transparent)

        ' Build an array of color mappings to remap our greyscale mask to full color
        ' Accept an alpha byte to specify the transparancy of the output image
        Dim Colors As ColorMap() = CreatePaletteIndex(Alpha, CustomPal)

        ' Create new image attributes class to handle the color remappings
        ' Inject our color map array to instruct the image attributes class how to do the colorization
        Dim Remapper As New ImageAttributes()
        Remapper.SetRemapTable(Colors)

        ' Draw our mask onto our memory bitmap work surface using the new color mapping scheme
        Surface.DrawImage(Mask, New Rectangle(0, 0, Mask.Width, Mask.Height), 0, 0, Mask.Width, Mask.Height, _
         GraphicsUnit.Pixel, Remapper)

        ' Send back newly colorized memory bitmap
        Return Output
    End Function

    Private Shared Function CreatePaletteIndex(Alpha As Byte, CustomPal As Boolean) As ColorMap()
        Dim OutputMap As ColorMap() = New ColorMap(255) {}

        ' Change this path to wherever you saved the palette image.
        Dim Palette As Bitmap
        If CustomPal = True Then
            Dim palettePath As String = Path.Combine(Directory.GetCurrentDirectory, "pal.png")
            Palette = DirectCast(Bitmap.FromFile(palettePath), Bitmap)
        Else
            Palette = New Bitmap(My.Resources.pal_white_red)
        End If

        ' Loop through each pixel and create a new color mapping
        For X As Integer = 0 To 255
            OutputMap(X) = New ColorMap()
            OutputMap(X).OldColor = Color.FromArgb(X, X, X)
            OutputMap(X).NewColor = Color.FromArgb(Alpha, Palette.GetPixel(X, 0))
        Next

        Return OutputMap
    End Function

#Region "API Calls"
    ' standard API declarations for INI access
    ' changing only "As Long" to "As Int32" (As Integer would work also)
Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
#End Region
#Region "INIRead Overloads"
    Public Overloads Function INIRead(ByVal INIPath As String, _
ByVal SectionName As String, ByVal KeyName As String, _
ByVal DefaultValue As String) As String
        ' primary version of call gets single value given all parameters
        Dim n As Int32
        Dim sData As String
        sData = space$(1024) ' allocate some room
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
        sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            INIRead = sdata.Substring(0, n)
        Else
            iniread = ""
        End If
    End Function
    Public Overloads Function INIRead(ByVal INIPath As String, _
    ByVal SectionName As String, ByVal KeyName As String) As String
        ' overload 1 assumes zero-length default
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Overloads Function INIRead(ByVal INIPath As String, _
    ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Overloads Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function
#End Region

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String) ' delete single line from section
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub


    Private Sub CreateTemplateIni()
        ' Dim sValue As String
        Dim spath As String = Path.Combine(Directory.GetCurrentDirectory, "plotic_silent_template.ini")

        INIWrite(spath, "Recoil", "RecoilUp", "0.55")
        INIWrite(spath, "Recoil", "RecoilLeft", "0.2")
        INIWrite(spath, "Recoil", "RecoilRight", "0.3")
        INIWrite(spath, "Recoil", "FirstShot", "1.3")

        INIWrite(spath, "Spread", "SpreadMin", "0.1")
        INIWrite(spath, "Spread", "SpreadInc", "0.12")

        INIWrite(spath, "Burst", "BurstsPerBullet", "5")
        INIWrite(spath, "Burst", "Bursts", "1000")

        INIWrite(spath, "Attach", "RenderAttachText", "0")
        INIWrite(spath, "Attach", "AttachRecoilV", "0")
        INIWrite(spath, "Attach", "AttachRecoilH", "0")
        INIWrite(spath, "Attach", "AttachSpreadMin", "0")
        INIWrite(spath, "Attach", "AttachSpreadInc", "0")
        INIWrite(spath, "Attach", "AttachSpreadInc", "0")

        INIWrite(spath, "Save", "SavePath", Directory.GetCurrentDirectory)
        INIWrite(spath, "Save", "FileName", "<<TitleText>>_bf3_<<SubText>>")

        INIWrite(spath, "Render", "ScaleRadius", "1")
        INIWrite(spath, "Render", "RenderBars", "1")

        INIWrite(spath, "Title", "RenderTitleText", "1")
        INIWrite(spath, "Title", "TitleText", "AEK-17")
        INIWrite(spath, "Title", "InfoText", "Dmg: 25-17")
        INIWrite(spath, "Title", "SubText", "Stock")

        INIWrite(spath, "Grid", "RenderGrid", "0")
        INIWrite(spath, "Grid", "Scale", "650")
        INIWrite(spath, "Grid", "IsDegrees", "0")
        INIWrite(spath, "Grid", "Distance", "1")
        INIWrite(spath, "Grid", "GridValue", "1")


        INIWrite(spath, "TTk", "RenderTTK", "0")
        INIWrite(spath, "TTK", "RenderHitRates", "0")



        'INIWrite(spath, "Section1", "Key1-2", "Value1-2")
        'INIWrite(sPath, "Section1", "Key1-3", "Value1-3")
        'INIWrite(sPath, "Section2", "Key2-1", "Value2-1")
        'INIWrite(sPath, "Section2", "Key2-2", "Value2-2")

        'sValue = INIRead(sPath, "section2", "key2-1", "Unknown") ' specify all
        'MessageBox.Show(sValue, "section2/key2-1/unknown", MessageBoxButtons.OK)

        'sValue = INIRead(sPath, "section2", "XYZ", "Unknown") ' specify all
        'MessageBox.Show(sValue, "section2/xyz/unknown", MessageBoxButtons.OK)

        'sValue = INIRead(sPath, "section2", "XYZ") ' use zero-length string as default
        'MessageBox.Show(sValue, "section2/XYZ", MessageBoxButtons.OK)

        'sValue = INIRead(sPath, "section1") ' get all keys in section
        'sValue = sValue.Replace(ControlChars.NullChar, "|"c) ' change embedded NULLs to pipe chars
        'MessageBox.Show(sValue, "section1 pre delete", MessageBoxButtons.OK)

        'INIDelete(sPath, "section1", "key1-2") ' delete middle entry in section 1
        'sValue = INIRead(sPath, "section1") ' get all keys in section again
        'sValue = sValue.Replace(ControlChars.NullChar, "|"c) ' change embedded NULLs to pipe chars
        'MessageBox.Show(sValue, "section1 post delete", MessageBoxButtons.OK)

        'sValue = INIRead(sPath) ' get all section names
        'sValue = sValue.Replace(ControlChars.NullChar, "|"c) ' change embedded NULLs to pipe chars
        'MessageBox.Show(sValue, "All sections pre delete", MessageBoxButtons.OK)

        'INIDelete(sPath, "section1") ' delete section
        'sValue = INIRead(spath) ' get all section names
        'sValue = sValue.Replace(ControlChars.NullChar, "|"c) ' change embedded NULLs to pipe chars
        'MessageBox.Show(sValue, "All sections post delete", MessageBoxButtons.OK)
    End Sub
End Class
Public Structure HeatPoint
    Public X As Integer
    Public Y As Integer
    Public Intensity As Byte
    Public Sub New(iX As Integer, iY As Integer, bIntensity As Byte)
        X = iX
        Y = iY
        Intensity = bIntensity
    End Sub
End Structure

