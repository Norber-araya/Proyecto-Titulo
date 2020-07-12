USE [Controlinventario]
GO
/****** Object:  Table [dbo].[boleta]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[cliente]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[detalle_boleta]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[detalle_fac_egreso]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[detalle_fac_ingreso]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[detalle_guia]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[detalle_proveedor]    Script Date: 12/07/2020 1:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_proveedor](
	[cod_producto] [varchar](50) NULL,
	[rut_prov] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_egreso]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[factura_ingreso]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[guia_despacho]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[mermas]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[producto]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[proveedor]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[registro]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[tipousuario]    Script Date: 12/07/2020 1:07:57 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 12/07/2020 1:07:57 ******/
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
INSERT [dbo].[cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES (N'20435824', N'sebastian', N'sebastian@gmail.com', N'534262562', N'mtamoros #2343', N'La serena', N'La Serena')
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
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (6, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (7, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
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
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (5, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2, N'GOM-001', N'Goma ', 1, CAST(500 AS Decimal(20, 0)), CAST(500 AS Decimal(20, 0)))
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
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (515451, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-03' AS Date), N'', CAST(214 AS Decimal(20, 0)), 5016.0000, CAST(264 AS Decimal(20, 0)))
GO
INSERT [dbo].[factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total]) VALUES (32354534, N'20345845k', N'MiOficinaS.A', N'Raul castellon #4565', N' La Serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-07-10' AS Date), N'', CAST(23319 AS Decimal(20, 0)), 546972.0000, CAST(28788 AS Decimal(20, 0)))
GO
SET IDENTITY_INSERT [dbo].[guia_despacho] ON 
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (1, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 5)
GO
INSERT [dbo].[guia_despacho] ([n_guia], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada]) VALUES (2, N'44300251-0', N'sebastian', N'mtamoros #2343', N'La serena', N'La Serena', N'sebastian@gmail.com', N'534262562', N'20435824', CAST(N'2020-07-11' AS Date), N'', CAST(405 AS Decimal(20, 0)), 95.0000, CAST(500 AS Decimal(20, 0)), 6)
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
SET IDENTITY_INSERT [dbo].[mermas] OFF
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'GOM-001', N'Goma ', CAST(500 AS Decimal(20, 0)), N'oficina', 3)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'PER-021', N'pera', CAST(10 AS Decimal(20, 0)), N'fruta', 0)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'RES-100', N'resma', CAST(1500 AS Decimal(20, 0)), N'oficina', 4)
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'20345845k', N'Jose ', N'matamoros', N'la serena', N'La serena', N'jose@gmail.com', N'54672398')
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
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'199482408', N'Norber araya', N'953559708', N'masculino', N'iNjFcBaCs4QcvAT6JcltxQRdTXIdg1hxiK3ve3Een64=', 100, N'diegoandresx0@gmail.com')
GO
ALTER TABLE [dbo].[detalle_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_detalle_proveedor_proveedor] FOREIGN KEY([rut_prov])
REFERENCES [dbo].[proveedor] ([rut_prov])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalle_proveedor] CHECK CONSTRAINT [FK_detalle_proveedor_proveedor]
GO
