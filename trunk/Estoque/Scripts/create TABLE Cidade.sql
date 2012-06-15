CREATE TABLE [Cidade](
[CidadeId] [int] NOT NULL,
[Nome] [varchar](38) NOT NULL,
[EstadoId] [tinyint] NULL,
[Capital] [bit] NOT NULL,
CONSTRAINT [PK_Cidade] PRIMARY KEY ([CidadeId])
)