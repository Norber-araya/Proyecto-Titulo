Imports System.Data.SqlClient
Public Class BuscarFacturas
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public documento As Integer = 0
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Public Sub dato1()
        If documento = 1 Then
            Dim comando = New SqlDataAdapter(" select * from factura where n_factura LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "factura")
            FacturaDataGridView.DataSource = DS.Tables("factura")
        End If
        If documento = 2 Then
            Dim comando = New SqlDataAdapter(" select * from boleta where n_boleta LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "boleta")
            BoletaDataGridView.DataSource = DS.Tables("boleta")
        End If


    End Sub
    Public Sub dato2()
        If documento = 1 Then
            Dim comando = New SqlDataAdapter(" select * from factura where fecha LIKE'" & DateTimePicker1.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "factura")
            FacturaDataGridView.DataSource = DS.Tables("Factura")
        End If
        If documento = 2 Then
            Dim comando = New SqlDataAdapter(" select * from boleta where fecha LIKE'" & DateTimePicker1.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "boleta")
            BoletaDataGridView.DataSource = DS.Tables("boleta")
        End If

    End Sub

    Private Sub BuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.boleta' Puede moverla o quitarla según sea necesario.
        Me.BoletaTableAdapter.Fill(Me.ControlinventarioDataSet.boleta)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ControlinventarioDataSet.factura)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If documento = 1 Then
            Verfactura.N_facturaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            Verfactura.Rut_provTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            Verfactura.Nombre_provTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            Verfactura.DireccionTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            Verfactura.ComunaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Verfactura.CiudadTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            Verfactura.EmailTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            Verfactura.FonoTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(7).Value.ToString
            Verfactura.Rut_clienteTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(8).Value.ToString
            Verfactura.FechaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(9).Value.ToString
            Verfactura.ObservacionTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(10).Value.ToString
            Verfactura.Valor_netoTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(11).Value.ToString
            Verfactura.IvaTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(12).Value.ToString
            Verfactura.TotalTextBox.Text = FacturaDataGridView.CurrentRow.Cells.Item(13).Value.ToString

            Verfactura.tipo = tipo
            Verfactura.Show()
            Me.Hide()
        End If

        If documento = 2 Then
            VerBoleta.N_boletaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            VerBoleta.Rut_empresaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            VerBoleta.Rut_clienteTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            VerBoleta.Nombre_empresaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            VerBoleta.DirecionTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            VerBoleta.FechaDateTimePicker.Text = BoletaDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            VerBoleta.TotalTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            VerBoleta.tipo = tipo
            VerBoleta.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub N_factura_TextChanged(sender As Object, e As EventArgs) Handles N_factura.TextChanged
        dato1()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navegacion.Show()
        Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        FacturaDataGridView.Visible = False
        BoletaDataGridView.Visible = True
        documento = 2

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        BoletaDataGridView.Visible = False
        FacturaDataGridView.Visible = True
        documento = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DateTimePicker1.Visible = False
        N_factura.Visible = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        N_factura.Visible = False
        DateTimePicker1.Visible = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        dato2()
    End Sub
End Class