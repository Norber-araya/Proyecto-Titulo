Public Class Form1

    Dim bdconexion As New BD_conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.login(usuariotxt.Text, contraseñatxt.Text)
        usuariotxt.Text = ""
        contraseñatxt.Text = ""
        usuariotxt.Focus()
    End Sub
    Private Sub contraseñatxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contraseñatxt.KeyPress
        If e.KeyChar = Chr(13) Then
            bdconexion.login(usuariotxt.Text, contraseñatxt.Text)
        End If
    End Sub
End Class
