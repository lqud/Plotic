Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms

Public Class Main
    Private Const UPDATE_PERIOD As Integer = 100
    Private Const IMAGE_V_CENTER_PERCENT As Double = 224 / 667
    Private Const IMAGE_H_CENTER_PERCENT As Double = 108 / 223
    Private Const VERSION As String = "Plotic v2.1"

    Private HeatPoints As New List(Of HeatPoint)()

    Private saveImagePath As String = ""
    Private saveImageFileName As String = ""
    Private silentTemplateFile As String = ""
    Private paletteOverride As Boolean = False
    Private silentRun As Boolean = False
    Private intBurstCycle As Integer = 0

    Public Pl As New Plotic


    Private Sub exitApplication()
        System.Environment.Exit(1)
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainToolStripStatus.Text = VERSION
        Me.Text = VERSION
        'Dim test2 = GetValue("G3A3", "WeaponClass")
        'Dim test2a = GetValue("G3A3", "MagazineCapacity")
        'Dim test2b = GetValue("G3A3", "NumberOfMagazines")
        'Dim test2c = GetValue("G3A3", "TraceFrequency")
        'Dim test2d = GetValue("G3A3", "RateOfFire")
        'Dim test2e = GetValue("G3A3", "RateOfFireForBurst")
        'Dim test02 = GetAttachmentValue("FAMAS", "HeavyBarrel", "DecreasePerSecondModifier", "StandZoom")
        'Dim test02a = GetAttachmentValue("FAMAS", "Silencer", "DecreasePerSecondModifier", "StandZoom")
        'Dim test04 = GetValue("FAMAS", "RecoilAmplitudeMax")
        'Vert Recoil Adjust
        'Dim test05 = GetAttachmentValue("FAMAS", "HeavyBarrel", "RecoilMagnitudeMod", "StandNoZoom")
        'horizontal recoil adjust
        'Dim test06 = GetAttachmentValue("FAMAS", "Foregrip", "RecoilAngleMod", "StandNoZoom")

        'Min Adjust
        'Dim test01 = GetAttachmentValue("FAMAS", "HeavyBarrel", "MinAngleModifier", "StandNoZoom")
        'Inc Adjust
        'Dim test03 = GetAttachmentValue("FAMAS", "HeavyBarrel", "IncreasePerShotModifier", "StandNoZoom")

        'right recoil
        'Dim test3 = GetValue("G3A3", "HorizontalRecoilAmplitudeIncPerShotMin")
        'left recoil
        'Dim test4 = GetValue("G3A3", "HorizontalRecoilAmplitudeIncPerShotMax")

        'Dim test5 = GetValue("G3A3", "HorizontalRecoilAmplitudeMax")
        'up recoil
        'Dim test6 = GetValue("G3A3", "RecoilAmplitudeIncPerShot")

        'Dim test7 = GetValue("G3A3", "RecoilAmplitudeDecreaseFactor")
        'Dim test8 = GetValue("G3A3", "RecoilAmplitudeMax")
        'first shot
        'Dim test0 = GetAttachmentValue("G3A3", "TargetPointer", "MinAngleModifier", "StandZoom")
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
        Dim silentIniPath As String = Path.Combine(Directory.GetCurrentDirectory, "plotic_silent.ini")
        If File.Exists(silentIniPath) Then
            Debug.WriteLine("FOUND: " & silentIniPath)
            Me.WindowState = FormWindowState.Minimized
            silentTemplateFile = silentIniPath
            startSilent()
        Else
            Debug.WriteLine("NOT FOUND: " & silentIniPath)
        End If

        'Check for Template file, if it isn't found, create it.
        Dim silentIniTemplatePath As String = Path.Combine(Directory.GetCurrentDirectory, "plotic_silent_template.ini")
        If File.Exists(silentIniTemplatePath) Then
            Debug.WriteLine("FOUND: " & silentIniTemplatePath)
        Else
            Debug.WriteLine("NOT FOUND: " & silentIniTemplatePath)
            CreateTemplateIni()
        End If
        picPlot.Image = New Bitmap(My.Resources.knife)
        picPlot.SizeMode = PictureBoxSizeMode.Zoom
        comboWeapon1.Items.Add("<<CUSTOM>>")
        Dim Mypath As String, MyName As String, iCount As Integer
        iCount = 0
        Mypath = Directory.GetCurrentDirectory & "\weapons\" ' Set the path.
        MyName = Dir(Mypath, vbDirectory)   ' Retrieve the first entry.
        Do While MyName <> ""   ' Start the loop.
            ' Ignore the current directory and the encompassing directory.
            If MyName <> "." And MyName <> ".." Then
                ' Use bitwise comparison to make sure MyName is a directory.
                If (GetAttr(Mypath & MyName) And vbDirectory) = vbDirectory Then
                    'Debug.WriteLine(MyName)   ' Display entry only if it
                    comboWeapon1.Items.Add(MyName)
                    If iCount = 0 Then
                        comboWeapon1.Text = MyName
                    End If
                    iCount = iCount + 1
                End If   ' it represents a directory.
            End If
            MyName = Dir()   ' Get next entry.
        Loop
        Debug.WriteLine("No.of Folders in the weapons path : " & iCount)
    End Sub

    Public Sub drawTTKSplit(ByVal g As Graphics)
        g.Clear(Color.Black)
        g.DrawImage(Pl.Image, 0, 0, 1000, 1000)
        g.DrawImage(Pl.HeatMap, 1000, 0, 1000, 1000)
        Dim centerx = 1000
        Dim centy = 1680
        Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 5)
        pen6.DashStyle = Drawing2D.DashStyle.Solid
        g.DrawLine(pen6, 1000, 0, 1000, 1000)
        g.DrawLine(pen6, 0, 1000, 2000, 1000)
    End Sub
    Public Sub drawTTKGrid(ByVal g As Graphics)

        Dim topY = 1500
        Dim bottomY = 1950
        Dim rightX = 1950
        Dim leftX = 50

        Dim graphWidth = 1900
        Dim graphHeight = 450
        Dim brushYellow As New SolidBrush(Color.Yellow)
        Dim brushBlue As New SolidBrush(Color.LightBlue)
        Dim brushLightBlue As New SolidBrush(Color.LightCyan)
        Dim brushGoldenRod As New SolidBrush(Color.Goldenrod)

        Dim penScale As New System.Drawing.Pen(Color.Yellow, 1)
        penScale.DashStyle = Drawing2D.DashStyle.Dot

        Dim xPixel As Integer = leftX
        Dim pixelsPerNMeters As Integer = Math.Round((numTTKHorizontalScale.Value * (graphWidth / numTTKRange.Value)), 0)
        Dim meterValue As Integer = 0

        Dim pixelsPerMeter As Integer = Math.Round(((graphWidth / numTTKRange.Value)), 0)
        Dim metersperPixel As Double = 1 / pixelsPerMeter

        g.DrawString("0", New Font("Arial", 25), brushYellow, (xPixel - 5), (bottomY + 10))
        g.DrawLine(penScale, xPixel, topY, xPixel, bottomY)
        meterValue += numTTKHorizontalScale.Value
        xPixel = xPixel + pixelsPerNMeters
        Do While (xPixel < rightX)
            g.DrawLine(penScale, xPixel, topY, xPixel, bottomY)
            g.DrawString(meterValue & "m", New Font("Arial", 25), brushYellow, (xPixel - 50), (bottomY + 10))
            xPixel = xPixel + pixelsPerNMeters
            meterValue += numTTKHorizontalScale.Value
        Loop

        Dim yPixel As Integer = topY
        Dim pixelsPerLine As Double = Math.Round(graphWidth / (numDamageMax.Value - numDamageMin.Value) * numTTKVerticalScale.Value, 0)
        Dim penDamage As New System.Drawing.Pen(Color.LightBlue, 1)
        Dim penDamageAlt As New System.Drawing.Pen(Color.LightCyan, 1)
        Dim penDamageEdge As New System.Drawing.Pen(Color.Blue, 3)
        penDamage.DashStyle = Drawing2D.DashStyle.Dash

        ' pixelsPerNMeters = Math.Round((numTTKGridSpacing.Value * (1980 / 80)), 0)
        Dim meterYValue As Integer = pixelsPerLine
        'Draw Top Line
        g.DrawLine(penDamageEdge, leftX, yPixel, rightX, yPixel)
        g.DrawString(numDamageMax.Value, New Font("Arial", 30), brushBlue, (rightX - 5), (yPixel - 25))

        'Draw Top Line
        Dim rangeInMeters As Double = rightX * metersperPixel

        Dim dblDamageAtMaxRange As Double = numDamageMin.Value + (((numDamageMax.Value - numDamageMin.Value) / (numMaxRange.Value - numMinRange.Value)) * (numTTKRange.Value - numMinRange.Value))
        Dim dblDamageAtMinRange As Double = numDamageMin.Value + (((numDamageMax.Value - numDamageMin.Value) / (numMaxRange.Value - numMinRange.Value)) * (0 - numMinRange.Value))

        Dim TTK As Double = ((Math.Round((100 / dblDamageAtMaxRange), 0) - 1) / (Pl.RateOfFire / 60)) + (numTTKRange.Value / Pl.BulletVelocity)
        Dim TTKMin As Double = ((Math.Round((100 / numDamageMax.Value), 0) - 1) / (Pl.RateOfFire / 60)) + (numTTKRange.Value / Pl.BulletVelocity)
        g.DrawString((Math.Round((TTK * 1000), 0)) & "ms", New Font("Arial", 15), brushGoldenRod, (leftX - 45), (yPixel + 5))

        'g.DrawLine(penDamage, 10, yPixel, 1950, yPixel)
        yPixel = yPixel + pixelsPerLine
        Dim intAltToggle As Integer = 0
        Do While (yPixel < bottomY)
            Dim linePercent As Double = meterYValue / graphHeight
            Dim lineDamage As Double = Math.Round(numDamageMax.Value - ((numDamageMax.Value - numDamageMin.Value) * linePercent), 1)
            If intAltToggle = 1 Then
                g.DrawLine(penDamageAlt, leftX, yPixel, bottomY, yPixel)
                g.DrawString(lineDamage, New Font("Arial", 15), brushLightBlue, (rightX - 5), (yPixel + 5))
            Else
                g.DrawLine(penDamage, leftX, yPixel, bottomY, yPixel)
                g.DrawString(lineDamage, New Font("Arial", 15), brushBlue, (rightX - 5), (yPixel + 5))

            End If
            yPixel = yPixel + pixelsPerLine
            meterYValue += pixelsPerLine
            If intAltToggle = 1 Then
                intAltToggle = 0
            Else
                intAltToggle = 1
            End If
        Loop
        'Draw Right Bottom Line
        g.DrawString(numDamageMin.Value, New Font("Arial", 30), brushBlue, (rightX - 5), (yPixel - 25))
        g.DrawLine(penDamageEdge, leftX, bottomY, rightX, bottomY)

        'Draw Left Bottom Line
        g.DrawString((Math.Round((TTKMin * 1000), 0)) & "ms", New Font("Arial", 15), brushGoldenRod, (leftX - 45), (yPixel - 25))

        'g.DrawString(numDamageMin.Value, New Font("Arial", 30), brushBlue, 1950, 1950)
    End Sub
    Public Sub drawTTK(ByVal g As Graphics, ByVal Hit1 As Integer, ByVal Hit2 As Integer, ByVal Hit3 As Integer, ByVal Hit4 As Integer, ByVal Hit5 As Integer)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim greenBrush2 As New SolidBrush(Color.Goldenrod)
        Dim hPos As Integer = 1550
        Dim rect As New Rectangle(1528, 23, 465, 260)
        g.FillRectangle(New SolidBrush(Color.FromArgb(127, 0, 0, 0)), rect)
        g.DrawString("Average Hit Rates", New Font("Consolas", 35), greenBrush2, (hPos - 20), 25)
        g.DrawString("1st Bullet: " + Hit1.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 70)
        g.DrawString("2nd Bullet: " + Hit2.ToString + "%", New Font("Consolas", 30), greenBrush2, hPos, 110)
        g.DrawString("3rd Bullet: " + Hit3.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 150)
        g.DrawString("4th Bullet: " + Hit4.ToString + "%", New Font("Consolas", 30), greenBrush2, hPos, 190)
        g.DrawString("5th Bullet: " + Hit5.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 230)
    End Sub
    Public Sub drawTTKBulletDamageArc(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim topY = 1500
        Dim bottomY = 1950
        Dim rightX = 1925
        Dim leftX = 50

        Dim graphWidth = rightX - leftX
        Dim graphHeight = bottomY - topY
        Dim pixelsPerMeter As Integer = Math.Round(((graphWidth / numTTKRange.Value)), 0)
        Dim metersperPixel As Double = 1 / pixelsPerMeter

        Dim damageDifference As Double = numDamageMax.Value - numDamageMin.Value
        Dim distanceDifference As Double = numMinRange.Value - numMaxRange.Value

        Dim penRed As New System.Drawing.Pen(Color.Red, 3)
        Dim penWhite As New System.Drawing.Pen(Color.White, 1)
        penRed.DashStyle = Drawing2D.DashStyle.Solid
        penWhite.DashStyle = Drawing2D.DashStyle.Solid

        'Calculate the position of the other points
        Dim yValue As Integer = topY
        For i = leftX To rightX Step 1

            Dim rangeInMeters As Double = (i - leftX) * metersperPixel

            If rangeInMeters <= numMaxRange.Value Then
                ' Debug.WriteLine(rangeInMeters & "-> " & yValue)
                yValue = topY
            ElseIf rangeInMeters >= numMinRange.Value Then
                yValue = bottomY
                ' Debug.WriteLine(rangeInMeters & "-> " & yValue)
            Else
                Dim a As Double = rangeInMeters - numMaxRange.Value
                Dim b As Double = a / distanceDifference
                Dim c As Double = damageDifference * b
                Dim d As Double = Math.Round(numDamageMax.Value - c, 2)
                ' Debug.WriteLine(rangeInMeters & "-> " & d)
                Dim e As Double = Math.Round(graphHeight * b, 2)
                yValue = Math.Round(topY + e, 0)

            End If

            g.DrawEllipse(penRed, i, yValue, 1, 1)
        Next

    End Sub
    Public Sub drawTTKChart(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim topY = 1500
        Dim bottomY = 1950
        Dim rightX = 1925
        Dim leftX = 50

        Dim graphWidth = rightX - leftX
        Dim graphHeight = bottomY - topY
        Dim pixelsPerMeter As Integer = Math.Round(((graphWidth / numTTKRange.Value)), 0)
        Dim metersperPixel As Double = 1 / pixelsPerMeter

        Dim damageDifference As Double = numDamageMax.Value - numDamageMin.Value
        Dim distanceDifference As Double = numMinRange.Value - numMaxRange.Value

        Dim penRed As New System.Drawing.Pen(Color.Red, 3)
        Dim penWhite As New System.Drawing.Pen(Color.White, 1)
        penRed.DashStyle = Drawing2D.DashStyle.Solid
        penWhite.DashStyle = Drawing2D.DashStyle.Solid

        Dim maxRangeInMeters As Double = rightX * metersperPixel

        Dim dblMaxDamageAtRange As Double = numDamageMin.Value + (((numDamageMax.Value - numDamageMin.Value) / (numMaxRange.Value - numMinRange.Value)) * (numTTKRange.Value - numMinRange.Value))
        Dim maxTTK As Double = ((Math.Round((100 / dblMaxDamageAtRange), 0) - 1) / (Pl.RateOfFire / 60)) + (maxRangeInMeters / Pl.BulletVelocity)


        'Calculate the position of the other points
        Dim yValue As Integer = topY
        For i = leftX To rightX Step 1
            Dim rangeInMeters As Double = (i - leftX) * metersperPixel

            'Dim damageAtDistance As Double = Pl.
            Dim dblDamageAtRange As Double = numDamageMin.Value + (((numDamageMax.Value - numDamageMin.Value) / (numMaxRange.Value - numMinRange.Value)) * (numTTKRange.Value - numMinRange.Value))
            Dim TTK As Double = ((Math.Round((100 / dblDamageAtRange), 0) - 1) / (Pl.RateOfFire / 60)) + (rangeInMeters / Pl.BulletVelocity)
            Debug.WriteLine(i & ": " & rangeInMeters & "-> " & Math.Round(TTK, 6) & " :: " & Math.Round(TTK / maxTTK, 4))

            If rangeInMeters <= numMaxRange.Value Then
                ' Debug.WriteLine(rangeInMeters & "-> " & yValue)
                yValue = topY
            ElseIf rangeInMeters >= numMinRange.Value Then
                yValue = bottomY
                ' Debug.WriteLine(rangeInMeters & "-> " & yValue)
            Else
                Dim a As Double = rangeInMeters - numMaxRange.Value
                Dim b As Double = TTK / maxTTK
                Dim c As Double = damageDifference * b
                Dim d As Double = Math.Round(numDamageMax.Value - c, 2)
                ' Debug.WriteLine(rangeInMeters & "-> " & d)
                Dim e As Double = Math.Round(graphHeight * b, 2)
                yValue = Math.Round(bottomY - e, 0)

            End If

            g.DrawEllipse(penRed, i, yValue, 1, 1)
        Next

    End Sub

    Public Sub drawDropGrid(ByVal g As Graphics)


        Dim topY = 1010
        Dim bottomY = 1450
        Dim rightX = 1925
        Dim leftX = 10
        Dim graphWidth = rightX - leftX
        Dim graphHeight = bottomY - topY
        Dim peakH = (Pl.BulletVelocity * Math.Sin(Pl.correctionAngle(15) * (Math.PI / 180)) - Pl.BulletDrop * 0) ^ 2 / (2 * Pl.BulletDrop)

        Dim verticleDistanceDifference = peakH + Math.Abs(Pl.dropInMeters(15))
        Dim VmetersperPixel As Double = 1 / (graphHeight / Math.Abs(Pl.dropInMeters(15, Pl.TargetRange)))

        Dim peakPercent As Double = peakH / verticleDistanceDifference
        Dim dropPercent As Double = Math.Abs(Pl.dropInMeters(15)) / verticleDistanceDifference

        Dim centerPixel As Integer = topY + Math.Round(peakPercent * graphHeight, 0)

        Dim adjVmetersperPixel As Double = 1 / ((graphHeight - Math.Round(peakPercent * graphHeight, 0)) / Math.Abs(Pl.dropInMeters(15, Pl.TargetRange)))

        Dim brushYellow As New SolidBrush(Color.Yellow)
        Dim brushBlue As New SolidBrush(Color.LightBlue)
        Dim brushLightBlue As New SolidBrush(Color.LightCyan)
        Dim penScale As New System.Drawing.Pen(Color.Yellow, 1)
        penScale.DashStyle = Drawing2D.DashStyle.Dot

        Dim brushLightGreen As New SolidBrush(Color.LightGreen)
        Dim penZeroMark As New System.Drawing.Pen(Color.LightGreen, 1)
        penZeroMark.DashStyle = Drawing2D.DashStyle.DashDotDot

        Dim xPixel As Integer = leftX
        Dim pixelsPerNMeters As Integer = Math.Round((numDropHorizontalScale.Value * (graphWidth / Pl.TargetRange)), 0)
        Dim meterValue As Integer = 0
        g.DrawString("0", New Font("Arial", 25), brushYellow, (xPixel + 2), (bottomY + 5))
        g.DrawLine(penScale, xPixel, topY, xPixel, bottomY)
        meterValue += numDropHorizontalScale.Value
        xPixel = xPixel + pixelsPerNMeters
        Do While (xPixel < rightX)
            g.DrawLine(penScale, xPixel, topY, xPixel, bottomY)
            g.DrawString(meterValue & "m", New Font("Arial", 25), brushYellow, (xPixel - 50), (bottomY + 5))
            xPixel = xPixel + pixelsPerNMeters
            meterValue += numDropHorizontalScale.Value
        Loop

        Dim yPixel As Integer = centerPixel
        Dim pixelsPerLine As Double = Math.Round((graphHeight - Math.Round(peakPercent * graphHeight, 0)) / Math.Abs(Pl.dropInMeters(15)) * numDropVerticalScale.Value, 0)

        Dim penDamage As New System.Drawing.Pen(Color.LightBlue, 1)
        Dim penDamageAlt As New System.Drawing.Pen(Color.LightCyan, 1)
        Dim penDamageEdge As New System.Drawing.Pen(Color.Blue, 3)
        penDamage.DashStyle = Drawing2D.DashStyle.Dash

        ' pixelsPerNMeters = Math.Round((numTTKGridSpacing.Value * (1980 / 80)), 0)
        Dim meterYValue As Integer = pixelsPerLine

        'Draw Zero Marker
        g.DrawLine(penZeroMark, leftX, centerPixel, rightX, centerPixel)
        g.DrawString(0, New Font("Arial", 15), brushLightGreen, (rightX + 1), centerPixel - 10)

        'Draw Top Line
        g.DrawLine(penDamageEdge, leftX, topY, rightX, topY)
        g.DrawString(Math.Round(peakH, 2) & "m", New Font("Arial", 20), brushBlue, (rightX - 15), (topY + 15))


        'g.DrawLine(penDamage, 10, yPixel, 1950, yPixel)
        yPixel = yPixel  + pixelsPerLine
        Dim intAltToggle As Integer = 0
        Do While (yPixel < bottomY)
            Dim linePercent As Double = meterYValue / graphHeight
            Dim lineDrop As Double = Math.Round(adjVmetersperPixel * meterYValue, 2)
            If intAltToggle = 1 Then
                g.DrawLine(penDamageAlt, leftX, yPixel, rightX, yPixel)
                g.DrawString("-" & lineDrop & "m", New Font("Arial", 15), brushLightBlue, (rightX + 1), (yPixel - 10))
            Else
                g.DrawLine(penDamage, leftX, yPixel, rightX, yPixel)
                g.DrawString("-" & lineDrop & "m", New Font("Arial", 15), brushBlue, (rightX + 1), (yPixel - 10))

            End If
            yPixel = yPixel + pixelsPerLine
            meterYValue += pixelsPerLine
            If intAltToggle = 1 Then
                intAltToggle = 0
            Else
                intAltToggle = 1
            End If
        Loop
        'Draw Bottom Line
        g.DrawString(Pl.dropInMeters(2, Pl.TargetRange) & "m", New Font("Arial", 20), brushBlue, (rightX - 15), (bottomY - 35))
        g.DrawLine(penDamageEdge, leftX, bottomY, rightX, bottomY)
        'g.DrawString(numDamageMin.Value, New Font("Arial", 30), brushBlue, 1950, 1950)
    End Sub
    Public Sub drawTTKBulletDropArc(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)

        Dim topY = 1010
        Dim bottomY = 1450
        Dim rightX = 1925
        Dim leftX = 10
        Dim graphWidth = rightX - leftX
        Dim graphHeight = bottomY - topY
        Dim peakH = (Pl.BulletVelocity * Math.Sin(Pl.correctionAngle(15) * (Math.PI / 180)) - Pl.BulletDrop * 0) ^ 2 / (2 * Pl.BulletDrop)

        Dim verticleDistanceDifference = peakH + Math.Abs(Pl.dropInMeters(15))
        Dim pixelsPerMeter = Math.Round(graphHeight / verticleDistanceDifference, 0)

        Dim peakPercent As Double = peakH / verticleDistanceDifference
        Dim dropPercent As Double = Math.Abs(Pl.dropInMeters(15)) / verticleDistanceDifference

        Dim centerPixel As Integer = topY + Math.Round(peakPercent * graphHeight, 0)

        Dim HmetersperPixel As Double = 1 / (graphWidth / Pl.TargetRange)
        Dim VmetersperPixel As Double = 1 / (graphHeight / Math.Abs(Pl.dropInMeters(15, Pl.TargetRange)))

        Dim damageDifference As Double = numDamageMax.Value - numDamageMin.Value
        Dim distanceDifference As Double = numMinRange.Value - numMaxRange.Value

        Dim penRed As New System.Drawing.Pen(Color.Red, 3)
        Dim penWhite As New System.Drawing.Pen(Color.White, 3)
        penRed.DashStyle = Drawing2D.DashStyle.Solid
        penWhite.DashStyle = Drawing2D.DashStyle.Solid

        'Calculate the position of the other points
        Dim yValue As Integer = 0
        For i = leftX To rightX Step 1

            Dim rangeInMeters As Double = i * HmetersperPixel

            Dim e = (Pl.BulletVelocity * Math.Sin(0) * Pl.timeOfFlight(15, rangeInMeters) - 0.5 * Pl.BulletDrop * Pl.timeOfFlight(15, rangeInMeters) * Pl.timeOfFlight(15, rangeInMeters))
            Dim percentOfHeight = Math.Abs(e / verticleDistanceDifference)
            Dim pixelAdjust = Math.Round(percentOfHeight * (graphHeight), 0)

            yValue = Math.Round(centerPixel + pixelAdjust, 0)
            If (yValue <= bottomY) Then
                'Debug.WriteLine(rangeInMeters & "-> " & e & "m " & Math.Round(percentOfHeight * 100, 2) & "%")
                g.DrawEllipse(penRed, i, yValue, 1, 1)
            End If

            e = (Pl.BulletVelocity * Math.Sin(Pl.correctionAngle(15) * Math.PI / 180) * Pl.timeOfFlight(15, rangeInMeters) - 0.5 * Pl.BulletDrop * Pl.timeOfFlight(15, rangeInMeters) * Pl.timeOfFlight(15, rangeInMeters))
            percentOfHeight = Math.Abs(e) / peakH
            pixelAdjust = Math.Round(percentOfHeight * (peakPercent * graphHeight), 0)
            yValue = Math.Round(centerPixel - pixelAdjust, 0)
            If (yValue <= bottomY) Then
                'Debug.WriteLine(rangeInMeters & "-> " & e & "m " & percentOfHeight & "%")
                g.DrawEllipse(penWhite, i, yValue, 1, 1)
            End If


        Next

    End Sub
    Private Sub drawBulletDrop(ByVal g As Graphics)
        Dim centerx = 1000
        Dim centery = 1680
        Dim penAdjustTarget As New System.Drawing.Pen(Color.White, numDropLineThickness.Value)
        Dim penDropTarget As New System.Drawing.Pen(Color.Red, numDropLineThickness.Value)
        Dim pen6 As New System.Drawing.Pen(Color.White, numDropLineThickness.Value)
        pen6.DashStyle = Drawing2D.DashStyle.Solid

        Dim bulletAdjustX = centerx - 25
        Dim bulletAdjustY = (centery - Pl.correctionInPixels) - 25

        Dim bulletTargetX = centerx - 25
        Dim bulletTargetY = (centery - Pl.dropInPixels) - 25

        If radBulletDropRenderType1.Checked Then
            g.DrawEllipse(penAdjustTarget, bulletAdjustX, bulletAdjustY, 50, 50)
            g.DrawEllipse(penDropTarget, bulletTargetX, bulletTargetY, 50, 50)

        ElseIf radBulletDropRenderType2.Checked Then
            g.DrawLine(penAdjustTarget, centerx - 25, bulletAdjustY + 25, centerx + 25, bulletAdjustY + 25)
            g.DrawLine(penDropTarget, centerx - 25, bulletTargetY + 25, centerx + 25, bulletTargetY + 25)

        ElseIf radBulletDropRenderType3.Checked Then
            g.DrawEllipse(penAdjustTarget, bulletAdjustX, bulletAdjustY, 50, 50)
            g.DrawLine(penAdjustTarget, centerx - 25, bulletAdjustY + 25, centerx + 25, bulletAdjustY + 25)

            g.DrawLine(penDropTarget, centerx - 25, bulletTargetY + 25, centerx + 25, bulletTargetY + 25)
            g.DrawEllipse(penDropTarget, bulletTargetX, bulletTargetY, 50, 50)
        End If
    End Sub
    Public Sub drawDropInfo(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim greenBrush2 As New SolidBrush(Color.Goldenrod)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim whiteBrush As New SolidBrush(Color.White)
        Dim hPos As Integer = 5
        Dim rect As New Rectangle(3, 248, 700, 180)
        g.FillRectangle(New SolidBrush(Color.FromArgb(127, 0, 0, 0)), rect)

        Dim test As Double = Pl.correctionAngle(5, 700)
        If Pl.TargetRange > Pl.MaxDistance Then
            g.DrawString("Bullet Drop @ " & numMeters.Value.ToString & " meters", New Font("Consolas", 35), redBrush, hPos, 250)
            g.DrawString("Down: " + Pl.dropInMeters(4).ToString + " meters", New Font("Consolas", 30), redBrush, hPos, 295)
            g.DrawString("Adjustment: " + Pl.correctionInMeters(4).ToString + " meters @ " & Pl.correctionAngle(5).ToString & Chr(176), New Font("Consolas", 30), redBrush, hPos, 335)
            g.DrawString("Time of Flight: " + Pl.timeOfFlight(4).ToString + " seconds", New Font("Consolas", 30), redBrush, hPos, 375)
        Else
            g.DrawString("Bullet Drop @ " & numMeters.Value.ToString & " meters", New Font("Consolas", 35), greenBrush2, hPos, 250)
            If chkRenderBulletDrop.Checked Then
                g.DrawString("Down: " + Pl.dropInMeters(4).ToString + " meters", New Font("Consolas", 30), redBrush, hPos, 295)
                g.DrawString("Adjustment: " + Pl.correctionInMeters(4).ToString + " meters @ " & Pl.correctionAngle(5).ToString & Chr(176), New Font("Consolas", 30), whiteBrush, hPos, 335)
            Else
                g.DrawString("Down: " + Pl.dropInMeters(4).ToString + " meters", New Font("Consolas", 30), greenBrush1, hPos, 295)
                g.DrawString("Adjustment: " + Pl.correctionInMeters(4).ToString + " meters @ " & Pl.correctionAngle(5).ToString & Chr(176), New Font("Consolas", 30), greenBrush2, hPos, 335)

            End If
            g.DrawString("Time of Flight: " + Pl.timeOfFlight(4).ToString + " seconds", New Font("Consolas", 30), greenBrush1, hPos, 375)
        End If

        'g.DrawString("Correction: " + Pl. + "%", New Font("Consolas", 30), greenBrush1, hPos, 190)
    End Sub

    Public Sub drawTitle(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim rect As New Rectangle(700, 28, 675, 250)
        g.FillRectangle(New SolidBrush(Color.FromArgb(127, 0, 0, 0)), rect)
        g.DrawString(Pl.Title, New Font("Arial", 90), greenBrush1, 800, 30)
        g.DrawString(Pl.Info, New Font("Consolas", 60), greenBrush1, 710, 130)
        g.DrawString(Pl.SubText, New Font("Consolas", 40), greenBrush1, 710, 220)

    End Sub
    Public Sub drawGrid(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim centerx = 1000
        Dim centy = 1680
        Dim imageEdgeReached As Boolean = False

        If Not radMeters.Checked Then
            Dim gridx = centerx
            Dim gridy = centy
            Dim direction = 1
            Dim direction1 = 1

            Do Until imageEdgeReached
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                pen6.DashStyle = Drawing2D.DashStyle.Dot
                g.DrawLine(pen6, gridx, 0, gridx, 2000)
                If direction = 1 Then
                    gridx = gridx - Val(Pl.Scale) / (1 / Pl.GridLineSpace)
                    If gridx < 0 Then
                        direction = 0
                    End If
                Else
                    gridx = gridx + Val(Pl.Scale) / (1 / Pl.GridLineSpace)
                End If
                If gridx > 2000 Then
                    imageEdgeReached = True
                End If
            Loop

            imageEdgeReached = False
            Do Until imageEdgeReached
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                g.DrawLine(pen6, 0, gridy, 2000, gridy)
                If direction1 = 1 Then
                    gridy = gridy - Val(Pl.Scale) / (1 / Pl.GridLineSpace)
                    If gridy < 0 Then
                        direction1 = 0
                    End If
                Else
                    gridy = gridy + Val(Pl.Scale) / (1 / Pl.GridLineSpace)
                End If
                If gridy > 2000 Then
                    imageEdgeReached = True
                End If
            Loop
        Else
            Dim gridx = centerx
            Dim gridy = centy
            Dim direction = 1
            Dim direction1 = 1
            Dim pixelMovement = Val(Pl.Scale) * (Math.Atan((Pl.GridLineSpace / Pl.TargetRange)) * (180 / Math.PI))
            Dim cycles = Math.Floor(((2000 - centerx) / pixelMovement) * 2) * 2
            Dim currentCycle As Integer = 1
            Do Until imageEdgeReached
                mainToolStripStatus.Text = "Drawing vertical grid, convert degrees->radians->meters " + currentCycle.ToString + "/" + cycles.ToString
                Application.DoEvents()
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                pen6.DashStyle = Drawing2D.DashStyle.Dot
                g.DrawLine(pen6, gridx, 0, gridx, 2000)
                If direction = 1 Then
                    gridx = gridx - Val(Pl.Scale) * (Math.Atan((Pl.GridLineSpace / Pl.TargetRange)) * (180 / Math.PI))
                    If gridx < 0 Then
                        direction = 0
                    End If
                Else
                    gridx = gridx + Val(Pl.Scale) * (Math.Atan((Pl.GridLineSpace / Pl.TargetRange)) * (180 / Math.PI))
                End If
                If gridx > 2000 Then
                    imageEdgeReached = True
                End If
                currentCycle += 1
            Loop

            imageEdgeReached = False
            currentCycle = 1
            Do Until imageEdgeReached
                mainToolStripStatus.Text = "Drawing horizontal grid, convert degrees->radians->meters " + currentCycle.ToString + "/" + cycles.ToString
                Application.DoEvents()
                Dim pen6 As New System.Drawing.Pen(Color.YellowGreen, 1)
                g.DrawLine(pen6, 0, gridy, 2000, gridy)
                If direction1 = 1 Then
                    gridy = gridy - Val(Pl.Scale) * (Math.Atan((Pl.GridLineSpace / Pl.TargetRange)) * (180 / Math.PI))
                    If gridy < 0 Then
                        direction1 = 0
                    End If
                Else
                    gridy = gridy + Val(Pl.Scale) * (Math.Atan((Pl.GridLineSpace / Pl.TargetRange)) * (180 / Math.PI))
                End If
                If gridy > 2000 Then
                    imageEdgeReached = True
                End If
                currentCycle += 1
            Loop
        End If

    End Sub

    Public Sub drawAdjustments(ByVal g As Graphics)
        Dim greenBrush1 As New SolidBrush(Color.YellowGreen)
        Dim greenBrush2 As New SolidBrush(Color.Goldenrod)
        Dim hPos As Integer = 5
        Dim rect As New Rectangle(3, 23, 350, 220)
        g.FillRectangle(New SolidBrush(Color.FromArgb(127, 0, 0, 0)), rect)
        g.DrawString("Adjustments", New Font("Consolas", 35), greenBrush2, hPos, 25)
        g.DrawString("Recoil V: " + Pl.AdjRecoilV.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 70)
        g.DrawString("Recoil H: " + Pl.AdjRecoilH.ToString + "%", New Font("Consolas", 30), greenBrush2, hPos, 110)
        g.DrawString("Spread Min: " + Pl.AdjSpreadMin.ToString + "%", New Font("Consolas", 30), greenBrush1, hPos, 150)
        g.DrawString("Spread Inc: " + Pl.AdjSpreadInc.ToString + "%", New Font("Consolas", 30), greenBrush2, hPos, 190)
    End Sub
    Public Sub drawBars(ByVal g As Graphics)
        ' prnt("Draw bars")
        Dim pen1 As New System.Drawing.Pen(Color.YellowGreen, 30)
        Dim penAdustments As New System.Drawing.Pen(Color.Green, 30)
        Dim pen2 As New System.Drawing.Pen(Color.Black, 30)
        Dim scale = 1500
        Dim x1 = 40
        Dim y = 1800
        Dim x2 = 130
        Dim x3 = 220
        Dim height1 As Integer = CDbl(Val(Pl.RecoilLeft)) * (scale - 400)
        Dim heightAdjust1 As Integer = CDbl(Val(calculateAdjustment(Pl.RecoilLeft, Pl.AdjRecoilH))) * (scale - 400)
        Dim height2 As Integer = CDbl(Val(Pl.RecoilUp)) * scale
        Dim heightAdjust2 As Integer = CDbl(Val(calculateAdjustment(Pl.RecoilUp, Pl.AdjRecoilV))) * scale
        Dim height3 As Integer = CDbl(Val(Pl.RecoilRight)) * (scale - 400)
        Dim heightAdjust3 As Integer = CDbl(Val(calculateAdjustment(Pl.RecoilRight, Pl.AdjRecoilH))) * (scale - 400)
        Dim height4 As Integer = CDbl(Val(Pl.FirstShot)) * 500
        g.DrawRectangle(pen1, x2, y - height4, 30, height4)

        If height2 <= heightAdjust2 Then
            g.DrawRectangle(penAdustments, x1, y - heightAdjust2, 30, heightAdjust2)
            g.DrawRectangle(pen1, x1, y - height2, 30, height2)
        Else
            g.DrawRectangle(pen1, x1, y - height2, 30, height2)
            g.DrawRectangle(penAdustments, x1, y - heightAdjust2, 30, heightAdjust2)
        End If

        Dim greenBrush As New SolidBrush(Color.YellowGreen)
        If height1 <= heightAdjust1 Then
            g.DrawRectangle(penAdustments, 1000 - heightAdjust1, 1900, heightAdjust1 + heightAdjust3, 30)
            g.DrawRectangle(pen1, 1000 - height1, 1900, height1 + height3, 30)
        Else
            g.DrawRectangle(pen1, 1000 - height1, 1900, height1 + height3, 30)
            g.DrawRectangle(penAdustments, 1000 - heightAdjust1, 1900, heightAdjust1 + heightAdjust3, 30)
        End If


        g.DrawRectangle(pen2, 1000, 1900, 5, 30)
        Dim pen11 As New System.Drawing.Pen(Color.YellowGreen, 30)
        Dim scale1 = 3000
        Dim x11 = 1840
        Dim y1 = 1800
        Dim x12 = 1930
        Dim height11 As Integer = CDbl(Val(Pl.SpreadMin)) * scale1
        Dim heightAdjust11 As Integer = CDbl(Val(calculateAdjustment(Pl.SpreadMin, Pl.AdjSpreadMin))) * scale1
        Dim height12 As Integer = CDbl(Val(Pl.SpreadInc)) * scale1
        Dim heightAdjust12 As Integer = CDbl(Val(calculateAdjustment(Pl.SpreadInc, Pl.AdjSpreadInc))) * scale1
        If height11 <= heightAdjust11 Then
            g.DrawRectangle(penAdustments, x11, y - heightAdjust11, 30, heightAdjust11)
            g.DrawRectangle(pen11, x11, y - height11, 30, height11)
        Else
            g.DrawRectangle(pen11, x11, y - height11, 30, height11)
            g.DrawRectangle(penAdustments, x11, y - heightAdjust11, 30, heightAdjust11)
        End If

        If height12 <= heightAdjust12 Then
            g.DrawRectangle(penAdustments, x12, y - heightAdjust12, 30, heightAdjust12)
            g.DrawRectangle(pen11, x12, y - height12, 30, height12)
        Else
            g.DrawRectangle(pen11, x12, y - height12, 30, height12)
            g.DrawRectangle(penAdustments, x12, y - heightAdjust12, 30, heightAdjust12)
        End If


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
        Debug.WriteLine("Creating image in silent mode...")
        intBurstCycle = 0

        'Disable all of the input boxes
        btnStart.Enabled = False

        Me.grpAttach.Enabled = False
        Me.grpWeapon.Enabled = False
        Me.tabMain.Enabled = False
        Me.grpStance.Enabled = False

        ' Enable to stop button
        btnStop.Enabled = True

        HeatPoints.Clear()
        loadPloticINI()
        createSilentImage()
    End Sub
    Private Sub loadPloticINI()
        Dim chrDecimalSymbol As Char = INIRead(silentTemplateFile, "Config", "DecimalSymbol", ".")

        Pl.RecoilUp = convertINIValue(INIRead(silentTemplateFile, "Recoil", "RecoilUp", "Unknown"), chrDecimalSymbol)
        Pl.RecoilLeft = convertINIValue(INIRead(silentTemplateFile, "Recoil", "RecoilLeft", "Unknown"), chrDecimalSymbol)
        Pl.RecoilRight = convertINIValue(INIRead(silentTemplateFile, "Recoil", "RecoilRight", "Unknown"), chrDecimalSymbol)
        Pl.FirstShot = convertINIValue(INIRead(silentTemplateFile, "Recoil", "FirstShot", "Unknown"), chrDecimalSymbol)

        Pl.SpreadInc = convertINIValue(INIRead(silentTemplateFile, "Spread", "SpreadInc", "Unknown"), chrDecimalSymbol)
        Pl.SpreadMin = convertINIValue(INIRead(silentTemplateFile, "Spread", "SpreadMin", "Unknown"), chrDecimalSymbol)

        Pl.Burst = CInt(Val(INIRead(silentTemplateFile, "Burst", "Bursts", "500")))
        Pl.BulletsPerBurst = CInt(Val(INIRead(silentTemplateFile, "Burst", "BulletsPerBurst", "5")))

        Pl.AdjRecoilH = convertINIValue(INIRead(silentTemplateFile, "Attach", "AttachRecoilH", "0"), chrDecimalSymbol)
        Pl.AdjRecoilV = convertINIValue(INIRead(silentTemplateFile, "Attach", "AttachRecoilV", "0"), chrDecimalSymbol)
        Pl.AdjSpreadInc = convertINIValue(INIRead(silentTemplateFile, "Attach", "AttachSpreadInc", "0"), chrDecimalSymbol)
        Pl.AdjSpreadMin = convertINIValue(INIRead(silentTemplateFile, "Attach", "AttachSpreadMin", "0"), chrDecimalSymbol)

        Pl.Title = INIRead(silentTemplateFile, "Title", "TitleText", "")
        Pl.Info = INIRead(silentTemplateFile, "Title", "InfoText", "")
        Pl.SubText = INIRead(silentTemplateFile, "Title", "SubText", "")

        Pl.Scale = CInt(Val(INIRead(silentTemplateFile, "Grid", "Scale", "650")))
        Pl.TargetRange = CInt(Val(INIRead(silentTemplateFile, "Grid", "Distance", "30")))
        Pl.GridLineSpace = convertINIValue(INIRead(silentTemplateFile, "Grid", "GridValue", "1"), chrDecimalSymbol)

        Pl.RateOfFire = CInt(Val(INIRead(silentTemplateFile, "TTK", "RateOfFire", "650")))
    End Sub
    Private Sub createSilentImage()
        Dim chrDecimalSymbol As Char = INIRead(silentTemplateFile, "Config", "DecimalSymbol", ".")

        Dim b As Bitmap = Pl.Image
        Dim fileDir = INIRead(silentTemplateFile, "Save", "SavePath", "Unknown")
        Dim fileName = convertFileName(INIRead(silentTemplateFile, "Save", "FileName", "Unknown"))
        Dim fullPath As String = Path.Combine(fileDir, fileName)

        Dim RenderTitleText As Integer = INIRead(silentTemplateFile, "Title", "RenderTitleText", "0")
        Dim RenderGrid As Integer = INIRead(silentTemplateFile, "Grid", "RenderGrid", "0")

        Dim RenderBars As Integer = INIRead(silentTemplateFile, "Render", "RenderBars", "0")
        Dim ScaleRadius As Integer = INIRead(silentTemplateFile, "Render", "ScaleRadius", "0")

        Dim RenderAttachText As Integer = INIRead(silentTemplateFile, "Attach", "RenderAttachText", "0")
        Dim VerticalMultiplier As String = INIRead(silentTemplateFile, "Attach", "VerticalMultiplier", "1")
        Dim MultiplyVerticalRecoil As Integer = INIRead(silentTemplateFile, "Attach", "MultiplyVerticalRecoil", "0")

        Dim IntensityScale As String = INIRead(silentTemplateFile, "HeatMap", "IntensityScale", "2")
        Dim RenderHeatMap As Integer = INIRead(silentTemplateFile, "HeatMap", "RenderHeatMap", "0")
        Dim HeatRadius As Integer = INIRead(silentTemplateFile, "HeatMap", "Radius", "0")

        Dim RenderTTK As Integer = INIRead(silentTemplateFile, "TTK", "RenderTTK", "0")
        Dim RenderHitRates As Integer = INIRead(silentTemplateFile, "TTK", "RenderHitRates", "0")

        Dim RecoilDecreaseAmount As Double = INIRead(silentTemplateFile, "Recoil", "RecoilDecrease", "15")


        'TODO: Convert to arrays
        Dim aryHits() As Integer = {0, 0, 0, 0, 0}
        Dim coord1x(Val(Pl.Burst)) As Integer
        Dim coord1y(Val(Pl.Burst)) As Integer
        Dim coord2x(Val(Pl.Burst)) As Integer
        Dim coord2y(Val(Pl.Burst)) As Integer
        Dim coord3x(Val(Pl.Burst)) As Integer
        Dim coord3y(Val(Pl.Burst)) As Integer
        Dim coord4x(Val(Pl.Burst)) As Integer
        Dim coord4y(Val(Pl.Burst)) As Integer
        Dim coord5x(Val(Pl.Burst)) As Integer
        Dim coord5y(Val(Pl.Burst)) As Integer
        Dim coord6x(Val(Pl.Burst)) As Integer
        Dim coord6y(Val(Pl.Burst)) As Integer

        'Make Adjustments to values
        Dim dblRecoilH As Double = calculateAdjustment(Pl.RecoilUp, Pl.AdjRecoilV)
        Dim dblRecoilR As Double = calculateAdjustment(Pl.RecoilRight, Pl.AdjRecoilH)
        Dim dblRecoilL As Double = calculateAdjustment(Pl.RecoilLeft, Pl.AdjRecoilH)

        Dim dblSpreadMin As Double = calculateAdjustment(Pl.SpreadMin, Pl.AdjSpreadMin)
        Dim dblSpreadInc As Double = calculateAdjustment(Pl.SpreadInc, Pl.AdjSpreadInc)


        Dim solMask As Bitmap = New Bitmap(My.Resources.sil_mask_fullsize)

        Dim silhouetteHeight As Integer = Math.Round((Math.Atan(1.85 / Pl.TargetRange) * (180 / Math.PI)) * Pl.Scale, 0)
        Dim silhouetteDiff As Double = silhouetteHeight / solMask.Height
        Dim silhouetteWidth As Integer = Math.Round((silhouetteDiff * solMask.Width), 0)

        Dim picVCenter As Integer = Math.Round((silhouetteHeight * IMAGE_V_CENTER_PERCENT), 0)
        Dim picHCenter As Integer = Math.Round((silhouetteWidth * IMAGE_H_CENTER_PERCENT), 0)

        Dim solscaledMask As New Bitmap(CInt(silhouetteWidth), CInt(silhouetteHeight))

        Dim sil_centerY As Integer = 1680 - picVCenter
        Dim sil_centerX As Integer = 1000 - picHCenter

        Dim soldestMask As Graphics = Graphics.FromImage(solscaledMask)

        If silhouetteHeight > 9800 Then
            Pl.MaskGraphic.Clear(Color.White)
        Else
            soldestMask.DrawImage(solMask, 0, 0, solscaledMask.Width + 1, solscaledMask.Height + 1)
            Pl.MaskGraphic.Clear(Color.Black)
            Pl.MaskGraphic.DrawImage(solscaledMask, sil_centerX, sil_centerY)
        End If

        Dim sol As Bitmap = New Bitmap(My.Resources.sil_1_fullsize)

        Dim solscaled As New Bitmap(CInt(silhouetteWidth), CInt(silhouetteHeight))
        Dim soldest As Graphics = Graphics.FromImage(solscaled)
        soldest.DrawImage(sol, 0, 0, solscaled.Width + 1, solscaled.Height + 1)

        If RenderTTK = 1 Then
            Pl.ImageGraphic.Clear(Color.Black)
            Pl.ImageGraphic.DrawImage(solscaled, sil_centerX, sil_centerY)
        Else
            Pl.ImageGraphic.Clear(Color.Black)
        End If
        If RenderBars = 1 Then
            drawBars(Pl.ImageGraphic)
        End If
        Dim scale = Val(Pl.Scale)
        Dim montako = 0
        Dim upd = 0

        Dim startX = 1000
        Dim startY = 1680
        Dim RateOfFire As Double = Pl.RateOfFire
        For ee = 0 To Pl.Burst
            Dim uprecoil = 0
            montako += 1
            Dim spread = dblSpreadMin * scale
            Dim centerx = 1000
            Dim centy = 1680
            Dim iIntense As Byte
            For a = 0 To Int(Pl.BulletsPerBurst) - 1
                Dim pen1 As New System.Drawing.Pen(Color.DarkRed, 4)
                Select Case a
                    Case 0
                        pen1.Color = Color.YellowGreen
                        iIntense = CByte(15 * convertINIValue(IntensityScale, chrDecimalSymbol))
                    Case 1
                        pen1.Color = Color.Yellow
                        iIntense = CByte(12 * convertINIValue(IntensityScale, chrDecimalSymbol))
                    Case 2
                        pen1.Color = Color.Orange
                        iIntense = CByte(9 * convertINIValue(IntensityScale, chrDecimalSymbol))
                    Case 3
                        pen1.Color = Color.Red
                        iIntense = CByte(6 * convertINIValue(IntensityScale, chrDecimalSymbol))
                    Case 4
                        pen1.Color = Color.DarkRed
                        iIntense = CByte(3 * convertINIValue(IntensityScale, chrDecimalSymbol))
                End Select
                Dim radius
                Dim mul As Integer = 100000
                If ScaleRadius = 1 Then
                    radius = spread * Math.Sqrt(rndD(1000, 0) / 1000)
                Else
                    radius = rndD(spread, 0)
                End If
                Dim angle = rndD(360, 0)
                Dim x As Integer = centerx + radius * Math.Cos(angle)
                Dim y As Integer = centy + radius * Math.Sin(angle)

                'Add Target to heatpoints
                HeatPoints.Add(New HeatPoint(x, y, iIntense))

                If RenderTTK <> 1 Then
                    Pl.ImageGraphic.DrawEllipse(pen1, x, y, 7, 7)
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
                    Pl.ImageGraphic.DrawEllipse(pen1, x, y, 7, 7)
                End If

                Application.DoEvents()
                If a = 0 Then
                    centy -= (CDbl(Val(dblRecoilH)) * scale) * CDbl(Val(Pl.FirstShot))
                Else
                    centy -= CDbl(Val(dblRecoilH)) * scale
                End If
                centerx += rndD(1000 + CDbl(dblRecoilR * scale), 1000 - Int(CDbl(dblRecoilL) * scale)) - 1000
                spread += CDbl(dblSpreadInc) * scale
                Try
                    centerx = Math.Round(RecoilDecrease(startX, startY, centerx, centy, RecoilDecreaseAmount, RateOfFire, scale, "x"), 0)
                    centy = Math.Round(RecoilDecrease(startX, startY, centerx, centy, RecoilDecreaseAmount, RateOfFire, scale, "y"), 0)
                Catch ex As Exception
                End Try

            Next
        Next
        Dim nl = Environment.NewLine
        Dim intBursts As Integer = Val(Pl.Burst)
        If RenderTTK = 1 Then
            For a = 0 To intBursts - 1
                Dim pen1 As New System.Drawing.Pen(Color.YellowGreen, 4)
                Dim pen2 As New System.Drawing.Pen(Color.Yellow, 4)
                Dim pen3 As New System.Drawing.Pen(Color.Orange, 4)
                Dim pen4 As New System.Drawing.Pen(Color.Red, 4)
                Dim pen5 As New System.Drawing.Pen(Color.DarkRed, 4)

                Pl.ImageGraphic.DrawEllipse(pen1, coord1x(a), coord1y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(pen2, coord2x(a), coord2y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(pen3, coord3x(a), coord3y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(pen4, coord4x(a), coord4y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(pen5, coord5x(a), coord5y(a), 7, 7)
            Next
            Debug.WriteLine("Bursts: " & intBursts)
            Debug.WriteLine("Hits #1: " & aryHits(0))

        End If
        If RenderHitRates = 1 And RenderTTK = 1 Then
            drawTTK(Pl.ImageGraphic, Math.Round((aryHits(0) / (intBursts + 1) * 100), 2), Math.Round((aryHits(1) / (intBursts + 1) * 100), 2), Math.Round((aryHits(2) / (intBursts + 1) * 100), 2), Math.Round((aryHits(3) / (intBursts + 1) * 100), 2), Math.Round((aryHits(4) / (intBursts + 1) * 100), 2))
        End If
        If RenderHeatMap = 1 Then
            Application.DoEvents()
            Pl.HeatMap = CreateIntensityMask(Pl.HeatMap, HeatPoints, CInt(Val(HeatRadius)))
            ' Colorize the memory bitmap and assign it as the picture boxes image
            Pl.HeatMap = Colorize(Pl.HeatMap, 255, paletteOverride)
        End If
        If RenderTitleText = 1 Then
            drawTitle(Pl.ImageGraphic)
        End If
        If RenderAttachText = 1 Then
            drawAdjustments(Pl.ImageGraphic)
        End If
        If RenderGrid = 1 Then
            drawGrid(Pl.ImageGraphic)
        End If


        b.Save(fullPath)

        If RenderHeatMap = 1 Then
            Dim h As Bitmap = Pl.HeatMap
            Dim heatFileName As String = fullPath.Insert((fullPath.Length - 4), "_heatmap")
            h.Save(heatFileName)
        End If
        Debug.WriteLine("Image Saved: " & fullPath)
        Debug.WriteLine("Shutting Down")
        exitApplication()
    End Sub

    Private Sub btnStart_Click() Handles btnStart.Click
        intBurstCycle = 0

        'Disable all of the input boxes
        btnStart.Enabled = False

        Me.grpWeapon.Enabled = False
        Me.tabMain.Enabled = False
        Me.grpStance.Enabled = False
        Me.viewToolStrip.Enabled = False

        ' Enable to stop button
        btnStop.Enabled = True

        selectView("main")

        SetImage_ThreadSafe(Pl.Image)

        ' Start the Background Worker working
        HeatPoints.Clear()

        If comboWeapon1.Text = "<<CUSTOM>>" Then
            loadCustomPlotic()
        Else
            loadPlotic()
        End If

        BackgroundWorker1.RunWorkerAsync()

    End Sub
    Private Sub loadCustomPlotic()
        Pl.RecoilUp = Double.Parse(numRecoilUp.Value)
        Pl.RecoilLeft = Double.Parse(numRecoilLeft.Value)
        Pl.RecoilRight = Double.Parse(numRecoilRight.Value)

        Pl.RecoilDecrease = Double.Parse(numRecoilDecrease.Value)

        Pl.SpreadInc = Double.Parse(numSpreadInc.Value)
        Pl.SpreadMin = Double.Parse(numSpreadMin.Value)
        Pl.FirstShot = Double.Parse(numFirstShot.Value)
        Pl.Burst = Integer.Parse(txtBursts.Text)
        Pl.BulletsPerBurst = Integer.Parse(numBulletsPerBurst.Value)
        Pl.AdjRecoilH = numRecoilH.Value
        Pl.AdjRecoilV = numRecoilV.Value
        Pl.AdjSpreadInc = numAdjInc.Value
        Pl.AdjSpreadMin = numAdjMin.Value
        Pl.GridLineSpace = Double.Parse(numLineSpace.Value)
        Pl.Gun = comboWeapon1.Text
        Pl.Title = txtTitle.Text
        Pl.SubText = txtSub.Text
        Pl.Info = txtInfo.Text


        Pl.Scale = txtScale.Text

        Pl.BulletVelocity = numBulletVelocity.Value
        Pl.MaxDistance = numMaxDistance.Value
        Pl.BulletDrop = numBulletDrop.Value
        Pl.TargetRange = numMeters.Value
        Pl.RateOfFire = numRateOfFire.Value

        If comboSilhouetteStyle.Text = "1" Then
            Pl.Silh = New Bitmap(My.Resources.sil_1_fullsize)
        ElseIf comboSilhouetteStyle.Text = "2" Then
            Pl.Silh = New Bitmap(My.Resources.sil_2_fullsize)
        ElseIf comboSilhouetteStyle.Text = "3" Then
            Pl.Silh = New Bitmap(My.Resources.sil_3_fullsize)
        End If

    End Sub
    Private Sub loadPlotic()


        Dim test = Double.Parse(GetValue(comboWeapon1.Text, "RecoilAmplitudeIncPerShot", getStance()), System.Globalization.CultureInfo.InvariantCulture)
        Pl.RecoilUp = Double.Parse(GetValue(comboWeapon1.Text, "RecoilAmplitudeIncPerShot", getStance()), System.Globalization.CultureInfo.InvariantCulture)
        Pl.RecoilLeft = Double.Parse(GetValue(comboWeapon1.Text, "HorizontalRecoilAmplitudeIncPerShotMax", getStance()), System.Globalization.CultureInfo.InvariantCulture)
        Pl.RecoilRight = Math.Abs(Double.Parse(GetValue(comboWeapon1.Text, "HorizontalRecoilAmplitudeIncPerShotMin", getStance()), System.Globalization.CultureInfo.InvariantCulture))
        Pl.RecoilDecrease = Double.Parse(GetValue(comboWeapon1.Text, "RecoilAmplitudeDecreaseFactor", getStance()), System.Globalization.CultureInfo.InvariantCulture)

        Pl.SpreadInc = Double.Parse(GetValue(comboWeapon1.Text, "IncreasePerShot", getStance()), System.Globalization.CultureInfo.InvariantCulture)
        Pl.SpreadMin = Double.Parse(getMinAngle())
        Pl.FirstShot = Double.Parse(GetValue(comboWeapon1.Text, "FirstShotRecoilMultiplier", getStance()), System.Globalization.CultureInfo.InvariantCulture)
        Pl.Burst = Integer.Parse(txtBursts.Text)
        Pl.BulletsPerBurst = Integer.Parse(numBulletsPerBurst.Value)
        Pl.AdjRecoilH = getAdjustRecoilH()
        Pl.AdjRecoilV = getAdjustRecoilV()
        Pl.AdjSpreadInc = getAdjustInc()
        Pl.AdjSpreadMin = getAdjustMin()
        Pl.GridLineSpace = Double.Parse(numLineSpace.Value)
        Pl.Gun = comboWeapon1.Text
        If txtTitle.Text = "<<GUN>>" Then
            Pl.Title = comboWeapon1.Text
        Else
            Pl.Title = txtTitle.Text
        End If
        If txtSub.Text = "<<ATTACH>>" Then
            Pl.SubText = buildAttachString()
        Else
            Pl.SubText = txtSub.Text
        End If
        If txtInfo.Text = "<<STANCE>>" Then
            Pl.Info = buildStanceString()
        Else
            Pl.Info = txtInfo.Text
        End If


        Pl.Scale = txtScale.Text

        Pl.BulletVelocity = GetSpeed(comboWeapon1.Text)
        Pl.MaxDistance = numMaxDistance.Value
        Pl.BulletDrop = numBulletDrop.Value
        Pl.TargetRange = numMeters.Value
        Pl.RateOfFire = GetRateOfFire(comboWeapon1.Text)

        If comboSilhouetteStyle.Text = "1" Then
            Pl.Silh = New Bitmap(My.Resources.sil_1_fullsize)
        ElseIf comboSilhouetteStyle.Text = "2" Then
            Pl.Silh = New Bitmap(My.Resources.sil_2_fullsize)
        ElseIf comboSilhouetteStyle.Text = "3" Then
            Pl.Silh = New Bitmap(My.Resources.sil_3_fullsize)
        End If

    End Sub

    Private Function getMinAngle() As Double
        Dim strStanceBuild As String = ""
        If chkStanceZoom.Checked Then
            strStanceBuild = "ADS"
        Else
            strStanceBuild = "HIP"
        End If
        If chkStanceMoving.Checked Then
            strStanceBuild += "Moving"
        Else
            strStanceBuild += "Base"
        End If
        strStanceBuild += "MinAngle"
        Return Double.Parse(GetValue(comboWeapon1.Text, strStanceBuild, getStance()), System.Globalization.CultureInfo.InvariantCulture)
    End Function
    Private Function getMaxAngle() As Double
        Dim strStanceBuild As String = ""
        If chkStanceZoom.Checked Then
            strStanceBuild = "ADS"
        Else
            strStanceBuild = "HIP"
        End If
        If chkStanceMoving.Checked Then
            strStanceBuild += "Moving"
        Else
            strStanceBuild += "Base"
        End If
        strStanceBuild += "MaxAngle"
        Return Double.Parse(GetValue(comboWeapon1.Text, strStanceBuild, getStance()), System.Globalization.CultureInfo.InvariantCulture)
    End Function

    Private Function getAdjustMin() As Double
        Dim dblSumModifer As Double = 0


        If radBarrelFlash.Checked Then
            Dim FlashAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Flash_Suppressor", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += FlashAngle
        End If
        If radBarrelHeavy.Checked Then
            Dim HeavyBarrelAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "HeavyBarrel", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += HeavyBarrelAngle
        End If
        If radBarrelSilencer.Checked Then
            Dim SilencerAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Silencer", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += SilencerAngle
        End If
        If radUnderBipod.Checked Then
            Dim BipodAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Bipod", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += BipodAngle
        End If
        If radUnderForegrip.Checked Then
            Dim ForegripAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Foregrip", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += ForegripAngle
        End If
        If radUnderLaser.Checked Then
            Dim LaserAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "TargetPointer", "MinAngleModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += LaserAngle
        End If
        If radBarrelNone.Checked And radUnderNone.Checked Then
            dblSumModifer += 0
        End If

        Return dblSumModifer
    End Function
    Private Function getAdjustInc() As Double
        Dim dblSumModifer As Double = 0


        If radBarrelFlash.Checked Then
            Dim FlashAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Flash_Suppressor", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += FlashAngle
        End If
        If radBarrelHeavy.Checked Then
            Dim HeavyBarrelAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "HeavyBarrel", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += HeavyBarrelAngle
        End If
        If radBarrelSilencer.Checked Then
            Dim SilencerAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Silencer", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += SilencerAngle
        End If
        If radUnderBipod.Checked Then
            Dim BipodAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Bipod", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += BipodAngle
        End If
        If radUnderForegrip.Checked Then
            Dim ForegripAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Foregrip", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += ForegripAngle
        End If
        If radUnderLaser.Checked Then
            Dim LaserAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "TargetPointer", "IncreasePerShotModifier", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += LaserAngle
        End If
        If radBarrelNone.Checked And radUnderNone.Checked Then
            dblSumModifer += 0
        End If

        Return dblSumModifer
    End Function
    Private Function getAdjustRecoilV() As Double
        Dim dblSumModifer As Double = 0


        If radBarrelFlash.Checked Then
            Dim FlashAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Flash_Suppressor", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += FlashAngle
        End If
        If radBarrelHeavy.Checked Then
            Dim HeavyBarrelAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "HeavyBarrel", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += HeavyBarrelAngle
        End If
        If radBarrelSilencer.Checked Then
            Dim SilencerAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Silencer", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += SilencerAngle
        End If
        If radUnderBipod.Checked Then
            Dim BipodAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Bipod", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += BipodAngle
        End If
        If radUnderForegrip.Checked Then
            Dim ForegripAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Foregrip", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += ForegripAngle
        End If
        If radUnderLaser.Checked Then
            Dim LaserAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "TargetPointer", "RecoilMagnitudeMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += LaserAngle
        End If
        If radBarrelNone.Checked And radUnderNone.Checked Then
            dblSumModifer += 0
        End If

        Return dblSumModifer
    End Function
    Private Function getAdjustRecoilH() As Double
        Dim dblSumModifer As Double = 0


        If radBarrelFlash.Checked Then
            Dim FlashAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Flash_Suppressor", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += FlashAngle
        End If
        If radBarrelHeavy.Checked Then
            Dim HeavyBarrelAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "HeavyBarrel", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += HeavyBarrelAngle
        End If
        If radBarrelSilencer.Checked Then
            Dim SilencerAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Silencer", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += SilencerAngle
        End If
        If radUnderBipod.Checked Then
            Dim BipodAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Bipod", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += BipodAngle
        End If
        If radUnderForegrip.Checked Then
            Dim ForegripAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "Foregrip", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += ForegripAngle
        End If
        If radUnderLaser.Checked Then
            Dim LaserAngle As Double = Math.Round(Double.Parse(GetAttachmentValue(comboWeapon1.Text, "TargetPointer", "RecoilAngleMod", getFullStance()), System.Globalization.CultureInfo.InvariantCulture) * 100, 0) - 100
            dblSumModifer += LaserAngle
        End If
        If radBarrelNone.Checked And radUnderNone.Checked Then
            dblSumModifer += 0
        End If

        Return dblSumModifer
    End Function

    Private Function buildStanceString() As String
        Dim attachString As String = ""
        If radStand.Checked Then
            attachString += "Stand-"
        End If
        If radCrouch.Checked Then
            attachString += "Crouch-"
        End If
        If radProne.Checked Then
            attachString += "Prone-"
        End If

        If chkStanceZoom.Checked Then
            attachString += "ADS"
        Else
            attachString += "Hip"
        End If

        If chkStanceMoving.Checked Then
            attachString += "-Moving"
        End If
        Return Trim(attachString)
    End Function
    Private Function buildAttachString() As String
        Dim attachString As String = ""
        Dim attachCount As Integer = 0
        If radBarrelFlash.Checked Then
            attachString += "Flash Supp. "
            attachCount += 1
        End If
        If radBarrelHeavy.Checked Then
            attachString += "H. Barrel "
            attachCount += 1
        End If
        If radBarrelSilencer.Checked Then
            attachString += "Silencer "
            attachCount += 1
        End If
        If radUnderBipod.Checked Then
            If attachCount > 0 Then
                attachString += "- Bipod "
            Else
                attachString += "Bipod "
            End If

            attachCount += 1
        End If
            If radUnderForegrip.Checked Then
            If attachCount > 0 Then
                attachString += "- Foregrip "
            Else
                attachString += "Foregrip "
            End If
            attachCount += 1
            End If
            If radUnderLaser.Checked Then
            If attachCount > 0 Then
                attachString += "- Laser "
            Else
                attachString += "Laser "
            End If
            attachCount += 1
            End If
        Return Trim(attachString)
    End Function

    Private Function getFullStance() As String
        Dim stance As String = ""
        If radStand.Checked Then
            stance = "Stand"
        ElseIf radCrouch.Checked Then
            stance = "Crouch"
        Else
            stance = "Prone"
        End If
        If chkStanceZoom.Checked Then
            stance = stance & "Zoom"
        Else
            stance = stance & "NoZoom"
        End If
        Return stance
    End Function
    Private Function getStance() As String
        Dim stance As String = ""
        If radStand.Checked Then
            stance = "Stand"
        ElseIf radCrouch.Checked Then
            stance = "Crouch"
        Else
            stance = "Prone"
        End If
        If chkStanceZoom.Checked Then
            stance = stance & "Zoom"
        Else
            stance = stance & "NoZoom"
        End If
        Return stance
    End Function

    Private Function getView() As String
        Dim currentView As String = "main"
        If Me.viewToolStrip.Text = "View: Main" Then
            currentView = "main"
        ElseIf Me.viewToolStrip.Text = "View: Heat Map" Then
            currentView = "heat"

        ElseIf Me.viewToolStrip.Text = "View: Mask" Then
            currentView = "mask"

        ElseIf Me.viewToolStrip.Text = "View: TTK" Then
            currentView = "ttk"
        End If
        Return currentView
    End Function
    Private Sub selectView(ByVal view As String)
        Select Case view
            Case "main"
                SetToolStripText_ThreadSafe("View: Main")
                CheckToolStripMain_ThreadSafe(CheckState.Checked)

                CheckToolStripHeatMap_ThreadSafe(CheckState.Unchecked)
                CheckToolStripMask_ThreadSafe(CheckState.Unchecked)
                CheckToolStripTTK_ThreadSafe(CheckState.Unchecked)
                SetImage_ThreadSafe(Pl.Image)
                MainToolStripMenuItem.Checked = True
                MaskToolStripMenuItem.Checked = False
                HeatMapToolStripMenuItem.Checked = False
                TTKToolStripMenuItem.Checked = False
            Case "heat"
                SetToolStripText_ThreadSafe("View: Heat Map")
                CheckToolStripHeatMap_ThreadSafe(CheckState.Checked)

                CheckToolStripMain_ThreadSafe(CheckState.Unchecked)
                CheckToolStripMask_ThreadSafe(CheckState.Unchecked)
                CheckToolStripTTK_ThreadSafe(CheckState.Unchecked)
                SetImage_ThreadSafe(Pl.HeatMap)
                MainToolStripMenuItem.Checked = False
                MaskToolStripMenuItem.Checked = False
                HeatMapToolStripMenuItem.Checked = True
                TTKToolStripMenuItem.Checked = False
            Case "mask"
                SetToolStripText_ThreadSafe("View: Mask")
                CheckToolStripMask_ThreadSafe(CheckState.Checked)

                CheckToolStripMain_ThreadSafe(CheckState.Unchecked)
                CheckToolStripTTK_ThreadSafe(CheckState.Unchecked)
                CheckToolStripHeatMap_ThreadSafe(CheckState.Unchecked)
                SetImage_ThreadSafe(Pl.Mask)
                MainToolStripMenuItem.Checked = False
                MaskToolStripMenuItem.Checked = True
                HeatMapToolStripMenuItem.Checked = False
                TTKToolStripMenuItem.Checked = False

            Case "ttk"
                SetToolStripText_ThreadSafe("View: TTK")
                CheckToolStripTTK_ThreadSafe(CheckState.Checked)

                CheckToolStripMask_ThreadSafe(CheckState.Unchecked)
                CheckToolStripMain_ThreadSafe(CheckState.Unchecked)
                CheckToolStripHeatMap_ThreadSafe(CheckState.Unchecked)
                SetImage_ThreadSafe(Pl.TTK)
                MainToolStripMenuItem.Checked = False
                MaskToolStripMenuItem.Checked = False
                HeatMapToolStripMenuItem.Checked = False
                TTKToolStripMenuItem.Checked = True
            Case Else
                SetToolStripText_ThreadSafe("View: Main")
                CheckToolStripMain_ThreadSafe(CheckState.Checked)

                CheckToolStripHeatMap_ThreadSafe(CheckState.Unchecked)
                CheckToolStripMask_ThreadSafe(CheckState.Unchecked)
                CheckToolStripTTK_ThreadSafe(CheckState.Unchecked)
                SetImage_ThreadSafe(Pl.Image)
                MainToolStripMenuItem.Checked = True
                MaskToolStripMenuItem.Checked = False
                HeatMapToolStripMenuItem.Checked = False
                TTKToolStripMenuItem.Checked = False

                SetOutPutText_ThreadSafe("View: '" & view & " NOT FOUND")
        End Select


    End Sub

    Public Sub showImage(ByVal lengthOfSide As Integer)
        Dim diaTest As New diaImageZoom()
        diaTest.Text = lengthOfSide & " x " & lengthOfSide
        diaTest.Size = New System.Drawing.Size(lengthOfSide + 6, (lengthOfSide + 28))
        diaTest.ShowInTaskbar = True
        diaTest.picStatic.Location = New System.Drawing.Point(0, 0)
        diaTest.picStatic.Name = "Test"
        diaTest.picStatic.Size = New System.Drawing.Size(lengthOfSide, lengthOfSide)
        If getView() = "main" Then
            diaTest.picStatic.Image = Pl.Image
        ElseIf getView() = "heat" Then
            diaTest.picStatic.Image = Pl.HeatMap
        ElseIf getView() = "mask" Then
            diaTest.picStatic.Image = Pl.Mask
        ElseIf getView() = "ttk" Then
            diaTest.picStatic.Image = Pl.TTK
        End If
        diaTest.Show()
        diaTest.ShowInTaskbar = True
    End Sub
    
    Private Function convertINIValue(ByVal inputValue As String, ByVal decimalSymbol As Char) As Double
        inputValue = inputValue.Replace(decimalSymbol, "."c)
        Return CDbl(Val(inputValue))
    End Function

    Public Function rndD(ByRef upper As Integer, ByRef lower As Integer) As Integer
        'TODO:Add error logic for zero division
        Dim Random As Long
        Try
            If (upper - lower) > 0 Then
                Random = lower + CLng(Rnd() * 1000000) Mod (upper - lower) + 1
            Else
                Random = 1
            End If
        Catch exc As DivideByZeroException
            Random = 1
        End Try
        Return Random
    End Function

    Private Sub btnSaveImage_Click() Handles btnSaveImage.Click
        Dim folderSelectDialog As New FolderBrowserDialog

        If folderSelectDialog.ShowDialog() = DialogResult.OK Then
            saveImagePath = folderSelectDialog.SelectedPath
            lblPath.Text = folderSelectDialog.SelectedPath
        End If

    End Sub

    Private Sub UpdateAdjustments()
        lblAdjUp.Text = calculateAdjustment(CDbl(Val(GetValue(comboWeapon1.Text, "RecoilAmplitudeIncPerShot", getStance()))), CDbl(Val(numRecoilV.Text))).ToString
        lblAdjRight.Text = calculateAdjustment(CDbl(Val(GetValue(comboWeapon1.Text, "HorizontalRecoilAmplitudeIncPerShotMin", getStance()))), CDbl(Val(numRecoilH.Text))).ToString
        lblAdjLeft.Text = calculateAdjustment(CDbl(Val(GetValue(comboWeapon1.Text, "HorizontalRecoilAmplitudeIncPerShotMax", getStance()))), CDbl(Val(numRecoilH.Text))).ToString

        lblAdjMin.Text = calculateAdjustment(CDbl(Val(numRecoilH.Value)), (numAdjMin.Value)).ToString
        lblAdjInc.Text = calculateAdjustment(CDbl(Val(numRecoilH.Value)), (numAdjInc.Value)).ToString
    End Sub
    Private Sub Adjustment_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numRecoilH.ValueChanged, numRecoilV.ValueChanged, numAdjInc.ValueChanged, numAdjMin.ValueChanged
        'UpdateAdjustments()
    End Sub
    Private Function calculateAdjustment(ByVal actor As Double, ByVal action As Double) As Double
        Return Math.Round((actor * (action / 100)) + (actor), 3)
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'TODO: Convert to arrays
        Dim aryHits() As Integer = {0, 0, 0, 0, 0}
        Dim coord1x(Val(Pl.Burst)) As Integer
        Dim coord1y(Val(Pl.Burst)) As Integer
        Dim coord2x(Val(Pl.Burst)) As Integer
        Dim coord2y(Val(Pl.Burst)) As Integer
        Dim coord3x(Val(Pl.Burst)) As Integer
        Dim coord3y(Val(Pl.Burst)) As Integer
        Dim coord4x(Val(Pl.Burst)) As Integer
        Dim coord4y(Val(Pl.Burst)) As Integer
        Dim coord5x(Val(Pl.Burst)) As Integer
        Dim coord5y(Val(Pl.Burst)) As Integer
        Dim coord6x(Val(Pl.Burst)) As Integer
        Dim coord6y(Val(Pl.Burst)) As Integer

        'Make Adjustments to values
        Dim dblRecoilH As Double = calculateAdjustment(Pl.RecoilUp, Pl.AdjRecoilV)
        Dim dblRecoilR As Double = calculateAdjustment(Pl.RecoilRight, Pl.AdjRecoilH)
        Dim dblRecoilL As Double = calculateAdjustment(Pl.RecoilLeft, Pl.AdjRecoilH)

        Dim dblSpreadMin As Double = calculateAdjustment(Pl.SpreadMin, Pl.AdjSpreadMin)
        Dim dblSpreadInc As Double = calculateAdjustment(Pl.SpreadInc, Pl.AdjSpreadInc)

        Dim dblRecoilDeceasePerSecond As Double = Double.Parse(Pl.RecoilDecrease, System.Globalization.CultureInfo.InvariantCulture)
        Dim solMask As Bitmap = New Bitmap(My.Resources.sil_mask_fullsize)

        Dim silhouetteHeight As Integer = Math.Round((Math.Atan(1.85 / Pl.TargetRange) * (180 / Math.PI)) * Pl.Scale, 0)
        Dim silhouetteDiff As Double = silhouetteHeight / solMask.Height
        Dim silhouetteWidth As Integer = Math.Round((silhouetteDiff * solMask.Width), 0)

        Dim picVCenter As Integer = Math.Round((silhouetteHeight * IMAGE_V_CENTER_PERCENT), 0)
        Dim picHCenter As Integer = Math.Round((silhouetteWidth * IMAGE_H_CENTER_PERCENT), 0)

        Dim solscaledMask As New Bitmap(CInt(silhouetteWidth), CInt(silhouetteHeight))

        Dim sil_centerY As Integer = 1680 - picVCenter
        Dim sil_centerX As Integer = 1000 - picHCenter

        Dim soldestMask As Graphics = Graphics.FromImage(solscaledMask)

        If silhouetteHeight > 9800 Then
            Pl.MaskGraphic.Clear(Color.White)
            silhouetteHeight = 9800
            silhouetteWidth = Math.Round(silhouetteHeight / silhouetteDiff, 0)
        Else
            soldestMask.DrawImage(solMask, 0, 0, solscaledMask.Width + 1, solscaledMask.Height + 1)
            Pl.MaskGraphic.Clear(Color.Black)
            Pl.MaskGraphic.DrawImage(solscaledMask, sil_centerX, sil_centerY)
        End If

        Dim sol As Bitmap = New Bitmap(Pl.Silh)



        Dim solscaled As New Bitmap(CInt(silhouetteWidth), CInt(silhouetteHeight))
        Dim soldest As Graphics = Graphics.FromImage(solscaled)
        soldest.DrawImage(sol, 0, 0, solscaled.Width + 1, solscaled.Height + 1)

        If chkTimeToKill.Checked Then
            Pl.ImageGraphic.Clear(Color.Black)
            Pl.ImageGraphic.DrawImage(solscaled, sil_centerX, sil_centerY)
        Else
            Pl.ImageGraphic.Clear(Color.Black)
        End If
        If chkBars.Checked Then
            drawBars(Pl.ImageGraphic)
        End If
        Dim scale = Val(Pl.Scale)
        Dim montako = 0
        Dim upd = 0

        Dim startX = 1000
        Dim startY = 1680

        For ee = 0 To Pl.Burst ' Burst Loop
            If BackgroundWorker1.CancellationPending Then
                ' Set Cancel to True
                SetImage_ThreadSafe(Pl.Image)
                e.Cancel = True
                Exit For
            End If

            upd += 1
            If upd = UPDATE_PERIOD Then
                upd = 0
                SetImage_ThreadSafe(Pl.Image)
            End If
            addBurstCount_ThreadSafe()
            'Dim uprecoil = 0
            montako += 1
            'Set the spread
            Dim spread = dblSpreadMin * scale

            'Set the center and first fire point (center mass)
            Dim centerx = 1000
            Dim centy = 1680
            Dim iIntense As Byte
            For a = 0 To Int(Pl.BulletsPerBurst) - 1 ' Loop through bullet bursts

                'Set pen color based on bullet number, anything past 5 will show up as darkred
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
                'Dim mul As Integer = 100000
                If chkScaleRadius.Checked = True Then
                    radius = spread * Math.Sqrt(rndD(1000, 0) / 1000)
                Else
                    radius = rndD(spread, 0)
                End If
                Dim angle = rndD(360, 0)

                Dim RateOfFire As Double = Pl.RateOfFire

                'Calculate X and Y values with spread
                Dim x As Integer = centerx + radius * Math.Cos(angle)
                Dim y As Integer = centy + radius * Math.Sin(angle)

                'Add Target to heatpoints
                HeatPoints.Add(New HeatPoint(x, y, iIntense))

                If Not chkTimeToKill.Checked Then
                    Pl.ImageGraphic.DrawEllipse(pen1, x, y, 7, 7)
                Else
                    'Debug.WriteLine((Val(colo.R) + Val(colo.G) + Val(colo.B)).ToString())
                    Select Case a
                        Case 0
                            If Pl.bulletHit(x, y) Then aryHits(0) += 1
                            coord1x(ee) = x
                            coord1y(ee) = y
                        Case 1
                            If Pl.bulletHit(x, y) Then aryHits(1) += 1
                            coord2x(ee) = x
                            coord2y(ee) = y
                        Case 2
                            If Pl.bulletHit(x, y) Then aryHits(2) += 1
                            coord3x(ee) = x
                            coord3y(ee) = y
                        Case 3
                            If Pl.bulletHit(x, y) Then aryHits(3) += 1
                            coord4x(ee) = x
                            coord4y(ee) = y
                        Case 4
                            If Pl.bulletHit(x, y) Then aryHits(4) += 1
                            coord5x(ee) = x
                            coord5y(ee) = y
                    End Select
                    Pl.ImageGraphic.DrawEllipse(pen1, x, y, 7, 7)
                End If

                Application.DoEvents()
                'Calculate the new Y position
                If a = 0 Then
                    centy -= (CDbl(Val(dblRecoilH)) * scale) * CDbl(Val(Pl.FirstShot))
                Else
                    centy -= CDbl(Val(dblRecoilH)) * scale
                End If
                'Calculate the new X position
                centerx += rndD(1000 + CDbl(dblRecoilR * scale), 1000 - Int(CDbl(dblRecoilL) * scale)) - 1000
                'Calculate the new spread value
                spread += CDbl(dblSpreadInc) * scale
                Try
                    'Calculate the recoil decrease
                    centerx = Math.Round(RecoilDecrease(startX, startY, centerx, centy, dblRecoilDeceasePerSecond, RateOfFire, scale, "x"), 0)
                    centy = Math.Round(RecoilDecrease(startX, startY, centerx, centy, dblRecoilDeceasePerSecond, RateOfFire, scale, "y"), 0)
                Catch

                End Try

            Next ' Next Bullet Burst

            'Update the Progress bar
            BackgroundWorker1.ReportProgress(Math.Round(CInt((ee / Pl.Burst) * 100), 0))
        Next 'Next BURST

        Dim nl = Environment.NewLine
        Dim intBursts As Integer = Val(txtBursts.Text)
        If chkTimeToKill.Checked = True Then
            For a = 0 To intBursts - 1
                Pl.ImageGraphic.DrawEllipse(New System.Drawing.Pen(Color.YellowGreen, 4), coord1x(a), coord1y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(New System.Drawing.Pen(Color.Yellow, 4), coord2x(a), coord2y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(New System.Drawing.Pen(Color.Orange, 4), coord3x(a), coord3y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(New System.Drawing.Pen(Color.Red, 4), coord4x(a), coord4y(a), 7, 7)
                Pl.ImageGraphic.DrawEllipse(New System.Drawing.Pen(Color.DarkRed, 4), coord5x(a), coord5y(a), 7, 7)
            Next
            SetImage_ThreadSafe(Pl.Image)
            Application.DoEvents()
            Debug.WriteLine("Bursts: " & intBursts)
            Debug.WriteLine("Hits #1: " & aryHits(0))
            Debug.WriteLine("1st. bullet: " + Math.Round((aryHits(0) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "2nd. bullet: " + Math.Round((aryHits(1) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "3rd. bullet: " + Math.Round((aryHits(2) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "4th. bullet: " + Math.Round((aryHits(3) / (intBursts + 1) * 100), 2).ToString + "%" + nl + _
                   "5th. bullet: " + Math.Round((aryHits(4) / (intBursts + 1) * 100), 2).ToString + "%")

        End If
        If chkDrawTTK.Checked And chkTimeToKill.Checked Then
            drawTTK(Pl.ImageGraphic, Math.Round((aryHits(0) / (intBursts + 1) * 100), 2), Math.Round((aryHits(1) / (intBursts + 1) * 100), 2), Math.Round((aryHits(2) / (intBursts + 1) * 100), 2), Math.Round((aryHits(3) / (intBursts + 1) * 100), 2), Math.Round((aryHits(4) / (intBursts + 1) * 100), 2))
        End If
        If chkHeatMap.Checked Then
            SetOutPutText_ThreadSafe("Please wait... Creating heat map")
            Application.DoEvents()
            Pl.HeatMap = CreateIntensityMask(Pl.HeatMap, HeatPoints, numHeatRadius.Value)
            ' Colorize the memory bitmap and assign it as the picture boxes image
            Pl.HeatMap = Colorize(Pl.HeatMap, 255, paletteOverride)
        End If
        If chkTitles.Checked Then
            drawTitle(Pl.ImageGraphic)
        End If
        If chkPrintAdj.Checked Then
            drawAdjustments(Pl.ImageGraphic)
        End If
        If chkRenderBulletDrop.Checked Then
            drawBulletDrop(Pl.ImageGraphic)
        End If
        If chkWriteDropInfo.Checked Then
            drawDropInfo(Pl.ImageGraphic)
        End If
        If chkDrawGrid.Checked Then
            drawGrid(Pl.ImageGraphic)
        End If
        If chkRenderHeatBars.Checked Then
            drawBars(Pl.HeatGraphic)
        End If
        If chkRenderHeatAdjust.Checked Then
            drawAdjustments(Pl.HeatGraphic)
        End If
        If chkRenderHeatTitle.Checked Then
            drawTitle(Pl.HeatGraphic)
        End If
        drawTTKSplit(Pl.TTKGraphic)
        If chkDrawTTKGrid.Checked Then
            drawTTKGrid(Pl.TTKGraphic)
        End If
        If chkDrawDropGrid.Checked Then
            drawTTKGrid(Pl.TTKGraphic)
            drawDropGrid(Pl.TTKGraphic)
        End If
        drawTTKBulletDamageArc(Pl.TTKGraphic)
        drawTTKBulletDropArc(Pl.TTKGraphic)
        '       drawTTKChart(Pl.TTKGraphic)
        ToggleToolStripMain_ThreadSafe(True)
        selectView("main")
        ToggleToolStripMask_ThreadSafe(True)


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub buildFileName()
        saveImageFileName = convertFileName(txtFilename.Text)
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
                buildFileName()
                SaveImage()
            End If
        End If
        If chkHeatMap.Checked Then
            ToggleToolStripHeatMap_ThreadSafe(True)
            Me.HeatMapToolStripMenuItem.Enabled = True
        End If
        Me.btnStart.Enabled = True
        Me.btnStop.Enabled = False

        Me.grpWeapon.Enabled = True
        Me.tabMain.Enabled = True
        Me.grpStance.Enabled = True
        Me.viewToolStrip.Enabled = True

        Me.ZoomToolStripMenuItem.Enabled = True
        Me.TTKToolStripMenuItem.Enabled = True
        Me.MaskToolStripMenuItem.Enabled = True

    End Sub
    Private Sub SaveImage()

        Dim b As New Bitmap(Pl.Image)

        Dim file = saveImagePath & "\" & saveImageFileName
        Debug.WriteLine("Filename: " & file)


        b.Save(file)
        b.Dispose()

        If chkHeatMap.Checked And chkSaveHeatMap.Checked Then
            Dim h As New Bitmap(Pl.HeatMap)

            Dim heatFileName As String = file.Insert((file.Length - 4), "_heatmap")
            Debug.WriteLine("Heat Filename: " & file)
            h.Save(heatFileName)
            h.Dispose()
        End If

        If chkSaveTTKChart.Checked Then
            Dim t As New Bitmap(Pl.TTK)

            Dim ttkFileName As String = file.Insert((file.Length - 4), "_TTK")
            Debug.WriteLine("TTK Filename: " & file)
            t.Save(ttkFileName)
            t.Dispose()
        End If

        mainToolStripStatus.Text = "Image Saved: " & file
        'Dispose of the images
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
    End Sub

    Private Function convertFileName(ByVal inputString As String) As String

        inputString = inputString.Replace("<<Title>>", Pl.Title)
        inputString = inputString.Replace("<<Info>>", Pl.Info)
        inputString = inputString.Replace("<<Sub>>", Pl.SubText)
        inputString = inputString & ".png"

        Return inputString
    End Function

#Region "Delegates and Thread Subs"
    Delegate Sub ToggleToolStripMain_Delegate(ByVal [viewBool] As Boolean)
    ' The delegates subroutine.
    Private Sub ToggleToolStripMain_ThreadSafe(ByVal [viewBool] As Boolean)
        ViewMainToolStripMenuItem.Enabled = [viewBool]
    End Sub
    Delegate Sub CheckToolStripMain_Delegate(ByVal [checked] As CheckState)
    Private Sub CheckToolStripMain_ThreadSafe(ByVal [checked] As CheckState)
        If picPlot.InvokeRequired Then
            Dim MyDelegate As New CheckToolStripMain_Delegate(AddressOf CheckToolStripMain_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[checked]})
        Else
            ViewMainToolStripMenuItem.CheckState = [checked]
        End If
    End Sub
    Delegate Sub ToggleToolStripHeatMap_Delegate(ByVal [viewBool] As Boolean)
    ' The delegates subroutine.
    Private Sub ToggleToolStripHeatMap_ThreadSafe(ByVal [viewBool] As Boolean)
        ViewHeatMapToolStripMenuItem.Enabled = [viewBool]
    End Sub
    Delegate Sub CheckToolStripHeatMap_Delegate(ByVal [checked] As CheckState)
    Private Sub CheckToolStripHeatMap_ThreadSafe(ByVal [checked] As CheckState)
        ViewHeatMapToolStripMenuItem.CheckState = [checked]
    End Sub
    Delegate Sub CheckToolStripTTK_Delegate(ByVal [checked] As CheckState)
    Private Sub CheckToolStripTTK_ThreadSafe(ByVal [checked] As CheckState)
        If picPlot.InvokeRequired Then
            Dim MyDelegate As New CheckToolStripTTK_Delegate(AddressOf CheckToolStripTTK_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[checked]})
        Else
            ViewTTKToolStripMenuItem.CheckState = [checked]
        End If
    End Sub
    Delegate Sub ToggleToolStripMask_Delegate(ByVal [viewBool] As Boolean)
    ' The delegates subroutine.
    Private Sub ToggleToolStripMask_ThreadSafe(ByVal [viewBool] As Boolean)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If picPlot.InvokeRequired Then
            Dim MyDelegate As New ToggleToolStripMask_Delegate(AddressOf ToggleToolStripMask_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[viewBool]})
        Else
            ViewMaskToolStripMenuItem.Enabled = [viewBool]
        End If
    End Sub
    Delegate Sub CheckToolStripMask_Delegate(ByVal [checked] As CheckState)
    Private Sub CheckToolStripMask_ThreadSafe(ByVal [checked] As CheckState)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If picPlot.InvokeRequired Then
            Dim MyDelegate As New CheckToolStripMask_Delegate(AddressOf CheckToolStripMask_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[checked]})
        Else
            ViewMaskToolStripMenuItem.CheckState = [checked]
        End If
    End Sub

    Delegate Sub SetToolStripText_Delegate(ByVal [text] As String)
    Private Sub SetToolStripText_ThreadSafe(ByVal [text] As String)
        viewToolStrip.Text = [text]
    End Sub

    Delegate Sub SetOutPutText_Delegate(ByVal [text] As String)
    ' The delegates subroutine.
    Private Sub SetOutPutText_ThreadSafe(ByVal [text] As String)
        mainToolStripStatus.Text = [text]
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
#End Region

    Private Sub chkSaveImage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSaveImage.CheckedChanged
        If sender.checked Then
            txtFilename.Enabled = True
            chkSaveTTKChart.Enabled = True
            chkSaveHeatMap.Enabled = True
            btnSaveImage.Enabled = True

            If saveImagePath = "" Then
                btnSaveImage_Click()
            End If
        Else
            txtFilename.Enabled = False
            chkSaveTTKChart.Enabled = False
            chkSaveHeatMap.Enabled = False
            btnSaveImage.Enabled = False
        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        System.Diagnostics.Process.Start("http://symthic.com")
    End Sub

    Private Sub CreateTemplateIni()
        ' Dim sValue As String
        Dim spath As String = Path.Combine(Directory.GetCurrentDirectory, "plotic_silent_template.ini")

        INIWrite(spath, "Config", "DecimalSymbol", ".")

        INIWrite(spath, "Recoil", "RecoilUp", "0.55")
        INIWrite(spath, "Recoil", "RecoilLeft", "0.2")
        INIWrite(spath, "Recoil", "RecoilRight", "0.3")
        INIWrite(spath, "Recoil", "FirstShot", "1.3")
        INIWrite(spath, "Recoil", "RecoilDecrease", "15")

        INIWrite(spath, "Spread", "SpreadMin", "0.1")
        INIWrite(spath, "Spread", "SpreadInc", "0.12")

        INIWrite(spath, "Burst", "BulletsPerBurst", "5")
        INIWrite(spath, "Burst", "Bursts", "1000")

        INIWrite(spath, "Attach", "RenderAttachText", "0")
        INIWrite(spath, "Attach", "AttachRecoilV", "0")
        INIWrite(spath, "Attach", "AttachRecoilH", "0")
        INIWrite(spath, "Attach", "AttachSpreadMin", "0")
        INIWrite(spath, "Attach", "AttachSpreadInc", "0")
        INIWrite(spath, "Attach", "AttachSpreadInc", "0")
        INIWrite(spath, "Attach", "MultiplyVerticalRecoil", "0")
        INIWrite(spath, "Attach", "VerticalMultiplier", "0.3")

        INIWrite(spath, "Save", "SavePath", Directory.GetCurrentDirectory)
        INIWrite(spath, "Save", "FileName", "<<Title>>_bf3_<<Sub>>")

        INIWrite(spath, "Render", "ScaleRadius", "1")
        INIWrite(spath, "Render", "RenderBars", "1")

        INIWrite(spath, "Title", "RenderTitleText", "1")
        INIWrite(spath, "Title", "TitleText", "AEK-17")
        INIWrite(spath, "Title", "InfoText", "Dmg 25-17")
        INIWrite(spath, "Title", "SubText", "Stock")

        INIWrite(spath, "Grid", "RenderGrid", "0")
        INIWrite(spath, "Grid", "Scale", "650")
        INIWrite(spath, "Grid", "IsDegrees", "0")
        INIWrite(spath, "Grid", "Distance", "30")
        INIWrite(spath, "Grid", "GridValue", "1")

        INIWrite(spath, "TTk", "RenderTTK", "0")
        INIWrite(spath, "TTK", "RenderHitRates", "0")
        INIWrite(spath, "TTK", "BulletVelocity", "500")
        INIWrite(spath, "TTK", "RateOfFire", "500")
        INIWrite(spath, "TTK", "MaxDistance", "0")
        INIWrite(spath, "TTK", "BulletDrop", "15")

        INIWrite(spath, "HeatMap", "RenderHeatMap", "1")
        INIWrite(spath, "HeatMap", "Radius", "75")
        INIWrite(spath, "HeatMap", "IntensityScale", "2.0")
        INIWrite(spath, "HeatMap", "OverwriteFile", "0")

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

#Region "Heat Map Creation"
    Private Function CreateIntensityMask(bSurface As Bitmap, aHeatPoints As List(Of HeatPoint), iRadius As Integer) As Bitmap
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
#End Region
#Region "INI Read/Write"
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
        sData = Space$(1024) ' allocate some room
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
        sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
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
#End Region
#Region "Toolstrip Menu Actions"
    Private Sub ViewMainToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewMainToolStripMenuItem.Click
        selectView("main")
    End Sub
    Private Sub ViewHeatMapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewHeatMapToolStripMenuItem.Click
        selectView("heat")
    End Sub
    Private Sub ViewMaskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewMaskToolStripMenuItem.Click
        selectView("mask")
    End Sub
    Private Sub ViewTTKToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewTTKToolStripMenuItem.Click
        selectView("ttk")
    End Sub
#End Region
#Region "Context Menu Actions"
    Private Sub MainToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MainToolStripMenuItem.Click
        selectView("main")
    End Sub
    Private Sub MaskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaskToolStripMenuItem.Click
        selectView("mask")
    End Sub
    Private Sub HeatMapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HeatMapToolStripMenuItem.Click
        selectView("heat")
    End Sub
    Private Sub TTKToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TTKToolStripMenuItem.Click
        selectView("ttk")
    End Sub
    Private Sub X500ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles X500ToolStripMenuItem.Click
        showImage(500)
    End Sub
    Private Sub X1000ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles X1000ToolStripMenuItem.Click
        showImage(800)
    End Sub
    Private Sub X1000ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles X1000ToolStripMenuItem1.Click
        showImage(1000)
    End Sub
#End Region
#Region "Weapon Pull Functions"
    Public Function GetSpeed(ByVal weapon As String) As Double
        If weapon = "M16A4" Then weapon = "M16A4_2"
        If weapon = "M4A1" Then weapon = "M4A1_2"
        Dim data = GetData(weapon, "")
        If data = "FILENOTFOUND" Then Return "ERROR"
        data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "InitialSpeed"))
        Dim start = InStr(data, "InitialSpeed")
        Dim Test = InStr(data, "z") + 2
        data = Microsoft.VisualBasic.Mid(data, Test, 50)
        Dim val As String = ""
        Dim leni As Integer = 1
        Do Until InStr(val, Environment.NewLine)
            val = Microsoft.VisualBasic.Left(data, leni)
            leni += 1
        Loop
        val = Microsoft.VisualBasic.Left(val, Len(val) - 1)
        Return Double.Parse(Trim(val), System.Globalization.CultureInfo.InvariantCulture)
    End Function
    Public Function GetRateOfFire(ByVal weapon As String) As Double
        If weapon = "M16A4" Then weapon = "M16A4_2"
        If weapon = "M4A1" Then weapon = "M4A1_2"
        Dim value As String = "RateOfFire "
        Dim data = GetData(weapon, "")
        If data = "FILENOTFOUND" Then Return "ERROR"
        data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, value))
        Dim start = InStr(data, value) + (Len(value))
        data = Microsoft.VisualBasic.Mid(data, start, 200)
        Dim val As String = ""
        Dim leni As Integer = 1
        Do Until InStr(val, Environment.NewLine)
            val = Microsoft.VisualBasic.Left(data, leni)
            leni += 1
        Loop
        val = Microsoft.VisualBasic.Left(val, Len(val) - 1)
        Return Double.Parse(Trim(val), System.Globalization.CultureInfo.InvariantCulture)
    End Function

    Public Function GetAttachmentValue(ByVal weapon As String, ByVal attachment As String, ByVal value As String, ByVal stance As String)
        Dim data = GetData(weapon, attachment)
        If data = "FILENOTFOUND" Then Return "ERROR"
        data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, stance))
        Dim start = InStr(data, value) + (Len(value) + 1)
        data = Microsoft.VisualBasic.Mid(data, start, 200)
        Dim val As String = ""
        Dim leni As Integer = 1
        Do Until InStr(val, Environment.NewLine)
            val = Microsoft.VisualBasic.Left(data, leni)
            leni += 1
        Loop
        val = Microsoft.VisualBasic.Left(val, Len(val) - 1)
        Return val
    End Function
    Public Function GetValue(ByVal weapon As String, ByVal value As String, Optional ByVal stance As String = "Stand")
        Dim data = GetData(weapon, "")
        Dim preparsevalues = "-IncreasePerShotMinAngleMaxAngleDecreasePerSecondRecoilAmplitudeMaxRecoilAmplitudeIncPerShotHorizontalRecoilAmplitudeIncPerShotMinHorizontalRecoilAmplitudeIncPerShotMaxHorizontalRecoilAmplitudeMaxRecoilAmplitudeDecreaseFactor-"
        If InStr(preparsevalues, value) Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "WeaponSwayData"))
        Else
            If InStr(value, "MinAngle") Or InStr(value, "MaxAngle") Then
                data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "WeaponSwayData"))
            End If
        End If
        'MsgBox(Microsoft.VisualBasic.Left(data, 200))
        stance = "-" + stance + "-"
        If InStr(stance, "Stand") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "Stand"))
        ElseIf InStr(stance, "Crouch") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "Crouch"))
        ElseIf InStr(stance, "Prone") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "Prone") - 1)
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "Prone") - 1)
        End If
        'MsgBox(Microsoft.VisualBasic.Left(data, 200))
        If InStr(value, "ADS") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, ControlChars.Tab & "Zoom"))
        ElseIf InStr(value, "HIP") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "NoZoom"))
        End If
        'MsgBox(Microsoft.VisualBasic.Left(data, 200))
        If InStr(value, "Base") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "BaseValue"))
        ElseIf InStr(value, "Moving") Then
            data = Microsoft.VisualBasic.Right(data, Len(data) - InStr(data, "Moving"))
        End If
        'MsgBox(Microsoft.VisualBasic.Left(data, 200))
        If InStr(value, "MinAngle") Then
            value = "MinAngle"
        ElseIf InStr(value, "MaxAngle") Then
            value = "MaxAngle"
        End If
        Dim start = InStr(data, value) + (Len(value) + 1)
        data = Microsoft.VisualBasic.Mid(data, start, 200)
        Dim val As String = ""
        Dim leni As Integer = 1
        Do Until InStr(val, Environment.NewLine)
            val = Microsoft.VisualBasic.Left(data, leni)
            leni += 1
        Loop
        val = Microsoft.VisualBasic.Left(val, Len(val) - 1)
        Return val
    End Function
    Public Function GetData(ByVal weapon As String, ByVal attachment As String)
        Dim basepath As String = System.IO.Path.Combine(Directory.GetCurrentDirectory, "weapons")
        If weapon = "Glock17" Then
            weapon = "Glock18"
        End If
        Dim weapon1 = weapon
        If attachment = "" Then
            If weapon = "M16A4_2" Then
                weapon = "M16A4"
                weapon1 = "M16A4"
            ElseIf weapon = "M4A1_2" Then
                weapon = "M4A1"
                weapon1 = "M4A1"
            ElseIf weapon = "M4A1" Or weapon = "M16A4" Then
                weapon1 = weapon + "_Gunsway"
            End If
        End If
        Dim path = basepath + "\" + weapon + "\" + weapon1
        If Not attachment = "" Then
            path += "_" + attachment
        End If
        path += ".sym"
        ' Debug.WriteLine(path)
        If File.Exists(path) Then
            Return My.Computer.FileSystem.ReadAllText(path)
        Else
            Return "FILENOTFOUND"
        End If
    End Function
