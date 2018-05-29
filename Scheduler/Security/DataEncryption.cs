using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Models;

namespace Scheduler.Security
{
    public class DataEncryption
    {
        private string NotificationfileName = Environment.CurrentDirectory + @"\notificationData.ntfd";
        private string TaskfileName = Environment.CurrentDirectory + @"\taskData.ntfd";

        public enum TaskType
        {
            Notification,
            Task
        };

 
        public void WriteToFileEnrypted(DataForNotification dataForNotification, TaskType taskType)
        {
            string fileName;

            fileName = taskType == TaskType.Notification ? NotificationfileName : TaskfileName;

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("02052018");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("02052018");

            CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] data = ASCIIEncoding.ASCII.GetBytes(dataForNotification.Name + "/"
                                                                                + dataForNotification.DateAndTime + "/"
                                                                                + dataForNotification.Comment + "/"
                                                                                + dataForNotification.Group + "/"
                                                                                + dataForNotification.Priority
                                                                                + dataForNotification
                                                                                    .DateandTimeOfNotification + "/"
                                                                                + dataForNotification.Status
                                                                                + dataForNotification.IsNotification + "/"
                                                                                + dataForNotification.Sound);
                                                                                

            crStream.Write(data, 0, data.Length);

            crStream.Close();
            stream.Close();
        }

        public List<DataForNotification> ReadFileEncrypted(TaskType taskType)
        {
            List<DataForNotification> result = new List<DataForNotification>();

            string fileName;

            fileName = taskType == TaskType.Notification ? NotificationfileName : TaskfileName;

            FileStream stream = new FileStream(fileName,
                FileMode.Open, FileAccess.Read);

            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("02052018");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("02052018");

            CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateDecryptor(), CryptoStreamMode.Read);

            StreamReader reader = new StreamReader(crStream);

            while (!reader.EndOfStream)
            {
                string data = reader.ReadLine();

                string[] array = data.Split('/');

                DataForNotification dataFromArray = new DataForNotification();

                dataFromArray.Name = array[0];
                dataFromArray.DateAndTime = DateTime.Parse(array[1]);
                dataFromArray.Comment = array[2];
                dataFromArray.Group = array[3];
                dataFromArray.Priority = Byte.Parse(array[4]);
                dataFromArray.DateandTimeOfNotification = DateTime.Parse(array[5]);
                dataFromArray.Status = Boolean.Parse(array[6]);
                dataFromArray.IsNotification = Boolean.Parse(array[7]);
                dataFromArray.Sound = array[8];

                result.Add(dataFromArray);
            }
           
            reader.Close();
            stream.Close();

            return result;
        }
    }
}
