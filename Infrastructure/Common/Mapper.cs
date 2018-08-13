using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core_Project.Service;
using Infrastructure.Repository;

namespace Infrastructure.Common
{
    public class Mapper
    {

        

        public  Mapper()
        {
            
        }

        public static ip_clients Map(IPClientsModel ipClientsModel, ip_clients ipClientsDB)
        {
            if (ipClientsModel == null)
            {
               
                //throw new ArgumentNullException(nameof(ipClientsModel));
            }

            if (ipClientsDB == null)
            {
                ipClientsDB = new ip_clients();
                //throw new ArgumentNullException(nameof(ipClientsDB));
            }

            ipClientsDB.client_id = ipClientsModel.Client_ID;
            ipClientsDB.client_active = ipClientsModel.Client_Active == null ? 0 : ipClientsModel.Client_Active == true ? 1 : 0;
            ipClientsDB.client_address_1 = ipClientsModel.Client_Address_1;
            ipClientsDB.client_address_2 = ipClientsModel.Client_Address_2;
            ipClientsDB.client_city = ipClientsModel.Client_City;
            ipClientsDB.client_country = ipClientsModel.Client_Country;
            ipClientsDB.client_date_created = ipClientsModel.Client_Date_Created;
            ipClientsDB.client_date_modified = ipClientsModel.Client_Date_Modified;
            ipClientsDB.client_email = ipClientsModel.Client_Email;
            ipClientsDB.client_fax = ipClientsModel.Client_Fax;
            ipClientsDB.client_id = ipClientsModel.Client_ID;
            ipClientsDB.client_mobile = ipClientsModel.Client_Mobile;
            ipClientsDB.client_name = ipClientsModel.Client_Name;
            ipClientsDB.client_phone = ipClientsModel.Client_Phone;
            ipClientsDB.client_state = ipClientsModel.Client_State;
            ipClientsDB.client_tax_code = ipClientsModel.Client_Tax_Code;
            ipClientsDB.client_vat_id = ipClientsModel.Client_VAT_ID;
            ipClientsDB.client_web = ipClientsModel.Client_Web;
            ipClientsDB.client_zip = ipClientsModel.Client_Zip;
            ipClientsDB.clientType = ipClientsModel.clientType;

            return ipClientsDB;
        }

        public static IPClientsModel Convert(ip_clients ipClientsDB)
        {
            if (ipClientsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipClientsDB));
            }

