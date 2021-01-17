using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Notes_App.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Type { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
