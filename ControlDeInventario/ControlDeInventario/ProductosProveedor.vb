Public Class ProductosProveedor
    Private Sub Detalle_proveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Detalle_proveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub ProductosProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Detalle_proveedorTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_proveedor)

    End Sub
End Class