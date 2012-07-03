USE [estoque]
GO

/****** Object:  Trigger [dbo].[categoria_InsertTrigger]    Script Date: 07/03/2012 15:49:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[categoria_InsertTrigger] 
    ON [dbo].[categoria] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[categoria] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idCategoria] = [categoria].[idCategoria] 
END;
GO

