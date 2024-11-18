<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeForm
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
        ListBoxTypes = New ListBox()
        ButtonCLEARFIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        TextBoxDESCRIPTION = New TextBox()
        Label7 = New Label()
        TextBoxNAME = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(11, 11)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1140, 806)
        Panel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1094, 0)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 35)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel3.Controls.Add(ListBoxTypes)
        Panel3.Controls.Add(ButtonCLEARFIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(TextBoxDESCRIPTION)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxNAME)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(10, 107)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1127, 660)
        Panel3.TabIndex = 3
        ' 
        ' ListBoxTypes
        ' 
        ListBoxTypes.FormattingEnabled = True
        ListBoxTypes.ItemHeight = 20
        ListBoxTypes.Location = New Point(538, 33)
        ListBoxTypes.Margin = New Padding(2)
        ListBoxTypes.Name = "ListBoxTypes"
        ListBoxTypes.Size = New Size(550, 584)
        ListBoxTypes.TabIndex = 17
        ' 
        ' ButtonCLEARFIELDS
        ' 
        ButtonCLEARFIELDS.BackColor = Color.Gold
        ButtonCLEARFIELDS.ForeColor = Color.Black
        ButtonCLEARFIELDS.Location = New Point(33, 541)
        ButtonCLEARFIELDS.Margin = New Padding(2)
        ButtonCLEARFIELDS.Name = "ButtonCLEARFIELDS"
        ButtonCLEARFIELDS.Size = New Size(462, 76)
        ButtonCLEARFIELDS.TabIndex = 16
        ButtonCLEARFIELDS.Text = "Clear Fields"
        ButtonCLEARFIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(366, 446)
        ButtonREMOVE.Margin = New Padding(2)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(129, 67)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(201, 446)
        ButtonEDIT.Margin = New Padding(2)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(129, 67)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(33, 446)
        ButtonADD.Margin = New Padding(2)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(129, 67)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' TextBoxDESCRIPTION
        ' 
        TextBoxDESCRIPTION.Location = New Point(201, 292)
        TextBoxDESCRIPTION.Margin = New Padding(2)
        TextBoxDESCRIPTION.Multiline = True
        TextBoxDESCRIPTION.Name = "TextBoxDESCRIPTION"
        TextBoxDESCRIPTION.Size = New Size(294, 103)
        TextBoxDESCRIPTION.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(33, 291)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(164, 38)
        Label7.TabIndex = 10
        Label7.Text = "Description:"
        ' 
        ' TextBoxNAME
        ' 
        TextBoxNAME.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxNAME.Location = New Point(201, 201)
        TextBoxNAME.Margin = New Padding(2)
        TextBoxNAME.Multiline = True
        TextBoxNAME.Name = "TextBoxNAME"
        TextBoxNAME.Size = New Size(294, 53)
        TextBoxNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(73, 201)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 38)
        Label3.TabIndex = 2
        Label3.Text = "Name:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxID.Location = New Point(201, 91)
        TextBoxID.Margin = New Padding(2)
        TextBoxID.Multiline = True
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(294, 55)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(105, 91)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 38)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(10, 85)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1088, 8)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(92, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 61)
        Label1.TabIndex = 1
        Label1.Text = "TYPES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(10, 19)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TypeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1161, 828)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "TypeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyTypeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCLEARFIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents TextBoxDESCRIPTION As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBoxTypes As ListBox
End Class

