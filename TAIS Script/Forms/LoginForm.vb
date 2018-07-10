Public Class LoginForm

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If (txtBoxUsername.Text = "admin" And txtBoxPassword.Text = "@dmin") Then
            FrmGeneral.SF_ADMIN = True

            Close()
        Else
            FrmGeneral.SF_ADMIN = False

            MessageBox.Show("Invalid username or password", "Error")
        End If
    End Sub
End Class