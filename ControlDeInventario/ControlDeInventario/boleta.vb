Imports System.Data.SqlClient
Public Class boleta
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut As String
    Public tipo As String
    Public realizado As Integer = 0
    Public validador As Integer = 0
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.boleta' Puede moverla o quitarla según sea necesario.
        Me.BoletaTableAdapter.Fill(Me.ControlinventarioDataSet.boleta)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

        Panel1.Visible = False
        Rut_empresaTextBox.Text = "44.300.251-0"
        Nombre_empresaTextBox.Text = "MiOficinaS.A"
        DireccionTextBox.Text = "Raul castellon #4565"
    End Sub
    Public Sub dato2()
        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Fila.Cells("Column1").Value <> Nothing Then
                DataGridView1.Rows.Remove(Fila)
            End If

        Next
        Rut_clienteTextBox.Text = ""
        N_boletaTextBox.Text = ""
    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from cliente where rut_cliente LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "cliente")
        ClienteDataGridView.DataSource = DS.Tables("cliente")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        elegir_producto.tipo = 1
        elegir_producto.Show()
    End Sub


    Private Sub CantidadTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CantidadTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub PrecioTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub N_boletaTextBox_TextChanged_1(sender As Object, e As KeyPressEventArgs) Handles N_boletaTextBox.KeyPress
        Dim prod As String
        Dim can As String
        Dim toll As String

        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Fila.Cells("elimina").Value <> Nothing Then
                prod = Fila.Cells("Column1").Value
                can = Fila.Cells("Column3").Value
                toll = Fila.Cells("Column5").Value
                DataGridView1.Rows.Remove(Fila)
                'Calculos'
                TotalTextBox.Text = Val(TotalTextBox.Text) - Val(toll)
                'calculos'
                bdconexion.eliminar_registro(prod, N_boletaTextBox.Text)
                bdconexion.actua_prod(prod, can)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                realizado = realizado - 1
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If N_boletaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        ElseIf PrecioTextBox.Text = "" Or CantidadTextBox.Text = "" Then

            MsgBox("Precio o cantida estan en blanco")
        Else
            bdconexion.select_boleta(N_boletaTextBox.Text)
            If validador = 0 Then


                If Val(CantidadTextBox.Text) <= Val(Label2.Text) Then
                    Dim canti As Integer
                    Dim tol As Integer
                    canti = CantidadTextBox.Text
                    tol = Val(canti) * Val(PrecioTextBox.Text)

                    DataGridView1.Rows.Add(Cod_productoTextBox.Text, CantidadTextBox.Text, tol)

                    'calculos de los totales '
                    TotalTextBox.Text = tol + Val(TotalTextBox.Text)
                    'inser en la tabla registros '
                    Dim ingreso As String = "venta"
                    Dim documento As String = "Boleta"
                    Dim can2 As Integer
                    can2 = 0
                    can2 = can2 - Val(CantidadTextBox.Text)
                    bdconexion.insertar_registro(documento, N_boletaTextBox.Text, Cod_productoTextBox.Text, can2, FechaDateTimePicker.Text, rut, ingreso)

                    'inser en la tabla registros '
                    'actualizar tabla producto'
                    bdconexion.actua_prod2(Cod_productoTextBox.Text, CantidadTextBox.Text)
                    Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                    'actualizar tabla producto'
                    realizado = realizado + 1
                    Cod_productoTextBox.Text = ""
                    NombreTextBox.Text = ""
                    CantidadTextBox.Text = ""
                    PrecioTextBox.Text = ""
                    Label2.Text = ""

                Else
                    MsgBox("Cantidad ingresada supera el stock de bodega")
                End If

            End If
        End If
        validador = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prod As String
        Dim nom As String
        Dim can As String
        Dim toll As String
        Dim entrada As String = "Entrada"

        If N_boletaTextBox.Text = "" Or Rut_empresaTextBox.Text = "" Or Nombre_empresaTextBox.Text = "" Or DireccionTextBox.Text = "" Then
            MsgBox("Hay campos en blancos ")
        ElseIf N_boletaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        Else
            If DataGridView1.Rows.Count > 0 Then
                bdconexion.insertar_boleta(N_boletaTextBox.Text, Rut_empresaTextBox.Text, Rut_clienteTextBox.Text, Nombre_empresaTextBox.Text, DireccionTextBox.Text, FechaDateTimePicker.Text, TotalTextBox.Text)
                realizado = 0
                For Each Fila As DataGridViewRow In DataGridView1.Rows

                    If Not Fila Is Nothing Then
                        prod = Fila.Cells("Column1").Value
                        can = Fila.Cells("Column2").Value
                        bdconexion.insertar_detalle_bol(N_boletaTextBox.Text, prod, can)

                    End If

                Next
                MsgBox("Boleta creada")
                dato2()
            End If



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prod As String
        Dim can As String
        Dim toll As String

        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Fila.Cells("elimina").Value <> Nothing Then
                prod = Fila.Cells("Column1").Value
                can = Fila.Cells("Column2").Value
                toll = Fila.Cells("Column3").Value
                DataGridView1.Rows.Remove(Fila)
                'Calculos'
                TotalTextBox.Text = Val(TotalTextBox.Text) - Val(toll)

                'calculos'

                bdconexion.eliminar_registro(prod, N_boletaTextBox.Text)
                bdconexion.actua_prod(prod, can)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                realizado = realizado - 1
            End If

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If realizado > 0 Then
            Dim prod As String
            Dim can As String
            Dim toll As String
            For Each Fila As DataGridViewRow In DataGridView1.Rows

                If Fila.Cells("Column1").Value <> Nothing Then
                    prod = Fila.Cells("Column1").Value
                    can = Fila.Cells("Column2").Value
                    toll = Fila.Cells("Column3").Value
                    DataGridView1.Rows.Remove(Fila)
                    'eliminar registros'
                    bdconexion.eliminar_registro(prod, N_boletaTextBox.Text)
                    'actualizar bodega'
                    bdconexion.actua_prod(prod, can)
                    Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

                End If
                MsgBox("boleta cancelada")

            Next
            Navegacion.Show()
            Close()
        ElseIf realizado = 0 Then
            Navegacion.Show()
            Close()
        End If
    End Sub

    Private Sub Rut_clienteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Rut_clienteTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Panel1.Visible = False
        TextBox1.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Visible = False
    End Sub
End Class