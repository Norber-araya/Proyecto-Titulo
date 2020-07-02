Public Class proveedor
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public nombre As String
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bdconexion.insertar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        proveedorEdid.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each Fila As DataGridViewRow In ProveedorDataGridView.Rows

            If Fila.Cells("eliminar").Value <> Nothing Then
                Dim dato As String = Fila.Cells(1).Value.ToString
                bdconexion.eliminar_prov(dato)

            End If

        Next

        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Navegacion.Show()
        Me.Close()
    End Sub
End Class