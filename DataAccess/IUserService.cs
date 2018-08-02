using CoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.DataAccess
{
    public interface IUserService
    {
        Task<int> AddUser(User user);
        List<User> GetUser();
    }
}
