Public Class Producto
    Dim bdconexion As New BD_conexion
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.insertar_prod(Cod_productoTextBox.Text, ProductoTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text, DateTimePicker1.Text)
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bdconexion.eliminar_prod(Cod_productoTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bdconexion.editar_prod(Cod_productoTextBox.Text, ProductoTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text, DateTimePicker1.Text)
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
        Else
            Me.ProductoTableAdapter.FillBy(Me.GestiondeinventarioDataSet.producto, "%" + TextBox1.Text + "%")
        End If
    End Sub
End Class