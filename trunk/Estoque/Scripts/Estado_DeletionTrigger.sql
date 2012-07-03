USE [estoque]
GO

/****** Object:  Trigger [dbo].[Estado_DeletionTrigger]    Script Date: 07/03/2012 15:46:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Estado_DeletionTrigger] 
    ON [dbo].[Estado] 
    AFTER DELETE 
AS 
SET NOCOUNT ON 
UPDATE [dbo].[Estado_Tombstone] 
    SET [DeletionDate] = GETUTCDATE() 
    FROM deleted 
    WHERE deleted.[EstadoId] = [Estado_Tombstone].[EstadoId] 
IF @@ROWCOUNT = 0 
BEGIN 
    INSERT INTO [dbo].[Estado_Tombstone] 
    ([EstadoId], DeletionDate)
    SELECT [EstadoId], GETUTCDATE()
    FROM deleted 
END 

GO


