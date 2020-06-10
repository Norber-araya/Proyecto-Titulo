Public Class Form5
    Dim bdconexion As New BD_conexion
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BodegaDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BodegaDataSet.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.detalle_fac' Puede moverla o quitarla según sea necesario.
        Me.Detalle_facTableAdapter.Fill(Me.BodegaDataSet.detalle_fac)
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.BodegaDataSet.factura)
        Panel1.Visible = False
    End Sub

    Private Sub ProveedorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedorDataGridView.CellContentClick

    End Sub

    Private Sub ProveedorDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProveedorDataGridView.SelectionChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bdconexion.insertar_factura(N_facturaTextBox.Text, Nombre_provTextBox.Text, Rut_provTextBox.Text, ContactoTextBox.Text, ComunaTextBox.Text, DireccionTextBox.Text, MailTextBox.Text, DetalleTextBox.Text, Nombre_prodTextBox.Text,
                                    Valor_nTextBox.Text, Valor_tTextBox.Text, DateTimePicker1.Text, ObservacionTextBox.Text, IvaTextBox.Text, CiudadTextBox.Text)

        bdconexion.insertar_detalle_fac(N_facturaTextBox.Text, IdTextBox.Text, CantidadTextBox.Text, Nombre_prodTextBox.Text, PrecioTextBox.Text, "0")
        Me.FacturaTableAdapter.Fill(Me.BodegaDataSet.factura)
    End Sub
End Class