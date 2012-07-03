USE [estoque]
GO

/****** Object:  Table [dbo].[Produtos_Tombstone]    Script Date: 07/03/2012 15:52:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produtos_Tombstone](
	[idProduto] [int] NOT NULL,
	[DeletionDate] [datetime] NULL,
 CONSTRAINT [PKDEL_Produtos_Tombstone_idProduto] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

