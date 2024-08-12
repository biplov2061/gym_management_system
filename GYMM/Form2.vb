Public Class loginform
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()

    End Sub

    '****<------ Username and Password Validation ------>*****

    Private Sub UserPassSubmitBtn_Click(sender As Object, e As EventArgs) Handles UserPassSubmitBtn.Click
        Dim username As String
        Dim password As String

        username = "admin"
        password = "admin"

        If username = usertext1.Text And password = passwordtext2.Text Then
            dashboard.Show()
            Me.Close()
        ElseIf usertext1.Text = "" Or passwordtext2.Text = "" Then
            incorrect.Text = "*** Please fill the form ***"
            incorrect.Visible = True
        Else

            incorrect.Text = "*** Incorrect Username or Password ***"
            incorrect.Visible = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        homepage.Show()
    End Sub


    '*****<------- Username empty or Null check -------->*******
    Private Sub usertext1_Leave(sender As Object, e As EventArgs) Handles usertext1.Leave
        If String.IsNullOrEmpty(usertext1.Text) = True Then
            usertext1.Focus()
            ErrorProvider1.SetError(Me.usertext1, "Please enter Username")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub


    '*****<------- Password empty or Null check  -------->*******
    Private Sub passwordtext2_Leave(sender As Object, e As EventArgs) Handles passwordtext2.Leave
        If String.IsNullOrEmpty(passwordtext2.Text) = True Then
            passwordtext2.Focus()
            ErrorProvider2.SetError(Me.passwordtext2, "Please enter your password")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub


End Class