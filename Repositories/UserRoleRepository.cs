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
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(Context context) : base(context)
        {

        }

        public UserRole GetUserRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.UserRoleId == id)
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .FirstOrDefault();
        }

        public List<UserRole> GetUserRolesAllDetails()
        {
            return _table
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .ToList();
        }
    }
}