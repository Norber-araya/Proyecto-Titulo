Imports System.Data.SqlClient
Public Class ProductoProveedor
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")

    Private Sub Detalle_proveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Detalle_proveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub ProductoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Detalle_proveedorTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_proveedor)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from detalle_proveedor where cod_producto LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "detalle_proveedor")
        Detalle_proveedorDataGridView.DataSource = DS.Tables("detalle_proveedor")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub
End Class