Public Class Menu
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Usuario.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form1.usuariotxt.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Producto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        proveedor.Show()
    End Sub
End Class