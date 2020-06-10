Public Class Form2
    Dim bdconexion As New BD_conexion

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BodegaDataSet.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BodegaDataSet.productos)
        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.insertar_prod(IdTextBox.Text, Nombre_prodTextBox.Text, PrecioTextBox.Text, DescripcionTextBox.Text)
        bdconexion.insertar_bod("1", IdTextBox.Text, Nombre_prodTextBox.Text, "0", DateTimePicker1.Text)
        bdconexion.insertar_detalleprov(IdTextBox.Text, Label3.Text)
        Me.ProductosTableAdapter.Fill(Me.BodegaDataSet.productos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        bdconexion.editar_prod(IdTextBox.Text, Nombre_prodTextBox.Text, PrecioTextBox.Text, DescripcionTextBox.Text)
        Me.ProductosTableAdapter.Fill(Me.BodegaDataSet.productos)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bdconexion.eliminar_prod(IdTextBox.Text)
        Me.ProductosTableAdapter.Fill(Me.BodegaDataSet.productos)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BodegaDataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = True
    End Sub

    Private Sub ProveedorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ProveedorDataGridView_SelectionChanged(sender As Object, e As EventArgs)

        If Rut_provTextBox.Text = "" Then

        Else
            Label3.Text = Rut_provTextBox.Text
        End If

    End Sub
End Class