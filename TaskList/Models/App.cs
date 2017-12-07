using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class App
    {
        [Required]
        [Key]
        public int AppId { get; set; }
        [StringLength(50)]
        [Display(Name = "Application's Name")]
        public string AppName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}