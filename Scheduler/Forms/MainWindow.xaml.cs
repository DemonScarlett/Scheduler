﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Scheduler.Forms;
using Scheduler.Helper;
using Scheduler.Models;
using Scheduler.Security;
using Scheduler.Service;

namespace Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<DataForNotification> _dataForNotifications;
        private List<TasksViewModel> _todayTasks;
        // todo return private ServiceController serviceController;
        private DataEncryption encryption;


        //todo Error: priority - not show, comment - empty show, status - I don`t know what do with it, delete - in process...
        public MainWindow()
        {
            
            InitializeComponent();
            _dataForNotifications = new List<DataForNotification>();
            _todayTasks = new List<TasksViewModel>();
            // todo return serviceController = new ServiceController();
            encryption = new DataEncryption();

            //smth temp
           /* TasksViewModel taskTemp = new TasksViewModel();
            taskTemp.Time = "14:10";
            taskTemp.Group = "По дому";
            taskTemp.Name = "Полить цветы";
            taskTemp.Comment = "";
            taskTemp.Priority = "Высокий";
            taskTemp.Status = "Выполнено";
            _todayTasks.Add(taskTemp);

            TasksViewModel taskTemp1 = new TasksViewModel();
            taskTemp1.Time = "18:10";
            taskTemp1.Group = "Работа";
            taskTemp1.Name = "Отчет за неделю";
            taskTemp1.Comment = "";
            taskTemp1.Priority = "Высокий";
            taskTemp1.Status = "Не выполнено";
            _todayTasks.Add(taskTemp1);

            TasksViewModel taskTemp2 = new TasksViewModel();
            taskTemp2.Time = "22:10";
            taskTemp2.Group = "Покупки";
            taskTemp2.Name = "Джинсы";
            taskTemp2.Comment = "Купить синие джинсы на барабашова. В районе 200-300грн";
            taskTemp2.Priority = "Низкий";
            taskTemp2.Status = "Не выполнено";
            _todayTasks.Add(taskTemp2);

            for (int i = 0; i < 3; i++)
            {
                TasksListView.Items.Add(_todayTasks[i]);
            }
               
            //end*/

            //todo anchors

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddTask form = new AddTask(/*serviceController*/);
            form.ShowDialog();
            
        }
     

        private void GroupButton_Click(object sender, RoutedEventArgs e)
        {
            GroupsWindow form = new GroupsWindow();
            form.Show();
            this.Close();
        }

        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
           /* CalendarWindow form = new CalendarWindow();
            form.Show();
            this.Close();*/
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            /* SettingWindow form = new SettingWindow();
            form.Show();
            this.Close();*/
        }

     
        private void TasksListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem item = TasksListView.SelectedItem as ListViewItem;
        }

        private void MainWindowFormGrid_Loaded(object sender, RoutedEventArgs e)
        {
            _dataForNotifications = encryption.ReadFileEncrypted(DataEncryption.TaskType.Task);
            foreach (var data in _dataForNotifications)
            {
                _todayTasks.Add(DataForNotificationConverter.ConvertToDisplay(data));
            }
            
            for (int i = 0; i < _todayTasks.Count; i++)
            {
                TasksListView.Items.Add(_todayTasks[i]);
            }
        }
    }
}
