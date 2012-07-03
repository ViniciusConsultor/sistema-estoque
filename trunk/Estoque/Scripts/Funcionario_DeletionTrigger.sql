USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_DeletionTrigger]    Script Date: 07/03/2012 15:40:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Funcionario_DeletionTrigger] 
    ON [dbo].[Funcionario] 
    AFTER DELETE 
AS 
SET NOCOUNT ON 
UPDATE [dbo].[Funcionario_Tombstone] 
    SET [DeletionDate] = GETUTCDATE() 
    FROM deleted 
    WHERE deleted.[idFuncionario] = [Funcionario_Tombstone].[idFuncionario] 
IF @@ROWCOUNT = 0 
BEGIN 
    INSERT INTO [dbo].[Funcionario_Tombstone] 
    ([idFuncionario], DeletionDate)
    SELECT [idFuncionario], GETUTCDATE()
    FROM deleted 
END 

GO


