Imports System.Data.SqlClient
Public Class proveedorEdid
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut2 As String
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub ProveedorEdid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from proveedor where rut_prov LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "proveedor")
        ProveedorDataGridView.DataSource = DS.Tables("proveedor")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rut_provTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Nombre_provTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        DireccionTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        ComunaTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        CiudadTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        EmailTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(5).Value.ToString
        FonoTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(6).Value.ToString
        rut2 = Rut_provTextBox.Text
    End Sub

    Private Sub ProveedorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedorDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Rut_provTextBox.Text = "" Or Nombre_provTextBox.Text = "" Or DireccionTextBox.Text = "" Or ComunaTextBox.Text = "" Or CiudadTextBox.Text = "" Or EmailTextBox.Text = "" Or FonoTextBox.Text = "" Then
            MsgBox("Hay campos en blanco")
        Else
            bdconexion.editar_prov(Rut_provTextBox.Text, rut2, Nombre_provTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        proveedor.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub
End Class