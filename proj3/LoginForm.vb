Imports MySqlConnector

Public Class LoginForm

    Dim db As New database()
    Dim func As New myFunction()

    ' Form Load event to set the MaxLength for textboxes
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the maximum length for both textboxes
        TextUsername.MaxLength = 20
        TextPassword.MaxLength = 20

        ' Set the password character to *
        TextPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Hide error message label
        LabelError.Visible = False

        ' Check if the textbox is empty
        If emptyFields() Then
            Dim Username As String = TextUsername.Text.Trim()
            Dim Password As String = TextPassword.Text.Trim()

            Dim query As String = "SELECT COUNT(*) FROM `user` WHERE `username` = @un AND `password` = @pass"

            Using conn As New MySqlConnection(db.getConnection().ConnectionString)
                conn.Open() ' Open the connection
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@un", Username)
                    command.Parameters.AddWithValue("@pass", Password)

                    Try
                        ' Execute the command and get the result
                        Dim rowsCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If rowsCount > 0 Then
                            ' If the user exists
                            Dim mainform As New MainForm()
                            mainform.Show() ' Show the main form
                            mainform.BringToFront() ' Bring the main form to the front
                            Me.Hide() ' Hide the login form
                        Else
                            ' If not exist
                            LabelError.Text = "Wrong Username or Password"
                            LabelError.Visible = True
                        End If
                    Catch ex As Exception
                        ' Handle potential errors
                        MessageBox.Show("An error occurred: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Public Function emptyFields() As Boolean
        ' Set panel colors to default
        PanelUsername.BackColor = Color.White
        PanelPassword.BackColor = Color.White

        Dim Username As String = TextUsername.Text.Trim()
        Dim Password As String = TextPassword.Text.Trim()

        If String.IsNullOrEmpty(Username) AndAlso String.IsNullOrEmpty(Password) Then
            PanelUsername.BackColor = Color.Red
            PanelPassword.BackColor = Color.Red
            Return False
        ElseIf String.IsNullOrEmpty(Username) Then
            PanelUsername.BackColor = Color.Red
            Return False
        ElseIf String.IsNullOrEmpty(Password) Then
            PanelPassword.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        ' Toggle password visibility
        If CheckBoxShowPassword.Checked Then
            TextPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            TextPassword.PasswordChar = "*"c ' Hide password with *
        End If
    End Sub

End Class
