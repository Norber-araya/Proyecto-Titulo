Imports System.Data.SqlClient
Public Class Bodega
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")



    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductoDataGridView_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ProductoDataGridView.CellFormatting
        If Me.ProductoDataGridView.Columns(e.ColumnIndex).Name = "cantidad" Then

            If e.Value IsNot Nothing Then
                If e.Value.[GetType]() <> GetType(System.DBNull) Then
                    'Stock menor a 20'

                    If Convert.ToInt32(e.Value) <= 20 Then
                        e.CellStyle.BackColor = Color.LightSalmon
                        e.CellStyle.ForeColor = Color.Red

                    End If
                    'Stock menor a 10'
                    If Convert.ToInt32(e.Value) <= 11 Then
                        e.CellStyle.BackColor = Color.Salmon
                        e.CellStyle.ForeColor = Color.Red
                    End If
                End If
            End If
        End If
    End Sub
End Class