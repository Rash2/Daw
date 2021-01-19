using Notes_App.Entities;
using Notes_App.IRepositories;
using Notes_App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Services
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Role Create(Role cat)
        {
            _roleRepository.Create(cat);
            _roleRepository.SaveChanges();

            return _roleRepository.GetRoleAllDetails(cat.RoleId);
        }
        public Role Get(int id)
        {
            return _roleRepository.GetRoleAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _roleRepository.FindById(id);
            if (entity != null)
            {
                _roleRepository.Delete(entity);
                _roleRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Role> GetAll()
        {
            return _roleRepository.GetRolesAllDetails();
        }

        public Role Update(Role cat)
        {
            if (_roleRepository.FindById(cat.RoleId) == null) return null;
            _roleRepository.Update(cat);
            _roleRepository.SaveChanges();
            return _roleRepository.GetRoleAllDetails(cat.RoleId);
        }
    }
}
