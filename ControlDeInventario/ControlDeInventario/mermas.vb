Imports System.Data.SqlClient
Public Class mermas
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut As String
    Private Sub MermasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MermasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from producto where cod_producto LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "producto")
        ProductoDataGridView.DataSource = DS.Tables("producto")
    End Sub

    Private Sub Mermas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.mermas' Puede moverla o quitarla según sea necesario.
        Me.MermasTableAdapter.Fill(Me.ControlinventarioDataSet.mermas)
        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(CantidadTextBox.Text) <= Val(Label2.Text) Then
            bdconexion.insertar_mermas(Cod_productoTextBox.Text, NombreTextBox.Text, CantidadTextBox.Text, FechaDateTimePicker.Text, rtbMensaje.Text)
            bdconexion.actua_prod2(Cod_productoTextBox.Text, CantidadTextBox.Text)
            Me.Refresh()
            CantidadTextBox.Text = ""
            Cod_productoTextBox.Text = ""
            NombreTextBox.Text = ""
            rtbMensaje.Text = ""
            Label2.Text = ""
            Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
            Me.MermasTableAdapter.Fill(Me.ControlinventarioDataSet.mermas)


        Else
            MsgBox("Cantida supera el Stock")
        End If


    End Sub

    Private Sub Cod_productoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cod_productoTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cod_productoTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        NombreTextBox.Text = ProductoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        Label2.Text = ProductoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        Panel1.Visible = False
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
        Me.MermasTableAdapter.Fill(Me.ControlinventarioDataSet.mermas)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Navegacion.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim prod As String
        Dim can As String
        Dim id As Integer
        For Each Fila As DataGridViewRow In MermasDataGridView.Rows

            If Fila.Cells("eliminar").Value <> Nothing Then
                id = Fila.Cells(1).Value.ToString
                prod = Fila.Cells(2).Value.ToString
                can = Fila.Cells(4).Value.ToString
                MsgBox(prod)
                MsgBox(prod)
                MsgBox(can)
                bdconexion.actua_prod(prod, can)
                bdconexion.eliminar_mermas(id)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                Me.MermasTableAdapter.Fill(Me.ControlinventarioDataSet.mermas)
            End If
        Next



    End Sub
End Class