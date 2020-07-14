Imports System.Data.SqlClient
Public Class VerGuia
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public tipo As String
    Private Sub Detalle_guiaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Detalle_guiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub VerGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_guia' Puede moverla o quitarla según sea necesario.
        Me.Detalle_guiaTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_guia)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from detalle_guia where n_guia LIKE'" & N_facturaTextBox.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "detalle_fac_ingreso")
        Detalle_guiaDataGridView.DataSource = DS.Tables("detalle_fac_ingreso")
    End Sub

    Private Sub N_facturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_facturaTextBox.TextChanged
        dato1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarFacturas.Show()
        Close()
    End Sub
End Class