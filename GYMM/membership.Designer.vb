<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class membership
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
        Me.MemberControlBox = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addMemSection = New System.Windows.Forms.TabPage()
        Me.submitMemberDetailsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContainerControl2 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.rbPaymentYes = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbPaymentNo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.cmbMembershipPlan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.rbMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dateDOB = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EquipName = New System.Windows.Forms.Label()
        Me.txtDeleteMemberId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnDeleteMember = New Guna.UI2.WinForms.Guna2Button()
        Me.ViewMemberBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.loadDashboardBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AddEquipBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider7 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider8 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MemberControlBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addMemSection.SuspendLayout()
        Me.Guna2ContainerControl2.SuspendLayout()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemberControlBox
        '
        Me.MemberControlBox.Controls.Add(Me.TabPage1)
        Me.MemberControlBox.Controls.Add(Me.addMemSection)
        Me.MemberControlBox.Controls.Add(Me.TabPage2)
        Me.MemberControlBox.ItemSize = New System.Drawing.Size(180, 40)
        Me.MemberControlBox.Location = New System.Drawing.Point(365, 90)
        Me.MemberControlBox.Name = "MemberControlBox"
        Me.MemberControlBox.SelectedIndex = 0
        Me.MemberControlBox.Size = New System.Drawing.Size(973, 640)
        Me.MemberControlBox.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.MemberControlBox.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MemberControlBox.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MemberControlBox.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.MemberControlBox.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MemberControlBox.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.MemberControlBox.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MemberControlBox.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MemberControlBox.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.MemberControlBox.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MemberControlBox.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.MemberControlBox.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MemberControlBox.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MemberControlBox.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.MemberControlBox.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MemberControlBox.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.MemberControlBox.TabIndex = 0
        Me.MemberControlBox.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MemberControlBox.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        Me.MemberControlBox.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(965, 592)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Members Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.Size = New System.Drawing.Size(962, 534)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "MemberID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 99
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 73
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Address"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 87
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "DOB"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Gender"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 81
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PhoneNumber"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 123
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Membership"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 111
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "PaymentStatus"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 126
        '
        'addMemSection
        '
        Me.addMemSection.Controls.Add(Me.submitMemberDetailsBtn)
        Me.addMemSection.Controls.Add(Me.Guna2ContainerControl2)
        Me.addMemSection.Controls.Add(Me.cmbMembershipPlan)
        Me.addMemSection.Controls.Add(Me.Guna2ContainerControl1)
        Me.addMemSection.Controls.Add(Me.dateDOB)
        Me.addMemSection.Controls.Add(Me.txtName)
        Me.addMemSection.Controls.Add(Me.txtAddress)
        Me.addMemSection.Controls.Add(Me.txtPhoneNo)
        Me.addMemSection.Controls.Add(Me.Label7)
        Me.addMemSection.Controls.Add(Me.Label6)
        Me.addMemSection.Controls.Add(Me.Label5)
        Me.addMemSection.Controls.Add(Me.Label4)
        Me.addMemSection.Controls.Add(Me.Label3)
        Me.addMemSection.Controls.Add(Me.Label1)
        Me.addMemSection.Controls.Add(Me.Label2)
        Me.addMemSection.Location = New System.Drawing.Point(4, 44)
        Me.addMemSection.Name = "addMemSection"
        Me.addMemSection.Padding = New System.Windows.Forms.Padding(3)
        Me.addMemSection.Size = New System.Drawing.Size(965, 592)
        Me.addMemSection.TabIndex = 1
        Me.addMemSection.Text = "Add Member"
        '
        'submitMemberDetailsBtn
        '
        Me.submitMemberDetailsBtn.AutoRoundedCorners = True
        Me.submitMemberDetailsBtn.BackColor = System.Drawing.Color.Transparent
        Me.submitMemberDetailsBtn.BorderRadius = 21
        Me.submitMemberDetailsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.submitMemberDetailsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.submitMemberDetailsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.submitMemberDetailsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.submitMemberDetailsBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.submitMemberDetailsBtn.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitMemberDetailsBtn.ForeColor = System.Drawing.Color.White
        Me.submitMemberDetailsBtn.Location = New System.Drawing.Point(574, 506)
        Me.submitMemberDetailsBtn.Name = "submitMemberDetailsBtn"
        Me.submitMemberDetailsBtn.Size = New System.Drawing.Size(187, 44)
        Me.submitMemberDetailsBtn.TabIndex = 24
        Me.submitMemberDetailsBtn.Text = "Add"
        '
        'Guna2ContainerControl2
        '
        Me.Guna2ContainerControl2.AutoRoundedCorners = True
        Me.Guna2ContainerControl2.BorderColor = System.Drawing.Color.Black
        Me.Guna2ContainerControl2.BorderRadius = 20
        Me.Guna2ContainerControl2.BorderThickness = 1
        Me.Guna2ContainerControl2.Controls.Add(Me.rbPaymentYes)
        Me.Guna2ContainerControl2.Controls.Add(Me.rbPaymentNo)
        Me.Guna2ContainerControl2.Location = New System.Drawing.Point(499, 44)
        Me.Guna2ContainerControl2.Name = "Guna2ContainerControl2"
        Me.Guna2ContainerControl2.Size = New System.Drawing.Size(314, 42)
        Me.Guna2ContainerControl2.TabIndex = 6
        Me.Guna2ContainerControl2.Text = "Guna2ContainerControl2"
        '
        'rbPaymentYes
        '
        Me.rbPaymentYes.AutoSize = True
        Me.rbPaymentYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPaymentYes.CheckedState.BorderThickness = 0
        Me.rbPaymentYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPaymentYes.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbPaymentYes.CheckedState.InnerOffset = -4
        Me.rbPaymentYes.Location = New System.Drawing.Point(37, 13)
        Me.rbPaymentYes.Name = "rbPaymentYes"
        Me.rbPaymentYes.Size = New System.Drawing.Size(52, 20)
        Me.rbPaymentYes.TabIndex = 20
        Me.rbPaymentYes.Text = "Yes"
        Me.rbPaymentYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbPaymentYes.UncheckedState.BorderThickness = 2
        Me.rbPaymentYes.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbPaymentYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbPaymentNo
        '
        Me.rbPaymentNo.AutoSize = True
        Me.rbPaymentNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPaymentNo.CheckedState.BorderThickness = 0
        Me.rbPaymentNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPaymentNo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbPaymentNo.CheckedState.InnerOffset = -4
        Me.rbPaymentNo.Location = New System.Drawing.Point(195, 13)
        Me.rbPaymentNo.Name = "rbPaymentNo"
        Me.rbPaymentNo.Size = New System.Drawing.Size(46, 20)
        Me.rbPaymentNo.TabIndex = 21
        Me.rbPaymentNo.Text = "No"
        Me.rbPaymentNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbPaymentNo.UncheckedState.BorderThickness = 2
        Me.rbPaymentNo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbPaymentNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'cmbMembershipPlan
        '
        Me.cmbMembershipPlan.AutoRoundedCorners = True
        Me.cmbMembershipPlan.BackColor = System.Drawing.Color.Transparent
        Me.cmbMembershipPlan.BorderColor = System.Drawing.Color.Black
        Me.cmbMembershipPlan.BorderRadius = 17
        Me.cmbMembershipPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMembershipPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMembershipPlan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMembershipPlan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMembershipPlan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMembershipPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMembershipPlan.ItemHeight = 30
        Me.cmbMembershipPlan.Items.AddRange(New Object() {"3 months", "6 months", "12 months"})
        Me.cmbMembershipPlan.Location = New System.Drawing.Point(59, 506)
        Me.cmbMembershipPlan.Name = "cmbMembershipPlan"
        Me.cmbMembershipPlan.Size = New System.Drawing.Size(318, 36)
        Me.cmbMembershipPlan.TabIndex = 5
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.AutoRoundedCorners = True
        Me.Guna2ContainerControl1.BorderColor = System.Drawing.Color.Black
        Me.Guna2ContainerControl1.BorderRadius = 21
        Me.Guna2ContainerControl1.BorderThickness = 1
        Me.Guna2ContainerControl1.Controls.Add(Me.rbMale)
        Me.Guna2ContainerControl1.Controls.Add(Me.rbFemale)
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(58, 305)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(318, 44)
        Me.Guna2ContainerControl1.TabIndex = 3
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMale.CheckedState.BorderThickness = 0
        Me.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbMale.CheckedState.InnerOffset = -4
        Me.rbMale.Location = New System.Drawing.Point(37, 13)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(58, 20)
        Me.rbMale.TabIndex = 20
        Me.rbMale.Text = "Male"
        Me.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbMale.UncheckedState.BorderThickness = 2
        Me.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbFemale.CheckedState.BorderThickness = 0
        Me.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbFemale.CheckedState.InnerOffset = -4
        Me.rbFemale.Location = New System.Drawing.Point(195, 13)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(74, 20)
        Me.rbFemale.TabIndex = 21
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbFemale.UncheckedState.BorderThickness = 2
        Me.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'dateDOB
        '
        Me.dateDOB.Animated = True
        Me.dateDOB.AutoRoundedCorners = True
        Me.dateDOB.BorderRadius = 19
        Me.dateDOB.Checked = True
        Me.dateDOB.FillColor = System.Drawing.Color.Gray
        Me.dateDOB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateDOB.ForeColor = System.Drawing.Color.White
        Me.dateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDOB.Location = New System.Drawing.Point(57, 220)
        Me.dateDOB.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateDOB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(319, 40)
        Me.dateDOB.TabIndex = 2
        Me.dateDOB.Value = New Date(2024, 7, 14, 0, 0, 0, 0)
        '
        'txtName
        '
        Me.txtName.AutoRoundedCorners = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.Color.Black
        Me.txtName.BorderRadius = 20
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(57, 43)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(318, 43)
        Me.txtName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.AutoRoundedCorners = True
        Me.txtAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtAddress.BorderColor = System.Drawing.Color.Black
        Me.txtAddress.BorderRadius = 20
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(57, 132)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(318, 43)
        Me.txtAddress.TabIndex = 1
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AutoRoundedCorners = True
        Me.txtPhoneNo.BackColor = System.Drawing.Color.Transparent
        Me.txtPhoneNo.BorderColor = System.Drawing.Color.Black
        Me.txtPhoneNo.BorderRadius = 20
        Me.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNo.DefaultText = ""
        Me.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNo.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.Location = New System.Drawing.Point(59, 407)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNo.PlaceholderText = ""
        Me.txtPhoneNo.SelectedText = ""
        Me.txtPhoneNo.Size = New System.Drawing.Size(318, 43)
        Me.txtPhoneNo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(526, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Payment Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Membership Plan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Phone No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EquipName)
        Me.TabPage2.Controls.Add(Me.txtDeleteMemberId)
        Me.TabPage2.Controls.Add(Me.BtnDeleteMember)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(965, 592)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Remove Member"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EquipName
        '
        Me.EquipName.AutoSize = True
        Me.EquipName.BackColor = System.Drawing.Color.Transparent
        Me.EquipName.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipName.Location = New System.Drawing.Point(103, 72)
        Me.EquipName.Name = "EquipName"
        Me.EquipName.Size = New System.Drawing.Size(155, 21)
        Me.EquipName.TabIndex = 24
        Me.EquipName.Text = "Enter Member Id"
        '
        'txtDeleteMemberId
        '
        Me.txtDeleteMemberId.AutoRoundedCorners = True
        Me.txtDeleteMemberId.BackColor = System.Drawing.Color.Transparent
        Me.txtDeleteMemberId.BorderColor = System.Drawing.Color.Black
        Me.txtDeleteMemberId.BorderRadius = 21
        Me.txtDeleteMemberId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeleteMemberId.DefaultText = ""
        Me.txtDeleteMemberId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDeleteMemberId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDeleteMemberId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteMemberId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteMemberId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteMemberId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeleteMemberId.ForeColor = System.Drawing.Color.Black
        Me.txtDeleteMemberId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteMemberId.Location = New System.Drawing.Point(83, 108)
        Me.txtDeleteMemberId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDeleteMemberId.Name = "txtDeleteMemberId"
        Me.txtDeleteMemberId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeleteMemberId.PlaceholderText = ""
        Me.txtDeleteMemberId.SelectedText = ""
        Me.txtDeleteMemberId.Size = New System.Drawing.Size(332, 45)
        Me.txtDeleteMemberId.TabIndex = 1
        '
        'BtnDeleteMember
        '
        Me.BtnDeleteMember.AutoRoundedCorners = True
        Me.BtnDeleteMember.BorderColor = System.Drawing.Color.Gray
        Me.BtnDeleteMember.BorderRadius = 22
        Me.BtnDeleteMember.BorderThickness = 1
        Me.BtnDeleteMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeleteMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeleteMember.FillColor = System.Drawing.Color.Red
        Me.BtnDeleteMember.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteMember.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteMember.Location = New System.Drawing.Point(93, 189)
        Me.BtnDeleteMember.Name = "BtnDeleteMember"
        Me.BtnDeleteMember.Size = New System.Drawing.Size(202, 46)
        Me.BtnDeleteMember.TabIndex = 8
        Me.BtnDeleteMember.Text = "Remove Member"
        '
        'ViewMemberBtn
        '
        Me.ViewMemberBtn.AutoRoundedCorners = True
        Me.ViewMemberBtn.BorderRadius = 22
        Me.ViewMemberBtn.BorderThickness = 1
        Me.ViewMemberBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewMemberBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewMemberBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewMemberBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewMemberBtn.FillColor = System.Drawing.Color.White
        Me.ViewMemberBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMemberBtn.ForeColor = System.Drawing.Color.Black
        Me.ViewMemberBtn.Location = New System.Drawing.Point(89, 216)
        Me.ViewMemberBtn.Name = "ViewMemberBtn"
        Me.ViewMemberBtn.Size = New System.Drawing.Size(183, 46)
        Me.ViewMemberBtn.TabIndex = 7
        Me.ViewMemberBtn.Text = "View members"
        '
        'loadDashboardBtn
        '
        Me.loadDashboardBtn.AutoRoundedCorners = True
        Me.loadDashboardBtn.BorderColor = System.Drawing.Color.White
        Me.loadDashboardBtn.BorderRadius = 14
        Me.loadDashboardBtn.BorderThickness = 1
        Me.loadDashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loadDashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loadDashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loadDashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loadDashboardBtn.FillColor = System.Drawing.Color.Transparent
        Me.loadDashboardBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadDashboardBtn.ForeColor = System.Drawing.Color.Black
        Me.loadDashboardBtn.Location = New System.Drawing.Point(21, 12)
        Me.loadDashboardBtn.Name = "loadDashboardBtn"
        Me.loadDashboardBtn.Size = New System.Drawing.Size(64, 30)
        Me.loadDashboardBtn.TabIndex = 14
        Me.loadDashboardBtn.Text = "🏠"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GYMM.My.Resources.Resources.gym2
        Me.PictureBox1.Location = New System.Drawing.Point(28, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(386, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 51)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Members"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(-6, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddEquipBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ViewMemberBtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Size = New System.Drawing.Size(1460, 709)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 17
        '
        'AddEquipBtn
        '
        Me.AddEquipBtn.AutoRoundedCorners = True
        Me.AddEquipBtn.BorderRadius = 21
        Me.AddEquipBtn.BorderThickness = 1
        Me.AddEquipBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddEquipBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddEquipBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddEquipBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddEquipBtn.FillColor = System.Drawing.Color.White
        Me.AddEquipBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEquipBtn.ForeColor = System.Drawing.Color.Black
        Me.AddEquipBtn.Location = New System.Drawing.Point(89, 307)
        Me.AddEquipBtn.Name = "AddEquipBtn"
        Me.AddEquipBtn.Size = New System.Drawing.Size(183, 45)
        Me.AddEquipBtn.TabIndex = 32
        Me.AddEquipBtn.Text = "Add Members"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(11, 176)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(350, 10)
        Me.Guna2Separator1.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(108, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Management system"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(212, 44)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Bulls Gym "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.GYMM.My.Resources.Resources.icons8_card_50
        Me.PictureBox2.Location = New System.Drawing.Point(333, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
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
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'ErrorProvider7
        '
        Me.ErrorProvider7.ContainerControl = Me
        '
        'ErrorProvider8
        '
        Me.ErrorProvider8.ContainerControl = Me
        '
        'membership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 703)
        Me.Controls.Add(Me.loadDashboardBtn)
        Me.Controls.Add(Me.MemberControlBox)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "membership"
        Me.Text = "membership"
        Me.MemberControlBox.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addMemSection.ResumeLayout(False)
        Me.addMemSection.PerformLayout()
        Me.Guna2ContainerControl2.ResumeLayout(False)
        Me.Guna2ContainerControl2.PerformLayout()
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.Guna2ContainerControl1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MemberControlBox As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents addMemSection As TabPage
    Friend WithEvents rbFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents dateDOB As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ContainerControl2 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents rbPaymentYes As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbPaymentNo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents cmbMembershipPlan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents submitMemberDetailsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents ViewMemberBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDeleteMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loadDashboardBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents ErrorProvider7 As ErrorProvider
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtDeleteMemberId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EquipName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ErrorProvider8 As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AddEquipBtn As Guna.UI2.WinForms.Guna2Button
End Class
