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
    public class IPUsersRepository : IIPUsers
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPUsersRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPUsersModel iPUsersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPUsersModel> FilterIPUsers()
        {
            throw new NotImplementedException();
        }

        public IPUsersModel FilterIPUsers(int id)
        {
            return new IPUsersModel() { userId = id };
        }
    }
}
