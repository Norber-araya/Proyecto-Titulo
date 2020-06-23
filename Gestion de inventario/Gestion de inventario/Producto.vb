Public Class Producto
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public nombre As String
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Navegacion.Show()
        Close()
    End Sub
End Class