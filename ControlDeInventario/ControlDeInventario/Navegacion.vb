Public Class Navegacion
    Public tipo As String
    Private Sub Navegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo = "100" Then
            permiso.Text = "Root"
        End If
        If tipo = "101" Then
            permiso.Text = "Administardor Gerente"
        End If
        If tipo = "102" Then
            permiso.Text = "Gerente"
        End If
        If tipo = "103" Then
            permiso.Text = "Operador Bodega"
        End If
        If tipo = "104" Then
            permiso.Text = "Visita"
        End If
        If tipo = "105" Then
            permiso.Text = "Vendedor"
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tipo = "100" Or tipo = "101" Then
            'Usuario.rut = rut.Text
            Usuario.tipo = tipo
            'Usuario.nombre = nombre.Text
            Usuario.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tipo = "100" Or tipo = "101" Then
            Producto.rut = rut.Text
            Producto.tipo = tipo
            Producto.nombre = nombre.Text
            Producto.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tipo = "100" Or tipo = "101" Then
            proveedor.rut = rut.Text
            proveedor.tipo = tipo
            proveedor.nombre = nombre.Text
            proveedor.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tipo = "100" Or tipo = "101" Or tipo = "103" Then
            Factura.rut = rut.Text
            Factura.tipo = tipo
            Factura.nombre = nombre.Text
            Factura.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BuscarFacturas.rut = rut.Text
        BuscarFacturas.tipo = tipo
        'BuscarFacturas.nombre = nombre.Text
        BuscarFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If tipo = "100" Or tipo = "101" Or tipo = "103" Then
            FacturaVenta.rut = rut.Text
            FacturaVenta.tipo = tipo
            FacturaVenta.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bodega.tipo = tipo
        Bodega.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If tipo = "100" Or tipo = "101" Or tipo = "103" Then
            mermas.rut = rut.Text
            mermas.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If tipo = "100" Or tipo = "101" Then
            cliente.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If tipo = "100" Or tipo = "101" Then
            Consulta.Show()
            Me.Hide()
        Else
            MsgBox("No tiene permiso")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Form1.Show()
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If tipo = "100" Or tipo = "101" Then
            boleta.rut = rut.Text
            boleta.tipo = tipo
            boleta.Show()

        Else
            MsgBox("No tiene permiso")
        End If
    End Sub
End Class