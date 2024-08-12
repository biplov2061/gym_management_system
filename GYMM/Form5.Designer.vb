<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Suppliments
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
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.viewSupplimentList = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.supplimentDataList = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtSuppExpiry = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.SuppliDetailsSubmitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.rbSuppYes = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbSuppNo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSuppPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSuppName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnDeleteSuppliment = New Guna.UI2.WinForms.Guna2Button()
        Me.EquipName = New System.Windows.Forms.Label()
        Me.txtDeleteSuppliment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.AddSuppliBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ViewTotalSuppli = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.viewSupplimentList.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.supplimentDataList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderColor = System.Drawing.Color.White
        Me.Guna2Button3.BorderRadius = 15
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(23, 19)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(65, 32)
        Me.Guna2Button3.TabIndex = 18
        Me.Guna2Button3.Text = "🏠"
        '
        'viewSupplimentList
        '
        Me.viewSupplimentList.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.viewSupplimentList.Controls.Add(Me.TabPage1)
        Me.viewSupplimentList.Controls.Add(Me.TabPage2)
        Me.viewSupplimentList.Controls.Add(Me.TabPage3)
        Me.viewSupplimentList.HotTrack = True
        Me.viewSupplimentList.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.viewSupplimentList.ItemSize = New System.Drawing.Size(180, 40)
        Me.viewSupplimentList.Location = New System.Drawing.Point(3, 106)
        Me.viewSupplimentList.Name = "viewSupplimentList"
        Me.viewSupplimentList.SelectedIndex = 0
        Me.viewSupplimentList.ShowToolTips = True
        Me.viewSupplimentList.Size = New System.Drawing.Size(1079, 563)
        Me.viewSupplimentList.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.viewSupplimentList.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.viewSupplimentList.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.viewSupplimentList.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.viewSupplimentList.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.viewSupplimentList.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.viewSupplimentList.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.viewSupplimentList.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.viewSupplimentList.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.viewSupplimentList.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.viewSupplimentList.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.viewSupplimentList.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.viewSupplimentList.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.viewSupplimentList.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.viewSupplimentList.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.viewSupplimentList.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.viewSupplimentList.TabIndex = 19
        Me.viewSupplimentList.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.viewSupplimentList.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.supplimentDataList)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(891, 555)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Suppliments Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'supplimentDataList
        '
        Me.supplimentDataList.BackgroundColor = System.Drawing.Color.White
        Me.supplimentDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.supplimentDataList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.supplimentDataList.Location = New System.Drawing.Point(6, 54)
        Me.supplimentDataList.Name = "supplimentDataList"
        Me.supplimentDataList.RowHeadersWidth = 51
        Me.supplimentDataList.RowTemplate.Height = 24
        Me.supplimentDataList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.supplimentDataList.Size = New System.Drawing.Size(754, 523)
        Me.supplimentDataList.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "SupplimentsId"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 121
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Suppliments Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 137
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Suppliments Price"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 132
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "SupplimentsAvailableStatus"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 204
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "ExpiryDate"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 102
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtSuppExpiry)
        Me.TabPage2.Controls.Add(Me.SuppliDetailsSubmitBtn)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Guna2ContainerControl1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtSuppPrice)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtSuppName)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(891, 555)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Suppliments"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtSuppExpiry
        '
        Me.txtSuppExpiry.Animated = True
        Me.txtSuppExpiry.AutoRoundedCorners = True
        Me.txtSuppExpiry.BorderRadius = 21
        Me.txtSuppExpiry.Checked = True
        Me.txtSuppExpiry.FillColor = System.Drawing.Color.Gray
        Me.txtSuppExpiry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSuppExpiry.ForeColor = System.Drawing.Color.White
        Me.txtSuppExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtSuppExpiry.Location = New System.Drawing.Point(99, 424)
        Me.txtSuppExpiry.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtSuppExpiry.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtSuppExpiry.Name = "txtSuppExpiry"
        Me.txtSuppExpiry.Size = New System.Drawing.Size(333, 44)
        Me.txtSuppExpiry.TabIndex = 3
        Me.txtSuppExpiry.Value = New Date(2024, 7, 14, 0, 0, 0, 0)
        '
        'SuppliDetailsSubmitBtn
        '
        Me.SuppliDetailsSubmitBtn.AutoRoundedCorners = True
        Me.SuppliDetailsSubmitBtn.BackColor = System.Drawing.Color.Transparent
        Me.SuppliDetailsSubmitBtn.BorderRadius = 21
        Me.SuppliDetailsSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SuppliDetailsSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SuppliDetailsSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SuppliDetailsSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SuppliDetailsSubmitBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.SuppliDetailsSubmitBtn.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliDetailsSubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SuppliDetailsSubmitBtn.Location = New System.Drawing.Point(525, 469)
        Me.SuppliDetailsSubmitBtn.Name = "SuppliDetailsSubmitBtn"
        Me.SuppliDetailsSubmitBtn.Size = New System.Drawing.Size(187, 44)
        Me.SuppliDetailsSubmitBtn.TabIndex = 33
        Me.SuppliDetailsSubmitBtn.Text = "Add"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Expiry Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Suppliments Available Status"
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.AutoRoundedCorners = True
        Me.Guna2ContainerControl1.BorderColor = System.Drawing.Color.Black
        Me.Guna2ContainerControl1.BorderRadius = 22
        Me.Guna2ContainerControl1.BorderThickness = 1
        Me.Guna2ContainerControl1.Controls.Add(Me.rbSuppYes)
        Me.Guna2ContainerControl1.Controls.Add(Me.rbSuppNo)
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(99, 314)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(333, 46)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'rbSuppYes
        '
        Me.rbSuppYes.AutoSize = True
        Me.rbSuppYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSuppYes.CheckedState.BorderThickness = 0
        Me.rbSuppYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSuppYes.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbSuppYes.CheckedState.InnerOffset = -4
        Me.rbSuppYes.Location = New System.Drawing.Point(37, 13)
        Me.rbSuppYes.Name = "rbSuppYes"
        Me.rbSuppYes.Size = New System.Drawing.Size(52, 20)
        Me.rbSuppYes.TabIndex = 20
        Me.rbSuppYes.Text = "Yes"
        Me.rbSuppYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbSuppYes.UncheckedState.BorderThickness = 2
        Me.rbSuppYes.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbSuppYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbSuppNo
        '
        Me.rbSuppNo.AutoSize = True
        Me.rbSuppNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSuppNo.CheckedState.BorderThickness = 0
        Me.rbSuppNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSuppNo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbSuppNo.CheckedState.InnerOffset = -4
        Me.rbSuppNo.Location = New System.Drawing.Point(234, 13)
        Me.rbSuppNo.Name = "rbSuppNo"
        Me.rbSuppNo.Size = New System.Drawing.Size(46, 20)
        Me.rbSuppNo.TabIndex = 21
        Me.rbSuppNo.Text = "No"
        Me.rbSuppNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbSuppNo.UncheckedState.BorderThickness = 2
        Me.rbSuppNo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbSuppNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Suppliment Price"
        '
        'txtSuppPrice
        '
        Me.txtSuppPrice.AutoRoundedCorners = True
        Me.txtSuppPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtSuppPrice.BorderColor = System.Drawing.Color.Black
        Me.txtSuppPrice.BorderRadius = 20
        Me.txtSuppPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuppPrice.DefaultText = ""
        Me.txtSuppPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSuppPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSuppPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSuppPrice.ForeColor = System.Drawing.Color.Black
        Me.txtSuppPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppPrice.Location = New System.Drawing.Point(99, 194)
        Me.txtSuppPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSuppPrice.Name = "txtSuppPrice"
        Me.txtSuppPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuppPrice.PlaceholderText = ""
        Me.txtSuppPrice.SelectedText = ""
        Me.txtSuppPrice.Size = New System.Drawing.Size(333, 43)
        Me.txtSuppPrice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Suppliment Name"
        '
        'txtSuppName
        '
        Me.txtSuppName.AutoRoundedCorners = True
        Me.txtSuppName.BackColor = System.Drawing.Color.Transparent
        Me.txtSuppName.BorderColor = System.Drawing.Color.Black
        Me.txtSuppName.BorderRadius = 20
        Me.txtSuppName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuppName.DefaultText = ""
        Me.txtSuppName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSuppName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSuppName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSuppName.ForeColor = System.Drawing.Color.Black
        Me.txtSuppName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppName.Location = New System.Drawing.Point(99, 92)
        Me.txtSuppName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuppName.PlaceholderText = ""
        Me.txtSuppName.SelectedText = ""
        Me.txtSuppName.Size = New System.Drawing.Size(333, 43)
        Me.txtSuppName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnDeleteSuppliment)
        Me.TabPage3.Controls.Add(Me.EquipName)
        Me.TabPage3.Controls.Add(Me.txtDeleteSuppliment)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(891, 555)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remove Suppliment"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnDeleteSuppliment
        '
        Me.BtnDeleteSuppliment.AutoRoundedCorners = True
        Me.BtnDeleteSuppliment.BorderColor = System.Drawing.Color.Gray
        Me.BtnDeleteSuppliment.BorderRadius = 21
        Me.BtnDeleteSuppliment.BorderThickness = 1
        Me.BtnDeleteSuppliment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteSuppliment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteSuppliment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeleteSuppliment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeleteSuppliment.FillColor = System.Drawing.Color.Red
        Me.BtnDeleteSuppliment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteSuppliment.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteSuppliment.Location = New System.Drawing.Point(115, 209)
        Me.BtnDeleteSuppliment.Name = "BtnDeleteSuppliment"
        Me.BtnDeleteSuppliment.Size = New System.Drawing.Size(206, 44)
        Me.BtnDeleteSuppliment.TabIndex = 27
        Me.BtnDeleteSuppliment.Text = "Remove Suppliment"
        '
        'EquipName
        '
        Me.EquipName.AutoSize = True
        Me.EquipName.BackColor = System.Drawing.Color.Transparent
        Me.EquipName.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipName.Location = New System.Drawing.Point(111, 75)
        Me.EquipName.Name = "EquipName"
        Me.EquipName.Size = New System.Drawing.Size(185, 21)
        Me.EquipName.TabIndex = 26
        Me.EquipName.Text = "Enter Suppliment ID"
        '
        'txtDeleteSuppliment
        '
        Me.txtDeleteSuppliment.AutoRoundedCorners = True
        Me.txtDeleteSuppliment.BackColor = System.Drawing.Color.Transparent
        Me.txtDeleteSuppliment.BorderColor = System.Drawing.Color.Black
        Me.txtDeleteSuppliment.BorderRadius = 22
        Me.txtDeleteSuppliment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeleteSuppliment.DefaultText = ""
        Me.txtDeleteSuppliment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDeleteSuppliment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDeleteSuppliment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteSuppliment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeleteSuppliment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteSuppliment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeleteSuppliment.ForeColor = System.Drawing.Color.Black
        Me.txtDeleteSuppliment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeleteSuppliment.Location = New System.Drawing.Point(98, 111)
        Me.txtDeleteSuppliment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDeleteSuppliment.Name = "txtDeleteSuppliment"
        Me.txtDeleteSuppliment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeleteSuppliment.PlaceholderText = ""
        Me.txtDeleteSuppliment.SelectedText = ""
        Me.txtDeleteSuppliment.Size = New System.Drawing.Size(349, 47)
        Me.txtDeleteSuppliment.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GYMM.My.Resources.Resources.gym2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(396, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 51)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Suppliments"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, -2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddSuppliBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ViewTotalSuppli)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.viewSupplimentList)
        Me.SplitContainer1.Size = New System.Drawing.Size(1394, 672)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 22)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Management system"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 164)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(350, 10)
        Me.Guna2Separator1.TabIndex = 31
        '
        'AddSuppliBtn
        '
        Me.AddSuppliBtn.AutoRoundedCorners = True
        Me.AddSuppliBtn.BorderRadius = 22
        Me.AddSuppliBtn.BorderThickness = 1
        Me.AddSuppliBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddSuppliBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddSuppliBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddSuppliBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddSuppliBtn.FillColor = System.Drawing.Color.White
        Me.AddSuppliBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSuppliBtn.ForeColor = System.Drawing.Color.Black
        Me.AddSuppliBtn.Location = New System.Drawing.Point(67, 325)
        Me.AddSuppliBtn.Name = "AddSuppliBtn"
        Me.AddSuppliBtn.Size = New System.Drawing.Size(200, 46)
        Me.AddSuppliBtn.TabIndex = 28
        Me.AddSuppliBtn.Text = "Add Suppliments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 44)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Bulls Gym "
        '
        'ViewTotalSuppli
        '
        Me.ViewTotalSuppli.AutoRoundedCorners = True
        Me.ViewTotalSuppli.BorderRadius = 23
        Me.ViewTotalSuppli.BorderThickness = 1
        Me.ViewTotalSuppli.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewTotalSuppli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewTotalSuppli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewTotalSuppli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewTotalSuppli.FillColor = System.Drawing.Color.White
        Me.ViewTotalSuppli.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTotalSuppli.ForeColor = System.Drawing.Color.Black
        Me.ViewTotalSuppli.Location = New System.Drawing.Point(67, 245)
        Me.ViewTotalSuppli.Name = "ViewTotalSuppli"
        Me.ViewTotalSuppli.Size = New System.Drawing.Size(200, 49)
        Me.ViewTotalSuppli.TabIndex = 22
        Me.ViewTotalSuppli.Text = "View Suppliments"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGreen
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.GYMM.My.Resources.Resources.icons8_supplement_64
        Me.PictureBox2.Location = New System.Drawing.Point(343, 10)
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
        'Suppliments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 672)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Suppliments"
        Me.Text = "Form5"
        Me.viewSupplimentList.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.supplimentDataList, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewSupplimentList As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSuppName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSuppPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents rbSuppYes As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbSuppNo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SuppliDetailsSubmitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSuppExpiry As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents supplimentDataList As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ViewTotalSuppli As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents AddSuppliBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtDeleteSuppliment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EquipName As Label
    Friend WithEvents BtnDeleteSuppliment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider4 As ErrorProvider
End Class
