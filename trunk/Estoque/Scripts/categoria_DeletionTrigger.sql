USE [estoque]
GO

/****** Object:  Trigger [dbo].[categoria_DeletionTrigger]    Script Date: 07/03/2012 15:49:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[categoria_DeletionTrigger] 
    ON [dbo].[categoria] 
    AFTER DELETE 
AS 
SET NOCOUNT ON 
UPDATE [dbo].[categoria_Tombstone] 
    SET [DeletionDate] = GETUTCDATE() 
    FROM deleted 
    WHERE deleted.[idCategoria] = [categoria_Tombstone].[idCategoria] 
IF @@ROWCOUNT = 0 
BEGIN 
    INSERT INTO [dbo].[categoria_Tombstone] 
    ([idCategoria], DeletionDate)
    SELECT [idCategoria], GETUTCDATE()
    FROM deleted 
END 

GO

