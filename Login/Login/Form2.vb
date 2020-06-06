Public Class Form2
    Private Sub Detalle_UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Detalle_UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Detalle_UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginnDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LoginnDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.LoginnDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'LoginnDataSet.Detalle_Usuario' Puede moverla o quitarla según sea necesario.
        Me.Detalle_UsuarioTableAdapter.Fill(Me.LoginnDataSet.Detalle_Usuario)

    End Sub

    Private Sub ID_UsuarioLabel1_Click(sender As Object, e As EventArgs)

    End Sub
End Class