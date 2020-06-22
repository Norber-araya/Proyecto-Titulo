Public Class proveedor

    Dim bdconexion As New BD_conexion
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.insertar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bdconexion.editar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bdconexion.eliminar_prov(Rut_provTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)
    End Sub
End Class