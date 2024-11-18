Public Class SalesForm

    Dim sales As New sales()
    Dim func As New myFunction()

    ' Define query strings
    Dim queryDisplayProperties As String = "SELECT `id`, `type`, `size`, `price` FROM `the_property`"
    Dim queryDisplayClients As String = "SELECT `id`, `first_name`, `last_name`, `phone` FROM `clients`"
    Private tableName As String ' Change the type to String
    Public Property DataGridViewClients_Properties As Object
    Public Property DateTimePickerSellingDate As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Close the form
        Close()
    End Sub

    Private Sub Sales_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Sales DataGridView with all sales data
        DataGridViewSalesList.DataSource = sales.getAllSales()

        ' Initially show properties data
        DataGridViewShowClients_Properties.DataSource = func.getData(queryDisplayProperties)
        tableName = "properties" ' Set tableName to properties initially
    End Sub

    ' Show clients data in DataGridView
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_ShowClients.Click
        displayData("clients")
    End Sub

    ' Show properties data in DataGridView
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_ShowClientsProperties.Click
        displayData("properties")
    End Sub

    ' Add a new sale (currently not implemented)



    'Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonAddSales.Click
    '    Try
    '        ' Validate and convert input fields
    '        Dim propertyId As Integer
    '        Dim clientId As Integer
    '        Dim sellingPrice As Decimal
    '        Dim sellingDate As Date = DateTimePickerSales.Value

    '        ' Convert property ID
    '        If Not Integer.TryParse(TextBoxPropIdSales.Text, propertyId) Then
    '            MessageBox.Show("Invalid Property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        ' Convert client ID
    '        If Not Integer.TryParse(TextBoxClientIdSales.Text, clientId) Then
    '            MessageBox.Show("Invalid Client ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        ' Convert selling price
    '        If Not Decimal.TryParse(TextBoxSellingPriceSales.Text, sellingPrice) Then
    '            MessageBox.Show("Invalid Selling Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        ' Check if the selling price is not empty
    '        If sellingPrice <= 0 Then
    '            MessageBox.Show("You need to enter a valid Selling Price.", "Empty Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        ' Add sale to the database
    '        If sales.addSale(propertyId, clientId, sellingPrice, sellingDate) Then
    '            MessageBox.Show("New Sale Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            ' Optionally clear the form fields after adding
    '            ButtonCLEAR_FIELDS_Click(sender, e)
    '            ' Refresh the DataGridView to show updated data
    '            DataGridViewSalesList.DataSource = sales.getAllSales()
    '        Else
    '            MessageBox.Show("Sale Not Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Add Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub

    'Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonAddSales.Click
    '    Try
    '        ' Validate input fields
    '        Dim propertyId As Integer
    '        Dim clientId As Integer
    '        Dim sellingPrice As Decimal
    '        Dim sellingDate As Date = DateTimePickerSales.Value

    '        ' Validation methods can be extracted to simplify the flow
    '        If Not ValidateInputs(propertyId, clientId, sellingPrice) Then Exit Sub

    '        ' Proceed to add sale
    '        If sales.addSale(propertyId, clientId, sellingPrice, sellingDate) Then
    '            MessageBox.Show("New Sale Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            ButtonCLEAR_FIELDS_Click(sender, e) ' Clear fields after successful addition
    '            DataGridViewSalesList.DataSource = sales.getAllSales() ' Refresh DataGridView
    '        Else
    '            MessageBox.Show("Sale Not Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Add Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub

    'Private Function ValidateInputs(ByRef propertyId As Integer, ByRef clientId As Integer, ByRef sellingPrice As Decimal) As Boolean
    '    ' Validation logic here, set propertyId, clientId, sellingPrice
    '    ' Return True if valid, otherwise False
    'End Function


    ' Add a new sale
    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonAddSales.Click
        Try
            ' Validate and convert input fields
            Dim propertyId As Integer
            Dim clientId As Integer
            Dim sellingPrice As Decimal
            Dim sellingDate As Date = DateTimePickerSales.Value

            ' Convert property ID
            If Not Integer.TryParse(TextBoxPropIdSales.Text, propertyId) Then
                MessageBox.Show("Invalid Property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Convert client ID
            If Not Integer.TryParse(TextBoxClientIdSales.Text, clientId) Then
                MessageBox.Show("Invalid Client ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Convert selling price
            If Not Decimal.TryParse(TextBoxSellingPriceSales.Text, sellingPrice) Then
                MessageBox.Show("Invalid Selling Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Check if the selling price is not empty
            If sellingPrice <= 0 Then
                MessageBox.Show("You need to enter a valid Selling Price.", "Empty Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Add sale to the database
            If sales.addSale(propertyId, clientId, sellingPrice, sellingDate) Then
                MessageBox.Show("New Sale Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Optionally clear the form fields after adding
                ButtonCLEAR_FIELDS_Click(sender, e)
                ' Refresh the DataGridView to show updated data
                DataGridViewSalesList.DataSource = sales.getAllSales()
            Else
                MessageBox.Show("Sale Not Added Successfully.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub




    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEditSales.Click
        ' Edit Sale logic here

        Try
            ' Validate and convert input fields
            Dim saleId As Integer
            Dim propertyId As Integer
            Dim clientId As Integer
            Dim sellingPrice As Decimal
            Dim sellingDate As Date = DateTimePickerSales.Value

            ' Convert sale ID
            If Not Integer.TryParse(TextBoxIdSales.Text, saleId) Then
                MessageBox.Show("Invalid Sale ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Convert property ID
            If Not Integer.TryParse(TextBoxPropIdSales.Text, propertyId) Then
                MessageBox.Show("Invalid Property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Convert client ID
            If Not Integer.TryParse(TextBoxClientIdSales.Text, clientId) Then
                MessageBox.Show("Invalid Client ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Convert selling price
            If Not Decimal.TryParse(TextBoxSellingPriceSales.Text, sellingPrice) Then
                MessageBox.Show("Invalid Selling Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Check if the selling price is not empty or zero
            If sellingPrice <= 0 Then
                MessageBox.Show("You need to enter a valid Selling Price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Ask for confirmation before updating
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this sale?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                ' If the user clicks "No", cancel the update
                Exit Sub
            End If

            ' Update the sale in the database
            If sales.editSale(saleId, propertyId, clientId, sellingPrice, sellingDate) Then
                MessageBox.Show("Sale Updated Successfully.", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Optionally clear the form fields after updating
                ButtonCLEAR_FIELDS_Click(sender, e)
                ' Refresh the DataGridView to show updated data
                DataGridViewSalesList.DataSource = sales.getAllSales()
            Else
                MessageBox.Show("Sale Not Updated Successfully.", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub




    ' Remove selected sale (currently not implemented)
    'Private Sub ButtonRemoveSales_Click(sender As Object, e As EventArgs) Handles ButtonRemoveSales.Click
    '    ' Remove Sale logic here
    'End Sub
    Private Sub ButtonRemoveSales_Click(sender As Object, e As EventArgs) Handles ButtonRemoveSales.Click
        ' Remove Sale logic here

        Try
            ' Validate and convert sale ID
            Dim saleId As Integer
            If Not Integer.TryParse(TextBoxIdSales.Text, saleId) Then
                MessageBox.Show("Please enter a valid Sale ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Confirm deletion
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this sale?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.No Then
                Exit Sub
            End If

            ' Remove the sale from the database
            If sales.removeSale(saleId) Then
                MessageBox.Show("Sale removed successfully.", "Remove Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Optionally clear the form fields after removing
                ButtonCLEAR_FIELDS_Click(sender, e)
                ' Refresh the DataGridView to show updated data
                DataGridViewSalesList.DataSource = sales.getAllSales()
            Else
                MessageBox.Show("Sale not removed. Please check if the Sale ID exists.", "Remove Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    ' Clear form fields
    Private Sub ButtonCLEAR_FIELDS_Click(sender As Object, e As EventArgs) Handles ButtonClearSales.Click
        TextBoxIdSales.Text = ""
        TextBoxPropIdSales.Text = ""
        TextBoxClientIdSales.Text = ""
        TextBoxSellingPriceSales.Text = ""
        DateTimePickerSales.Value = DateAndTime.Now
    End Sub

    ' Display the selected sale's data in the form fields
    'Private Sub DataGridViewSalesList_Click(sender As Object, e As EventArgs) Handles DataGridViewSalesList.Click



    '    Try
    '        ' Check if a row is selected
    '        If DataGridViewSalesList.SelectedRows.Count > 0 Then
    '            Dim selectedRow As DataGridViewRow = DataGridViewSalesList.SelectedRows(0)

    '            ' Populate the form fields based on the selected row
    '            TextBoxIdSales.Text = selectedRow.Cells("id").Value.ToString()
    '            TextBoxPropIdSales.Text = selectedRow.Cells("Property").Value.ToString()
    '            TextBoxClientIdSales.Text = selectedRow.Cells("Client").Value.ToString()
    '            TextBoxSellingPriceSales.Text = selectedRow.Cells("Price").Value.ToString()
    '            DateTimePickerSales.Value = If(selectedRow.Cells("Date").Value IsNot Nothing, CType(selectedRow.Cells("Date").Value, DateTime), DateAndTime.Now)

    '            ' Disable the Add button when a row is selected
    '            ButtonAddSales.Enabled = False

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    End Try


    'End Sub
    Private Sub DataGridViewSalesList_Click(sender As Object, e As EventArgs) Handles DataGridViewSalesList.Click
        Try
            ' Check if a row is selected
            If DataGridViewSalesList.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridViewSalesList.SelectedRows(0)

                ' Populate the form fields based on the selected row
                TextBoxIdSales.Text = If(selectedRow.Cells("id").Value IsNot Nothing, selectedRow.Cells("id").Value.ToString(), "")
                TextBoxPropIdSales.Text = If(selectedRow.Cells("Property").Value IsNot Nothing, selectedRow.Cells("Property").Value.ToString(), "")
                TextBoxClientIdSales.Text = If(selectedRow.Cells("Client").Value IsNot Nothing, selectedRow.Cells("Client").Value.ToString(), "")
                TextBoxSellingPriceSales.Text = If(selectedRow.Cells("Price").Value IsNot Nothing, selectedRow.Cells("Price").Value.ToString(), "")
                DateTimePickerSales.Value = If(selectedRow.Cells("Date").Value IsNot Nothing, CType(selectedRow.Cells("Date").Value, DateTime), DateAndTime.Now)

                ' Disable the Add button when a row is selected
                ButtonAddSales.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub


    ' Create a function to display data in DataGridView based on the selected table
    Sub displayData(ByVal table As String)
        Select Case table
            Case "clients"
                DataGridViewShowClients_Properties.DataSource = func.getData(queryDisplayClients)
                tableName = "clients" ' Set tableName to clients
            Case "properties"
                DataGridViewShowClients_Properties.DataSource = func.getData(queryDisplayProperties)
                tableName = "properties" ' Set tableName to properties
            Case Else
                MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    ' Handle clicks in the Clients/Properties DataGridView
    '    Private Sub DataGridViewShowClients_Properties_Click(sender As Object, e As EventArgs) Handles DataGridViewShowClients_Properties.Click
    '        Try
    '            ' Check if a row is selected
    '            If DataGridViewShowClients_Properties.SelectedRows.Count > 0 Then
    '                Dim selectedRow As DataGridViewRow = DataGridViewShowClients_Properties.SelectedRows(0)

    '                If tableName.Equals("clients") Then
    '                    ' Display client details
    '                    TextBoxClientIdSales.Text = selectedRow.Cells("id").Value.ToString()
    '                    TextBoxClientFirst.Text = selectedRow.Cells("first_name").Value.ToString()
    '                    TextBoxClientLastName.Text = selectedRow.Cells("last_name").Value.ToString()
    '                    TextBoxClientPhone.Text = selectedRow.Cells("phone").Value.ToString()
    '                ElseIf tableName.Equals("properties") Then
    '                    ' Display property details
    '                    TextBoxPropIdSales.Text = selectedRow.Cells("id").Value.ToString()
    '                    TextBoxPropType.Text = selectedRow.Cells("type").Value.ToString()
    '                    TextBoxPropSize.Text = selectedRow.Cells("size").Value.ToString()
    '                    TextBoxPropPrice.Text = selectedRow.Cells("price").Value.ToString()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        End Try
    '    End Sub

    Private Sub DataGridViewShowClients_Properties_Click(sender As Object, e As EventArgs) Handles DataGridViewShowClients_Properties.Click
        ' Ensure a row is selected in the DataGridView
        If DataGridViewShowClients_Properties.CurrentRow IsNot Nothing Then
            Try
                If tableName.Equals("clients") Then
                    ' Client ID is located in the first column (index 0)
                    TextBoxClientIdSales.Text = DataGridViewShowClients_Properties.CurrentRow.Cells(0).Value.ToString()
                ElseIf tableName.Equals("properties") Then
                    ' Property ID is located in the first column (index 0)
                    TextBoxPropIdSales.Text = DataGridViewShowClients_Properties.CurrentRow.Cells(0).Value.ToString()
                End If

                ' Selling price is located in the fourth column (index 3)
                TextBoxSellingPriceSales.Text = DataGridViewShowClients_Properties.CurrentRow.Cells(3).Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        Else
            MessageBox.Show("No row selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'display properties sold
    Private Sub ButtonSold_Click(sender As Object, e As EventArgs) Handles ButtonSold.Click
        Dim query As String = queryDisplayProperties + " WHERE id IN (SELECT `propertyid` FROM `prop_sale`)"
        DataGridViewShowClients_Properties.DataSource = func.getData(query)
    End Sub

    'display not properties sold
    Private Sub ButtonNotSold_Click(sender As Object, e As EventArgs) Handles ButtonNotSold.Click
        Dim query As String = queryDisplayProperties + " WHERE id NOT IN (SELECT `propertyid` FROM `prop_sale`)"
        DataGridViewShowClients_Properties.DataSource = func.getData(query)
    End Sub
End Class
