Imports System.Data.SqlClient

Public Class membership

    '******<------- Try ------>*****

    Dim con As SqlConnection = New SqlConnection("Data Source=VOSTRO;Initial Catalog=GymManagementSystem;Integrated Security=True")
    Dim dr As SqlDataReader
    Private Sub membersdetails()

        Dim gender As String = ""
        If rbMale.Checked Then
            gender = "Male"
        ElseIf rbFemale.Checked Then
            gender = "Female"
        End If

        Dim paymentstatus As String = ""
        If rbPaymentYes.Checked Then
            paymentstatus = "Yes"
        ElseIf rbPaymentNo.Checked Then
            paymentstatus = "No"
        End If

        '******<------- Try catch block for checking runtime errors during entering data in database ------>*****
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[MembersDetails]
           ([name]
           ,[address]
           ,[DOB]
           ,[gender]
           ,[phoneNo]
           ,[membership_plan]
           ,[paymentstatus])
     VALUES
           ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + dateDOB.Text.ToString() + "', 
            '" + gender + "', '" + txtPhoneNo.Text + "',
            '" + cmbMembershipPlan.SelectedItem.ToString() + "',
            '" + paymentstatus + "'); select scope_identity();")

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member Added into Database !")
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error Occured !")
        End Try
    End Sub


    '******<------- Try catch block for checking runtime errors during loading data in form from database ------>*****

    Public Sub show_data()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [dbo].[MembersDetails]", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("member_id"), dr.Item("name"), dr.Item("address"), dr.Item("DOB"), dr.Item("gender"), dr.Item("phoneNo"),
              dr.Item("membership_plan"), dr.Item("paymentstatus"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub submitMemberDetailsBtn_Click(sender As Object, e As EventArgs) Handles submitMemberDetailsBtn.Click
        If txtName.Text = "" Or txtAddress.Text = "" Or txtPhoneNo.Text.ToString() = "" Or cmbMembershipPlan.Text.ToString() = "" Then
            MessageBox.Show("Please fill all areas of form !")
        Else
            membersdetails()
            txtName.Text = ""
            txtAddress.Text = ""
            txtPhoneNo.Text = ""
            cmbMembershipPlan.Text = ""
        End If
        show_data()
    End Sub

    Private Sub loadDashboardBtn_Click(sender As Object, e As EventArgs) Handles loadDashboardBtn.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub ViewMemberBtn_Click(sender As Object, e As EventArgs) Handles ViewMemberBtn.Click

        MemberControlBox.Visible = True

    End Sub


    '***********<------------  ERROR PROVIDING AND VALIDATION PART FOR INPUT FIELDS ----------->******


    '*****<------- VALIDATION FOR MEMBER NAME textbox -------->*******
    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If String.IsNullOrEmpty(txtName.Text) = True Then
            txtName.Focus()
            ErrorProvider1.SetError(Me.txtName, "Please enter member name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    '*****<------- VALIDATION FOR MEMBER Address textbox -------->*******
    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        If String.IsNullOrEmpty(txtAddress.Text) = True Then
            txtAddress.Focus()
            ErrorProvider2.SetError(Me.txtAddress, "Please enter Address")
        Else
            ErrorProvider2.Clear()
        End If

    End Sub


    '******<-------- VALIDATION FOR membershipPlan ---------->*****
    Private Sub cmbMembershipPlan_DropDown(sender As Object, e As EventArgs) Handles cmbMembershipPlan.DropDown

        If String.IsNullOrEmpty(cmbMembershipPlan.Text) = True Then
            cmbMembershipPlan.Focus()
            ErrorProvider4.SetError(Me.cmbMembershipPlan, "Please choose plan")
        Else
            ErrorProvider4.Clear()
        End If
    End Sub

    '*******<-------- VALIDATION FOR MEMBER PHONE NUMBER ------>*******
    Private Sub txtPhoneNo_Leave(sender As Object, e As EventArgs) Handles txtPhoneNo.Leave
        If String.IsNullOrEmpty(txtPhoneNo.Text) = True Then
            txtPhoneNo.Focus()
            ErrorProvider5.SetError(Me.txtPhoneNo, "Please enter phone number")
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    '*******<-------- DELETING MEMBER FROM DATABSE ------>*******

    Public Sub deleteMember()
        Dim deleteQuery As String
        Try
            con.Open()
            deleteQuery = "DELETE FROM [dbo].[MembersDetails] WHERE member_id = " & txtDeleteMemberId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(deleteQuery, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member with ID " & txtDeleteMemberId.Text & "successfully !")
            txtDeleteMemberId.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    '*******<-------- Member Delete from database ------>*******

    Private Sub BtnDeleteMember_Click(sender As Object, e As EventArgs) Handles BtnDeleteMember.Click
        If txtDeleteMemberId.Text <> "" Then
            deleteMember()
        Else
            MsgBox("Please enter Member ID !")
        End If
    End Sub


    '*******<-------- VALIDATION FOR MEMBER DELETE TEXTBOX ------>*******
    Private Sub txtDeleteMemberId_Leave(sender As Object, e As EventArgs) Handles txtDeleteMemberId.Leave
        If String.IsNullOrEmpty(txtDeleteMemberId.Text) = True Then
            txtDeleteMemberId.Focus()
            ErrorProvider7.SetError(Me.txtDeleteMemberId, "Please enter member ID")
        Else
            ErrorProvider7.Clear()
        End If
    End Sub

    Private Sub membership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_data()
    End Sub

    Private Sub AddEquipBtn_Click(sender As Object, e As EventArgs) Handles AddEquipBtn.Click
        MemberControlBox.Visible = True
    End Sub
End Class