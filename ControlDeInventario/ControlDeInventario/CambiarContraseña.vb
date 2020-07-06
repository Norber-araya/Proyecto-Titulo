Public Class CambiarContraseña
    Private Sub CambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DatosUsuario.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Se cambion la contraseña")
        Form1.Show()
        Me.Close()
    End Sub
End Class