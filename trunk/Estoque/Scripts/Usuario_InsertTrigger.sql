
USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_InsertTrigger]    Script Date: 07/05/2012 14:40:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Usuario_InsertTrigger] 
    ON [dbo].[Usuario] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Usuario] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[idUsuario] = [Usuario].[idUsuario] 
END;
GO