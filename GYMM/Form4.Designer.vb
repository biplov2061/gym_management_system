<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Equipment
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
        Me.EquipDetailsBox = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EquipSubmitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.rbEqipYes = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbEqipNo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.EquipAvaiStatus = New System.Windows.Forms.Label()
        Me.EquipWeight = New System.Windows.Forms.Label()
        Me.EquipPrice = New System.Windows.Forms.Label()
        Me.EquipName = New System.Windows.Forms.Label()
        Me.txtEquipWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEquipPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEquipName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDeleteEquipment = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDeleteEquipment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.AddEquipBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ViewTotalEquip = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EquipDetailsBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EquipDetailsBox
        '
        Me.EquipDetailsBox.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.EquipDetailsBox.Controls.Add(Me.TabPage1)
        Me.EquipDetailsBox.Controls.Add(Me.TabPage2)
        Me.EquipDetailsBox.Controls.Add(Me.TabPage3)
        Me.EquipDetailsBox.ItemSize = New System.Drawing.Size(180, 40)
        Me.EquipDetailsBox.Location = New System.Drawing.Point(3, 131)
        Me.EquipDetailsBox.Name = "EquipDetailsBox"
        Me.EquipDetailsBox.SelectedIndex = 0
        Me.EquipDetailsBox.Size = New System.Drawing.Size(976, 599)
        Me.EquipDetailsBox.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.EquipDetailsBox.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.EquipDetailsBox.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.EquipDetailsBox.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.EquipDetailsBox.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.EquipDetailsBox.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.EquipDetailsBox.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.EquipDetailsBox.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.EquipDetailsBox.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.EquipDetailsBox.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.EquipDetailsBox.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.EquipDetailsBox.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.EquipDetailsBox.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.EquipDetailsBox.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.EquipDetailsBox.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EquipDetailsBox.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.EquipDetailsBox.TabIndex = 0
        Me.EquipDetailsBox.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.EquipDetailsBox.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(788, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Equipments Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.Size = New System.Drawing.Size(947, 605)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Equipment Id"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Equipment Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 128
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Equipment Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 123
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "EquipAvailableStatus"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 165
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "EquipmentWeight"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 142
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "EquipmentQuantity"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 148
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EquipSubmitBtn)
        Me.TabPage2.Controls.Add(Me.Guna2ContainerControl1)
        Me.TabPage2.Controls.Add(Me.EquipAvaiStatus)
        Me.TabPage2.Controls.Add(Me.EquipWeight)
        Me.TabPage2.Controls.Add(Me.EquipPrice)
        Me.TabPage2.Controls.Add(Me.EquipName)
        Me.TabPage2.Controls.Add(Me.txtEquipWeight)
        Me.TabPage2.Controls.Add(Me.txtEquipPrice)
        Me.TabPage2.Controls.Add(Me.txtEquipName)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(897, 594)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Equipments"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EquipSubmitBtn
        '
        Me.EquipSubmitBtn.AutoRoundedCorners = True
        Me.EquipSubmitBtn.BackColor = System.Drawing.Color.Transparent
        Me.EquipSubmitBtn.BorderRadius = 21
        Me.EquipSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EquipSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EquipSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EquipSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EquipSubmitBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.EquipSubmitBtn.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipSubmitBtn.ForeColor = System.Drawing.Color.White
        Me.EquipSubmitBtn.Location = New System.Drawing.Point(538, 484)
        Me.EquipSubmitBtn.Name = "EquipSubmitBtn"
        Me.EquipSubmitBtn.Size = New System.Drawing.Size(187, 44)
        Me.EquipSubmitBtn.TabIndex = 28
        Me.EquipSubmitBtn.Text = "Add"
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.AutoRoundedCorners = True
        Me.Guna2ContainerControl1.BorderColor = System.Drawing.Color.Black
        Me.Guna2ContainerControl1.BorderRadius = 22
        Me.Guna2ContainerControl1.BorderThickness = 1
        Me.Guna2ContainerControl1.Controls.Add(Me.rbEqipYes)
        Me.Guna2ContainerControl1.Controls.Add(Me.rbEqipNo)
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(60, 327)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(333, 46)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'rbEqipYes
        '
        Me.rbEqipYes.AutoSize = True
        Me.rbEqipYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbEqipYes.CheckedState.BorderThickness = 0
        Me.rbEqipYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbEqipYes.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbEqipYes.CheckedState.InnerOffset = -4
        Me.rbEqipYes.Location = New System.Drawing.Point(37, 13)
        Me.rbEqipYes.Name = "rbEqipYes"
        Me.rbEqipYes.Size = New System.Drawing.Size(52, 20)
        Me.rbEqipYes.TabIndex = 20
        Me.rbEqipYes.Text = "Yes"
        Me.rbEqipYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbEqipYes.UncheckedState.BorderThickness = 2
        Me.rbEqipYes.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbEqipYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbEqipNo
        '
        Me.rbEqipNo.AutoSize = True
        Me.rbEqipNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbEqipNo.CheckedState.BorderThickness = 0
        Me.rbEqipNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbEqipNo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbEqipNo.CheckedState.InnerOffset = -4
        Me.rbEqipNo.Location = New System.Drawing.Point(234, 13)
        Me.rbEqipNo.Name = "rbEqipNo"
        Me.rbEqipNo.Size = New System.Drawing.Size(46, 20)
        Me.rbEqipNo.TabIndex = 21
        Me.rbEqipNo.Text = "No"
        Me.rbEqipNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbEqipNo.UncheckedState.BorderThickness = 2
        Me.rbEqipNo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbEqipNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'EquipAvaiStatus
        '
        Me.EquipAvaiStatus.AutoSize = True
        Me.EquipAvaiStatus.BackColor = System.Drawing.Color.Transparent
        Me.EquipAvaiStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipAvaiStatus.Location = New System.Drawing.Point(70, 293)
        Me.EquipAvaiStatus.Name = "EquipAvaiStatus"
        Me.EquipAvaiStatus.Size = New System.Drawing.Size(144, 17)
        Me.EquipAvaiStatus.TabIndex = 26
        Me.EquipAvaiStatus.Text = "EquipAvailableStatus"
        '
        'EquipWeight
        '
        Me.EquipWeight.AutoSize = True
        Me.EquipWeight.BackColor = System.Drawing.Color.Transparent
        Me.EquipWeight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipWeight.Location = New System.Drawing.Point(70, 415)
        Me.EquipWeight.Name = "EquipWeight"
        Me.EquipWeight.Size = New System.Drawing.Size(124, 17)
        Me.EquipWeight.TabIndex = 25
        Me.EquipWeight.Text = "EquipmentWeight"
        '
        'EquipPrice
        '
        Me.EquipPrice.AutoSize = True
        Me.EquipPrice.BackColor = System.Drawing.Color.Transparent
        Me.EquipPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipPrice.Location = New System.Drawing.Point(70, 190)
        Me.EquipPrice.Name = "EquipPrice"
        Me.EquipPrice.Size = New System.Drawing.Size(112, 17)
        Me.EquipPrice.TabIndex = 24
        Me.EquipPrice.Text = "EquipmentPrice"
        '
        'EquipName
        '
        Me.EquipName.AutoSize = True
        Me.EquipName.BackColor = System.Drawing.Color.Transparent
        Me.EquipName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipName.Location = New System.Drawing.Point(70, 83)
        Me.EquipName.Name = "EquipName"
        Me.EquipName.Size = New System.Drawing.Size(121, 17)
        Me.EquipName.TabIndex = 23
        Me.EquipName.Text = "Equipment Name"
        '
        'txtEquipWeight
        '
        Me.txtEquipWeight.AutoRoundedCorners = True
        Me.txtEquipWeight.BackColor = System.Drawing.Color.Transparent
        Me.txtEquipWeight.BorderColor = System.Drawing.Color.Black
        Me.txtEquipWeight.BorderRadius = 21
        Me.txtEquipWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEquipWeight.DefaultText = ""
        Me.txtEquipWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEquipWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEquipWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEquipWeight.ForeColor = System.Drawing.Color.Black
        Me.txtEquipWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipWeight.Location = New System.Drawing.Point(60, 449)
        Me.txtEquipWeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEquipWeight.Name = "txtEquipWeight"
        Me.txtEquipWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEquipWeight.PlaceholderText = ""
        Me.txtEquipWeight.SelectedText = ""
        Me.txtEquipWeight.Size = New System.Drawing.Size(333, 44)
        Me.txtEquipWeight.TabIndex = 3
        '
        'txtEquipPrice
        '
        Me.txtEquipPrice.AutoRoundedCorners = True
        Me.txtEquipPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtEquipPrice.BorderColor = System.Drawing.Color.Black
        Me.txtEquipPrice.BorderRadius = 20
        Me.txtEquipPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEquipPrice.DefaultText = ""
        Me.txtEquipPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEquipPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEquipPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEquipPrice.ForeColor = System.Drawing.Color.Black
        Me.txtEquipPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipPrice.Location = New System.Drawing.Point(60, 220)
        Me.txtEquipPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEquipPrice.Name = "txtEquipPrice"
        Me.txtEquipPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEquipPrice.PlaceholderText = ""
        Me.txtEquipPrice.SelectedText = ""
        Me.txtEquipPrice.Size = New System.Drawing.Size(333, 43)
        Me.txtEquipPrice.TabIndex = 1
        '
        'txtEquipName
        '
        Me.txtEquipName.AutoRoundedCorners = True
        Me.txtEquipName.BackColor = System.Drawing.Color.Transparent
        Me.txtEquipName.BorderColor = System.Drawing.Color.Black
        Me.txtEquipName.BorderRadius = 20
        Me.txtEquipName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEquipName.DefaultText = ""
        Me.txtEquipName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEquipName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEquipName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEquipName.ForeColor = System.Drawing.Color.Black
        Me.txtEquipName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipName.Location = New System.Drawing.Point(60, 115)
        Me.txtEquipName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEquipName.Name = "txtEquipName"
        Me.txtEquipName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEquipName.PlaceholderText = ""
        Me.txtEquipName.SelectedText = ""
        Me.txtEquipName.Size = New System.Drawing.Size(333, 43)
        Me.txtEquipName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.BtnDeleteEquipment)
        Me.TabPage3.Controls.Add(Me.txtDeleteEquipment)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(897, 594)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remove Equipment"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Enter Equipment ID"
        '
        'BtnDeleteEquipment
        '
        Me.BtnDeleteEquipment.AutoRoundedCorners = True
        Me.BtnDeleteEquipment.BorderColor = System.Drawing.Color.Gray
        Me.BtnDeleteEquipment.BorderRadius = 21
        Me.BtnDeleteEquipment.BorderThickness = 1
        Me.BtnDeleteEquipment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteEquipment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteEquipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeleteEquipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeleteEquipment.FillColor = System.Drawing.Color.Red
        Me.BtnDeleteEquipment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEquipment.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteEquipment.Location = New System.Drawing.Point(107, 207)
        Me.BtnDeleteEquipment.Name = "BtnDeleteEquipment"
        Me.BtnDeleteEquipment.Size = New System.Drawing.Size(206, 44)
        Me.BtnDeleteEquipment.TabIndex = 28
        Me.BtnDeleteEquipment.Text = "Remove Equipment"
        '
        'txtDeleteEquipment
        '
        Me.txtDeleteEquipment.AutoRoundedCorners = True
        Me.txtDeleteEquipment.BackColor = System.Drawing.Color.Transparent
        Me.txtDeleteEquipment.BorderColor = System.Drawing.Color.Black
        Me.txtDeleteEquipment.BorderRadius = 21
        Me.txtDeleteEquipment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeleteEquipment.DefaultText = ""
        Me.txtDeleteEquipment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDeleteEquipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDeleteEquipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteEquipment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteEquipment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteEquipment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeleteEquipment.ForeColor = System.Drawing.Color.Black
        Me.txtDeleteEquipment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteEquipment.Location = New System.Drawing.Point(93, 111)
        Me.txtDeleteEquipment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDeleteEquipment.Name = "txtDeleteEquipment"
        Me.txtDeleteEquipment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeleteEquipment.PlaceholderText = ""
        Me.txtDeleteEquipment.SelectedText = ""
        Me.txtDeleteEquipment.Size = New System.Drawing.Size(332, 45)
        Me.txtDeleteEquipment.TabIndex = 2
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderColor = System.Drawing.Color.White
        Me.Guna2Button3.BorderRadius = 17
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(18, 23)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(73, 36)
        Me.Guna2Button3.TabIndex = 15
        Me.Guna2Button3.Text = "🏠"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GYMM.My.Resources.Resources.gym2
        Me.PictureBox1.Location = New System.Drawing.Point(9, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(358, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 51)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Equipments"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddEquipBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ViewTotalEquip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EquipDetailsBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(1418, 733)
        Me.SplitContainer1.SplitterDistance = 372
        Me.SplitContainer1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(101, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 22)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Management system"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(9, 167)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(350, 10)
        Me.Guna2Separator1.TabIndex = 30
        '
        'AddEquipBtn
        '
        Me.AddEquipBtn.AutoRoundedCorners = True
        Me.AddEquipBtn.BorderRadius = 19
        Me.AddEquipBtn.BorderThickness = 1
        Me.AddEquipBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddEquipBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddEquipBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddEquipBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddEquipBtn.FillColor = System.Drawing.Color.White
        Me.AddEquipBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEquipBtn.ForeColor = System.Drawing.Color.Black
        Me.AddEquipBtn.Location = New System.Drawing.Point(71, 339)
        Me.AddEquipBtn.Name = "AddEquipBtn"
        Me.AddEquipBtn.Size = New System.Drawing.Size(214, 40)
        Me.AddEquipBtn.TabIndex = 29
        Me.AddEquipBtn.Text = "Add Equipments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 44)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Bulls Gym "
        '
        'ViewTotalEquip
        '
        Me.ViewTotalEquip.AutoRoundedCorners = True
        Me.ViewTotalEquip.BorderRadius = 20
        Me.ViewTotalEquip.BorderThickness = 1
        Me.ViewTotalEquip.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewTotalEquip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewTotalEquip.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewTotalEquip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewTotalEquip.FillColor = System.Drawing.Color.White
        Me.ViewTotalEquip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTotalEquip.ForeColor = System.Drawing.Color.Black
        Me.ViewTotalEquip.Location = New System.Drawing.Point(69, 246)
        Me.ViewTotalEquip.Name = "ViewTotalEquip"
        Me.ViewTotalEquip.Size = New System.Drawing.Size(216, 43)
        Me.ViewTotalEquip.TabIndex = 23
        Me.ViewTotalEquip.Text = "View Equipments"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.GYMM.My.Resources.Resources.icons8_gym_50
        Me.PictureBox2.Location = New System.Drawing.Point(305, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'Equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 733)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Equipment"
        Me.Text = "Form4"
        Me.EquipDetailsBox.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.Guna2ContainerControl1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EquipDetailsBox As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEquipWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEquipPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEquipName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EquipName As Label
    Friend WithEvents EquipPrice As Label
    Friend WithEvents EquipAvaiStatus As Label
    Friend WithEvents EquipWeight As Label
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents rbEqipYes As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbEqipNo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents EquipSubmitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ViewTotalEquip As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents AddEquipBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtDeleteEquipment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnDeleteEquipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
End Class
