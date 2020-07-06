Imports System.Data.SqlClient
Public Class elegir_producto
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")

    Public tipo As Integer
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Elegir_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

    End Sub

    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from producto where cod_producto LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "producto")
        ProductoDataGridView.DataSource = DS.Tables("producto")
    End Sub

    Private Sub ProductoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductoDataGridView.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tipo = 1 Then
            boleta.Cod_productoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            boleta.NombreTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            boleta.PrecioTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            boleta.Label2.Text = ProductoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Me.Close()
        End If

        If tipo = 2 Then
            Factura.cod_producto.Text = ProductoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            Factura.ProductoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            Factura.Label5.Text = ProductoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Me.Close()
        End If
        If tipo = 3 Then
            FacturaVenta.cod_producto.Text = ProductoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            FacturaVenta.ProductoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            FacturaVenta.precio.Text = ProductoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            FacturaVenta.Label3.Text = ProductoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Me.Close()
        End If

    End Sub
End Class