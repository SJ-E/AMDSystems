using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPUsers
    {
        IEnumerable<IPUsersModel> FilterIPUsers();
        IPUsersModel FilterIPUsers(int id);
        void Add(IPUsersModel iPUsersModel);
    }
}
