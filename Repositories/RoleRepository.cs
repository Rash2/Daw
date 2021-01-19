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
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(Context context) : base(context)
        {

        }

        public Role GetRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.RoleId == id)
                .FirstOrDefault();
        }

        public List<Role> GetRolesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}