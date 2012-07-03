USE [estoque]
GO

/****** Object:  Table [dbo].[categoria]    Script Date: 07/03/2012 15:50:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](30) NOT NULL,
	[descricaoCat] [varchar](100) NULL,
	[LastEditDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[categoria] ADD  CONSTRAINT [DF_categoria_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[categoria] ADD  CONSTRAINT [DF_categoria_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO

