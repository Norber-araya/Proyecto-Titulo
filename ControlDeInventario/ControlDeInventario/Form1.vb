Public Class Form1
    Dim bdconexion As New BD_conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.prueba(usuariotxt.Text)
        bdconexion.login(usuariotxt.Text, contraseñatxt.Text)
        usuariotxt.Text = ""
        contraseñatxt.Text = ""

    End Sub
    Private Sub contraseñatxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contraseñatxt.KeyPress
        If e.KeyChar = Chr(13) Then
            bdconexion.prueba(usuariotxt.Text)
            bdconexion.login(usuariotxt.Text, contraseñatxt.Text)

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
