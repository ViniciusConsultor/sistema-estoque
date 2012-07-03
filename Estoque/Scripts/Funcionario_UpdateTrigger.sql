USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_UpdateTrigger]    Script Date: 07/03/2012 15:45:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Funcionario_UpdateTrigger] 
    ON [dbo].[Funcionario] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Funcionario] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idFuncionario] = [Funcionario].[idFuncionario] 
END;
GO


