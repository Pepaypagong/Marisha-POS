Imports System.Data.SqlClient
Imports System.IO

Public Class brands_q

    Dim SQL As New SQLControl

    Public Sub load_brand()
        Using cmd As New SqlCommand("SELECT * FROM brand_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_brandss.dgv_brand.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_brandss.dgv_brand.Columns(0).DataPropertyName = "brand_no"
                    frm_brandss.dgv_brand.Columns(1).DataPropertyName = "brand_name"

                    frm_brandss.dgv_brand.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'New category'

    'GET cat NO.'
    Public Sub get_brand_no()
        Try
            Dim get_brand_no As String = "SELECT brand_no FROM brand_table ORDER BY brand_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_brand_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_brands_addupdate.lbl_brand_no.Text = SQL.SQLDR("brand_no") + 1
            Else
                frm_brands_addupdate.lbl_brand_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT brand'
    Public Sub insert_brand()
        Try
            Dim insert_brand As String = "INSERT INTO brand_table(brand_no,brand_name)VALUES " & _
            "(@brand_no,@brand_name)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_brand, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@brand_no", frm_brands_addupdate.lbl_brand_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@brand_name", frm_brands_addupdate.txt_brand_name.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Brand Successfully Added!", MsgBoxStyle.Information, " Brand Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'UPDATING CUSTOMERS'
    Sub update_brand()

        Try
            Dim update_brand As String = "UPDATE brand_table SET brand_name = @brand_name " & _
                                            "WHERE brand_no = @brand_no"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_brand, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@brand_name", frm_brands_addupdate.txt_brand_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@brand_no", frm_brands_addupdate.lbl_brand_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Brand Record Successfully Updated!", MsgBoxStyle.Information, " Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

End Class
