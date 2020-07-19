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
        tipo1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tipo = "100" Then
            If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroBox1.Text = "" Or EmailTextBox.Text = "" Or tipousuario.Text = "" Then
                MsgBox("Hay campos en blancos ")
            Else
                If ContraseñaTextBox.Text = "" Or confirmar.Text = "" Then
                    MsgBox("Campos contraseña en blanco")
                ElseIf ContraseñaTextBox.Text = confirmar.Text Then
                    bdconexion.insertar_usuario(RutTextBox.Text, NombreTextBox.Text, ContactoTextBox.Text, GeneroBox1.Text, ContraseñaTextBox.Text, tipo1.Text, EmailTextBox.Text)
                    Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
                    RutTextBox.Text = ""
                    NombreTextBox.Text = ""
                    ContactoTextBox.Text = ""
                    GeneroBox1.Text = ""
                    EmailTextBox.Text = ""
                    ContraseñaTextBox.Text = ""
                    confirmar.Text = ""
                Else
                    MsgBox("Las contraseñas no coinciden")

                End If
            End If
        ElseIf tipo = "101" Then
            If tipo1.Text = "100" Then
                MsgBox("no tiene permiso para crear usuario root")
            Else
                If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroBox1.Text = "" Or EmailTextBox.Text = "" Or tipousuario.Text = "" Then
                    MsgBox("Hay campos en blanco")
                Else
                    If ContraseñaTextBox.Text = "" Or confirmar.Text = "" Then
                        MsgBox("Campos contraseña en blanco")
                    ElseIf ContraseñaTextBox.Text = confirmar.Text Then
                        bdconexion.insertar_usuario(RutTextBox.Text, NombreTextBox.Text, ContactoTextBox.Text, GeneroBox1.Text, ContraseñaTextBox.Text, tipo1.Text, EmailTextBox.Text)
                        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
                        RutTextBox.Text = ""
                        NombreTextBox.Text = ""
                        ContactoTextBox.Text = ""
                        GeneroBox1.Text = ""
                        EmailTextBox.Text = ""
                        ContraseñaTextBox.Text = ""
                        confirmar.Text = ""
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

    Private Sub EmailTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Navegacion.Show()
        Me.Close()
    End Sub

    Private Sub RutLabel_Click(sender As Object, e As EventArgs)

    End Sub


End Class