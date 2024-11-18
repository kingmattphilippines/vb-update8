Imports MySqlConnector

Public Class owners_clients

    Dim db As New database()

        ' Create a function to insert a new owner/client
        Function insertPerson(ByVal personType As String, ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String, ByVal address As String) As Boolean
            Dim query As String = $"INSERT INTO `{personType}` (first_name, last_name, phone, email, address) VALUES (@fn, @ln, @phn, @mail, @adrs)"

            Using conn As MySqlConnection = db.getConnection()
                db.openConnection(conn)
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@fn", fname)
                    command.Parameters.AddWithValue("@ln", lname)
                    command.Parameters.AddWithValue("@phn", phone)
                    command.Parameters.AddWithValue("@mail", email)
                    command.Parameters.AddWithValue("@adrs", address)
                    Return command.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ' Create a function to edit a person
        Function editPerson(ByVal personType As String, ByVal personId As Integer, ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String, ByVal address As String) As Boolean
            Dim query As String = $"UPDATE `{personType}` SET first_name=@fn, last_name=@ln, phone=@phn, email=@mail, address=@adrs WHERE id=@id"

            Using conn As MySqlConnection = db.getConnection()
                db.openConnection(conn)
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@fn", fname)
                    command.Parameters.AddWithValue("@ln", lname)
                    command.Parameters.AddWithValue("@phn", phone)
                    command.Parameters.AddWithValue("@mail", email)
                    command.Parameters.AddWithValue("@adrs", address)
                    command.Parameters.AddWithValue("@id", personId)
                    Return command.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ' Create function to delete the selected owner/client
        Function deletePerson(ByVal personType As String, ByVal personId As Integer) As Boolean
            Dim query As String = $"DELETE FROM `{personType}` WHERE id=@id"

            Using conn As MySqlConnection = db.getConnection()
                db.openConnection(conn)
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@id", personId)
                    Return command.ExecuteNonQuery() > 0 ' Return true if a row was deleted
                End Using
            End Using
        End Function

    Function getCount(ByVal tablename As String) As Integer
        Dim query As String = ""

        If tablename.Equals("client", StringComparison.OrdinalIgnoreCase) Then
            query = "SELECT COUNT(*) FROM `clients`"
        ElseIf tablename.Equals("owner", StringComparison.OrdinalIgnoreCase) Then
            query = "SELECT COUNT(*) FROM `prop_owner`"
        Else
            MessageBox.Show("Unknown table name: " & tablename, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1 ' Indicate an error
        End If

        ' Ensure command is created with the valid query
        Dim command As New MySqlCommand(query)

        ' Assuming 'Func' is an instance of MYFUNCTION
        Dim func As New myFunction()

        ' Return the count using the exeCount function
        Return func.exeCount(command)
    End Function

    Function IsNameDuplicate(personType As String, fname As String, lname As String) As Boolean
        Try
            ' SQL query to check if the combination of first name and last name already exists
            Dim query As String = $"SELECT COUNT(*) FROM `{personType}` WHERE first_name = @fname AND last_name = @lname"

            ' Using MySqlConnection to execute the query
            Using conn As MySqlConnection = db.getConnection()
                db.openConnection(conn)
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@fname", fname)
                    command.Parameters.AddWithValue("@lname", lname)

                    ' Execute the query and return true if a duplicate is found
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for duplicates: " & ex.Message, "Duplicate Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function





End Class


