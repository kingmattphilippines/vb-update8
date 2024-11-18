Public Class MainForm

    ' Declare forms and label for WELCOME message
    Dim ownersf As New OwnerForm()
    Dim propertyF As New PropertyForm()
    Dim property_type As New TypeForm()
    Dim clientsF As New ClientForm()
    Dim propImagesF As New ImageForm()
    Dim salesF As New SalesForm()

    ' Declare label for "WELCOME" message
    Dim lblWelcome As New Label()

    ' Main form load Event
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add hover events to all buttons
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                AddHandler ctrl.MouseEnter, AddressOf Button_MouseEnter
                AddHandler ctrl.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next

        ' Initialize and set properties for the WELCOME label
        lblWelcome.Text = "CODERFITZ-GROUP"
        lblWelcome.Font = New Font("Segoe UI Bold", 50, FontStyle.Bold) ' Set the font size and style
        lblWelcome.ForeColor = Color.White ' Set the text color
        lblWelcome.AutoSize = True ' Auto size to fit the text
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter ' Center the text

        ' Add the WELCOME label to the form
        Me.Controls.Add(lblWelcome)
    End Sub

    ' Main form Shown Event (called when the form is reopened)
    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Ensure Panel2 and BtnRefresh are visible when the form is shown or reopened
        ShowHomePanel()

        ' Center panels
        CenterPanel()
        CenterSidebarPanel()
        AdjustPanelsToFormSize()

        ' Display counts
        RefreshCounts()

        ' Center the WELCOME label within the form
        CenterWelcomeLabel()
    End Sub

    ' Adjust Panel1 height and Panel3 width to match the form size
    Private Sub AdjustPanelsToFormSize()
        Panel1.Top = 100 ' Align Panel1 to the top
        Panel1.Height = Me.ClientSize.Height ' Set Panel1 height equal to form height
        Panel3.Width = Me.ClientSize.Width ' Set Panel3 width equal to form width
    End Sub

    ' Hover event handlers
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.DodgerBlue
        btn.ForeColor = Color.White
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.SteelBlue
        btn.ForeColor = Color.White
    End Sub

    ' Display form as a dialog
    Private Sub DisplayFormAsDialog(ByRef formToShow As Form)
        Try
            ' Create a new form instance if it is null or disposed
            If formToShow Is Nothing OrElse formToShow.IsDisposed Then
                formToShow = CreateFormInstance(formToShow.GetType().Name)
            End If

            ' Set the form's StartPosition to CenterParent to center it relative to the parent (MainForm)
            formToShow.StartPosition = FormStartPosition.CenterParent

            ' Show the form as a modal dialog
            formToShow.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Create form instance based on name
    Private Function CreateFormInstance(formName As String) As Form
        Select Case formName
            Case "OwnerForm" : Return New OwnerForm()
            Case "ClientForm" : Return New ClientForm()
            Case "PropertyForm" : Return New PropertyForm()
            Case "TypeForm" : Return New TypeForm()
            Case "ImageForm" : Return New ImageForm()
            Case "SalesForm" : Return New SalesForm()
            Case Else : Return Nothing
        End Select
    End Function

    ' Button click handler
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles BtnOwner.Click, BtnClient.Click, BtnProperty.Click, BtnType.Click, BtnImage.Click, BtnSale.Click
        ' Hide Panel2 and BtnRefresh when any button is clicked
        HideHomePanel()

        Dim formToShow As Form = Nothing
        Select Case DirectCast(sender, Button).Name
            Case BtnOwner.Name : formToShow = ownersf
            Case BtnClient.Name : formToShow = clientsF
            Case BtnProperty.Name : formToShow = propertyF
            Case BtnType.Name : formToShow = property_type
            Case BtnImage.Name : formToShow = propImagesF
            Case BtnSale.Name : formToShow = salesF
        End Select
        If formToShow IsNot Nothing Then DisplayFormAsDialog(formToShow)
    End Sub

    ' Logout handler
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    ' Refresh button click handler
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshCounts()
    End Sub

    ' Refresh statistics
    Private Sub RefreshCounts()
        LabelProperties.Text = New the_property().getPropertiesCount().ToString & " Property(ies)"
        LabelOwners.Text = New owners_clients().getCount("owner").ToString & " Owner(s)"
        LabelClients.Text = New owners_clients().getCount("client").ToString & " Client(s)"
        LabelSales.Text = New sales().getSalesCount().ToString & " Sale(s)"
    End Sub

    ' Center panels within the form
    Private Sub CenterPanel()
        Panel2.Left = (Me.ClientSize.Width - Panel2.Width) \ 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height) \ 2

        ' Center BtnRefresh below Panel2
        BtnRefresh.Left = (Me.ClientSize.Width - BtnRefresh.Width) \ 2
        BtnRefresh.Top = Panel2.Bottom + 10 ' Position BtnRefresh 10 pixels below Panel2
    End Sub

    Private Sub CenterSidebarPanel()
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
        Panel1.Left = 0 ' Align it to the left side or adjust based on your needs
    End Sub

    ' Center the WELCOME label within the form
    Private Sub CenterWelcomeLabel()
        lblWelcome.Left = (Me.ClientSize.Width - lblWelcome.Width) \ 2
        lblWelcome.Top = (Me.ClientSize.Height - lblWelcome.Height) \ 2
    End Sub

    ' Show Panel2 and BtnRefresh automatically when loading the form (acting as the "Home" view)
    Private Sub ShowHomePanel()
        Panel2.Visible = True
        BtnRefresh.Visible = True
    End Sub

    ' Hide Panel2 and BtnRefresh when navigating to another form
    Private Sub HideHomePanel()
        Panel2.Visible = False
        BtnRefresh.Visible = False
    End Sub

    ' Show Panel2 and BtnRefresh when Home button is clicked
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowHomePanel()
    End Sub

End Class
