Imports System.Data.SqlClient
Imports System.IO
Public Class ItemFlowService

    Dim SQL As New SQLControl

    Public Sub InsertItemFlow(item_no As Integer, date_time As DateTime, trans_type As String,
                              item_in As Decimal, item_out As Decimal, is_initial_entry As Integer, 
                              buying_price As Decimal)

        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@item_no", item_no)
            params.Add("@date", date_time)
            params.Add("@trans_type", trans_type)
            params.Add("@item_in", item_in)
            params.Add("@item_out", item_out)
            params.Add("@is_initial_entry", is_initial_entry)
            params.Add("@buying_price", buying_price)

            Dim query As String = "INSERT INTO item_flow_table" & 
                "(item_no,date,trans_type,item_in,item_out,is_initial_entry,buying_price)VALUES " & 
                "(@item_no,@date,@trans_type,@item_in,@item_out,@is_initial_entry,@buying_price)"

            SQL.GlobalInsertUpdateDelete(query,params)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

                'new global insert for item flow
                'For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                '    itemFlowServce.InsertItemFlow(row.Cells(0).Value, DateTime.Now, 
                '                                  "SALES", 0, row.Cells(4).Value, 0, row.Cells(9).Value)
                'Next


End Class
