Public Class Provedores
    Dim bdconexion As New BD_conexion
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter1.Fill(Me.BodegaDataSet1.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        'ProveedorDataGridView.ClearSelection()
        Rut_provTextBox.Text = ""

    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        If Rut_provTextBox.Text = "" Then

        Else
            'llamo al insertar que esta en bd_conexion
            bdconexion.insertar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ContactoTextBox.Text)
        End If
        Me.ProveedorTableAdapter.Fill(Me.BodegaDataSet.proveedor)
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        If Rut_provTextBox.Text = "" Then

        Else
            'llamo al editar que esta en bd_conexion
            bdconexion.editar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ContactoTextBox.Text)
        End If
        Me.ProveedorTableAdapter.Fill(Me.BodegaDataSet.proveedor)
    End Sub

    Private Sub ProveedorBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        'llamo al eliminar que esta en bd_conexion
        bdconexion.eliminar_prov(Rut_provTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.BodegaDataSet.proveedor)
    End Sub

    Private Sub Provedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProveedorBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BodegaDataSet1)

    End Sub
End Class