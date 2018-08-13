using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Project.Model;

namespace Core_Project.Service
{
    public interface IUserProfileService
    {
        UserProfileModel GetUser(string email = "", string phoneNo = "");
        int CreateUserProfile(UserProfileModel model);
    }
}
