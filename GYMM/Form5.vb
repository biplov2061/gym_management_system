Imports System.Data.SqlClient

Public Class Suppliments
    Dim con As SqlConnection = New SqlConnection("Data Source=VOSTRO;Initial Catalog=GymManagementSystem;Integrated Security=True")
    Dim rd As SqlDataReader


    Private Sub suppliments_details()
        Dim SuppStatus As String = ""
        If rbSuppYes.Checked Then
            SuppStatus = "Yes"
        ElseIf rbSuppNo.Checked Then
            SuppStatus = "No"
        End If

        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[SupplimentsDetails]
            ([SupplimentsName]
           ,[SupplimentsPrice]
           ,[SupplimentsAvailableStatus]
           ,[ExpiryDate])
     VALUES
              ('" + txtSuppName.Text + "', '" + txtSuppPrice.Text + "', 
            '" + SuppStatus + "', '" + txtSuppExpiry.Text.ToString() + "'); select scope_identity();")

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Supplies Details Added !")
            con.Close()
            getSuppDetails()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub getSuppDetails()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [dbo].[SupplimentsDetails]", con)
            rd = cmd.ExecuteReader

            While rd.Read
                supplimentDataList.Rows.Add(rd.Item("SupplimentsId"), rd.Item("SupplimentsName"),
                rd.Item("SupplimentsPrice"), rd.Item("SupplimentsAvailableStatus"), rd.Item("ExpiryDate"))
            End While
            rd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub SuppliDetailsSubmitBtn_Click(sender As Object, e As EventArgs) Handles SuppliDetailsSubmitBtn.Click
        If txtSuppName.Text = "" Or txtSuppPrice.Text = "" Then
            MessageBox.Show("Please fill all areas of form")
        Else
            suppliments_details()
        End If
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub ViewTotalSuppli_Click(sender As Object, e As EventArgs) Handles ViewTotalSuppli.Click
        viewSupplimentList.Visible = True
    End Sub

    Private Sub AddSuppliBtn_Click(sender As Object, e As EventArgs) Handles AddSuppliBtn.Click
        viewSupplimentList.Visible = True
    End Sub

    Private Sub txtSuppName_Leave(sender As Object, e As EventArgs) Handles txtSuppName.Leave
        If String.IsNullOrEmpty(txtSuppName.Text) = True Then
            txtSuppName.Focus()
            ErrorProvider1.SetError(Me.txtSuppName, "Please enter Equipment name")
        Else
            ErrorProvider1.Clear()
        End If

    End Sub



    Private Sub txtSuppPrice_Leave(sender As Object, e As EventArgs) Handles txtSuppPrice.Leave
        If String.IsNullOrEmpty(txtSuppPrice.Text) = True Then
            txtSuppPrice.Focus()
            ErrorProvider2.SetError(Me.txtSuppPrice, "Please enter Equipment name")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub txtDeleteSuppliment_Leave(sender As Object, e As EventArgs) Handles txtDeleteSuppliment.Leave
        If String.IsNullOrEmpty(txtDeleteSuppliment.Text) = True Then
            txtDeleteSuppliment.Focus()
            ErrorProvider3.SetError(Me.txtDeleteSuppliment, "Please enter Suppliment ID !")
        Else
            ErrorProvider3.Clear()
        End If
    End Sub

    '*****<------- Deleting Suppliment details from database -------->*******
    Public Sub deleteSuppliment()
        Dim deleteSuppli As String
        Try
            con.Open()
            deleteSuppli = "DELETE FROM [dbo].[SupplimentsDetails] WHERE SupplimentsId = " & txtDeleteSuppliment.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(deleteSuppli, con)
            cmd.ExecuteNonQuery()
            MsgBox("Suppliment with ID" & txtDeleteSuppliment.Text & "removed successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnDeleteSuppliment_Click(sender As Object, e As EventArgs) Handles BtnDeleteSuppliment.Click
        If txtDeleteSuppliment.Text <> "" Then
            deleteSuppliment()
        Else
            MsgBox("Please enter Suppliment Id !")

        End If
    End Sub

    Private Sub Suppliments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSuppDetails()
    End Sub

    Private Sub Guna2ContainerControl1_Leave(sender As Object, e As EventArgs) Handles Guna2ContainerControl1.Leave
        If Not rbSuppYes.Checked AndAlso Not rbSuppNo.Checked Then
            rbSuppNo.Focus()
            ErrorProvider4.SetError(Me.rbSuppNo, "Please choose suppliments available status.")
        Else
            ErrorProvider4.Clear()
        End If
    End Sub
End Class