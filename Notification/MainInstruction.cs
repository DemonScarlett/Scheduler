using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Scheduler.DataContract;
using Scheduler.Models;
using Scheduler.Security;

namespace Notification
{
    public partial class MainInstruction : ServiceBase, ISchedulerServiceDataContract<DataForNotification>
    {
        List<DataForNotification> _data;
        static DataForNotification  _currentNotification;
     //   public DataForNotification CurrentNotification { set; get; }
        public bool Enabled { get; set; }

        // IsBusy , Working

        public MainInstruction()
        {
            InitializeComponent();
          //  CurrentNotification = new DataForNotification();
            _currentNotification = new DataForNotification();
            _data = new List<DataForNotification>();

        }
        /*ServiceContract.AddTask(name,dateTime);*/


        protected override void OnStart(string[] args)
        {
            //todo get current date and time from file 
            DateTime date = DateTime.Now;

            var timerCallback = new TimerCallback(ListExam);
            Timer timer = new Timer(timerCallback, date, 0, 60000);

            InitializeServiceHost();

            DataEncryption workingWithFile = new DataEncryption();

            _data = workingWithFile.ReadFileEncrypted();

        }

        private  void ListExam(object obj)
        {
            DateTime now = (DateTime) obj;

            _data.Sort();//if it will not work check all list
            _currentNotification = _data[0];

            //if(now.Subtract(_currentNotification.DateAndTime) <= TimeSpan.FromMinutes(1))

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
            Process.Start("NotificationForm.exe");
        }

        protected override void OnStop()
        {
            // todo write current date and time to file
        }

        public void AddTask(DataForNotification newTask)
        {
            if (!_data.Contains(newTask))
                _data.Add(newTask);
        }

        public void DeleteTask(DataForNotification task)
        {
            if(_data.Contains(task))
                _data.Remove(task);
        }

        public DataForNotification GetData()
        {
            return _currentNotification;
        }


        private void InitializeServiceHost()
        {
            ServiceHost host = new ServiceHost(typeof(MainInstruction), new Uri("http://localhost:8000/Scheduler"));
            host.AddServiceEndpoint(typeof(ISchedulerServiceDataContract<DataForNotification>), new BasicHttpBinding(),
                "");
            host.Open();
        }
    }
}
