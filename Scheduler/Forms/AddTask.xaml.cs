using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Scheduler.Models;
using Scheduler.Security;
using Scheduler.Service;

namespace Scheduler.Forms
{
    /// <summary>
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        // todo return private ServiceController _serviceController;
        private DataForNotification _data;

        public AddTask(/*ServiceController serviceController*/)
        {
            // todo return  _serviceController = serviceController;
            _data = new DataForNotification();

            InitializeComponent();

            // Default values
            NotificationDatePicker.SelectedDate = DateTime.Now;
            PriorityComboBox.SelectedIndex = 0;

            //AddNotificationButton.IsEnabled = false;
        }

        private void AddNotificationButton_Click(object sender, RoutedEventArgs e)
        {
            //todo create separate methods
           InitializeComponent();
            // todo return AddNotificationWindow form = new AddNotificationWindow( _serviceController, _data);
            // todo return form.ShowDialog();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
           InitializeComponent();
            DataEncryption workingWithFile = new DataEncryption();
            workingWithFile.WriteToFileEnrypted(_data, DataEncryption.TaskType.Task);
            this.Close();
        }

        private void InitializeData()
        {
            if (!String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(TimeTextBox.Text))
            {
                //todo groups division
                _data.Name = NameTextBox.Text;
                _data.DateAndTime = DateTime.Parse(NotificationDatePicker.SelectedDate + TimeTextBox.Text);
                _data.Priority = Byte.Parse(PriorityComboBox.SelectedIndex.ToString());
                string comment = new TextRange(CommentTextBox.Document.ContentStart, CommentTextBox.Document.ContentEnd).Text;
                if (!String.IsNullOrEmpty(comment)) _data.Comment = comment;
            }
            else
            {
                //todo Own MessageBox
                MessageBox.Show("Заполните все поля не отмеченные звездочкой", "Пустое поле", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void AddTaskForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
