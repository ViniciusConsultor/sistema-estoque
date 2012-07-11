CREATE PROCEDURE sp_update_funcionario
	@idfuncionario INT,
	@telefone VARCHAR(10),
	@celular VARCHAR(10),
	@cargo VARCHAR(20),
	@rua VARCHAR(50),
	@casanum INT,
	@referencia VARCHAR(30),
	@idcidade INT,
	@excluido BIT
AS
BEGIN
	UPDATE dbo.Funcionario
	SET telefone = @telefone,
	celular = @celular,
	cargo = @cargo,
	rua = @rua,
	casaNum = @casanum,
	Referencia = @referencia,
	idCidade = @idcidade,
	excluido = @excluido
END
GO