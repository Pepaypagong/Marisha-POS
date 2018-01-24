Imports System.Data.SqlClient
Imports System.IO

Public Class trans_history_q

    Dim SQL As New SQLControl

    Public Sub load_transaction_history()
        Using cmd As New SqlCommand("SELECT * FROM begin_end_inv_table WHERE item_in > 0 or item_out > 0 ORDER BY ID DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_trans_history.dgv_history.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_trans_history.dgv_history.Columns(0).DataPropertyName = "trans_datetime"
                    frm_trans_history.dgv_history.Columns(1).DataPropertyName = "trans_type"
                    frm_trans_history.dgv_history.Columns(2).DataPropertyName = "barcode"
                    frm_trans_history.dgv_history.Columns(3).DataPropertyName = "item_name"
                    frm_trans_history.dgv_history.Columns(4).DataPropertyName = "item_in"
                    frm_trans_history.dgv_history.Columns(5).DataPropertyName = "item_out"
                    frm_trans_history.dgv_history.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_transaction_history_filter()
        Using cmd As New SqlCommand("SELECT * FROM begin_end_inv_table WHERE (item_in > 0 or item_out > 0) " & _
                                    "AND trans_date between '" & frm_trans_history.dtp_date_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_trans_history.dtp_date_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY ID DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_trans_history.dgv_history.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_trans_history.dgv_history.Columns(0).DataPropertyName = "trans_datetime"
                    frm_trans_history.dgv_history.Columns(1).DataPropertyName = "trans_type"
                    frm_trans_history.dgv_history.Columns(2).DataPropertyName = "barcode"
                    frm_trans_history.dgv_history.Columns(3).DataPropertyName = "item_name"
                    frm_trans_history.dgv_history.Columns(4).DataPropertyName = "item_in"
                    frm_trans_history.dgv_history.Columns(5).DataPropertyName = "item_out"
                    frm_trans_history.dgv_history.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'settings'
    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'trans_history' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_trans_history.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
