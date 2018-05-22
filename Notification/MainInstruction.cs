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
        List<DataForNotification> _data = new List<DataForNotification>();
        static DataForNotification  _currentNotification = new DataForNotification();
        public MainInstruction()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //todo get current date and time from file 
            DateTime date = DateTime.Now;

            TimerCallback timerCallback = new TimerCallback(FileExam);
            Timer timer = new Timer(timerCallback, date, 0, 60000);

        }

        private  void FileExam(object obj)
        {
            DateTime now = (DateTime) obj;

            DataEncryption workingWithFile = new DataEncryption();

            _data = workingWithFile.ReadFileEncrypted();

            _data.Sort();//?
            _currentNotification = _data[0];

            if (now.Date == _currentNotification.DateAndTime.Date)
                if (now.Hour == _currentNotification.DateAndTime.Hour)
                    if (now.Minute == _currentNotification.DateAndTime.Minute)
                    {
                        
                        Thread callNotificationForm = new Thread(CallForm);

                        callNotificationForm.Start();
                        
                    }
                       

        }

        static void CallForm()
        {
            NotificationForm form = new NotificationForm(_currentNotification);
            form.ShowDialog();
        }

        protected override void OnStop()
        {
            // todo write current date and time to file
        }
    }
}
