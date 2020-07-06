Imports System.Configuration
Imports System.Data.SqlClient
Public Class BD_conexion
    Dim conexion As New System.Data.SqlClient.SqlConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As SqlCommand
    Sub conectar()
        ' hay que entrar a app.config y cambiar los valores connection string x nuestra conexion y name x un nombre
        direccion = ConfigurationManager.ConnectionStrings("conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()

        'MsgBox("conectado")
    End Sub



    'LOGIN'
    Sub prueba(usuario As String)
        conectar()
        Dim tipo As String
        Dim nombre As String
        Dim rut As String
        comando = New SqlCommand(" select * from usuario where rut ='" + usuario + "'", conexion)
        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            rut = Convert.ToString(dr("rut"))
            tipo = Convert.ToString(dr("id_tipousuario"))
            nombre = Convert.ToString(dr("nombre"))
        End If
        'enviar datos al menu'
        Navegacion.tipo.Text = tipo
        Navegacion.rut.Text = rut
        Navegacion.nombre.text = nombre


        desconectar()
    End Sub
    Sub login(usuario As String, contraseña As String)
        Dim enc As New Encriptador
        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + usuario + "' and contraseña ='" + enc.Encriptar(contraseña) + "'", conexion)


        Dim VLDR_Nombre As Integer

        VLDR_Nombre = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If VLDR_Nombre > 0 Then
            Navegacion.Show()
            Form1.Close()
        Else
            'Si NO existe el Cliente
            MsgBox("usuario o contraseña incorrecto")

        End If
        desconectar()
    End Sub

    'LOGIN'

    'USUARIO'
    Public Sub insertar_usuario(rut As String, nombre As String, contacto As String, genero As String, contraseña As String, id_tipousuario As Integer, email As String)
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

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)
        Dim corre As New Correo
        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Usuario: " & UCase(rut) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New SqlCommand("INSERT INTO [usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email])  VALUES ('" & rut + "','" & nombre & "','" & contacto & "','" & genero & "','" & enc.Encriptar(contraseña) & "','" & id_tipousuario & "','" & email & "')", conexion)

            comando.ExecuteNonQuery()

            MsgBox("El Usuario: " & UCase(rut) & " ha sido ingresado con exito")
            corre.enviarCorreo(emisor, pass, mensaje, asunto, email)

        End If
        desconectar()
    End Sub
    Sub eliminar_usuario(rut As String)

        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM usuario WHERE rut ='" + rut + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Usuario: " & UCase(rut) & " ha sido borrado")
        Else
            MsgBox("El Usuario: " & UCase(rut) & " no existe")
        End If

        desconectar()
    End Sub

    Public Sub editar_ususrio(rut As String, rut2 As String, nombre As String, contacto As String, genero As String, email As String)

        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut2 + "'", conexion)
        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE usuario SET rut ='" & rut & "',nombre ='" + nombre + "',contacto ='" + contacto + "',genero ='" + genero + "',email ='" + email + "' where rut= '" + rut2 + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El usuario: " & UCase(rut2) & " fue actualizado")
        Else

            MsgBox("El usuario: " & UCase(rut2) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    'USUARIO'


    'Producto Sentencias sql'
    Public Sub insertar_prod(cod_producto As String, producto As String, precio As Double, tipo_producto As String)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            MsgBox("El Producto: " & UCase(producto) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES ('" & cod_producto & "','" & producto & "','" & precio & "','" & tipo_producto & "','" & cantidad & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")

        End If
        desconectar()
    End Sub

    Public Sub editar_prod(cod_producto As String, cod As String, producto As String, precio As Double, tipo_producto As String, cantidad As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" & cod & "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE producto SET cod_producto ='" & cod_producto & "', nombre ='" & producto & "',precio ='" & precio & "',tipo_producto ='" & tipo_producto & "',cantidad ='" & cantidad & "' where cod_producto= '" & cod & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(producto) & " fue actualizado")
        Else

            MsgBox("El Producto: " & UCase(producto) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prod(cod_producto As String)
        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM producto WHERE cod_producto ='" + cod_producto + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(cod_producto) & " ha sido borrado")
        Else
            MsgBox("El Producto: " & UCase(cod_producto) & " no existe")
        End If

        desconectar()
    End Sub
    'Producto Sentencias sql'

    'DETALLE PROVEEDOR'
    Public Sub insertar_DetaProv(cod_productorov As String, rut_prov As String)

        conectar()
        comando = New SqlCommand("INSERT INTO [detalle_proveedor] ([cod_producto], [rut_prov]) VALUES ('" & cod_productorov & "','" & rut_prov & "')", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub


    'DETALLE PROVEEDOR'

    'PROVEEDOR'
    Public Sub insertar_prov(rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ya existe en la base de datos")

        Else

            comando = New SqlCommand("INSERT INTO [proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES ('" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prov(rut_prov As String, ru2 As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE proveedor SET rut_prov ='" + rut_prov + "', nombre_prov ='" + nombre_prov + "',direccion ='" + direccion + "', comuna ='" + comuna + "',ciudad ='" + ciudad + "',email ='" + email + "',fono ='" + fono + "' where rut_prov= '" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " fue actualizado")
        Else

            MsgBox("El Proveedor: " & UCase(nombre_prov) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prov(rut_prov As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM proveedor WHERE rut_prov ='" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(rut_prov) & " ha sido borrado")
        Else
            MsgBox("El Proveedor: " & UCase(rut_prov) & " no existe")
        End If

        desconectar()

    End Sub

    'PROVEEDOR'


    'REGISTROS'
    Public Sub insertar_registro(documento As String, n_documento As Integer, id_producto As String, precio As Double, cantidad As Integer, fecha As Date, usuario As String, tipo As String)

        conectar()

        comando = New SqlCommand("INSERT INTO  [registro] ([documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo])  VALUES ('" & documento & "','" & n_documento & "','" & id_producto & "','" & precio & "','" & cantidad & "','" & fecha & "','" & usuario & "','" & tipo & "')", conexion)
        comando.ExecuteNonQuery()
        MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub
    Sub eliminar_registro(id_pro As String, n_documento As Integer)

        conectar()

        comando = New SqlCommand("DELETE FROM registro WHERE id_producto ='" & id_pro & "' and n_documento ='" & n_documento & "'", conexion)
        comando.ExecuteNonQuery()
        MsgBox("El registro ha sido borrado")

        desconectar()

    End Sub

    Sub eliminar_mermas(id_mermas As Integer)
        conectar()

        comando = New SqlCommand(" select count(*) from mermas where id_mermas ='" & id_mermas & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM mermas WHERE id_mermas ='" & id_mermas & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(id_mermas) & " ha sido borrado")
        Else
            MsgBox("El Producto: " & UCase(id_mermas) & " no existe")
        End If

        desconectar()
    End Sub

    'REGISTROS'


    'actualizacion de bodega'
    Public Sub actua_prod(cod_producto As String, cantidad As Integer)
        Dim can As String
        conectar()

        comando = New SqlCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = cantidad + Val(can)
        MsgBox(cantidad)
        desconectar()
        conectar()
        comando = New SqlCommand("UPDATE producto SET cantidad ='" & cantidad & "' where cod_producto = '" & cod_producto & "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    Public Sub actua_prod2(cod_producto As String, cantidad As Integer)
        Dim can As String
        conectar()

        comando = New SqlCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = Val(can) - cantidad
        MsgBox(cantidad)
        desconectar()
        conectar()
        comando = New SqlCommand("UPDATE producto SET cantidad ='" & cantidad & "' where cod_producto = '" & cod_producto & "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    'actualizacion de bodega'

    'FACTURAS'

    Public Sub select_factura(n_factura As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from factura where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer
        FacturaVenta.validador = 0
        Factura.validador = 0
        validar = CInt(comando.ExecuteScalar)
        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")
            FacturaVenta.validador = 1
            Factura.validador = 1
        End If
        desconectar()

    End Sub
    Public Sub insertar_factura(n_factura As Integer, rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String, rut_cliente As String, fecha As Date, observacion As String, valor_neto As Double, iva As Double, total As Double, tipo As String)

        conectar()

        comando = New SqlCommand(" select count(*) from factura where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            Dim ss As Double = 0

            comando = New SqlCommand("INSERT INTO [factura] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [tipo])  VALUES ('" & n_factura & "','" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "','" & rut_cliente & "','" & fecha & "','" & observacion & "','" & valor_neto & "','" & iva & "','" & total & "','" & tipo & "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("La Factura " & UCase(n_factura) & " ha sido ingresadoa con exito")
        End If
        desconectar()
    End Sub

    'FACTURAS'

    'DETALLE FACTURA'
    Public Sub insertar_fac_deta(n_factura As Integer, cod_producto As String, descripcion As String, cantidad As Integer, precio_unitario As Double, total As Double)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_fac] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total])  VALUES ('" & n_factura & "','" & cod_producto & "','" & descripcion & "','" & cantidad & "','" & precio_unitario & "','" & total & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub


    'DETALLE FACTURA'

    'BOLETA'
    Public Sub select_boleta(n_boleta As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from boleta where n_boleta ='" & n_boleta & "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            MsgBox("El boleta: " & UCase(n_boleta) & " ya existe en la base de datos")
            boleta.validador = 1
        End If
        desconectar()
    End Sub
    Public Sub insertar_boleta(n_boleta As Integer, rut_empresa As String, rut_cliente As String, nombre_empresa As String, direccion As String, fecha As Date, total As Double)

        conectar()

        comando = New SqlCommand(" select count(*) from boleta where n_boleta ='" & n_boleta & "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            MsgBox("El boleta: " & UCase(n_boleta) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total])  VALUES ('" & n_boleta & "','" & rut_empresa & "','" & rut_cliente & "','" & nombre_empresa & "','" & direccion & "','" & fecha & "','" & total & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: "
        End If
        desconectar()
    End Sub

    Public Sub insertar_detalle_bol(n_boleta As Integer, cod_producto As String, cantidad As Integer)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad])  VALUES ('" & n_boleta & "','" & cod_producto & "','" & cantidad & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub

    Sub eliminar_boleta(n_boleta As Integer)
        conectar()

        comando = New SqlCommand(" select count(*) from detalle_boleta where n_boleta ='" & n_boleta & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM detalle_boleta WHERE n_boleta ='" & n_boleta & "'", conexion)
            comando.ExecuteNonQuery()
        Else

        End If

        desconectar()
    End Sub

    'BOLETA'








    'CLIENTE'
    Public Sub insertar_cliente(rut_cliente As String, nombre As String, email As String, fono As String, direccion As String, comuna As String, ciudad As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" + rut_cliente + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(rut_cliente) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES ('" & rut_cliente & "','" & nombre & "','" & email & "','" & fono & "','" & direccion & "','" & comuna & "','" & ciudad & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")

        End If
        desconectar()
    End Sub

    Sub eliminar_cliente(rut As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" & rut & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM cliente WHERE rut_cliente ='" & rut & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Cliente: " & UCase(rut) & " ha sido borrado")
        Else
            MsgBox("El Cliente: " & UCase(rut) & " no existe")
        End If

        desconectar()

    End Sub

    Public Sub editar_cliente(rut_cliente As String, rut As String, nombre As String, email As String, fono As String, direccion As String, comuna As String, ciudad As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" & rut & "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE cliente SET rut_cliente ='" & rut_cliente & "', nombre ='" & nombre & "',email ='" & email & "',fono ='" & fono & "',direccion ='" & direccion & "',comuna ='" & comuna & "',ciudad ='" & ciudad & "' where rut_cliente= '" & rut & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El cliente: " & UCase(rut_cliente) & " fue actualizado")
        Else

            MsgBox("El cliente: " & UCase(rut) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    'CLIENTE'

    'MERMAS'
    Public Sub insertar_mermas(cod_producto As String, producto As String, cantidad As Integer, fecha As Date, observacion As String)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then
            comando = New SqlCommand("INSERT INTO [mermas] ([cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES ('" & cod_producto & "','" & producto & "','" & cantidad & "','" & fecha & "','" & observacion & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")


        Else
            MsgBox("El Producto: " & UCase(producto) & " no existe ")

        End If
        desconectar()
    End Sub
    'MERMAS'







    Sub desconectar()
        conexion.Close()
    End Sub

End Class
