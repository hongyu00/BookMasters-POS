Imports System.Data.SqlClient

Public Class FrmMemberSearch
    Private Sub FrmMemberSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(Nothing, Nothing)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, mskMobile.TextChanged

        Dim strName As String = txtName.Text.ToUpper().Trim()
        Dim strMobile As String = mskMobile.Text.Trim()

        lblMessage.Visible = False

        If strName <> "" And strMobile <> "-" Then
            MessageBox.Show("Cannot search by both options, please select only one", "Duplicated option", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnClear_Click(Nothing, Nothing)
        ElseIf strName = "" And strMobile = "-" Then
            btnClear_Click(Nothing, Nothing)
        Else
            If strName <> "" Then
                searchDB(strName, "memberName")
            ElseIf strMobile <> "-" Then
                searchDB(strMobile.Replace(" ", "%"), "memberContact")
            End If
        End If 'If either one not empty

    End Sub

    Private Sub searchDB(strContent As String, strSearchItem As String)

        Try
            Dim ds As DataSet = New DataSet()
            Dim da As SqlDataAdapter
            Dim strSql As String

            If OpenConnection() = True Then

                strSql = "Select memberID,memberName,memberContact,memberStatus From Member Where " & strSearchItem & " LIKE '%" & strContent & "%'"
                da = New SqlDataAdapter(strSql, conn)
                ds.Clear()
                da.Fill(ds, "MemberSearch")

                If ds.Tables("MemberSearch").Rows.Count > 0 Then

                    With gvMember
                        .DataSource = ds.Tables("MemberSearch")
                        .Columns(0).HeaderCell.Value = "Member ID"
                        .Columns(1).HeaderCell.Value = "Member Name"
                        .Columns(2).HeaderCell.Value = "Member Contact"
                        .Columns(3).HeaderCell.Value = "Member Status"
                    End With

                Else
                    'Cannot found record
                    clearGV()
                    lblMessage.Visible = True

                End If

                CloseConnection()

            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If 'If connection is open

        Catch ex As Exception
            MessageBox.Show("Error: Cannot search record", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        mskMobile.Text = ""
        clearGV()
        lblMessage.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearGV()
        With gvMember
            .DataSource = Nothing
            .Rows.Clear()
        End With
    End Sub

    Private Sub gvMember_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvMember.CellDoubleClick

        'Only execute when the content double clicked
        '-1 is header double clicked so we should not response
        If e.RowIndex <> -1 Then
            With FrmMemberDetailsNUpdate
                .strMemberID = gvMember.Rows(e.RowIndex).Cells(0).Value
                .ShowDialog()
            End With

            txtName_TextChanged(Nothing, Nothing)
        End If

    End Sub
End Class