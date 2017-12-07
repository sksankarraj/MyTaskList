using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace TaskList.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext()
            : base("name=ConStr")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<App> Apps { get; set; }
        public virtual DbSet<PriorityLevel> Priority { get; set; }

    }
}