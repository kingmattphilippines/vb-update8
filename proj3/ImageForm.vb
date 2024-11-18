Imports System.IO
Imports MySqlConnector

Public Class ImageForm
    Dim func As New myFunction()
    Dim theProperty As New the_property()

    Private Sub PropertyImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the panel in the form and load data
        Dim querySelectTypes As String = "SELECT id, name FROM `prop_type`"
        DataGridViewTypes.DataSource = func.getData(querySelectTypes)

        Dim querySelectProperties As String = "SELECT id, price, address FROM `the_property`"
        DataGridViewProperties.DataSource = func.getData(querySelectProperties)

        ' Load data into the ListBox
        loadListBoxData(0)

        ' Clear selection
        DataGridViewTypes.ClearSelection()
        DataGridViewProperties.ClearSelection()
        ListBox_Images.ClearSelected()

        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        ' Center the menu panel in the form
        Panel_Menu.Location = New Point((ClientSize.Width - Panel_Menu.Width) / 2, Panel_Menu.Location.Y)

        ' Make the left and right panels full height
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - PanelRight.Width, 0)

        ' Position the close button at the upper right
        ButtonClosedImages.Location = New Point(ClientSize.Width - (ButtonClosedImages.Width + 10), 10)
    End Sub

    Private Sub loadListBoxData(ByVal propertyId As Integer)
        Try
            Dim querySelectImages As String

            If propertyId = 0 Then
                ' Get all images if propertyId is 0
                querySelectImages = "SELECT id FROM `prop_images`"
                ListBox_Images.DataSource = func.getData(querySelectImages)
            Else
                ' Get images for the selected property
                Dim command As New MySqlCommand("SELECT id FROM `prop_images` WHERE `propertyId`=@propId")
                command.Parameters.AddWithValue("@propId", propertyId)
                ListBox_Images.DataSource = func.getDataUsingCommand(command)
            End If

            ListBox_Images.DisplayMember = "id"
            ListBox_Images.ValueMember = "id"
            ListBox_Images.ClearSelected()
        Catch ex As Exception
            MessageBox.Show("Failed to load image data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_SelectImage_Click(sender As Object, e As EventArgs) Handles Button_SelectImages.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox_PropImage.Image = Image.FromFile(opf.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Try
            If PictureBox_PropImage.Image Is Nothing Then
                MessageBox.Show("You need to select an image first.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim propertyId As Integer = Convert.ToInt32(DataGridViewProperties.CurrentRow.Cells(0).Value.ToString())

            Using pic As New MemoryStream()
                PictureBox_PropImage.Image.Save(pic, PictureBox_PropImage.Image.RawFormat)
                pic.Position = 0

                If theProperty.addImage(propertyId, pic) Then
                    MessageBox.Show("New property image added successfully.", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadListBoxData(propertyId)
                Else
                    MessageBox.Show("Image not added to this property.", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Add Image Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        If ListBox_Images.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an image to remove.", "Select Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim imageId As Integer = Convert.ToInt32(ListBox_Images.SelectedValue)

        If MessageBox.Show("Are you sure you want to remove this image?", "Delete Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If theProperty.removeImage(imageId) Then
                MessageBox.Show("Image removed successfully.", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadListBoxData(0)
                PictureBox_PropImage.Image = Nothing
            Else
                MessageBox.Show("Image not removed.", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ListBox_Images_Click(sender As Object, e As EventArgs) Handles ListBox_Images.Click
        Try
            Dim imageId As Integer = Convert.ToInt32(ListBox_Images.SelectedValue)
            Dim imageStream As MemoryStream = theProperty.getImageById(imageId)

            If imageStream IsNot Nothing AndAlso imageStream.Length > 0 Then
                PictureBox_PropImage.Image = Image.FromStream(imageStream)
            Else
                MessageBox.Show("No image found or failed to load.", "Load Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the image: " & ex.Message, "Load Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewTypes_Click(sender As Object, e As EventArgs) Handles DataGridViewTypes.Click
        Try
            If DataGridViewTypes.CurrentRow IsNot Nothing Then
                Dim typeId As Integer = Convert.ToInt32(DataGridViewTypes.CurrentRow.Cells(0).Value)
                Dim command As New MySqlCommand("SELECT id, price, address FROM `the_property` WHERE `type` = @tp")
                command.Parameters.AddWithValue("@tp", typeId)
                DataGridViewProperties.DataSource = func.getDataUsingCommand(command)
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving properties: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewProperties_Click(sender As Object, e As EventArgs) Handles DataGridViewProperties.Click
        Try
            ' when we click on a property from this datagridview we need to display the images list

            Dim propertyId As Integer = Convert.ToInt32(DataGridViewProperties.CurrentRow.Cells(0).Value)
            loadListBoxData(propertyId)


        Catch

            'click on an empty datagridview
            'clear the listbox


        End Try

    End Sub

    Private Sub ButtonClosedImages_Click(sender As Object, e As EventArgs) Handles ButtonClosedImages.Click
        Close()
    End Sub

    ' Button to show property images in a new form like a slideshow
    Private Sub Button_ShowAllProperties_Click(sender As Object, e As EventArgs) Handles Button_ShowAllProperties.Click
        Dim propertyId As Integer = Convert.ToInt32(DataGridViewProperties.CurrentRow.Cells(0).Value)
        Dim sliderf As New PropertyImageSlideForm()
        sliderf.getImages(propertyId)

        sliderf.ShowDialog()
    End Sub

    ' Refresh button to reload all data
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        ' Reload the DataGridView and ListBox data
        PropertyImageForm_Load(sender, e)
        MessageBox.Show("Data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
