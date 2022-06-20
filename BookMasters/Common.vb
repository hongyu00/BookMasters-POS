Imports System.Data.SqlClient
Imports System.Globalization

Module Common

    Friend conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookMastersDB.mdf;Integrated Security=True")
    Friend strNotification As String = ""

    Public Function OpenConnection() As Boolean

        Try
            conn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try

    End Function

    Public Sub CloseConnection()
        conn.Close()
    End Sub


#Region "For Member and Voucher Module"

    'To get all the country available
    Public Function GetCountry() As List(Of String)

        Dim list As New List(Of String)()
        Dim cultures As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)

        For Each info As CultureInfo In cultures
            Dim info2 As New RegionInfo(info.LCID)

            If Not list.Contains(info2.EnglishName) Then
                list.Add(info2.EnglishName)
            End If
        Next

        'Sort the list according to the name
        list.Sort()

        Return list
    End Function

    'To check whether the string contains special character
    'Return true means contain
    Public Function containsSpecialChars(str As String) As Boolean
        'If not match will return -1 so it is false (-1 <> -1)
        Return str.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    'If the status of member or voucher have been updated,
    'Show the notification to list down the updated item
    Public Sub showNoti()
        If strNotification <> "" Then
            MessageBox.Show(strNotification, "List of updated information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strNotification = ""
        End If
    End Sub

    'To set the button style
    Public Sub setBtnStyle(btn As Button, flag As Boolean)

        If flag = False Then
            With btn
                .BackColor = Color.FromArgb(204, 204, 204)
                .Enabled = False
            End With
        Else
            With btn
                .BackColor = Color.FromArgb(22, 99, 255)
                .Enabled = True
            End With
        End If

    End Sub
#End Region


End Module
