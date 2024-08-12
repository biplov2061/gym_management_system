Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class Trainer
    Dim con As SqlConnection = New SqlConnection("Data Source=VOSTRO;Initial Catalog=GymManagementSystem;Integrated Security=True")
    Dim rd As SqlDataReader

    Private Sub Trainersdetails()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[TrainerDetails]
            ([TrainerName]
             ,[TrainerAge]
             ,[TrainerNumber]
             ,[TrainerAddress]
             ,[Salary])
       VALUES
         ('" + txtTrainerName.Text + "', '" + txtTrainerAge.Text + "', 
            '" + txtTrainerNum.Text + "', '" + txtTrainerAddress.Text + "', '" + txtTrainerSal.Text + "'); select scope_identity();")

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Trainer Details Added !")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub showTrainerDetail()
        Try
            TrainerDataGridView1.ClearSelection()
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [dbo].[TrainerDetails] ", con)
            rd = cmd.ExecuteReader

            While rd.Read
                TrainerDataGridView1.Rows.Add(rd.Item("TrainerId"), rd.Item("TrainerName"), rd.Item("TrainerAge"), rd.Item("TrainerNumber"),
                rd.Item("TrainerAddress"), rd.Item("Salary"))

            End While
            rd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub BtnTrainerDetailsSubmit_Click(sender As Object, e As EventArgs) Handles BtnTrainerDetailsSubmit.Click
        If txtTrainerName.Text = "" Or txtTrainerAge.Text = "" Or txtTrainerNum.Text = "" Or txtTrainerAddress.Text = "" Or txtTrainerSal.Text = "" Then
            MessageBox.Show("Please fill all the areas of form❗")
        Else
            Trainersdetails()
            txtTrainerName.Text = ""
            txtTrainerAge.Text = ""
            txtTrainerNum.Text = ""
            txtTrainerAddress.Text = ""
            txtTrainerSal.Text = ""
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub ViewTrainerTable_Click(sender As Object, e As EventArgs) Handles ViewTrainerTable.Click
        TrainerControlBox.Visible = True
    End Sub


    Private Sub txtTrainerName_Leave(sender As Object, e As EventArgs) Handles txtTrainerName.Leave
        If String.IsNullOrEmpty(txtTrainerName.Text) = True Then
            txtTrainerName.Focus()
            ErrorProvider1.SetError(Me.txtTrainerName, "Please enter Equipment name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtTrainerAge_Leave(sender As Object, e As EventArgs) Handles txtTrainerAge.Leave
        If String.IsNullOrEmpty(txtTrainerAge.Text) = True Then
            txtTrainerAge.Focus()
            ErrorProvider2.SetError(Me.txtTrainerAge, "Please enter Equipment name")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub txtTrainerNum_Leave(sender As Object, e As EventArgs) Handles txtTrainerNum.Leave
        If String.IsNullOrEmpty(txtTrainerNum.Text) = True Then
            txtTrainerNum.Focus()
            ErrorProvider3.SetError(Me.txtTrainerNum, "Please enter Equipment name")
        Else
            ErrorProvider3.Clear()
        End If
    End Sub

    Private Sub txtTrainerAddress_Leave(sender As Object, e As EventArgs) Handles txtTrainerAddress.Leave
        If String.IsNullOrEmpty(txtTrainerAddress.Text) = True Then
            txtTrainerAddress.Focus()
            ErrorProvider4.SetError(Me.txtTrainerAddress, "Please enter Equipment name")
        Else
            ErrorProvider4.Clear()
        End If
    End Sub

    Private Sub txtTrainerSal_Leave(sender As Object, e As EventArgs) Handles txtTrainerSal.Leave
        If String.IsNullOrEmpty(txtTrainerSal.Text) = True Then
            txtTrainerSal.Focus()
            ErrorProvider5.SetError(Me.txtTrainerSal, "Please enter Equipment name")
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    Private Sub txtDeleteTrainer_Leave(sender As Object, e As EventArgs) Handles txtDeleteTrainer.Leave
        If String.IsNullOrEmpty(txtDeleteTrainer.Text) = True Then
            txtDeleteTrainer.Focus()
            ErrorProvider7.SetError(Me.txtDeleteTrainer, "Please enter Trainer ID !")
        Else
            ErrorProvider7.Clear()
        End If
    End Sub

    '*****<------- Deleting Trainer details from database -------->*******
    Public Sub deteleTrainer()
        Dim deleteTrainer As String
        If txtDeleteTrainer.Text = "" Then
            MessageBox.Show("please enter trainer id")
        Else
            Try
                con.Open()
                deleteTrainer = "DELETE FROM [dbo].[TrainerDetails]  WHERE TrainerId = " & txtDeleteTrainer.Text & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(deleteTrainer, con)
                cmd.ExecuteNonQuery()
                MsgBox("Trainer with ID" & txtDeleteTrainer.Text & "removed successfully !")
                txtDeleteTrainer.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If

    End Sub
    Private Sub BtnDeleteTrainer_Click(sender As Object, e As EventArgs) Handles BtnDeleteTrainer.Click
        If txtDeleteTrainer.Text <> "" Then
            deteleTrainer()
        Else
            MsgBox("Please enter Trainer Id !")
        End If
    End Sub

    Private Sub Trainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showTrainerDetail()
    End Sub

    Private Sub viewTrainer_Click(sender As Object, e As EventArgs) Handles viewTrainer.Click
        TrainerControlBox.Visible = True
    End Sub
End Class

