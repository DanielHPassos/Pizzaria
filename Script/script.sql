USE [Pizzaria_Management]
GO
/****** Object:  User [FATECRL\lab1]    Script Date: 15/04/2015 12:23:00 ******/
CREATE USER [FATECRL\lab1] FOR LOGIN [FATECRL\lab1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [FATECRL\prova1]    Script Date: 15/04/2015 12:23:00 ******/
CREATE USER [FATECRL\prova1] FOR LOGIN [FATECRL\prova1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [FATECRL\lab1]
GO
ALTER ROLE [db_owner] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [FATECRL\prova1]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [FATECRL\prova1]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[cd_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[nm_Cliente] [nvarchar](50) NULL,
	[ds_Endereco] [nvarchar](50) NULL,
	[dt_Nascimento] [date] NULL,
	[cd_TelResidencial] [nvarchar](15) NULL,
	[cd_TelCelular] [nvarchar](15) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[cd_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[cd_Funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nm_Funcionario] [nvarchar](50) NULL,
	[ds_Endereco] [nvarchar](50) NULL,
	[dt_Nascimento] [date] NULL,
	[cd_TelResidencial] [nvarchar](15) NULL,
	[cd_TelCelular] [nvarchar](15) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[cd_Funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[cd_Pedido] [int] IDENTITY(1,1) NOT NULL,
	[cd_Cliente] [int] NULL,
	[cd_Funcionario] [int] NULL,
	[cd_Produto] [int] NULL,
	[dt_Pedido] [date] NULL,
	[vl_Total] [decimal](18, 2) NULL,
	[ic_TipoEntrega] [binary](1) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[cd_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pizza]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizza](
	[cd_Pizza] [int] IDENTITY(1,1) NOT NULL,
	[nm_Pizza] [nvarchar](50) NULL,
	[ds_Pizza] [nvarchar](50) NULL,
	[cd_Produto] [int] NULL,
	[vl_Pizza] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Pizza] PRIMARY KEY CLUSTERED 
(
	[cd_Pizza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PizzaPedida]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaPedida](
	[cd_Pedido] [int] NULL,
	[cd_Pizza] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produto]    Script Date: 15/04/2015 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[cd_Produto] [int] IDENTITY(1,1) NOT NULL,
	[nm_Produto] [nvarchar](50) NULL,
	[ds_Produto] [nvarchar](50) NULL,
	[qt_Produto] [int] NULL,
	[vl_Produto] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[cd_Produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([cd_Cliente])
REFERENCES [dbo].[Cliente] ([cd_Cliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Funcionario] FOREIGN KEY([cd_Funcionario])
REFERENCES [dbo].[Funcionario] ([cd_Funcionario])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Funcionario]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Produto] FOREIGN KEY([cd_Produto])
REFERENCES [dbo].[Produto] ([cd_Produto])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Produto]
GO
ALTER TABLE [dbo].[Pizza]  WITH CHECK ADD  CONSTRAINT [FK_Pizza_Produto] FOREIGN KEY([cd_Produto])
REFERENCES [dbo].[Produto] ([cd_Produto])
GO
ALTER TABLE [dbo].[Pizza] CHECK CONSTRAINT [FK_Pizza_Produto]
GO
