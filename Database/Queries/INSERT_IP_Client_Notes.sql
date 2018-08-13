USE [AMDSystems]
GO

INSERT INTO [dbo].[ip_client_notes]
           ([client_id]
           ,[client_note_date]
           ,[client_note])
     VALUES
           (<client_id, int,>
           ,<client_note_date, date,>
           ,<client_note, varchar(max),>)
GO


