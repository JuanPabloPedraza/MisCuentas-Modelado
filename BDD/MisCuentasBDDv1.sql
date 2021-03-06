
-- IMPORTANTE
--Crear Primero base de datos con el nombre MisCuentas
USE [MisCuentas]
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 30/10/2020 15:42:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipoMovimiento] [varchar](25) NOT NULL,
	[importe] [float] NOT NULL,
 CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
