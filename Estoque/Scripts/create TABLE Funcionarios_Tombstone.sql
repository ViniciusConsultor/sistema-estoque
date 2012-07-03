USE [estoque]
GO

/****** Object:  Table [dbo].[Funcionario_Tombstone]    Script Date: 07/03/2012 15:52:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Funcionario_Tombstone](
	[idFuncionario] [int] NOT NULL,
	[DeletionDate] [datetime] NULL,
 CONSTRAINT [PKDEL_Funcionario_Tombstone_idFuncionario] PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

