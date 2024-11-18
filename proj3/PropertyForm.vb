Imports System.Security.AccessControl

Public Class PropertyForm
    Dim theType As New the_type
    Dim theProperty As New the_property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub



    Private Sub PropertyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display the property types in the combox
        ComboBoxTYPE.DataSource = theType.getAllTypes()
        ComboBoxTYPE.DisplayMember = "name"
        ComboBoxTYPE.ValueMember = "id"
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Try
            Dim type As Integer = ComboBoxTYPE.SelectedValue

            ' Validate ownerId and propertySize inputs
            Dim ownerId As Integer
            If String.IsNullOrWhiteSpace(TextBoxOWNER_ID.Text) OrElse Not Integer.TryParse(TextBoxOWNER_ID.Text, ownerId) Then
                MessageBox.Show("Owner ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim propertySize As Integer
            If String.IsNullOrWhiteSpace(TextBoxSIZE.Text) OrElse Not Integer.TryParse(TextBoxSIZE.Text, propertySize) Then
                MessageBox.Show("Size must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim price As String = TextBoxPRICE.Text
            Dim address As String = TextBoxADDRESS.Text
            Dim comment As String = TextBoxCOMMENTS.Text
            Dim beds As Integer = NumericUpDownBEDS.Value
            Dim baths As Integer = NumericUpDownBATHS.Value
            Dim age As Integer = NumericUpDownAGE.Value
            Dim hasBalcony As Boolean = CheckBoxBALCONY.Checked
            Dim hasBackyard As Boolean = CheckBoxBACKYARD.Checked
            Dim hasGarage As Boolean = CheckBoxGARAGE.Checked
            Dim hasPool As Boolean = CheckBoxPOOL.Checked
            Dim hasFireplace As Boolean = CheckBoxFIREPLACE.Checked
            Dim hasElevator As Boolean = CheckBoxELEVATOR.Checked

            ' Validate inputs
            If String.IsNullOrWhiteSpace(price) OrElse String.IsNullOrWhiteSpace(address) Then
                MessageBox.Show("Price and address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Call addProperty function with all required parameters
            If theProperty.addProperty(type, ownerId, propertySize, price, address, beds, baths, age, hasBalcony, hasBackyard, hasGarage, hasPool, hasFireplace, hasElevator, comment) Then
                MessageBox.Show("Property added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtonCLEARFIELDS.PerformClick() ' Clear fields after adding
            Else
                MessageBox.Show("Failed to add property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEDIT.Click
        Try
            Dim propertyId As Integer
            If String.IsNullOrWhiteSpace(TextBoxID.Text) OrElse Not Integer.TryParse(TextBoxID.Text, propertyId) Then
                MessageBox.Show("Please enter a valid property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim type As Integer = ComboBoxTYPE.SelectedValue

            ' Validate ownerId and propertySize inputs
            Dim ownerId As Integer
            If String.IsNullOrWhiteSpace(TextBoxOWNER_ID.Text) OrElse Not Integer.TryParse(TextBoxOWNER_ID.Text, ownerId) Then
                MessageBox.Show("Owner ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim propertySize As Integer
            If String.IsNullOrWhiteSpace(TextBoxSIZE.Text) OrElse Not Integer.TryParse(TextBoxSIZE.Text, propertySize) Then
                MessageBox.Show("Size must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim price As String = TextBoxPRICE.Text
            Dim address As String = TextBoxADDRESS.Text
            Dim comment As String = TextBoxCOMMENTS.Text
            Dim beds As Integer = NumericUpDownBEDS.Value
            Dim baths As Integer = NumericUpDownBATHS.Value
            Dim age As Integer = NumericUpDownAGE.Value
            Dim hasBalcony As Boolean = CheckBoxBALCONY.Checked
            Dim hasBackyard As Boolean = CheckBoxBACKYARD.Checked
            Dim hasGarage As Boolean = CheckBoxGARAGE.Checked
            Dim hasPool As Boolean = CheckBoxPOOL.Checked
            Dim hasFireplace As Boolean = CheckBoxFIREPLACE.Checked
            Dim hasElevator As Boolean = CheckBoxELEVATOR.Checked
            ButtonCLEARFIELDS.PerformClick() ' Clear fields after removing

            If String.IsNullOrWhiteSpace(price) OrElse String.IsNullOrWhiteSpace(address) Then
                MessageBox.Show("Price and address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If theProperty.editProperty(propertyId, type, ownerId, propertySize, price, address, beds, baths, age, hasBalcony, hasBackyard, hasGarage, hasPool, hasFireplace, hasElevator, comment) Then
                MessageBox.Show("Property updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        Try
            Dim propertyId As Integer
            If String.IsNullOrWhiteSpace(TextBoxID.Text) OrElse Not Integer.TryParse(TextBoxID.Text, propertyId) Then
                MessageBox.Show("Please enter a valid property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Are you sure you want to remove this property?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If theProperty.removeProperty(propertyId) Then
                    MessageBox.Show("Property removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ButtonCLEARFIELDS.PerformClick() ' Clear fields after removing
                Else
                    MessageBox.Show("Failed to remove property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ButtonCLEARFIELDS_Click(sender As Object, e As EventArgs) Handles ButtonCLEARFIELDS.Click
        'button to clear fields 
        TextBoxID.Text = ""
        TextBoxADDRESS.Text = ""
        TextBoxCOMMENTS.Text = ""
        TextBoxOWNER_ID.Text = ""
        TextBoxPRICE.Text = ""
        TextBoxSIZE.Text = ""

        'set the numericUpDown to 0
        NumericUpDownAGE.Value = 0
        NumericUpDownBATHS.Value = 0
        NumericUpDownBEDS.Value = 0

        'set the combobox to the first item
        ComboBoxTYPE.SelectedIndex = 0

        'uncheck all the box
        CheckBoxBALCONY.Checked = False
        CheckBoxBACKYARD.Checked = False
        CheckBoxGARAGE.Checked = False
        CheckBoxFIREPLACE.Checked = False
        CheckBoxPOOL.Checked = False
        CheckBoxELEVATOR.Checked = False


    End Sub

    Private Sub Button_ShowAllProperty_Click(sender As Object, e As EventArgs) Handles Button_ShowAllProperty.Click
        'button to show all property
        Dim propsListF As New PropertyListForm()
        propsListF.Show()

    End Sub

    Private Sub Button_ShowPropertyImage_Click(sender As Object, e As EventArgs) Handles Button_ShowPropertyImage.Click
        ' Button to show property image
        Try
            Dim propertyId As Integer = Convert.ToInt32(TextBoxID.Text)
            Dim sliderf As New PropertyImageSlideForm()
            sliderf.getImages(propertyId)

            sliderf.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Use a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub




    Private Sub ButtonSEARCHOWNER_Click(sender As Object, e As EventArgs) Handles ButtonSEARCHOWNER.Click
        'selected owner
        'open new form to all the user to select an owner
        Try
            Dim ownersListF As New OwnerListForm()
            ownersListF.ShowDialog()

            TextBoxOWNER_ID.Text = ownersListF.DataGridViewOWNERS.CurrentRow.Cells(0).Value.ToString()

        Catch
            'no owner selected

        End Try
    End Sub

    Private Sub ButtonSEARCH_Click(sender As Object, e As EventArgs) Handles ButtonSEARCH.Click
        'search property by id
        'display result if exist
        Try
            Dim id As Integer = Convert.ToInt32(TextBoxID.Text)
            Dim table As DataTable = theProperty.getPropertyById(id)

            If table.Rows.Count > 0 Then
                TextBoxADDRESS.Text = table.Rows(0)("address")
                TextBoxCOMMENTS.Text = table.Rows(0)("comment")
                TextBoxOWNER_ID.Text = table.Rows(0)("owner")
                TextBoxPRICE.Text = table.Rows(0)("price")
                TextBoxSIZE.Text = table.Rows(0)("size")

                NumericUpDownAGE.Value = table.Rows(0)("age")
                NumericUpDownBEDS.Value = table.Rows(0)("beds")
                NumericUpDownBATHS.Value = table.Rows(0)("baths")

                CheckBoxBACKYARD.Checked = table.Rows(0)("backyard")
                CheckBoxBACKYARD.Checked = table.Rows(0)("balcony")
                CheckBoxBACKYARD.Checked = table.Rows(0)("garage")
                CheckBoxBACKYARD.Checked = table.Rows(0)("fireplace")
                CheckBoxBACKYARD.Checked = table.Rows(0)("elevator")
                CheckBoxBACKYARD.Checked = table.Rows(0)("pool")








            Else

                MessageBox.Show("Property does not exist, use another ID", "No Property", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged
    End Sub

    Private Sub TextBoxSIZE_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSIZE.TextChanged
    End Sub

    Private Sub ComboBoxTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTYPE.SelectedIndexChanged
    End Sub

    Private Sub TextBoxOWNER_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOWNER_ID.TextChanged
    End Sub

    Private Sub NumericUpDownAGE_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownAGE.ValueChanged
    End Sub

    Private Sub NumericUpDownBATHS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownBATHS.ValueChanged
    End Sub

    Private Sub NumericUpDownBEDS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownBEDS.ValueChanged
    End Sub

    Private Sub TextBoxCOMMENTS_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCOMMENTS.TextChanged
    End Sub

    Private Sub TextBoxADDRESS_TextChanged(sender As Object, e As EventArgs) Handles TextBoxADDRESS.TextChanged
    End Sub

    Private Sub TextBoxPRICE_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPRICE.TextChanged
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class