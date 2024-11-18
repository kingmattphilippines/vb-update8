Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ClientForm


    Dim func As New myFunction()
    Dim tableName As String = "clients"

    Private Sub ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientsData()
    End Sub

    Private Sub LoadClientsData()
        Try
            Dim selectClientsQuery As String = "SELECT * FROM " & tableName
            DataGridViewCLIENTS.DataSource = func.getData(selectClientsQuery)
            DataGridViewCLIENTS.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading clients: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
    '    Dim fname As String = TextBoxfNAME.Text.Trim()
    '    Dim lname As String = TextBoxlNAME.Text.Trim()
    '    Dim phone As String = TextBoxPHONE.Text.Trim()
    '    Dim email As String = TextBoxMAIL.Text.Trim()
    '    Dim address As String = TextBoxADDRESS.Text.Trim()

    '    Try
    '        If ValidateFields(fname, lname, phone, address) Then
    '            If New owners_clients().insertPerson(tableName, fname, lname, phone, email, address) Then
    '                MessageBox.Show("The client has been successfully added.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                LoadClientsData()
    '                ButtonCLEAR_FIELDS.PerformClick()
    '            Else
    '                MessageBox.Show("Client not added.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Add Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Dim fname As String = TextBoxfNAME.Text.Trim()
        Dim lname As String = TextBoxlNAME.Text.Trim()
        Dim phone As String = TextBoxPHONE.Text.Trim()
        Dim email As String = TextBoxMAIL.Text.Trim()
        Dim address As String = TextBoxADDRESS.Text.Trim()

        Try
            ' Check if all fields are validated and filled
            If ValidateFields(fname, lname, phone, address) Then

                ' Check for duplicate first and last name
                Dim ownerClientObj As New owners_clients()
                If ownerClientObj.IsNameDuplicate("clients", fname, lname) Then
                    MessageBox.Show("A client with this name already exists. Please use a different name.", "Duplicate Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Exit without adding the client
                End If

                ' If no duplication, proceed with adding the client
                If New owners_clients().insertPerson("clients", fname, lname, phone, email, address) Then
                    MessageBox.Show("The client has been successfully added.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadClientsData()
                    ButtonCLEAR_FIELDS.PerformClick()
                Else
                    MessageBox.Show("Client not added. Please try again.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            ' Display detailed error message in case of any error
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Add Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private ReadOnly Property IsNameDuplicate(fname As String, lname As String) As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Function ValidateFields(fname As String, lname As String, phone As String, address As String) As Boolean
        If String.IsNullOrWhiteSpace(fname) Or String.IsNullOrWhiteSpace(lname) Or String.IsNullOrWhiteSpace(phone) Or String.IsNullOrWhiteSpace(address) Then
            MessageBox.Show("One or more fields are empty.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEDIT.Click
        Dim ownerID As Integer
        If Integer.TryParse(TextBoxID.Text, ownerID) Then
            Dim fname As String = TextBoxfNAME.Text.Trim()
            Dim lname As String = TextBoxlNAME.Text.Trim()
            Dim phone As String = TextBoxPHONE.Text.Trim()
            Dim email As String = TextBoxMAIL.Text.Trim()
            Dim address As String = TextBoxADDRESS.Text.Trim()

            Try
                If ValidateFields(fname, lname, phone, address) Then
                    If New owners_clients().editPerson(tableName, ownerID, fname, lname, phone, email, address) Then
                        MessageBox.Show("The client has been successfully updated.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadClientsData()
                        ButtonCLEAR_FIELDS.PerformClick()
                    Else
                        MessageBox.Show("Client data has not been updated.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Edit Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a valid client to edit.", "Invalid Client ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        Try
            Dim ownerID As Integer
            If Integer.TryParse(TextBoxID.Text, ownerID) Then
                If MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If New owners_clients().deletePerson(tableName, ownerID) Then
                        MessageBox.Show("The client has been successfully deleted.", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadClientsData()
                        ButtonCLEAR_FIELDS.PerformClick()
                    Else
                        MessageBox.Show("Client could not be deleted.", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                MessageBox.Show("Please select a valid client ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Delete Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCLEAR_FIELDS_Click(sender As Object, e As EventArgs) Handles ButtonCLEAR_FIELDS.Click
        TextBoxID.Clear()
        TextBoxfNAME.Clear()
        TextBoxlNAME.Clear()
        TextBoxPHONE.Clear()
        TextBoxMAIL.Clear()
        TextBoxADDRESS.Clear()
    End Sub

    Private Sub DataGridViewCLIENTS_Click(sender As Object, e As EventArgs) Handles DataGridViewCLIENTS.Click
        If DataGridViewCLIENTS.CurrentRow IsNot Nothing Then
            TextBoxID.Text = DataGridViewCLIENTS.CurrentRow.Cells(0).Value.ToString()
            TextBoxfNAME.Text = DataGridViewCLIENTS.CurrentRow.Cells(1).Value.ToString()
            TextBoxlNAME.Text = DataGridViewCLIENTS.CurrentRow.Cells(2).Value.ToString()
            TextBoxPHONE.Text = DataGridViewCLIENTS.CurrentRow.Cells(3).Value.ToString()
            TextBoxMAIL.Text = DataGridViewCLIENTS.CurrentRow.Cells(4).Value.ToString()
            TextBoxADDRESS.Text = DataGridViewCLIENTS.CurrentRow.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class

