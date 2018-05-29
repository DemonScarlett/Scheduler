using System.ServiceModel;
using Scheduler.Models;


namespace Scheduler.DataContract
{
    [ServiceContract]
    public interface ISchedulerServiceDataContract<T>
    {
        void AddTask(T newTask);
        void DeleteTask(T task);
        DataForNotification GetData();

    }
}
