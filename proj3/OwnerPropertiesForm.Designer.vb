<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerPropertiesForm
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
            Button1 = New Button()
            Panel1 = New Panel()
            DataGridViewOWNERPROPERTIES = New DataGridView()
            Label1 = New Label()
            Panel1.SuspendLayout()
            CType(DataGridViewOWNERPROPERTIES, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' Button1
            ' 
            Button1.FlatStyle = FlatStyle.Flat
            Button1.Location = New Point(695, 0)
            Button1.Name = "Button1"
            Button1.Size = New Size(73, 48)
            Button1.TabIndex = 0
            Button1.Text = "X"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' Panel1
            ' 
            Panel1.BackColor = Color.MintCream
            Panel1.Controls.Add(DataGridViewOWNERPROPERTIES)
            Panel1.Location = New Point(12, 65)
            Panel1.Name = "Panel1"
            Panel1.Size = New Size(745, 392)
            Panel1.TabIndex = 1
            ' 
            ' DataGridViewOWNERPROPERTIES
            ' 
            DataGridViewOWNERPROPERTIES.BackgroundColor = SystemColors.ButtonFace
            DataGridViewOWNERPROPERTIES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewOWNERPROPERTIES.Location = New Point(14, 11)
            DataGridViewOWNERPROPERTIES.Name = "DataGridViewOWNERPROPERTIES"
            DataGridViewOWNERPROPERTIES.RowHeadersWidth = 51
            DataGridViewOWNERPROPERTIES.RowTemplate.Height = 29
            DataGridViewOWNERPROPERTIES.Size = New Size(718, 364)
            DataGridViewOWNERPROPERTIES.TabIndex = 0
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
            Label1.ForeColor = SystemColors.Control
            Label1.Location = New Point(12, 9)
            Label1.Name = "Label1"
            Label1.Size = New Size(274, 38)
            Label1.TabIndex = 0
            Label1.Text = "OWNER PROPERTIES"
            ' 
            ' OwnerPropertiesForm
            ' 
            AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.DarkCyan
            ClientSize = New Size(769, 469)
            Controls.Add(Label1)
            Controls.Add(Panel1)
            Controls.Add(Button1)
            FormBorderStyle = FormBorderStyle.None
            Name = "OwnerPropertiesForm"
            Text = "OwnerPropertiesForm"
            Panel1.ResumeLayout(False)
            CType(DataGridViewOWNERPROPERTIES, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Button1 As Button
        Friend WithEvents Panel1 As Panel
        Friend WithEvents DataGridViewOWNERPROPERTIES As DataGridView
        Friend WithEvents Label1 As Label
    End Class
