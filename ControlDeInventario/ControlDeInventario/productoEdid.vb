Imports System.Data.SqlClient
Public Class productoEdid
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public cod As String
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub ProductoEdid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from producto where cod_producto LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "producto")
        ProductoDataGridView.DataSource = DS.Tables("producto")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cod_productoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        ProductoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        CantidadTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        PrecioTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        cod = Cod_productoTextBox.Text
        MsgBox(cod)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Cod_productoTextBox.Text = "" Or ProductoTextBox.Text = "" Or CantidadTextBox.Text = "" Or PrecioTextBox.Text = "" Then
            MsgBox("Hay campos en blancos ")
        Else
            bdconexion.editar_prod(Cod_productoTextBox.Text, cod, ProductoTextBox.Text, CantidadTextBox.Text, PrecioTextBox.Text)

        End If
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Producto.Show()
        Me.Close()
    End Sub

    Private Sub CantidadTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CantidadTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub PrecioTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub
End Class