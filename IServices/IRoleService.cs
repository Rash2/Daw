using Notes_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.IServices
{
    public interface IRoleService
    {
        Role Create(Role role);
        Role Get(int id);
        Role Update(Role role);
        bool Delete(int id);
        List<Role> GetAll();

    }
}
