<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        ButtonSold = New Button()
        ButtonNotSold = New Button()
        Button_ShowClientsProperties = New Button()
        Button_ShowClients = New Button()
        DataGridViewShowClients_Properties = New DataGridView()
        Label8 = New Label()
        DateTimePickerSales = New DateTimePicker()
        ButtonClearSales = New Button()
        ButtonRemoveSales = New Button()
        ButtonEditSales = New Button()
        ButtonAddSales = New Button()
        DataGridViewSalesList = New DataGridView()
        Label6 = New Label()
        TextBoxSellingPriceSales = New TextBox()
        Label5 = New Label()
        TextBoxClientIdSales = New TextBox()
        Label4 = New Label()
        TextBoxPropIdSales = New TextBox()
        Label3 = New Label()
        TextBoxIdSales = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridViewShowClients_Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewSalesList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumAquamarine
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(31, 10)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1142, 775)
        Panel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1104, 2)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 35)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(ButtonSold)
        Panel3.Controls.Add(ButtonNotSold)
        Panel3.Controls.Add(Button_ShowClientsProperties)
        Panel3.Controls.Add(Button_ShowClients)
        Panel3.Controls.Add(DataGridViewShowClients_Properties)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(DateTimePickerSales)
        Panel3.Controls.Add(ButtonClearSales)
        Panel3.Controls.Add(ButtonRemoveSales)
        Panel3.Controls.Add(ButtonEditSales)
        Panel3.Controls.Add(ButtonAddSales)
        Panel3.Controls.Add(DataGridViewSalesList)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBoxSellingPriceSales)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxClientIdSales)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxPropIdSales)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxIdSales)
        Panel3.Controls.Add(Label2)
        Panel3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(10, 78)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1130, 695)
        Panel3.TabIndex = 4
        ' 
        ' ButtonSold
        ' 
        ButtonSold.BackColor = Color.Orange
        ButtonSold.ForeColor = Color.White
        ButtonSold.Location = New Point(499, 596)
        ButtonSold.Margin = New Padding(2)
        ButtonSold.Name = "ButtonSold"
        ButtonSold.Size = New Size(293, 58)
        ButtonSold.TabIndex = 23
        ButtonSold.Text = "Sold Properties"
        ButtonSold.UseVisualStyleBackColor = False
        ' 
        ' ButtonNotSold
        ' 
        ButtonNotSold.BackColor = Color.Orange
        ButtonNotSold.ForeColor = Color.White
        ButtonNotSold.Location = New Point(839, 596)
        ButtonNotSold.Margin = New Padding(2)
        ButtonNotSold.Name = "ButtonNotSold"
        ButtonNotSold.Size = New Size(264, 58)
        ButtonNotSold.TabIndex = 22
        ButtonNotSold.Text = "Not Sold Properties"
        ButtonNotSold.UseVisualStyleBackColor = False
        ' 
        ' Button_ShowClientsProperties
        ' 
        Button_ShowClientsProperties.BackColor = Color.Orange
        Button_ShowClientsProperties.ForeColor = Color.White
        Button_ShowClientsProperties.Location = New Point(837, 523)
        Button_ShowClientsProperties.Margin = New Padding(2)
        Button_ShowClientsProperties.Name = "Button_ShowClientsProperties"
        Button_ShowClientsProperties.Size = New Size(266, 58)
        Button_ShowClientsProperties.TabIndex = 21
        Button_ShowClientsProperties.Text = "Show Properties"
        Button_ShowClientsProperties.UseVisualStyleBackColor = False
        ' 
        ' Button_ShowClients
        ' 
        Button_ShowClients.BackColor = Color.Orange
        Button_ShowClients.ForeColor = Color.White
        Button_ShowClients.Location = New Point(499, 523)
        Button_ShowClients.Margin = New Padding(2)
        Button_ShowClients.Name = "Button_ShowClients"
        Button_ShowClients.Size = New Size(293, 58)
        Button_ShowClients.TabIndex = 20
        Button_ShowClients.Text = "Show Clients"
        Button_ShowClients.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewShowClients_Properties
        ' 
        DataGridViewShowClients_Properties.BackgroundColor = SystemColors.ControlLight
        DataGridViewShowClients_Properties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewShowClients_Properties.Location = New Point(499, 298)
        DataGridViewShowClients_Properties.Margin = New Padding(2)
        DataGridViewShowClients_Properties.Name = "DataGridViewShowClients_Properties"
        DataGridViewShowClients_Properties.RowHeadersWidth = 62
        DataGridViewShowClients_Properties.Size = New Size(604, 209)
        DataGridViewShowClients_Properties.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.Location = New Point(499, 18)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 18
        Label8.Text = "Sales List"
        ' 
        ' DateTimePickerSales
        ' 
        DateTimePickerSales.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePickerSales.Location = New Point(161, 309)
        DateTimePickerSales.Margin = New Padding(2)
        DateTimePickerSales.Name = "DateTimePickerSales"
        DateTimePickerSales.Size = New Size(285, 43)
        DateTimePickerSales.TabIndex = 17
        ' 
        ' ButtonClearSales
        ' 
        ButtonClearSales.BackColor = Color.Gold
        ButtonClearSales.ForeColor = Color.Black
        ButtonClearSales.Location = New Point(62, 523)
        ButtonClearSales.Margin = New Padding(2)
        ButtonClearSales.Name = "ButtonClearSales"
        ButtonClearSales.Size = New Size(384, 58)
        ButtonClearSales.TabIndex = 16
        ButtonClearSales.Text = "Clear Fields"
        ButtonClearSales.UseVisualStyleBackColor = False
        ' 
        ' ButtonRemoveSales
        ' 
        ButtonRemoveSales.BackColor = Color.Red
        ButtonRemoveSales.ForeColor = Color.White
        ButtonRemoveSales.Location = New Point(62, 457)
        ButtonRemoveSales.Margin = New Padding(2)
        ButtonRemoveSales.Name = "ButtonRemoveSales"
        ButtonRemoveSales.Size = New Size(384, 50)
        ButtonRemoveSales.TabIndex = 15
        ButtonRemoveSales.Text = "REMOVE"
        ButtonRemoveSales.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditSales
        ' 
        ButtonEditSales.BackColor = Color.DeepSkyBlue
        ButtonEditSales.ForeColor = Color.White
        ButtonEditSales.Location = New Point(281, 389)
        ButtonEditSales.Margin = New Padding(2)
        ButtonEditSales.Name = "ButtonEditSales"
        ButtonEditSales.Size = New Size(165, 50)
        ButtonEditSales.TabIndex = 14
        ButtonEditSales.Text = "EDIT"
        ButtonEditSales.UseVisualStyleBackColor = False
        ' 
        ' ButtonAddSales
        ' 
        ButtonAddSales.BackColor = Color.YellowGreen
        ButtonAddSales.ForeColor = Color.White
        ButtonAddSales.Location = New Point(62, 389)
        ButtonAddSales.Margin = New Padding(2)
        ButtonAddSales.Name = "ButtonAddSales"
        ButtonAddSales.Size = New Size(187, 50)
        ButtonAddSales.TabIndex = 13
        ButtonAddSales.Text = "ADD"
        ButtonAddSales.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewSalesList
        ' 
        DataGridViewSalesList.BackgroundColor = SystemColors.ControlLight
        DataGridViewSalesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewSalesList.Location = New Point(499, 41)
        DataGridViewSalesList.Margin = New Padding(2)
        DataGridViewSalesList.Name = "DataGridViewSalesList"
        DataGridViewSalesList.RowHeadersWidth = 62
        DataGridViewSalesList.Size = New Size(604, 216)
        DataGridViewSalesList.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 316)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 32)
        Label6.TabIndex = 8
        Label6.Text = "Date:"
        ' 
        ' TextBoxSellingPriceSales
        ' 
        TextBoxSellingPriceSales.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSellingPriceSales.Location = New Point(205, 253)
        TextBoxSellingPriceSales.Margin = New Padding(2)
        TextBoxSellingPriceSales.Name = "TextBoxSellingPriceSales"
        TextBoxSellingPriceSales.Size = New Size(241, 43)
        TextBoxSellingPriceSales.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(15, 260)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 32)
        Label5.TabIndex = 6
        Label5.Text = "Selling Price:"
        ' 
        ' TextBoxClientIdSales
        ' 
        TextBoxClientIdSales.BackColor = SystemColors.AppWorkspace
        TextBoxClientIdSales.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxClientIdSales.Location = New Point(205, 182)
        TextBoxClientIdSales.Margin = New Padding(2)
        TextBoxClientIdSales.Name = "TextBoxClientIdSales"
        TextBoxClientIdSales.ReadOnly = True
        TextBoxClientIdSales.Size = New Size(241, 43)
        TextBoxClientIdSales.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 193)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 32)
        Label4.TabIndex = 4
        Label4.Text = "Client ID:"
        ' 
        ' TextBoxPropIdSales
        ' 
        TextBoxPropIdSales.BackColor = SystemColors.AppWorkspace
        TextBoxPropIdSales.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPropIdSales.Location = New Point(205, 113)
        TextBoxPropIdSales.Margin = New Padding(2)
        TextBoxPropIdSales.Name = "TextBoxPropIdSales"
        TextBoxPropIdSales.ReadOnly = True
        TextBoxPropIdSales.Size = New Size(241, 43)
        TextBoxPropIdSales.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 124)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 32)
        Label3.TabIndex = 2
        Label3.Text = "Properties ID:"
        ' 
        ' TextBoxIdSales
        ' 
        TextBoxIdSales.BackColor = SystemColors.AppWorkspace
        TextBoxIdSales.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxIdSales.Location = New Point(205, 41)
        TextBoxIdSales.Margin = New Padding(2)
        TextBoxIdSales.Name = "TextBoxIdSales"
        TextBoxIdSales.ReadOnly = True
        TextBoxIdSales.Size = New Size(241, 43)
        TextBoxIdSales.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 48)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 38)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(10, 66)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1130, 8)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(106, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 61)
        Label1.TabIndex = 1
        Label1.Text = "SALES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(10, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' SalesForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumAquamarine
        ClientSize = New Size(1184, 796)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "SalesForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales_Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewShowClients_Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewSalesList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonClearSales As Button
    Friend WithEvents ButtonRemoveSales As Button
    Friend WithEvents ButtonEditSales As Button
    Friend WithEvents ButtonAddSales As Button
    Friend WithEvents DataGridViewSalesList As DataGridView
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSellingPriceSales As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxClientIdSales As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPropIdSales As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIdSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePickerSales As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_ShowClientsProperties As Button
    Friend WithEvents Button_ShowClients As Button
    Friend WithEvents DataGridViewShowClients_Properties As DataGridView
    Friend WithEvents ButtonSold As Button
    Friend WithEvents ButtonNotSold As Button
End Class

