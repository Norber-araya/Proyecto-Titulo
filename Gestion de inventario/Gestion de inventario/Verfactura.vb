Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Public Class Verfactura
    Dim conexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Diegoandres\Documents\Proyecto avances\bd\gestiondeinventario.accdb")
    Public tipo As String
    Private Sub Detalle_facBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_facBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_facBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub Verfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.detalle_fac' Puede moverla o quitarla según sea necesario.
        Me.Detalle_facTableAdapter.Fill(Me.GestiondeinventarioDataSet.detalle_fac)

        If tipo = "100" Or tipo = "101" Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If

    End Sub
    Public Sub dato1()

        Dim comando = New OleDbDataAdapter(" select * from detalle_fac where n_factura LIKE'" & N_facturaTextBox.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "detalle_fac")
        Detalle_facDataGridView.DataSource = DS.Tables("detalle_fac")
    End Sub



    Private Sub Detalle_facDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Detalle_facDataGridView.CellContentClick

    End Sub

    Private Sub N_facturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_facturaTextBox.TextChanged
        dato1()
    End Sub

    Private Sub Rut_provLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Rut_provTextBox_TextChanged(sender As Object, e As EventArgs) Handles Rut_provTextBox.TextChanged

    End Sub

    Private Sub Nombre_provLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nombre_provTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nombre_provTextBox.TextChanged

    End Sub

    Private Sub DireccionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DireccionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DireccionTextBox.TextChanged

    End Sub

    Private Sub ComunaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComunaTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComunaTextBox.TextChanged

    End Sub

    Private Sub CiudadLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CiudadTextBox_TextChanged(sender As Object, e As EventArgs) Handles CiudadTextBox.TextChanged

    End Sub

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub FonoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles FonoTextBox.TextChanged

    End Sub

    Private Sub Rut_clienteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Rut_clienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles Rut_clienteTextBox.TextChanged

    End Sub

    Private Sub FechaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FechaTextBox_TextChanged(sender As Object, e As EventArgs) Handles FechaTextBox.TextChanged

    End Sub

    Private Sub ObservacionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ObservacionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ObservacionTextBox.TextChanged

    End Sub

    Private Sub N_facturaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarFacturas.Show()
        Close()
    End Sub
End Class