using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPSettings
    {
        IEnumerable<IPSettingsModel> FilterIPSettings();
        IPSettingsModel FilterIPSettings(int id);
        void Add(IPSettingsModel iPSettingsModel);
    }
}
