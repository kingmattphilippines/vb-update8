<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageForm
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
        Panel_Menu = New Panel()
        ButtonClosedImages = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        ButtonRefresh = New Button()
        Button_ShowAllProperties = New Button()
        DataGridViewTypes = New DataGridView()
        DataGridViewProperties = New DataGridView()
        ListBox_Images = New ListBox()
        ButtonREMOVE = New Button()
        PictureBox_PropImage = New PictureBox()
        btnAddImage = New Button()
        Button_SelectImages = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        MySqlCommandBuilder1 = New MySqlConnector.MySqlCommandBuilder()
        PanelLeft = New Panel()
        PanelRight = New Panel()
        Panel_Menu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DataGridViewTypes, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_PropImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.LightPink
        Panel_Menu.Controls.Add(ButtonClosedImages)
        Panel_Menu.Controls.Add(PictureBox1)
        Panel_Menu.Controls.Add(Panel2)
        Panel_Menu.Controls.Add(Label1)
        Panel_Menu.Location = New Point(-4, 0)
        Panel_Menu.Margin = New Padding(2)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(1195, 829)
        Panel_Menu.TabIndex = 3
        ' 
        ' ButtonClosedImages
        ' 
        ButtonClosedImages.FlatStyle = FlatStyle.Flat
        ButtonClosedImages.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonClosedImages.ForeColor = Color.White
        ButtonClosedImages.Location = New Point(1115, 0)
        ButtonClosedImages.Name = "ButtonClosedImages"
        ButtonClosedImages.Size = New Size(72, 41)
        ButtonClosedImages.TabIndex = 4
        ButtonClosedImages.Text = "X"
        ButtonClosedImages.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(11, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(11, 72)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1172, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(155, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(548, 61)
        Label1.TabIndex = 1
        Label1.Text = "PROPERTY IMAGES"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(ButtonRefresh)
        Panel3.Controls.Add(Button_ShowAllProperties)
        Panel3.Controls.Add(DataGridViewTypes)
        Panel3.Controls.Add(DataGridViewProperties)
        Panel3.Controls.Add(ListBox_Images)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(PictureBox_PropImage)
        Panel3.Controls.Add(btnAddImage)
        Panel3.Controls.Add(Button_SelectImages)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(11, 97)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1172, 640)
        Panel3.TabIndex = 4
        ' 
        ' ButtonRefresh
        ' 
        ButtonRefresh.BackColor = Color.Turquoise
        ButtonRefresh.Location = New Point(29, 581)
        ButtonRefresh.Name = "ButtonRefresh"
        ButtonRefresh.Size = New Size(250, 37)
        ButtonRefresh.TabIndex = 26
        ButtonRefresh.Text = "Refresh All"
        ButtonRefresh.UseVisualStyleBackColor = False
        ' 
        ' Button_ShowAllProperties
        ' 
        Button_ShowAllProperties.BackColor = Color.Turquoise
        Button_ShowAllProperties.Location = New Point(311, 582)
        Button_ShowAllProperties.Name = "Button_ShowAllProperties"
        Button_ShowAllProperties.Size = New Size(356, 37)
        Button_ShowAllProperties.TabIndex = 25
        Button_ShowAllProperties.Text = "Show this Property Images"
        Button_ShowAllProperties.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewTypes
        ' 
        DataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTypes.Location = New Point(29, 72)
        DataGridViewTypes.Name = "DataGridViewTypes"
        DataGridViewTypes.RowHeadersWidth = 51
        DataGridViewTypes.RowTemplate.Height = 29
        DataGridViewTypes.Size = New Size(250, 503)
        DataGridViewTypes.TabIndex = 24
        ' 
        ' DataGridViewProperties
        ' 
        DataGridViewProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProperties.Location = New Point(311, 72)
        DataGridViewProperties.Name = "DataGridViewProperties"
        DataGridViewProperties.RowHeadersWidth = 51
        DataGridViewProperties.RowTemplate.Height = 29
        DataGridViewProperties.Size = New Size(356, 503)
        DataGridViewProperties.TabIndex = 23
        ' 
        ' ListBox_Images
        ' 
        ListBox_Images.FormattingEnabled = True
        ListBox_Images.ItemHeight = 20
        ListBox_Images.Location = New Point(691, 72)
        ListBox_Images.Name = "ListBox_Images"
        ListBox_Images.Size = New Size(82, 504)
        ListBox_Images.TabIndex = 22
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(691, 579)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(82, 40)
        ButtonREMOVE.TabIndex = 21
        ButtonREMOVE.Text = "Remove"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' PictureBox_PropImage
        ' 
        PictureBox_PropImage.BackColor = Color.FloralWhite
        PictureBox_PropImage.Location = New Point(801, 72)
        PictureBox_PropImage.Name = "PictureBox_PropImage"
        PictureBox_PropImage.Size = New Size(360, 449)
        PictureBox_PropImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_PropImage.TabIndex = 20
        PictureBox_PropImage.TabStop = False
        ' 
        ' btnAddImage
        ' 
        btnAddImage.BackColor = Color.YellowGreen
        btnAddImage.ForeColor = Color.White
        btnAddImage.Location = New Point(802, 582)
        btnAddImage.Margin = New Padding(2)
        btnAddImage.Name = "btnAddImage"
        btnAddImage.Size = New Size(360, 40)
        btnAddImage.TabIndex = 19
        btnAddImage.Text = "Add Image"
        btnAddImage.UseVisualStyleBackColor = False
        ' 
        ' Button_SelectImages
        ' 
        Button_SelectImages.BackColor = Color.YellowGreen
        Button_SelectImages.ForeColor = Color.White
        Button_SelectImages.Location = New Point(802, 535)
        Button_SelectImages.Margin = New Padding(2)
        Button_SelectImages.Name = "Button_SelectImages"
        Button_SelectImages.Size = New Size(360, 40)
        Button_SelectImages.TabIndex = 18
        Button_SelectImages.Text = "Select Image"
        Button_SelectImages.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(678, 40)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 29)
        Label4.TabIndex = 6
        Label4.Text = "IMAGES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(311, 40)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 29)
        Label3.TabIndex = 5
        Label3.Text = "PROPERTIES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 40)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 29)
        Label2.TabIndex = 4
        Label2.Text = "Types"
        ' 
        ' MySqlCommandBuilder1
        ' 
        MySqlCommandBuilder1.ConflictOption = ConflictOption.OverwriteChanges
        MySqlCommandBuilder1.DataAdapter = Nothing
        MySqlCommandBuilder1.QuotePrefix = "`"
        MySqlCommandBuilder1.QuoteSuffix = "`"
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.LavenderBlush
        PanelLeft.Location = New Point(-7, 83)
        PanelLeft.Margin = New Padding(2)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(12, 681)
        PanelLeft.TabIndex = 6
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.LavenderBlush
        PanelRight.Location = New Point(1457, 83)
        PanelRight.Margin = New Padding(2)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(12, 681)
        PanelRight.TabIndex = 7
        ' 
        ' ImageForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(1184, 754)
        Controls.Add(Panel3)
        Controls.Add(PanelRight)
        Controls.Add(PanelLeft)
        Controls.Add(Panel_Menu)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "ImageForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyImages_Form"
        Panel_Menu.ResumeLayout(False)
        Panel_Menu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewTypes, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_PropImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private Panel_Menu As Panel
    Private Panel2 As Panel
    Private Label1 As Label
    Private Panel3 As Panel
    Private MySqlCommandBuilder1 As MySqlConnector.MySqlCommandBuilder
    Private Label4 As Label
    Private Label3 As Label
    Private Label2 As Label
    Private PanelLeft As Panel
    Private PanelRight As Panel
    Private WithEvents Button_SelectImages As Button
    Private WithEvents btnAddImage As Button
    Friend WithEvents PictureBox_PropImage As PictureBox
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents DataGridViewProperties As DataGridView
    Friend WithEvents DataGridViewTypes As DataGridView
    Friend WithEvents ButtonClosedImages As Button
    Private WithEvents Button_Refresh As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Button_ShowAllProperties As Button
End Class

