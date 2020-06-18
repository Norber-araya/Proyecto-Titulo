Public Class Factura
    Dim bdconexion As New BD_conexion

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)

        Me.FacturaTableAdapter.Fill(Me.GestiondeinventarioDataSet.factura)
        Label2.Text = Form2.Label3.Text

        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.insertar_factura(N_facturaTextBox.Text, Rut_provTextBox.Text, ComboBox1.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text, Rut_clienteTextBox.Text, DateTimePicker1.Text, ObservacionTextBox.Text, Valor_netoTextBox.Text, IvaTextBox.Text, TotalTextBox.Text)

        Panel1.Visible = True


        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
        Else
            Me.ProductoTableAdapter.FillBy(Me.GestiondeinventarioDataSet.producto, "%" + TextBox2.Text + "%")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bdconexion.insertar_registro(Cod_productoLabel1.Text, TextBox1.Text, N_facturaTextBox.Text, DateTimePicker1.Text, Label2.Text)
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Producto.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub
End Class