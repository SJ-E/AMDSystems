using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPQuoteItemsRepository : IIPQuoteItems
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPQuoteItemsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }
        public void Add(IPQuoteItemsModel iPQuoteItemsModel)
        {
            if (iPQuoteItemsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteItemsModel));
            }
            iPQuoteItemsModel.item_date_added = DateTime.Now;
            ip_quote_items ipQuoteItemsDB = Mapper.Map(iPQuoteItemsModel, new ip_quote_items());
            AMDSystemsEntities.ip_quote_items.Add(ipQuoteItemsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems()
        {
            var allIPQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Select(qt => qt).ToList();
            var allIPQuoteItemsModel = new List<IPQuoteItemsModel>();
            allIPQuoteItemsDB.ForEach(qt => allIPQuoteItemsModel.Add(Mapper.Convert(qt)));
            return allIPQuoteItemsModel;
        }

        public IPQuoteItemsModel FilterIPQuoteItems(int id)
        {
            var ipQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Where(qt => qt.item_id == id).FirstOrDefault();
            var ipQuoteItemsModel = Mapper.Convert(ipQuoteItemsDB);
            return ipQuoteItemsModel;
        }

      
        public IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems(IPQuotesModel model)
        {
            var ipQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Where(qt => qt.quote_id == model.quote_id).ToList() ;
            if (ipQuoteItemsDB.Count() == 0)
            {
                return new List<IPQuoteItemsModel>();
            }

            var ipQuoteItemsModel = ipQuoteItemsDB.Select(e=>  Mapper.Convert(e));
            return ipQuoteItemsModel;
        }

        public IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems(IPPurchaseModel model)
        {
            var ipQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Where(qt => qt.quote_id == model.quote_id).ToList();
            if (ipQuoteItemsDB.Count() == 0)
            {
                return new List<IPQuoteItemsModel>();
            }

            var ipQuoteItemsModel = ipQuoteItemsDB.Select(e => Mapper.Convert(e));
            return ipQuoteItemsModel;
        }

        public void Update(IPQuoteItemsModel iPQuoteItemsModel)
        {
            if (iPQuoteItemsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteItemsModel));
            }

            var ipQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Where(qi => qi.item_id == iPQuoteItemsModel.item_id).FirstOrDefault();
            Mapper.Map(iPQuoteItemsModel, ipQuoteItemsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public void Update(IEnumerable<IPQuoteItemsModel> iPQuoteItemsModels,int quoteId)
        {
          

            foreach (var iPQuoteItemsModel in iPQuoteItemsModels)
            {
                var ipQuoteItemsDB = AMDSystemsEntities.ip_quote_items.Where(qi => qi.item_id == iPQuoteItemsModel.item_id).FirstOrDefault();
                if (ipQuoteItemsDB == null)
                {
                    ipQuoteItemsDB = new ip_quote_items();
                    Mapper.Map(iPQuoteItemsModel, ipQuoteItemsDB);
                    ipQuoteItemsDB.quote_id = quoteId;
                    ipQuoteItemsDB.item_date_added = DateTime.Now;
                    AMDSystemsEntities.ip_quote_items.Add(ipQuoteItemsDB);
                }
                else
                {
                    Mapper.MapUpdate(iPQuoteItemsModel, ipQuoteItemsDB);
                    ipQuoteItemsDB.quote_id = quoteId;
                }
                AMDSystemsEntities.SaveChanges();
            }
                
                
                
            }

        }
    }

