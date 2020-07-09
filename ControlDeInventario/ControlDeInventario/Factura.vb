Imports System.Data.SqlClient
Public Class Factura
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public nombre As String
    Public realizado As Integer = 0
    Public validador As Integer = 0

    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from proveedor where rut_prov LIKE'" & buscar.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "proveedor")
        ProveedorDataGridView.DataSource = DS.Tables("proveedor")
    End Sub
    Public Sub dato2()
        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Not Fila Is Nothing Then
                DataGridView1.Rows.Remove(Fila)
            End If

        Next
        Rut_provTextBox.Text = ""
        N_facturaTextBox.Text = ""
        total.Text = ""
        impuesto.Text = ""
        neto.Text = ""
    End Sub
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)
        Panel1.Visible = False
        NombrePro.Text = "MiOficinaS.A"
        Rut_clienteTextBox.Text = "44.300.251-0"
        FonoTextBox.Text = "954722488"
        DireccionTextBox.Text = "Raul castellon #4565"
        CiudadTextBox.Text = "La Serena"
        EmailTextBox.Text = "mioficinaS.A@gmail.com"
        ObservacionTextBox.Text = ""
        ComunaTextBox.Text = " La Serena"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        Rut_provTextBox.Text = ProveedorDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Panel1.Visible = False
    End Sub


    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        dato1()
    End Sub

    Private Sub Cantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles cantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
          If N_facturaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        ElseIf precio.Text = "" Or cantidad.Text = "" Then

            MsgBox("Precio o cantida estan en blanco")
        Else
            bdconexion.select_factura(N_facturaTextBox.Text)
            If validador = 0 Then
                Dim canti As Integer
                Dim tol As Integer
                canti = cantidad.Text
                tol = Val(canti) * Val(precio.Text)

                DataGridView1.Rows.Add(cod_producto.Text, ProductoTextBox.Text, cantidad.Text, precio.Text, tol)

                'calculos de los totales '
                total.Text = tol + Val(total.Text)
                impuesto.Text = Val(total.Text) * 0.19
                neto.Text = Val(total.Text) - Val(impuesto.Text)
                'inser en la tabla registros '
                Dim ingreso As String = "ingreso"
                Dim documento As String = "Factura"
                bdconexion.insertar_registro(documento, N_facturaTextBox.Text, cod_producto.Text, precio.Text, cantidad.Text, DateTimePicker1.Text, rut, ingreso)

                'inser en la tabla registros '
                'actualizar tabla producto'
                bdconexion.actua_prod(cod_producto.Text, cantidad.Text)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                'actualizar tabla producto'

                realizado = realizado + 1
                cod_producto.Text = ""
                ProductoTextBox.Text = ""
                cantidad.Text = ""
                precio.Text = ""
                Label5.Text = ""
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
                total.Text = Val(total.Text) - Val(toll)
                impuesto.Text = Val(total.Text) * 0.19
                neto.Text = Val(total.Text) - Val(impuesto.Text)
                'calculos'

                bdconexion.eliminar_registro(prod, N_facturaTextBox.Text)
                bdconexion.actua_prod2(prod, can)
                Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)
                realizado = realizado - 1
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod As String
        Dim nom As String
        Dim can As String
        Dim prec As String
        Dim toll As String
        Dim entrada As String = "Entrada"

        If NombrePro.Text = "" Or DireccionTextBox.Text = "" Or ComunaTextBox.Text = "" Or CiudadTextBox.Text = "" Or EmailTextBox.Text = "" Or FonoTextBox.Text = "" Or Rut_clienteTextBox.Text = "" Then
            MsgBox("Hay campos en blancos ")
        ElseIf Rut_provTextBox.Text = "" Then
            MsgBox("No a seleccionad a un Proveedor")
        ElseIf N_facturaTextBox.Text = "" Then
            MsgBox("ingese numero de factura")
        Else
            If DataGridView1.Rows.Count > 0 Then
                Dim variable As Double = CDbl(impuesto.Text)
                bdconexion.insertar_factura(N_facturaTextBox.Text, Rut_provTextBox.Text, NombrePro.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text, Rut_clienteTextBox.Text, DateTimePicker1.Text, ObservacionTextBox.Text, neto.Text, variable, total.Text, entrada)
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
                    MsgBox("factura creada")
                    dato2()
                Next

            End If
        End If

    End Sub

    Private Sub Precio_TextChanged(sender As Object, e As KeyPressEventArgs) Handles precio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
                    bdconexion.actua_prod2(prod, can)
                    Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

                End If

            Next
            Navegacion.Show()
            Close()
        ElseIf realizado = 0 Then
            Navegacion.Show()
            Close()
        End If


        Navegacion.Show()
        Me.Close()
    End Sub

    Private Sub Precio_TextChanged(sender As Object, e As EventArgs) Handles precio.TextChanged, precio.KeyPress

    End Sub

    Private Sub Rut_provTextBox_TextChanged(sender As Object, e As EventArgs) Handles Rut_provTextBox.TextChanged

    End Sub

    Private Sub N_facturaTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles N_facturaTextBox.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("solo puede elegir numeros")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        elegir_producto.tipo = 2
        elegir_producto.Show()
    End Sub

    Private Sub NombrePro_TextChanged(sender As Object, e As EventArgs) Handles NombrePro.TextChanged

    End Sub
End Class