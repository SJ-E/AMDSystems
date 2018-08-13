USE [AMDSystems]
GO

INSERT INTO [dbo].[ip_clients]
           ([client_date_created]
           ,[client_date_modified]
           ,[client_name]
           ,[client_address_1]
           ,[client_address_2]
           ,[client_city]
           ,[client_state]
           ,[client_zip]
           ,[client_country]
           ,[client_phone]
           ,[client_fax]
           ,[client_mobile]
           ,[client_email]
           ,[client_web]
           ,[client_vat_id]
           ,[client_tax_code]
           ,[client_active])
     VALUES
           (<client_date_created, datetime,>
           ,<client_date_modified, datetime,>
           ,<client_name, varchar(max),>
           ,<client_address_1, varchar(max),>
           ,<client_address_2, varchar(max),>
           ,<client_city, varchar(max),>
           ,<client_state, varchar(max),>
           ,<client_zip, varchar(max),>
           ,<client_country, varchar(max),>
           ,<client_phone, varchar(max),>
           ,<client_fax, varchar(max),>
           ,<client_mobile, varchar(max),>
           ,<client_email, varchar(max),>
           ,<client_web, varchar(max),>
           ,<client_vat_id, varchar(max),>
           ,<client_tax_code, varchar(max),>
           ,<client_active, int,>)
GO


