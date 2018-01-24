Imports System.Data.SqlClient
Imports System.IO

Public Class hold_resume_q

    Dim SQL As New SQLControl

    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM held_trans_table ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_held_trans.dgv_trans.AutoGenerateColumns = False

                    'Add Columns
                    frm_held_trans.dgv_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_held_trans.dgv_trans.Columns(1).DataPropertyName = "DateTime"
                    frm_held_trans.dgv_trans.Columns(2).DataPropertyName = "Remarks"

                    frm_held_trans.dgv_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'get trans or hold no '
    Public Sub get_hold_no()
        Try
            Dim get_hold_no As String = "SELECT trans_no FROM held_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_hold_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_trans_remarks.lbl_trans_hold_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_trans_remarks.lbl_trans_hold_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT TRANS'
    Public Sub insert_trans()
        Try
            Dim insert_trans As String = "INSERT INTO held_trans_table(trans_no,DateTime,Remarks,Discount)VALUES " & _
            "(@trans_no,@DateTime,@Remarks,@Discount)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_trans_remarks.lbl_trans_hold_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@DateTime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@Remarks", frm_trans_remarks.txt_remarks.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@Discount", frm_invoice.lbl_disc_percent.Text)
            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT TRANSACTION ITEMS ( MULTIPLE ENTRIES) '
    Public Sub insert_trans_items()
        Try
            For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows

                Dim insert_trans_items As String = "INSERT INTO held_item_table(trans_id,item_no,barcode, " & _
                "item_name,price,quantity,amount,beg_inv,end_inv,buying_price,beg_inv_price,beg_inv_init_price,discount,unit_of_measure,category)VALUES " & _
                "(@trans_id,@item_no,@barcode,@item_name,@price,@quantity,@amount,@beg_inv,@end_inv,@buying_price,@beg_inv_price,@beg_inv_init_price,@discount,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_trans_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_id", frm_trans_remarks.lbl_trans_hold_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@quantity", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@amount", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", row.Cells(7).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@end_inv", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@buying_price", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@beg_inv_price", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@beg_inv_init_price", row.Cells(11).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@discount", row.Cells(12).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(5).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(13).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'Delete from purchase_trans_table'
    Sub delete_trans()
        Try
            Dim delete_trans As String = "Delete from held_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_held_trans.lbl_id.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from purchase_item_table'
    Sub delete_trans_item()
        Try
            Dim delete_trans_item As String = "Delete from held_item_table WHERE trans_id = @trans_id"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_item, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_id", frm_held_trans.lbl_id.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'RESUME TRANSACTION'
    Public Sub load_resume_trans()
        Try
            Dim load_resume_trans As String = "SELECT * FROM held_item_table WHERE trans_id = '" & frm_held_trans.lbl_id.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load_resume_trans, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            Do While SQL.SQLDR.Read
                frm_invoice.dgv_item_cart.Rows.Add(New Object() _
                                     {SQL.SQLDR("item_no"), SQL.SQLDR("barcode"), _
                                      SQL.SQLDR("item_name"), SQL.SQLDR("price"), _
                                      CDec(SQL.SQLDR("quantity")), SQL.SQLDR("unit_of_measure"), SQL.SQLDR("amount"), _
                                      SQL.SQLDR("beg_inv"), SQL.SQLDR("end_inv"), _
                                      SQL.SQLDR("buying_price"), SQL.SQLDR("beg_inv_price"), SQL.SQLDR("beg_inv_init_price"), SQL.SQLDR("discount"), SQL.SQLDR("category")})
            Loop
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub load_discount_resume()
        Try
            Dim load_discount_resume As String = "SELECT Discount FROM held_trans_table WHERE trans_no = '" & frm_held_trans.lbl_id.Text & "'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load_discount_resume, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_invoice.lbl_disc_percent.Text = SQL.SQLDR("Discount")
            Else
                frm_invoice.lbl_disc_percent.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
