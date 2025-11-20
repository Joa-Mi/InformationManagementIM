Imports System.Data.SqlClient
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Adminlogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Optional: Add logic if needed
    End Sub

    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click
        ' Show the Login form and match the same window size/state
        Login.WindowState = Me.WindowState
        Login.Size = Me.Size
        Login.Location = Me.Location
        Login.Show()

        ' Hide the Admin login form
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Optional: Add logic if needed
    End Sub

    Private Sub Adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Match the Login form's window state, size, and position
        Me.WindowState = Login.WindowState
        Me.Size = Login.Size
        Me.Location = Login.Location

        ' Test database connection
        If Not isConnectedToLocalServer() Then
            MsgBox("Unable to connect to database server. Please check your connection.", MsgBoxStyle.Critical, "Connection Error")
        End If
    End Sub

    Private Sub adminlog_Click(sender As Object, e As EventArgs) Handles adminlog.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Please enter your username.", MsgBoxStyle.Exclamation, "Validation Error")
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter your password.", MsgBoxStyle.Exclamation, "Validation Error")
            txtPassword.Focus()
            Return
        End If

        ' Attempt to authenticate admin
        If AuthenticateAdmin(txtUsername.Text.Trim(), txtPassword.Text) Then
            ' Log the successful login
            Logs("Admin Login - User: " & CurrentLoggedUser.name, "adminlog_Click")

            ' Show success message
            MsgBox("Login successful! Welcome, " & CurrentLoggedUser.name, MsgBoxStyle.Information, "Success")

            ' Open Admin Dashboard
            Dim dashboard As New AdminDashboard()
            dashboard.StartPosition = FormStartPosition.CenterScreen
            dashboard.WindowState = FormWindowState.Maximized
            dashboard.Show()
            Me.Hide()
        Else
            ' Show error message for invalid credentials
            MsgBox("Invalid username or password. Please try again.", MsgBoxStyle.Critical, "Login Failed")
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub

    ' Database connection test function
    Private Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Dim myadocon As MySqlConnection = Nothing

        Try
            myadocon = New MySqlConnection()
            myadocon.ConnectionString = strConnection

            Try
                myadocon.Open()
                If myadocon.State = ConnectionState.Open Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As Exception
                MsgBox("Connection Error: " & ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try

            If myadocon.State = ConnectionState.Open Then
                myadocon.Close()
            End If
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If myadocon IsNot Nothing Then
                myadocon.Dispose()
            End If
        End Try

        Return result
    End Function

    ' Authenticate admin user
    Private Function AuthenticateAdmin(username As String, password As String) As Boolean
        Dim conn As MySqlConnection = Nothing
        Dim cmd As MySqlCommand = Nothing
        Dim reader As MySqlDataReader = Nothing

        Try
            conn = New MySqlConnection(strConnection)
            conn.Open()

            ' Encrypt the password for comparison
            Dim encryptedPassword As String = Encrypt(password)

            ' Query to check admin credentials
            ' Assuming you have a user_accounts table with columns:
            ' id, name, username, password, type (where type = 1 for admin)
            Dim query As String = "SELECT id, name, position, username, password, type " &
                                "FROM user_accounts " &
                                "WHERE username = @username AND password = @password AND type = 1"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", encryptedPassword)

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Store logged user information
                CurrentLoggedUser.id = Convert.ToInt32(reader("id"))
                CurrentLoggedUser.name = reader("name").ToString()
                CurrentLoggedUser.position = If(IsDBNull(reader("position")), "", reader("position").ToString())
                CurrentLoggedUser.username = reader("username").ToString()
                CurrentLoggedUser.password = reader("password").ToString()
                CurrentLoggedUser.type = Convert.ToInt32(reader("type"))

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Authentication Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If reader IsNot Nothing Then reader.Close()
            If cmd IsNot Nothing Then cmd.Dispose()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Dispose()
            End If
        End Try
    End Function

    ' Encrypt password function (from modDB)
    Private Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)

        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using

        Return clearText
    End Function

    ' Log function to record activities
    Private Sub Logs(ByVal transaction As String, Optional ByVal events As String = "*_Click")
        Dim conn As MySqlConnection = Nothing
        Dim cmd As MySqlCommand = Nothing

        Try
            conn = New MySqlConnection(strConnection)
            conn.Open()

            Dim query As String = "INSERT INTO `logs`(`dt`, `user_accounts_id`, `event`, `transactions`) " &
                                "VALUES (now(), @userId, @event, @transaction)"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userId", CurrentLoggedUser.id)
            cmd.Parameters.AddWithValue("@event", events)
            cmd.Parameters.AddWithValue("@transaction", transaction)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            ' Silent fail for logging - don't interrupt user experience
            Console.WriteLine("Log Error: " & ex.Message)
        Finally
            If cmd IsNot Nothing Then cmd.Dispose()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Dispose()
            End If
        End Try
    End Sub
End Class