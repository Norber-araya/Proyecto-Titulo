Public Class Navegacion
    Private Sub Navegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public tipo As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Usuario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Producto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        proveedor.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BuscarFacturas.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FacturaVenta.Show()
        Close()
    End Sub
End Class