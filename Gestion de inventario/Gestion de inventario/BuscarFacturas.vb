Imports System.Data
Imports System.Data.OleDb
Public Class BuscarFacturas
    Dim conexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Diegoandres\Documents\Proyecto avances\bd\gestiondeinventario.accdb")


    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub BuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.GestiondeinventarioDataSet.factura)

    End Sub

    Public Sub dato1()

        Dim comando = New OleDbDataAdapter(" select * from factura where n_factura LIKE'" & N_factura.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "factura")
        FacturaDataGridView.DataSource = DS.Tables("factura")

    End Sub
    Public Sub dato2()

        Dim comando = New OleDbDataAdapter(" select * from factura where fecha LIKE'" & N_factura.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "factura")
        FacturaDataGridView.DataSource = DS.Tables("Factura")
    End Sub

    Private Sub FacturaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaDataGridView.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles N_factura.TextChanged
        dato1()
    End Sub

    Private Sub Fecha_TextChanged(sender As Object, e As EventArgs) Handles Fecha.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Verfactura.N_facturaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Verfactura.Rut_provTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        Verfactura.Nombre_provTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        Verfactura.DireccionTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        Verfactura.ComunaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        Verfactura.CiudadTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(5).Value.ToString
        Verfactura.EmailTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(6).Value.ToString
        Verfactura.FonoTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(7).Value.ToString
        Verfactura.Rut_clienteTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(8).Value.ToString
        Verfactura.FechaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(9).Value.ToString
        Verfactura.ObservacionTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(10).Value.ToString
        Verfactura.Valor_netoTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(11).Value.ToString
        Verfactura.IvaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(12).Value.ToString
        Verfactura.TotalTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(13).Value.ToString


        Verfactura.Show()
    End Sub

    Private Sub FacturaBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles FacturaBindingNavigator.RefreshItems

    End Sub
End Class