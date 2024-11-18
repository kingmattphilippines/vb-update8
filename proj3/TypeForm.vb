Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TypeForm



    Dim theType As New the_type()

    Private Sub PropertyTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display data from listboxtype
        RefreshListBox()



    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Dim name As String = TextBoxNAME.Text
        Dim description As String = TextBoxDESCRIPTION.Text

        If name.Trim().Equals("") Then
            MessageBox.Show("You need to enter name first", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf theType.addType(name, description) Then
            MessageBox.Show("New type added successfully", "Add Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshListBox()
            ButtonCLEARFIELDS.PerformClick() ' Clear fields after adding
        Else
            MessageBox.Show("Type not added", "Add Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEDIT.Click
        Try
            Dim id As Integer = Convert.ToInt32(TextBoxID.Text)
            Dim name As String = TextBoxNAME.Text
            Dim description As String = TextBoxDESCRIPTION.Text

            If name.Trim().Equals("") Then
                MessageBox.Show("You need to enter name first", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf theType.editType(id, name, description) Then
                MessageBox.Show("The selected type has been updated successfully", "Edit Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshListBox()
                ButtonCLEARFIELDS.PerformClick() ' Clear fields after editing
            Else
                MessageBox.Show("Type not updated", "Edit Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch
            MessageBox.Show("Select type you want to edit", "Edit type error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        Try
            Dim id As Integer = Convert.ToInt32(TextBoxID.Text)
            If MessageBox.Show("Are you sure you want to delete this type?", "Delete Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If theType.deleteType(id) Then
                    MessageBox.Show("The selected type has been deleted successfully", "Delete Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshListBox()
                    ButtonCLEARFIELDS.PerformClick() ' Clear fields after removing
                Else
                    MessageBox.Show("Type not deleted", "Delete Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch
            MessageBox.Show("Select type you want to delete", "Delete type error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCLEARFIELDS_Click(sender As Object, e As EventArgs) Handles ButtonCLEARFIELDS.Click
        TextBoxID.Text = ""
        TextBoxNAME.Text = ""
        TextBoxDESCRIPTION.Text = ""
    End Sub

    Private Sub RefreshListBox()
        ListBoxTypes.DataSource = theType.getAllTypes()
        ListBoxTypes.DisplayMember = "name"
        ListBoxTypes.ValueMember = "id"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ListBoxTypes_Click(sender As Object, e As EventArgs) Handles ListBoxTypes.Click
        ' Display the selected property type from the list to textboxes
        Dim selectedRow As DataRowView = CType(ListBoxTypes.SelectedItem, DataRowView)
        If selectedRow IsNot Nothing Then
            TextBoxID.Text = selectedRow("id").ToString()
            TextBoxNAME.Text = selectedRow("name").ToString()
            TextBoxDESCRIPTION.Text = selectedRow("description").ToString()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

