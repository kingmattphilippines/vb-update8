Imports MySqlConnector

Public Class myFunction
    Dim db As New database()

    ' Function to get data using a MySqlCommand
    Public Function getDataUsingCommand(command As MySqlCommand) As DataTable
        Dim table As New DataTable()
        Try
            ' Set the connection for the command
            Using connection As MySqlConnection = db.getConnection()
                command.Connection = connection
                db.openConnection(connection)

                ' Use a data adapter to fill the DataTable with the results of the command
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving properties: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return the filled DataTable
        Return table
    End Function

    ' Function to get data using a query string
    Function getData(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Using connection As MySqlConnection = db.getConnection()
            Using command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(command)
                    db.openConnection(connection)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function

    ' Function to execute a query
    Function exeQuery(ByVal command As MySqlCommand) As Boolean
        Using connection As MySqlConnection = db.getConnection()
            command.Connection = connection
            db.openConnection(connection)
            Try
                Return command.ExecuteNonQuery() = 1
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message)
                Return False
            Finally
                db.closesConnection(connection) ' Ensure the connection is closed
            End Try
        End Using
    End Function




    ' Function to execute a scalar query and return the result
    Public Function executeScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Dim result As Object = Nothing
        Try
            Using connection As MySqlConnection = db.getConnection()
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If

                    ' Execute the command and get the scalar result
                    result = command.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing scalar query: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return result
    End Function

    ' Function to execute a count query
    Public Function exeCount(ByVal command As MySqlCommand) As Integer
        Dim count As Integer = 0 ' Default return value

        ' Using statement to automatically manage the connection lifecycle
        Using connection As MySqlConnection = db.getConnection()
            Try
                ' Set the connection for the command
                command.Connection = connection
                db.openConnection(connection)

                ' Execute the command and get the scalar result
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    count = Convert.ToInt32(result)
                End If
            Catch ex As Exception
                ' Display an error message if an exception occurs
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                db.closesConnection(connection) ' Ensure the connection is closed
            End Try
        End Using

        ' Return the count
        Return count
    End Function
End Class
