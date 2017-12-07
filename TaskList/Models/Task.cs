using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Task
    {
        [Required]
        [Key]
        public int TaskId { get; set; }
        [Display(Name="Title")]
        public string TaskTitle { get; set; }
        [Display(Name = "Description")]
        public string TaskDesc { get; set; }
        [Display(Name = "Application")]
        public virtual  App App { get; set; }
        [Display(Name = "Set Priority")]
        public virtual PriorityLevel Priority { get; set; }
        [Display(Name = "Deadline")]
        public DateTime DeadLine { get; set; }
        public Boolean? isCompleted { get; set; }
    }
}