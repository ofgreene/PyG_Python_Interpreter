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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G0-G1 Linear Move")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G2 Arc Move")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G3 Circle Move")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G4 Dwell")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G5 Cubic B-spline")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G6 Direct Stepper Move")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G10 Retract")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G11 Recover")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G12 Clean Nozzle")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G17-19 CNC Workspace Planes")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G20 Inch Units")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G21 Millimeter Units")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G26 Mesh Validation Pattern")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G27 Park toolhead")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G28 Auto Home")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 3-Point")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 Bilinear")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 Linear")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 Manual")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 Unified")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G29 Bed Leveling ", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G30 Single Z-Probe")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G31 Dock Sled")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G32 Undock Sled")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G33 Delta Auto Claibration")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G34 Mechanical Gantry Calibration")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G35 Tramming Assistant")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G38 Probe target")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G42 Move to mesh coordinate")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G53 Move in Machine Coordinates")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G54-G59 Workspace Coordinate System")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G60 Save Current Position")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G61 Return to Saved Position")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G76 Probe Temperature Calibration")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G80 Cancel Current Motion Mode")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G90 Absolute Positioning")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G91 Relative Positioning")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G92 Set Position")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G425 Backlash Calibration")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G-Code Commands", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M0-M1 Unconditional Stop")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M3 Spindle CW/Laser On")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M4 Spindle CCW/Laser On")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M5 Spindle/Laser Off")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M7-M9 Cooland Controls")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M10-M11 Vacuum/Blower Control")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M16 Expected Printer Check")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M17 Enable Steppers")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M18 Disable steppers")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M20 List SD Card")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M21 Init SD card")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M22 Release SD Card")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M23 Select SD File")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M24 Start or Resume SD print")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M25 Pause SD print")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M26 Set SD Position")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M27 Report SD print status")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M28 Start SD write")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M29 Stop SD write")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M30 Delete SD file")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M31 Print time")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M32 Select and Start")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M33 Get Long Path")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("M-Code Commands", New System.Windows.Forms.TreeNode() {TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59, TreeNode60, TreeNode61, TreeNode62, TreeNode63})
        Me.pnlPython = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.scrollPython = New System.Windows.Forms.VScrollBar()
        Me.pnlGcode = New System.Windows.Forms.Panel()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.scrollGcode = New System.Windows.Forms.VScrollBar()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.lstMachineOptions = New System.Windows.Forms.ToolStripComboBox()
        Me.lstEnvironment = New System.Windows.Forms.ToolStripComboBox()
        Me.lstToolSettings = New System.Windows.Forms.ToolStripComboBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolbtn1 = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnlbl1 = New System.Windows.Forms.ToolStripLabel()
        Me.toolbtn2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.iconText = New System.Windows.Forms.ToolStripButton()
        Me.lblText = New System.Windows.Forms.ToolStripLabel()
        Me.iconCAD = New System.Windows.Forms.ToolStripButton()
        Me.lblCAD = New System.Windows.Forms.ToolStripLabel()
        Me.iconCNC = New System.Windows.Forms.ToolStripButton()
        Me.lblCNC = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbOpen = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.treeLibrary = New System.Windows.Forms.TreeView()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lblLibraries = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlPython.SuspendLayout()
        Me.pnlGcode.SuspendLayout()
        Me.menuMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPython
        '
        Me.pnlPython.BackColor = System.Drawing.Color.White
        Me.pnlPython.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPython.Controls.Add(Me.RichTextBox1)
        Me.pnlPython.Controls.Add(Me.scrollPython)
        Me.pnlPython.Location = New System.Drawing.Point(94, 106)
        Me.pnlPython.Name = "pnlPython"
        Me.pnlPython.Size = New System.Drawing.Size(243, 423)
        Me.pnlPython.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(239, 419)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'scrollPython
        '
        Me.scrollPython.Location = New System.Drawing.Point(478, -4)
        Me.scrollPython.Name = "scrollPython"
        Me.scrollPython.Size = New System.Drawing.Size(17, 665)
        Me.scrollPython.TabIndex = 3
        '
        'pnlGcode
        '
        Me.pnlGcode.BackColor = System.Drawing.Color.White
        Me.pnlGcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGcode.Controls.Add(Me.RichTextBox3)
        Me.pnlGcode.Controls.Add(Me.scrollGcode)
        Me.pnlGcode.Location = New System.Drawing.Point(386, 106)
        Me.pnlGcode.Name = "pnlGcode"
        Me.pnlGcode.Size = New System.Drawing.Size(258, 427)
        Me.pnlGcode.TabIndex = 1
        '
        'RichTextBox3
        '
        Me.RichTextBox3.AcceptsTab = True
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(254, 423)
        Me.RichTextBox3.TabIndex = 5
        Me.RichTextBox3.Text = " "
        '
        'scrollGcode
        '
        Me.scrollGcode.Location = New System.Drawing.Point(506, 0)
        Me.scrollGcode.Name = "scrollGcode"
        Me.scrollGcode.Size = New System.Drawing.Size(17, 665)
        Me.scrollGcode.TabIndex = 4
        '
        'menuMain
        '
        Me.menuMain.BackColor = System.Drawing.Color.Tan
        Me.menuMain.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lstMachineOptions, Me.lstEnvironment, Me.lstToolSettings})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1042, 32)
        Me.menuMain.TabIndex = 2
        Me.menuMain.Text = "MenuStrip1"
        '
        'lstMachineOptions
        '
        Me.lstMachineOptions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMachineOptions.Items.AddRange(New Object() {"2-axis mill", "2.5-axis mill", "3-axis mill", "4-axis mill", "5-axis mill"})
        Me.lstMachineOptions.Name = "lstMachineOptions"
        Me.lstMachineOptions.Size = New System.Drawing.Size(145, 28)
        Me.lstMachineOptions.Text = "Machine Options"
        '
        'lstEnvironment
        '
        Me.lstEnvironment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEnvironment.Items.AddRange(New Object() {"GibbsCAM", "MasterCAM", "CAD"})
        Me.lstEnvironment.Name = "lstEnvironment"
        Me.lstEnvironment.Size = New System.Drawing.Size(121, 28)
        Me.lstEnvironment.Text = "Environment"
        '
        'lstToolSettings
        '
        Me.lstToolSettings.DropDownWidth = 140
        Me.lstToolSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstToolSettings.Items.AddRange(New Object() {"F: Feed Control", "S: Spindle Speed", "T: Tool Operations"})
        Me.lstToolSettings.Name = "lstToolSettings"
        Me.lstToolSettings.Size = New System.Drawing.Size(140, 28)
        Me.lstToolSettings.Text = "Tool Settings"
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.PaleGreen
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(517, 561)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(130, 40)
        Me.btnRun.TabIndex = 5
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(386, 561)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 40)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MistyRose
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(209, 782)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MistyRose
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(96, 782)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 40)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbtn1, Me.toolbtnlbl1, Me.toolbtn2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(67, 641)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolbtn1
        '
        Me.toolbtn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolbtn1.Image = CType(resources.GetObject("toolbtn1.Image"), System.Drawing.Image)
        Me.toolbtn1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtn1.Name = "toolbtn1"
        Me.toolbtn1.Size = New System.Drawing.Size(64, 20)
        Me.toolbtn1.ToolTipText = "Download Python"
        '
        'toolbtnlbl1
        '
        Me.toolbtnlbl1.Name = "toolbtnlbl1"
        Me.toolbtnlbl1.Size = New System.Drawing.Size(64, 15)
        Me.toolbtnlbl1.Text = "python.org"
        '
        'toolbtn2
        '
        Me.toolbtn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolbtn2.Image = CType(resources.GetObject("toolbtn2.Image"), System.Drawing.Image)
        Me.toolbtn2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtn2.Name = "toolbtn2"
        Me.toolbtn2.Size = New System.Drawing.Size(64, 20)
        Me.toolbtn2.Text = "ToolStripButton2"
        Me.toolbtn2.ToolTipText = "Connect to GitHub"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 15)
        Me.ToolStripLabel2.Text = "GitHub"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iconText, Me.lblText, Me.iconCAD, Me.lblCAD, Me.iconCNC, Me.lblCNC})
        Me.ToolStrip2.Location = New System.Drawing.Point(67, 32)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(975, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'iconText
        '
        Me.iconText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.iconText.Image = CType(resources.GetObject("iconText.Image"), System.Drawing.Image)
        Me.iconText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.iconText.Name = "iconText"
        Me.iconText.Size = New System.Drawing.Size(23, 22)
        Me.iconText.Text = "ToolStripButton2"
        Me.iconText.ToolTipText = "View as text"
        '
        'lblText
        '
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(56, 22)
        Me.lblText.Text = "Text View"
        '
        'iconCAD
        '
        Me.iconCAD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.iconCAD.Image = CType(resources.GetObject("iconCAD.Image"), System.Drawing.Image)
        Me.iconCAD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.iconCAD.Name = "iconCAD"
        Me.iconCAD.Size = New System.Drawing.Size(23, 22)
        Me.iconCAD.Text = "ToolStripButton1"
        Me.iconCAD.ToolTipText = "View as CAD drawing"
        '
        'lblCAD
        '
        Me.lblCAD.Name = "lblCAD"
        Me.lblCAD.Size = New System.Drawing.Size(59, 22)
        Me.lblCAD.Text = "CAD View"
        '
        'iconCNC
        '
        Me.iconCNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.iconCNC.Image = CType(resources.GetObject("iconCNC.Image"), System.Drawing.Image)
        Me.iconCNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.iconCNC.Name = "iconCNC"
        Me.iconCNC.Size = New System.Drawing.Size(23, 22)
        Me.iconCNC.Text = "ToolStripButton3"
        Me.iconCNC.ToolTipText = "View as 3D graphic"
        '
        'lblCNC
        '
        Me.lblCNC.ActiveLinkColor = System.Drawing.Color.Red
        Me.lblCNC.BackColor = System.Drawing.Color.BurlyWood
        Me.lblCNC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCNC.Name = "lblCNC"
        Me.lblCNC.Size = New System.Drawing.Size(114, 22)
        Me.lblCNC.Text = "CNC Simulator View"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripLabel7, Me.ToolStripLabel8, Me.ToolStripButton9, Me.ToolStripLabel9})
        Me.ToolStrip3.Location = New System.Drawing.Point(990, 57)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(52, 616)
        Me.ToolStrip3.TabIndex = 13
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripButton7.Text = "ToolStripButton1"
        Me.ToolStripButton7.ToolTipText = "CNC Glossary of Terms"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(49, 15)
        Me.ToolStripLabel7.Text = "Glossary"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(49, 0)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripButton9.Text = "ToolStripButton3"
        Me.ToolStripButton9.ToolTipText = "Load/View Previous Projects"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(49, 15)
        Me.ToolStripLabel9.Text = "Projects"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(664, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Add Command")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(664, 343)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Remove Command")
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.Location = New System.Drawing.Point(1167, 774)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(64, 16)
        Me.lblLog.TabIndex = 17
        Me.lblLog.Text = "Details: "
        Me.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbSave
        '
        Me.pbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSave.Image = CType(resources.GetObject("pbSave.Image"), System.Drawing.Image)
        Me.pbSave.Location = New System.Drawing.Point(586, 61)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(45, 40)
        Me.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSave.TabIndex = 18
        Me.pbSave.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbSave, "Save GCode File")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbOpen
        '
        Me.pbOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbOpen.Image = CType(resources.GetObject("pbOpen.Image"), System.Drawing.Image)
        Me.pbOpen.Location = New System.Drawing.Point(398, 60)
        Me.pbOpen.Name = "pbOpen"
        Me.pbOpen.Size = New System.Drawing.Size(44, 43)
        Me.pbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOpen.TabIndex = 19
        Me.pbOpen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbOpen, "Open Python File")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 644)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(351, 17)
        Me.HScrollBar1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.treeLibrary)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Location = New System.Drawing.Point(733, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 427)
        Me.Panel1.TabIndex = 10
        '
        'treeLibrary
        '
        Me.treeLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeLibrary.Location = New System.Drawing.Point(0, 0)
        Me.treeLibrary.Name = "treeLibrary"
        TreeNode1.Name = "G0-G1"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Tag = "Add a straight line movement to the planner."
        TreeNode1.Text = "G0-G1 Linear Move"
        TreeNode1.ToolTipText = "Add a straight line movement to the planner."
        TreeNode2.BackColor = System.Drawing.Color.White
        TreeNode2.ForeColor = System.Drawing.Color.Black
        TreeNode2.Name = "G2"
        TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode2.Tag = "Add an arc movement to the planner."
        TreeNode2.Text = "G2 Arc Move"
        TreeNode2.ToolTipText = "Add an arc movement to the planner."
        TreeNode3.Name = "G3"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.Tag = "Add a circle movement to the planner."
        TreeNode3.Text = "G3 Circle Move"
        TreeNode3.ToolTipText = "Add a circle movement to the planner."
        TreeNode4.Name = "G4"
        TreeNode4.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode4.Tag = "Pause the planner"
        TreeNode4.Text = "G4 Dwell"
        TreeNode4.ToolTipText = "Pause the planner"
        TreeNode5.Name = "G5"
        TreeNode5.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode5.Tag = "Cubic B-spline with XYE destination and IJPQ offsets"
        TreeNode5.Text = "G5 Cubic B-spline"
        TreeNode5.ToolTipText = "Cubic B-spline with XYE destination and IJPQ offsets"
        TreeNode6.Name = "G6"
        TreeNode6.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode6.Tag = "Perform a direct, uninterpolated, and non-kinematic synchronized move"
        TreeNode6.Text = "G6 Direct Stepper Move"
        TreeNode6.ToolTipText = "Perform a direct, uninterpolated, and non-kinematic synchronized move"
        TreeNode7.Name = "G10"
        TreeNode7.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode7.Tag = "Retract the filament"
        TreeNode7.Text = "G10 Retract"
        TreeNode7.ToolTipText = "Retract the filament"
        TreeNode8.Name = "G11"
        TreeNode8.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode8.Tag = "Recover the filament with firmware-based retract."
        TreeNode8.Text = "G11 Recover"
        TreeNode8.ToolTipText = "Recover the filament with firmware-based retract."
        TreeNode9.Name = "G12"
        TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode9.Tag = "Perform the nozzle cleaning procedure."
        TreeNode9.Text = "G12 Clean Nozzle"
        TreeNode9.ToolTipText = "Perform the nozzle cleaning procedure."
        TreeNode10.Name = "G17-19"
        TreeNode10.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode10.Tag = "Select CNC workspace plane"
        TreeNode10.Text = "G17-19 CNC Workspace Planes"
        TreeNode10.ToolTipText = "Select CNC workspace plane"
        TreeNode11.Name = "G20"
        TreeNode11.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode11.Tag = "Set Units to Inches"
        TreeNode11.Text = "G20 Inch Units"
        TreeNode11.ToolTipText = "Set Units to Inches"
        TreeNode12.Name = "G21"
        TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode12.Tag = "Sets Units to Millimeters"
        TreeNode12.Text = "G21 Millimeter Units"
        TreeNode12.ToolTipText = "Sets Units to Millimeters"
        TreeNode13.Name = "G26"
        TreeNode13.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode13.Tag = "Test the mesh and adjust."
        TreeNode13.Text = "G26 Mesh Validation Pattern"
        TreeNode13.ToolTipText = "Test the mesh and adjust."
        TreeNode14.Name = "G27"
        TreeNode14.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode14.Tag = "Park the current toolhead"
        TreeNode14.Text = "G27 Park toolhead"
        TreeNode14.ToolTipText = "Park the current toolhead"
        TreeNode15.Name = "G28"
        TreeNode15.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode15.Tag = "Auto home one or more axes."
        TreeNode15.Text = "G28 Auto Home"
        TreeNode15.ToolTipText = "Auto home one or more axes."
        TreeNode16.Name = "G29 1"
        TreeNode16.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode16.Tag = "Probe the bed and enable leveling compensation."
        TreeNode16.Text = "G29 3-Point"
        TreeNode16.ToolTipText = "Probe the bed and enable leveling compensation."
        TreeNode17.Name = "G29 2"
        TreeNode17.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode17.Tag = "Probe the bed and enable leveling compensation."
        TreeNode17.Text = "G29 Bilinear"
        TreeNode17.ToolTipText = "Probe the bed and enable leveling compensation."
        TreeNode18.Name = "G29 3"
        TreeNode18.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode18.Tag = "Probe the bed and enable leveling compensation."
        TreeNode18.Text = "G29 Linear"
        TreeNode18.ToolTipText = "Probe the bed and enable leveling compensation."
        TreeNode19.Name = "G29 4"
        TreeNode19.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode19.Tag = "Probe the bed and enable leveling compensation."
        TreeNode19.Text = "G29 Manual"
        TreeNode19.ToolTipText = "Probe the bed and enable leveling compensation."
        TreeNode20.Name = "G29 5"
        TreeNode20.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode20.Tag = "Probe the bed and enable leveling compensation."
        TreeNode20.Text = "G29 Unified"
        TreeNode20.ToolTipText = "Probe the bed and enable leveling compensation."
        TreeNode21.Name = "G29"
        TreeNode21.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode21.Tag = "Probe the bed and enable leveling compensation"
        TreeNode21.Text = "G29 Bed Leveling "
        TreeNode21.ToolTipText = "Probe the bed and enable leveling compensation"
        TreeNode22.Name = "G30"
        TreeNode22.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode22.Tag = "Probe bed at current XY location."
        TreeNode22.Text = "G30 Single Z-Probe"
        TreeNode22.ToolTipText = "Probe bed at current XY location."
        TreeNode23.Name = "G31"
        TreeNode23.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode23.Tag = "Dock the Z probe sled."
        TreeNode23.Text = "G31 Dock Sled"
        TreeNode23.ToolTipText = "Dock the Z probe sled."
        TreeNode24.Name = "G32"
        TreeNode24.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode24.Tag = "Undock the Z probe sled. "
        TreeNode24.Text = "G32 Undock Sled"
        TreeNode24.ToolTipText = "Undock the Z probe sled. "
        TreeNode25.Name = "G33"
        TreeNode25.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode25.Tag = "Calibrate various Delta parameters"
        TreeNode25.Text = "G33 Delta Auto Claibration"
        TreeNode25.ToolTipText = "Calibrate various Delta parameters"
        TreeNode26.Name = "G34"
        TreeNode26.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode26.Tag = "Modern replacement for Prusa's TMC_Z_CALIBRATION"
        TreeNode26.Text = "G34 Mechanical Gantry Calibration"
        TreeNode26.ToolTipText = "Modern replacement for Prusa's TMC_Z_CALIBRATION"
        TreeNode27.Name = "G35"
        TreeNode27.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode27.Tag = "Runa procedure to tram the bed."
        TreeNode27.Text = "G35 Tramming Assistant"
        TreeNode27.ToolTipText = "Runa procedure to tram the bed."
        TreeNode28.Name = "G38"
        TreeNode28.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode28.Tag = "Probe towards (or away from) a workpiece."
        TreeNode28.Text = "G38 Probe target"
        TreeNode28.ToolTipText = "Probe towards (or away from) a workpiece."
        TreeNode29.Name = "G42"
        TreeNode29.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode29.Tag = "Move to a specific point in the leveling mesh."
        TreeNode29.Text = "G42 Move to mesh coordinate"
        TreeNode29.ToolTipText = "Move to a specific point in the leveling mesh."
        TreeNode30.Name = "G53"
        TreeNode30.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode30.Tag = "Apply native workspace to the current move. "
        TreeNode30.Text = "G53 Move in Machine Coordinates"
        TreeNode30.ToolTipText = "Apply native workspace to the current move. "
        TreeNode31.Name = "G54"
        TreeNode31.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode31.Tag = "Select a workspace coordinate system"
        TreeNode31.Text = "G54-G59 Workspace Coordinate System"
        TreeNode31.ToolTipText = "Select a workspace coordinate system"
        TreeNode32.Name = "G60"
        TreeNode32.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode32.Tag = "Save current position to specified slot"
        TreeNode32.Text = "G60 Save Current Position"
        TreeNode32.ToolTipText = "Save current position to specified slot"
        TreeNode33.Name = "G61"
        TreeNode33.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode33.Tag = "Return to saved position of specified slot"
        TreeNode33.Text = "G61 Return to Saved Position"
        TreeNode33.ToolTipText = "Return to saved position of specified slot"
        TreeNode34.Name = "G76"
        TreeNode34.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode34.Tag = "Calibrate probe temperature compensation"
        TreeNode34.Text = "G76 Probe Temperature Calibration"
        TreeNode34.ToolTipText = "Calibrate probe temperature compensation"
        TreeNode35.Name = "G80"
        TreeNode35.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode35.Tag = "Cancel the current motion mode"
        TreeNode35.Text = "G80 Cancel Current Motion Mode"
        TreeNode35.ToolTipText = "Cancel the current motion mode"
        TreeNode36.Name = "G90"
        TreeNode36.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode36.Tag = "Set the interpreter to absolute positions"
        TreeNode36.Text = "G90 Absolute Positioning"
        TreeNode36.ToolTipText = "Set the interpreter to absolute positions"
        TreeNode37.Name = "G91"
        TreeNode37.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode37.Tag = "Set the interpreter to relative positions"
        TreeNode37.Text = "G91 Relative Positioning"
        TreeNode37.ToolTipText = "Set the interpreter to relative positions"
        TreeNode38.Name = "G92"
        TreeNode38.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode38.Tag = "Set the current position of one or more axes."
        TreeNode38.Text = "G92 Set Position"
        TreeNode38.ToolTipText = "Set the current position of one or more axes."
        TreeNode39.Name = "G425"
        TreeNode39.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode39.Tag = "Use a conductivbe object to calibrate XYZ backlash"
        TreeNode39.Text = "G425 Backlash Calibration"
        TreeNode39.ToolTipText = "Use a conductivbe object to calibrate XYZ backlash"
        TreeNode40.Name = "GCodeLibrary"
        TreeNode40.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode40.Tag = "Common G-Codes"
        TreeNode40.Text = "G-Code Commands"
        TreeNode40.ToolTipText = "Common G-Codes"
        TreeNode41.Name = "M0-M1"
        TreeNode41.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode41.Tag = "Stop and wait for user"
        TreeNode41.Text = "M0-M1 Unconditional Stop"
        TreeNode41.ToolTipText = "Stop and wait for user"
        TreeNode42.Name = "M3"
        TreeNode42.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode42.Tag = "Set the spindle CW speed or laser power"
        TreeNode42.Text = "M3 Spindle CW/Laser On"
        TreeNode42.ToolTipText = "Set the spindle CW speed or laser power"
        TreeNode43.Name = "M4"
        TreeNode43.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode43.Tag = "Set the spindle CCW speed or laser power"
        TreeNode43.Text = "M4 Spindle CCW/Laser On"
        TreeNode43.ToolTipText = "Set the spindle CCW speed or laser power"
        TreeNode44.Name = "M5"
        TreeNode44.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode44.Tag = "Turn off spindle or laser"
        TreeNode44.Text = "M5 Spindle/Laser Off"
        TreeNode44.ToolTipText = "Turn off spindle or laser"
        TreeNode45.Name = "M7-M9"
        TreeNode45.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode45.Tag = "Turn mist or flood cooland on/off"
        TreeNode45.Text = "M7-M9 Cooland Controls"
        TreeNode45.ToolTipText = "Turn mist or flood cooland on/off"
        TreeNode46.Name = "M10-M11"
        TreeNode46.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode46.Tag = "Enable or disable the Cutter Vacuum or Laser Blower Motor"
        TreeNode46.Text = "M10-M11 Vacuum/Blower Control"
        TreeNode46.ToolTipText = "Enable or disable the Cutter Vacuum or Laser Blower Motor"
        TreeNode47.Name = "M16"
        TreeNode47.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode47.Tag = "Prevent G-code usage on the wrong machine"
        TreeNode47.Text = "M16 Expected Printer Check"
        TreeNode47.ToolTipText = "Prevent G-code usage on the wrong machine"
        TreeNode48.Name = "M17"
        TreeNode48.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode48.Tag = "Enable steppers"
        TreeNode48.Text = "M17 Enable Steppers"
        TreeNode48.ToolTipText = "Enable steppers"
        TreeNode49.Name = "M18"
        TreeNode49.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode49.Tag = "Disable steppers (same as M84)"
        TreeNode49.Text = "M18 Disable steppers"
        TreeNode49.ToolTipText = "Disable steppers (same as M84)"
        TreeNode50.Name = "M20"
        TreeNode50.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode50.Tag = "List the contents of the SD Card"
        TreeNode50.Text = "M20 List SD Card"
        TreeNode50.ToolTipText = "List the contents of the SD Card"
        TreeNode51.Name = "M21"
        TreeNode51.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode51.Tag = "Attempt to detect an SD card in the slot"
        TreeNode51.Text = "M21 Init SD card"
        TreeNode51.ToolTipText = "Attempt to detect an SD card in the slot"
        TreeNode52.Name = "M22"
        TreeNode52.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode52.Tag = "Simulate ejection of the SD card"
        TreeNode52.Text = "M22 Release SD Card"
        TreeNode52.ToolTipText = "Simulate ejection of the SD card"
        TreeNode53.Name = "M23"
        TreeNode53.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode53.Tag = "Select an SD file to be executed"
        TreeNode53.Text = "M23 Select SD File"
        TreeNode53.ToolTipText = "Select an SD file to be executed"
        TreeNode54.Name = "M24"
        TreeNode54.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode54.Tag = "Start or resume a file selected with [`M23`](/docs/gcode/M023.html)"
        TreeNode54.Text = "M24 Start or Resume SD print"
        TreeNode54.ToolTipText = "Start or resume a file selected with [`M23`](/docs/gcode/M023.html)"
        TreeNode55.Name = "M25"
        TreeNode55.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode55.Tag = "Pause printing from the SD card"
        TreeNode55.Text = "M25 Pause SD print"
        TreeNode55.ToolTipText = "Pause printing from the SD card"
        TreeNode56.Name = "M26"
        TreeNode56.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode56.Tag = "Set the SD read position"
        TreeNode56.Text = "M26 Set SD Position"
        TreeNode56.ToolTipText = "Set the SD read position"
        TreeNode57.Name = "M27"
        TreeNode57.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode57.Tag = "Print SD progress to serial"
        TreeNode57.Text = "M27 Report SD print status"
        TreeNode57.ToolTipText = "Print SD progress to serial"
        TreeNode58.Name = "M28"
        TreeNode58.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode58.Tag = "Start writing to a file on the SD card"
        TreeNode58.Text = "M28 Start SD write"
        TreeNode58.ToolTipText = "Start writing to a file on the SD card"
        TreeNode59.Name = "M29"
        TreeNode59.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode59.Tag = "Stop writing the file, end logging."
        TreeNode59.Text = "M29 Stop SD write"
        TreeNode59.ToolTipText = "Stop writing the file, end logging."
        TreeNode60.Name = "M30"
        TreeNode60.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode60.Tag = "Delete a specified file from SD."
        TreeNode60.Text = "M30 Delete SD file"
        TreeNode60.ToolTipText = "Delete a specified file from SD."
        TreeNode61.Name = "M31"
        TreeNode61.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode61.Tag = "Report the current print time."
        TreeNode61.Text = "M31 Print time"
        TreeNode61.ToolTipText = "Report the current print time."
        TreeNode62.Name = "M32"
        TreeNode62.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode62.Tag = "Begin an SD print from a file."
        TreeNode62.Text = "M32 Select and Start"
        TreeNode62.ToolTipText = "Begin an SD print from a file."
        TreeNode63.Name = "M33"
        TreeNode63.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode63.Tag = "Convert a short pathname to a long pathname."
        TreeNode63.Text = "M33 Get Long Path"
        TreeNode63.ToolTipText = "Convert a short pathname to a long pathname."
        TreeNode64.Name = "MCodeLibrary"
        TreeNode64.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode64.Tag = "Common M-Codes"
        TreeNode64.Text = "M-Code Commands"
        TreeNode64.ToolTipText = "Common M-Codes"
        Me.treeLibrary.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode64})
        Me.treeLibrary.Size = New System.Drawing.Size(246, 431)
        Me.treeLibrary.TabIndex = 17
        Me.treeLibrary.Tag = "test"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(733, 561)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(248, 40)
        Me.RichTextBox2.TabIndex = 20
        Me.RichTextBox2.Text = ""
        '
        'lblLibraries
        '
        Me.lblLibraries.AutoSize = True
        Me.lblLibraries.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibraries.Location = New System.Drawing.Point(732, 83)
        Me.lblLibraries.Name = "lblLibraries"
        Me.lblLibraries.Size = New System.Drawing.Size(78, 18)
        Me.lblLibraries.TabIndex = 21
        Me.lblLibraries.Text = "Libraries:"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(732, 540)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(65, 18)
        Me.lblDetails.TabIndex = 22
        Me.lblDetails.Text = "Details:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(517, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Run GCode Script")
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(454, 61)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(63, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Connect to CNC Media")
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1042, 673)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblLibraries)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.pbOpen)
        Me.Controls.Add(Me.pbSave)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.pnlGcode)
        Me.Controls.Add(Me.pnlPython)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "Form1"
        Me.Text = "PyG "
        Me.pnlPython.ResumeLayout(False)
        Me.pnlGcode.ResumeLayout(False)
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPython As Panel
    Friend WithEvents pnlGcode As Panel
    Friend WithEvents scrollPython As VScrollBar
    Friend WithEvents scrollGcode As VScrollBar
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents btnRun As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolbtn1 As ToolStripButton
    Friend WithEvents toolbtnlbl1 As ToolStripLabel
    Friend WithEvents toolbtn2 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents iconCAD As ToolStripButton
    Friend WithEvents lblCAD As ToolStripLabel
    Friend WithEvents iconText As ToolStripButton
    Friend WithEvents lblText As ToolStripLabel
    Friend WithEvents iconCNC As ToolStripButton
    Friend WithEvents lblCNC As ToolStripLabel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lstToolSettings As ToolStripComboBox
    Friend WithEvents lblLog As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents pbSave As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbOpen As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents treeLibrary As TreeView
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents lblLibraries As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lstMachineOptions As ToolStripComboBox
    Friend WithEvents lstEnvironment As ToolStripComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
