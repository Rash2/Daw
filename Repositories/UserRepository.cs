using Notes_App.Entities;
using Notes_App.IRepositories;
using Notes_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notes_App.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {

        }

        public User GetByUserAndPassword(string email, string password)
        {
            return _table.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _table.Where(x => x.Email == email).FirstOrDefault();
        }


        public User GetUserAllDetails(int id)
        {
            return _table.Where(user => user.UserId == id)
                .Include(user => user.UserRoles)
                .FirstOrDefault();
        }

        public List<User> GetUsersAllDetails()
        {
            return _table
                .Include(user => user.UserRoles)
                .ToList();
        }
    }
}