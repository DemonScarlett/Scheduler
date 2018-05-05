using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduler.Models;

namespace Notification
{
    public partial class NotificationForm : Form
    {
        DataForNotification _dataForNotification = new DataForNotification();
        public NotificationForm(DataForNotification dataForNotifications)
        {
            _dataForNotification = dataForNotifications;
            InitializeComponent();
        }

        private void CommentLable_Click(object sender, EventArgs e)
        {

        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            NameLable.Text = _dataForNotification.Name;
            DateLable.Text = _dataForNotification.DateAndTime.ToShortDateString();
            TimeLable.Text = _dataForNotification.DateAndTime.ToShortTimeString();
            CommentTextBox.Text = _dataForNotification.Comment;

            if (_dataForNotification.Priority == 0)
                 PriorityTextLable.Text ="Низкий";
            if (_dataForNotification.Priority == 1)
                PriorityTextLable.Text = "Средний";
            if (_dataForNotification.Priority == 2)
                PriorityTextLable.Text = "Высокий";

            GroupLable.Text = _dataForNotification.Group;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostponeButton_Click(object sender, EventArgs e)
        {
            //todo write new dateTime to file for next notification (maybe with config file)
        }
    }
}
