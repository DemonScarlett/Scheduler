using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Scheduler.DataContract;
using Scheduler.Models;

namespace Scheduler.Service
{
    public class ServiceController
    {
        public ISchedulerServiceDataContract<DataForNotification> ServiceContract { get; set; }
       

        public ServiceController()
        {
            Uri uri = new Uri("http://localhost:8000/Scheduler");
            EndpointAddress address= new EndpointAddress(uri);
           
            ChannelFactory<ISchedulerServiceDataContract<DataForNotification>> channelFactory
                = new ChannelFactory<ISchedulerServiceDataContract<DataForNotification>>(new BasicHttpBinding(), address);

            ServiceContract = channelFactory.CreateChannel();

        }
    }
}
