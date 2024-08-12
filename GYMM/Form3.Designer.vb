<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BackLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TrainerBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplimentsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.EquipmentBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.MemberBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
        Me.TrainerBox = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.totalAvailableTrainer = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuppliBox = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.SuppliTotalCapacity = New System.Windows.Forms.Label()
        Me.totalSupplimentsCount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EquipBox = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.EquipTotalCapacity = New System.Windows.Forms.Label()
        Me.txtAvailableEquip = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MemberBox = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RegMemberCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrainerBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliBox.SuspendLayout()
        Me.EquipBox.SuspendLayout()
        Me.MemberBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BackLogin)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TrainerBtn)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SupplimentsBtn)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EquipmentBtn)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MemberBtn)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Guna2Button9)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TrainerBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer2.Panel2.Controls.Add(Me.SuppliBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer2.Panel2.Controls.Add(Me.EquipBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.MemberBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(1478, 716)
        Me.SplitContainer2.SplitterDistance = 467
        Me.SplitContainer2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 22)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Management system"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 159)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(413, 10)
        Me.Guna2Separator1.TabIndex = 12
        '
        'BackLogin
        '
        Me.BackLogin.AutoRoundedCorners = True
        Me.BackLogin.BorderRadius = 14
        Me.BackLogin.BorderThickness = 1
        Me.BackLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BackLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BackLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BackLogin.FillColor = System.Drawing.Color.White
        Me.BackLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLogin.ForeColor = System.Drawing.Color.Black
        Me.BackLogin.Location = New System.Drawing.Point(23, 12)
        Me.BackLogin.Name = "BackLogin"
        Me.BackLogin.Size = New System.Drawing.Size(57, 31)
        Me.BackLogin.TabIndex = 8
        Me.BackLogin.Text = "⬅️"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 51)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bulls Gym "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GYMM.My.Resources.Resources.gym2
        Me.PictureBox1.Location = New System.Drawing.Point(59, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TrainerBtn
        '
        Me.TrainerBtn.AutoRoundedCorners = True
        Me.TrainerBtn.BorderColor = System.Drawing.Color.DodgerBlue
        Me.TrainerBtn.BorderRadius = 22
        Me.TrainerBtn.BorderThickness = 1
        Me.TrainerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.TrainerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.TrainerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TrainerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TrainerBtn.FillColor = System.Drawing.Color.Transparent
        Me.TrainerBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainerBtn.ForeColor = System.Drawing.Color.Black
        Me.TrainerBtn.Image = Global.GYMM.My.Resources.Resources.icons8_trainer_50
        Me.TrainerBtn.Location = New System.Drawing.Point(81, 549)
        Me.TrainerBtn.Name = "TrainerBtn"
        Me.TrainerBtn.Size = New System.Drawing.Size(254, 46)
        Me.TrainerBtn.TabIndex = 4
        Me.TrainerBtn.Text = "  Trainers"
        '
        'SupplimentsBtn
        '
        Me.SupplimentsBtn.AutoRoundedCorners = True
        Me.SupplimentsBtn.BorderColor = System.Drawing.Color.DodgerBlue
        Me.SupplimentsBtn.BorderRadius = 21
        Me.SupplimentsBtn.BorderThickness = 1
        Me.SupplimentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SupplimentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SupplimentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SupplimentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SupplimentsBtn.FillColor = System.Drawing.Color.Transparent
        Me.SupplimentsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplimentsBtn.ForeColor = System.Drawing.Color.Black
        Me.SupplimentsBtn.Image = Global.GYMM.My.Resources.Resources.icons8_supplement_64
        Me.SupplimentsBtn.Location = New System.Drawing.Point(81, 455)
        Me.SupplimentsBtn.Name = "SupplimentsBtn"
        Me.SupplimentsBtn.Size = New System.Drawing.Size(254, 45)
        Me.SupplimentsBtn.TabIndex = 3
        Me.SupplimentsBtn.Text = "     Suppliments"
        '
        'EquipmentBtn
        '
        Me.EquipmentBtn.AutoRoundedCorners = True
        Me.EquipmentBtn.BorderColor = System.Drawing.Color.DodgerBlue
        Me.EquipmentBtn.BorderRadius = 22
        Me.EquipmentBtn.BorderThickness = 1
        Me.EquipmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EquipmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EquipmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EquipmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EquipmentBtn.FillColor = System.Drawing.Color.White
        Me.EquipmentBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentBtn.ForeColor = System.Drawing.Color.Black
        Me.EquipmentBtn.Image = Global.GYMM.My.Resources.Resources.icons8_gym_50
        Me.EquipmentBtn.Location = New System.Drawing.Point(85, 358)
        Me.EquipmentBtn.Name = "EquipmentBtn"
        Me.EquipmentBtn.Size = New System.Drawing.Size(254, 47)
        Me.EquipmentBtn.TabIndex = 2
        Me.EquipmentBtn.Text = "     Equipments"
        '
        'MemberBtn
        '
        Me.MemberBtn.AutoRoundedCorners = True
        Me.MemberBtn.BorderColor = System.Drawing.Color.DodgerBlue
        Me.MemberBtn.BorderRadius = 23
        Me.MemberBtn.BorderThickness = 1
        Me.MemberBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.MemberBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.MemberBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.MemberBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.MemberBtn.FillColor = System.Drawing.Color.White
        Me.MemberBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberBtn.ForeColor = System.Drawing.Color.Black
        Me.MemberBtn.Image = Global.GYMM.My.Resources.Resources.icons8_card_50
        Me.MemberBtn.Location = New System.Drawing.Point(85, 258)
        Me.MemberBtn.Name = "MemberBtn"
        Me.MemberBtn.Size = New System.Drawing.Size(250, 48)
        Me.MemberBtn.TabIndex = 1
        Me.MemberBtn.Text = "Member/Membership"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(380, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 52)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DASHBOARD"
        '
        'Guna2Button9
        '
        Me.Guna2Button9.AutoRoundedCorners = True
        Me.Guna2Button9.BorderRadius = 23
        Me.Guna2Button9.BorderThickness = 1
        Me.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button9.FillColor = System.Drawing.Color.White
        Me.Guna2Button9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button9.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button9.Image = Global.GYMM.My.Resources.Resources.icons8_card_50
        Me.Guna2Button9.Location = New System.Drawing.Point(-141, 25)
        Me.Guna2Button9.Name = "Guna2Button9"
        Me.Guna2Button9.Size = New System.Drawing.Size(90, 48)
        Me.Guna2Button9.TabIndex = 8
        Me.Guna2Button9.Text = "Member/Membership"
        '
        'TrainerBox
        '
        Me.TrainerBox.AutoRoundedCorners = True
        Me.TrainerBox.BorderColor = System.Drawing.Color.Lime
        Me.TrainerBox.BorderRadius = 67
        Me.TrainerBox.BorderThickness = 1
        Me.TrainerBox.Controls.Add(Me.PictureBox2)
        Me.TrainerBox.Controls.Add(Me.Label19)
        Me.TrainerBox.Controls.Add(Me.totalAvailableTrainer)
        Me.TrainerBox.Controls.Add(Me.Label21)
        Me.TrainerBox.Controls.Add(Me.Label22)
        Me.TrainerBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TrainerBox.ForeColor = System.Drawing.Color.White
        Me.TrainerBox.Location = New System.Drawing.Point(116, 567)
        Me.TrainerBox.Name = "TrainerBox"
        Me.TrainerBox.Size = New System.Drawing.Size(723, 136)
        Me.TrainerBox.TabIndex = 13
        Me.TrainerBox.Text = "Guna2ContainerControl4"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Image = Global.GYMM.My.Resources.Resources.icons8_trainer_50
        Me.PictureBox2.Location = New System.Drawing.Point(78, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(521, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 26)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "10"
        '
        'totalAvailableTrainer
        '
        Me.totalAvailableTrainer.AutoSize = True
        Me.totalAvailableTrainer.BackColor = System.Drawing.Color.Transparent
        Me.totalAvailableTrainer.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAvailableTrainer.Location = New System.Drawing.Point(90, 91)
        Me.totalAvailableTrainer.Name = "totalAvailableTrainer"
        Me.totalAvailableTrainer.Size = New System.Drawing.Size(25, 26)
        Me.totalAvailableTrainer.TabIndex = 11
        Me.totalAvailableTrainer.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(503, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 21)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Capacity"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(38, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 21)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Available Trainers"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(585, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 21)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Suppliments"
        '
        'SuppliBox
        '
        Me.SuppliBox.AutoRoundedCorners = True
        Me.SuppliBox.BorderColor = System.Drawing.Color.Lime
        Me.SuppliBox.BorderRadius = 72
        Me.SuppliBox.BorderThickness = 1
        Me.SuppliBox.Controls.Add(Me.SuppliTotalCapacity)
        Me.SuppliBox.Controls.Add(Me.totalSupplimentsCount)
        Me.SuppliBox.Controls.Add(Me.Label17)
        Me.SuppliBox.Controls.Add(Me.Label18)
        Me.SuppliBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SuppliBox.ForeColor = System.Drawing.Color.White
        Me.SuppliBox.Location = New System.Drawing.Point(534, 370)
        Me.SuppliBox.Name = "SuppliBox"
        Me.SuppliBox.Size = New System.Drawing.Size(305, 146)
        Me.SuppliBox.TabIndex = 15
        Me.SuppliBox.Text = "Guna2ContainerControl3"
        '
        'SuppliTotalCapacity
        '
        Me.SuppliTotalCapacity.AutoSize = True
        Me.SuppliTotalCapacity.BackColor = System.Drawing.Color.Transparent
        Me.SuppliTotalCapacity.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliTotalCapacity.Location = New System.Drawing.Point(180, 84)
        Me.SuppliTotalCapacity.Name = "SuppliTotalCapacity"
        Me.SuppliTotalCapacity.Size = New System.Drawing.Size(64, 26)
        Me.SuppliTotalCapacity.TabIndex = 13
        Me.SuppliTotalCapacity.Text = "1000"
        '
        'totalSupplimentsCount
        '
        Me.totalSupplimentsCount.AutoSize = True
        Me.totalSupplimentsCount.BackColor = System.Drawing.Color.Transparent
        Me.totalSupplimentsCount.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalSupplimentsCount.Location = New System.Drawing.Point(180, 37)
        Me.totalSupplimentsCount.Name = "totalSupplimentsCount"
        Me.totalSupplimentsCount.Size = New System.Drawing.Size(25, 26)
        Me.totalSupplimentsCount.TabIndex = 14
        Me.totalSupplimentsCount.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Capacity"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(29, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 21)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Available"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(167, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Equipments"
        '
        'EquipBox
        '
        Me.EquipBox.AutoRoundedCorners = True
        Me.EquipBox.BorderColor = System.Drawing.Color.SpringGreen
        Me.EquipBox.BorderRadius = 72
        Me.EquipBox.BorderThickness = 1
        Me.EquipBox.Controls.Add(Me.EquipTotalCapacity)
        Me.EquipBox.Controls.Add(Me.txtAvailableEquip)
        Me.EquipBox.Controls.Add(Me.Label10)
        Me.EquipBox.Controls.Add(Me.Label9)
        Me.EquipBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EquipBox.ForeColor = System.Drawing.Color.White
        Me.EquipBox.Location = New System.Drawing.Point(116, 370)
        Me.EquipBox.Name = "EquipBox"
        Me.EquipBox.Size = New System.Drawing.Size(329, 146)
        Me.EquipBox.TabIndex = 13
        Me.EquipBox.Text = "Guna2ContainerControl2"
        '
        'EquipTotalCapacity
        '
        Me.EquipTotalCapacity.AutoSize = True
        Me.EquipTotalCapacity.BackColor = System.Drawing.Color.Transparent
        Me.EquipTotalCapacity.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipTotalCapacity.Location = New System.Drawing.Point(180, 84)
        Me.EquipTotalCapacity.Name = "EquipTotalCapacity"
        Me.EquipTotalCapacity.Size = New System.Drawing.Size(51, 26)
        Me.EquipTotalCapacity.TabIndex = 13
        Me.EquipTotalCapacity.Text = "100"
        '
        'txtAvailableEquip
        '
        Me.txtAvailableEquip.AutoSize = True
        Me.txtAvailableEquip.BackColor = System.Drawing.Color.Transparent
        Me.txtAvailableEquip.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableEquip.Location = New System.Drawing.Point(180, 37)
        Me.txtAvailableEquip.Name = "txtAvailableEquip"
        Me.txtAvailableEquip.Size = New System.Drawing.Size(25, 26)
        Me.txtAvailableEquip.TabIndex = 14
        Me.txtAvailableEquip.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Capacity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Available"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Member/Membership Status"
        '
        'MemberBox
        '
        Me.MemberBox.AutoRoundedCorners = True
        Me.MemberBox.BorderColor = System.Drawing.Color.Lime
        Me.MemberBox.BorderRadius = 72
        Me.MemberBox.BorderThickness = 1
        Me.MemberBox.Controls.Add(Me.Label7)
        Me.MemberBox.Controls.Add(Me.RegMemberCount)
        Me.MemberBox.Controls.Add(Me.Label6)
        Me.MemberBox.Controls.Add(Me.Label4)
        Me.MemberBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MemberBox.ForeColor = System.Drawing.Color.White
        Me.MemberBox.Location = New System.Drawing.Point(116, 166)
        Me.MemberBox.Name = "MemberBox"
        Me.MemberBox.Size = New System.Drawing.Size(723, 146)
        Me.MemberBox.TabIndex = 8
        Me.MemberBox.Text = "Guna2ContainerControl1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "100"
        '
        'RegMemberCount
        '
        Me.RegMemberCount.AutoSize = True
        Me.RegMemberCount.BackColor = System.Drawing.Color.Transparent
        Me.RegMemberCount.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegMemberCount.Location = New System.Drawing.Point(103, 80)
        Me.RegMemberCount.Name = "RegMemberCount"
        Me.RegMemberCount.Size = New System.Drawing.Size(27, 30)
        Me.RegMemberCount.TabIndex = 11
        Me.RegMemberCount.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(469, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Members Capacity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Registered Members"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 716)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'dashboard
        '
        Me.ClientSize = New System.Drawing.Size(1478, 716)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "dashboard"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrainerBox.ResumeLayout(False)
        Me.TrainerBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliBox.ResumeLayout(False)
        Me.SuppliBox.PerformLayout()
        Me.EquipBox.ResumeLayout(False)
        Me.EquipBox.PerformLayout()
        Me.MemberBox.ResumeLayout(False)
        Me.MemberBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SupplimentsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EquipmentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MemberBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TrainerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MemberBox As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Label5 As Label
    Friend WithEvents RegMemberCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SuppliBox As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents SuppliTotalCapacity As Label
    Friend WithEvents totalSupplimentsCount As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EquipBox As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents EquipTotalCapacity As Label
    Friend WithEvents txtAvailableEquip As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TrainerBox As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents totalAvailableTrainer As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label2 As Label
End Class
