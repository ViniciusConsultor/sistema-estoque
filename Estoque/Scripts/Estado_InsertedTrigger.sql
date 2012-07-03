USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_InsertTrigger]    Script Date: 07/03/2012 15:47:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Estado_InsertTrigger] 
    ON [dbo].[Estado] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [dbo].[Estado] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[EstadoId] = [Estado].[EstadoId] 
END;
GO


