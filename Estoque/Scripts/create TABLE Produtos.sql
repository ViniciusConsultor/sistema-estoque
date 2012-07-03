USE [estoque]
GO

/****** Object:  Table [dbo].[Produtos]    Script Date: 07/03/2012 15:52:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Produtos](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[idCategoria] [int] NOT NULL,
	[codigoBarras] [varchar](10) NULL,
	[quantidade] [int] NULL,
	[diponivel] [bit] NULL,
	[idFornecedor] [int] NULL,
	[valorAVista] [int] NULL,
	[valorBase] [int] NULL,
	[valorPrazo] [int] NULL,
	[valorCredito] [int] NULL,
	[cadastradoEm] [datetime] NOT NULL,
	[cadstradoPor] [int] NOT NULL,
	[excluido] [bit] NULL,
	[LastEditDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_Proutos] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Proutos_categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[categoria] ([idCategoria])
GO

ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Proutos_categoria]
GO

ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO

