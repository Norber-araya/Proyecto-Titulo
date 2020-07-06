Imports System.Data.SqlClient
Public Class VerBoleta
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")

    Public tipo As String
    Private Sub Detalle_boletaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_boletaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_boletaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub VerBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_boleta' Puede moverla o quitarla según sea necesario.
        Me.Detalle_boletaTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_boleta)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from detalle_boleta where n_boleta LIKE'" & N_boletaTextBox.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "detalle_boleta")
        Detalle_boletaDataGridView.DataSource = DS.Tables("detalle_boleta")
    End Sub

    Private Sub TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub N_boletaTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_boletaTextBox.TextChanged
        dato1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarFacturas.Show()
        Me.Close()
    End Sub
End Class