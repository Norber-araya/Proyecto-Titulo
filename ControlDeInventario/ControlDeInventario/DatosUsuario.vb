Public Class DatosUsuario
    Dim bdconexion As New BD_conexion
    Public rut As String
    Private Sub DatosUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        dato1()
    End Sub
    Public Sub dato1()
        bdconexion.select_usuario(rut)

    End Sub

    Private Sub ContactoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MsgBox("Hay campos en blanco")
        Else
            bdconexion.editar_usuario(RutTextBox.Text, rut, NombreTextBox.Text, ContactoTextBox.Text, GeneroTextBox.Text, EmailTextBox.Text)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CambiarContraseña.rut = rut
        bdconexion.select_usuario2(TextBox1.Text, TextBox2.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navegacion.Show()
        Me.Close()
    End Sub
End Class