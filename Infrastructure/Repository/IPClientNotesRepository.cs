using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
namespace Infrastructure.Repository
{
    public class IPClientNotesRepository:IIPClientNotes
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPClientNotesRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPClientNotesModel> FilterIPClientsNotes()
        {
            throw new NotImplementedException();
        }

        public IPClientNotesModel FilterIPClientsNotes(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPClientNotesModel iPClientsNotesModel)
        {
            throw new NotImplementedException();
        }
    }
}
