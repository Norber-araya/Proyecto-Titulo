Public Class Form6
    Private Sub BodegaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BodegaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BodegaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me.BodegaDataSet.bodega)

    End Sub
End Class