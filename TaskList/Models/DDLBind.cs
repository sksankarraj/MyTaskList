using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskList.Models;

namespace TaskList.Models
{
    public class DDLBind
    {
        TaskContext db = new TaskContext();

        public IEnumerable<App> getAppsList()
        {
            return db.Apps.AsEnumerable().ToList();
        }
    }
}