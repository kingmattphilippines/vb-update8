<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        CheckBoxShowPassword = New CheckBox()
        LabelError = New Label()
        PanelPassword = New Panel()
        TextPassword = New TextBox()
        Label4 = New Label()
        btnLogin = New Button()
        PanelUsername = New Panel()
        TextUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        PanelPassword.SuspendLayout()
        PanelUsername.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1134, 744)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CheckBoxShowPassword)
        Panel3.Controls.Add(LabelError)
        Panel3.Controls.Add(PanelPassword)
        Panel3.Controls.Add(btnLogin)
        Panel3.Controls.Add(PanelUsername)
        Panel3.Location = New Point(569, 186)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(565, 490)
        Panel3.TabIndex = 2
        ' 
        ' CheckBoxShowPassword
        ' 
        CheckBoxShowPassword.AutoSize = True
        CheckBoxShowPassword.Location = New Point(95, 337)
        CheckBoxShowPassword.Name = "CheckBoxShowPassword"
        CheckBoxShowPassword.Size = New Size(132, 24)
        CheckBoxShowPassword.TabIndex = 5
        CheckBoxShowPassword.Text = "Show Password"
        CheckBoxShowPassword.UseVisualStyleBackColor = True
        ' 
        ' LabelError
        ' 
        LabelError.BackColor = Color.Azure
        LabelError.ForeColor = Color.Red
        LabelError.Location = New Point(100, 175)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(384, 25)
        LabelError.TabIndex = 4
        LabelError.Text = "Error message here"
        LabelError.TextAlign = ContentAlignment.MiddleCenter
        LabelError.Visible = False
        ' 
        ' PanelPassword
        ' 
        PanelPassword.Controls.Add(TextPassword)
        PanelPassword.Controls.Add(Label4)
        PanelPassword.Location = New Point(3, 216)
        PanelPassword.Name = "PanelPassword"
        PanelPassword.Size = New Size(559, 111)
        PanelPassword.TabIndex = 2
        ' 
        ' TextPassword
        ' 
        TextPassword.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextPassword.Location = New Point(94, 39)
        TextPassword.Multiline = True
        TextPassword.Name = "TextPassword"
        TextPassword.PasswordChar = "*"c
        TextPassword.Size = New Size(387, 66)
        TextPassword.TabIndex = 1
        TextPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(94, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 26)
        Label4.TabIndex = 0
        Label4.Text = "Password:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(97, 393)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(387, 77)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PanelUsername
        ' 
        PanelUsername.Controls.Add(TextUsername)
        PanelUsername.Controls.Add(Label3)
        PanelUsername.Location = New Point(3, 42)
        PanelUsername.Name = "PanelUsername"
        PanelUsername.Size = New Size(559, 111)
        PanelUsername.TabIndex = 0
        ' 
        ' TextUsername
        ' 
        TextUsername.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextUsername.Location = New Point(94, 39)
        TextUsername.Multiline = True
        TextUsername.Name = "TextUsername"
        TextUsername.Size = New Size(387, 66)
        TextUsername.TabIndex = 1
        TextUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(94, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 26)
        Label3.TabIndex = 0
        Label3.Text = "Username:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(576, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(558, 53)
        Label2.TabIndex = 1
        Label2.Text = "USER LOGIN"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(567, 744)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 473)
        Label1.Name = "Label1"
        Label1.Size = New Size(564, 145)
        Label1.TabIndex = 1
        Label1.Text = "Real Estate Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(152, 107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(227, 223)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 680)
        Controls.Add(Panel1)
        Name = "LoginForm"
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        PanelPassword.ResumeLayout(False)
        PanelPassword.PerformLayout()
        PanelUsername.ResumeLayout(False)
        PanelUsername.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents PanelUsername As Panel
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents CheckBoxShowPassword As CheckBox
End Class
