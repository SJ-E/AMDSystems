USE [amd2]
GO

INSERT INTO [dbo].[ip_products]
           ([family_id]
           ,[product_sku]
           ,[product_name]
           ,[product_description]
           ,[product_price]
           ,[purchase_price]
           ,[provider_name]
           ,[tax_rate_id]
           ,[quantity]
           ,[sub_cate]
           ,[serial_number]
           ,[supp_name]
           ,[warenty_detail]
           ,[selling_price]
           ,[other_info]
           ,[purchase_org_price])
     VALUES
           (1
           ,'Pro'
           ,'Product Name-10'
           ,'Product Description-10'
           ,10
           ,10
           ,'xx'
           ,1
           ,100
           ,'xx'
           ,'12354'
           ,'xx'
           ,'1'
           ,10
           ,'s'
           ,'ss')
GO


select * from [dbo].[ip_products]