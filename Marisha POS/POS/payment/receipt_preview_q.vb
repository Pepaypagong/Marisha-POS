Imports System.Data.SqlClient
Imports System.IO

Public Class receipt_preview_q

    Dim SQL As New SQLControl

    Public Sub load_receipt_info()
        Try
            Dim load As String = "SELECT * FROM set_receipt_table"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            frm_receipt_preview.lbl_store_name.Text = SQL.SQLDR("store_name")
            frm_receipt_preview.lbl_store_address.Text = SQL.SQLDR("store_address")
            frm_receipt_preview.lbl_tin.Text = "TIN NO. : " + SQL.SQLDR("tin")
            frm_receipt_preview.lbl_closing_1.Text = SQL.SQLDR("closing_1")
            frm_receipt_preview.lbl_closing_2.Text = SQL.SQLDR("closing_2")

            frm_receipt_preview.store_name = SQL.SQLDR("store_name")
            frm_receipt_preview.store_address = SQL.SQLDR("store_address")
            frm_receipt_preview.tin = SQL.SQLDR("tin")
            frm_receipt_preview.closing_1 = SQL.SQLDR("closing_1")
            frm_receipt_preview.closing_2 = SQL.SQLDR("closing_2")
            frm_receipt_preview.closing_3 = SQL.SQLDR("closing_3")
            frm_receipt_preview.closing_4 = SQL.SQLDR("closing_4")

            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub load_receipt_info_customer()
        Try
            Dim load As String = "SELECT * FROM set_receipt_table"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()

            frm_receipt_preview_customer.store_name = SQL.SQLDR("store_name")
            frm_receipt_preview_customer.store_address = SQL.SQLDR("store_address")
            frm_receipt_preview_customer.tin = SQL.SQLDR("tin")
            frm_receipt_preview_customer.closing_1 = SQL.SQLDR("closing_1")
            frm_receipt_preview_customer.closing_2 = SQL.SQLDR("closing_2")
            frm_receipt_preview_customer.closing_3 = SQL.SQLDR("closing_3")
            frm_receipt_preview_customer.closing_4 = SQL.SQLDR("closing_4")

            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    public Sub LoadItemstoDatagrid()
        Dim y As Integer
        Try
            Dim load As String = "SELECT * FROM sales_item_table WHERE trans_no = '" & frm_invoice.lbl_trans_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            frm_receipt_preview.dgw.Rows.Clear()

            Do While SQL.SQLDR.Read = True

                If SQL.SQLDR("item_name").ToString.Length > 25 Then
                    frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                     SQL.SQLDR("total_amount"))
                    frm_receipt_preview.dgw.Height += 38
                    y += 38
                Else
                    frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                        SQL.SQLDR("total_amount"))
                    frm_receipt_preview.dgw.Height += 19
                    y += 19
                End If

                    'If SQL.SQLDR("item_name").ToString.Length > 25 Then
                    '    If SQL.SQLDR("total_amount").ToString.Length > 5 Then
                    '        frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CInt(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                    '                                     SQL.SQLDR("total_amount"))
                    '        frm_receipt_preview.dgw.Height += 38
                    '        y += 38
                    '    Else
                    '        frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CInt(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                    '                                    SQL.SQLDR("total_amount").ToString)
                    '        frm_receipt_preview.dgw.Height += 38
                    '        y += 38
                    '    End If
                    'Else
                    '    If SQL.SQLDR("total_amount").ToString.Length > 5 Then
                    '        frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CInt(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                    '                                     SQL.SQLDR("total_amount"))
                    '        frm_receipt_preview.dgw.Height += 19
                    '        y += 19
                    '    Else
                    '        frm_receipt_preview.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CInt(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                    '                                      ("11" + SQL.SQLDR("total_amount").ToString))
                    '        frm_receipt_preview.dgw.Height += 19
                    '        y += 19
                    '    End If
                    'End If
            Loop

            frm_receipt_preview.pnl_total.Location = New Point(7, 199 + y)
            frm_receipt_preview.pnl_receipt.Height += y
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub LoadItemstoDatagrid_customer()
        Dim y As Integer
        Try
            Dim load As String = "SELECT * FROM sales_item_table WHERE trans_no = '" & frm_invoice.lbl_trans_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            frm_receipt_preview_customer.dgw.Rows.Clear()

            Do While SQL.SQLDR.Read = True

                If SQL.SQLDR("item_name").ToString.Length > 25 Then
                    frm_receipt_preview_customer.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                     SQL.SQLDR("total_amount"))
                    frm_receipt_preview_customer.dgw.Height += 38
                    y += 38
                Else
                    frm_receipt_preview_customer.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                        SQL.SQLDR("total_amount"))
                    frm_receipt_preview_customer.dgw.Height += 19
                    y += 19
                End If
            Loop

            frm_receipt_preview_customer.pnl_total.Location = New Point(7, 199 + y)
            frm_receipt_preview_customer.pnl_receipt.Height += y
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
