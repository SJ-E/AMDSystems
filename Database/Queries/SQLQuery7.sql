USE [amd2]
GO

INSERT INTO [dbo].[ip_tax_rates]
           ([tax_rate_name]
           ,[tax_rate_percent])
     VALUES
           ('18.00% - storage '
           ,18.0)
GO

select * from ip_users