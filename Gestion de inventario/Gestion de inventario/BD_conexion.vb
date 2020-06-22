Imports System.Configuration
Imports System.Data.OleDb

Public Class BD_conexion
    Dim conexion As New System.Data.OleDb.OleDbConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As OleDbCommand
    Dim corre As New Correo
    Sub conectar()
        ' hay que entrar a app.config y cambiar los valores connection string x nuestra conexion y name x un nombre
        direccion = ConfigurationManager.ConnectionStrings("conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()

        'MsgBox("conectado")
    End Sub

    Sub prueba(usuario As String)
        conectar()
        Dim tipo As String
        Dim nombre As String
        Dim rut As String
        comando = New OleDbCommand(" select * from usuario where rut ='" + usuario + "'", conexion)
        Dim dr As OleDbDataReader = comando.ExecuteReader()
        If dr.Read() Then
            rut = Convert.ToString(dr("rut"))
            tipo = Convert.ToString(dr("id_tipousuario"))
            nombre = Convert.ToString(dr("nombre"))
        End If
        'enviar datos al menu'
        navegacion.tipo = tipo
        navegacion.Label3.Text = nombre

        'enviar datos al Verfactura'
        Verfactura.tipo = tipo
        'enviar datos al factura ingreso'
        Factura.tipo = tipo
        Factura.rut = rut
        'enviar datos al factura Ventas'
        FacturaVenta.tipo = tipo
        FacturaVenta.rut = rut
        desconectar()
    End Sub
    Sub login(usuario As String, contraseña As String)
        Dim enc As New Encriptador
        conectar()

        comando = New OleDbCommand(" select count(*) from usuario where rut ='" + usuario + "' and contraseña ='" + enc.Encriptar(contraseña) + "'", conexion)


        Dim VLDR_Nombre As Integer

        VLDR_Nombre = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If VLDR_Nombre > 0 Then
            navegacion.Show()
        Else
            'Si NO existe el Cliente
            MsgBox("usuario o contraseña incorrecto")

        End If
        desconectar()
    End Sub
    'usuario'
    Public Sub insertar_usuario(rut As String, nombre As String, contacto As String, genero As String, contraseña As String, id_tipousuario As String, email As String)
        Dim emisor, pass, asunto As String
        emisor = "mioficinaS.A@gmail.com"
        pass = "mioficina1998"
        asunto = "Datos de su cuenta"
        Dim mensaje As String
        mensaje = "Su usuario  es: "
        mensaje = mensaje + rut
        Dim mensaje2 As String
        mensaje2 = ", y su clave es: "
        mensaje2 = mensaje2 + contraseña
        mensaje = mensaje + mensaje2
        MsgBox(mensaje)
        Dim enc As New Encriptador
        conectar()

        comando = New OleDbCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Usuario: " & UCase(rut) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO usuario (`rut`, `nombre`, `contacto`, `genero`, `contraseña`, `id_tipousuario`, `email`) VALUES ('" + rut + "','" + nombre + "','" + contacto + "','" + genero + "','" + enc.Encriptar(contraseña) + "','" + id_tipousuario + "','" + email + "')", conexion)

            comando.ExecuteNonQuery()

            MsgBox("El Usuario: " & UCase(rut) & " ha sido ingresado con exito")
            corre.enviarCorreo(emisor, pass, mensaje, asunto, email)

        End If
        desconectar()
    End Sub
    Sub eliminar_usuario(rut As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New OleDbCommand("DELETE FROM usuario WHERE rut ='" + rut + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Usuario: " & UCase(rut) & " ha sido borrado")
        Else
            MsgBox("El Usuario: " & UCase(rut) & " no existe")
        End If

        desconectar()
    End Sub
    'usuario'

    'producto'
    Public Sub insertar_prod(cod_producto As String, producto As String, precio As String, cantidad As String, fecha_ui As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(producto) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO producto (`cod_producto`, `producto`, `precio`, `cantidad`, `fecha_ui`) VALUES ('" + cod_producto + "','" + producto + "','" + precio + "','" + cantidad + "','" + fecha_ui + "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prod(cod_producto As String, producto As String, precio As String, cantidad As String, fecha_ui As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New OleDbCommand("UPDATE producto SET cod_producto ='" + cod_producto + "', producto ='" + producto + "',precio ='" + precio + "', cantidad ='" + cantidad + "',fecha_ui ='" + fecha_ui + "' where cod_producto= '" + cod_producto + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(producto) & " fue actualizado")
        Else

            MsgBox("El Producto: " & UCase(producto) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    Public Sub actua_prod(cod_producto As String, cantidad As String)
        Dim can As String
        conectar()

        comando = New OleDbCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As OleDbDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = Val(cantidad) + Val(can)
        MsgBox(cantidad)

        comando = New OleDbCommand("UPDATE producto SET cantidad ='" + cantidad + "' where cod_producto = '" + cod_producto + "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    Public Sub actua_prod2(cod_producto As String, cantidad As String)
        Dim can As String
        conectar()

        comando = New OleDbCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As OleDbDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = Val(can) - Val(cantidad)
        MsgBox(cantidad)

        comando = New OleDbCommand("UPDATE producto SET cantidad ='" + cantidad + "' where cod_producto = '" + cod_producto + "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    'producto'
    Sub eliminar_prod(cod_producto As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New OleDbCommand("DELETE FROM producto WHERE cod_producto ='" + cod_producto + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(cod_producto) & " ha sido borrado")
        Else
            MsgBox("El Producto: " & UCase(cod_producto) & " no existe")
        End If

        desconectar()
    End Sub
    Public Sub insertar_prov(rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO proveedor (`rut_prov`, `nombre_prov`, `direccion`, `comuna`, `ciudad`, `email`, `fono`) VALUES ('" + rut_prov + "','" + nombre_prov + "','" + direccion + "','" + comuna + "','" + ciudad + "','" + email + "','" + fono + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prov(rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New OleDbCommand("UPDATE proveedor SET rut_prov ='" + rut_prov + "', nombre_prov ='" + nombre_prov + "',direccion ='" + direccion + "', comuna ='" + comuna + "',ciudad ='" + ciudad + "',email ='" + email + "',fono ='" + fono + "' where rut_prov= '" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " fue actualizado")
        Else

            MsgBox("El Proveedor: " & UCase(nombre_prov) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prov(rut_prov As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New OleDbCommand("DELETE FROM proveedor WHERE rut_prov ='" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(rut_prov) & " ha sido borrado")
        Else
            MsgBox("El Proveedor: " & UCase(rut_prov) & " no existe")
        End If

        desconectar()

    End Sub
    'registro'

    Public Sub insertar_registro(id_producto As String, cantidad As String, n_factura As String, fecha As String, usuario As String)

        conectar()

        comando = New OleDbCommand("INSERT INTO registro (`id_producto`, `cantidad`, `n_factura`, `fecha`, `usuario`) VALUES ('" + id_producto + "','" + cantidad + "','" + n_factura + "','" + fecha + "','" + usuario + "')", conexion)
        comando.ExecuteNonQuery()
        MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub
    Sub eliminar_registro(id_pro As String, n_fac As String)

        conectar()

        comando = New OleDbCommand("DELETE FROM registro WHERE id_producto ='" + id_pro + "' and n_factura ='" + n_fac + "'", conexion)
        comando.ExecuteNonQuery()
        MsgBox("El registro ha sido borrado")

        desconectar()

    End Sub
    'registro'
    'factura'
    Public Sub insertar_factura(n_factura As String, rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String, rut_cliente As String, fecha As String, observacion As String, valor_neto As String, iva As String, total As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from factura where n_factura ='" + n_factura + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO factura (`n_factura`, `rut_prov`, `nombre_prov`, `direccion`, `comuna`, `ciudad`, `email`, `fono`, `rut_cliente`, `fecha`, `observacion`, `valor_neto`, `iva`, `total`) VALUES ('" + n_factura + "','" + rut_prov + "','" + nombre_prov + "','" + direccion + "','" + comuna + "','" + ciudad + "','" + email + "','" + fono + "','" + rut_cliente + "','" + fecha + "','" + observacion + "','" + valor_neto + "','" + iva + "','" + total + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("La Factura " & UCase(n_factura) & " ha sido ingresadoa con exito")
        End If
        desconectar()
    End Sub
    'factura'
    'detalle factura'
    Public Sub insertar_fac_deta(n_factura As String, cod_producto As String, descripcion As String, cantidad As String, precio_unitario As String, total As String)

        conectar()

        comando = New OleDbCommand("INSERT INTO detalle_fac (`n_factura`, `cod_producto`, `descripcion`, `cantidad`, `precio_unitario` , `total`) VALUES ('" + n_factura + "','" + cod_producto + "','" + descripcion + "','" + cantidad + "','" + precio_unitario + "','" + total + "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub
    'detalle factura'

    Sub desconectar()
        conexion.Close()
    End Sub
End Class