#End Region

    Private Sub comboWeapon1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboWeapon1.SelectedIndexChanged
        If sender.text <> "<<CUSTOM>>" Then
            grpCustomTTK.Enabled = False
            grpAttach.Enabled = False
            grpRecoil.Enabled = False
            grpSpread.Enabled = False

            grpStance.Enabled = True
            grpBarrel.Enabled = True
            grpUnderBarrel.Enabled = True

            updateAttachmentSelection()
            renderGunImage()
        Else
            grpCustomTTK.Enabled = True
            grpAttach.Enabled = True
            grpRecoil.Enabled = True
            grpSpread.Enabled = True

            grpStance.Enabled = False
            grpBarrel.Enabled = False
            grpUnderBarrel.Enabled = False

            picPlot.Image = New Bitmap(My.Resources.knife)
        End If

        'Reset the Attachments
        radBarrelNone.Checked = True
        radUnderNone.Checked = True

        Pl.AdjRecoilH = 0
        Pl.AdjRecoilV = 0
        Pl.AdjSpreadInc = 0
        Pl.AdjSpreadMin = 0

    End Sub
    Private Sub renderGunImage()
        Dim basepath As String = System.IO.Path.Combine(Directory.GetCurrentDirectory, "gun_images")
        Dim path = basepath & "\" & comboWeapon1.Text.ToLower & ".png"
        If File.Exists(path) Then
            picPlot.Image = DirectCast(Bitmap.FromFile(path), Bitmap)
            picPlot.SizeMode = PictureBoxSizeMode.Zoom
            'Debug.WriteLine("Gun Image Found at " & path)

        Else
            Debug.WriteLine("No Gun Image Found at " & path)
            picPlot.Image = New Bitmap(My.Resources.knife)
        End If
    End Sub
    Private Sub updateAttachmentSelection()
        If GetData(comboWeapon1.Text, "HeavyBarrel") = "FILENOTFOUND" Then
            radBarrelHeavy.Enabled = False
        Else
            radBarrelHeavy.Enabled = True
        End If

        If GetData(comboWeapon1.Text, "Silencer") = "FILENOTFOUND" Then
            radBarrelSilencer.Enabled = False
        Else
            radBarrelSilencer.Enabled = True
        End If

        If GetData(comboWeapon1.Text, "Flash_Suppressor") = "FILENOTFOUND" Then
            radBarrelFlash.Enabled = False
        Else
            radBarrelFlash.Enabled = True
        End If

        If GetData(comboWeapon1.Text, "Foregrip") = "FILENOTFOUND" Then
            radUnderForegrip.Enabled = False
        Else
            radUnderForegrip.Enabled = True
        End If

        If GetData(comboWeapon1.Text, "TargetPointer") = "FILENOTFOUND" Then
            radUnderLaser.Enabled = False
        Else
            radUnderLaser.Enabled = True
        End If

        If GetData(comboWeapon1.Text, "Bipod") = "FILENOTFOUND" Then
            radUnderBipod.Enabled = False
        Else
            radUnderBipod.Enabled = True
        End If
    End Sub

    Public Function RecoilDecrease(ByVal StartX As Integer, ByVal StartY As Integer, ByVal ShootX As Integer, ByVal ShootY As Integer, ByVal DecPerSec As Double, ByVal RoF As Integer, ByVal PxPerDegScale As Integer, ByVal YorX As String)
        Dim diffX, diffY As Integer

        diffX = Math.Abs(StartX - ShootX)
        diffY = Math.Abs(StartY - ShootY)
        Dim hypotenuseBig = Math.Sqrt(diffY ^ 2 + diffX ^ 2)
        Dim hypotenuseSmall = PxPerDegScale * (DecPerSec / 10) / (RoF / 60)
        Dim sideScaleRatio = diffY / hypotenuseBig
        Dim bottomScaleRatio = diffX / hypotenuseBig
        Dim diffXSmall = bottomScaleRatio * hypotenuseSmall
        Dim diffYSmall = sideScaleRatio * hypotenuseSmall
        If YorX = "Y" Or YorX = "y" Then
            Return Math.Round(diffYSmall + ShootY, 0)
        Else
            If StartX > ShootX Then Return Math.Round(ShootX + diffXSmall, 0) Else Return Math.Round(ShootX - diffXSmall, 0)
            Exit Function
        End If
        Return 0
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmAbout.Show()
    End Sub

    Private Sub chkRenderAmmoInfo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRenderAmmoInfo.CheckedChanged
        If sender.checked Then
            radAmmoImage.Enabled = True
            radAmmoText.Enabled = True

        Else
            radAmmoImage.Enabled = False
            radAmmoText.Enabled = False

        End If
    End Sub

    Private Sub chkDrawGrid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDrawGrid.CheckedChanged
        If sender.checked Then
            radMeters.Enabled = True
            radDegrees.Enabled = True
            numLineSpace.Enabled = True
        Else
            radMeters.Enabled = False
            radDegrees.Enabled = False
            numLineSpace.Enabled = False
        End If
    End Sub

    Private Sub chkTimeToKill_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTimeToKill.CheckedChanged
        If sender.checked Then
            comboSilhouetteStyle.Enabled = True
        Else
            comboSilhouetteStyle.Enabled = False
        End If
    End Sub

    Private Sub chkRenderBulletDrop_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRenderBulletDrop.CheckedChanged
        If sender.checked Then
            grpStyle.Enabled = True
            numDropLineThickness.Enabled = True
        Else
            grpStyle.Enabled = False
            numDropLineThickness.Enabled = False
        End If
    End Sub

    Private Sub chkDrawDropGrid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDrawDropGrid.CheckedChanged
        If sender.checked Then
            numDropHorizontalScale.Enabled = True
            numDropVerticalScale.Enabled = True
        Else
            numDropHorizontalScale.Enabled = False
            numDropVerticalScale.Enabled = False
        End If
    End Sub

    Private Sub chkDrawTTKGrid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDrawTTKGrid.CheckedChanged
        If sender.checked Then
            numTTKHorizontalScale.Enabled = True
            numTTKVerticalScale.Enabled = True
        Else
            numTTKHorizontalScale.Enabled = False
            numTTKVerticalScale.Enabled = False
        End If
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

