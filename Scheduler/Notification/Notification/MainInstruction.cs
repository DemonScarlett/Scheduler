using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Scheduler.Models;
using Scheduler.Security;

namespace Notification
{
    public partial class MainInstruction : ServiceBase
    {
        public MainInstruction()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            DateTime date = DateTime.Now;

            TimerCallback timerCallback = new TimerCallback(FileExam);
            Timer timer = new Timer(timerCallback, date, 0, 60000);

        }

        private  void FileExam(object obj)
        {
            DateTime now = (DateTime) obj;

            List<DataForNotification> data = new List<DataForNotification>(); 
            DataEncryption workingWithFile = new DataEncryption();

            data = workingWithFile.ReadFileEncrypted();

            data.Sort();//?

            if (now.Date == data[0].DateAndTime.Date)
                if (now.Hour == data[0].DateAndTime.Hour)
                    if (now.Minute == data[0].DateAndTime.Minute)

        }

        protected override void OnStop()
        {
        }
    }
}
