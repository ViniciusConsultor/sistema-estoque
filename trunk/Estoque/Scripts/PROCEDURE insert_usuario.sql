USE estoque
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_insert_usuario
	@usuario VARCHAR(30),
	@senha VARCHAR(10),
	@perfil VARCHAR(20),
	@idfuncionario INT,
	@ativo BIT
AS	
	INSERT INTO dbo.Usuario (usuario, senha, perfil, idFuncionario, ativo)
	VALUES (@usuario, @senha, @perfil, @idfuncionario, @ativo)
GO