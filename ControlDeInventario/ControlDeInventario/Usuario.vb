Imports System.Data.SqlClient
Public Class Usuario
    Dim bdconexion As New BD_conexion
    Public tipo As String
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.tipousuario' Puede moverla o quitarla según sea necesario.
        Me.TipousuarioTableAdapter.Fill(Me.ControlinventarioDataSet.tipousuario)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tipo = "100" Then
            If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroTextBox.Text = "" Or EmailTextBox.Text = "" Or tipousuario.Text = "" Then
                MsgBox("Hay campos en blancos ")
            Else
                If ContraseñaTextBox.Text = "" Or confirmar.Text = "" Then
                    MsgBox("Campos contraseña en blanco")
                ElseIf ContraseñaTextBox.Text = confirmar.Text Then
                    bdconexion.insertar_usuario(RutTextBox.Text, NombreTextBox.Text, ContactoTextBox.Text, GeneroTextBox.Text, ContraseñaTextBox.Text, tipo1.Text, EmailTextBox.Text)
                    Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
                Else
                    MsgBox("Las contraseñas no coinciden")

                End If
            End If
        ElseIf tipo = "101" Then
            If tipo1.Text = "100" Then
                MsgBox("no tiene permiso para crear usuario root")
            Else
                If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroTextBox.Text = "" Or EmailTextBox.Text = "" Or tipousuario.Text = "" Then
                    MsgBox("Hay campos en blanco")
                Else
                    If ContraseñaTextBox.Text = "" Or confirmar.Text = "" Then
                        MsgBox("Campos contraseña en blanco")
                    ElseIf ContraseñaTextBox.Text = confirmar.Text Then
                        bdconexion.insertar_usuario(RutTextBox.Text, NombreTextBox.Text, ContactoTextBox.Text, GeneroTextBox.Text, ContraseñaTextBox.Text, tipo1.Text, EmailTextBox.Text)
                        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
                    Else
                        MsgBox("Las contraseñas no coinciden")

                    End If
                End If
            End If
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UsuarioEdid.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each Fila As DataGridViewRow In UsuarioDataGridView.Rows

            If Fila.Cells("eliminar").Value <> Nothing Then
                Dim dato As String = Fila.Cells(1).Value.ToString
                bdconexion.eliminar_usuario(dato)

            End If

        Next
        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuarioDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RutLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RutTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactoLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactoTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GeneroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GeneroTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class