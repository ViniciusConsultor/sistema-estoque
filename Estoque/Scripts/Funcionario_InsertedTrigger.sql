USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_InsertTrigger]    Script Date: 07/03/2012 15:43:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Funcionario_InsertTrigger] 
    ON [dbo].[Funcionario] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Funcionario] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idFuncionario] = [Funcionario].[idFuncionario] 
END;
GO


