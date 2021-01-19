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
    public class UserRoleService: IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public UserRole Create(UserRole ur)
        {
            _userRoleRepository.Create(ur);
            _userRoleRepository.SaveChanges();

            return _userRoleRepository.GetUserRoleAllDetails(ur.RoleId);
        }
        public UserRole Get(int id)
        {
            return _userRoleRepository.GetUserRoleAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _userRoleRepository.FindById(id);
            if (entity != null)
            {
                _userRoleRepository.Delete(entity);
                _userRoleRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UserRole> GetAll()
        {
            return _userRoleRepository.GetUserRolesAllDetails();
        }

        public UserRole Update(UserRole ur)
        {
            if (_userRoleRepository.FindById(ur.RoleId) == null) return null;
            _userRoleRepository.Update(ur);
            _userRoleRepository.SaveChanges();
            return _userRoleRepository.GetUserRoleAllDetails(ur.RoleId);
        }
    }
}
