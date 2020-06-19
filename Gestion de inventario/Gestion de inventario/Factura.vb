Public Class Factura
    Dim bdconexion As New BD_conexion

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.GestiondeinventarioDataSet.proveedor)
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
        Me.FacturaTableAdapter.Fill(Me.GestiondeinventarioDataSet.factura)
        Label2.Text = Form1.Label1.Text

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub ProductoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim canti As Integer
        Dim tol As Integer
        canti = cantidad.Text
        tol = Val(canti) * Val(precio.Text)

        DataGridView1.Rows.Add(ComboBox2.Text, ProductoTextBox.Text, cantidad.Text, precio.Text, tol)

        'calculos de los totales '
        total.Text = tol + Val(total.Text)
        'impuesto.Text = Val(total.Text) * 0.19
        neto.Text = Val(total.Text) - Val(impuesto.Text)
        'inser en la tabla registros '
        bdconexion.insertar_registro(ComboBox2.Text, cantidad.Text, N_facturaTextBox.Text, DateTimePicker1.Text, Label1.Text)
        'inser en la tabla registros '
        'actualizar tabla producto'
        CantidadTextBox.Text = Val(CantidadTextBox.Text) + Val(canti)
        bdconexion.actua_prod(ComboBox2.Text, CantidadTextBox.Text)
        'actualizar tabla producto'
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles impuesto.TextChanged

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim prod As String
        Dim can As String
        For Each r As DataGridViewRow In DataGridView1.SelectedRows
            prod = r.Cells("Column1").Value
            can = r.Cells("Column3").Value
            DataGridView1.Rows.Remove(r)
            can = Val(can) - Val(can) - Val(can)
            bdconexion.actua_prod(prod, can)
        Next


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod As String
        Dim nom As String
        Dim can As String
        Dim prec As String
        Dim toll As String


        If DataGridView1.Rows.Count > 0 Then

            For Each Fila As DataGridViewRow In DataGridView1.Rows

                If Not Fila Is Nothing Then
                    prod = Fila.Cells("Column1").Value
                    nom = Fila.Cells("Column2").Value
                    can = Fila.Cells("Column3").Value
                    prec = Fila.Cells("Column4").Value
                    toll = Fila.Cells("Column5").Value
                    bdconexion.insertar_fac_deta(N_facturaTextBox.Text, prod, nom, can, prec, toll)

                End If
                bdconexion.insertar_factura(N_facturaTextBox.Text, Rut_provTextBox.Text, ComboBox1.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text, Rut_clienteTextBox.Text, DateTimePicker1.Text, ObservacionTextBox.Text, neto.Text, impuesto.Text, total.Text)

            Next

        End If
    End Sub

    Private Sub Neto_TextChanged(sender As Object, e As EventArgs) Handles neto.TextChanged

    End Sub

    Private Sub N_facturaLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class