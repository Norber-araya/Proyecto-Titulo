Imports System.Data.SqlClient
Public Class Producto
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut As String
    Public tipo As String
    Public nombre As String
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
        Panel1.Visible = False

    End Sub

    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from proveedor where rut_prov LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "proveedor")
        ProveedorDataGridView.DataSource = DS.Tables("proveedor")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cod_productoTextBox.Text = "" Or ProductoTextBox.Text = "" Or PrecioTextBox.Text = "" Then
            MsgBox("Hay campos en blancos ")
        ElseIf proveedor.Text = "" Then
            MsgBox("No a seleccionad a un proveedor")
        Else
            bdconexion.insertar_prod(Cod_productoTextBox.Text, ProductoTextBox.Text, PrecioTextBox.Text, ComboBox1.Text)
            bdconexion.insertar_DetaProv(Cod_productoTextBox.Text, proveedor.Text)
            Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

            Cod_productoTextBox.Text = ""
            ProductoTextBox.Text = ""
            PrecioTextBox.Text = ""
            proveedor.Text = ""
            ComboBox1.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub



    Private Sub PrecioTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        proveedor.Text = ProveedorDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Navegacion.Show()
        Me.Close()
    End Sub

    Private Sub PrecioTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ProductoProveedor.Show()
    End Sub
End Class