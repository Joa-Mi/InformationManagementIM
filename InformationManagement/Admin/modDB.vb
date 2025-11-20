Imports System.Data.SqlClient
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module modDB
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader

    ' Database configuration - CHANGE THESE TO MATCH YOUR DATABASE
    Public db_server As String = "localhost"
    Public db_uid As String = "root"
    Public db_pwd As String = ""
    Public db_name As String = "tabeya_system"  ' Change this to your database name
    Public strConnection As String = "server=" & db_server & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";" & "allowuservariables='True';"

    ' Structure to hold logged user information
    Public Structure LoggedUser
        Dim id As Integer
        Dim name As String
        Dim position As String
        Dim username As String
        Dim password As String
        Dim type As Integer
    End Structure

    Public CurrentLoggedUser As LoggedUser = Nothing

    ' Open database connection
    Public Sub openConn(ByVal db_name As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical, "Database Connection Error")
        End Try
    End Sub

    ' Execute a SELECT query and return a DataReader
    Public Sub readQuery(ByVal sql As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdRead = .ExecuteReader
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical, "Query Error")
        End Try
    End Sub

    ' Test if connected to local server
    Public Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Try
            myadocon = New MySqlConnection
            myadocon.ConnectionString = strConnection
            Try
                myadocon.Open()
                If myadocon.State = ConnectionState.Open Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As Exception
                Return False
            End Try
            If myadocon.State = ConnectionState.Open Then
                myadocon.Close()
            End If
        Catch
            Return False
        End Try
        Return result
    End Function

    ' Load data into a DataGridView
    Function LoadToDGV(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Data Load Error")
        End Try
        Return 0
    End Function

    ' Encrypt a string
    Public Function Encrypt(ByVal clearText As String) As String
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

    ' Decrypt a string
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    ' Log user activities
    Sub Logs(ByVal transaction As String, Optional ByVal events As String = "*_Click")
        Try
            readQuery(String.Format("INSERT INTO `logs`(`dt`, `user_accounts_id`, `event`, `transactions`) VALUES ({0},{1},'{2}','{3}')", "now()",
                                    CurrentLoggedUser.id,
                                    events,
                                    transaction))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Log Error")
        End Try
    End Sub
End Module