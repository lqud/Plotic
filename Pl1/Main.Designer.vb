<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.grpStance = New System.Windows.Forms.GroupBox()
        Me.chkStanceMoving = New System.Windows.Forms.CheckBox()
        Me.chkStanceZoom = New System.Windows.Forms.CheckBox()
        Me.radProne = New System.Windows.Forms.RadioButton()
        Me.radCrouch = New System.Windows.Forms.RadioButton()
        Me.radStand = New System.Windows.Forms.RadioButton()
        Me.numBulletsPerBurst = New System.Windows.Forms.NumericUpDown()
        Me.lbbpbm = New System.Windows.Forms.Label()
        Me.lbbm = New System.Windows.Forms.Label()
        Me.txtBursts = New System.Windows.Forms.TextBox()
        Me.chkPrintAdj = New System.Windows.Forms.CheckBox()
        Me.chkDrawGrid = New System.Windows.Forms.CheckBox()
        Me.chkScaleRadius = New System.Windows.Forms.CheckBox()
        Me.grpWeapon = New System.Windows.Forms.GroupBox()
        Me.comboWeapon1 = New System.Windows.Forms.ComboBox()
        Me.lblBurstCounter = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.grpAttach = New System.Windows.Forms.GroupBox()
        Me.numRecoilH = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblIncTitle = New System.Windows.Forms.Label()
        Me.numMin = New System.Windows.Forms.NumericUpDown()
        Me.lblMinTitle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numInc = New System.Windows.Forms.NumericUpDown()
        Me.numRecoilMultiplier = New System.Windows.Forms.NumericUpDown()
        Me.lblAdjInc = New System.Windows.Forms.Label()
        Me.chkMultiplyRecoil = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAdjMin = New System.Windows.Forms.Label()
        Me.numRecoilV = New System.Windows.Forms.NumericUpDown()
        Me.lblAdjRight = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAdjLeft = New System.Windows.Forms.Label()
        Me.lblAdjUp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.mainToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkTitles = New System.Windows.Forms.CheckBox()
        Me.numMeters = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.radDegrees = New System.Windows.Forms.RadioButton()
        Me.radMeters = New System.Windows.Forms.RadioButton()
        Me.numLineSpace = New System.Windows.Forms.NumericUpDown()
        Me.chkBars = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.viewToolStrip = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHeatMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTTKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabRender = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTimeToKill = New System.Windows.Forms.CheckBox()
        Me.chkDrawTTK = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabSaveOptions = New System.Windows.Forms.TabPage()
        Me.chkSaveTTKChart = New System.Windows.Forms.CheckBox()
        Me.chkSaveHeatMap = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.chkSaveImage = New System.Windows.Forms.CheckBox()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.tabHeatMap = New System.Windows.Forms.TabPage()
        Me.chkRenderHeatBars = New System.Windows.Forms.CheckBox()
        Me.chkRenderHeatTitle = New System.Windows.Forms.CheckBox()
        Me.chkRenderHeatAdjust = New System.Windows.Forms.CheckBox()
        Me.numIntensityScale = New System.Windows.Forms.NumericUpDown()
        Me.numHeatRadius = New System.Windows.Forms.NumericUpDown()
        Me.chkHeatMap = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabAdvanced = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAdvBulletDrop = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numMaxDistance = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numBulletDrop = New System.Windows.Forms.NumericUpDown()
        Me.numDropLineThickness = New System.Windows.Forms.NumericUpDown()
        Me.chkRenderBulletDrop = New System.Windows.Forms.CheckBox()
        Me.chkWriteDropInfo = New System.Windows.Forms.CheckBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.numDropVerticalScale = New System.Windows.Forms.NumericUpDown()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.numDropHorizontalScale = New System.Windows.Forms.NumericUpDown()
        Me.chkDrawDropGrid = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabAdvTTK = New System.Windows.Forms.TabPage()
        Me.grpCustomTTK = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.numBulletVelocity = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.numRateOfFire = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.numDamagePercent = New System.Windows.Forms.NumericUpDown()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.numHealthPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.numDamageSplitter = New System.Windows.Forms.NumericUpDown()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.numMinRange = New System.Windows.Forms.NumericUpDown()
        Me.numMaxRange = New System.Windows.Forms.NumericUpDown()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.numTTKGridSpacing = New System.Windows.Forms.NumericUpDown()
        Me.chkDrawTTKGrid = New System.Windows.Forms.CheckBox()
        Me.numTTKRange = New System.Windows.Forms.NumericUpDown()
        Me.numDamageMin = New System.Windows.Forms.NumericUpDown()
        Me.numDamageMax = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tabCustom = New System.Windows.Forms.TabPage()
        Me.grpSpread = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.grpRecoil = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contextImgRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeatMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X500ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X1000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X1000ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBarrelNone = New System.Windows.Forms.RadioButton()
        Me.radUnderLaser = New System.Windows.Forms.RadioButton()
        Me.radBarrelFlash = New System.Windows.Forms.RadioButton()
        Me.radBarrelSilencer = New System.Windows.Forms.RadioButton()
        Me.radBarrelHeavy = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUnderNone = New System.Windows.Forms.RadioButton()
        Me.radUnderBipod = New System.Windows.Forms.RadioButton()
        Me.radUnderForegrip = New System.Windows.Forms.RadioButton()
        Me.picPlot = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.comboSilhouetteStyle = New System.Windows.Forms.ComboBox()
        Me.grpStance.SuspendLayout()
        CType(Me.numBulletsPerBurst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWeapon.SuspendLayout()
        Me.grpAttach.SuspendLayout()
        CType(Me.numRecoilH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRecoilMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRecoilV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMeters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabRender.SuspendLayout()
        Me.tabSaveOptions.SuspendLayout()
        Me.tabHeatMap.SuspendLayout()
        CType(Me.numIntensityScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeatRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvanced.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabAdvBulletDrop.SuspendLayout()
        CType(Me.numMaxDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBulletDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDropLineThickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDropVerticalScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDropHorizontalScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvTTK.SuspendLayout()
        Me.grpCustomTTK.SuspendLayout()
        CType(Me.numBulletVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRateOfFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDamagePercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHealthPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDamageSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTTKGridSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTTKRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDamageMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDamageMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustom.SuspendLayout()
        Me.grpSpread.SuspendLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecoil.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextImgRightClick.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picPlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStance
        '
        Me.grpStance.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpStance.Controls.Add(Me.chkStanceMoving)
        Me.grpStance.Controls.Add(Me.chkStanceZoom)
        Me.grpStance.Controls.Add(Me.radProne)
        Me.grpStance.Controls.Add(Me.radCrouch)
        Me.grpStance.Controls.Add(Me.radStand)
        Me.grpStance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStance.ForeColor = System.Drawing.Color.White
        Me.grpStance.Location = New System.Drawing.Point(250, 14)
        Me.grpStance.Name = "grpStance"
        Me.grpStance.Size = New System.Drawing.Size(139, 72)
        Me.grpStance.TabIndex = 32
        Me.grpStance.TabStop = False
        Me.grpStance.Text = "Stance"
        '
        'chkStanceMoving
        '
        Me.chkStanceMoving.AutoSize = True
        Me.chkStanceMoving.Location = New System.Drawing.Point(71, 42)
        Me.chkStanceMoving.Name = "chkStanceMoving"
        Me.chkStanceMoving.Size = New System.Drawing.Size(61, 17)
        Me.chkStanceMoving.TabIndex = 4
        Me.chkStanceMoving.Text = "Moving"
        Me.chkStanceMoving.UseVisualStyleBackColor = True
        '
        'chkStanceZoom
        '
        Me.chkStanceZoom.AutoSize = True
        Me.chkStanceZoom.Checked = True
        Me.chkStanceZoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStanceZoom.Location = New System.Drawing.Point(71, 21)
        Me.chkStanceZoom.Name = "chkStanceZoom"
        Me.chkStanceZoom.Size = New System.Drawing.Size(53, 17)
        Me.chkStanceZoom.TabIndex = 3
        Me.chkStanceZoom.Text = "Zoom"
        Me.chkStanceZoom.UseVisualStyleBackColor = True
        '
        'radProne
        '
        Me.radProne.AutoSize = True
        Me.radProne.Location = New System.Drawing.Point(6, 47)
        Me.radProne.Name = "radProne"
        Me.radProne.Size = New System.Drawing.Size(53, 17)
        Me.radProne.TabIndex = 2
        Me.radProne.Text = "Prone"
        Me.radProne.UseVisualStyleBackColor = True
        '
        'radCrouch
        '
        Me.radCrouch.AutoSize = True
        Me.radCrouch.Location = New System.Drawing.Point(6, 30)
        Me.radCrouch.Name = "radCrouch"
        Me.radCrouch.Size = New System.Drawing.Size(59, 17)
        Me.radCrouch.TabIndex = 1
        Me.radCrouch.Text = "Crouch"
        Me.radCrouch.UseVisualStyleBackColor = True
        '
        'radStand
        '
        Me.radStand.AutoSize = True
        Me.radStand.Checked = True
        Me.radStand.Location = New System.Drawing.Point(6, 13)
        Me.radStand.Name = "radStand"
        Me.radStand.Size = New System.Drawing.Size(53, 17)
        Me.radStand.TabIndex = 0
        Me.radStand.TabStop = True
        Me.radStand.Text = "Stand"
        Me.radStand.UseVisualStyleBackColor = True
        '
        'numBulletsPerBurst
        '
        Me.numBulletsPerBurst.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numBulletsPerBurst.ForeColor = System.Drawing.Color.White
        Me.numBulletsPerBurst.Location = New System.Drawing.Point(165, 52)
        Me.numBulletsPerBurst.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numBulletsPerBurst.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBulletsPerBurst.Name = "numBulletsPerBurst"
        Me.numBulletsPerBurst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numBulletsPerBurst.Size = New System.Drawing.Size(48, 20)
        Me.numBulletsPerBurst.TabIndex = 67
        Me.numBulletsPerBurst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numBulletsPerBurst.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lbbpbm
        '
        Me.lbbpbm.AutoSize = True
        Me.lbbpbm.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lbbpbm.ForeColor = System.Drawing.Color.White
        Me.lbbpbm.Location = New System.Drawing.Point(83, 55)
        Me.lbbpbm.Name = "lbbpbm"
        Me.lbbpbm.Size = New System.Drawing.Size(82, 13)
        Me.lbbpbm.TabIndex = 14
        Me.lbbpbm.Text = "Bullets per burst"
        '
        'lbbm
        '
        Me.lbbm.AutoSize = True
        Me.lbbm.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lbbm.ForeColor = System.Drawing.Color.White
        Me.lbbm.Location = New System.Drawing.Point(2, 54)
        Me.lbbm.Name = "lbbm"
        Me.lbbm.Size = New System.Drawing.Size(36, 13)
        Me.lbbm.TabIndex = 1
        Me.lbbm.Text = "Bursts"
        '
        'txtBursts
        '
        Me.txtBursts.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtBursts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBursts.ForeColor = System.Drawing.Color.White
        Me.txtBursts.Location = New System.Drawing.Point(39, 51)
        Me.txtBursts.Name = "txtBursts"
        Me.txtBursts.Size = New System.Drawing.Size(38, 20)
        Me.txtBursts.TabIndex = 21
        Me.txtBursts.Text = "250"
        Me.txtBursts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPrintAdj
        '
        Me.chkPrintAdj.AutoSize = True
        Me.chkPrintAdj.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkPrintAdj.ForeColor = System.Drawing.Color.White
        Me.chkPrintAdj.Location = New System.Drawing.Point(6, 41)
        Me.chkPrintAdj.Name = "chkPrintAdj"
        Me.chkPrintAdj.Size = New System.Drawing.Size(83, 17)
        Me.chkPrintAdj.TabIndex = 43
        Me.chkPrintAdj.Text = "Adjustments"
        Me.chkPrintAdj.UseVisualStyleBackColor = False
        '
        'chkDrawGrid
        '
        Me.chkDrawGrid.AutoSize = True
        Me.chkDrawGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkDrawGrid.Checked = True
        Me.chkDrawGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawGrid.ForeColor = System.Drawing.Color.White
        Me.chkDrawGrid.Location = New System.Drawing.Point(6, 99)
        Me.chkDrawGrid.Name = "chkDrawGrid"
        Me.chkDrawGrid.Size = New System.Drawing.Size(93, 17)
        Me.chkDrawGrid.TabIndex = 42
        Me.chkDrawGrid.Text = "Grid line every"
        Me.chkDrawGrid.UseVisualStyleBackColor = False
        '
        'chkScaleRadius
        '
        Me.chkScaleRadius.AutoSize = True
        Me.chkScaleRadius.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkScaleRadius.ForeColor = System.Drawing.Color.White
        Me.chkScaleRadius.Location = New System.Drawing.Point(6, 7)
        Me.chkScaleRadius.Name = "chkScaleRadius"
        Me.chkScaleRadius.Size = New System.Drawing.Size(84, 17)
        Me.chkScaleRadius.TabIndex = 0
        Me.chkScaleRadius.Text = "Scale radius"
        Me.chkScaleRadius.UseVisualStyleBackColor = False
        '
        'grpWeapon
        '
        Me.grpWeapon.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpWeapon.Controls.Add(Me.numBulletsPerBurst)
        Me.grpWeapon.Controls.Add(Me.comboWeapon1)
        Me.grpWeapon.Controls.Add(Me.lbbm)
        Me.grpWeapon.Controls.Add(Me.txtBursts)
        Me.grpWeapon.Controls.Add(Me.lbbpbm)
        Me.grpWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpWeapon.ForeColor = System.Drawing.Color.White
        Me.grpWeapon.Location = New System.Drawing.Point(16, 14)
        Me.grpWeapon.Name = "grpWeapon"
        Me.grpWeapon.Size = New System.Drawing.Size(228, 83)
        Me.grpWeapon.TabIndex = 31
        Me.grpWeapon.TabStop = False
        Me.grpWeapon.Text = "Weapon"
        '
        'comboWeapon1
        '
        Me.comboWeapon1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.comboWeapon1.ForeColor = System.Drawing.Color.White
        Me.comboWeapon1.FormattingEnabled = True
        Me.comboWeapon1.Location = New System.Drawing.Point(8, 21)
        Me.comboWeapon1.Name = "comboWeapon1"
        Me.comboWeapon1.Size = New System.Drawing.Size(205, 21)
        Me.comboWeapon1.TabIndex = 0
        Me.comboWeapon1.Text = "(Select Gun)"
        '
        'lblBurstCounter
        '
        Me.lblBurstCounter.AutoSize = True
        Me.lblBurstCounter.ForeColor = System.Drawing.Color.White
        Me.lblBurstCounter.Location = New System.Drawing.Point(288, 93)
        Me.lblBurstCounter.Name = "lblBurstCounter"
        Me.lblBurstCounter.Size = New System.Drawing.Size(57, 13)
        Me.lblBurstCounter.TabIndex = 35
        Me.lblBurstCounter.Text = "Burst 0 / 0"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.GreenYellow
        Me.btnStart.Location = New System.Drawing.Point(259, 113)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(121, 38)
        Me.btnStart.TabIndex = 30
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStop.Enabled = False
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.ForeColor = System.Drawing.Color.Firebrick
        Me.btnStop.Location = New System.Drawing.Point(259, 163)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(121, 23)
        Me.btnStop.TabIndex = 36
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'grpAttach
        '
        Me.grpAttach.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpAttach.Controls.Add(Me.numRecoilH)
        Me.grpAttach.Controls.Add(Me.Label11)
        Me.grpAttach.Controls.Add(Me.lblIncTitle)
        Me.grpAttach.Controls.Add(Me.numMin)
        Me.grpAttach.Controls.Add(Me.lblMinTitle)
        Me.grpAttach.Controls.Add(Me.Label10)
        Me.grpAttach.Controls.Add(Me.Label12)
        Me.grpAttach.Controls.Add(Me.numInc)
        Me.grpAttach.Controls.Add(Me.numRecoilMultiplier)
        Me.grpAttach.Controls.Add(Me.lblAdjInc)
        Me.grpAttach.Controls.Add(Me.chkMultiplyRecoil)
        Me.grpAttach.Controls.Add(Me.Label9)
        Me.grpAttach.Controls.Add(Me.lblAdjMin)
        Me.grpAttach.Controls.Add(Me.numRecoilV)
        Me.grpAttach.Controls.Add(Me.lblAdjRight)
        Me.grpAttach.Controls.Add(Me.Label8)
        Me.grpAttach.Controls.Add(Me.lblAdjLeft)
        Me.grpAttach.Controls.Add(Me.lblAdjUp)
        Me.grpAttach.Controls.Add(Me.Label4)
        Me.grpAttach.Controls.Add(Me.Label5)
        Me.grpAttach.Controls.Add(Me.Label6)
        Me.grpAttach.Controls.Add(Me.Label7)
        Me.grpAttach.Enabled = False
        Me.grpAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpAttach.ForeColor = System.Drawing.Color.White
        Me.grpAttach.Location = New System.Drawing.Point(147, 6)
        Me.grpAttach.Name = "grpAttach"
        Me.grpAttach.Size = New System.Drawing.Size(212, 136)
        Me.grpAttach.TabIndex = 40
        Me.grpAttach.TabStop = False
        Me.grpAttach.Text = "Attachment Adjustments       +/-100%"
        '
        'numRecoilH
        '
        Me.numRecoilH.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numRecoilH.ForeColor = System.Drawing.Color.White
        Me.numRecoilH.Location = New System.Drawing.Point(51, 44)
        Me.numRecoilH.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numRecoilH.Name = "numRecoilH"
        Me.numRecoilH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numRecoilH.Size = New System.Drawing.Size(48, 20)
        Me.numRecoilH.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(195, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "%"
        '
        'lblIncTitle
        '
        Me.lblIncTitle.AutoSize = True
        Me.lblIncTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblIncTitle.ForeColor = System.Drawing.Color.Red
        Me.lblIncTitle.Location = New System.Drawing.Point(127, 88)
        Me.lblIncTitle.Name = "lblIncTitle"
        Me.lblIncTitle.Size = New System.Drawing.Size(25, 13)
        Me.lblIncTitle.TabIndex = 10
        Me.lblIncTitle.Text = "Inc."
        '
        'numMin
        '
        Me.numMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numMin.ForeColor = System.Drawing.Color.White
        Me.numMin.Location = New System.Drawing.Point(147, 19)
        Me.numMin.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numMin.Name = "numMin"
        Me.numMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMin.Size = New System.Drawing.Size(48, 20)
        Me.numMin.TabIndex = 47
        '
        'lblMinTitle
        '
        Me.lblMinTitle.AutoSize = True
        Me.lblMinTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblMinTitle.ForeColor = System.Drawing.Color.Red
        Me.lblMinTitle.Location = New System.Drawing.Point(126, 68)
        Me.lblMinTitle.Name = "lblMinTitle"
        Me.lblMinTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblMinTitle.TabIndex = 10
        Me.lblMinTitle.Text = "Min."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(195, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(59, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "+"
        '
        'numInc
        '
        Me.numInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numInc.ForeColor = System.Drawing.Color.White
        Me.numInc.Location = New System.Drawing.Point(147, 45)
        Me.numInc.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numInc.Name = "numInc"
        Me.numInc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numInc.Size = New System.Drawing.Size(48, 20)
        Me.numInc.TabIndex = 45
        '
        'numRecoilMultiplier
        '
        Me.numRecoilMultiplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numRecoilMultiplier.DecimalPlaces = 4
        Me.numRecoilMultiplier.ForeColor = System.Drawing.Color.White
        Me.numRecoilMultiplier.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numRecoilMultiplier.Location = New System.Drawing.Point(137, 111)
        Me.numRecoilMultiplier.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numRecoilMultiplier.Name = "numRecoilMultiplier"
        Me.numRecoilMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numRecoilMultiplier.Size = New System.Drawing.Size(66, 20)
        Me.numRecoilMultiplier.TabIndex = 56
        Me.numRecoilMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numRecoilMultiplier.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'lblAdjInc
        '
        Me.lblAdjInc.AutoSize = True
        Me.lblAdjInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjInc.ForeColor = System.Drawing.Color.Red
        Me.lblAdjInc.Location = New System.Drawing.Point(155, 88)
        Me.lblAdjInc.MinimumSize = New System.Drawing.Size(40, 12)
        Me.lblAdjInc.Name = "lblAdjInc"
        Me.lblAdjInc.Size = New System.Drawing.Size(40, 15)
        Me.lblAdjInc.TabIndex = 46
        Me.lblAdjInc.Text = "0"
        Me.lblAdjInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkMultiplyRecoil
        '
        Me.chkMultiplyRecoil.AutoSize = True
        Me.chkMultiplyRecoil.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkMultiplyRecoil.ForeColor = System.Drawing.Color.White
        Me.chkMultiplyRecoil.Location = New System.Drawing.Point(6, 113)
        Me.chkMultiplyRecoil.Name = "chkMultiplyRecoil"
        Me.chkMultiplyRecoil.Size = New System.Drawing.Size(135, 17)
        Me.chkMultiplyRecoil.TabIndex = 55
        Me.chkMultiplyRecoil.Text = "Multiply Vertical Recoil:"
        Me.chkMultiplyRecoil.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(98, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "%"
        '
        'lblAdjMin
        '
        Me.lblAdjMin.AutoSize = True
        Me.lblAdjMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjMin.ForeColor = System.Drawing.Color.Red
        Me.lblAdjMin.Location = New System.Drawing.Point(155, 68)
        Me.lblAdjMin.MinimumSize = New System.Drawing.Size(40, 12)
        Me.lblAdjMin.Name = "lblAdjMin"
        Me.lblAdjMin.Size = New System.Drawing.Size(40, 15)
        Me.lblAdjMin.TabIndex = 45
        Me.lblAdjMin.Text = "0"
        Me.lblAdjMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numRecoilV
        '
        Me.numRecoilV.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numRecoilV.ForeColor = System.Drawing.Color.White
        Me.numRecoilV.Location = New System.Drawing.Point(51, 18)
        Me.numRecoilV.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numRecoilV.Name = "numRecoilV"
        Me.numRecoilV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numRecoilV.Size = New System.Drawing.Size(48, 20)
        Me.numRecoilV.TabIndex = 43
        '
        'lblAdjRight
        '
        Me.lblAdjRight.AutoSize = True
        Me.lblAdjRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjRight.ForeColor = System.Drawing.Color.Red
        Me.lblAdjRight.Location = New System.Drawing.Point(80, 87)
        Me.lblAdjRight.MinimumSize = New System.Drawing.Size(40, 12)
        Me.lblAdjRight.Name = "lblAdjRight"
        Me.lblAdjRight.Size = New System.Drawing.Size(40, 15)
        Me.lblAdjRight.TabIndex = 43
        Me.lblAdjRight.Text = "0"
        Me.lblAdjRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(99, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "%"
        '
        'lblAdjLeft
        '
        Me.lblAdjLeft.AutoSize = True
        Me.lblAdjLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjLeft.ForeColor = System.Drawing.Color.Red
        Me.lblAdjLeft.Location = New System.Drawing.Point(11, 87)
        Me.lblAdjLeft.MinimumSize = New System.Drawing.Size(40, 12)
        Me.lblAdjLeft.Name = "lblAdjLeft"
        Me.lblAdjLeft.Size = New System.Drawing.Size(40, 15)
        Me.lblAdjLeft.TabIndex = 42
        Me.lblAdjLeft.Text = "0"
        Me.lblAdjLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdjUp
        '
        Me.lblAdjUp.AutoSize = True
        Me.lblAdjUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjUp.ForeColor = System.Drawing.Color.Red
        Me.lblAdjUp.Location = New System.Drawing.Point(46, 66)
        Me.lblAdjUp.MinimumSize = New System.Drawing.Size(40, 12)
        Me.lblAdjUp.Name = "lblAdjUp"
        Me.lblAdjUp.Size = New System.Drawing.Size(40, 15)
        Me.lblAdjUp.TabIndex = 41
        Me.lblAdjUp.Text = "0"
        Me.lblAdjUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(117, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(119, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Inc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Recoil H"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Recoil V"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(175, 16)
        Me.ToolStripProgressBar1.Step = 25
        '
        'mainToolStripStatus
        '
        Me.mainToolStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mainToolStripStatus.ForeColor = System.Drawing.Color.Silver
        Me.mainToolStripStatus.Name = "mainToolStripStatus"
        Me.mainToolStripStatus.Size = New System.Drawing.Size(429, 17)
        Me.mainToolStripStatus.Spring = True
        Me.mainToolStripStatus.Text = "version()"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.ToolStripStatusLabel2.LinkColor = System.Drawing.Color.DodgerBlue
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel2.Tag = ""
        Me.ToolStripStatusLabel2.Text = "http://symthic.com"
        Me.ToolStripStatusLabel2.ToolTipText = "http://symthic.com"
        '
        'txtScale
        '
        Me.txtScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtScale.ForeColor = System.Drawing.Color.White
        Me.txtScale.Location = New System.Drawing.Point(78, 122)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(30, 20)
        Me.txtScale.TabIndex = 59
        Me.txtScale.Text = "650"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(4, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Scale px/deg"
        '
        'chkTitles
        '
        Me.chkTitles.AutoSize = True
        Me.chkTitles.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkTitles.Checked = True
        Me.chkTitles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTitles.ForeColor = System.Drawing.Color.White
        Me.chkTitles.Location = New System.Drawing.Point(6, 58)
        Me.chkTitles.Name = "chkTitles"
        Me.chkTitles.Size = New System.Drawing.Size(51, 17)
        Me.chkTitles.TabIndex = 57
        Me.chkTitles.Text = "Titles"
        Me.chkTitles.UseVisualStyleBackColor = False
        '
        'numMeters
        '
        Me.numMeters.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numMeters.ForeColor = System.Drawing.Color.White
        Me.numMeters.Location = New System.Drawing.Point(87, 145)
        Me.numMeters.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.numMeters.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMeters.Name = "numMeters"
        Me.numMeters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMeters.Size = New System.Drawing.Size(56, 20)
        Me.numMeters.TabIndex = 53
        Me.numMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMeters.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(143, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "m"
        '
        'radDegrees
        '
        Me.radDegrees.AutoSize = True
        Me.radDegrees.Checked = True
        Me.radDegrees.ForeColor = System.Drawing.Color.White
        Me.radDegrees.Location = New System.Drawing.Point(149, 105)
        Me.radDegrees.Name = "radDegrees"
        Me.radDegrees.Size = New System.Drawing.Size(65, 17)
        Me.radDegrees.TabIndex = 51
        Me.radDegrees.TabStop = True
        Me.radDegrees.Text = "Degrees"
        Me.radDegrees.UseVisualStyleBackColor = True
        '
        'radMeters
        '
        Me.radMeters.AutoSize = True
        Me.radMeters.ForeColor = System.Drawing.Color.White
        Me.radMeters.Location = New System.Drawing.Point(149, 90)
        Me.radMeters.Name = "radMeters"
        Me.radMeters.Size = New System.Drawing.Size(57, 17)
        Me.radMeters.TabIndex = 50
        Me.radMeters.Text = "Meters"
        Me.radMeters.UseVisualStyleBackColor = True
        '
        'numLineSpace
        '
        Me.numLineSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numLineSpace.DecimalPlaces = 2
        Me.numLineSpace.ForeColor = System.Drawing.Color.White
        Me.numLineSpace.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.numLineSpace.Location = New System.Drawing.Point(97, 97)
        Me.numLineSpace.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numLineSpace.Name = "numLineSpace"
        Me.numLineSpace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numLineSpace.Size = New System.Drawing.Size(48, 20)
        Me.numLineSpace.TabIndex = 49
        Me.numLineSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numLineSpace.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkBars
        '
        Me.chkBars.AutoSize = True
        Me.chkBars.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkBars.Checked = True
        Me.chkBars.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBars.ForeColor = System.Drawing.Color.White
        Me.chkBars.Location = New System.Drawing.Point(6, 24)
        Me.chkBars.Name = "chkBars"
        Me.chkBars.Size = New System.Drawing.Size(47, 17)
        Me.chkBars.TabIndex = 43
        Me.chkBars.Text = "Bars"
        Me.chkBars.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.mainToolStripStatus, Me.ToolStripStatusLabel2, Me.viewToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(810, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 41
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'viewToolStrip
        '
        Me.viewToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.viewToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMainToolStripMenuItem, Me.ViewHeatMapToolStripMenuItem, Me.ViewMaskToolStripMenuItem, Me.ViewTTKToolStripMenuItem})
        Me.viewToolStrip.Image = CType(resources.GetObject("viewToolStrip.Image"), System.Drawing.Image)
        Me.viewToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.viewToolStrip.Name = "viewToolStrip"
        Me.viewToolStrip.Size = New System.Drawing.Size(78, 20)
        Me.viewToolStrip.Text = "View: Main"
        '
        'ViewMainToolStripMenuItem
        '
        Me.ViewMainToolStripMenuItem.Checked = True
        Me.ViewMainToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewMainToolStripMenuItem.Name = "ViewMainToolStripMenuItem"
        Me.ViewMainToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewMainToolStripMenuItem.Text = "View: &Main"
        '
        'ViewHeatMapToolStripMenuItem
        '
        Me.ViewHeatMapToolStripMenuItem.Enabled = False
        Me.ViewHeatMapToolStripMenuItem.Name = "ViewHeatMapToolStripMenuItem"
        Me.ViewHeatMapToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewHeatMapToolStripMenuItem.Text = "View: &Heat Map"
        '
        'ViewMaskToolStripMenuItem
        '
        Me.ViewMaskToolStripMenuItem.Enabled = False
        Me.ViewMaskToolStripMenuItem.Name = "ViewMaskToolStripMenuItem"
        Me.ViewMaskToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewMaskToolStripMenuItem.Text = "View: Ma&sk"
        '
        'ViewTTKToolStripMenuItem
        '
        Me.ViewTTKToolStripMenuItem.Enabled = False
        Me.ViewTTKToolStripMenuItem.Name = "ViewTTKToolStripMenuItem"
        Me.ViewTTKToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewTTKToolStripMenuItem.Text = "View: TTK"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'tabMain
        '
        Me.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMain.Controls.Add(Me.tabRender)
        Me.tabMain.Controls.Add(Me.tabSaveOptions)
        Me.tabMain.Controls.Add(Me.tabHeatMap)
        Me.tabMain.Controls.Add(Me.tabAdvanced)
        Me.tabMain.Controls.Add(Me.tabCustom)
        Me.tabMain.Location = New System.Drawing.Point(16, 200)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(370, 214)
        Me.tabMain.TabIndex = 42
        '
        'tabRender
        '
        Me.tabRender.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabRender.Controls.Add(Me.comboSilhouetteStyle)
        Me.tabRender.Controls.Add(Me.Label48)
        Me.tabRender.Controls.Add(Me.CheckBox1)
        Me.tabRender.Controls.Add(Me.txtSub)
        Me.tabRender.Controls.Add(Me.Label24)
        Me.tabRender.Controls.Add(Me.txtInfo)
        Me.tabRender.Controls.Add(Me.Label1)
        Me.tabRender.Controls.Add(Me.txtTitle)
        Me.tabRender.Controls.Add(Me.Label3)
        Me.tabRender.Controls.Add(Me.chkTimeToKill)
        Me.tabRender.Controls.Add(Me.chkDrawTTK)
        Me.tabRender.Controls.Add(Me.numLineSpace)
        Me.tabRender.Controls.Add(Me.chkScaleRadius)
        Me.tabRender.Controls.Add(Me.chkDrawGrid)
        Me.tabRender.Controls.Add(Me.chkBars)
        Me.tabRender.Controls.Add(Me.txtScale)
        Me.tabRender.Controls.Add(Me.Label15)
        Me.tabRender.Controls.Add(Me.chkTitles)
        Me.tabRender.Controls.Add(Me.chkPrintAdj)
        Me.tabRender.Controls.Add(Me.numMeters)
        Me.tabRender.Controls.Add(Me.Label14)
        Me.tabRender.Controls.Add(Me.radMeters)
        Me.tabRender.Controls.Add(Me.radDegrees)
        Me.tabRender.Controls.Add(Me.Label16)
        Me.tabRender.Location = New System.Drawing.Point(4, 25)
        Me.tabRender.Name = "tabRender"
        Me.tabRender.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRender.Size = New System.Drawing.Size(362, 185)
        Me.tabRender.TabIndex = 0
        Me.tabRender.Text = "Render Options"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(119, 41)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 96
        Me.CheckBox1.Text = "Ammo Info"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtSub
        '
        Me.txtSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSub.ForeColor = System.Drawing.Color.White
        Me.txtSub.Location = New System.Drawing.Point(269, 161)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(86, 20)
        Me.txtSub.TabIndex = 94
        Me.txtSub.Text = "<<ATTACH>>"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(231, 165)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Sub"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.ForeColor = System.Drawing.Color.White
        Me.txtInfo.Location = New System.Drawing.Point(269, 132)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(86, 20)
        Me.txtInfo.TabIndex = 91
        Me.txtInfo.Text = "<<STANCE>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(230, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(269, 104)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(87, 20)
        Me.txtTitle.TabIndex = 90
        Me.txtTitle.Text = "<<GUN>>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(232, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Info"
        '
        'chkTimeToKill
        '
        Me.chkTimeToKill.AutoSize = True
        Me.chkTimeToKill.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkTimeToKill.ForeColor = System.Drawing.Color.White
        Me.chkTimeToKill.Location = New System.Drawing.Point(119, 8)
        Me.chkTimeToKill.Name = "chkTimeToKill"
        Me.chkTimeToKill.Size = New System.Drawing.Size(109, 17)
        Me.chkTimeToKill.TabIndex = 88
        Me.chkTimeToKill.Text = "Draw scale target"
        Me.chkTimeToKill.UseVisualStyleBackColor = False
        '
        'chkDrawTTK
        '
        Me.chkDrawTTK.AutoSize = True
        Me.chkDrawTTK.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkDrawTTK.ForeColor = System.Drawing.Color.White
        Me.chkDrawTTK.Location = New System.Drawing.Point(119, 25)
        Me.chkDrawTTK.Name = "chkDrawTTK"
        Me.chkDrawTTK.Size = New System.Drawing.Size(91, 17)
        Me.chkDrawTTK.TabIndex = 89
        Me.chkDrawTTK.Text = "Write hit rates"
        Me.chkDrawTTK.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Target Distance"
        '
        'tabSaveOptions
        '
        Me.tabSaveOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabSaveOptions.Controls.Add(Me.chkSaveTTKChart)
        Me.tabSaveOptions.Controls.Add(Me.chkSaveHeatMap)
        Me.tabSaveOptions.Controls.Add(Me.Label32)
        Me.tabSaveOptions.Controls.Add(Me.Label31)
        Me.tabSaveOptions.Controls.Add(Me.Label29)
        Me.tabSaveOptions.Controls.Add(Me.Label30)
        Me.tabSaveOptions.Controls.Add(Me.lblPath)
        Me.tabSaveOptions.Controls.Add(Me.txtFilename)
        Me.tabSaveOptions.Controls.Add(Me.chkSaveImage)
        Me.tabSaveOptions.Controls.Add(Me.btnSaveImage)
        Me.tabSaveOptions.Location = New System.Drawing.Point(4, 25)
        Me.tabSaveOptions.Name = "tabSaveOptions"
        Me.tabSaveOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSaveOptions.Size = New System.Drawing.Size(362, 185)
        Me.tabSaveOptions.TabIndex = 2
        Me.tabSaveOptions.Text = "Save"
        '
        'chkSaveTTKChart
        '
        Me.chkSaveTTKChart.AutoSize = True
        Me.chkSaveTTKChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkSaveTTKChart.ForeColor = System.Drawing.Color.White
        Me.chkSaveTTKChart.Location = New System.Drawing.Point(256, 117)
        Me.chkSaveTTKChart.Name = "chkSaveTTKChart"
        Me.chkSaveTTKChart.Size = New System.Drawing.Size(103, 17)
        Me.chkSaveTTKChart.TabIndex = 52
        Me.chkSaveTTKChart.Text = "Save TTK Chart"
        Me.chkSaveTTKChart.UseVisualStyleBackColor = False
        '
        'chkSaveHeatMap
        '
        Me.chkSaveHeatMap.AutoSize = True
        Me.chkSaveHeatMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkSaveHeatMap.ForeColor = System.Drawing.Color.White
        Me.chkSaveHeatMap.Location = New System.Drawing.Point(256, 94)
        Me.chkSaveHeatMap.Name = "chkSaveHeatMap"
        Me.chkSaveHeatMap.Size = New System.Drawing.Size(101, 17)
        Me.chkSaveHeatMap.TabIndex = 51
        Me.chkSaveHeatMap.Text = "Save Heat Map"
        Me.chkSaveHeatMap.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(28, 107)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 13)
        Me.Label32.TabIndex = 50
        Me.Label32.Text = "Sub = <<Sub>>"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(28, 94)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 13)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "Info = <<Info>>"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(27, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Title = <<Title>>"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(10, 62)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 13)
        Me.Label30.TabIndex = 47
        Me.Label30.Text = "Filename:"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPath.ForeColor = System.Drawing.Color.White
        Me.lblPath.Location = New System.Drawing.Point(12, 38)
        Me.lblPath.MinimumSize = New System.Drawing.Size(340, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(340, 13)
        Me.lblPath.TabIndex = 46
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFilename
        '
        Me.txtFilename.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilename.ForeColor = System.Drawing.Color.White
        Me.txtFilename.Location = New System.Drawing.Point(63, 58)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(283, 20)
        Me.txtFilename.TabIndex = 45
        Me.txtFilename.Text = "<<Title>>_<<Info>>_<<Sub>>"
        '
        'chkSaveImage
        '
        Me.chkSaveImage.AutoSize = True
        Me.chkSaveImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkSaveImage.ForeColor = System.Drawing.Color.White
        Me.chkSaveImage.Location = New System.Drawing.Point(15, 16)
        Me.chkSaveImage.Name = "chkSaveImage"
        Me.chkSaveImage.Size = New System.Drawing.Size(94, 17)
        Me.chkSaveImage.TabIndex = 42
        Me.chkSaveImage.Text = "Save image to"
        Me.chkSaveImage.UseVisualStyleBackColor = False
        '
        'btnSaveImage
        '
        Me.btnSaveImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveImage.ForeColor = System.Drawing.Color.LightGray
        Me.btnSaveImage.Location = New System.Drawing.Point(110, 13)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(29, 21)
        Me.btnSaveImage.TabIndex = 43
        Me.btnSaveImage.Text = "..."
        Me.btnSaveImage.UseVisualStyleBackColor = False
        '
        'tabHeatMap
        '
        Me.tabHeatMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabHeatMap.Controls.Add(Me.chkRenderHeatBars)
        Me.tabHeatMap.Controls.Add(Me.chkRenderHeatTitle)
        Me.tabHeatMap.Controls.Add(Me.chkRenderHeatAdjust)
        Me.tabHeatMap.Controls.Add(Me.numIntensityScale)
        Me.tabHeatMap.Controls.Add(Me.numHeatRadius)
        Me.tabHeatMap.Controls.Add(Me.chkHeatMap)
        Me.tabHeatMap.Controls.Add(Me.Label13)
        Me.tabHeatMap.ForeColor = System.Drawing.Color.White
        Me.tabHeatMap.Location = New System.Drawing.Point(4, 25)
        Me.tabHeatMap.Name = "tabHeatMap"
        Me.tabHeatMap.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHeatMap.Size = New System.Drawing.Size(362, 185)
        Me.tabHeatMap.TabIndex = 3
        Me.tabHeatMap.Text = "Heat Map"
        '
        'chkRenderHeatBars
        '
        Me.chkRenderHeatBars.AutoSize = True
        Me.chkRenderHeatBars.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkRenderHeatBars.Enabled = False
        Me.chkRenderHeatBars.ForeColor = System.Drawing.Color.White
        Me.chkRenderHeatBars.Location = New System.Drawing.Point(271, 42)
        Me.chkRenderHeatBars.Name = "chkRenderHeatBars"
        Me.chkRenderHeatBars.Size = New System.Drawing.Size(47, 17)
        Me.chkRenderHeatBars.TabIndex = 72
        Me.chkRenderHeatBars.Text = "Bars"
        Me.chkRenderHeatBars.UseVisualStyleBackColor = False
        '
        'chkRenderHeatTitle
        '
        Me.chkRenderHeatTitle.AutoSize = True
        Me.chkRenderHeatTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkRenderHeatTitle.Enabled = False
        Me.chkRenderHeatTitle.ForeColor = System.Drawing.Color.White
        Me.chkRenderHeatTitle.Location = New System.Drawing.Point(271, 25)
        Me.chkRenderHeatTitle.Name = "chkRenderHeatTitle"
        Me.chkRenderHeatTitle.Size = New System.Drawing.Size(51, 17)
        Me.chkRenderHeatTitle.TabIndex = 73
        Me.chkRenderHeatTitle.Text = "Titles"
        Me.chkRenderHeatTitle.UseVisualStyleBackColor = False
        '
        'chkRenderHeatAdjust
        '
        Me.chkRenderHeatAdjust.AutoSize = True
        Me.chkRenderHeatAdjust.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkRenderHeatAdjust.Enabled = False
        Me.chkRenderHeatAdjust.ForeColor = System.Drawing.Color.White
        Me.chkRenderHeatAdjust.Location = New System.Drawing.Point(271, 8)
        Me.chkRenderHeatAdjust.Name = "chkRenderHeatAdjust"
        Me.chkRenderHeatAdjust.Size = New System.Drawing.Size(83, 17)
        Me.chkRenderHeatAdjust.TabIndex = 71
        Me.chkRenderHeatAdjust.Text = "Adjustments"
        Me.chkRenderHeatAdjust.UseVisualStyleBackColor = False
        '
        'numIntensityScale
        '
        Me.numIntensityScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numIntensityScale.DecimalPlaces = 2
        Me.numIntensityScale.ForeColor = System.Drawing.Color.White
        Me.numIntensityScale.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.numIntensityScale.Location = New System.Drawing.Point(108, 29)
        Me.numIntensityScale.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numIntensityScale.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numIntensityScale.Name = "numIntensityScale"
        Me.numIntensityScale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numIntensityScale.Size = New System.Drawing.Size(48, 20)
        Me.numIntensityScale.TabIndex = 69
        Me.numIntensityScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numIntensityScale.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'numHeatRadius
        '
        Me.numHeatRadius.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numHeatRadius.ForeColor = System.Drawing.Color.White
        Me.numHeatRadius.Location = New System.Drawing.Point(107, 5)
        Me.numHeatRadius.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numHeatRadius.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHeatRadius.Name = "numHeatRadius"
        Me.numHeatRadius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numHeatRadius.Size = New System.Drawing.Size(48, 20)
        Me.numHeatRadius.TabIndex = 68
        Me.numHeatRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numHeatRadius.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'chkHeatMap
        '
        Me.chkHeatMap.AutoSize = True
        Me.chkHeatMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkHeatMap.ForeColor = System.Drawing.Color.White
        Me.chkHeatMap.Location = New System.Drawing.Point(8, 8)
        Me.chkHeatMap.Name = "chkHeatMap"
        Me.chkHeatMap.Size = New System.Drawing.Size(104, 17)
        Me.chkHeatMap.TabIndex = 67
        Me.chkHeatMap.Text = "Heat Map radius"
        Me.chkHeatMap.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(34, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Intensity Scale"
        '
        'tabAdvanced
        '
        Me.tabAdvanced.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabAdvanced.Controls.Add(Me.TabControl1)
        Me.tabAdvanced.ForeColor = System.Drawing.Color.White
        Me.tabAdvanced.Location = New System.Drawing.Point(4, 25)
        Me.tabAdvanced.Name = "tabAdvanced"
        Me.tabAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdvanced.Size = New System.Drawing.Size(362, 185)
        Me.tabAdvanced.TabIndex = 5
        Me.tabAdvanced.Text = "Advanced"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tabAdvBulletDrop)
        Me.TabControl1.Controls.Add(Me.tabAdvTTK)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(362, 185)
        Me.TabControl1.TabIndex = 0
        '
        'tabAdvBulletDrop
        '
        Me.tabAdvBulletDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabAdvBulletDrop.Controls.Add(Me.Label20)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label19)
        Me.tabAdvBulletDrop.Controls.Add(Me.numMaxDistance)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label17)
        Me.tabAdvBulletDrop.Controls.Add(Me.numBulletDrop)
        Me.tabAdvBulletDrop.Controls.Add(Me.numDropLineThickness)
        Me.tabAdvBulletDrop.Controls.Add(Me.chkRenderBulletDrop)
        Me.tabAdvBulletDrop.Controls.Add(Me.chkWriteDropInfo)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label39)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label51)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label52)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label53)
        Me.tabAdvBulletDrop.Controls.Add(Me.numDropVerticalScale)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label54)
        Me.tabAdvBulletDrop.Controls.Add(Me.numDropHorizontalScale)
        Me.tabAdvBulletDrop.Controls.Add(Me.chkDrawDropGrid)
        Me.tabAdvBulletDrop.Controls.Add(Me.Label18)
        Me.tabAdvBulletDrop.ForeColor = System.Drawing.Color.White
        Me.tabAdvBulletDrop.Location = New System.Drawing.Point(4, 25)
        Me.tabAdvBulletDrop.Name = "tabAdvBulletDrop"
        Me.tabAdvBulletDrop.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdvBulletDrop.Size = New System.Drawing.Size(354, 156)
        Me.tabAdvBulletDrop.TabIndex = 0
        Me.tabAdvBulletDrop.Text = "Bullet Drop"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label20.ForeColor = System.Drawing.Color.LightGreen
        Me.Label20.Location = New System.Drawing.Point(332, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "m"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label19.ForeColor = System.Drawing.Color.LightGreen
        Me.Label19.Location = New System.Drawing.Point(231, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 151
        Me.Label19.Text = "Max Dist."
        '
        'numMaxDistance
        '
        Me.numMaxDistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numMaxDistance.ForeColor = System.Drawing.Color.LightGreen
        Me.numMaxDistance.Location = New System.Drawing.Point(283, 26)
        Me.numMaxDistance.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numMaxDistance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaxDistance.Name = "numMaxDistance"
        Me.numMaxDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMaxDistance.Size = New System.Drawing.Size(48, 20)
        Me.numMaxDistance.TabIndex = 150
        Me.numMaxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMaxDistance.Value = New Decimal(New Integer() {945, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label17.ForeColor = System.Drawing.Color.LightGreen
        Me.Label17.Location = New System.Drawing.Point(331, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "m/s"
        '
        'numBulletDrop
        '
        Me.numBulletDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numBulletDrop.DecimalPlaces = 2
        Me.numBulletDrop.ForeColor = System.Drawing.Color.LightGreen
        Me.numBulletDrop.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.numBulletDrop.Location = New System.Drawing.Point(283, 3)
        Me.numBulletDrop.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numBulletDrop.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBulletDrop.Name = "numBulletDrop"
        Me.numBulletDrop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numBulletDrop.Size = New System.Drawing.Size(48, 20)
        Me.numBulletDrop.TabIndex = 148
        Me.numBulletDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numBulletDrop.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'numDropLineThickness
        '
        Me.numDropLineThickness.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDropLineThickness.ForeColor = System.Drawing.Color.White
        Me.numDropLineThickness.Location = New System.Drawing.Point(98, 18)
        Me.numDropLineThickness.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numDropLineThickness.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDropLineThickness.Name = "numDropLineThickness"
        Me.numDropLineThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDropLineThickness.Size = New System.Drawing.Size(36, 20)
        Me.numDropLineThickness.TabIndex = 145
        Me.numDropLineThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDropLineThickness.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkRenderBulletDrop
        '
        Me.chkRenderBulletDrop.AutoSize = True
        Me.chkRenderBulletDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkRenderBulletDrop.ForeColor = System.Drawing.Color.White
        Me.chkRenderBulletDrop.Location = New System.Drawing.Point(1, 20)
        Me.chkRenderBulletDrop.Name = "chkRenderBulletDrop"
        Me.chkRenderBulletDrop.Size = New System.Drawing.Size(101, 17)
        Me.chkRenderBulletDrop.TabIndex = 144
        Me.chkRenderBulletDrop.Text = "Bullet Drop Line"
        Me.chkRenderBulletDrop.UseVisualStyleBackColor = False
        '
        'chkWriteDropInfo
        '
        Me.chkWriteDropInfo.AutoSize = True
        Me.chkWriteDropInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkWriteDropInfo.ForeColor = System.Drawing.Color.White
        Me.chkWriteDropInfo.Location = New System.Drawing.Point(1, 3)
        Me.chkWriteDropInfo.Name = "chkWriteDropInfo"
        Me.chkWriteDropInfo.Size = New System.Drawing.Size(98, 17)
        Me.chkWriteDropInfo.TabIndex = 143
        Me.chkWriteDropInfo.Text = "Write Drop Info"
        Me.chkWriteDropInfo.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(132, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(18, 13)
        Me.Label39.TabIndex = 146
        Me.Label39.Text = "px"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label51.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label51.Location = New System.Drawing.Point(3, 91)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(15, 13)
        Me.Label51.TabIndex = 142
        Me.Label51.Text = "H"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label52.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label52.Location = New System.Drawing.Point(79, 91)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(14, 13)
        Me.Label52.TabIndex = 141
        Me.Label52.Text = "V"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label53.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label53.Location = New System.Drawing.Point(139, 92)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(15, 13)
        Me.Label53.TabIndex = 140
        Me.Label53.Text = "m"
        '
        'numDropVerticalScale
        '
        Me.numDropVerticalScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDropVerticalScale.DecimalPlaces = 2
        Me.numDropVerticalScale.ForeColor = System.Drawing.Color.White
        Me.numDropVerticalScale.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numDropVerticalScale.Location = New System.Drawing.Point(93, 88)
        Me.numDropVerticalScale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numDropVerticalScale.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numDropVerticalScale.Name = "numDropVerticalScale"
        Me.numDropVerticalScale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDropVerticalScale.Size = New System.Drawing.Size(43, 20)
        Me.numDropVerticalScale.TabIndex = 139
        Me.numDropVerticalScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDropVerticalScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label54.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label54.Location = New System.Drawing.Point(64, 92)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(15, 13)
        Me.Label54.TabIndex = 137
        Me.Label54.Text = "m"
        '
        'numDropHorizontalScale
        '
        Me.numDropHorizontalScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDropHorizontalScale.ForeColor = System.Drawing.Color.White
        Me.numDropHorizontalScale.Location = New System.Drawing.Point(18, 88)
        Me.numDropHorizontalScale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numDropHorizontalScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDropHorizontalScale.Name = "numDropHorizontalScale"
        Me.numDropHorizontalScale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDropHorizontalScale.Size = New System.Drawing.Size(43, 20)
        Me.numDropHorizontalScale.TabIndex = 136
        Me.numDropHorizontalScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDropHorizontalScale.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'chkDrawDropGrid
        '
        Me.chkDrawDropGrid.AutoSize = True
        Me.chkDrawDropGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkDrawDropGrid.Checked = True
        Me.chkDrawDropGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawDropGrid.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkDrawDropGrid.Location = New System.Drawing.Point(35, 65)
        Me.chkDrawDropGrid.Name = "chkDrawDropGrid"
        Me.chkDrawDropGrid.Size = New System.Drawing.Size(93, 17)
        Me.chkDrawDropGrid.TabIndex = 138
        Me.chkDrawDropGrid.Text = "Grid line every"
        Me.chkDrawDropGrid.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label18.ForeColor = System.Drawing.Color.LightGreen
        Me.Label18.Location = New System.Drawing.Point(220, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 149
        Me.Label18.Text = "Bullet Drop -"
        '
        'tabAdvTTK
        '
        Me.tabAdvTTK.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabAdvTTK.Controls.Add(Me.grpCustomTTK)
        Me.tabAdvTTK.Controls.Add(Me.Label46)
        Me.tabAdvTTK.Controls.Add(Me.Label45)
        Me.tabAdvTTK.Controls.Add(Me.numDamagePercent)
        Me.tabAdvTTK.Controls.Add(Me.Label44)
        Me.tabAdvTTK.Controls.Add(Me.Label43)
        Me.tabAdvTTK.Controls.Add(Me.numHealthPercent)
        Me.tabAdvTTK.Controls.Add(Me.Label42)
        Me.tabAdvTTK.Controls.Add(Me.numDamageSplitter)
        Me.tabAdvTTK.Controls.Add(Me.Label41)
        Me.tabAdvTTK.Controls.Add(Me.Label40)
        Me.tabAdvTTK.Controls.Add(Me.Label38)
        Me.tabAdvTTK.Controls.Add(Me.Label37)
        Me.tabAdvTTK.Controls.Add(Me.numMinRange)
        Me.tabAdvTTK.Controls.Add(Me.numMaxRange)
        Me.tabAdvTTK.Controls.Add(Me.Label35)
        Me.tabAdvTTK.Controls.Add(Me.numTTKGridSpacing)
        Me.tabAdvTTK.Controls.Add(Me.chkDrawTTKGrid)
        Me.tabAdvTTK.Controls.Add(Me.numTTKRange)
        Me.tabAdvTTK.Controls.Add(Me.numDamageMin)
        Me.tabAdvTTK.Controls.Add(Me.numDamageMax)
        Me.tabAdvTTK.Controls.Add(Me.Label23)
        Me.tabAdvTTK.Controls.Add(Me.Label22)
        Me.tabAdvTTK.Controls.Add(Me.Label21)
        Me.tabAdvTTK.Controls.Add(Me.Label34)
        Me.tabAdvTTK.Controls.Add(Me.Label36)
        Me.tabAdvTTK.Location = New System.Drawing.Point(4, 25)
        Me.tabAdvTTK.Name = "tabAdvTTK"
        Me.tabAdvTTK.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdvTTK.Size = New System.Drawing.Size(354, 156)
        Me.tabAdvTTK.TabIndex = 1
        Me.tabAdvTTK.Text = "Time to Kill"
        '
        'grpCustomTTK
        '
        Me.grpCustomTTK.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpCustomTTK.Controls.Add(Me.Label25)
        Me.grpCustomTTK.Controls.Add(Me.numBulletVelocity)
        Me.grpCustomTTK.Controls.Add(Me.Label26)
        Me.grpCustomTTK.Controls.Add(Me.numRateOfFire)
        Me.grpCustomTTK.Controls.Add(Me.Label28)
        Me.grpCustomTTK.Controls.Add(Me.Label27)
        Me.grpCustomTTK.ForeColor = System.Drawing.Color.White
        Me.grpCustomTTK.Location = New System.Drawing.Point(179, 76)
        Me.grpCustomTTK.Name = "grpCustomTTK"
        Me.grpCustomTTK.Size = New System.Drawing.Size(168, 74)
        Me.grpCustomTTK.TabIndex = 141
        Me.grpCustomTTK.TabStop = False
        Me.grpCustomTTK.Text = "Custom"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label25.ForeColor = System.Drawing.Color.LightGreen
        Me.Label25.Location = New System.Drawing.Point(11, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 117
        Me.Label25.Text = "Bullet Speed"
        '
        'numBulletVelocity
        '
        Me.numBulletVelocity.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numBulletVelocity.ForeColor = System.Drawing.Color.LightGreen
        Me.numBulletVelocity.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numBulletVelocity.Location = New System.Drawing.Point(78, 48)
        Me.numBulletVelocity.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.numBulletVelocity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBulletVelocity.Name = "numBulletVelocity"
        Me.numBulletVelocity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numBulletVelocity.Size = New System.Drawing.Size(48, 20)
        Me.numBulletVelocity.TabIndex = 116
        Me.numBulletVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numBulletVelocity.Value = New Decimal(New Integer() {630, 0, 0, 0})
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label26.ForeColor = System.Drawing.Color.LightGreen
        Me.Label26.Location = New System.Drawing.Point(126, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 115
        Me.Label26.Text = "m/s"
        '
        'numRateOfFire
        '
        Me.numRateOfFire.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numRateOfFire.ForeColor = System.Drawing.Color.Lime
        Me.numRateOfFire.Location = New System.Drawing.Point(78, 18)
        Me.numRateOfFire.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.numRateOfFire.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRateOfFire.Name = "numRateOfFire"
        Me.numRateOfFire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numRateOfFire.Size = New System.Drawing.Size(48, 20)
        Me.numRateOfFire.TabIndex = 118
        Me.numRateOfFire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numRateOfFire.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label28.ForeColor = System.Drawing.Color.Lime
        Me.Label28.Location = New System.Drawing.Point(49, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 13)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "ROF"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label27.ForeColor = System.Drawing.Color.Lime
        Me.Label27.Location = New System.Drawing.Point(128, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 13)
        Me.Label27.TabIndex = 120
        Me.Label27.Text = "rpm"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label46.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label46.Location = New System.Drawing.Point(198, 54)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(15, 13)
        Me.Label46.TabIndex = 140
        Me.Label46.Text = "H"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label45.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label45.Location = New System.Drawing.Point(274, 54)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(14, 13)
        Me.Label45.TabIndex = 139
        Me.Label45.Text = "V"
        '
        'numDamagePercent
        '
        Me.numDamagePercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDamagePercent.Enabled = False
        Me.numDamagePercent.ForeColor = System.Drawing.Color.Red
        Me.numDamagePercent.Location = New System.Drawing.Point(86, 117)
        Me.numDamagePercent.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numDamagePercent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDamagePercent.Name = "numDamagePercent"
        Me.numDamagePercent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDamagePercent.Size = New System.Drawing.Size(48, 20)
        Me.numDamagePercent.TabIndex = 138
        Me.numDamagePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDamagePercent.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(34, 97)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(49, 13)
        Me.Label44.TabIndex = 137
        Me.Label44.Text = "Health %"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(25, 120)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(58, 13)
        Me.Label43.TabIndex = 136
        Me.Label43.Text = "Damage %"
        '
        'numHealthPercent
        '
        Me.numHealthPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numHealthPercent.Enabled = False
        Me.numHealthPercent.ForeColor = System.Drawing.Color.Red
        Me.numHealthPercent.Location = New System.Drawing.Point(86, 94)
        Me.numHealthPercent.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numHealthPercent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHealthPercent.Name = "numHealthPercent"
        Me.numHealthPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numHealthPercent.Size = New System.Drawing.Size(48, 20)
        Me.numHealthPercent.TabIndex = 135
        Me.numHealthPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numHealthPercent.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label42.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label42.Location = New System.Drawing.Point(334, 55)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(21, 13)
        Me.Label42.TabIndex = 134
        Me.Label42.Text = "pts"
        '
        'numDamageSplitter
        '
        Me.numDamageSplitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDamageSplitter.DecimalPlaces = 2
        Me.numDamageSplitter.ForeColor = System.Drawing.Color.White
        Me.numDamageSplitter.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numDamageSplitter.Location = New System.Drawing.Point(288, 51)
        Me.numDamageSplitter.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numDamageSplitter.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numDamageSplitter.Name = "numDamageSplitter"
        Me.numDamageSplitter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDamageSplitter.Size = New System.Drawing.Size(43, 20)
        Me.numDamageSplitter.TabIndex = 133
        Me.numDamageSplitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDamageSplitter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label41.ForeColor = System.Drawing.Color.LightGreen
        Me.Label41.Location = New System.Drawing.Point(332, 6)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(15, 13)
        Me.Label41.TabIndex = 132
        Me.Label41.Text = "m"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label40.ForeColor = System.Drawing.Color.LightGreen
        Me.Label40.Location = New System.Drawing.Point(218, 5)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 13)
        Me.Label40.TabIndex = 131
        Me.Label40.Text = "Dmg Range"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label38.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label38.Location = New System.Drawing.Point(192, 29)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(15, 13)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "m"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label37.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label37.Location = New System.Drawing.Point(192, 6)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(15, 13)
        Me.Label37.TabIndex = 129
        Me.Label37.Text = "m"
        '
        'numMinRange
        '
        Me.numMinRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numMinRange.ForeColor = System.Drawing.Color.SkyBlue
        Me.numMinRange.Location = New System.Drawing.Point(143, 25)
        Me.numMinRange.Name = "numMinRange"
        Me.numMinRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMinRange.Size = New System.Drawing.Size(48, 20)
        Me.numMinRange.TabIndex = 128
        Me.numMinRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMinRange.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'numMaxRange
        '
        Me.numMaxRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numMaxRange.ForeColor = System.Drawing.Color.SkyBlue
        Me.numMaxRange.Location = New System.Drawing.Point(143, 2)
        Me.numMaxRange.Name = "numMaxRange"
        Me.numMaxRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMaxRange.Size = New System.Drawing.Size(48, 20)
        Me.numMaxRange.TabIndex = 127
        Me.numMaxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMaxRange.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label35.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label35.Location = New System.Drawing.Point(259, 55)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(15, 13)
        Me.Label35.TabIndex = 123
        Me.Label35.Text = "m"
        '
        'numTTKGridSpacing
        '
        Me.numTTKGridSpacing.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numTTKGridSpacing.ForeColor = System.Drawing.Color.White
        Me.numTTKGridSpacing.Location = New System.Drawing.Point(213, 51)
        Me.numTTKGridSpacing.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTTKGridSpacing.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTTKGridSpacing.Name = "numTTKGridSpacing"
        Me.numTTKGridSpacing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTTKGridSpacing.Size = New System.Drawing.Size(43, 20)
        Me.numTTKGridSpacing.TabIndex = 122
        Me.numTTKGridSpacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTTKGridSpacing.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkDrawTTKGrid
        '
        Me.chkDrawTTKGrid.AutoSize = True
        Me.chkDrawTTKGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkDrawTTKGrid.Checked = True
        Me.chkDrawTTKGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawTTKGrid.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkDrawTTKGrid.Location = New System.Drawing.Point(229, 28)
        Me.chkDrawTTKGrid.Name = "chkDrawTTKGrid"
        Me.chkDrawTTKGrid.Size = New System.Drawing.Size(93, 17)
        Me.chkDrawTTKGrid.TabIndex = 124
        Me.chkDrawTTKGrid.Text = "Grid line every"
        Me.chkDrawTTKGrid.UseVisualStyleBackColor = False
        '
        'numTTKRange
        '
        Me.numTTKRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numTTKRange.ForeColor = System.Drawing.Color.LightGreen
        Me.numTTKRange.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numTTKRange.Location = New System.Drawing.Point(283, 2)
        Me.numTTKRange.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.numTTKRange.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTTKRange.Name = "numTTKRange"
        Me.numTTKRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTTKRange.Size = New System.Drawing.Size(48, 20)
        Me.numTTKRange.TabIndex = 121
        Me.numTTKRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTTKRange.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'numDamageMin
        '
        Me.numDamageMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDamageMin.DecimalPlaces = 1
        Me.numDamageMin.ForeColor = System.Drawing.Color.SkyBlue
        Me.numDamageMin.Location = New System.Drawing.Point(75, 25)
        Me.numDamageMin.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numDamageMin.Name = "numDamageMin"
        Me.numDamageMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDamageMin.Size = New System.Drawing.Size(48, 20)
        Me.numDamageMin.TabIndex = 114
        Me.numDamageMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDamageMin.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'numDamageMax
        '
        Me.numDamageMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.numDamageMax.DecimalPlaces = 1
        Me.numDamageMax.ForeColor = System.Drawing.Color.SkyBlue
        Me.numDamageMax.Location = New System.Drawing.Point(75, 2)
        Me.numDamageMax.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numDamageMax.Name = "numDamageMax"
        Me.numDamageMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numDamageMax.Size = New System.Drawing.Size(48, 20)
        Me.numDamageMax.TabIndex = 113
        Me.numDamageMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDamageMax.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label23.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label23.Location = New System.Drawing.Point(51, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 13)
        Me.Label23.TabIndex = 112
        Me.Label23.Text = "Min"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label22.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label22.Location = New System.Drawing.Point(48, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Max"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label21.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label21.Location = New System.Drawing.Point(5, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "Damage"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label34.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label34.Location = New System.Drawing.Point(124, 5)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(18, 13)
        Me.Label34.TabIndex = 125
        Me.Label34.Text = "@"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label36.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label36.Location = New System.Drawing.Point(124, 28)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(18, 13)
        Me.Label36.TabIndex = 126
        Me.Label36.Text = "@"
        '
        'tabCustom
        '
        Me.tabCustom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabCustom.Controls.Add(Me.grpSpread)
        Me.tabCustom.Controls.Add(Me.grpRecoil)
        Me.tabCustom.Controls.Add(Me.grpAttach)
        Me.tabCustom.ForeColor = System.Drawing.Color.White
        Me.tabCustom.Location = New System.Drawing.Point(4, 25)
        Me.tabCustom.Name = "tabCustom"
        Me.tabCustom.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustom.Size = New System.Drawing.Size(362, 185)
        Me.tabCustom.TabIndex = 6
        Me.tabCustom.Text = "Custom"
        '
        'grpSpread
        '
        Me.grpSpread.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpSpread.Controls.Add(Me.Label47)
        Me.grpSpread.Controls.Add(Me.Label33)
        Me.grpSpread.Controls.Add(Me.NumericUpDown7)
        Me.grpSpread.Controls.Add(Me.NumericUpDown8)
        Me.grpSpread.Enabled = False
        Me.grpSpread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSpread.ForeColor = System.Drawing.Color.White
        Me.grpSpread.Location = New System.Drawing.Point(11, 109)
        Me.grpSpread.Name = "grpSpread"
        Me.grpSpread.Size = New System.Drawing.Size(124, 68)
        Me.grpSpread.TabIndex = 58
        Me.grpSpread.TabStop = False
        Me.grpSpread.Text = "Spread"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(17, 42)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(25, 13)
        Me.Label47.TabIndex = 48
        Me.Label47.Text = "Inc."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(16, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(27, 13)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Min."
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown7.DecimalPlaces = 2
        Me.NumericUpDown7.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown7.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown7.Location = New System.Drawing.Point(45, 39)
        Me.NumericUpDown7.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown7.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown7.TabIndex = 41
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown8.DecimalPlaces = 2
        Me.NumericUpDown8.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown8.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown8.Location = New System.Drawing.Point(45, 13)
        Me.NumericUpDown8.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown8.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown8.TabIndex = 43
        '
        'grpRecoil
        '
        Me.grpRecoil.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.grpRecoil.Controls.Add(Me.NumericUpDown3)
        Me.grpRecoil.Controls.Add(Me.NumericUpDown2)
        Me.grpRecoil.Controls.Add(Me.NumericUpDown1)
        Me.grpRecoil.Controls.Add(Me.NumericUpDown5)
        Me.grpRecoil.Controls.Add(Me.Label2)
        Me.grpRecoil.Enabled = False
        Me.grpRecoil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpRecoil.ForeColor = System.Drawing.Color.White
        Me.grpRecoil.Location = New System.Drawing.Point(11, 6)
        Me.grpRecoil.Name = "grpRecoil"
        Me.grpRecoil.Size = New System.Drawing.Size(124, 100)
        Me.grpRecoil.TabIndex = 57
        Me.grpRecoil.TabStop = False
        Me.grpRecoil.Text = "Recoil"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Location = New System.Drawing.Point(64, 70)
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown3.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown3.TabIndex = 45
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown2.Location = New System.Drawing.Point(70, 43)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown2.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown2.TabIndex = 44
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 43)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 41
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown5.DecimalPlaces = 2
        Me.NumericUpDown5.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown5.Location = New System.Drawing.Point(37, 16)
        Me.NumericUpDown5.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDown5.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown5.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "First Shot"
        '
        'contextImgRightClick
        '
        Me.contextImgRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.MaskToolStripMenuItem, Me.HeatMapToolStripMenuItem, Me.TTKToolStripMenuItem, Me.ToolStripSeparator1, Me.ZoomToolStripMenuItem})
        Me.contextImgRightClick.Name = "contextImgRightClick"
        Me.contextImgRightClick.Size = New System.Drawing.Size(127, 120)
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Checked = True
        Me.MainToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MainToolStripMenuItem.Text = "&Main"
        '
        'MaskToolStripMenuItem
        '
        Me.MaskToolStripMenuItem.Enabled = False
        Me.MaskToolStripMenuItem.Name = "MaskToolStripMenuItem"
        Me.MaskToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MaskToolStripMenuItem.Text = "Mas&k"
        '
        'HeatMapToolStripMenuItem
        '
        Me.HeatMapToolStripMenuItem.Enabled = False
        Me.HeatMapToolStripMenuItem.Name = "HeatMapToolStripMenuItem"
        Me.HeatMapToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.HeatMapToolStripMenuItem.Text = "&Heat Map"
        '
        'TTKToolStripMenuItem
        '
        Me.TTKToolStripMenuItem.Enabled = False
        Me.TTKToolStripMenuItem.Name = "TTKToolStripMenuItem"
        Me.TTKToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.TTKToolStripMenuItem.Text = "&TTK"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X500ToolStripMenuItem, Me.X1000ToolStripMenuItem, Me.X1000ToolStripMenuItem1})
        Me.ZoomToolStripMenuItem.Enabled = False
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ZoomToolStripMenuItem.Text = "&Zoom"
        '
        'X500ToolStripMenuItem
        '
        Me.X500ToolStripMenuItem.Name = "X500ToolStripMenuItem"
        Me.X500ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.X500ToolStripMenuItem.Text = "500 x 500 (25%)"
        '
        'X1000ToolStripMenuItem
        '
        Me.X1000ToolStripMenuItem.Name = "X1000ToolStripMenuItem"
        Me.X1000ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.X1000ToolStripMenuItem.Text = "800 x 800 (40%)"
        '
        'X1000ToolStripMenuItem1
        '
        Me.X1000ToolStripMenuItem1.Name = "X1000ToolStripMenuItem1"
        Me.X1000ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.X1000ToolStripMenuItem1.Text = "1000 x 1000 (50%)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radBarrelNone)
        Me.GroupBox1.Controls.Add(Me.radUnderLaser)
        Me.GroupBox1.Controls.Add(Me.radBarrelFlash)
        Me.GroupBox1.Controls.Add(Me.radBarrelSilencer)
        Me.GroupBox1.Controls.Add(Me.radBarrelHeavy)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Location = New System.Drawing.Point(17, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 94)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barrel Attachments"
        '
        'radBarrelNone
        '
        Me.radBarrelNone.AutoSize = True
        Me.radBarrelNone.Checked = True
        Me.radBarrelNone.Location = New System.Drawing.Point(7, 14)
        Me.radBarrelNone.Name = "radBarrelNone"
        Me.radBarrelNone.Size = New System.Drawing.Size(51, 17)
        Me.radBarrelNone.TabIndex = 7
        Me.radBarrelNone.TabStop = True
        Me.radBarrelNone.Text = "None"
        Me.radBarrelNone.UseVisualStyleBackColor = True
        '
        'radUnderLaser
        '
        Me.radUnderLaser.AutoSize = True
        Me.radUnderLaser.Location = New System.Drawing.Point(6, 68)
        Me.radUnderLaser.Name = "radUnderLaser"
        Me.radUnderLaser.Size = New System.Drawing.Size(78, 17)
        Me.radUnderLaser.TabIndex = 6
        Me.radUnderLaser.Text = "Laser Sight"
        Me.radUnderLaser.UseVisualStyleBackColor = True
        '
        'radBarrelFlash
        '
        Me.radBarrelFlash.AutoSize = True
        Me.radBarrelFlash.Location = New System.Drawing.Point(75, 42)
        Me.radBarrelFlash.Name = "radBarrelFlash"
        Me.radBarrelFlash.Size = New System.Drawing.Size(59, 17)
        Me.radBarrelFlash.TabIndex = 6
        Me.radBarrelFlash.Text = "F Supp"
        Me.radBarrelFlash.UseVisualStyleBackColor = True
        '
        'radBarrelSilencer
        '
        Me.radBarrelSilencer.AutoSize = True
        Me.radBarrelSilencer.Location = New System.Drawing.Point(75, 14)
        Me.radBarrelSilencer.Name = "radBarrelSilencer"
        Me.radBarrelSilencer.Size = New System.Drawing.Size(63, 17)
        Me.radBarrelSilencer.TabIndex = 5
        Me.radBarrelSilencer.Text = "Silencer"
        Me.radBarrelSilencer.UseVisualStyleBackColor = True
        '
        'radBarrelHeavy
        '
        Me.radBarrelHeavy.AutoSize = True
        Me.radBarrelHeavy.Location = New System.Drawing.Point(6, 42)
        Me.radBarrelHeavy.Name = "radBarrelHeavy"
        Me.radBarrelHeavy.Size = New System.Drawing.Size(63, 17)
        Me.radBarrelHeavy.TabIndex = 4
        Me.radBarrelHeavy.Text = "H Barrel"
        Me.radBarrelHeavy.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.radUnderNone)
        Me.GroupBox2.Controls.Add(Me.radUnderBipod)
        Me.GroupBox2.Controls.Add(Me.radUnderForegrip)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Location = New System.Drawing.Point(169, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(84, 94)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Under Barrel"
        '
        'radUnderNone
        '
        Me.radUnderNone.AccessibleDescription = " "
        Me.radUnderNone.AutoSize = True
        Me.radUnderNone.Checked = True
        Me.radUnderNone.Location = New System.Drawing.Point(9, 17)
        Me.radUnderNone.Name = "radUnderNone"
        Me.radUnderNone.Size = New System.Drawing.Size(51, 17)
        Me.radUnderNone.TabIndex = 8
        Me.radUnderNone.TabStop = True
        Me.radUnderNone.Text = "None"
        Me.radUnderNone.UseVisualStyleBackColor = True
        '
        'radUnderBipod
        '
        Me.radUnderBipod.AutoSize = True
        Me.radUnderBipod.Location = New System.Drawing.Point(9, 68)
        Me.radUnderBipod.Name = "radUnderBipod"
        Me.radUnderBipod.Size = New System.Drawing.Size(52, 17)
        Me.radUnderBipod.TabIndex = 5
        Me.radUnderBipod.Text = "Bipod"
        Me.radUnderBipod.UseVisualStyleBackColor = True
        '
        'radUnderForegrip
        '
        Me.radUnderForegrip.AutoSize = True
        Me.radUnderForegrip.Location = New System.Drawing.Point(9, 42)
        Me.radUnderForegrip.Name = "radUnderForegrip"
        Me.radUnderForegrip.Size = New System.Drawing.Size(63, 17)
        Me.radUnderForegrip.TabIndex = 4
        Me.radUnderForegrip.Text = "Foregrip"
        Me.radUnderForegrip.UseVisualStyleBackColor = True
        '
        'picPlot
        '
        Me.picPlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.picPlot.ContextMenuStrip = Me.contextImgRightClick
        Me.picPlot.Location = New System.Drawing.Point(395, 14)
        Me.picPlot.Name = "picPlot"
        Me.picPlot.Size = New System.Drawing.Size(400, 400)
        Me.picPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlot.TabIndex = 29
        Me.picPlot.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(798, -4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabel1.TabIndex = 45
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "."
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(236, 9)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 13)
        Me.Label48.TabIndex = 97
        Me.Label48.Text = "Style"
        '
        'comboSilhouetteStyle
        '
        Me.comboSilhouetteStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.comboSilhouetteStyle.Enabled = False
        Me.comboSilhouetteStyle.ForeColor = System.Drawing.Color.White
        Me.comboSilhouetteStyle.FormattingEnabled = True
        Me.comboSilhouetteStyle.Items.AddRange(New Object() {"1", "2", "3"})
        Me.comboSilhouetteStyle.Location = New System.Drawing.Point(267, 6)
        Me.comboSilhouetteStyle.Name = "comboSilhouetteStyle"
        Me.comboSilhouetteStyle.Size = New System.Drawing.Size(44, 21)
        Me.comboSilhouetteStyle.TabIndex = 98
        Me.comboSilhouetteStyle.Text = "1"
        '
        'Main
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CancelButton = Me.btnStop
        Me.ClientSize = New System.Drawing.Size(810, 439)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblBurstCounter)
        Me.Controls.Add(Me.grpStance)
        Me.Controls.Add(Me.grpWeapon)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "version()"
        Me.grpStance.ResumeLayout(False)
        Me.grpStance.PerformLayout()
        CType(Me.numBulletsPerBurst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWeapon.ResumeLayout(False)
        Me.grpWeapon.PerformLayout()
        Me.grpAttach.ResumeLayout(False)
        Me.grpAttach.PerformLayout()
        CType(Me.numRecoilH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRecoilMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRecoilV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMeters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabRender.ResumeLayout(False)
        Me.tabRender.PerformLayout()
        Me.tabSaveOptions.ResumeLayout(False)
        Me.tabSaveOptions.PerformLayout()
        Me.tabHeatMap.ResumeLayout(False)
        Me.tabHeatMap.PerformLayout()
        CType(Me.numIntensityScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeatRadius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdvanced.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabAdvBulletDrop.ResumeLayout(False)
        Me.tabAdvBulletDrop.PerformLayout()
        CType(Me.numMaxDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBulletDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDropLineThickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDropVerticalScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDropHorizontalScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdvTTK.ResumeLayout(False)
        Me.tabAdvTTK.PerformLayout()
        Me.grpCustomTTK.ResumeLayout(False)
        Me.grpCustomTTK.PerformLayout()
        CType(Me.numBulletVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRateOfFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDamagePercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHealthPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDamageSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTTKGridSpacing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTTKRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDamageMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDamageMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustom.ResumeLayout(False)
        Me.grpSpread.ResumeLayout(False)
        Me.grpSpread.PerformLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecoil.ResumeLayout(False)
        Me.grpRecoil.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextImgRightClick.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picPlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStance As System.Windows.Forms.GroupBox
    Friend WithEvents chkScaleRadius As System.Windows.Forms.CheckBox
    Friend WithEvents lbbpbm As System.Windows.Forms.Label
    Friend WithEvents lbbm As System.Windows.Forms.Label
    Friend WithEvents txtBursts As System.Windows.Forms.TextBox
    Friend WithEvents grpWeapon As System.Windows.Forms.GroupBox
    Friend WithEvents lblBurstCounter As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picPlot As System.Windows.Forms.PictureBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents grpAttach As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents numRecoilV As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numRecoilH As System.Windows.Forms.NumericUpDown
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkPrintAdj As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrawGrid As System.Windows.Forms.CheckBox
    Friend WithEvents lblAdjUp As System.Windows.Forms.Label
    Friend WithEvents lblAdjLeft As System.Windows.Forms.Label
    Friend WithEvents lblAdjRight As System.Windows.Forms.Label
    Friend WithEvents lblAdjMin As System.Windows.Forms.Label
    Friend WithEvents lblAdjInc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMinTitle As System.Windows.Forms.Label
    Friend WithEvents lblIncTitle As System.Windows.Forms.Label
    Friend WithEvents numInc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents mainToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents radMeters As System.Windows.Forms.RadioButton
    Friend WithEvents numLineSpace As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkBars As System.Windows.Forms.CheckBox
    Friend WithEvents numRecoilMultiplier As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkMultiplyRecoil As System.Windows.Forms.CheckBox
    Friend WithEvents numMeters As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents radDegrees As System.Windows.Forms.RadioButton
    Friend WithEvents chkTitles As System.Windows.Forms.CheckBox
    Friend WithEvents txtScale As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStripProgressBar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabRender As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tabSaveOptions As System.Windows.Forms.TabPage
    Friend WithEvents chkSaveImage As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents numBulletsPerBurst As System.Windows.Forms.NumericUpDown
    Friend WithEvents viewToolStrip As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewMainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHeatMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabHeatMap As System.Windows.Forms.TabPage
    Friend WithEvents numIntensityScale As System.Windows.Forms.NumericUpDown
    Friend WithEvents numHeatRadius As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkHeatMap As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chkRenderHeatBars As System.Windows.Forms.CheckBox
    Friend WithEvents chkRenderHeatTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkRenderHeatAdjust As System.Windows.Forms.CheckBox
    Friend WithEvents ViewTTKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkSaveTTKChart As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveHeatMap As System.Windows.Forms.CheckBox
    Friend WithEvents chkTimeToKill As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrawTTK As System.Windows.Forms.CheckBox
    Friend WithEvents contextImgRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeatMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X500ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X1000ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X1000ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabAdvanced As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAdvBulletDrop As System.Windows.Forms.TabPage
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents numMaxDistance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents numBulletDrop As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDropLineThickness As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkRenderBulletDrop As System.Windows.Forms.CheckBox
    Friend WithEvents chkWriteDropInfo As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents numDropVerticalScale As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents numDropHorizontalScale As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDrawDropGrid As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tabAdvTTK As System.Windows.Forms.TabPage
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents numDamagePercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents numHealthPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents numDamageSplitter As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents numMinRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMaxRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents numTTKGridSpacing As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDrawTTKGrid As System.Windows.Forms.CheckBox
    Friend WithEvents numTTKRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents numRateOfFire As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents numBulletVelocity As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDamageMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDamageMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents comboWeapon1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkStanceZoom As System.Windows.Forms.CheckBox
    Friend WithEvents radProne As System.Windows.Forms.RadioButton
    Friend WithEvents radCrouch As System.Windows.Forms.RadioButton
    Friend WithEvents radStand As System.Windows.Forms.RadioButton
    Friend WithEvents tabCustom As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBarrelNone As System.Windows.Forms.RadioButton
    Friend WithEvents radBarrelFlash As System.Windows.Forms.RadioButton
    Friend WithEvents radBarrelSilencer As System.Windows.Forms.RadioButton
    Friend WithEvents radBarrelHeavy As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnderNone As System.Windows.Forms.RadioButton
    Friend WithEvents radUnderLaser As System.Windows.Forms.RadioButton
    Friend WithEvents radUnderBipod As System.Windows.Forms.RadioButton
    Friend WithEvents radUnderForegrip As System.Windows.Forms.RadioButton
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkStanceMoving As System.Windows.Forms.CheckBox
    Friend WithEvents grpRecoil As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpSpread As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpCustomTTK As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents comboSilhouetteStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
End Class
