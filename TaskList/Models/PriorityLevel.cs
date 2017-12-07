using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class PriorityLevel
    {
        [Required]
        [Key]
        public int PriorityId { get; set; }
        [StringLength(15)]
        public string PriorityName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}