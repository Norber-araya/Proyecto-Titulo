Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LoginnDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.LoginnDataSet.Usuario)
        PasswordTextBox.Text = ""
        ID_UsuarioTextBox.Text = ""



    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginnDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Registrarse.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Iniciar_Click_1(sender As Object, e As EventArgs) Handles Iniciar.Click
        If Me.UsuarioTableAdapter.BuscarDatos(Me.LoginnDataSet.Usuario, ID_UsuarioTextBox.Text, PasswordTextBox.Text) Then

            Form3.Show()
        Else
            MsgBox("datos incorectos")


        End If
    End Sub
End Class