using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Notes_App.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string CategoryTitle { get; set; }
    }
}
