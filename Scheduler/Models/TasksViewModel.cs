using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Models
{
    class TasksViewModel
    {
        public string Time { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
