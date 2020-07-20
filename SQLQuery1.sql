USE [Controlinventario]
GO
/****** Object:  Table [dbo].[boleta]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[boleta](
	[n_boleta] [int] NULL,
	[rut_empresa] [varchar](50) NULL,
	[rut_cliente] [varchar](50) NULL,
	[nombre_empresa] [varchar](50) NULL,
	[direcion] [varchar](50) NULL,
	[fecha] [date] NULL,
	[total] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[rut_cliente] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_boleta]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_boleta](
	[n_boleta] [int] NULL,
	[cod_prodcuto] [varchar](50) NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_fac_egreso]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_fac_egreso](
	[n_factura] [int] NULL,
	[cod_producto] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](20, 0) NULL,
	[total] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_fac_ingreso]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_fac_ingreso](
	[n_factura] [int] NULL,
	[cod_producto] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](20, 0) NULL,
	[total] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_guia]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_guia](
	[n_guia] [int] NULL,
	[cod_producto] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](20, 0) NULL,
	[total] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_proveedor]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_proveedor](
	[cod_producto] [varchar](50) NULL,
	[rut_prov] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_egreso]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_egreso](
	[n_factura] [int] NOT NULL,
	[rut_prov] [varchar](50) NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[rut_cliente] [varchar](50) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
	[valor_neto] [decimal](20, 0) NULL,
	[iva] [money] NULL,
	[total] [decimal](20, 0) NULL,
 CONSTRAINT [PK_factura_egreso] PRIMARY KEY CLUSTERED 
(
	[n_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_ingreso]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_ingreso](
	[n_factura] [int] NOT NULL,
	[rut_prov] [varchar](50) NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[rut_cliente] [varchar](50) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
	[valor_neto] [decimal](20, 0) NULL,
	[iva] [money] NULL,
	[total] [decimal](20, 0) NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[n_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[guia_despacho]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guia_despacho](
	[n_guia] [int] IDENTITY(1,1) NOT NULL,
	[rut_prov] [varchar](50) NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[rut_cliente] [varchar](50) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
	[valor_neto] [decimal](20, 0) NULL,
	[iva] [money] NULL,
	[total] [decimal](20, 0) NULL,
	[factura_asociada] [int] NULL,
 CONSTRAINT [PK_guia_despacho] PRIMARY KEY CLUSTERED 
(
	[n_guia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mermas]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mermas](
	[id_mermas] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[cod_producto] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio] [decimal](20, 0) NULL,
	[tipo_producto] [varchar](50) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[rut_prov] [varchar](50) NOT NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[rut_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registro]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registro](
	[id_registro] [int] IDENTITY(1,1) NOT NULL,
	[documento] [varchar](50) NULL,
	[n_documento] [int] NULL,
	[id_producto] [varchar](50) NULL,
	[precio] [decimal](20, 0) NULL,
	[cantidad] [int] NULL,
	[fecha] [date] NULL,
	[usuario] [varchar](50) NULL,
	[tipo] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipousuario]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipousuario](
	[id_tipousuario] [int] NOT NULL,
	[permiso] [varchar](40) NULL,
 CONSTRAINT [PK_tipousuario] PRIMARY KEY CLUSTERED 
(
	[id_tipousuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 20/07/2020 0:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[rut] [varchar](35) NOT NULL,
	[nombre] [varchar](40) NULL,
	[contacto] [varchar](30) NULL,
	[genero] [varchar](20) NULL,
	[contraseña] [varchar](255) NULL,
	[id_tipousuario] [int] NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (200, N'44.300.251-0', NULL, N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-04' AS Date), NULL)
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (234, N'44.300.251-0', NULL, N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-04' AS Date), NULL)
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (3122, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-04' AS Date), NULL)
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (342, N'44.300.251-0', N'', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-05' AS Date), CAST(501 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (123223, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-08' AS Date), CAST(18000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1232, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-08' AS Date), CAST(3000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (31424, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-08' AS Date), CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (42314, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-08' AS Date), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1213, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-12' AS Date), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1214, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-13' AS Date), CAST(11000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1215, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-13' AS Date), CAST(10 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1216, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-07-14' AS Date), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1217, N'44.300.251-0', N'468468464', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-06-04' AS Date), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1218, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-05-13' AS Date), CAST(60500 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1219, N'44.300.251-0', N'84845454', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-04-08' AS Date), CAST(76000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1220, N'44.300.251-0', N'', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2020-03-11' AS Date), CAST(80000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1221, N'44.300.251-0', N'36654512', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2021-01-08' AS Date), CAST(800000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1222, N'44.300.251-0', N'468468464', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2019-10-17' AS Date), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1223, N'44.300.251-0', N'20435824', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2021-01-01' AS Date), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total]) VALUES (1224, N'44.300.251-0', N'468468464', N'MiOficinaS.A', N'Raul castellon #4565', CAST(N'2021-06-19' AS Date), CAST(60000 AS Decimal(20, 0)))
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'20435824', N'sebastian', N'sebastian@gmail.com', N'534262562', N'mtamoros #2343', N'La serena', N'La Serena')
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'19661999', N'jose castillo', N'joseje', N'2132312', N'angostua', N'la serena', N'la serena')
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'36654512', N'norber', N'asdsa', N'22323123', N'toki', N'La Serena', N'La Serena')
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'9934565', N'esperanza', N'assa', N'545463', N'peru 5656', N'La Serena', N'La Serena')
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'84845454', N'alvaro', N'asasa', N'4844542', N'viña 455', N'Ovalle', N'Ovalle')
GO
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'468468464', N'juan perez', N'asdsa', N'54654', N'sere5857', N'Coquimbo', N'Coquimbo')
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (200, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (234, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (3122, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (342, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (123223, N'RES-100', 12)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1232, N'RES-100', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1232, N'RES-100', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (31424, N'RES-100', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (31424, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1213, N'RES-100', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (42314, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1214, N'GOM-001', 22)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1215, N'PER-021', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1216, N'GOM-001', 3)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1217, N'ESC-009', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1218, N'GOM-001', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1218, N'ESC-009', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1218, N'IMP-007', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1219, N'MOU-004', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1219, N'TEC-002', 2)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1219, N'ESC-009', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1219, N'IMP-007', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1220, N'ESC-009', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1220, N'MON-007', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1221, N'IMP-007', 20)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1222, N'MOU-004', 5)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1223, N'ESC-009', 1)
GO
INSERT [dbo].[detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad]) VALUES (1224, N'MON-007', 1)
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (6, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (7, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (8, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (9, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (10, N'GOM-001', N'Goma ', 2, CAST(500 AS Decimal(20, 0)), CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (11, N'GOM-001', N'Goma ', 2, CAST(500 AS Decimal(20, 0)), CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (12, N'ESC-009', N'Escaner', 2, CAST(20000 AS Decimal(20, 0)), CAST(40000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (13, N'NOTA-006', N'Notas Adhesivas', 20, CAST(300 AS Decimal(20, 0)), CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (14, N'IMP-007', N'Impresora', 8, CAST(40000 AS Decimal(20, 0)), CAST(320000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (15, N'ESC-009', N'Escaner', 1, CAST(20000 AS Decimal(20, 0)), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (16, N'IMP-007', N'Impresora', 10, CAST(40000 AS Decimal(20, 0)), CAST(400000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (1, N'RES-100', N'Resma ', 20, CAST(100 AS Decimal(20, 0)), CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2, N'RES-100', N'Resma ', 200, CAST(1000 AS Decimal(20, 0)), CAST(200000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'RES-100', N'Resma ', 10, CAST(1500 AS Decimal(20, 0)), CAST(15000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'ARCH-9526', N'Archivador', 10, CAST(2000 AS Decimal(20, 0)), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (33223, N'PER-021', N'pera', 2, CAST(100 AS Decimal(20, 0)), CAST(200 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (33223, N'RES-100', N'resma', 4, CAST(1500 AS Decimal(20, 0)), CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (33223, N'RES-100', N'resma', 4, CAST(1500 AS Decimal(20, 0)), CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3454545, N'RES-100', N'resma', 4, CAST(1500 AS Decimal(20, 0)), CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (434343, N'GOM-001', N'Goma ', 3, CAST(500 AS Decimal(20, 0)), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (232323, N'PER-021', N'pera', 1, CAST(3131 AS Decimal(20, 0)), CAST(3131 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (232323, N'PER-021', N'pera', 1, CAST(3131 AS Decimal(20, 0)), CAST(3131 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2323888, N'PER-021', N'pera', 1, CAST(3131 AS Decimal(20, 0)), CAST(3131 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (122, N'GOM-001', N'Goma ', 1, CAST(100 AS Decimal(20, 0)), CAST(100 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (21212, N'GOM-001', N'Goma ', 4, CAST(66 AS Decimal(20, 0)), CAST(264 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (121433, N'GOM-001', N'Goma ', 4, CAST(66 AS Decimal(20, 0)), CAST(264 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (515451, N'GOM-001', N'Goma ', 4, CAST(66 AS Decimal(20, 0)), CAST(264 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (54, N'GOM-001', N'Goma ', 3, CAST(500 AS Decimal(20, 0)), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (54, N'RES-100', N'resma', 3, CAST(1500 AS Decimal(20, 0)), CAST(4500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (32, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (423, N'GOM-001', N'Goma ', 1, CAST(123 AS Decimal(20, 0)), CAST(123 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (43, N'RES-100', N'resma', 20, CAST(1000 AS Decimal(20, 0)), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3244, N'GOM-001', N'Goma ', 1, CAST(102 AS Decimal(20, 0)), CAST(102 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (32354534, N'GOM-001', N'Goma ', 1, CAST(23223 AS Decimal(20, 0)), CAST(23223 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (32551, N'RES-100', N'resma', 1, CAST(1500 AS Decimal(20, 0)), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (1111111, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'RES-100', N'resma', 1, CAST(1500 AS Decimal(20, 0)), CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (5, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (12123, N'GOM-001', N'Goma ', 1, CAST(12 AS Decimal(20, 0)), CAST(12 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (1, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2, N'GOM-001', N'Goma ', 2, CAST(500 AS Decimal(20, 0)), CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (123123123, N'GOM-001', N'Goma ', 299, CAST(100 AS Decimal(20, 0)), CAST(29900 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (22321323, N'PER-021', N'pera', 19, CAST(300 AS Decimal(20, 0)), CAST(5700 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (31213121, N'GOM-001', N'Goma ', 20, CAST(100 AS Decimal(20, 0)), CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (564565465, N'GOM-001', N'Goma ', 1, CAST(100 AS Decimal(20, 0)), CAST(100 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (31313213, N'MON-007', N'Monitor', 1, CAST(60000 AS Decimal(20, 0)), CAST(60000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (213213123, N'ESC-009', N'Escaner', 3, CAST(20000 AS Decimal(20, 0)), CAST(60000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (123123, N'IMP-007', N'Impresora', 80, CAST(402130 AS Decimal(20, 0)), CAST(32170400 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (12312321, N'ESC-009', N'Escaner', 1, CAST(213123 AS Decimal(20, 0)), CAST(213123 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (13123123, N'ESC-009', N'Escaner', 2, CAST(1000 AS Decimal(20, 0)), CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (1232132, N'IMP-007', N'Impresora', 20, CAST(64654 AS Decimal(20, 0)), CAST(1293080 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (5, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (4, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (5, N'GOM-001', N'Goma ', 2, CAST(500 AS Decimal(20, 0)), CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (6, N'ESC-009', N'Escaner', 2, CAST(20000 AS Decimal(20, 0)), CAST(40000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (7, N'NOTA-006', N'Notas Adhesivas', 20, CAST(300 AS Decimal(20, 0)), CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (8, N'IMP-007', N'Impresora', 8, CAST(40000 AS Decimal(20, 0)), CAST(320000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (9, N'ESC-009', N'Escaner', 1, CAST(20000 AS Decimal(20, 0)), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (10, N'IMP-007', N'Impresora', 10, CAST(40000 AS Decimal(20, 0)), CAST(400000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'fdf', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'GOM-001', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'PER-021', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'TEC-002', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'Silla-003', N'6312475-9')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'MOU-004', N'308956551')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'PORT-005', N'308956551')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'NOTA-006', N'308956551')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'MON-007', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'IMP-007', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'ESC-009', N'6312475-9')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'FOTO-010', N'20345845k')
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (1, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-10' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (2, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-10' AS Date), N'', CAST(810 AS Decimal(20, 0)), 190.0000, CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (3, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(1215 AS Decimal(20, 0)), 285.0000, CAST(1500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (4, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (5, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (6, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (7, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-12' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (8, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2019-08-08' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (9, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-06-04' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (10, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-13' AS Date), N'', CAST(810 AS Decimal(20, 0)), 190.0000, CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (11, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-13' AS Date), N'', CAST(810 AS Decimal(20, 0)), 190.0000, CAST(1000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (12, N'44300251-0', N'alvaro', N'viña 455', N'Ovalle', N'Ovalle', N'asasa', N'4844542', N'84845454', CAST(N'2020-07-19' AS Date), N'sadadas', CAST(49410 AS Decimal(20, 0)), 11590.0000, CAST(61000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (13, N'44300251-0', N'norber', N'toki', N'La Serena', N'La Serena', N'asdsa', N'22323123', N'36654512', CAST(N'2020-04-14' AS Date), N'as', CAST(37260 AS Decimal(20, 0)), 8740.0000, CAST(46000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (14, N'44300251-0', N'jose castillo', N'angostua', N'la serena', N'la serena', N'joseje', N'2132312', N'19661999', CAST(N'2020-02-11' AS Date), N'', CAST(259200 AS Decimal(20, 0)), 60800.0000, CAST(320000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (15, N'44300251-0', N'jose castillo', N'angostua', N'la serena', N'la serena', N'joseje', N'2132312', N'19661999', CAST(N'2021-03-03' AS Date), N'', CAST(16200 AS Decimal(20, 0)), 3800.0000, CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (16, N'44300251-0', N'esperanza', N'peru 5656', N'La Serena', N'La Serena', N'assa', N'545463', N'9934565', CAST(N'2019-12-11' AS Date), N'', CAST(324000 AS Decimal(20, 0)), 76000.0000, CAST(400000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (32, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-05' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (43, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-05' AS Date), N'', CAST(16200 AS Decimal(20, 0)), 3800.0000, CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (54, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-03' AS Date), N'', CAST(4860 AS Decimal(20, 0)), 1140.0000, CAST(6000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (423, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-05' AS Date), N'', CAST(100 AS Decimal(20, 0)), 2337.0000, CAST(123 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (3244, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-05' AS Date), N'', CAST(83 AS Decimal(20, 0)), 1938.0000, CAST(102 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (12123, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-12' AS Date), N'', CAST(10 AS Decimal(20, 0)), 228.0000, CAST(12 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (123123, N'5465651', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-04-16' AS Date), N'sdsd', CAST(26058024 AS Decimal(20, 0)), 6112376.0000, CAST(32170400 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (515451, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-03' AS Date), N'', CAST(214 AS Decimal(20, 0)), 5016.0000, CAST(264 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (1232132, N'6312475-9', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2019-11-13' AS Date), N'qewq', CAST(1047395 AS Decimal(20, 0)), 2456852.0000, CAST(1293080 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (12312321, N'6312475-9', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-03-18' AS Date), N'eqwew', CAST(2161692 AS Decimal(20, 0)), 50706345.0000, CAST(2668755 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (13123123, N'6312475-9', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2021-02-11' AS Date), N'', CAST(1620 AS Decimal(20, 0)), 380.0000, CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (22321323, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-13' AS Date), N'', CAST(4617 AS Decimal(20, 0)), 1083.0000, CAST(5700 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (31213121, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-13' AS Date), N'', CAST(3240 AS Decimal(20, 0)), 760.0000, CAST(4000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (31313213, N'45464522', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-06-09' AS Date), N'jajaj', CAST(50544 AS Decimal(20, 0)), 11856.0000, CAST(62400 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (32354534, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-10' AS Date), N'', CAST(23319 AS Decimal(20, 0)), 546972.0000, CAST(28788 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (123123123, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-13' AS Date), N'', CAST(24219 AS Decimal(20, 0)), 5681.0000, CAST(29900 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (213213123, N'308956551', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-05-09' AS Date), N'dddd', CAST(145800 AS Decimal(20, 0)), 34200.0000, CAST(180000 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (564565465, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-13' AS Date), N'', CAST(162 AS Decimal(20, 0)), 38.0000, CAST(200 AS Decimal(20, 0)))
GO
SET IDENTITY_INSERT [dbo].[guia_despacho] ON 
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (1, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 5)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (2, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 6)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (3, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2019-08-08' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 8)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (4, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-06-04' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 9)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (5, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-13' AS Date), N'', CAST(810 AS Decimal(20, 0)), 190.0000, CAST(1000 AS Decimal(20, 0)), 11)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (6, N'44300251-0', N'alvaro', N'viña 455', N'Ovalle', N'Ovalle', N'asasa', N'4844542', N'84845454', CAST(N'2020-07-19' AS Date), N'sadadas', CAST(49410 AS Decimal(20, 0)), 11590.0000, CAST(61000 AS Decimal(20, 0)), 12)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (7, N'44300251-0', N'norber', N'toki', N'La Serena', N'La Serena', N'asdsa', N'22323123', N'36654512', CAST(N'2020-04-14' AS Date), N'as', CAST(37260 AS Decimal(20, 0)), 8740.0000, CAST(46000 AS Decimal(20, 0)), 13)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (8, N'44300251-0', N'jose castillo', N'angostua', N'la serena', N'la serena', N'joseje', N'2132312', N'19661999', CAST(N'2020-02-11' AS Date), N'', CAST(259200 AS Decimal(20, 0)), 60800.0000, CAST(320000 AS Decimal(20, 0)), 14)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (9, N'44300251-0', N'jose castillo', N'angostua', N'la serena', N'la serena', N'joseje', N'2132312', N'19661999', CAST(N'2021-03-03' AS Date), N'', CAST(16200 AS Decimal(20, 0)), 3800.0000, CAST(20000 AS Decimal(20, 0)), 15)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (10, N'44300251-0', N'esperanza', N'peru 5656', N'La Serena', N'La Serena', N'assa', N'545463', N'9934565', CAST(N'2019-12-11' AS Date), N'', CAST(324000 AS Decimal(20, 0)), 76000.0000, CAST(400000 AS Decimal(20, 0)), 16)
GO
SET IDENTITY_INSERT [dbo].[guia_despacho] OFF
GO
SET IDENTITY_INSERT [dbo].[mermas] ON 
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (1, N'RES-100', N'Resma ', 10, CAST(N'2020-06-30' AS Date), NULL)
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (2, N'RES-100', N'Resma ', 10, CAST(N'2020-06-30' AS Date), NULL)
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (4, N'PER-021', N'pera', 5, CAST(N'2020-07-02' AS Date), N'productos dañados ')
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (5, N'GOM-001', N'Goma ', 3, CAST(N'2020-07-13' AS Date), N'mal estado')
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (7, N'MON-007', N'Monitor', 1, CAST(N'2020-07-19' AS Date), N'mal estado')
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (8, N'FOTO-010', N'Fotocopiadora', 1, CAST(N'2020-07-19' AS Date), N'Mal Estado')
GO
SET IDENTITY_INSERT [dbo].[mermas] OFF
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'ESC-009', N'Escaner', CAST(20000 AS Decimal(20, 0)), N'Computacion', 26)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'FOTO-010', N'Fotocopiadora', CAST(35000 AS Decimal(20, 0)), N'Computacion', 19)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'GOM-001', N'Goma ', CAST(500 AS Decimal(20, 0)), N'Papeleria', 28)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'IMP-007', N'Impresora', CAST(40000 AS Decimal(20, 0)), N'Computacion', 100)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'MON-007', N'Monitor', CAST(60000 AS Decimal(20, 0)), N'Computacion', 13)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'MOU-004', N'Mouse', CAST(4000 AS Decimal(20, 0)), N'Computacion', 45)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'NOTA-006', N'Notas Adhesivas', CAST(300 AS Decimal(20, 0)), N'Escritorio', 181)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'PORT-005', N'Portalapices', CAST(2000 AS Decimal(20, 0)), N'Escritorio', 80)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'RES-100', N'Resma', CAST(1500 AS Decimal(20, 0)), N'Papeleria', 8)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'SILLA-003', N'Silla Escritorio', CAST(50000 AS Decimal(20, 0)), N'Escritorio', 30)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'TEC-002', N'Teclado', CAST(6000 AS Decimal(20, 0)), N'Computacion', 48)
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'308956551', N'juan perez', N'angostura', N'la serena', N'la serena', N'asssa', N'1231231')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'45464522', N'Acer', N'santiago 4555', N'vitacura', N'Santiago', N'asa', N'34545')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'5465651', N'sp digital', N'asdad', N'coquimbo', N'coquimbo', N'asdsd', N'5546876')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'554544556', N'Genius', N'Santiago 255', N'Maipu', N'Santiago', N'asa', N'544545')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'6312475-9', N'espn', N'las rocas', N'la serena', N'la serena', N'asss', N'645511')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'64545432', N'Gear', N'macul 33', N'Macul', N'Santiago', N'sdasd', N'56546')
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'753511222', N'PC Factory', N'santiago21', N'vitacura', N'Santiago', N'sadas', N'6465456')
GO
SET IDENTITY_INSERT [dbo].[registro] ON 
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (1, N'Factura', 32, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-05' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (2, N'Factura', 423, N'GOM-001', CAST(123 AS Decimal(20, 0)), 1, CAST(N'2020-07-05' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (3, N'Boleta', 324, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-05' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (5, N'Boleta', 342, N'GOM-001', CAST(501 AS Decimal(20, 0)), 1, CAST(N'2020-07-05' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (6, N'Factura', 43, N'RES-100', CAST(1000 AS Decimal(20, 0)), 20, CAST(N'2020-07-05' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (7, N'Factura', 3244, N'GOM-001', CAST(102 AS Decimal(20, 0)), 1, CAST(N'2020-07-05' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (8, N'Boleta', 123223, N'RES-100', CAST(1500 AS Decimal(20, 0)), 12, CAST(N'2020-07-08' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (9, N'Boleta', 1232, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-08' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (10, N'Boleta', 1232, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-08' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (11, N'Boleta', 31424, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-08' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (12, N'Boleta', 31424, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-08' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (21, N'Factura', 32354534, N'GOM-001', CAST(23223 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (22, N'Factura', 32354534, N'RES-100', CAST(5565 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (23, N'Factura', 31342, N'GOM-001', CAST(1424 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (24, N'Factura', 32551, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (25, N'Factura', 1111111, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (28, N'Factura', 3, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-11' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (29, N'Factura', 4, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-11' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (30, N'Factura', 5, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-11' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (31, N'Factura', 6, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-11' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (32, N'Factura', 7, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-12' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (33, N'Factura', 12123, N'GOM-001', CAST(12 AS Decimal(20, 0)), 1, CAST(N'2020-07-12' AS Date), N'199482408', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (13, N'Boleta', 42314, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-08' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (16, N'Factura', 4242, N'RES-100', CAST(33242 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (26, N'Factura', 1, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-07-10' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (27, N'Factura', 2, N'GOM-001', CAST(500 AS Decimal(20, 0)), 2, CAST(N'2020-07-10' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (37, N'Boleta', 1213, N'RES-100', CAST(1500 AS Decimal(20, 0)), 1, CAST(N'2020-07-12' AS Date), N'199482408', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (38, N'Factura', 8, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2019-08-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (39, N'Factura', 9, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-06-04' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (40, N'Factura', 123123123, N'GOM-001', CAST(100 AS Decimal(20, 0)), 299, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (41, N'Factura', 22321323, N'PER-021', CAST(300 AS Decimal(20, 0)), 19, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (42, N'Factura', 31213121, N'GOM-001', CAST(100 AS Decimal(20, 0)), 20, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (43, N'Factura', 31213121, N'GOM-001', CAST(100 AS Decimal(20, 0)), 20, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (44, N'Factura', 564565465, N'GOM-001', CAST(100 AS Decimal(20, 0)), 1, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (45, N'Factura', 564565465, N'GOM-001', CAST(100 AS Decimal(20, 0)), 1, CAST(N'2020-07-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (47, N'Factura', 10, N'GOM-001', CAST(500 AS Decimal(20, 0)), 2, CAST(N'2020-07-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (48, N'Factura', 11, N'GOM-001', CAST(500 AS Decimal(20, 0)), 2, CAST(N'2020-07-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (49, N'Boleta', 1214, N'GOM-001', CAST(500 AS Decimal(20, 0)), 22, CAST(N'2020-07-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (51, N'Boleta', 1216, N'GOM-001', CAST(500 AS Decimal(20, 0)), 3, CAST(N'2020-07-14' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (53, N'Boleta', 1217, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2020-06-04' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (54, N'Boleta', 1218, N'GOM-001', CAST(500 AS Decimal(20, 0)), 1, CAST(N'2020-05-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (55, N'Boleta', 1218, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2020-05-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (56, N'Boleta', 1218, N'IMP-007', CAST(40000 AS Decimal(20, 0)), 1, CAST(N'2020-05-13' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (57, N'Boleta', 1219, N'MOU-004', CAST(4000 AS Decimal(20, 0)), 1, CAST(N'2020-04-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (58, N'Boleta', 1219, N'TEC-002', CAST(6000 AS Decimal(20, 0)), 2, CAST(N'2020-04-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (59, N'Boleta', 1219, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2020-04-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (60, N'Boleta', 1219, N'IMP-007', CAST(40000 AS Decimal(20, 0)), 1, CAST(N'2020-04-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (61, N'Boleta', 1220, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2020-03-11' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (62, N'Boleta', 1220, N'MON-007', CAST(60000 AS Decimal(20, 0)), 1, CAST(N'2020-03-11' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (63, N'Factura', 31313213, N'MON-007', CAST(60000 AS Decimal(20, 0)), 1, CAST(N'2020-06-09' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (64, N'Factura', 31313213, N'RES-100', CAST(600 AS Decimal(20, 0)), 4, CAST(N'2020-06-09' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (65, N'Factura', 213213123, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 3, CAST(N'2020-05-09' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (66, N'Factura', 213213123, N'PORT-005', CAST(3000 AS Decimal(20, 0)), 40, CAST(N'2020-05-09' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (67, N'Factura', 123123, N'IMP-007', CAST(402130 AS Decimal(20, 0)), 80, CAST(N'2020-04-16' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (68, N'Factura', 12312321, N'ESC-009', CAST(213123 AS Decimal(20, 0)), 1, CAST(N'2020-03-18' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (69, N'Factura', 12312321, N'NOTA-006', CAST(23232 AS Decimal(20, 0)), 100, CAST(N'2020-03-18' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (70, N'Factura', 12312321, N'MOU-004', CAST(21321 AS Decimal(20, 0)), 1, CAST(N'2020-03-18' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (71, N'Factura', 12312321, N'NOTA-006', CAST(111111 AS Decimal(20, 0)), 1, CAST(N'2020-03-18' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (72, N'Factura', 12, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 2, CAST(N'2020-07-19' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (73, N'Factura', 12, N'GOM-001', CAST(500 AS Decimal(20, 0)), 2, CAST(N'2020-07-19' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (74, N'Factura', 12, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2020-07-19' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (75, N'Factura', 13, N'NOTA-006', CAST(300 AS Decimal(20, 0)), 20, CAST(N'2020-04-14' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (76, N'Factura', 13, N'PORT-005', CAST(2000 AS Decimal(20, 0)), 20, CAST(N'2020-04-14' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (77, N'Factura', 14, N'IMP-007', CAST(40000 AS Decimal(20, 0)), 8, CAST(N'2020-07-19' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (78, N'Factura', 15, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2021-03-03' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (79, N'Factura', 16, N'IMP-007', CAST(40000 AS Decimal(20, 0)), 10, CAST(N'2019-12-11' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (80, N'Factura', 13123123, N'ESC-009', CAST(1000 AS Decimal(20, 0)), 2, CAST(N'2021-02-11' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (81, N'Factura', 1232132, N'IMP-007', CAST(64654 AS Decimal(20, 0)), 20, CAST(N'2019-11-13' AS Date), N'admin', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (82, N'Boleta', 1221, N'IMP-007', CAST(40000 AS Decimal(20, 0)), 20, CAST(N'2021-01-08' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (83, N'Boleta', 1222, N'MOU-004', CAST(4000 AS Decimal(20, 0)), 5, CAST(N'2019-10-17' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (84, N'Boleta', 1223, N'ESC-009', CAST(20000 AS Decimal(20, 0)), 1, CAST(N'2021-01-01' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (85, N'Boleta', 1224, N'MON-007', CAST(60000 AS Decimal(20, 0)), 1, CAST(N'2021-06-19' AS Date), N'admin', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo]) VALUES (50, N'Boleta', 1215, N'PER-021', CAST(10 AS Decimal(20, 0)), 1, CAST(N'2020-07-13' AS Date), N'admin', N'venta')
GO
SET IDENTITY_INSERT [dbo].[registro] OFF
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (100, N'root')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (101, N'admin gerente')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (102, N'gerente')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (103, N'operador bodega')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (104, N'visita')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (105, N'vendedor')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'admin', N'admin', N'23232', N'123232', N'a8mux6u+zeSvX+18My4CAIp9M3NjcK/0igwvMTtrC+A=', 100, N'dassa')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'admin gerente', N'admin gerente', N'554454', N'asa', N'a8mux6u+zeSvX+18My4CAIp9M3NjcK/0igwvMTtrC+A=', 101, N'ssa')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'bodega', N'bodeguero', N'454', N'masculino', N'9ot44zGYypaoT4ghOoz8kg3hPUOQSMZ/GXkYvNbGzeE=', 103, N'ds')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'gerente', N'asasa', N'251545', N'sasa', N'AM5t2y4RC5KE7sZwjb4AX2Yz40F5YMcPTJbddxqmwcc=', 102, N'sas')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'vendedor', N'vendedor', N'311513', N'asa', N'u2vqU9uOVJaV3xuDTQL1ikzYwlriJ6o/M+y3V5aAz84=', 105, N'dsd')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'visita', N'visita', N'sasa', N'masculino', N'5yZa8D5MgTum4BhPlpyl12ZjJ0Qc4J/HvukvwAsVLGQ=', 104, N'asas')
GO
