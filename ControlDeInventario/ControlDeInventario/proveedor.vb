Public Class proveedor
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public nombre As String
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Rut_provTextBox.Text = "" Or Nombre_provTextBox.Text = "" Or DireccionTextBox.Text = "" Or ComunaTextBox.Text = "" Or CiudadTextBox.Text = "" Or EmailTextBox.Text = "" Or FonoTextBox.Text = "" Then
            MsgBox("Hay campos en blancos ")

        Else
            bdconexion.insertar_prov(Rut_provTextBox.Text, Nombre_provTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text, EmailTextBox.Text, FonoTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.ControlinventarioDataSet.proveedor)

            Rut_provTextBox.Text = ""
            Nombre_provTextBox.Text = ""
            DireccionTextBox.Text = ""
            CiudadTextBox.Text = ""
            ComunaTextBox.Text = ""
            EmailTextBox.Text = ""
            FonoTextBox.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        proveedorEdid.Show()
        Me.Close()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Navegacion.Show()
        Me.Close()
    End Sub
End Class