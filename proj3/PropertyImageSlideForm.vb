Imports System.IO

Public Class PropertyImageSlideForm
    ' Create a DataTable to store the images
    Dim images As New DataTable()

    ' Create a variable for the image position
    Dim position As Integer = 0

    Dim theProperty As New the_property()

    ' Load event to initialize the form
    Private Sub PropertyImageSliderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally, set the form to the desired size
        'Me.Size = New Size(800, 600) ' Match the PropertyImageForm size
        'Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' Close the form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    ' Create a function to display the images
    Sub getImages(ByVal propertyId As Integer)
        Try
            images = theProperty.getpropertyImages(propertyId)

            If images.Rows.Count > 0 Then
                ' Display the first image
                displayImage(position)

                Label_ImagesCount.Text = "* " + images.Rows.Count.ToString() + " Images(s)"
            Else
                MessageBox.Show("No images found for this property.", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PictureBox_PropImage.Image = Nothing
            End If
        Catch
        End Try
    End Sub

    ' Create a sub to display the image
    Public Sub displayImage(ByVal index As Integer)
        Try
            If images.Rows.Count > 0 Then
                PictureBox_PropImage.Image = Image.FromStream(New MemoryStream(CType(images.Rows(index)("prop_image"), Byte())))
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while displaying the image: " & ex.Message, "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Navigate to the next image
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles Button_Next.Click, Button_Next.MouseHover
        If position < images.Rows.Count - 1 Then
            position += 1
            displayImage(position)
        Else
            MessageBox.Show("You have reached the last image.", "End of Slideshow", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Navigate to the previous image
    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        If position > 0 Then
            position -= 1
            displayImage(position)
        Else
            MessageBox.Show("You are at the first image.", "Start of Slideshow", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
