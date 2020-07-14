Public Class Form1
    Dim bdconexion As New BD_conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
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
            usuariotxt.Text = ""
            contraseñatxt.Text = ""
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("escriba su usuario")
        Else
            bdconexion.recuperar_contraseña(TextBox1.Text)
            Panel1.Visible = False
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
