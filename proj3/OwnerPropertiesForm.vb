Imports System.Windows.Forms.PropertyGridInternal

Public Class OwnerPropertiesForm

    Private ownerId As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    'create a subto get the owner and display them

    Sub getProperties(ByVal ownerId As Integer)
        Try

            DataGridViewOWNERPROPERTIES.DataSource = New the_property().getPropertiesByOwnerId(ownerId)


        Catch

        End Try



    End Sub


End Class