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
            Dim comando = New SqlDataAdapter(" select * from factura_ingreso where n_factura LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "factura_ingreso")
            Factura_ingresoDataGridView.DataSource = DS.Tables("factura_ingreso")
        End If
        If documento = 2 Then
            Dim comando = New SqlDataAdapter(" select * from factura_ingreso where n_factura LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "factura_ingreso")
            Factura_ingresoDataGridView.DataSource = DS.Tables("factura_ingreso")
        End If
        If documento = 3 Then
            Dim comando = New SqlDataAdapter(" select * from boleta where n_boleta LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "boleta")
            BoletaDataGridView.DataSource = DS.Tables("boleta")
        End If
        If documento = 4 Then
            Dim comando = New SqlDataAdapter(" select * from guia_despacho where n_guia LIKE'" & N_factura.Text & "%'", conexion)
            Dim DS As New DataSet
            comando.Fill(DS, "guia_despacho")
            Guia_despachoDataGridView.DataSource = DS.Tables("guia_despacho")
        End If
    End Sub
    Public Sub dato2()


    End Sub
    Public Sub dato3()
        Dim venta As String = "venta"
        Dim comando = New SqlDataAdapter(" select * from factura where tipo LIKE'" & venta & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "Factura")
        Factura_ingresoDataGridView.DataSource = DS.Tables("Factura")
    End Sub

    Private Sub BuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.mermas' Puede moverla o quitarla según sea necesario.
        Me.MermasTableAdapter.Fill(Me.ControlinventarioDataSet.mermas)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.guia_despacho' Puede moverla o quitarla según sea necesario.
        Me.Guia_despachoTableAdapter.Fill(Me.ControlinventarioDataSet.guia_despacho)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.factura_ingreso' Puede moverla o quitarla según sea necesario.
        Me.Factura_ingresoTableAdapter.Fill(Me.ControlinventarioDataSet.factura_ingreso)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.boleta' Puede moverla o quitarla según sea necesario.
        Me.BoletaTableAdapter.Fill(Me.ControlinventarioDataSet.boleta)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.Factura_egresoTableAdapter.Fill(Me.ControlinventarioDataSet.factura_egreso)
        'TODO: esta línea de código carga datos en la tabla 'Controlinven

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If documento = 1 Then
            Verfactura.N_facturaTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            Verfactura.Rut_provTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            Verfactura.Nombre_provTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            Verfactura.DireccionTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            Verfactura.ComunaTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Verfactura.CiudadTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            Verfactura.EmailTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            Verfactura.FonoTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(7).Value.ToString
            Verfactura.Rut_clienteTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(8).Value.ToString
            Verfactura.FechaTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(9).Value.ToString
            Verfactura.ObservacionTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(10).Value.ToString
            Verfactura.Valor_netoTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(11).Value.ToString
            Verfactura.IvaTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(12).Value.ToString
            Verfactura.TotalTextBox.Text = Factura_ingresoDataGridView.CurrentRow.Cells.Item(13).Value.ToString
            Verfactura.documento = 1
            Verfactura.tipo = tipo
            Me.Hide()
            Verfactura.Show()

        End If
        If documento = 2 Then
            Verfactura.N_facturaTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            Verfactura.Rut_provTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            Verfactura.Nombre_provTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            Verfactura.DireccionTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            Verfactura.ComunaTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            Verfactura.CiudadTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            Verfactura.EmailTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            Verfactura.FonoTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(7).Value.ToString
            Verfactura.Rut_clienteTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(8).Value.ToString
            Verfactura.FechaTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(9).Value.ToString
            Verfactura.ObservacionTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(10).Value.ToString
            Verfactura.Valor_netoTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(11).Value.ToString
            Verfactura.IvaTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(12).Value.ToString
            Verfactura.TotalTextBox.Text = Factura_egresoDataGridView.CurrentRow.Cells.Item(13).Value.ToString
            Verfactura.documento = 2
            Me.Hide()
            Verfactura.Show()


        End If
        If documento = 3 Then
            VerBoleta.N_boletaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            VerBoleta.Rut_empresaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            VerBoleta.Rut_clienteTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            VerBoleta.Nombre_empresaTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            VerBoleta.DirecionTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            VerBoleta.FechaDateTimePicker.Text = BoletaDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            VerBoleta.TotalTextBox.Text = BoletaDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            VerBoleta.tipo = tipo
            Me.Hide()
            VerBoleta.Show()


        End If

        If documento = 4 Then
            VerGuia.N_facturaTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            VerGuia.Rut_provTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(1).Value.ToString
            VerGuia.Nombre_provTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(2).Value.ToString
            VerGuia.DireccionTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(3).Value.ToString
            VerGuia.ComunaTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(4).Value.ToString
            VerGuia.CiudadTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(5).Value.ToString
            VerGuia.EmailTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(6).Value.ToString
            VerGuia.FonoTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(7).Value.ToString
            VerGuia.Rut_clienteTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(8).Value.ToString
            VerGuia.FechaTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(9).Value.ToString
            VerGuia.ObservacionTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(10).Value.ToString
            VerGuia.Valor_netoTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(11).Value.ToString
            VerGuia.IvaTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(12).Value.ToString
            VerGuia.TotalTextBox.Text = Guia_despachoDataGridView.CurrentRow.Cells.Item(13).Value.ToString
            VerGuia.tipo = tipo
            Me.Hide()
            VerGuia.Show()


        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Factura_ingresoDataGridView.Visible = False
        Factura_egresoDataGridView.Visible = False
        Guia_despachoDataGridView.Visible = False
        BoletaDataGridView.Visible = True
        documento = 3

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        BoletaDataGridView.Visible = False
        Factura_egresoDataGridView.Visible = False
        Guia_despachoDataGridView.Visible = False
        Factura_ingresoDataGridView.Visible = True
        documento = 1
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        BoletaDataGridView.Visible = False
        Factura_egresoDataGridView.Visible = True
        Guia_despachoDataGridView.Visible = False
        Factura_ingresoDataGridView.Visible = False
        documento = 2
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        BoletaDataGridView.Visible = False
        Factura_egresoDataGridView.Visible = False
        Guia_despachoDataGridView.Visible = True
        Factura_ingresoDataGridView.Visible = False
        documento = 4
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navegacion.Show()
        Close()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        dato2()
    End Sub
    Private Sub N_factura_TextChanged(sender As Object, e As EventArgs) Handles N_factura.TextChanged
        dato1()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)
        dato3()
    End Sub


End Class