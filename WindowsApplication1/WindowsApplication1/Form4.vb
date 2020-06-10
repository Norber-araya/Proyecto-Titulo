Public Class Form4
    Private Sub Detalle_provBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_provBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_provBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.detalle_prov' Puede moverla o quitarla según sea necesario.
        Me.Detalle_provTableAdapter.Fill(Me.BodegaDataSet.detalle_prov)

    End Sub
End Class