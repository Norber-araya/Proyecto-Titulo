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
    Private Sub N_factura_TextChanged(sender As Object, e As EventArgs)
        dato1()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)
        dato3()
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            RadioButton9.Checked = False
            RadioButton8.Checked = False
            DateTimePicker3.Enabled = True
            ComboBox1.Enabled = False
            ComboBox4.Enabled = False
            If DateTimePicker3.Text = "" Then

            Else
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker3.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker3.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy(Me.ControlinventarioDataSet.boleta, DateTimePicker3.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker3.Text)
                End If

            End If
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        If RadioButton10.Checked = True Then
            RadioButton9.Checked = False
            RadioButton8.Checked = False
            DateTimePicker3.Enabled = True
            ComboBox1.Enabled = False
            ComboBox4.Enabled = False
            If DateTimePicker3.Text = "" Then

            Else
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker3.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker3.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy(Me.ControlinventarioDataSet.boleta, DateTimePicker3.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker3.Text)
                End If

            End If
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            RadioButton10.Checked = False
            RadioButton8.Checked = False
            DateTimePicker3.Enabled = False
            ComboBox1.Enabled = True
            ComboBox4.Enabled = True
            If ComboBox4.Text = "enero" Then
                DateTimePicker1.Text = "1 / 1 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 1 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If



            ElseIf ComboBox4.Text = "febrero" Then
                DateTimePicker1.Text = "1 / 2 /" + ComboBox1.Text
                DateTimePicker2.Text = "28 / 2 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "marzo" Then
                DateTimePicker1.Text = "1 / 3 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 3 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "abril" Then
                DateTimePicker1.Text = "1 / 4 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 4 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "mayo" Then
                DateTimePicker1.Text = "1 / 5 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 5 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "junio" Then
                DateTimePicker1.Text = "1 / 6 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 6 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "julio" Then
                DateTimePicker1.Text = "1 / 7 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 7 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "agosto" Then
                DateTimePicker1.Text = "1 / 8 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 8 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "septiembre" Then
                DateTimePicker1.Text = "1 / 9 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 9/" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "octubre" Then
                DateTimePicker1.Text = "1 / 10 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 10 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "noviembre" Then
                DateTimePicker1.Text = "1 / 11 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 12 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "diciembre" Then

                DateTimePicker1.Text = "1 / 12 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 12 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            RadioButton10.Checked = False
            RadioButton9.Checked = False
            DateTimePicker3.Enabled = False
            ComboBox4.Enabled = False
            ComboBox1.Enabled = True
            DateTimePicker1.Text = "1 / 1 /" + ComboBox1.Text
            DateTimePicker2.Text = "31 / 12 /" + ComboBox1.Text
            If documento = "1" Then
                Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "2" Then
                Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "3" Then
                Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "4" Then
                Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If RadioButton9.Checked = True Then
            RadioButton10.Checked = False
            RadioButton8.Checked = False
            DateTimePicker3.Enabled = False
            ComboBox1.Enabled = True
            ComboBox4.Enabled = True
            If ComboBox4.Text = "enero" Then
                DateTimePicker1.Text = "1 / 1 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 1 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If



            ElseIf ComboBox4.Text = "febrero" Then
                DateTimePicker1.Text = "1 / 2 /" + ComboBox1.Text
                DateTimePicker2.Text = "28 / 2 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "marzo" Then
                DateTimePicker1.Text = "1 / 3 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 3 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "abril" Then
                DateTimePicker1.Text = "1 / 4 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 4 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "mayo" Then
                DateTimePicker1.Text = "1 / 5 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 5 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "junio" Then
                DateTimePicker1.Text = "1 / 6 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 6 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "julio" Then
                DateTimePicker1.Text = "1 / 7 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 7 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "agosto" Then
                DateTimePicker1.Text = "1 / 8 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 8 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "septiembre" Then
                DateTimePicker1.Text = "1 / 9 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 9/" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "octubre" Then
                DateTimePicker1.Text = "1 / 10 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 10 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "noviembre" Then
                DateTimePicker1.Text = "1 / 11 /" + ComboBox1.Text
                DateTimePicker2.Text = "30 / 12 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            ElseIf ComboBox4.Text = "diciembre" Then

                DateTimePicker1.Text = "1 / 12 /" + ComboBox1.Text
                DateTimePicker2.Text = "31 / 12 /" + ComboBox1.Text
                If documento = "1" Then
                    Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "2" Then
                    Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "3" Then
                    Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
                If documento = "4" Then
                    Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If RadioButton8.Checked = True Then
            RadioButton10.Checked = False
            RadioButton9.Checked = False
            DateTimePicker3.Enabled = False
            ComboBox4.Enabled = False
            ComboBox1.Enabled = True
            DateTimePicker1.Text = "1 / 1 /" + ComboBox1.Text
            DateTimePicker2.Text = "31 / 12 /" + ComboBox1.Text
            If documento = "1" Then
                Me.Factura_ingresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_ingreso, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "2" Then
                Me.Factura_egresoTableAdapter.FillBy1(Me.ControlinventarioDataSet.factura_egreso, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "3" Then
                Me.BoletaTableAdapter.FillBy1(Me.ControlinventarioDataSet.boleta, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
            If documento = "4" Then
                Me.Guia_despachoTableAdapter.FillBy1(Me.ControlinventarioDataSet.guia_despacho, DateTimePicker1.Text, DateTimePicker2.Text)
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If documento = "1" Then
            Me.Factura_ingresoTableAdapter.Fill(Me.ControlinventarioDataSet.factura_ingreso)
        End If
        If documento = "2" Then
            Me.Factura_egresoTableAdapter.Fill(Me.ControlinventarioDataSet.factura_egreso)
        End If
        If documento = "3" Then
            Me.BoletaTableAdapter.Fill(Me.ControlinventarioDataSet.boleta)
        End If
        If documento = "4" Then
            Me.Guia_despachoTableAdapter.Fill(Me.ControlinventarioDataSet.guia_despacho)
        End If
    End Sub
End Class