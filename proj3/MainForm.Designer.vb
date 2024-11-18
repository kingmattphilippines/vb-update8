<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel1 = New Panel()
        btnHome = New Button()
        Panel4 = New Panel()
        BtnLogout = New Button()
        BtnSale = New Button()
        BtnImage = New Button()
        BtnType = New Button()
        BtnProperty = New Button()
        BtnClient = New Button()
        BtnOwner = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        LabelSales = New Label()
        LabelProperties = New Label()
        LabelClients = New Label()
        LabelOwners = New Label()
        BtnRefresh = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnSale)
        Panel1.Controls.Add(BtnImage)
        Panel1.Controls.Add(BtnType)
        Panel1.Controls.Add(BtnProperty)
        Panel1.Controls.Add(BtnClient)
        Panel1.Controls.Add(BtnOwner)
        Panel1.Location = New Point(-10, 132)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 758)
        Panel1.TabIndex = 0
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnHome.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(45, 64)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(153, 54)
        btnHome.TabIndex = 8
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(17, 6)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(204, 52)
        Panel4.TabIndex = 7
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnLogout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogout.ForeColor = Color.White
        BtnLogout.Location = New Point(45, 690)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(153, 54)
        BtnLogout.TabIndex = 7
        BtnLogout.Text = "LOGOUT"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnSale
        ' 
        BtnSale.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnSale.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSale.ForeColor = Color.White
        BtnSale.Location = New Point(45, 592)
        BtnSale.Name = "BtnSale"
        BtnSale.Size = New Size(153, 54)
        BtnSale.TabIndex = 5
        BtnSale.Text = "SALES"
        BtnSale.UseVisualStyleBackColor = False
        ' 
        ' BtnImage
        ' 
        BtnImage.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnImage.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnImage.ForeColor = Color.White
        BtnImage.Location = New Point(45, 496)
        BtnImage.Name = "BtnImage"
        BtnImage.Size = New Size(153, 54)
        BtnImage.TabIndex = 4
        BtnImage.Text = "IMAGES"
        BtnImage.UseVisualStyleBackColor = False
        ' 
        ' BtnType
        ' 
        BtnType.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnType.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnType.ForeColor = Color.White
        BtnType.Location = New Point(45, 408)
        BtnType.Name = "BtnType"
        BtnType.Size = New Size(153, 54)
        BtnType.TabIndex = 3
        BtnType.Text = "TYPES"
        BtnType.UseVisualStyleBackColor = False
        ' 
        ' BtnProperty
        ' 
        BtnProperty.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnProperty.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnProperty.ForeColor = Color.White
        BtnProperty.Location = New Point(45, 322)
        BtnProperty.Name = "BtnProperty"
        BtnProperty.Size = New Size(153, 54)
        BtnProperty.TabIndex = 2
        BtnProperty.Text = "PROPERTIES"
        BtnProperty.UseVisualStyleBackColor = False
        ' 
        ' BtnClient
        ' 
        BtnClient.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClient.ForeColor = Color.White
        BtnClient.Location = New Point(45, 231)
        BtnClient.Name = "BtnClient"
        BtnClient.Size = New Size(153, 54)
        BtnClient.TabIndex = 1
        BtnClient.Text = "CLIENTS"
        BtnClient.UseVisualStyleBackColor = False
        ' 
        ' BtnOwner
        ' 
        BtnOwner.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnOwner.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnOwner.ForeColor = Color.White
        BtnOwner.Location = New Point(45, 144)
        BtnOwner.Name = "BtnOwner"
        BtnOwner.Size = New Size(153, 54)
        BtnOwner.TabIndex = 0
        BtnOwner.Text = "OWNERS"
        BtnOwner.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(163, 112)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(LabelSales)
        Panel2.Controls.Add(LabelProperties)
        Panel2.Controls.Add(LabelClients)
        Panel2.Controls.Add(LabelOwners)
        Panel2.Location = New Point(265, 140)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(908, 626)
        Panel2.TabIndex = 1
        ' 
        ' LabelSales
        ' 
        LabelSales.BackColor = Color.White
        LabelSales.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelSales.ForeColor = Color.Gray
        LabelSales.Location = New Point(455, 317)
        LabelSales.Name = "LabelSales"
        LabelSales.Size = New Size(453, 301)
        LabelSales.TabIndex = 3
        LabelSales.Text = "1000  Sale(s)"
        LabelSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelProperties
        ' 
        LabelProperties.BackColor = Color.White
        LabelProperties.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelProperties.ForeColor = Color.Gray
        LabelProperties.Location = New Point(0, 317)
        LabelProperties.Name = "LabelProperties"
        LabelProperties.Size = New Size(449, 301)
        LabelProperties.TabIndex = 2
        LabelProperties.Text = "1000  Propertie(s)"
        LabelProperties.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelClients
        ' 
        LabelClients.BackColor = Color.White
        LabelClients.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelClients.ForeColor = Color.Gray
        LabelClients.Location = New Point(455, 0)
        LabelClients.Name = "LabelClients"
        LabelClients.Size = New Size(453, 309)
        LabelClients.TabIndex = 1
        LabelClients.Text = "1000  Client(s)"
        LabelClients.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelOwners
        ' 
        LabelOwners.BackColor = Color.White
        LabelOwners.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelOwners.ForeColor = Color.Gray
        LabelOwners.Location = New Point(0, 0)
        LabelOwners.Name = "LabelOwners"
        LabelOwners.Size = New Size(449, 309)
        LabelOwners.TabIndex = 0
        LabelOwners.Text = "1000  Owner(s)"
        LabelOwners.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        BtnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnRefresh.ForeColor = Color.White
        BtnRefresh.Location = New Point(646, 772)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(153, 54)
        BtnRefresh.TabIndex = 8
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(-5, -11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1190, 145)
        Panel3.TabIndex = 9
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(1185, 890)
        Controls.Add(Panel3)
        Controls.Add(BtnRefresh)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "MainForm"
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSale As Button
    Friend WithEvents BtnImage As Button
    Friend WithEvents BtnType As Button
    Friend WithEvents BtnProperty As Button
    Friend WithEvents BtnClient As Button
    Friend WithEvents BtnOwner As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents LabelSales As Label
    Friend WithEvents LabelProperties As Label
    Friend WithEvents LabelClients As Label
    Friend WithEvents LabelOwners As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnHome As Button
End Class
