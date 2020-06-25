using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
