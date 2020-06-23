Public Class Usuario
    Dim bdconexion As New BD_conexion
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GestiondeinventarioDataSet)

    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.tipousuario' Puede moverla o quitarla según sea necesario.
        Me.TipousuarioTableAdapter.Fill(Me.GestiondeinventarioDataSet.tipousuario)
        'TODO: esta línea de código carga datos en la tabla 'GestiondeinventarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.GestiondeinventarioDataSet.usuario)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.UsuarioTableAdapter.Fill(Me.GestiondeinventarioDataSet.usuario)
        If RutTextBox.Text = "" And NombreTextBox.Text = "" And GeneroTextBox.Text = "" And EmailTextBox.Text = "" And tipousuario.Text = "" Then
            MsgBox("No a selecionado al proveedor")
        Else
            If ContraseñaTextBox.Text = "" And confirmar.Text = "" Then
                MsgBox("Campos contraseña en blanco")
            ElseIf ContraseñaTextBox.Text = confirmar.Text Then
                bdconexion.insertar_usuario(RutTextBox.Text, NombreTextBox.Text, ContactoTextBox.Text, GeneroTextBox.Text, ContraseñaTextBox.Text, tipo.Text, EmailTextBox.Text)
                Me.UsuarioTableAdapter.Fill(Me.GestiondeinventarioDataSet.usuario)
            Else
                MsgBox("Las contraseñas no coinciden")

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bdconexion.eliminar_usuario(RutTextBox.Text)
        Me.UsuarioTableAdapter.Fill(Me.GestiondeinventarioDataSet.usuario)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class