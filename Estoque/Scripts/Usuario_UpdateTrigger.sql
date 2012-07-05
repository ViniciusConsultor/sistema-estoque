
USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_UpdateTrigger]    Script Date: 07/05/2012 14:44:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Usuario_UpdateTrigger] 
    ON [dbo].[Usuario] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Usuario] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idUsuario] = [Usuario].[idUsuario] 
END;
GO
