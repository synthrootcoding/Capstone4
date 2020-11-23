using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Capstone4TDL.Models
{
    public partial class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
        public int? IdNetUsers { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        public virtual TodoItem IdNetUsersNavigation { get; set; }
        public virtual ICollection<TodoItem> InverseIdNetUsersNavigation { get; set; }

        public TodoItem()
        {
            InverseIdNetUsersNavigation = new HashSet<TodoItem>();
        }
    }
}
