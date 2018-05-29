using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Models;

namespace Scheduler.Helper
{
    public static class DataForNotificationConverter
    {
        public static TasksViewModel ConvertToDisplay(DataForNotification inputData)
        {
            TasksViewModel displayData = new TasksViewModel();
            displayData.Name = inputData.Name;
            displayData.Date = inputData.DateAndTime.ToShortDateString();
            displayData.Time = inputData.DateAndTime.ToShortTimeString();
            displayData.Comment = inputData.Comment;
            displayData.Group = inputData.Group;

            if (inputData.Priority == 0)
                displayData.Priority = "Низкий";
            if (inputData.Priority == 1)
                displayData.Priority = "Средний";
            if (inputData.Priority == 2)
                displayData.Priority = "Высокий";

            displayData.Status = inputData.Status == true? "Выполнено":"";

            return displayData;
        }
    }
}
