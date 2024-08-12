Imports System.Data.SqlClient
Public Class dashboard
    Dim con As SqlConnection = New SqlConnection("Data Source=VOSTRO;Initial Catalog=GymManagementSystem;Integrated Security=True")

    Public Sub countmember()
        Dim total_count As String
        Dim count As String
        con.Open()
        Dim cmd As New SqlCommand
        count = "SELECT COUNT(*) FROM [dbo].[MembersDetails]"
        cmd = New SqlCommand(count, con)
        total_count = cmd.ExecuteScalar().ToString()
        RegMemberCount.Text = total_count
        con.Close()
    End Sub

    Public Sub countEquipments()
        Try
            con.Open()
            Dim totalEquipCount As String
            Dim count As String
            Dim cmd As New SqlCommand
            count = "SELECT COUNT(*) FROM [dbo].[EquipmentDetails]"
            cmd = New SqlCommand(count, con)
            totalEquipCount = cmd.ExecuteScalar().ToString()
            txtAvailableEquip.Text = totalEquipCount
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub countSuppliments()
        Try
            con.Open()
            Dim totalSuppliCount As String
            Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [dbo].[SupplimentsDetails]", con)
            totalSuppliCount = cmd.ExecuteScalar().ToString()
            totalSupplimentsCount.Text = totalSuppliCount
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub countTrainers()
        Try
            con.Open()
            Dim totalTrainerCount As String
            Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM [dbo].[TrainerDetails] ", con)
            totalTrainerCount = cmd.ExecuteScalar().ToString()
            totalAvailableTrainer.Text = totalTrainerCount
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MemberBtn_Click(sender As Object, e As EventArgs) Handles MemberBtn.Click
        Me.Close()
        membership.Show()
    End Sub

    Private Sub EquipmentBtn_Click(sender As Object, e As EventArgs) Handles EquipmentBtn.Click
        Me.Close()
        Equipment.Show()
    End Sub

    Private Sub SupplimentsBtn_Click(sender As Object, e As EventArgs) Handles SupplimentsBtn.Click
        Me.Close()
        Suppliments.Show()
    End Sub

    Private Sub BackLogin_Click(sender As Object, e As EventArgs) Handles BackLogin.Click
        Me.Close()
        loginform.Show()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs)
        countmember()
        countEquipments()
        countSuppliments()
        countTrainers()
    End Sub

    Private Sub TrainerBtn_Click(sender As Object, e As EventArgs) Handles TrainerBtn.Click
        Me.Close()
        Trainer.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countSuppliments()
        countTrainers()
        countEquipments()
        countmember()
    End Sub

End Class