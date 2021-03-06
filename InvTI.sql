USE [master]
GO
/****** Object:  Database [InvTI]    Script Date: 01/05/2017 12:56:47 p.m. ******/
CREATE DATABASE [InvTI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InvTI', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\InvTI.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'InvTI_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\InvTI_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [InvTI] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InvTI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InvTI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InvTI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InvTI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InvTI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InvTI] SET ARITHABORT OFF 
GO
ALTER DATABASE [InvTI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InvTI] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [InvTI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InvTI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InvTI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InvTI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InvTI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InvTI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InvTI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InvTI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InvTI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InvTI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InvTI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InvTI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InvTI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InvTI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InvTI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InvTI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InvTI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InvTI] SET  MULTI_USER 
GO
ALTER DATABASE [InvTI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InvTI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InvTI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InvTI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [InvTI]
GO
/****** Object:  Table [dbo].[Consumible]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Consumible](
	[codigo_con] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[rendimiento] [int] NULL,
	[impresoras] [varchar](max) NULL,
	[descripcion] [varchar](max) NULL,
	[marca] [varchar](50) NULL,
	[color] [varchar](50) NULL,
	[cantidad_total] [int] NULL,
	[unidad] [varchar](50) NULL,
 CONSTRAINT [PK_Consumible] PRIMARY KEY CLUSTERED 
(
	[codigo_con] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConsumibleXentrada]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConsumibleXentrada](
	[id_entrada] [int] NOT NULL,
	[codigo_con] [varchar](50) NOT NULL,
	[estado] [int] NULL,
	[medio_ingreso] [varchar](max) NULL,
	[cantidad] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConsumibleXsalida]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConsumibleXsalida](
	[id_salida] [int] NOT NULL,
	[codigo_con] [varchar](50) NOT NULL,
	[id_destino] [int] NOT NULL,
	[estado] [int] NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento_destino]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento_destino](
	[id_destino] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Departamento_destino] PRIMARY KEY CLUSTERED 
(
	[id_destino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entrada_consu]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada_consu](
	[id_entrada] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [varchar](50) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Entrada_consu] PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entrada_mat]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada_mat](
	[codigo_contratacion] [varchar](50) NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [varchar](50) NULL,
	[medio_ingreso] [varchar](max) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Entrada_mat] PRIMARY KEY CLUSTERED 
(
	[codigo_contratacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entrada_rep]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada_rep](
	[id_entrada] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [varchar](50) NULL,
	[medio_ingreso] [varchar](max) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Entrada_rep] PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Material]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Material](
	[codigo_mat] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[cantidad] [int] NULL,
	[unidad] [varchar](50) NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[codigo_mat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaterialXentrada]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaterialXentrada](
	[codigo_contratacion] [varchar](50) NOT NULL,
	[codigo_mat] [varchar](50) NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaterialXpedido]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaterialXpedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[codigo_mat] [varchar](50) NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orden_trabajo]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orden_trabajo](
	[id_orden] [int] IDENTITY(1,1) NOT NULL,
	[fecha_solicitud] [varchar](50) NULL,
	[id_usuario] [int] NULL,
	[estado] [varchar](7) NULL,
	[lugar] [varchar](50) NULL,
	[justificacion_aprovacion] [varchar](max) NULL,
 CONSTRAINT [PK_Orden_trabajo] PRIMARY KEY CLUSTERED 
(
	[id_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[id_pedido] [int] NOT NULL,
	[id_orden] [int] NULL,
	[numero_orden] [int] NULL,
	[fecha] [varchar](50) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Repuesto]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Repuesto](
	[codigo_rep] [varchar](50) NOT NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[impresoras] [varchar](max) NULL,
	[tipo] [varchar](50) NULL,
	[descripcion] [varchar](max) NULL,
	[cantidad_nuevos] [int] NULL,
	[cantidad_viejos] [int] NULL,
	[cantidad_total] [int] NULL,
	[unidad] [varchar](50) NULL,
 CONSTRAINT [PK_Repuesto] PRIMARY KEY CLUSTERED 
(
	[codigo_rep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RepuestoXentrada]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RepuestoXentrada](
	[id_entrada] [int] NOT NULL,
	[codig_rep] [varchar](50) NULL,
	[estado] [int] NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RepuestoXsalida]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RepuestoXsalida](
	[id_salida] [int] NOT NULL,
	[codigo_rep] [varchar](50) NULL,
	[estado] [int] NULL,
	[cantidad] [int] NULL,
	[activo_destino] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salida_consu]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salida_consu](
	[id_salida] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [varchar](50) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Salida_consu] PRIMARY KEY CLUSTERED 
(
	[id_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salida_rep]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salida_rep](
	[id_salida] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [varchar](50) NULL,
	[observaciones] [varchar](max) NULL,
 CONSTRAINT [PK_Salida_rep] PRIMARY KEY CLUSTERED 
(
	[id_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/05/2017 12:56:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido1] [varchar](50) NULL,
	[apellido2] [varchar](50) NULL,
	[nombre_usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[rol] [varchar](2) NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ConsumibleXentrada]  WITH CHECK ADD  CONSTRAINT [FK_ConsumibleXentrada_Consumible] FOREIGN KEY([codigo_con])
REFERENCES [dbo].[Consumible] ([codigo_con])
GO
ALTER TABLE [dbo].[ConsumibleXentrada] CHECK CONSTRAINT [FK_ConsumibleXentrada_Consumible]
GO
ALTER TABLE [dbo].[ConsumibleXentrada]  WITH CHECK ADD  CONSTRAINT [FK_ConsumibleXentrada_Entrada_consu] FOREIGN KEY([id_entrada])
REFERENCES [dbo].[Entrada_consu] ([id_entrada])
GO
ALTER TABLE [dbo].[ConsumibleXentrada] CHECK CONSTRAINT [FK_ConsumibleXentrada_Entrada_consu]
GO
ALTER TABLE [dbo].[ConsumibleXsalida]  WITH CHECK ADD  CONSTRAINT [FK_ConsumibleXsalida_Consumible1] FOREIGN KEY([codigo_con])
REFERENCES [dbo].[Consumible] ([codigo_con])
GO
ALTER TABLE [dbo].[ConsumibleXsalida] CHECK CONSTRAINT [FK_ConsumibleXsalida_Consumible1]
GO
ALTER TABLE [dbo].[ConsumibleXsalida]  WITH CHECK ADD  CONSTRAINT [FK_ConsumibleXsalida_Departamento_destino] FOREIGN KEY([id_destino])
REFERENCES [dbo].[Departamento_destino] ([id_destino])
GO
ALTER TABLE [dbo].[ConsumibleXsalida] CHECK CONSTRAINT [FK_ConsumibleXsalida_Departamento_destino]
GO
ALTER TABLE [dbo].[ConsumibleXsalida]  WITH CHECK ADD  CONSTRAINT [FK_ConsumibleXsalida_Salida_consu] FOREIGN KEY([id_salida])
REFERENCES [dbo].[Salida_consu] ([id_salida])
GO
ALTER TABLE [dbo].[ConsumibleXsalida] CHECK CONSTRAINT [FK_ConsumibleXsalida_Salida_consu]
GO
ALTER TABLE [dbo].[Entrada_consu]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_consu_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Entrada_consu] CHECK CONSTRAINT [FK_Entrada_consu_Usuario1]
GO
ALTER TABLE [dbo].[Entrada_mat]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_mat_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Entrada_mat] CHECK CONSTRAINT [FK_Entrada_mat_Usuario1]
GO
ALTER TABLE [dbo].[Entrada_rep]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_rep_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Entrada_rep] CHECK CONSTRAINT [FK_Entrada_rep_Usuario1]
GO
ALTER TABLE [dbo].[MaterialXentrada]  WITH CHECK ADD  CONSTRAINT [FK_MaterialXentrada_Entrada_mat] FOREIGN KEY([codigo_contratacion])
REFERENCES [dbo].[Entrada_mat] ([codigo_contratacion])
GO
ALTER TABLE [dbo].[MaterialXentrada] CHECK CONSTRAINT [FK_MaterialXentrada_Entrada_mat]
GO
ALTER TABLE [dbo].[MaterialXentrada]  WITH CHECK ADD  CONSTRAINT [FK_MaterialXentrada_Material] FOREIGN KEY([codigo_mat])
REFERENCES [dbo].[Material] ([codigo_mat])
GO
ALTER TABLE [dbo].[MaterialXentrada] CHECK CONSTRAINT [FK_MaterialXentrada_Material]
GO
ALTER TABLE [dbo].[MaterialXpedido]  WITH CHECK ADD  CONSTRAINT [FK_MaterialXpedido_Material] FOREIGN KEY([codigo_mat])
REFERENCES [dbo].[Material] ([codigo_mat])
GO
ALTER TABLE [dbo].[MaterialXpedido] CHECK CONSTRAINT [FK_MaterialXpedido_Material]
GO
ALTER TABLE [dbo].[MaterialXpedido]  WITH CHECK ADD  CONSTRAINT [FK_MaterialXpedido_Pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[MaterialXpedido] CHECK CONSTRAINT [FK_MaterialXpedido_Pedido]
GO
ALTER TABLE [dbo].[Orden_trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Orden_trabajo_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Orden_trabajo] CHECK CONSTRAINT [FK_Orden_trabajo_Usuario1]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Orden_trabajo] FOREIGN KEY([id_orden])
REFERENCES [dbo].[Orden_trabajo] ([id_orden])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Orden_trabajo]
GO
ALTER TABLE [dbo].[RepuestoXentrada]  WITH CHECK ADD  CONSTRAINT [FK_RepuestoXentrada_Entrada_rep] FOREIGN KEY([id_entrada])
REFERENCES [dbo].[Entrada_rep] ([id_entrada])
GO
ALTER TABLE [dbo].[RepuestoXentrada] CHECK CONSTRAINT [FK_RepuestoXentrada_Entrada_rep]
GO
ALTER TABLE [dbo].[RepuestoXentrada]  WITH CHECK ADD  CONSTRAINT [FK_RepuestoXentrada_Repuesto] FOREIGN KEY([codig_rep])
REFERENCES [dbo].[Repuesto] ([codigo_rep])
GO
ALTER TABLE [dbo].[RepuestoXentrada] CHECK CONSTRAINT [FK_RepuestoXentrada_Repuesto]
GO
ALTER TABLE [dbo].[RepuestoXsalida]  WITH CHECK ADD  CONSTRAINT [FK_RepuestoXsalida_Repuesto] FOREIGN KEY([codigo_rep])
REFERENCES [dbo].[Repuesto] ([codigo_rep])
GO
ALTER TABLE [dbo].[RepuestoXsalida] CHECK CONSTRAINT [FK_RepuestoXsalida_Repuesto]
GO
ALTER TABLE [dbo].[RepuestoXsalida]  WITH CHECK ADD  CONSTRAINT [FK_RepuestoXsalida_Salida_rep] FOREIGN KEY([id_salida])
REFERENCES [dbo].[Salida_rep] ([id_salida])
GO
ALTER TABLE [dbo].[RepuestoXsalida] CHECK CONSTRAINT [FK_RepuestoXsalida_Salida_rep]
GO
ALTER TABLE [dbo].[Salida_consu]  WITH CHECK ADD  CONSTRAINT [FK_Salida_consu_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Salida_consu] CHECK CONSTRAINT [FK_Salida_consu_Usuario1]
GO
ALTER TABLE [dbo].[Salida_rep]  WITH CHECK ADD  CONSTRAINT [FK_Salida_rep_Usuario1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Salida_rep] CHECK CONSTRAINT [FK_Salida_rep_Usuario1]
GO
USE [master]
GO
ALTER DATABASE [InvTI] SET  READ_WRITE 
GO
