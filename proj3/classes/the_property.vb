Imports System.IO
Imports MySqlConnector

Public Class the_property

    Dim func As New myFunction()
    Private db As New database()

    ' General method for executing commands and returning DataTable
    Private Function ExecuteCommand(command As MySqlCommand, Optional table As DataTable = Nothing) As DataTable
        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Try
                command.Connection = conn
                If table Is Nothing Then table = New DataTable()
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                db.closesConnection(conn)
            End Try
        End Using
        Return table
    End Function

    ' Get property by ID
    Function getPropertyById(ByVal id As Integer) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `the_property` WHERE `id` = @id")
        command.Parameters.AddWithValue("@id", id)
        Return ExecuteCommand(command)
    End Function

    ' Get properties by owner ID
    Function getPropertiesByOwnerId(ByVal ownerid As Integer) As DataTable
        Dim command As New MySqlCommand("SELECT `id`, `size`, `price`, `address`, `beds`, `baths`, `age`, `comment` FROM `the_property` WHERE `owner` = @oid")
        command.Parameters.AddWithValue("@oid", ownerid)
        Return ExecuteCommand(command)
    End Function

    ' Add a new property
    Function addProperty(ByVal type As Integer,
                         ByVal owner As Integer,
                         ByVal size As Integer,
                         ByVal price As String,
                         ByVal address As String,
                         ByVal beds As Integer,
                         ByVal baths As Integer,
                         ByVal age As Integer,
                         ByVal balcony As Boolean,
                         ByVal backyard As Boolean,
                         ByVal garage As Boolean,
                         ByVal pool As Boolean,
                         ByVal fireplace As Boolean,
                         ByVal elevator As Boolean,
                         ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `the_property`(`type`, `owner`, `size`, `price`, `address`, `beds`, `baths`, `age`, `balcony`, `backyard`, `garage`, `pool`, `fireplace`, `elevator`, `comment`) VALUES (@tp, @ownerId, @sz, @prc, @adrs, @bds, @bths, @age, @blcn, @bkyd, @grg, @pool, @frplc, @elv, @cmnt)")
        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)

        Return func.exeQuery(command)
    End Function

    ' Edit the selected property
    Function editProperty(ByVal propertyId As Integer,
                          ByVal type As Integer,
                          ByVal owner As Integer,
                          ByVal size As Integer,
                          ByVal price As String,
                          ByVal address As String,
                          ByVal beds As Integer,
                          ByVal baths As Integer,
                          ByVal age As Integer,
                          ByVal balcony As Boolean,
                          ByVal backyard As Boolean,
                          ByVal garage As Boolean,
                          ByVal pool As Boolean,
                          ByVal fireplace As Boolean,
                          ByVal elevator As Boolean,
                          ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `the_property` SET `type` = @tp, `owner` = @ownerId, `size` = @sz, `price` = @prc, `address` = @adrs, `beds` = @bds, `baths` = @bths, `age` = @age, `balcony` = @blcn, `backyard` = @bkyd, `garage` = @grg, `pool` = @pool, `fireplace` = @frplc, `elevator` = @elv, `comment` = @cmnt WHERE `id` = @id")
        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)
        command.Parameters.AddWithValue("@id", propertyId)

        Return func.exeQuery(command)
    End Function

    ' Remove the selected property
    Function removeProperty(ByVal propertyId As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `the_property` WHERE `id` = @id")
        command.Parameters.AddWithValue("@id", propertyId)
        Return func.exeQuery(command)
    End Function

    ' Add a property image
    Function addImage(ByVal PropertyId As Integer, ByVal propertyImage As MemoryStream) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `prop_images`(`propertyid`, `prop_image`) VALUES (@pid, @img)")
        command.Parameters.AddWithValue("@pid", PropertyId)
        command.Parameters.AddWithValue("@img", propertyImage.ToArray())

        Return func.exeQuery(command)
    End Function

    ' Remove a property image
    Function removeImage(ByVal imageId As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `prop_images` WHERE `id` = @imgId")
        command.Parameters.AddWithValue("@imgId", imageId)

        Return func.exeQuery(command)
    End Function

    ' Get all images for a property
    Function getpropertyImages(ByVal propertyId As Integer) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `prop_images` WHERE `propertyid` = @pid")
        command.Parameters.AddWithValue("@pid", propertyId)
        Return ExecuteCommand(command)
    End Function

    ' Get image by ID
    Function getImageById(ByVal imageId As Integer) As MemoryStream
        Dim command As New MySqlCommand("SELECT `prop_image` FROM `prop_images` WHERE `id` = @id")
        command.Parameters.AddWithValue("@id", imageId)

        Dim table As DataTable = ExecuteCommand(command)
        If table.Rows.Count > 0 Then
            Return New MemoryStream(CType(table.Rows(0)("prop_image"), Byte()))
        Else
            Return New MemoryStream()
        End If
    End Function

    'get properties count
    Function getPropertiesCount() As Integer
        Dim command As New MySqlCommand("SELECT COUNT(*) FROM `the_property`")
        Return func.exeCount(command) ' Ensure this method returns an Integer
    End Function




End Class
