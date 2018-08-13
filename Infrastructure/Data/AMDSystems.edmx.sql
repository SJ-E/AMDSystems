
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/14/2018 12:15:19
-- Generated from EDMX file: F:\Santhosh\SPCodePractice\AMDSystems\AMDSystems\Infrastructure\Data\AMDSystems.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [amd2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__060DEAE8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__060DEAE8];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__0AD2A005]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_notes] DROP CONSTRAINT [FK__ip_client__clien__0AD2A005];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__5BAD9CC8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_notes] DROP CONSTRAINT [FK__ip_client__clien__5BAD9CC8];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__5D95E53A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__5D95E53A];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__5E8A0973]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__5E8A0973];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__5F7E2DAC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__5F7E2DAC];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__607251E5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__607251E5];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__6166761E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__6166761E];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__625A9A57]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__625A9A57];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__634EBE90]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__634EBE90];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_client__clien__6442E2C9]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__6442E2C9];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__clien__31B762FC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__clien__31B762FC];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__clien__32E0915F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__clien__32E0915F];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__clien__5DCAEF64]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__clien__5DCAEF64];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__clien__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__clien__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__30F848ED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__invoi__30F848ED];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__32AB8735]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__invoi__32AB8735];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__41EDCAC5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoice_custom] DROP CONSTRAINT [FK__ip_invoic__invoi__41EDCAC5];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__43D61337]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [FK__ip_invoic__invoi__43D61337];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__5BE2A6F2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__invoi__5BE2A6F2];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__60A75C0F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__invoi__60A75C0F];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__619B8048]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoice_custom] DROP CONSTRAINT [FK__ip_invoic__invoi__619B8048];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [FK__ip_invoic__invoi__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__invoi__73BA3083]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [FK__ip_invoic__invoi__73BA3083];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__user___339FAB6E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__user___339FAB6E];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__user___5CD6CB2B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__user___5CD6CB2B];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_invoic__user___5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__user___5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__ip_quote___quote__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [FK__ip_quote___quote__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_products_ip_families]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [FK_ip_products_ip_families];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_products_ip_tax_rates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [FK_ip_products_ip_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quote_ip_payments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_payments] DROP CONSTRAINT [FK_ip_quote_ip_payments];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quote_items_ip_products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [FK_ip_quote_items_ip_products];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quote_items_ip_quotes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [FK_ip_quote_items_ip_quotes];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quote_tax_rates_ip_quote_tax_rates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quote_tax_rates] DROP CONSTRAINT [FK_ip_quote_tax_rates_ip_quote_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quote_tax_rates_ip_tax_rates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quote_tax_rates] DROP CONSTRAINT [FK_ip_quote_tax_rates_ip_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quotes_ip_clients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [FK_ip_quotes_ip_clients];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quotes_ip_invoice_groups]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [FK_ip_quotes_ip_invoice_groups];
GO
IF OBJECT_ID(N'[dbo].[FK_ip_quotes_ip_users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [FK_ip_quotes_ip_users];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ip_client_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_client_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_client_notes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_client_notes];
GO
IF OBJECT_ID(N'[dbo].[ip_clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_clients];
GO
IF OBJECT_ID(N'[dbo].[ip_company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_company];
GO
IF OBJECT_ID(N'[dbo].[ip_company_profile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_company_profile];
GO
IF OBJECT_ID(N'[dbo].[ip_custom_fields]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_custom_fields];
GO
IF OBJECT_ID(N'[dbo].[ip_estimate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_estimate];
GO
IF OBJECT_ID(N'[dbo].[ip_estimate_items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_estimate_items];
GO
IF OBJECT_ID(N'[dbo].[ip_families]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_families];
GO
IF OBJECT_ID(N'[dbo].[ip_import_details]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_import_details];
GO
IF OBJECT_ID(N'[dbo].[ip_imports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_imports];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_groups];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_item_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_item_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_items];
GO
IF OBJECT_ID(N'[dbo].[ip_invoice_tax_rates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoice_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[ip_invoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoices];
GO
IF OBJECT_ID(N'[dbo].[ip_invoices_recurring]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_invoices_recurring];
GO
IF OBJECT_ID(N'[dbo].[ip_job_portal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_job_portal];
GO
IF OBJECT_ID(N'[dbo].[ip_make]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_make];
GO
IF OBJECT_ID(N'[dbo].[ip_merchant_responses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_merchant_responses];
GO
IF OBJECT_ID(N'[dbo].[ip_model]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_model];
GO
IF OBJECT_ID(N'[dbo].[ip_payment_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_payment_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_payment_methods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_payment_methods];
GO
IF OBJECT_ID(N'[dbo].[ip_payments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_payments];
GO
IF OBJECT_ID(N'[dbo].[ip_products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_products];
GO
IF OBJECT_ID(N'[dbo].[ip_projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_projects];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase_item_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase_item_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase_items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase_items];
GO
IF OBJECT_ID(N'[dbo].[ip_purchase_tax_rates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_purchase_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[ip_quote_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quote_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_quote_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quote_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_quote_item_amounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quote_item_amounts];
GO
IF OBJECT_ID(N'[dbo].[ip_quote_items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quote_items];
GO
IF OBJECT_ID(N'[dbo].[ip_quote_tax_rates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quote_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[ip_quotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_quotes];
GO
IF OBJECT_ID(N'[dbo].[ip_Spares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_Spares];
GO
IF OBJECT_ID(N'[dbo].[ip_tax_rates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_tax_rates];
GO
IF OBJECT_ID(N'[dbo].[ip_user_clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_user_clients];
GO
IF OBJECT_ID(N'[dbo].[ip_user_custom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_user_custom];
GO
IF OBJECT_ID(N'[dbo].[ip_users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_users];
GO
IF OBJECT_ID(N'[dbo].[ip_versions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ip_versions];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_email_templates]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_email_templates];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_item_lookups]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_item_lookups];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_sessions]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_sessions];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_settings]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_settings];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_tasks]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_tasks];
GO
IF OBJECT_ID(N'[AMDModelStoreContainer].[ip_uploads]', 'U') IS NOT NULL
    DROP TABLE [AMDModelStoreContainer].[ip_uploads];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ip_client_custom'
CREATE TABLE [dbo].[ip_client_custom] (
    [client_custom_id] int IDENTITY(1,1) NOT NULL,
    [client_id] int  NOT NULL
);
GO

-- Creating table 'ip_client_notes'
CREATE TABLE [dbo].[ip_client_notes] (
    [client_note_id] int IDENTITY(1,1) NOT NULL,
    [client_id] int  NOT NULL,
    [client_note_date] datetime  NOT NULL,
    [client_note] varchar(max)  NOT NULL
);
GO

-- Creating table 'ip_clients'
CREATE TABLE [dbo].[ip_clients] (
    [client_id] int IDENTITY(1,1) NOT NULL,
    [client_date_created] datetime  NOT NULL,
    [client_date_modified] datetime  NOT NULL,
    [client_name] varchar(max)  NULL,
    [client_address_1] varchar(max)  NULL,
    [client_address_2] varchar(max)  NULL,
    [client_city] varchar(max)  NULL,
    [client_state] varchar(max)  NULL,
    [client_zip] varchar(max)  NULL,
    [client_country] varchar(max)  NULL,
    [client_phone] varchar(max)  NULL,
    [client_fax] varchar(max)  NULL,
    [client_mobile] varchar(max)  NULL,
    [client_email] varchar(max)  NULL,
    [client_web] varchar(max)  NULL,
    [client_vat_id] varchar(max)  NULL,
    [client_tax_code] varchar(max)  NULL,
    [client_active] int  NOT NULL,
    [isdelete] bit  NULL,
    [clientType] int  NULL
);
GO

-- Creating table 'ip_company'
CREATE TABLE [dbo].[ip_company] (
    [id] int  NOT NULL,
    [company_name] varchar(250)  NOT NULL,
    [status] int  NOT NULL
);
GO

-- Creating table 'ip_company_profile'
CREATE TABLE [dbo].[ip_company_profile] (
    [Id] int  NOT NULL,
    [CompanyName] varchar(500)  NOT NULL,
    [CompanyAddress] varchar(1000)  NOT NULL,
    [CompanyPhoneNumber] varchar(20)  NOT NULL,
    [CompanyEmailId] varchar(100)  NOT NULL,
    [CompanyLogo] varchar(500)  NOT NULL,
    [CompanyTINNumber] varchar(100)  NOT NULL,
    [Template] varchar(500)  NOT NULL,
    [Status] int  NOT NULL,
    [SenderId] varchar(6)  NOT NULL,
    [Message] varchar(120)  NOT NULL,
    [CloseMessage] varchar(120)  NOT NULL,
    [Terms] varchar(5000)  NOT NULL,
    [Prefix] varchar(100)  NOT NULL
);
GO

-- Creating table 'ip_custom_fields'
CREATE TABLE [dbo].[ip_custom_fields] (
    [custom_field_id] int  NOT NULL,
    [custom_field_table] varchar(255)  NULL,
    [custom_field_label] varchar(max)  NULL,
    [custom_field_column] varchar(max)  NULL
);
GO

-- Creating table 'ip_estimate'
CREATE TABLE [dbo].[ip_estimate] (
    [quote_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [user_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [invoice_group_id] int  NOT NULL,
    [quote_status_id] smallint  NOT NULL,
    [quote_date_created] datetime  NOT NULL,
    [quote_date_modified] datetime  NOT NULL,
    [quote_date_expires] datetime  NOT NULL,
    [quote_number] varchar(100)  NULL,
    [quote_discount_amount] decimal(20,2)  NULL,
    [quote_discount_percent] decimal(20,2)  NULL,
    [quote_url_key] char(32)  NOT NULL,
    [quote_password] varchar(90)  NULL,
    [notes] varchar(max)  NULL
);
GO

-- Creating table 'ip_estimate_items'
CREATE TABLE [dbo].[ip_estimate_items] (
    [item_id] int  NOT NULL,
    [quote_id] int  NOT NULL,
    [item_tax_rate_id] int  NOT NULL,
    [item_product_id] int  NULL,
    [item_date_added] datetime  NOT NULL,
    [item_name] varchar(max)  NULL,
    [item_description] varchar(max)  NULL,
    [item_quantity] decimal(20,2)  NULL,
    [item_price] decimal(20,2)  NULL,
    [item_discount_amount] decimal(20,2)  NULL,
    [item_order] int  NOT NULL,
    [item_serial] varchar(200)  NULL,
    [clientname] varchar(450)  NULL,
    [clientnum] varchar(1000)  NULL
);
GO

-- Creating table 'ip_families'
CREATE TABLE [dbo].[ip_families] (
    [family_id] int IDENTITY(1,1) NOT NULL,
    [family_name] varchar(max)  NULL
);
GO

-- Creating table 'ip_import_details'
CREATE TABLE [dbo].[ip_import_details] (
    [import_detail_id] int  NOT NULL,
    [import_id] int  NOT NULL,
    [import_lang_key] varchar(35)  NOT NULL,
    [import_table_name] varchar(35)  NOT NULL,
    [import_record_id] int  NOT NULL
);
GO

-- Creating table 'ip_imports'
CREATE TABLE [dbo].[ip_imports] (
    [import_id] int  NOT NULL,
    [import_date] datetime  NOT NULL
);
GO

-- Creating table 'ip_invoice_amounts'
CREATE TABLE [dbo].[ip_invoice_amounts] (
    [invoice_amount_id] int IDENTITY(1,1) NOT NULL,
    [invoice_id] int  NOT NULL,
    [invoice_item_subtotal] decimal(20,2)  NULL,
    [invoice_item_tax_total] decimal(20,2)  NULL,
    [invoice_tax_total] decimal(20,2)  NULL,
    [invoice_total] decimal(20,2)  NULL,
    [invoice_paid] decimal(20,2)  NULL,
    [invoice_balance] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_invoice_custom'
CREATE TABLE [dbo].[ip_invoice_custom] (
    [invoice_custom_id] int IDENTITY(1,1) NOT NULL,
    [invoice_id] int  NOT NULL,
    [invoice_custom_delivery_note] varchar(2000)  NOT NULL,
    [invoice_custom_delivery_date] varchar(2000)  NOT NULL,
    [invoice_custom_order_no] varchar(2000)  NOT NULL,
    [invoice_custom_order_date] varchar(2000)  NOT NULL
);
GO

-- Creating table 'ip_invoice_groups'
CREATE TABLE [dbo].[ip_invoice_groups] (
    [invoice_group_id] int IDENTITY(1,1) NOT NULL,
    [invoice_group_name] varchar(max)  NULL,
    [invoice_group_identifier_format] varchar(255)  NOT NULL,
    [invoice_group_next_id] int  NOT NULL,
    [invoice_group_left_pad] int  NOT NULL
);
GO

-- Creating table 'ip_invoice_item_amounts'
CREATE TABLE [dbo].[ip_invoice_item_amounts] (
    [item_amount_id] int  NOT NULL,
    [item_id] int  NOT NULL,
    [item_subtotal] decimal(20,2)  NULL,
    [item_tax_total] decimal(20,2)  NULL,
    [item_discount] decimal(20,2)  NULL,
    [item_total] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_invoice_items'
CREATE TABLE [dbo].[ip_invoice_items] (
    [item_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [item_tax_rate_id] int  NOT NULL,
    [item_product_id] int  NULL,
    [item_date_added] datetime  NOT NULL,
    [item_name] varchar(max)  NULL,
    [item_description] varchar(max)  NULL,
    [item_quantity] decimal(10,2)  NOT NULL,
    [item_price] decimal(20,2)  NULL,
    [item_discount_amount] decimal(20,2)  NULL,
    [item_order] int  NOT NULL,
    [item_serial] varchar(100)  NULL
);
GO

-- Creating table 'ip_invoice_tax_rates'
CREATE TABLE [dbo].[ip_invoice_tax_rates] (
    [invoice_tax_rate_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [tax_rate_id] int  NOT NULL,
    [include_item_tax] int  NOT NULL,
    [invoice_tax_rate_amount] decimal(10,2)  NOT NULL
);
GO

-- Creating table 'ip_invoices'
CREATE TABLE [dbo].[ip_invoices] (
    [invoice_id] int IDENTITY(1,1) NOT NULL,
    [user_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [invoice_group_id] int  NOT NULL,
    [invoice_status_id] smallint  NOT NULL,
    [is_read_only] smallint  NULL,
    [invoice_password] varchar(90)  NULL,
    [invoice_date_created] datetime  NOT NULL,
    [invoice_time_created] time  NOT NULL,
    [invoice_date_modified] datetime  NOT NULL,
    [invoice_date_due] datetime  NOT NULL,
    [invoice_number] varchar(100)  NULL,
    [invoice_discount_amount] decimal(20,2)  NULL,
    [invoice_discount_percent] decimal(20,2)  NULL,
    [invoice_terms] varchar(max)  NOT NULL,
    [invoice_url_key] char(32)  NOT NULL,
    [payment_method] int  NOT NULL,
    [creditinvoice_parent_id] int  NULL
);
GO

-- Creating table 'ip_invoices_recurring'
CREATE TABLE [dbo].[ip_invoices_recurring] (
    [invoice_recurring_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [recur_start_date] datetime  NOT NULL,
    [recur_end_date] datetime  NOT NULL,
    [recur_frequency] char(2)  NOT NULL,
    [recur_next_date] datetime  NOT NULL
);
GO

-- Creating table 'ip_job_portal'
CREATE TABLE [dbo].[ip_job_portal] (
    [id] int  NOT NULL,
    [customer_name] varchar(500)  NOT NULL,
    [customer_mobile] varchar(500)  NOT NULL,
    [customer_address] varchar(500)  NOT NULL,
    [company] varchar(100)  NOT NULL,
    [job_number] varchar(100)  NOT NULL,
    [date] datetime  NOT NULL,
    [make] varchar(100)  NOT NULL,
    [model] varchar(100)  NOT NULL,
    [sl_no] varchar(100)  NOT NULL,
    [gurantee] varchar(100)  NOT NULL,
    [paidamount] decimal(10,0)  NOT NULL,
    [problem] varchar(100)  NOT NULL,
    [remarks] varchar(100)  NOT NULL,
    [terms_conditions] varchar(100)  NOT NULL,
    [status] int  NOT NULL
);
GO

-- Creating table 'ip_make'
CREATE TABLE [dbo].[ip_make] (
    [id] int  NOT NULL,
    [make_name] varchar(255)  NOT NULL,
    [status] int  NOT NULL
);
GO

-- Creating table 'ip_merchant_responses'
CREATE TABLE [dbo].[ip_merchant_responses] (
    [merchant_response_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [merchant_response_date] datetime  NOT NULL,
    [merchant_response_driver] varchar(35)  NOT NULL,
    [merchant_response] varchar(255)  NOT NULL,
    [merchant_response_reference] varchar(255)  NOT NULL
);
GO

-- Creating table 'ip_model'
CREATE TABLE [dbo].[ip_model] (
    [id] int  NOT NULL,
    [modee_name] varchar(255)  NOT NULL,
    [status] int  NOT NULL
);
GO

-- Creating table 'ip_payment_custom'
CREATE TABLE [dbo].[ip_payment_custom] (
    [payment_custom_id] int  NOT NULL,
    [payment_id] int  NOT NULL
);
GO

-- Creating table 'ip_payment_methods'
CREATE TABLE [dbo].[ip_payment_methods] (
    [payment_method_id] int  NOT NULL,
    [payment_method_name] varchar(max)  NULL
);
GO

-- Creating table 'ip_payments'
CREATE TABLE [dbo].[ip_payments] (
    [payment_id] int IDENTITY(1,1) NOT NULL,
    [quote_id] int  NOT NULL,
    [payment_method_id] int  NOT NULL,
    [payment_date] datetime  NOT NULL,
    [payment_amount] decimal(20,2)  NULL,
    [payment_note] varchar(max)  NOT NULL
);
GO

-- Creating table 'ip_products'
CREATE TABLE [dbo].[ip_products] (
    [product_id] int IDENTITY(1,1) NOT NULL,
    [family_id] int  NULL,
    [product_sku] varchar(max)  NULL,
    [product_name] varchar(max)  NULL,
    [product_description] varchar(max)  NOT NULL,
    [product_price] decimal(20,2)  NULL,
    [purchase_price] decimal(20,2)  NULL,
    [provider_name] varchar(max)  NULL,
    [tax_rate_id] int  NULL,
    [quantity] int  NULL,
    [sub_cate] varchar(500)  NULL,
    [serial_number] varchar(100)  NULL,
    [supp_name] varchar(500)  NULL,
    [warenty_detail] varchar(500)  NULL,
    [selling_price] varchar(450)  NULL,
    [other_info] varchar(450)  NULL,
    [purchase_org_price] varchar(450)  NULL,
    [isdelete] bit  NULL
);
GO

-- Creating table 'ip_projects'
CREATE TABLE [dbo].[ip_projects] (
    [project_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [project_name] varchar(max)  NULL
);
GO

-- Creating table 'ip_purchase'
CREATE TABLE [dbo].[ip_purchase] (
    [quote_id] int  NOT NULL,
    [invoice_id] int  NOT NULL,
    [user_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [invoice_group_id] int  NOT NULL,
    [quote_status_id] smallint  NOT NULL,
    [quote_date_created] datetime  NOT NULL,
    [quote_date_modified] datetime  NOT NULL,
    [quote_date_expires] datetime  NOT NULL,
    [quote_number] varchar(100)  NULL,
    [quote_discount_amount] decimal(20,2)  NULL,
    [quote_discount_percent] decimal(20,2)  NULL,
    [quote_url_key] char(32)  NOT NULL,
    [quote_password] varchar(90)  NULL,
    [notes] varchar(max)  NULL
);
GO

-- Creating table 'ip_purchase_amounts'
CREATE TABLE [dbo].[ip_purchase_amounts] (
    [quote_amount_id] int  NOT NULL,
    [quote_id] int  NOT NULL,
    [quote_item_subtotal] decimal(20,2)  NULL,
    [quote_item_tax_total] decimal(20,2)  NULL,
    [quote_tax_total] decimal(20,2)  NULL,
    [quote_total] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_purchase_custom'
CREATE TABLE [dbo].[ip_purchase_custom] (
    [quote_custom_id] int  NOT NULL,
    [quote_id] int  NOT NULL
);
GO

-- Creating table 'ip_purchase_item_amounts'
CREATE TABLE [dbo].[ip_purchase_item_amounts] (
    [item_amount_id] int  NOT NULL,
    [item_id] int  NOT NULL,
    [item_subtotal] decimal(20,2)  NULL,
    [item_tax_total] decimal(20,2)  NULL,
    [item_discount] decimal(20,2)  NULL,
    [item_total] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_purchase_items'
CREATE TABLE [dbo].[ip_purchase_items] (
    [item_id] int  NOT NULL,
    [quote_id] int  NOT NULL,
    [item_tax_rate_id] int  NOT NULL,
    [item_product_id] int  NULL,
    [item_date_added] datetime  NOT NULL,
    [item_name] varchar(max)  NULL,
    [item_description] varchar(max)  NULL,
    [item_quantity] decimal(20,2)  NULL,
    [item_price] decimal(20,2)  NULL,
    [item_discount_amount] decimal(20,2)  NULL,
    [item_order] int  NOT NULL,
    [item_serial] varchar(200)  NULL
);
GO

-- Creating table 'ip_purchase_tax_rates'
CREATE TABLE [dbo].[ip_purchase_tax_rates] (
    [quote_tax_rate_id] int  NOT NULL,
    [quote_id] int  NOT NULL,
    [tax_rate_id] int  NOT NULL,
    [include_item_tax] int  NOT NULL,
    [quote_tax_rate_amount] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_quote_amounts'
CREATE TABLE [dbo].[ip_quote_amounts] (
    [quote_amount_id] int IDENTITY(1,1) NOT NULL,
    [quote_id] int  NOT NULL,
    [quote_item_subtotal] decimal(20,2)  NULL,
    [quote_discount] decimal(20,2)  NULL,
    [quote_tax_total] decimal(20,2)  NULL,
    [quote_total] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_quote_custom'
CREATE TABLE [dbo].[ip_quote_custom] (
    [quote_custom_id] int  NOT NULL,
    [quote_id] int  NOT NULL
);
GO

-- Creating table 'ip_quote_item_amounts'
CREATE TABLE [dbo].[ip_quote_item_amounts] (
    [item_amount_id] int  NOT NULL,
    [item_id] int  NOT NULL,
    [item_subtotal] decimal(20,2)  NULL,
    [item_tax_total] decimal(20,2)  NULL,
    [item_discount] decimal(20,2)  NULL,
    [item_total] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_quote_items'
CREATE TABLE [dbo].[ip_quote_items] (
    [item_id] int IDENTITY(1,1) NOT NULL,
    [quote_id] int  NOT NULL,
    [item_product_id] int  NULL,
    [item_date_added] datetime  NOT NULL,
    [item_name] varchar(max)  NULL,
    [item_description] varchar(max)  NULL,
    [item_quantity] decimal(20,2)  NULL,
    [item_price] decimal(20,2)  NULL,
    [item_discount_amount] decimal(20,2)  NULL,
    [item_order] int  NOT NULL,
    [item_serial] varchar(200)  NULL
);
GO

-- Creating table 'ip_quote_tax_rates'
CREATE TABLE [dbo].[ip_quote_tax_rates] (
    [quote_tax_rate_id] int IDENTITY(1,1) NOT NULL,
    [quote_id] int  NOT NULL,
    [tax_rate_id] int  NOT NULL,
    [include_item_tax] int  NOT NULL,
    [quote_tax_rate_amount] decimal(20,2)  NULL
);
GO

-- Creating table 'ip_quotes'
CREATE TABLE [dbo].[ip_quotes] (
    [quote_id] int IDENTITY(1,1) NOT NULL,
    [user_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [invoice_group_id] int  NOT NULL,
    [quote_status_id] smallint  NOT NULL,
    [quote_date_created] datetime  NOT NULL,
    [quote_date_modified] datetime  NOT NULL,
    [quote_date_expires] datetime  NOT NULL,
    [quote_number] varchar(100)  NULL,
    [quote_discount_amount] decimal(20,2)  NULL,
    [quote_discount_percent] decimal(20,2)  NULL,
    [quote_url_key] char(32)  NOT NULL,
    [quote_password] varchar(90)  NULL,
    [notes] varchar(max)  NULL,
    [ip_quote_custom] int  NOT NULL,
    [is_quote] bit  NULL,
    [payment_method] int  NULL,
    [delivery_notes] varchar(50)  NULL,
    [delivery_date] datetime  NULL,
    [payment_notes] varchar(50)  NULL,
    [ispayment_completed] bit  NULL,
    [is_quote_delete] bit  NULL,
    [ispurchase] bit  NULL,
    [taxType] int  NULL,
    [type] int  NULL
);
GO

-- Creating table 'ip_Spares'
CREATE TABLE [dbo].[ip_Spares] (
    [id] int  NOT NULL,
    [JobId] varchar(255)  NOT NULL,
    [Spares_name] varchar(255)  NOT NULL,
    [status] int  NOT NULL,
    [Amount] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'ip_tax_rates'
CREATE TABLE [dbo].[ip_tax_rates] (
    [tax_rate_id] int IDENTITY(1,1) NOT NULL,
    [tax_rate_name] varchar(max)  NULL,
    [tax_rate_percent] decimal(5,2)  NOT NULL
);
GO

-- Creating table 'ip_user_clients'
CREATE TABLE [dbo].[ip_user_clients] (
    [user_client_id] int  NOT NULL,
    [user_id] int  NOT NULL,
    [client_id] int  NOT NULL
);
GO

-- Creating table 'ip_user_custom'
CREATE TABLE [dbo].[ip_user_custom] (
    [user_custom_id] int  NOT NULL,
    [user_id] int  NOT NULL,
    [user_custom_bank_name] varchar(2000)  NOT NULL,
    [user_custom_account_number] varchar(2000)  NOT NULL,
    [user_custom_ifsc_code] varchar(2000)  NOT NULL,
    [user_custom_branch] varchar(2000)  NOT NULL
);
GO

-- Creating table 'ip_users'
CREATE TABLE [dbo].[ip_users] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [user_type] int  NOT NULL,
    [user_active] smallint  NULL,
    [user_date_created] datetime  NOT NULL,
    [user_date_modified] datetime  NOT NULL,
    [user_name] varchar(max)  NULL,
    [user_company] varchar(max)  NULL,
    [user_address_1] varchar(max)  NULL,
    [user_address_2] varchar(max)  NULL,
    [user_city] varchar(max)  NULL,
    [user_state] varchar(max)  NULL,
    [user_zip] varchar(max)  NULL,
    [user_country] varchar(max)  NULL,
    [user_phone] varchar(max)  NULL,
    [user_fax] varchar(max)  NULL,
    [user_mobile] varchar(max)  NULL,
    [user_email] varchar(max)  NULL,
    [user_password] varchar(60)  NOT NULL,
    [user_web] varchar(max)  NULL,
    [user_vat_id] varchar(max)  NULL,
    [user_tax_code] varchar(max)  NULL,
    [user_psalt] varchar(max)  NULL,
    [user_passwordreset_token] varchar(100)  NULL
);
GO

-- Creating table 'ip_versions'
CREATE TABLE [dbo].[ip_versions] (
    [version_id] int  NOT NULL,
    [version_date_applied] varchar(14)  NOT NULL,
    [version_file] varchar(45)  NOT NULL,
    [version_sql_errors] int  NOT NULL
);
GO

-- Creating table 'ip_email_templates'
CREATE TABLE [dbo].[ip_email_templates] (
    [email_template_id] int  NOT NULL,
    [email_template_title] varchar(max)  NULL,
    [email_template_type] varchar(255)  NULL,
    [email_template_body] varchar(max)  NOT NULL,
    [email_template_subject] varchar(max)  NULL,
    [email_template_from_name] varchar(max)  NULL,
    [email_template_from_email] varchar(max)  NULL,
    [email_template_cc] varchar(max)  NULL,
    [email_template_bcc] varchar(max)  NULL,
    [email_template_pdf_template] varchar(255)  NULL
);
GO

-- Creating table 'ip_item_lookups'
CREATE TABLE [dbo].[ip_item_lookups] (
    [item_lookup_id] int  NOT NULL,
    [item_name] varchar(100)  NOT NULL,
    [item_description] varchar(max)  NOT NULL,
    [item_price] decimal(10,2)  NOT NULL
);
GO

-- Creating table 'ip_sessions'
CREATE TABLE [dbo].[ip_sessions] (
    [session_id] varchar(40)  NOT NULL,
    [ip_address] varchar(45)  NOT NULL,
    [user_agent] varchar(120)  NOT NULL,
    [last_activity] int  NOT NULL,
    [user_data] varchar(max)  NOT NULL
);
GO

-- Creating table 'ip_settings'
CREATE TABLE [dbo].[ip_settings] (
    [setting_id] int  NOT NULL,
    [setting_key] varchar(50)  NOT NULL,
    [setting_value] varchar(max)  NOT NULL
);
GO

-- Creating table 'ip_tasks'
CREATE TABLE [dbo].[ip_tasks] (
    [task_id] int  NOT NULL,
    [project_id] varchar(max)  NOT NULL,
    [task_name] varchar(max)  NULL,
    [task_description] varchar(max)  NOT NULL,
    [task_price] varchar(500)  NULL,
    [task_finish_date] varchar(500)  NOT NULL,
    [task_status] varchar(500)  NOT NULL
);
GO

-- Creating table 'ip_uploads'
CREATE TABLE [dbo].[ip_uploads] (
    [upload_id] int  NOT NULL,
    [client_id] int  NOT NULL,
    [url_key] char(32)  NOT NULL,
    [file_name_original] varchar(max)  NOT NULL,
    [file_name_new] varchar(max)  NOT NULL,
    [uploaded_date] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [client_custom_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [PK_ip_client_custom]
    PRIMARY KEY CLUSTERED ([client_custom_id] ASC);
GO

-- Creating primary key on [client_note_id] in table 'ip_client_notes'
ALTER TABLE [dbo].[ip_client_notes]
ADD CONSTRAINT [PK_ip_client_notes]
    PRIMARY KEY CLUSTERED ([client_note_id] ASC);
GO

-- Creating primary key on [client_id] in table 'ip_clients'
ALTER TABLE [dbo].[ip_clients]
ADD CONSTRAINT [PK_ip_clients]
    PRIMARY KEY CLUSTERED ([client_id] ASC);
GO

-- Creating primary key on [id], [company_name], [status] in table 'ip_company'
ALTER TABLE [dbo].[ip_company]
ADD CONSTRAINT [PK_ip_company]
    PRIMARY KEY CLUSTERED ([id], [company_name], [status] ASC);
GO

-- Creating primary key on [Id], [CompanyName], [CompanyAddress], [CompanyPhoneNumber], [CompanyEmailId], [CompanyLogo], [CompanyTINNumber], [Template], [Status], [SenderId], [Message], [CloseMessage], [Terms], [Prefix] in table 'ip_company_profile'
ALTER TABLE [dbo].[ip_company_profile]
ADD CONSTRAINT [PK_ip_company_profile]
    PRIMARY KEY CLUSTERED ([Id], [CompanyName], [CompanyAddress], [CompanyPhoneNumber], [CompanyEmailId], [CompanyLogo], [CompanyTINNumber], [Template], [Status], [SenderId], [Message], [CloseMessage], [Terms], [Prefix] ASC);
GO

-- Creating primary key on [custom_field_id] in table 'ip_custom_fields'
ALTER TABLE [dbo].[ip_custom_fields]
ADD CONSTRAINT [PK_ip_custom_fields]
    PRIMARY KEY CLUSTERED ([custom_field_id] ASC);
GO

-- Creating primary key on [quote_id], [invoice_id], [user_id], [client_id], [invoice_group_id], [quote_status_id], [quote_date_created], [quote_date_modified], [quote_date_expires], [quote_url_key] in table 'ip_estimate'
ALTER TABLE [dbo].[ip_estimate]
ADD CONSTRAINT [PK_ip_estimate]
    PRIMARY KEY CLUSTERED ([quote_id], [invoice_id], [user_id], [client_id], [invoice_group_id], [quote_status_id], [quote_date_created], [quote_date_modified], [quote_date_expires], [quote_url_key] ASC);
GO

-- Creating primary key on [item_id], [quote_id], [item_tax_rate_id], [item_date_added], [item_order] in table 'ip_estimate_items'
ALTER TABLE [dbo].[ip_estimate_items]
ADD CONSTRAINT [PK_ip_estimate_items]
    PRIMARY KEY CLUSTERED ([item_id], [quote_id], [item_tax_rate_id], [item_date_added], [item_order] ASC);
GO

-- Creating primary key on [family_id] in table 'ip_families'
ALTER TABLE [dbo].[ip_families]
ADD CONSTRAINT [PK_ip_families]
    PRIMARY KEY CLUSTERED ([family_id] ASC);
GO

-- Creating primary key on [import_detail_id], [import_id], [import_lang_key], [import_table_name], [import_record_id] in table 'ip_import_details'
ALTER TABLE [dbo].[ip_import_details]
ADD CONSTRAINT [PK_ip_import_details]
    PRIMARY KEY CLUSTERED ([import_detail_id], [import_id], [import_lang_key], [import_table_name], [import_record_id] ASC);
GO

-- Creating primary key on [import_id], [import_date] in table 'ip_imports'
ALTER TABLE [dbo].[ip_imports]
ADD CONSTRAINT [PK_ip_imports]
    PRIMARY KEY CLUSTERED ([import_id], [import_date] ASC);
GO

-- Creating primary key on [invoice_amount_id] in table 'ip_invoice_amounts'
ALTER TABLE [dbo].[ip_invoice_amounts]
ADD CONSTRAINT [PK_ip_invoice_amounts]
    PRIMARY KEY CLUSTERED ([invoice_amount_id] ASC);
GO

-- Creating primary key on [invoice_custom_id] in table 'ip_invoice_custom'
ALTER TABLE [dbo].[ip_invoice_custom]
ADD CONSTRAINT [PK_ip_invoice_custom]
    PRIMARY KEY CLUSTERED ([invoice_custom_id] ASC);
GO

-- Creating primary key on [invoice_group_id] in table 'ip_invoice_groups'
ALTER TABLE [dbo].[ip_invoice_groups]
ADD CONSTRAINT [PK_ip_invoice_groups]
    PRIMARY KEY CLUSTERED ([invoice_group_id] ASC);
GO

-- Creating primary key on [item_amount_id], [item_id] in table 'ip_invoice_item_amounts'
ALTER TABLE [dbo].[ip_invoice_item_amounts]
ADD CONSTRAINT [PK_ip_invoice_item_amounts]
    PRIMARY KEY CLUSTERED ([item_amount_id], [item_id] ASC);
GO

-- Creating primary key on [item_id], [invoice_id], [item_tax_rate_id], [item_date_added], [item_quantity], [item_order] in table 'ip_invoice_items'
ALTER TABLE [dbo].[ip_invoice_items]
ADD CONSTRAINT [PK_ip_invoice_items]
    PRIMARY KEY CLUSTERED ([item_id], [invoice_id], [item_tax_rate_id], [item_date_added], [item_quantity], [item_order] ASC);
GO

-- Creating primary key on [invoice_tax_rate_id], [invoice_id], [tax_rate_id], [include_item_tax], [invoice_tax_rate_amount] in table 'ip_invoice_tax_rates'
ALTER TABLE [dbo].[ip_invoice_tax_rates]
ADD CONSTRAINT [PK_ip_invoice_tax_rates]
    PRIMARY KEY CLUSTERED ([invoice_tax_rate_id], [invoice_id], [tax_rate_id], [include_item_tax], [invoice_tax_rate_amount] ASC);
GO

-- Creating primary key on [invoice_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [PK_ip_invoices]
    PRIMARY KEY CLUSTERED ([invoice_id] ASC);
GO

-- Creating primary key on [invoice_recurring_id], [invoice_id], [recur_start_date], [recur_end_date], [recur_frequency], [recur_next_date] in table 'ip_invoices_recurring'
ALTER TABLE [dbo].[ip_invoices_recurring]
ADD CONSTRAINT [PK_ip_invoices_recurring]
    PRIMARY KEY CLUSTERED ([invoice_recurring_id], [invoice_id], [recur_start_date], [recur_end_date], [recur_frequency], [recur_next_date] ASC);
GO

-- Creating primary key on [id], [customer_name], [customer_mobile], [customer_address], [company], [job_number], [date], [make], [model], [sl_no], [gurantee], [paidamount], [problem], [remarks], [terms_conditions], [status] in table 'ip_job_portal'
ALTER TABLE [dbo].[ip_job_portal]
ADD CONSTRAINT [PK_ip_job_portal]
    PRIMARY KEY CLUSTERED ([id], [customer_name], [customer_mobile], [customer_address], [company], [job_number], [date], [make], [model], [sl_no], [gurantee], [paidamount], [problem], [remarks], [terms_conditions], [status] ASC);
GO

-- Creating primary key on [id], [make_name], [status] in table 'ip_make'
ALTER TABLE [dbo].[ip_make]
ADD CONSTRAINT [PK_ip_make]
    PRIMARY KEY CLUSTERED ([id], [make_name], [status] ASC);
GO

-- Creating primary key on [merchant_response_id], [invoice_id], [merchant_response_date], [merchant_response_driver], [merchant_response], [merchant_response_reference] in table 'ip_merchant_responses'
ALTER TABLE [dbo].[ip_merchant_responses]
ADD CONSTRAINT [PK_ip_merchant_responses]
    PRIMARY KEY CLUSTERED ([merchant_response_id], [invoice_id], [merchant_response_date], [merchant_response_driver], [merchant_response], [merchant_response_reference] ASC);
GO

-- Creating primary key on [id], [modee_name], [status] in table 'ip_model'
ALTER TABLE [dbo].[ip_model]
ADD CONSTRAINT [PK_ip_model]
    PRIMARY KEY CLUSTERED ([id], [modee_name], [status] ASC);
GO

-- Creating primary key on [payment_custom_id], [payment_id] in table 'ip_payment_custom'
ALTER TABLE [dbo].[ip_payment_custom]
ADD CONSTRAINT [PK_ip_payment_custom]
    PRIMARY KEY CLUSTERED ([payment_custom_id], [payment_id] ASC);
GO

-- Creating primary key on [payment_method_id] in table 'ip_payment_methods'
ALTER TABLE [dbo].[ip_payment_methods]
ADD CONSTRAINT [PK_ip_payment_methods]
    PRIMARY KEY CLUSTERED ([payment_method_id] ASC);
GO

-- Creating primary key on [payment_id] in table 'ip_payments'
ALTER TABLE [dbo].[ip_payments]
ADD CONSTRAINT [PK_ip_payments]
    PRIMARY KEY CLUSTERED ([payment_id] ASC);
GO

-- Creating primary key on [product_id] in table 'ip_products'
ALTER TABLE [dbo].[ip_products]
ADD CONSTRAINT [PK_ip_products]
    PRIMARY KEY CLUSTERED ([product_id] ASC);
GO

-- Creating primary key on [project_id], [client_id] in table 'ip_projects'
ALTER TABLE [dbo].[ip_projects]
ADD CONSTRAINT [PK_ip_projects]
    PRIMARY KEY CLUSTERED ([project_id], [client_id] ASC);
GO

-- Creating primary key on [quote_id], [invoice_id], [user_id], [client_id], [invoice_group_id], [quote_status_id], [quote_date_created], [quote_date_modified], [quote_date_expires], [quote_url_key] in table 'ip_purchase'
ALTER TABLE [dbo].[ip_purchase]
ADD CONSTRAINT [PK_ip_purchase]
    PRIMARY KEY CLUSTERED ([quote_id], [invoice_id], [user_id], [client_id], [invoice_group_id], [quote_status_id], [quote_date_created], [quote_date_modified], [quote_date_expires], [quote_url_key] ASC);
GO

-- Creating primary key on [quote_amount_id], [quote_id] in table 'ip_purchase_amounts'
ALTER TABLE [dbo].[ip_purchase_amounts]
ADD CONSTRAINT [PK_ip_purchase_amounts]
    PRIMARY KEY CLUSTERED ([quote_amount_id], [quote_id] ASC);
GO

-- Creating primary key on [quote_custom_id], [quote_id] in table 'ip_purchase_custom'
ALTER TABLE [dbo].[ip_purchase_custom]
ADD CONSTRAINT [PK_ip_purchase_custom]
    PRIMARY KEY CLUSTERED ([quote_custom_id], [quote_id] ASC);
GO

-- Creating primary key on [item_amount_id], [item_id] in table 'ip_purchase_item_amounts'
ALTER TABLE [dbo].[ip_purchase_item_amounts]
ADD CONSTRAINT [PK_ip_purchase_item_amounts]
    PRIMARY KEY CLUSTERED ([item_amount_id], [item_id] ASC);
GO

-- Creating primary key on [item_id], [quote_id], [item_tax_rate_id], [item_date_added], [item_order] in table 'ip_purchase_items'
ALTER TABLE [dbo].[ip_purchase_items]
ADD CONSTRAINT [PK_ip_purchase_items]
    PRIMARY KEY CLUSTERED ([item_id], [quote_id], [item_tax_rate_id], [item_date_added], [item_order] ASC);
GO

-- Creating primary key on [quote_tax_rate_id], [quote_id], [tax_rate_id], [include_item_tax] in table 'ip_purchase_tax_rates'
ALTER TABLE [dbo].[ip_purchase_tax_rates]
ADD CONSTRAINT [PK_ip_purchase_tax_rates]
    PRIMARY KEY CLUSTERED ([quote_tax_rate_id], [quote_id], [tax_rate_id], [include_item_tax] ASC);
GO

-- Creating primary key on [quote_amount_id] in table 'ip_quote_amounts'
ALTER TABLE [dbo].[ip_quote_amounts]
ADD CONSTRAINT [PK_ip_quote_amounts]
    PRIMARY KEY CLUSTERED ([quote_amount_id] ASC);
GO

-- Creating primary key on [quote_custom_id], [quote_id] in table 'ip_quote_custom'
ALTER TABLE [dbo].[ip_quote_custom]
ADD CONSTRAINT [PK_ip_quote_custom]
    PRIMARY KEY CLUSTERED ([quote_custom_id], [quote_id] ASC);
GO

-- Creating primary key on [item_amount_id], [item_id] in table 'ip_quote_item_amounts'
ALTER TABLE [dbo].[ip_quote_item_amounts]
ADD CONSTRAINT [PK_ip_quote_item_amounts]
    PRIMARY KEY CLUSTERED ([item_amount_id], [item_id] ASC);
GO

-- Creating primary key on [item_id] in table 'ip_quote_items'
ALTER TABLE [dbo].[ip_quote_items]
ADD CONSTRAINT [PK_ip_quote_items]
    PRIMARY KEY CLUSTERED ([item_id] ASC);
GO

-- Creating primary key on [quote_tax_rate_id] in table 'ip_quote_tax_rates'
ALTER TABLE [dbo].[ip_quote_tax_rates]
ADD CONSTRAINT [PK_ip_quote_tax_rates]
    PRIMARY KEY CLUSTERED ([quote_tax_rate_id] ASC);
GO

-- Creating primary key on [quote_id] in table 'ip_quotes'
ALTER TABLE [dbo].[ip_quotes]
ADD CONSTRAINT [PK_ip_quotes]
    PRIMARY KEY CLUSTERED ([quote_id] ASC);
GO

-- Creating primary key on [id], [JobId], [Spares_name], [status], [Amount] in table 'ip_Spares'
ALTER TABLE [dbo].[ip_Spares]
ADD CONSTRAINT [PK_ip_Spares]
    PRIMARY KEY CLUSTERED ([id], [JobId], [Spares_name], [status], [Amount] ASC);
GO

-- Creating primary key on [tax_rate_id] in table 'ip_tax_rates'
ALTER TABLE [dbo].[ip_tax_rates]
ADD CONSTRAINT [PK_ip_tax_rates]
    PRIMARY KEY CLUSTERED ([tax_rate_id] ASC);
GO

-- Creating primary key on [user_client_id], [user_id], [client_id] in table 'ip_user_clients'
ALTER TABLE [dbo].[ip_user_clients]
ADD CONSTRAINT [PK_ip_user_clients]
    PRIMARY KEY CLUSTERED ([user_client_id], [user_id], [client_id] ASC);
GO

-- Creating primary key on [user_custom_id], [user_id], [user_custom_bank_name], [user_custom_account_number], [user_custom_ifsc_code], [user_custom_branch] in table 'ip_user_custom'
ALTER TABLE [dbo].[ip_user_custom]
ADD CONSTRAINT [PK_ip_user_custom]
    PRIMARY KEY CLUSTERED ([user_custom_id], [user_id], [user_custom_bank_name], [user_custom_account_number], [user_custom_ifsc_code], [user_custom_branch] ASC);
GO

-- Creating primary key on [user_id] in table 'ip_users'
ALTER TABLE [dbo].[ip_users]
ADD CONSTRAINT [PK_ip_users]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

-- Creating primary key on [version_id], [version_date_applied], [version_file], [version_sql_errors] in table 'ip_versions'
ALTER TABLE [dbo].[ip_versions]
ADD CONSTRAINT [PK_ip_versions]
    PRIMARY KEY CLUSTERED ([version_id], [version_date_applied], [version_file], [version_sql_errors] ASC);
GO

-- Creating primary key on [email_template_id], [email_template_body] in table 'ip_email_templates'
ALTER TABLE [dbo].[ip_email_templates]
ADD CONSTRAINT [PK_ip_email_templates]
    PRIMARY KEY CLUSTERED ([email_template_id], [email_template_body] ASC);
GO

-- Creating primary key on [item_lookup_id], [item_name], [item_description], [item_price] in table 'ip_item_lookups'
ALTER TABLE [dbo].[ip_item_lookups]
ADD CONSTRAINT [PK_ip_item_lookups]
    PRIMARY KEY CLUSTERED ([item_lookup_id], [item_name], [item_description], [item_price] ASC);
GO

-- Creating primary key on [session_id], [ip_address], [user_agent], [last_activity], [user_data] in table 'ip_sessions'
ALTER TABLE [dbo].[ip_sessions]
ADD CONSTRAINT [PK_ip_sessions]
    PRIMARY KEY CLUSTERED ([session_id], [ip_address], [user_agent], [last_activity], [user_data] ASC);
GO

-- Creating primary key on [setting_id], [setting_key], [setting_value] in table 'ip_settings'
ALTER TABLE [dbo].[ip_settings]
ADD CONSTRAINT [PK_ip_settings]
    PRIMARY KEY CLUSTERED ([setting_id], [setting_key], [setting_value] ASC);
GO

-- Creating primary key on [task_id], [project_id], [task_description], [task_finish_date], [task_status] in table 'ip_tasks'
ALTER TABLE [dbo].[ip_tasks]
ADD CONSTRAINT [PK_ip_tasks]
    PRIMARY KEY CLUSTERED ([task_id], [project_id], [task_description], [task_finish_date], [task_status] ASC);
GO

-- Creating primary key on [upload_id], [client_id], [url_key], [file_name_original], [file_name_new], [uploaded_date] in table 'ip_uploads'
ALTER TABLE [dbo].[ip_uploads]
ADD CONSTRAINT [PK_ip_uploads]
    PRIMARY KEY CLUSTERED ([upload_id], [client_id], [url_key], [file_name_original], [file_name_new], [uploaded_date] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__060DEAE8]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__060DEAE8'
CREATE INDEX [IX_FK__ip_client__clien__060DEAE8]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__5D95E53A]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__5D95E53A'
CREATE INDEX [IX_FK__ip_client__clien__5D95E53A]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__5E8A0973]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__5E8A0973'
CREATE INDEX [IX_FK__ip_client__clien__5E8A0973]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__5F7E2DAC]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__5F7E2DAC'
CREATE INDEX [IX_FK__ip_client__clien__5F7E2DAC]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__607251E5]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__607251E5'
CREATE INDEX [IX_FK__ip_client__clien__607251E5]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__6166761E]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__6166761E'
CREATE INDEX [IX_FK__ip_client__clien__6166761E]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__625A9A57]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__625A9A57'
CREATE INDEX [IX_FK__ip_client__clien__625A9A57]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__634EBE90]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__634EBE90'
CREATE INDEX [IX_FK__ip_client__clien__634EBE90]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_custom'
ALTER TABLE [dbo].[ip_client_custom]
ADD CONSTRAINT [FK__ip_client__clien__6442E2C9]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__6442E2C9'
CREATE INDEX [IX_FK__ip_client__clien__6442E2C9]
ON [dbo].[ip_client_custom]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_notes'
ALTER TABLE [dbo].[ip_client_notes]
ADD CONSTRAINT [FK__ip_client__clien__0AD2A005]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__0AD2A005'
CREATE INDEX [IX_FK__ip_client__clien__0AD2A005]
ON [dbo].[ip_client_notes]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_client_notes'
ALTER TABLE [dbo].[ip_client_notes]
ADD CONSTRAINT [FK__ip_client__clien__5BAD9CC8]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_client__clien__5BAD9CC8'
CREATE INDEX [IX_FK__ip_client__clien__5BAD9CC8]
ON [dbo].[ip_client_notes]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__clien__31B762FC]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__clien__31B762FC'
CREATE INDEX [IX_FK__ip_invoic__clien__31B762FC]
ON [dbo].[ip_invoices]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__clien__32E0915F]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__clien__32E0915F'
CREATE INDEX [IX_FK__ip_invoic__clien__32E0915F]
ON [dbo].[ip_invoices]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__clien__5DCAEF64]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__clien__5DCAEF64'
CREATE INDEX [IX_FK__ip_invoic__clien__5DCAEF64]
ON [dbo].[ip_invoices]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__clien__5FB337D6]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__clien__5FB337D6'
CREATE INDEX [IX_FK__ip_invoic__clien__5FB337D6]
ON [dbo].[ip_invoices]
    ([client_id]);
GO

-- Creating foreign key on [client_id] in table 'ip_quotes'
ALTER TABLE [dbo].[ip_quotes]
ADD CONSTRAINT [FK_ip_quotes_ip_clients]
    FOREIGN KEY ([client_id])
    REFERENCES [dbo].[ip_clients]
        ([client_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quotes_ip_clients'
CREATE INDEX [IX_FK_ip_quotes_ip_clients]
ON [dbo].[ip_quotes]
    ([client_id]);
GO

-- Creating foreign key on [family_id] in table 'ip_products'
ALTER TABLE [dbo].[ip_products]
ADD CONSTRAINT [FK_ip_products_ip_families]
    FOREIGN KEY ([family_id])
    REFERENCES [dbo].[ip_families]
        ([family_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_products_ip_families'
CREATE INDEX [IX_FK_ip_products_ip_families]
ON [dbo].[ip_products]
    ([family_id]);
GO

-- Creating foreign key on [invoice_id] in table 'ip_invoice_amounts'
ALTER TABLE [dbo].[ip_invoice_amounts]
ADD CONSTRAINT [FK__ip_invoic__invoi__43D61337]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[ip_invoices]
        ([invoice_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__43D61337'
CREATE INDEX [IX_FK__ip_invoic__invoi__43D61337]
ON [dbo].[ip_invoice_amounts]
    ([invoice_id]);
GO

-- Creating foreign key on [invoice_id] in table 'ip_invoice_amounts'
ALTER TABLE [dbo].[ip_invoice_amounts]
ADD CONSTRAINT [FK__ip_invoic__invoi__628FA481]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[ip_invoices]
        ([invoice_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__628FA481'
CREATE INDEX [IX_FK__ip_invoic__invoi__628FA481]
ON [dbo].[ip_invoice_amounts]
    ([invoice_id]);
GO

-- Creating foreign key on [invoice_id] in table 'ip_invoice_amounts'
ALTER TABLE [dbo].[ip_invoice_amounts]
ADD CONSTRAINT [FK__ip_invoic__invoi__73BA3083]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[ip_invoices]
        ([invoice_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__73BA3083'
CREATE INDEX [IX_FK__ip_invoic__invoi__73BA3083]
ON [dbo].[ip_invoice_amounts]
    ([invoice_id]);
GO

-- Creating foreign key on [invoice_id] in table 'ip_invoice_custom'
ALTER TABLE [dbo].[ip_invoice_custom]
ADD CONSTRAINT [FK__ip_invoic__invoi__41EDCAC5]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[ip_invoices]
        ([invoice_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__41EDCAC5'
CREATE INDEX [IX_FK__ip_invoic__invoi__41EDCAC5]
ON [dbo].[ip_invoice_custom]
    ([invoice_id]);
GO

-- Creating foreign key on [invoice_id] in table 'ip_invoice_custom'
ALTER TABLE [dbo].[ip_invoice_custom]
ADD CONSTRAINT [FK__ip_invoic__invoi__619B8048]
    FOREIGN KEY ([invoice_id])
    REFERENCES [dbo].[ip_invoices]
        ([invoice_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__619B8048'
CREATE INDEX [IX_FK__ip_invoic__invoi__619B8048]
ON [dbo].[ip_invoice_custom]
    ([invoice_id]);
GO

-- Creating foreign key on [invoice_group_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__invoi__30F848ED]
    FOREIGN KEY ([invoice_group_id])
    REFERENCES [dbo].[ip_invoice_groups]
        ([invoice_group_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__30F848ED'
CREATE INDEX [IX_FK__ip_invoic__invoi__30F848ED]
ON [dbo].[ip_invoices]
    ([invoice_group_id]);
GO

-- Creating foreign key on [invoice_group_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__invoi__32AB8735]
    FOREIGN KEY ([invoice_group_id])
    REFERENCES [dbo].[ip_invoice_groups]
        ([invoice_group_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__32AB8735'
CREATE INDEX [IX_FK__ip_invoic__invoi__32AB8735]
ON [dbo].[ip_invoices]
    ([invoice_group_id]);
GO

-- Creating foreign key on [invoice_group_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__invoi__5BE2A6F2]
    FOREIGN KEY ([invoice_group_id])
    REFERENCES [dbo].[ip_invoice_groups]
        ([invoice_group_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__5BE2A6F2'
CREATE INDEX [IX_FK__ip_invoic__invoi__5BE2A6F2]
ON [dbo].[ip_invoices]
    ([invoice_group_id]);
GO

-- Creating foreign key on [invoice_group_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__invoi__60A75C0F]
    FOREIGN KEY ([invoice_group_id])
    REFERENCES [dbo].[ip_invoice_groups]
        ([invoice_group_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__invoi__60A75C0F'
CREATE INDEX [IX_FK__ip_invoic__invoi__60A75C0F]
ON [dbo].[ip_invoices]
    ([invoice_group_id]);
GO

-- Creating foreign key on [invoice_group_id] in table 'ip_quotes'
ALTER TABLE [dbo].[ip_quotes]
ADD CONSTRAINT [FK_ip_quotes_ip_invoice_groups]
    FOREIGN KEY ([invoice_group_id])
    REFERENCES [dbo].[ip_invoice_groups]
        ([invoice_group_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quotes_ip_invoice_groups'
CREATE INDEX [IX_FK_ip_quotes_ip_invoice_groups]
ON [dbo].[ip_quotes]
    ([invoice_group_id]);
GO

-- Creating foreign key on [user_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__user___339FAB6E]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[ip_users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__user___339FAB6E'
CREATE INDEX [IX_FK__ip_invoic__user___339FAB6E]
ON [dbo].[ip_invoices]
    ([user_id]);
GO

-- Creating foreign key on [user_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__user___5CD6CB2B]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[ip_users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__user___5CD6CB2B'
CREATE INDEX [IX_FK__ip_invoic__user___5CD6CB2B]
ON [dbo].[ip_invoices]
    ([user_id]);
GO

-- Creating foreign key on [user_id] in table 'ip_invoices'
ALTER TABLE [dbo].[ip_invoices]
ADD CONSTRAINT [FK__ip_invoic__user___5EBF139D]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[ip_users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_invoic__user___5EBF139D'
CREATE INDEX [IX_FK__ip_invoic__user___5EBF139D]
ON [dbo].[ip_invoices]
    ([user_id]);
GO

-- Creating foreign key on [quote_id] in table 'ip_payments'
ALTER TABLE [dbo].[ip_payments]
ADD CONSTRAINT [FK_ip_quote_ip_payments]
    FOREIGN KEY ([quote_id])
    REFERENCES [dbo].[ip_quotes]
        ([quote_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quote_ip_payments'
CREATE INDEX [IX_FK_ip_quote_ip_payments]
ON [dbo].[ip_payments]
    ([quote_id]);
GO

-- Creating foreign key on [tax_rate_id] in table 'ip_products'
ALTER TABLE [dbo].[ip_products]
ADD CONSTRAINT [FK_ip_products_ip_tax_rates]
    FOREIGN KEY ([tax_rate_id])
    REFERENCES [dbo].[ip_tax_rates]
        ([tax_rate_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_products_ip_tax_rates'
CREATE INDEX [IX_FK_ip_products_ip_tax_rates]
ON [dbo].[ip_products]
    ([tax_rate_id]);
GO

-- Creating foreign key on [item_product_id] in table 'ip_quote_items'
ALTER TABLE [dbo].[ip_quote_items]
ADD CONSTRAINT [FK_ip_quote_items_ip_products]
    FOREIGN KEY ([item_product_id])
    REFERENCES [dbo].[ip_products]
        ([product_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quote_items_ip_products'
CREATE INDEX [IX_FK_ip_quote_items_ip_products]
ON [dbo].[ip_quote_items]
    ([item_product_id]);
GO

-- Creating foreign key on [quote_id] in table 'ip_quote_amounts'
ALTER TABLE [dbo].[ip_quote_amounts]
ADD CONSTRAINT [FK__ip_quote___quote__5441852A]
    FOREIGN KEY ([quote_id])
    REFERENCES [dbo].[ip_quotes]
        ([quote_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ip_quote___quote__5441852A'
CREATE INDEX [IX_FK__ip_quote___quote__5441852A]
ON [dbo].[ip_quote_amounts]
    ([quote_id]);
GO

-- Creating foreign key on [quote_id] in table 'ip_quote_items'
ALTER TABLE [dbo].[ip_quote_items]
ADD CONSTRAINT [FK_ip_quote_items_ip_quotes]
    FOREIGN KEY ([quote_id])
    REFERENCES [dbo].[ip_quotes]
        ([quote_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quote_items_ip_quotes'
CREATE INDEX [IX_FK_ip_quote_items_ip_quotes]
ON [dbo].[ip_quote_items]
    ([quote_id]);
GO

-- Creating foreign key on [quote_tax_rate_id] in table 'ip_quote_tax_rates'
ALTER TABLE [dbo].[ip_quote_tax_rates]
ADD CONSTRAINT [FK_ip_quote_tax_rates_ip_quote_tax_rates]
    FOREIGN KEY ([quote_tax_rate_id])
    REFERENCES [dbo].[ip_quote_tax_rates]
        ([quote_tax_rate_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [quote_id] in table 'ip_quote_tax_rates'
ALTER TABLE [dbo].[ip_quote_tax_rates]
ADD CONSTRAINT [FK_ip_quote_tax_rates_ip_tax_rates]
    FOREIGN KEY ([quote_id])
    REFERENCES [dbo].[ip_tax_rates]
        ([tax_rate_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quote_tax_rates_ip_tax_rates'
CREATE INDEX [IX_FK_ip_quote_tax_rates_ip_tax_rates]
ON [dbo].[ip_quote_tax_rates]
    ([quote_id]);
GO

-- Creating foreign key on [user_id] in table 'ip_quotes'
ALTER TABLE [dbo].[ip_quotes]
ADD CONSTRAINT [FK_ip_quotes_ip_users]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[ip_users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ip_quotes_ip_users'
CREATE INDEX [IX_FK_ip_quotes_ip_users]
ON [dbo].[ip_quotes]
    ([user_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------