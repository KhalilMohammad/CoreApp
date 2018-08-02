using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApp.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.DataAccess
{
    public class UserService : IUserService
    {
        private readonly ApplicatinoDbContext _context;

        public UserService(ApplicatinoDbContext context)
        {
            _context = context;
        }


        public Task<int> AddUser(User user)
        {
            var users = new User
            {
                Id = user.Id,
                Name = user.Name                
            };

            _context.User.Add(users);
            _context.SaveChanges();

            return Task.FromResult(user.Id);

        }

        public List<User> GetUser()
        {
            try
            {
                return _context.User
                       .AsNoTracking()
                       .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
