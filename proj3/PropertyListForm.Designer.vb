<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyListForm
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
        DataGridViewPROPERTIES = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridViewPROPERTIES, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(DataGridViewPROPERTIES)
        Panel1.Location = New Point(19, 76)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(998, 486)
        Panel1.TabIndex = 7
        ' 
        ' DataGridViewPROPERTIES
        ' 
        DataGridViewPROPERTIES.AllowUserToAddRows = False
        DataGridViewPROPERTIES.BackgroundColor = Color.White
        DataGridViewPROPERTIES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPROPERTIES.Location = New Point(23, 44)
        DataGridViewPROPERTIES.Margin = New Padding(2, 2, 2, 2)
        DataGridViewPROPERTIES.Name = "DataGridViewPROPERTIES"
        DataGridViewPROPERTIES.RowHeadersWidth = 62
        DataGridViewPROPERTIES.Size = New Size(954, 414)
        DataGridViewPROPERTIES.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(78, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(495, 61)
        Label1.TabIndex = 6
        Label1.Text = "PROPERTIES LIST"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1002, 0)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 33)
        Button1.TabIndex = 8
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PropertyListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1039, 598)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "PropertyListForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertiesList_Form"
        Panel1.ResumeLayout(False)
        CType(DataGridViewPROPERTIES, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewPROPERTIES As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class

