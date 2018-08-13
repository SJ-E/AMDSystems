using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPSettingsRepository : IIPSettings
    {

        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPSettingsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPSettingsModel iPSettingsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPSettingsModel> FilterIPSettings()
        {
            throw new NotImplementedException();
        }

        public IPSettingsModel FilterIPSettings(int id)
        {
            throw new NotImplementedException();
        }
    }
}
