<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usertext1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordtext2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserPassSubmitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.incorrect = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 19
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(996, 6)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(67, 40)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "❌"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(296, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOGIN"
        '
        'usertext1
        '
        Me.usertext1.AllowDrop = True
        Me.usertext1.AutoRoundedCorners = True
        Me.usertext1.BackColor = System.Drawing.Color.Transparent
        Me.usertext1.BorderColor = System.Drawing.Color.Black
        Me.usertext1.BorderRadius = 23
        Me.usertext1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usertext1.DefaultText = ""
        Me.usertext1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usertext1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usertext1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usertext1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usertext1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertext1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usertext1.ForeColor = System.Drawing.Color.Black
        Me.usertext1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertext1.Location = New System.Drawing.Point(184, 182)
        Me.usertext1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usertext1.Name = "usertext1"
        Me.usertext1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usertext1.PlaceholderText = ""
        Me.usertext1.SelectedText = ""
        Me.usertext1.Size = New System.Drawing.Size(406, 48)
        Me.usertext1.TabIndex = 0
        '
        'passwordtext2
        '
        Me.passwordtext2.AutoRoundedCorners = True
        Me.passwordtext2.BackColor = System.Drawing.Color.Transparent
        Me.passwordtext2.BorderColor = System.Drawing.Color.Black
        Me.passwordtext2.BorderRadius = 22
        Me.passwordtext2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtext2.DefaultText = ""
        Me.passwordtext2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtext2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtext2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtext2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtext2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtext2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordtext2.ForeColor = System.Drawing.Color.Black
        Me.passwordtext2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtext2.Location = New System.Drawing.Point(184, 294)
        Me.passwordtext2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.passwordtext2.Name = "passwordtext2"
        Me.passwordtext2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordtext2.PlaceholderText = ""
        Me.passwordtext2.SelectedText = ""
        Me.passwordtext2.Size = New System.Drawing.Size(406, 47)
        Me.passwordtext2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Username or Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'UserPassSubmitBtn
        '
        Me.UserPassSubmitBtn.AutoRoundedCorners = True
        Me.UserPassSubmitBtn.BackColor = System.Drawing.Color.Transparent
        Me.UserPassSubmitBtn.BorderRadius = 24
        Me.UserPassSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UserPassSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UserPassSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UserPassSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UserPassSubmitBtn.FillColor = System.Drawing.Color.Black
        Me.UserPassSubmitBtn.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassSubmitBtn.ForeColor = System.Drawing.Color.White
        Me.UserPassSubmitBtn.Location = New System.Drawing.Point(274, 471)
        Me.UserPassSubmitBtn.Name = "UserPassSubmitBtn"
        Me.UserPassSubmitBtn.Size = New System.Drawing.Size(214, 50)
        Me.UserPassSubmitBtn.TabIndex = 2
        Me.UserPassSubmitBtn.Text = "Log In"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoRoundedCorners = True
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Guna2GradientPanel1.BorderRadius = 286
        Me.Guna2GradientPanel1.Controls.Add(Me.incorrect)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.UserPassSubmitBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.usertext1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.passwordtext2)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.SystemColors.WindowFrame
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(255, 52)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1206, 574)
        Me.Guna2GradientPanel1.TabIndex = 11
        '
        'incorrect
        '
        Me.incorrect.AutoSize = True
        Me.incorrect.BackColor = System.Drawing.Color.Transparent
        Me.incorrect.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrect.ForeColor = System.Drawing.Color.Red
        Me.incorrect.Location = New System.Drawing.Point(249, 372)
        Me.incorrect.Name = "incorrect"
        Me.incorrect.Size = New System.Drawing.Size(0, 17)
        Me.incorrect.TabIndex = 12
        Me.incorrect.Visible = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(194, 423)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(383, 11)
        Me.Guna2Separator1.TabIndex = 11
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 13
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(60, 29)
        Me.Guna2Button3.TabIndex = 13
        Me.Guna2Button3.Text = "⬅️"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GYMM.My.Resources.Resources.gym2
        Me.PictureBox1.Location = New System.Drawing.Point(60, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 670)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.Text = "Form2"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents usertext1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordtext2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserPassSubmitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents incorrect As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
