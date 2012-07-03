USE [estoque]
GO

/****** Object:  Table [dbo].[Cidade_Tombstone]    Script Date: 07/03/2012 15:51:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cidade_Tombstone](
	[CidadeId] [int] NOT NULL,
	[DeletionDate] [datetime] NULL,
 CONSTRAINT [PKDEL_Cidade_Tombstone_CidadeId] PRIMARY KEY CLUSTERED 
(
	[CidadeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

