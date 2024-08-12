Imports System.Data.SqlClient
Public Class Equipment
    Dim con As SqlConnection = New SqlConnection("Data Source=VOSTRO;Initial Catalog=GymManagementSystem;Integrated Security=True")
    Dim dr As SqlDataReader

    Private Sub Equipments()

        Dim status As String = ""
        If rbEqipYes.Checked Then
            status = "Yes"
        ElseIf rbEqipNo.Checked Then
            status = "No"

        End If

        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[EquipmentDetails]
            ([EquipmentName]
           ,[EquipmentPrice]
           ,[EquipAvailableStatus]
           ,[EquipmentWeight])
     VALUES
           ('" + txtEquipName.Text + "', '" + txtEquipPrice.Text + "', '" + status + "', 
            '" + txtEquipWeight.Text + "'); select scope_identity();")
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Equipments details added !")
            con.Close()
            show_equip()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub show_equip()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [dbo].[EquipmentDetails]", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Equipment_id"), dr.Item("EquipmentName"), dr.Item("EquipmentPrice"), dr.Item("EquipAvailableStatus"),
             dr.Item("EquipmentWeight"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    '*****<------- Deleting equipment detail from database -------->*******
    Public Sub deleteEquip()
        Dim deleteEquip As String
        Try
            con.Open()
            deleteEquip = "DELETE FROM [dbo].[EquipmentDetails] WHERE Equipment_id = " & txtDeleteEquipment.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(deleteEquip, con)
            cmd.ExecuteNonQuery()
            MsgBox("Equipment with ID" & txtDeleteEquipment.Text & "removed successfully !")
            txtDeleteEquipment.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub EquipSubmitBtn_Click(sender As Object, e As EventArgs) Handles EquipSubmitBtn.Click
        If txtEquipName.Text = "" Or txtEquipPrice.Text = "" Or txtEquipWeight.Text = "" Then
            MessageBox.Show("Please fill all areas of form !")
        Else
            Equipments()
        End If
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub ViewTotalEquip_Click(sender As Object, e As EventArgs) Handles ViewTotalEquip.Click
        EquipDetailsBox.Visible = True
    End Sub

    Private Sub AddEquipBtn_Click(sender As Object, e As EventArgs) Handles AddEquipBtn.Click
        EquipDetailsBox.Visible = True
    End Sub


    '*****<------- VALIDATION FOR Equipment NAME textbox -------->*******
    Private Sub txtEquipName_Leave(sender As Object, e As EventArgs) Handles txtEquipName.Leave
        If String.IsNullOrEmpty(txtEquipName.Text) = True Then
            txtEquipName.Focus()
            ErrorProvider1.SetError(Me.txtEquipName, "Please enter Equipment name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub


    '*****<------- VALIDATION FOR Equipment Price textbox -------->*******
    Private Sub txtEquipPrice_Leave(sender As Object, e As EventArgs) Handles txtEquipPrice.Leave
        If String.IsNullOrEmpty(txtEquipPrice.Text) = True Then
            txtEquipPrice.Focus()
            ErrorProvider2.SetError(Me.txtEquipPrice, "Please enter Equipment name")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub


    '*****<------- VALIDATION FOR Equipment Weight textbox -------->*******
    Private Sub txtEquipWeight_TextChanged(sender As Object, e As EventArgs) Handles txtEquipWeight.TextChanged
        If String.IsNullOrEmpty(txtEquipWeight.Text) = True Then
            txtEquipWeight.Focus()
            ErrorProvider3.SetError(Me.txtEquipWeight, "Please enter Equipment name")
        Else
            ErrorProvider3.Clear()
        End If
    End Sub

    Private Sub txtDeleteEquipment_Leave(sender As Object, e As EventArgs) Handles txtDeleteEquipment.Leave
        If String.IsNullOrEmpty(txtDeleteEquipment.Text) = True Then
            txtDeleteEquipment.Focus()
            ErrorProvider5.SetError(Me.txtDeleteEquipment, "Please enter Equipment Id !")
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    Private Sub BtnDeleteEquipment_Click(sender As Object, e As EventArgs) Handles BtnDeleteEquipment.Click
        If txtDeleteEquipment.Text <> "" Then
            deleteEquip()
        Else
            MsgBox("Please enter Equipment Id!")

        End If
    End Sub

    Private Sub Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_equip()
    End Sub
End Class