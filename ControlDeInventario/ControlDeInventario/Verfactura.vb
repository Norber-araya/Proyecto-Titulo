Imports System.Data.SqlClient

Public Class Verfactura
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public tipo As String
    Public documento As Integer
    Private Sub Detalle_facBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_facBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_facBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Verfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_fac_egreso' Puede moverla o quitarla según sea necesario.
        Me.Detalle_fac_egresoTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_fac_egreso)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.detalle_fac_ingreso' Puede moverla o quitarla según sea necesario.
        Me.Detalle_fac_ingresoTableAdapter.Fill(Me.ControlinventarioDataSet.detalle_fac_ingreso)
        Detalle_fac_egresoDataGridView.Visible = False
        Detalle_fac_ingresoDataGridView.Visible = False
        dato1()
    End Sub
    Public Sub dato1()
        If documento = 1 Then
            Detalle_fac_ingresoDataGridView.Visible = True
            Dim comando = New SqlDataAdapter(" select * from detalle_fac_ingreso where n_factura LIKE'" & N_facturaTextBox.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "detalle_fac_ingreso")
            Detalle_fac_ingresoDataGridView.DataSource = DS.Tables("detalle_fac_ingreso")
        End If
        If documento = 2 Then
            Detalle_fac_egresoDataGridView.Visible = True
            Dim comando = New SqlDataAdapter(" select * from detalle_fac_egreso where n_factura LIKE'" & N_facturaTextBox.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "detalle_fac_egreso")
            Detalle_fac_egresoDataGridView.DataSource = DS.Tables("detalle_fac_egreso")
        End If

    End Sub

    Private Sub N_facturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_facturaTextBox.TextChanged
        dato1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarFacturas.Show()
        Close()
    End Sub

    Private Sub Detalle_facBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub
End Class