            return new IPClientsModel()
            {
                Client_Active = ipClientsDB.isdelete.HasValue && ipClientsDB.isdelete.Value == true ? true : false,
                Client_Address_1 = ipClientsDB.client_address_1,
                Client_Address_2 = ipClientsDB.client_address_2,
                Client_City = ipClientsDB.client_city,
                Client_Country = ipClientsDB.client_country,
                Client_Date_Created = ipClientsDB.client_date_created,
                Client_Date_Modified = ipClientsDB.client_date_modified,
                Client_Email = ipClientsDB.client_email,
                Client_Fax = ipClientsDB.client_fax,
                Client_ID = ipClientsDB.client_id,
                Client_Mobile = ipClientsDB.client_mobile,
                Client_Name = ipClientsDB.client_name,
                Client_Phone = ipClientsDB.client_phone,
                Client_State = ipClientsDB.client_state,
                Client_Tax_Code = ipClientsDB.client_tax_code,
                Client_VAT_ID = ipClientsDB.client_vat_id,
                Client_Web = ipClientsDB.client_web,
                Client_Zip = ipClientsDB.client_zip,
                clientType = ipClientsDB.clientType.HasValue?ipClientsDB.clientType.Value:0
            };
        }

        public ip_client_custom Map(IPClientCustomModel iPClientCustomModel, ip_client_custom ipClientCustomDB)
        {
            if (iPClientCustomModel == null)
            {
                //throw new ArgumentNullException(nameof(iPClientCustomModel));
            }

            if (ipClientCustomDB == null)
            {
                //throw new ArgumentNullException(nameof(ipClientCustomDB));
            }


            ipClientCustomDB.client_custom_id = iPClientCustomModel.Client_Custom_ID;
            ipClientCustomDB.client_id = iPClientCustomModel.Client_ID;

            return ipClientCustomDB;
        }

        public IPClientCustomModel Convert(ip_client_custom iPClientCustomDB)
        {
            if (iPClientCustomDB == null)
            {
                //throw new ArgumentNullException(nameof(iPClientCustomDB));
            }

            return new IPClientCustomModel()
            {
                Client_Custom_ID = iPClientCustomDB.client_custom_id,
                Client_ID = iPClientCustomDB.client_id
            };
        }

        public static ip_products Map(IPProductsModel iPProductsModel, ip_products ipProductsDB)
        {
            if (iPProductsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPProductsModel));
            }

            if (ipProductsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipProductsDB));
            }

            ipProductsDB.family_id = iPProductsModel.family_id;
            ipProductsDB.other_info = iPProductsModel.other_info;
            ipProductsDB.product_description = iPProductsModel.product_description;
            ipProductsDB.product_name = iPProductsModel.product_name;
            ipProductsDB.product_price = iPProductsModel.product_price;
            ipProductsDB.product_sku = iPProductsModel.product_sku;
            ipProductsDB.provider_name = iPProductsModel.provider_name;
            ipProductsDB.purchase_org_price = iPProductsModel.purchase_org_price;
            ipProductsDB.purchase_price = iPProductsModel.purchase_price;
            ipProductsDB.quantity = iPProductsModel.quantity;
            ipProductsDB.selling_price = iPProductsModel.selling_price;
            ipProductsDB.serial_number = iPProductsModel.serial_number;
            ipProductsDB.sub_cate = iPProductsModel.sub_cate;
            ipProductsDB.supp_name = iPProductsModel.supp_name;
            ipProductsDB.tax_rate_id = iPProductsModel.tax_rate_id;
            ipProductsDB.warenty_detail = iPProductsModel.warenty_detail;
            return ipProductsDB;
        }

        public static IPProductsModel Convert(ip_products ipProductsDB)
        {
            if (ipProductsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipProductsDB));
            }

            return new IPProductsModel()
            {
                product_id = ipProductsDB.product_id,
                family_id = ipProductsDB.family_id,
                other_info = ipProductsDB.other_info,
                product_description = ipProductsDB.product_description,
                product_name = ipProductsDB.product_name,
                product_price = ipProductsDB.product_price,
                product_sku = ipProductsDB.product_sku,
                provider_name = ipProductsDB.provider_name,
                purchase_org_price = ipProductsDB.purchase_org_price,
                purchase_price = ipProductsDB.purchase_price,
                quantity = ipProductsDB.quantity,
                selling_price = ipProductsDB.selling_price,
                serial_number = ipProductsDB.serial_number,
                sub_cate = ipProductsDB.sub_cate,
                supp_name = ipProductsDB.supp_name,
                tax_rate_id = ipProductsDB.tax_rate_id,
                warenty_detail = ipProductsDB.warenty_detail,
                tax_Model =  Convert(ipProductsDB.ip_tax_rates),
                family_Model = Convert(ipProductsDB.ip_families)
                
            };
        }

        public static IPTaxRatesModel Convert(ip_tax_rates tax_Rates)
        {
            var obj =  new IPTaxRatesModel() {
                tax_rate_id = tax_Rates.tax_rate_id,
                tax_rate_name = tax_Rates.tax_rate_name,
                tax_rate_percent = tax_Rates.tax_rate_percent

            };
            return obj;
        }

        public static ip_tax_rates Map(IPTaxRatesModel iPTaxRatesModel, ip_tax_rates tax_Rates)
        {
            tax_Rates.tax_rate_name = iPTaxRatesModel.tax_rate_name;
            tax_Rates.tax_rate_percent = iPTaxRatesModel.tax_rate_percent;
            return tax_Rates;
        }

        public static ip_families Map(IPFamiliesModel iPFamiliesModel, ip_families ipFamiliesDB)
        {
            if (iPFamiliesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPFamiliesModel));
            }

            if (ipFamiliesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipFamiliesDB));
            }

            ipFamiliesDB.family_name = iPFamiliesModel.family_name;

            return ipFamiliesDB;
        }

        public static IPFamiliesModel Convert(ip_families ipFamiliesDB)
        {
            if (ipFamiliesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipFamiliesDB));
            }

            return new IPFamiliesModel()
            {
                family_id = ipFamiliesDB.family_id,
                family_name = ipFamiliesDB.family_name
            };
        }

        public static IPQuoteTaxRatesModel Convert(ip_quote_tax_rates ipQuoteTaxRatesDB)
        {
            if (ipQuoteTaxRatesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteTaxRatesDB));
            }

            return new IPQuoteTaxRatesModel()
            {
                include_item_tax = ipQuoteTaxRatesDB.include_item_tax,
                quote_id = ipQuoteTaxRatesDB.quote_id,
                quote_tax_rate_amount = ipQuoteTaxRatesDB.quote_tax_rate_amount,
                tax_rate_id = ipQuoteTaxRatesDB.tax_rate_id,
                quote_tax_rate_id = ipQuoteTaxRatesDB.quote_tax_rate_id
            };
        }

      



        public static ip_quote_tax_rates Map(IPQuoteTaxRatesModel iPQuoteTaxRatesModel, ip_quote_tax_rates ipQuoteTaxRatesDB)
        {
            if (iPQuoteTaxRatesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteTaxRatesModel));
            }

            if (ipQuoteTaxRatesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteTaxRatesDB));
            }

            ipQuoteTaxRatesDB.include_item_tax = iPQuoteTaxRatesModel.include_item_tax;
            ipQuoteTaxRatesDB.quote_tax_rate_amount = iPQuoteTaxRatesModel.quote_tax_rate_amount;
            ipQuoteTaxRatesDB.quote_tax_rate_id = iPQuoteTaxRatesModel.quote_tax_rate_id;
            ipQuoteTaxRatesDB.quote_id = iPQuoteTaxRatesModel.quote_id;

            return ipQuoteTaxRatesDB;
        }

        public static IPQuotesModel Convert(ip_quotes iPQuotesDB)
        {
            if (iPQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesDB));
            }

            var model = new IPQuotesModel();

            model.quote_id = iPQuotesDB.quote_id;
            model.client_id = iPQuotesDB.client_id;
            model.invoice_group_id = iPQuotesDB.invoice_group_id;
            model.notes = iPQuotesDB.notes;
            model.quote_date_created = iPQuotesDB.quote_date_created;
            model.quote_date_expires = iPQuotesDB.quote_date_expires;
            model.quote_date_modified = iPQuotesDB.quote_date_modified;
            model.quote_discount_amount = iPQuotesDB.quote_discount_amount.HasValue ? iPQuotesDB.quote_discount_amount.Value : 0;
            model.quote_discount_percent = iPQuotesDB.quote_discount_percent.HasValue ? iPQuotesDB.quote_discount_percent.Value : 0;
            model.quote_number = iPQuotesDB.quote_number;
            model.quote_password = iPQuotesDB.quote_password;
            model.quote_status_id = iPQuotesDB.quote_status_id;
            model.quote_url_key = iPQuotesDB.quote_url_key;
            model.taxType = iPQuotesDB.taxType.HasValue ? iPQuotesDB.taxType.Value : 0;
            model.user_id = iPQuotesDB.user_id;
            model.client = Convert(iPQuotesDB.ip_clients);

          
                model.quote_amount = Convert(iPQuotesDB.ip_quote_amounts.FirstOrDefault());
           
            IIPPayments paymentService = new IPPaymentsRepository();

            model.payment = paymentService.FilterIPPaymentsByQuoteID(iPQuotesDB.quote_id);
            return model;
            
        }

       

        public static IPPurchaseModel Convert(ip_quotes iPQuotesDB,bool isPurchase)
        {
            if (iPQuotesDB == null)
            {
               
            }

            return new IPPurchaseModel()
            {
                quote_id = iPQuotesDB.quote_id,
                client_id = iPQuotesDB.client_id,
                invoice_group_id = iPQuotesDB.invoice_group_id,
                
                notes = iPQuotesDB.notes,
                quote_date_created = iPQuotesDB.quote_date_created,
                quote_date_expires = iPQuotesDB.quote_date_expires,
                quote_date_modified = iPQuotesDB.quote_date_modified,
                quote_discount_amount = iPQuotesDB.quote_discount_amount,
                quote_discount_percent = iPQuotesDB.quote_discount_percent,
                quote_number = iPQuotesDB.quote_number,
                quote_password = iPQuotesDB.quote_password,
                quote_status_id = iPQuotesDB.quote_status_id,
                quote_url_key = iPQuotesDB.quote_url_key,
                taxType = iPQuotesDB.taxType.HasValue ? iPQuotesDB.taxType.Value : 0,
                user_id = iPQuotesDB.user_id
            };
        }

        public static ip_quotes Map(IPQuotesModel iPQuotesModel, ip_quotes ipQuotesDB)
        {
            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            ipQuotesDB.client_id = iPQuotesModel.client_id;
            ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
            ipQuotesDB.type  = iPQuotesModel.type;
            ipQuotesDB.notes = iPQuotesModel.notes;
            ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
            ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
            ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
            ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
            ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
            ipQuotesDB.quote_number = iPQuotesModel.quote_number;
            ipQuotesDB.quote_password = iPQuotesModel.quote_password;
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
            ipQuotesDB.taxType = iPQuotesModel.taxType;
            ipQuotesDB.user_id = iPQuotesModel.user_id;

            return ipQuotesDB;
        }

        public static ip_quotes Map(IPPurchaseModel iPQuotesModel, ip_quotes ipQuotesDB)
        {
            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            ipQuotesDB.client_id = iPQuotesModel.client_id;
            ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
            ipQuotesDB.type  = iPQuotesModel.type;
            ipQuotesDB.notes = iPQuotesModel.notes;
            ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
            ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
            ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
            ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
            ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
            ipQuotesDB.quote_number = iPQuotesModel.quote_number;
            ipQuotesDB.quote_password = iPQuotesModel.quote_password;
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
            ipQuotesDB.taxType = iPQuotesModel.taxType;
            ipQuotesDB.user_id = iPQuotesModel.user_id;

            return ipQuotesDB;
        }

        
        public static IPQuoteItemsModel Convert(ip_quote_items ipQuoteItemsDB)
        {
            if (ipQuoteItemsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteItemsDB));
            }
            return new IPQuoteItemsModel()
            {
                item_date_added = ipQuoteItemsDB.item_date_added,
                quote_id = ipQuoteItemsDB.quote_id,
               
                item_description = ipQuoteItemsDB.item_description,
                item_discount_amount = ipQuoteItemsDB.item_discount_amount,
                item_id = ipQuoteItemsDB.item_id,
                item_name = ipQuoteItemsDB.item_name,
                item_order = ipQuoteItemsDB.item_order,
                item_price = ipQuoteItemsDB.item_price,
                item_product_id = ipQuoteItemsDB.item_product_id,
                item_quantity = ipQuoteItemsDB.item_quantity,
                item_serial = ipQuoteItemsDB.item_serial,
                product =Convert(ipQuoteItemsDB.ip_products)
            };
        }

        public static ip_quote_items Map(IPQuoteItemsModel iPQuoteItemsModel, ip_quote_items ipQuoteItemsDB)
        {  
            ipQuoteItemsDB.item_description = iPQuoteItemsModel.item_description;
            ipQuoteItemsDB.item_discount_amount = iPQuoteItemsModel.item_discount_amount;         
            ipQuoteItemsDB.item_product_id = iPQuoteItemsModel.item_product_id;
            ipQuoteItemsDB.item_quantity = iPQuoteItemsModel.item_quantity;
            return ipQuoteItemsDB;
        }

        public static ip_quote_items MapUpdate(IPQuoteItemsModel iPQuoteItemsModel, ip_quote_items ipQuoteItemsDB)
        {
            ipQuoteItemsDB.item_description = iPQuoteItemsModel.item_description==null?"": iPQuoteItemsModel.item_description;
            ipQuoteItemsDB.item_discount_amount = iPQuoteItemsModel.item_discount_amount==null?0: iPQuoteItemsModel.item_discount_amount;            
            ipQuoteItemsDB.item_quantity = iPQuoteItemsModel.item_quantity==null?0: iPQuoteItemsModel.item_quantity;
            return ipQuoteItemsDB;
        }

        public static ip_payments Map(IPPaymentsModel iPPaymentsModel, ip_payments ipPaymentssDB)
        {
            ipPaymentssDB.quote_id = iPPaymentsModel.quote_id;
            ipPaymentssDB.payment_amount = iPPaymentsModel.payment_amount;
            ipPaymentssDB.payment_date = iPPaymentsModel.payment_date;
            ipPaymentssDB.payment_note = iPPaymentsModel.payment_note== null? " ": iPPaymentsModel.payment_note;
            ipPaymentssDB.payment_method_id = iPPaymentsModel.payment_method_id;
            return ipPaymentssDB;
        }

        public static IPPaymentsModel Map( ip_payments ipPaymentssDB)
        {
            IPPaymentsModel iPPaymentsModel = new IPPaymentsModel();
            iPPaymentsModel.quote_id = ipPaymentssDB.quote_id;
            iPPaymentsModel.payment_amount = ipPaymentssDB.payment_amount.HasValue? ipPaymentssDB.payment_amount.Value:0;
            iPPaymentsModel.payment_date = ipPaymentssDB.payment_date;
            iPPaymentsModel.payment_note = ipPaymentssDB.payment_note;
            iPPaymentsModel.payment_method_id = ipPaymentssDB.payment_method_id;
            return iPPaymentsModel;
        }

        public static IPQuoteAmountsModel Convert(ip_quote_amounts ipQuoteAmountsDB)
        {
            if (ipQuoteAmountsDB == null)
            {
                return new IPQuoteAmountsModel();
            }

            return new IPQuoteAmountsModel()
            {
                quote_amount_id = ipQuoteAmountsDB.quote_amount_id,
                quote_id = ipQuoteAmountsDB.quote_id,
                quote_item_subtotal = ipQuoteAmountsDB.quote_item_subtotal,
                quote_discount = ipQuoteAmountsDB.quote_discount,
                quote_tax_total = ipQuoteAmountsDB.quote_tax_total,
                quote_total = ipQuoteAmountsDB.quote_total
            };
        }

        public static ip_quote_amounts Map(IPQuoteAmountsModel iPQuoteAmountsModel, ip_quote_amounts ipQuoteAmountsDB)
        {
            if (iPQuoteAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteAmountsModel));
            }

            if (ipQuoteAmountsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteAmountsDB));
            }

            ipQuoteAmountsDB.quote_id = iPQuoteAmountsModel.quote_id;
            ipQuoteAmountsDB.quote_item_subtotal = iPQuoteAmountsModel.quote_item_subtotal;
            ipQuoteAmountsDB.quote_discount = iPQuoteAmountsModel.quote_discount;
            ipQuoteAmountsDB.quote_tax_total = iPQuoteAmountsModel.quote_tax_total;
            ipQuoteAmountsDB.quote_total = iPQuoteAmountsModel.quote_total;

            return ipQuoteAmountsDB;
        }

        public static IPQuoteCustomModel Convert(ip_quote_custom ipQuoteCustomDB)
        {
            if (ipQuoteCustomDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteCustomDB));
            }

            return new IPQuoteCustomModel()
            {
                quote_custom_id = ipQuoteCustomDB.quote_custom_id,
                quote_id = ipQuoteCustomDB.quote_id
            };
        }

        public static ip_quote_custom Map(IPQuoteCustomModel iPQuoteCustomModel, ip_quote_custom ipQuoteCustomDB)
        {
            if (iPQuoteCustomModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteCustomModel));
            }

            if (ipQuoteCustomDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteCustomDB));
            }

            ipQuoteCustomDB.quote_id = iPQuoteCustomModel.quote_id;

            return ipQuoteCustomDB;
        }

        public static IPQuoteItemAmountsModel Convert(ip_quote_item_amounts ipQuoteItemAmountsDB)
        {
            if (ipQuoteItemAmountsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteItemAmountsDB));
            }

            return new IPQuoteItemAmountsModel()
            {
                item_amount_id = ipQuoteItemAmountsDB.item_amount_id,
                item_discount = ipQuoteItemAmountsDB.item_discount,
                item_id = ipQuoteItemAmountsDB.item_id,
                item_subtotal = ipQuoteItemAmountsDB.item_subtotal,
                item_tax_total = ipQuoteItemAmountsDB.item_tax_total,
                item_total = ipQuoteItemAmountsDB.item_total
            };
        }

        public static ip_quote_item_amounts Map(IPQuoteItemAmountsModel iPQuoteItemAmountsModel, ip_quote_item_amounts ipQuoteItemAmountsDB)
        {
            if (iPQuoteItemAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteItemAmountsModel));
            }

            if (ipQuoteItemAmountsDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuoteItemAmountsDB));
            }

            ipQuoteItemAmountsDB.item_discount = iPQuoteItemAmountsModel.item_discount;
            ipQuoteItemAmountsDB.item_id = iPQuoteItemAmountsModel.item_id;
            ipQuoteItemAmountsDB.item_subtotal = iPQuoteItemAmountsModel.item_subtotal;
            ipQuoteItemAmountsDB.item_tax_total = iPQuoteItemAmountsModel.item_tax_total;
            ipQuoteItemAmountsDB.item_total = iPQuoteItemAmountsModel.item_total;

            return ipQuoteItemAmountsDB;
        }

        public static ip_quotes Map(IPInvoicesModel iPQuotesModel, ip_quotes ipQuotesDB)
        {
            //throw new NotImplementedException();

            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            ipQuotesDB.client_id = iPQuotesModel.client_id;
            ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
            ipQuotesDB.is_quote = iPQuotesModel.isquote;
            ipQuotesDB.notes = iPQuotesModel.notes;
            ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
            ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
            ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
            ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
            ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
            ipQuotesDB.quote_number = iPQuotesModel.quote_number;
            ipQuotesDB.quote_password = iPQuotesModel.quote_password;
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
            ipQuotesDB.user_id = iPQuotesModel.user_id;

            return ipQuotesDB;
        }


        public static IPQuotesModel Map(IPInvoicesModel iPQuotesModel, IPQuotesModel ipQuotesDB)
        {
            //throw new NotImplementedException();

            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            ipQuotesDB.client_id = iPQuotesModel.client_id;
            ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
            ipQuotesDB.type = iPQuotesModel.type;
            ipQuotesDB.notes = iPQuotesModel.notes;
            ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
            ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
            ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
            ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
            ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
            ipQuotesDB.quote_number = iPQuotesModel.quote_number;
            ipQuotesDB.quote_password = iPQuotesModel.quote_password;
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
            ipQuotesDB.user_id = iPQuotesModel.user_id;

            return ipQuotesDB;
        }

        public static IPInvoicesModel Map(IPQuotesModel iPQuotesModel, IPInvoicesModel ipQuotesDB)
        {
            //throw new NotImplementedException();

            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            ipQuotesDB.client_id = iPQuotesModel.client_id;
            ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
            ipQuotesDB.type = iPQuotesModel.type;
            ipQuotesDB.notes = iPQuotesModel.notes;
            ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
            ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
            ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
            ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
            ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
            ipQuotesDB.quote_number = iPQuotesModel.quote_number;
            ipQuotesDB.quote_password = iPQuotesModel.quote_password;
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
            ipQuotesDB.user_id = iPQuotesModel.user_id;

            return ipQuotesDB;
        }

        public static List<IPInvoicesModel> Map(List<IPQuotesModel> ls_iPQuotesModel, List<IPInvoicesModel> ls_ipQuotesDB)
        {
            //throw new NotImplementedException();

            if (ls_iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            if (ls_ipQuotesDB == null)
            {
                //throw new ArgumentNullException(nameof(ipQuotesDB));
            }

            foreach (IPQuotesModel iPQuotesModel in ls_iPQuotesModel)
            {
                var ipQuotesDB = new IPInvoicesModel();
                ipQuotesDB.client_id = iPQuotesModel.client_id;
                ipQuotesDB.invoice_group_id = iPQuotesModel.invoice_group_id;
                ipQuotesDB.type = iPQuotesModel.type;
                ipQuotesDB.notes = iPQuotesModel.notes;
                ipQuotesDB.quote_date_created = iPQuotesModel.quote_date_created;
                ipQuotesDB.quote_date_expires = iPQuotesModel.quote_date_expires;
                ipQuotesDB.quote_date_modified = iPQuotesModel.quote_date_modified;
                ipQuotesDB.quote_discount_amount = iPQuotesModel.quote_discount_amount;
                ipQuotesDB.quote_discount_percent = iPQuotesModel.quote_discount_percent;
                ipQuotesDB.quote_number = iPQuotesModel.quote_number;
                ipQuotesDB.quote_password = iPQuotesModel.quote_password;
                ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
                ipQuotesDB.quote_url_key = iPQuotesModel.quote_url_key;
                ipQuotesDB.user_id = iPQuotesModel.user_id;
                ls_ipQuotesDB.Add(ipQuotesDB);
            }
            return ls_ipQuotesDB;
        }

    }
}

