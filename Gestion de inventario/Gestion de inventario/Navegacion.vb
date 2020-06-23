Public Class Navegacion

    Private Sub Navegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tipo.Text = "100" Or tipo.Text = "101" Then
            Producto.rut = rut.Text
            Producto.tipo = tipo.Text
        Producto.nombre = nombre.Text
        Usuario.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tipo.Text = "100" Or tipo.Text = "101" Then
            Producto.rut = rut.Text
            Producto.tipo = tipo.Text
            Producto.nombre = nombre.Text
            Producto.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tipo.Text = "100" Or tipo.Text = "101" Then
            proveedor.rut = rut.Text
            proveedor.tipo = tipo.Text
            proveedor.nombre = nombre.Text
            proveedor.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tipo.Text = "100" Or tipo.Text = "101" Then
            Factura.rut = rut.Text
            Factura.tipo = tipo.Text
            Factura.nombre = nombre.Text
            Factura.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BuscarFacturas.rut = rut.Text
        BuscarFacturas.tipo = tipo.Text
        BuscarFacturas.nombre = nombre.Text
        BuscarFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If tipo.Text = "100" Or tipo.Text = "101" Then
            FacturaVenta.rut = rut.Text
            FacturaVenta.tipo = tipo.Text
            FacturaVenta.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class