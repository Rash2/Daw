using Notes_App.Entities;
using Notes_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(AuthenticationRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }

        public static User ToUserExtension(this AuthenticationRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }

        public static User ToUserExtension(this RegisterRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }
    }
}