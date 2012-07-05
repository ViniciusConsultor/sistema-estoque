
CREATE PROCEDURE sp_insert_funcionario
	@nome VARCHAR(50),
	@datanascimento VARCHAR(10),
	@usuario VARCHAR(30),
	@senha VARCHAR(10),
	@perfil VARCHAR(20),
	@email VARCHAR(50),
	@cpf VARCHAR(11),
	@rg VARCHAR(10),
	@ctps VARCHAR(10),
	@ctpsSerie VARCHAR(5),
	@telefone VARCHAR(10),
	@celular VARCHAR(10),
	@rua VARCHAR(50),
	@casanum INT,
	@idcidade INT,
	@idestado TINYINT,
	@cargo VARCHAR(20),
	@complemento VARCHAR(30),
	@referencia VARCHAR(30),
	@ativo BIT,
	@id INT
AS
	INSERT INTO dbo.Funcionario (nome, dataNascimento, usuario, senha, perfil, email, cpf, rg, ctps, ctpsSerie, telefone, celular, rua, casaNum, idCidade, idEstado, cargo, complemento, Referencia, ativo)
	VALUES (@nome, @datanascimento, @usuario, @senha, @perfil, @email, @cpf, @rg, @ctps, @ctpsserie, @telefone, @celular, @rua, @casanum, @idcidade, @idestado, @cargo, @complemento, @referencia, @ativo) set @id = @@IDENTITY
	

