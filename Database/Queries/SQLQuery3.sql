USE [amd2]
GO
select * from [dbo].[ip_clients]
select * from ip_users
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
           ( '2-11-2018'
            ,'2-11-2018'
           ,'client-1'
          ,'client-1'
           ,'client-1'
          ,'client-1'
          ,'client-1'
           ,'client-1'
           ,'client-1'
           ,'client-1'
          ,'client-1'
          ,'client-1'
           ,'client-1'
         ,'client-1'
         ,'client-1'
           ,'client-1'
            ,1)
GO

