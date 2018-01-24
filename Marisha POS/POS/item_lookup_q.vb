Imports System.Data.SqlClient
Imports System.IO

Public Class item_lookup_q

    Dim SQL As New SQLControl

    Public Sub load_items()
        Using cmd As New SqlCommand("SELECT * FROM item_table WHERE category = '" & frm_item_lookup.cbo_category.Text & "' ORDER BY item_name ASC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim btn As New Button()

                        AddHandler btn.Click, AddressOf frm_item_lookup.click_me

                        btn.Name = "btn" + dt.Rows(i)(1)
                        btn.Tag = dt.Rows(i)(0)
                        btn.Text = dt.Rows(i)(2).ToString()
                        btn.Font = New Font("Tahoma", 11.0F, FontStyle.Regular)
                        btn.BackColor = Color.White
                        btn.Height = 100
                        btn.Width = 150
                        btn.TextAlign = ContentAlignment.MiddleCenter
                        frm_item_lookup.flp_items.Controls.Add(btn)
                    Next

                End Using
            End Using
        End Using
    End Sub

    'Load Categories'
    Sub show_categories()
        Try
            Dim show_categories As String = "Select * from category_table ORDER BY category_name ASC"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_categories, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            frm_item_lookup.cbo_category.Items.Clear()
            Do While SQL.SQLDR.Read
                frm_item_lookup.cbo_category.Items.Add(SQL.SQLDR!category_name)
            Loop
            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'INPUT QUANTITY KILOGRAMS'

End Class
