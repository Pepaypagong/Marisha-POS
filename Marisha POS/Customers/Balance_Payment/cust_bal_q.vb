Imports System.Data.SqlClient
Imports System.IO

Public Class cust_bal_q

    Dim SQL As New SQLControl

    Public Sub load_payments()
        Using cmd As New SqlCommand("SELECT * FROM customer_payments_table WHERE customer_no = '" & frm_payment_records.lbl_customer_no.Text & "' AND amount_paid > '0' " & _
                                    "ORDER BY ID DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_payment_records.dgv_payments.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_payment_records.dgv_payments.Columns(0).DataPropertyName = "ID"
                    frm_payment_records.dgv_payments.Columns(1).DataPropertyName = "date_pay"
                    frm_payment_records.dgv_payments.Columns(2).DataPropertyName = "customer_no"
                    frm_payment_records.dgv_payments.Columns(3).DataPropertyName = "amount_paid"

                    frm_payment_records.dgv_payments.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_filter_payments()
        Using cmd As New SqlCommand("SELECT * FROM customer_payments_table WHERE customer_no = '" & frm_payment_records.lbl_customer_no.Text & "' " & _
                                    "AND date_pay between '" & frm_payment_records.dtp_from.Value.ToString("yyyy/MM/dd") & "' AND '" & frm_payment_records.dtp_to.Value.ToString("yyyy/MM/dd") & "' AND amount_paid > '0' " & _
                                    "ORDER BY ID DESC", SQL.SQLCon)

            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_payment_records.dgv_payments.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_payment_records.dgv_payments.Columns(0).DataPropertyName = "ID"
                    frm_payment_records.dgv_payments.Columns(1).DataPropertyName = "date_pay"
                    frm_payment_records.dgv_payments.Columns(2).DataPropertyName = "customer_no"
                    frm_payment_records.dgv_payments.Columns(3).DataPropertyName = "amount_paid"

                    frm_payment_records.dgv_payments.DataSource = dt
                End Using
            End Using
        End Using
    End Sub


    'INSERT PAYMENT RECORD'
    Public Sub inser_pay()
        Try
            Dim inser_pay As String = "INSERT INTO customer_payments_table(date_pay,customer_no,amount_paid)VALUES " & _
            "(@date_pay,@customer_no,@amount_paid)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(inser_pay, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@date_pay", frm_balance_pay.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_payment_records.lbl_customer_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@amount_paid", frm_balance_pay.txt_amount.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Payment Successfully Recorded!", MsgBoxStyle.Information, " Payment Recorded")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'DELETE RECORD'
    Sub delete_pay()
        Try
            Dim delete_pay As String = "Delete from customer_payments_table WHERE ID = @ID"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_pay, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@ID", frm_payment_records.lbl_pay_id.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'cust_payment' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_payment_records.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub
End Class
