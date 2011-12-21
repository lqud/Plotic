Public Class Main
    Private Const SCALE_FACTOR As Single = 0.1783

    Dim saveImagePath As String = ""
    Dim intBurstCycle As Integer = 0
    Public Pl As New Plotic

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub drawTitle(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        g.DrawString(txtGunName.Text, New Font("Arial", 90), greenBrush1, 800, 30)
        g.DrawString("Damage: " + txtDamage.Text, New Font("Consolas", 60), greenBrush1, 710, 130)

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
        g.DrawRectangle(pen2, 995, 1880, 5, 80)
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
        g.DrawString("Left Right", New Font("Consolas", 45), greenBrush5, 837, 1820)
        Dim pen111 As New System.Drawing.Pen(Color.YellowGreen, 30)
    End Sub

    Private Sub btnStart_Click() Handles btnStart.Click
        intBurstCycle = -1

        'Disable all of the input boxes
        btnStart.Enabled = False

        Me.grpAttach.Enabled = False
        Me.grpMisc.Enabled = False
        Me.grpRecoil.Enabled = False
        Me.grpRender.Enabled = False
        Me.grpSpread.Enabled = False



        ' Enable to stop button
        btnStop.Enabled = True
        ' Start the Background Worker working

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
        Pl.BulletsPerBurst = txtBulletsPerBurst.Text
        Pl.AdjRecoilH = numRecoilH.Value
        Pl.AdjRecoilV = numRecoilV.Value
        Pl.AdjSpreadInc = numInc.Value
        Pl.AdjSpreadMin = numMin.Value
        Pl.GunName = txtGunName.Text
    End Sub
    Public Function rndD(ByRef upper As Integer, ByRef lower As Integer) As Integer
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
        lblAdjUp.Text = (Math.Round((CDbl(Val(txtRecoilUp.Text)) * (numRecoilV.Value / 100)) + (CDbl(Val(txtRecoilUp.Text))), 3)).ToString
        lblAdjRight.Text = (Math.Round((CDbl(Val(txtRecoilRight.Text)) * (numRecoilH.Value / 100)) + (CDbl(Val(txtRecoilRight.Text))), 3)).ToString
        lblAdjLeft.Text = (Math.Round((CDbl(Val(txtRecoilLeft.Text)) * (numRecoilH.Value / 100)) + (CDbl(Val(txtRecoilLeft.Text))), 3)).ToString

        lblAdjMin.Text = (Math.Round((CDbl(Val(txtSpreadMin.Text)) * (numMin.Value / 100)) + (CDbl(Val(txtSpreadMin.Text))), 3)).ToString
        lblAdjInc.Text = (Math.Round((CDbl(Val(txtSpreadInc.Text)) * (numInc.Value / 100)) + (CDbl(Val(txtSpreadInc.Text))), 3)).ToString

    End Sub

    Private Sub Adjustment_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numRecoilH.ValueChanged, numRecoilV.ValueChanged, numInc.ValueChanged, numMin.ValueChanged
        UpdateAdjustments()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim hits1 = 0
        Dim hits2 = 0
        Dim hits3 = 0
        Dim hits4 = 0
        Dim hits5 = 0

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
        Dim dblRecoilH As Double = Math.Round((Pl.RecoilUp * (Pl.AdjRecoilV / 100)) + (Pl.RecoilUp), 3)
        Dim dblRecoilR As Double = Math.Round((Pl.RecoilRight * (Pl.AdjRecoilH / 100)) + (Pl.RecoilRight), 3)
        Dim dblRecoilL As Double = Math.Round((Pl.RecoilLeft * (Pl.AdjRecoilH / 100)) + (Pl.RecoilLeft), 3)

        Dim dblSpreadMin As Double = Math.Round((Pl.SpreadMin * (Pl.AdjSpreadMin / 100)) + (Pl.SpreadMin), 3)
        Dim dblSpreadInc As Double = Math.Round((Pl.SpreadInc * (Pl.AdjSpreadInc / 100)) + (Pl.SpreadInc), 3)

        Dim b As Bitmap = New Bitmap(2000, 2000)

        Dim sol As Bitmap = New Bitmap(My.Resources.sil_1)
        Dim scale_f = 4.25
        Dim solscaled As New Bitmap(CInt(sol.Width * scale_f), CInt(sol.Height * scale_f))
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
        If chkTitles.Checked Then
            drawTitle(g)
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
            If upd = 100 Then
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
            For a = 0 To Int(Pl.BulletsPerBurst) - 1
                Dim pen1 As New System.Drawing.Pen(Color.YellowGreen, 4)
                Select Case a
                    Case 0
                        pen1.Color = Color.YellowGreen
                    Case 1
                        pen1.Color = Color.Yellow
                    Case 2
                        pen1.Color = Color.Orange
                    Case 3
                        pen1.Color = Color.Red
                    Case 4
                        pen1.Color = Color.DarkRed
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
                If Not chkTimeToKill.Checked Then
                    g.DrawEllipse(pen1, x, y, 7, 7)
                Else
                    Dim colo As Object
                    Dim rgbb As Integer
                    If x < 0 Or y < 0 Or x > 2000 Or y > 2000 Then
                        rgbb = 0
                    Else
                        colo = b.GetPixel(x, y)
                        rgbb = Val(colo.R) + Val(colo.G) + Val(colo.B)
                    End If
                    'Debug.WriteLine((Val(colo.R) + Val(colo.G) + Val(colo.B)).ToString())
                    Select Case a
                        Case 0
                            If rgbb > 50 Then
                                hits1 += 1
                            End If
                            coord1x(ee) = x
                            coord1y(ee) = y
                        Case 1
                            If rgbb > 50 Then
                                hits2 += 1
                            End If
                            coord2x(ee) = x
                            coord2y(ee) = y
                        Case 2
                            If rgbb > 50 Then
                                hits3 += 1
                            End If
                            coord3x(ee) = x
                            coord3y(ee) = y
                        Case 3
                            If rgbb > 50 Then
                                hits4 += 1
                            End If
                            coord4x(ee) = x
                            coord4y(ee) = y
                        Case 4
                            If rgbb > 50 Then
                                hits5 += 1
                            End If
                            coord5x(ee) = x
                            coord5y(ee) = y
                    End Select
                    'g.DrawEllipse(pen1, x, y, 7, 7)
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
            Debug.WriteLine("Hits #1: " & hits1)
            SetHitRateText_ThreadSafe("1st. bullet: " + Math.Round((hits1 / intBursts * 100), 2).ToString + "%" + nl + _
                   "2nd. bullet: " + Math.Round((hits2 / intBursts * 100), 2).ToString + "%" + nl + _
                   "3rd. bullet: " + Math.Round((hits3 / intBursts * 100), 2).ToString + "%" + nl + _
                   "4th. bullet: " + Math.Round((hits4 / intBursts * 100), 2).ToString + "%" + nl + _
                   "5th. bullet: " + Math.Round((hits5 / intBursts * 100), 2).ToString + "%")

        End If
        If chkDrawTTK.Checked And chkTimeToKill.Checked Then
            drawTTK(g, Math.Round((hits1 / intBursts * 100), 2), Math.Round((hits2 / intBursts * 100), 2), Math.Round((hits3 / intBursts * 100), 2), Math.Round((hits4 / intBursts * 100), 2), Math.Round((hits5 / intBursts * 100), 2))
        End If
        SetImage_ThreadSafe(b)
        Pl.Image = b
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
        End If

        Me.btnStart.Enabled = True
        Me.btnStop.Enabled = False

        Me.grpAttach.Enabled = True
        Me.grpMisc.Enabled = True
        Me.grpRecoil.Enabled = True
        Me.grpRender.Enabled = True
        Me.grpSpread.Enabled = True

        If chkSaveImage.Checked Then
            Debug.WriteLine("Saving Image")
            SaveImage()
        End If
    End Sub
    Private Sub SaveImage()
        Dim b As Bitmap = Pl.Image
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
            Dim MyDelegate As New SetCounterText_Delegate(AddressOf SetHitRateText_ThreadSafe)
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
            intBurstCycle += 1
            lblBurstCounter.Text = "Burst " + intBurstCycle.ToString + " / " + Pl.Burst.ToString
        End If

    End Sub
    Delegate Sub SetCounterText_Delegate(ByVal [text] As String)
    ' The delegates subroutine.
    Private Sub SetCounterText_ThreadSafe(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If lblBurstCounter.InvokeRequired Then
            Dim MyDelegate As New SetCounterText_Delegate(AddressOf SetCounterText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[text]})
        Else
            lblBurstCounter.Text = [text]
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

    Private Sub chkSaveImage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSaveImage.CheckedChanged
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
        Me.ToolStripProgressBar2.Value = e.ProgressPercentage
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
End Class