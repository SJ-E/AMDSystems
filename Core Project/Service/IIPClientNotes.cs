using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Project.Model;

namespace Core_Project.Service
{
     public interface IIPClientNotes
    {
        IEnumerable<IPClientNotesModel> FilterIPClientsNotes();
        IPClientNotesModel FilterIPClientsNotes(int id);
        void Add(IPClientNotesModel iPClientsNotesModel);
    }
}
