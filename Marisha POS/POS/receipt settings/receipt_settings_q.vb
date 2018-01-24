Imports System.Data.SqlClient
Imports System.IO

Public Class receipt_settings_q

    Dim SQL As New SQLControl

    Public Sub load()
        Try
            Dim load As String = "SELECT * FROM set_receipt_table"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            frm_receipt_settings.txt_store_name.Text = SQL.SQLDR("store_name")
            frm_receipt_settings.txt_store_address.Text = SQL.SQLDR("store_address")
            frm_receipt_settings.txt_tin.Text = SQL.SQLDR("tin").ToString.Remove(0, 9)
            frm_receipt_settings.txt_closing_1.Text = SQL.SQLDR("closing_1")
            frm_receipt_settings.txt_closing_2.Text = SQL.SQLDR("closing_2")
            frm_receipt_settings.txt_closing_3.Text = SQL.SQLDR("closing_3")
            frm_receipt_settings.txt_closing_4.Text = SQL.SQLDR("closing_4")
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'UPDATING'
    Sub update()

        Try
            Dim update As String = "UPDATE set_receipt_table SET store_name = @store_name, store_address = @store_address, " & _
                                            "tin = @tin, closing_1 = @closing_1, closing_2 = @closing_2, closing_3 = @closing_3, closing_4 = @closing_4"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@store_name", frm_receipt_settings.txt_store_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@store_address", frm_receipt_settings.txt_store_address.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@tin", "TIN No. :" & frm_receipt_settings.txt_tin.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@closing_1", frm_receipt_settings.txt_closing_1.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@closing_2", frm_receipt_settings.txt_closing_2.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@closing_3", frm_receipt_settings.txt_closing_3.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@closing_4", frm_receipt_settings.txt_closing_4.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Receipt Settings Successfully Updated!", MsgBoxStyle.Information, " Settings Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub
End Class
