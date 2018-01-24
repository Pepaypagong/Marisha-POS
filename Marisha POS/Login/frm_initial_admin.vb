Public Class frm_initial_admin
    Dim login_query As New login_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_admin_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public imgName As String
    Sub uploadimage()
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()

            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                imgName = dlgImage.FileName

                Dim newimg As New Bitmap(imgName)

                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ae As System.ArgumentException
            imgName = " "

            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub cmd_loadpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_loadpic.Click
        uploadimage()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If IncompleteInput() = True Then
            Exit Sub
        Else
            If MsgBox(" ACCOUNT INFORMATION " & vbCrLf & _
                      " Account No : " + lbl_account_no.Text & vbCrLf & "" + _
                      " Username : " + txt_username.Text & vbCrLf & "" + _
                      " Password : " + txt_password.Text & vbCrLf & "" + _
                      " Position : " + txt_position.Text & vbCrLf & "" + _
                      " First Name : " + txt_fname.Text & vbCrLf & "" + _
                      " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                      " Last Name : " + txt_lname.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Save?") = MsgBoxResult.Yes Then
                login_query.insert_account()
                Me.Close()
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_account_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.pic.Image Is Nothing Then
            MsgBox(" Please Put a picture!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.cmd_loadpic.Focus()
            Return True
        ElseIf Me.txt_username.Text = "" Then
            MsgBox(" Please Input the Username!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_username.Focus()
            Return True
        ElseIf Me.txt_password.Text = "" Then
            MsgBox(" Please Input the Password!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_password.Focus()
            Return True
        ElseIf Me.txt_confirm_pass.Text = "" Then
            MsgBox(" Please Confirm Password!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_confirm_pass.Focus()
            Return True
        ElseIf Me.txt_password.Text <> Me.txt_confirm_pass.Text Then
            MsgBox(" Password Not The Same, Please Retype the Password!", MsgBoxStyle.Critical, " Incorrect Fields!")
            Me.txt_confirm_pass.Clear()
            Me.txt_confirm_pass.Focus()
            Return True
        ElseIf Me.txt_position.Text = "" Then
            MsgBox(" Please Input the Position!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_position.Focus()
            Return True
        ElseIf Me.txt_fname.Text = "" Then
            MsgBox(" Please Input the First Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_fname.Focus()
            Return True
        ElseIf Me.txt_mname.Text = "" Then
            MsgBox(" Please Input the Middle Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_mname.Focus()
            Return True
        ElseIf Me.txt_lname.Text = "" Then
            MsgBox(" Please Input the Last Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_lname.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub noenter_numbers_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txt_fname.KeyPress, txt_mname.KeyPress, txt_lname.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
            And Not e.KeyChar = Chr(Keys.Delete) _
            And Not e.KeyChar = Chr(Keys.Back) _
            And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub


End Class