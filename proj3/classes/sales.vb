Imports MySqlConnector

Public Class sales

    Dim func As New myFunction()
    Private query As String

    ' Get all sales
    Public Function getAllSales() As DataTable
        query = "SELECT `Id`, `propertyid` AS 'Property', `clientid` AS 'Client', `selling_price` AS 'Price', `selling_date` AS 'Date' FROM `prop_sale`"
        Return func.getData(query)
    End Function

    ' Add a new sale
    Function addSale(ByVal propertyId As Integer, ByVal clientId As Integer, ByVal sellingPrice As Decimal, ByVal sellingDate As Date) As Boolean
        query = "INSERT INTO `prop_sale`(`propertyid`, `clientid`, `selling_price`, `selling_date`) VALUES (@property, @client, @price, @date)"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@property", MySqlDbType.Int32) With {.Value = propertyId},
            New MySqlParameter("@client", MySqlDbType.Int32) With {.Value = clientId},
            New MySqlParameter("@price", MySqlDbType.Decimal) With {.Value = sellingPrice},
            New MySqlParameter("@date", MySqlDbType.Date) With {.Value = sellingDate}
        }

        Return ExecuteQuery(query, parameters)
    End Function


    Function editSale(saleId As Integer, propertyId As Integer, clientId As Integer, ByVal sellingPrice As Decimal, ByVal sellingDate As Date) As Boolean
        ' Validate parameters
        If saleId <= 0 Or propertyId <= 0 Or clientId <= 0 Or sellingPrice <= 0 Then
            Throw New ArgumentException("Invalid parameters provided for sale edit.")
        End If

        Dim query As String = "UPDATE `prop_sale` SET `propertyid`=@property, `clientid`=@client, `selling_price`=@price, `selling_date`=@date WHERE `id`=@id"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@property", MySqlDbType.Int32) With {.Value = propertyId},
        New MySqlParameter("@client", MySqlDbType.Int32) With {.Value = clientId},
        New MySqlParameter("@price", MySqlDbType.Decimal) With {.Value = sellingPrice},
        New MySqlParameter("@date", MySqlDbType.Date) With {.Value = sellingDate},
        New MySqlParameter("@id", MySqlDbType.Int32) With {.Value = saleId}
    }

        ' Call ExecuteQuery to execute the update
        Return ExecuteQuery(query, parameters)
    End Function





    ' Remove sale
    Function removeSale(ByVal saleId As Integer) As Boolean
        query = "DELETE FROM `prop_sale` WHERE `id`=@id"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@id", MySqlDbType.Int32) With {.Value = saleId}
        }

        Return ExecuteQuery(query, parameters)
    End Function



    ' Helper function to execute queries
    Private Function ExecuteQuery(ByVal query As String, ByVal parameters As List(Of MySqlParameter)) As Boolean
        Try
            Dim command As New MySqlCommand(query)
            command.Parameters.AddRange(parameters.ToArray())

            Return func.exeQuery(command)
        Catch ex As Exception
            ' Log the error (consider adding a logging mechanism)
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Function getSalesCount() As Integer
        Dim command As New MySqlCommand("SELECT COUNT(*) FROM `prop_sale`")
        Return func.exeCount(command) ' Ensure this method returns an Integer
    End Function
End Class
