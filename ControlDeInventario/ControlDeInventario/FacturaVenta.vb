Imports System.Data.SqlClient
Public Class FacturaVenta
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public realizado As Integer = 0
    Public validador As Integer = 0
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)
        Rut_provTextBox.Text = "44300251-0"
        Panel1.Visible = False
    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from cliente where rut_cliente LIKE'" & buscar.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "cliente")
        ClienteDataGridView.DataSource = DS.Tables("cliente")
    End Sub
    Public Sub dato2()
        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Fila.Cells("Column1").Value <> Nothing Then
                DataGridView1.Rows.Remove(Fila)
            End If

        Next
        Rut_provTextBox.Text = ""
        N_facturaTextBox.Text = ""
        TotalTextBox.Text = ""
        IvaTextBox.Text = ""
        Valor_netoTextBox.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If N_facturaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        ElseIf cantidad.Text = "" Then

            MsgBox("cantida estan en blanco")
        Else
            bdconexion.select_factura(N_facturaTextBox.Text)
            If validador = 0 Then
                If Val(cantidad.Text) <= Val(Label3.Text) Then
                    Dim canti As Integer
                    Dim tol As Integer
                    Dim venta As String = "venta"
                    canti = cantidad.Text
                    tol = Val(canti) * Val(precio.Text)

                    DataGridView1.Rows.Add(cod_producto.Text, ProductoTextBox.Text, cantidad.Text, precio.Text, tol)

                    'calculos de los totales '
                    TotalTextBox.Text = tol + Val(TotalTextBox.Text)
                    IvaTextBox.Text = Val(TotalTextBox.Text) * 0.19
                    Valor_netoTextBox.Text = Val(TotalTextBox.Text) - Val(IvaTextBox.Text)
                    'inser en la tabla registros '
                    Dim documento As String = "Factura"
                    bdconexion.insertar_registro(documento, N_facturaTextBox.Text, cod_producto.Text, precio.Text, cantidad.Text, DateTimePicker1.Text, rut, venta)
                    Label3.Text = Val(Label3.Text) - Val(cantidad.Text)
                    'inser en la tabla registros '
                    'actualizar tabla producto'
                    bdconexion.actua_prod2(cod_producto.Text, cantidad.Text)
                    Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

                    'actualizar tabla producto'
                    realizado = realizado + 1
                    cod_producto.Text = ""
                    ProductoTextBox.Text = ""
                    precio.Text = ""
                    cantidad.Text = ""
                    Label3.Text = ""
                Else
                    MsgBox("cantidad ingresada supera el stock de bodega")
                End If
            End If
        End If




    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
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
                IvaTextBox.Text = Val(TotalTextBox.Text) * 0.19
                Valor_netoTextBox.Text = Val(TotalTextBox.Text) - Val(IvaTextBox.Text)
                'calculos'

                'eliminar registros'
                bdconexion.eliminar_registro(prod, N_facturaTextBox.Text)
                'actualizar bodega'
                bdconexion.actua_prod(prod, can)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                realizado = realizado - 1
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prod As String
        Dim nom As String
        Dim can As String
        Dim prec As String
        Dim toll As String
        Dim venta As String = "venta"
        If NombreTextBox.Text = "" Or DireccionTextBox1.Text = "" Or ComunaTextBox1.Text = "" Or CiudadTextBox1.Text = "" Or EmailTextBox1.Text = "" Or FonoTextBox1.Text = "" Or Rut_clienteTextBox1.Text = "" Then
            MsgBox("Hay campos en blancos ")
        ElseIf Rut_provTextBox.Text = "" Then
            MsgBox("No a seleccionad a un Proveedor")
        ElseIf N_facturaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        Else

            If DataGridView1.Rows.Count > 0 Then
                bdconexion.insertar_factura(N_facturaTextBox.Text, Rut_provTextBox.Text, NombreTextBox.Text, DireccionTextBox1.Text, ComunaTextBox1.Text, CiudadTextBox1.Text, EmailTextBox1.Text, FonoTextBox1.Text, Rut_clienteTextBox1.Text, DateTimePicker1.Text, ObservacionTextBox.Text, Valor_netoTextBox.Text, IvaTextBox.Text, TotalTextBox.Text, venta)
                realizado = 0
                For Each Fila As DataGridViewRow In DataGridView1.Rows

                    If Not Fila Is Nothing Then
                        prod = Fila.Cells("Column1").Value
                        nom = Fila.Cells("Column2").Value
                        can = Fila.Cells("Column3").Value
                        prec = Fila.Cells("Column4").Value
                        toll = Fila.Cells("Column5").Value
                        bdconexion.insertar_fac_deta(N_facturaTextBox.Text, prod, nom, can, prec, toll)

                    End If
                    dato2()
                    MsgBox("Factura Venta Creada")
                Next

            End If



        End If






    End Sub

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        dato1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rut_clienteTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        NombreTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        EmailTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        FonoTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        DireccionTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        ComunaTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(5).Value.ToString
        CiudadTextBox1.Text = ClienteDataGridView.CurrentRow.Cells.Item(6).Value.ToString

        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If realizado > 0 Then
            Dim prod As String
            Dim can As String
            Dim toll As String
            For Each Fila As DataGridViewRow In DataGridView1.Rows

                If Fila.Cells("Column1").Value <> Nothing Then
                    prod = Fila.Cells("Column1").Value
                    can = Fila.Cells("Column3").Value
                    toll = Fila.Cells("Column5").Value
                    DataGridView1.Rows.Remove(Fila)
                    'eliminar registros'
                    bdconexion.eliminar_registro(prod, N_facturaTextBox.Text)
                    'actualizar bodega'
                    bdconexion.actua_prod(prod, can)
                    Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

                End If

            Next
            Navegacion.Show()
            Close()
        ElseIf realizado = 0 Then
            Navegacion.Show()
            Close()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        elegir_producto.tipo = 3
        elegir_producto.Show()
    End Sub

    Private Sub cod_producto_TextChanged(sender As Object, e As EventArgs) Handles cod_producto.TextChanged

    End Sub
End Class