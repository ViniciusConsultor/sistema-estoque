USE [estoque]
GO

/****** Object:  Trigger [dbo].[categoria_UpdateTrigger]    Script Date: 07/03/2012 15:49:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[categoria_UpdateTrigger] 
    ON [dbo].[categoria] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[categoria] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idCategoria] = [categoria].[idCategoria] 
END;
GO

