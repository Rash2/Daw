using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;

namespace Notes_App.IRepositories
{
    public interface IUserRoleRepository : IGenericRepository<UserRole>
    {
        UserRole GetUserRoleAllDetails(int id);
        List<UserRole> GetUserRolesAllDetails();
    }
}
