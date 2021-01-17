using Notes_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Models;

namespace Notes_App.IServices
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        bool Register(RegisterRequest request);
        AuthenticationResponse Login(AuthenticationRequest request);
    }
}
