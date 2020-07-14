Public Class CambiarContraseña
    Dim bdconexion As New BD_conexion
    Public rut As String
    Private Sub CambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Hay campos en blanco")
        ElseIf TextBox1.Text = TextBox2.Text Then
            bdconexion.editar_contraseña(rut, TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class