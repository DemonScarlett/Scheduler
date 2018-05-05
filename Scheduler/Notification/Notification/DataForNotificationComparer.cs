using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Models;

namespace Notification
{
    public class DataForNotificationComparer: IEqualityComparer<DataForNotification>
    {
        public bool Equals(DataForNotification x, DataForNotification y)
        {
            var xAsDateAndHours = AsDateHoursAndMinutes(x.DateAndTime);
            var yAsDateAndHours = AsDateHoursAndMinutes(y.DateAndTime);

            return xAsDateAndHours.Equals(yAsDateAndHours);
        }

        private DateTime AsDateHoursAndMinutes(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month,
                dateTime.Day, dateTime.Hour,
                dateTime.Minute, 0);
        }

        public int GetHashCode(DataForNotification obj)
        {
            return AsDateHoursAndMinutes(obj.DateAndTime).GetHashCode();
        }
    }
}
