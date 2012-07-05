USE [estoque]
GO

/****** Object:  Table [dbo].[Funcionario]    Script Date: 07/03/2012 15:51:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Funcionario](
	[idFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[dataNascimento] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[cpf] [varchar](11) NOT NULL,
	[rg] [varchar](10) NOT NULL,
	[ctps] [varchar](10) NULL,
	[ctpsSerie] [varchar](5) NULL,
	[telefone] [varchar](10) NULL,
	[celular] [varchar](10) NULL,
	[cargo] [varchar](20) NULL,
	[rua] [varchar](50) NULL,
	[casaNum] [int] NULL,
	[Referencia] [varchar](30) NULL,
	[idCidade] [int] NULL,
	[idEstado] [tinyint] NULL,	
) ON [PRIMARY]
SET ANSI_PADDING OFF
ALTER TABLE [dbo].[Funcionario] ADD [LastEditDate] [datetime] NULL
ALTER TABLE [dbo].[Funcionario] ADD [CreationDate] [datetime] NULL
/****** Object:  Index [PK_Funcionario]    Script Date: 07/03/2012 15:51:30 ******/
ALTER TABLE [dbo].[Funcionario] ADD  CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Funcionario] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([EstadoId])
GO

ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [FK_Estado_Funcionario]
GO

ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_Funcionario_Cidade] FOREIGN KEY([idCidade])
REFERENCES [dbo].[Cidade] ([CidadeId])
GO

ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [FK_Funcionario_Cidade]
GO

ALTER TABLE [dbo].[Funcionario] ADD  CONSTRAINT [DF_Funcionario_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[Funcionario] ADD  CONSTRAINT [DF_Funcionario_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO

