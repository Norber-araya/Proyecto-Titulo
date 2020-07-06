Imports System.Data.SqlClient

Public Class Verfactura
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")

    Public tipo As String
    Private Sub Detalle_facBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_facBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_facBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Verfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_fac' Puede moverla o quitarla según sea necesario.
        Me.Detalle_facTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_fac)
    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from detalle_fac where n_factura LIKE'" & N_facturaTextBox.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "detalle_fac")
        Detalle_facDataGridView.DataSource = DS.Tables("detalle_fac")
    End Sub

    Private Sub N_facturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_facturaTextBox.TextChanged
        dato1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarFacturas.Show()
        Close()
    End Sub
End Class