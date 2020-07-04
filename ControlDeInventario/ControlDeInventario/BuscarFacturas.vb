Imports System.Data.SqlClient
Public Class BuscarFacturas
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from factura where n_factura LIKE'" & N_factura.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "factura")
        FacturaDataGridView.DataSource = DS.Tables("factura")

    End Sub
    Public Sub dato2()

        Dim comando = New SqlDataAdapter(" select * from factura where fecha LIKE'" & N_factura.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "factura")
        FacturaDataGridView.DataSource = DS.Tables("Factura")
    End Sub

    Private Sub BuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ControlinventarioDataSet.factura)

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

        Verfactura.tipo = tipo
        Verfactura.Show()
        Me.Hide()
    End Sub

    Private Sub N_factura_TextChanged(sender As Object, e As EventArgs) Handles N_factura.TextChanged
        dato1()
    End Sub

    Private Sub Fecha_TextChanged(sender As Object, e As EventArgs) Handles Fecha.TextChanged
        dato2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navegacion.Show()
        Close()
    End Sub
End Class