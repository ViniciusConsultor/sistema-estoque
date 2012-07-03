USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_UpdateTrigger]    Script Date: 07/03/2012 15:47:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Estado_UpdateTrigger] 
    ON [dbo].[Estado] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Estado] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[EstadoId] = [Estado].[EstadoId] 
END;
GO

