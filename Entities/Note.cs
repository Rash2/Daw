using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Entities
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Color { get; set; }
        public string DateCreated { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
