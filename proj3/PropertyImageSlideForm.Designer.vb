<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyImageSlideForm
    Inherits System.Windows.Forms.Form



    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel3 = New Panel()
        Label_ImagesCount = New Label()
        Button_Previous = New Button()
        Button_Next = New Button()
        PictureBox_PropImage = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Panel3.SuspendLayout()
        CType(PictureBox_PropImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel3.Controls.Add(Label_ImagesCount)
        Panel3.Controls.Add(Button_Previous)
        Panel3.Controls.Add(Button_Next)
        Panel3.Controls.Add(PictureBox_PropImage)
        Panel3.Location = New Point(11, 66)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(792, 456)
        Panel3.TabIndex = 5
        ' 
        ' Label_ImagesCount
        ' 
        Label_ImagesCount.Font = New Font("Microsoft PhagsPa", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label_ImagesCount.Location = New Point(130, 404)
        Label_ImagesCount.Margin = New Padding(2, 0, 2, 0)
        Label_ImagesCount.Name = "Label_ImagesCount"
        Label_ImagesCount.Size = New Size(178, 41)
        Label_ImagesCount.TabIndex = 24
        Label_ImagesCount.Text = "* 100 IMAGES"
        Label_ImagesCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_Previous
        ' 
        Button_Previous.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button_Previous.FlatStyle = FlatStyle.Flat
        Button_Previous.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Previous.Location = New Point(3, 69)
        Button_Previous.Name = "Button_Previous"
        Button_Previous.Size = New Size(121, 332)
        Button_Previous.TabIndex = 23
        Button_Previous.Text = "Previous"
        Button_Previous.UseVisualStyleBackColor = True
        ' 
        ' Button_Next
        ' 
        Button_Next.Cursor = Cursors.IBeam
        Button_Next.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button_Next.FlatStyle = FlatStyle.Flat
        Button_Next.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Next.Location = New Point(665, 69)
        Button_Next.Name = "Button_Next"
        Button_Next.RightToLeft = RightToLeft.Yes
        Button_Next.Size = New Size(120, 332)
        Button_Next.TabIndex = 22
        Button_Next.Text = "Next"
        Button_Next.UseVisualStyleBackColor = True
        ' 
        ' PictureBox_PropImage
        ' 
        PictureBox_PropImage.BackColor = Color.FloralWhite
        PictureBox_PropImage.Location = New Point(130, 69)
        PictureBox_PropImage.Name = "PictureBox_PropImage"
        PictureBox_PropImage.Size = New Size(538, 332)
        PictureBox_PropImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_PropImage.TabIndex = 21
        PictureBox_PropImage.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(548, 55)
        Label1.TabIndex = 6
        Label1.Text = "SLIDER"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(756, -2)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 31)
        Button1.TabIndex = 25
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PropertyImageSlideForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(814, 532)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyImageSlideForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyImageSliderForm"
        Panel3.ResumeLayout(False)
        CType(PictureBox_PropImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents Panel3 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents Button_Previous As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents PictureBox_PropImage As PictureBox
    Private WithEvents Label_ImagesCount As Label
    Friend WithEvents Button1 As Button
End Class
