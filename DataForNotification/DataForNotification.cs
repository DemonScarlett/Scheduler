using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Models
{
    public class DataForNotification
    {
       public string Group { set; get; }
        public string Name { set; get; }
        public string Comment { set; get; }
        public DateTime DateAndTime { set; get; }
        public byte Priority { set; get; }
        public bool Status { get; set; }
        public DateTime DateandTimeOfNotification { get; set; }
        public bool IsNotification { set; get; }
        public string Sound { set; get; }

    }
}
