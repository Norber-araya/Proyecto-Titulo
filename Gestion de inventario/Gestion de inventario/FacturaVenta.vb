﻿Imports System.Data
Imports System.Data.OleDb
Public Class FacturaVenta
    Dim conexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Diegoandres\Documents\Proyecto avances\bd\gestiondeinventario.accdb")
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub FacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.GestiondeinventarioDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.GestiondeinventarioDataSet.factura)
        Rut_provTextBox.Text = "44300251-0"
        Panel1.Visible = False
    End Sub
    Public Sub dato1()

        Dim comando = New OleDbDataAdapter(" select * from cliente where rut_cliente LIKE'" & buscar.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "cliente")
        ClienteDataGridView.DataSource = DS.Tables("cliente")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ComunaTextBox1.TextChanged

    End Sub

    Private Sub FonoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FonoTextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
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

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        dato1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(cantidad.Text) <= Val(Label3.Text) Then



            Dim canti As Integer
            Dim tol As Integer
            canti = cantidad.Text
            tol = Val(canti) * Val(PrecioTextBox.Text)

            DataGridView1.Rows.Add(ComboBox2.Text, ProductoTextBox.Text, cantidad.Text, PrecioTextBox.Text, tol)

            'calculos de los totales '
            TotalTextBox.Text = tol + Val(TotalTextBox.Text)
            IvaTextBox.Text = Val(TotalTextBox.Text) * 0.19
            Valor_netoTextBox.Text = Val(TotalTextBox.Text) - Val(IvaTextBox.Text)
            'inser en la tabla registros '
            bdconexion.insertar_registro(ComboBox2.Text, cantidad.Text, N_facturaTextBox.Text, DateTimePicker1.Text, rut)
            Label3.Text = Val(Label3.Text) - Val(cantidad.Text)
            'inser en la tabla registros '
            'actualizar tabla producto'
            bdconexion.actua_prod2(ComboBox2.Text, cantidad.Text)
            Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)

            'actualizar tabla producto'
        Else
            MsgBox("cantidad ingresada supera el stock de bodega")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim prod As String
        Dim can As String
        Dim toll As String

        For Each r As DataGridViewRow In DataGridView1.SelectedRows
            prod = r.Cells("Column1").Value
            can = r.Cells("Column3").Value
            toll = r.Cells("Column5").Value
            DataGridView1.Rows.Remove(r)

            TotalTextBox.Text = Val(TotalTextBox.Text) - Val(toll)
            IvaTextBox.Text = Val(TotalTextBox.Text) * 0.19
            Valor_netoTextBox.Text = Val(TotalTextBox.Text) - Val(IvaTextBox.Text)

            bdconexion.eliminar_registro(prod, N_facturaTextBox.Text)

            bdconexion.actua_prod(prod, can)
            Me.ProductoTableAdapter.Fill(Me.GestiondeinventarioDataSet.producto)

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prod As String
        Dim nom As String
        Dim can As String
        Dim prec As String
        Dim toll As String


        If DataGridView1.Rows.Count > 0 Then
            bdconexion.insertar_factura(N_facturaTextBox.Text, Rut_provTextBox.Text, NombreTextBox.Text, DireccionTextBox1.Text, ComunaTextBox1.Text, CiudadTextBox1.Text, EmailTextBox1.Text, FonoTextBox1.Text, Rut_clienteTextBox1.Text, DateTimePicker1.Text, ObservacionTextBox.Text, Valor_netoTextBox.Text, IvaTextBox.Text, TotalTextBox.Text)

            For Each Fila As DataGridViewRow In DataGridView1.Rows

                If Not Fila Is Nothing Then
                    prod = Fila.Cells("Column1").Value
                    nom = Fila.Cells("Column2").Value
                    can = Fila.Cells("Column3").Value
                    prec = Fila.Cells("Column4").Value
                    toll = Fila.Cells("Column5").Value
                    bdconexion.insertar_fac_deta(N_facturaTextBox.Text, prod, nom, can, prec, toll)

                End If

            Next

        End If
    End Sub
End Class