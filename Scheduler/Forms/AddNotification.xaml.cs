using System;
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
using System.Windows.Shapes;
using Scheduler.Models;
using Scheduler.Service;

namespace Scheduler.Forms
{
    /// <summary>
    /// Interaction logic for AddNotificationWindow.xaml
    /// </summary>
    public partial class AddNotificationWindow : Window
    {
 
        private ServiceController _serviceController;
        private DataForNotification _data;
        
        public AddNotificationWindow(ServiceController serviceController, DataForNotification data)
        {
            //todo add sounds to notif

            InitializeComponent();
            _data = data;
            _serviceController = serviceController;
    
        }

        private void AddNotificationWindowDesign_Loaded(object sender, RoutedEventArgs e)
        {
            NotificationCalendar.SelectedDate = _data.DateAndTime.Date;
            TimeTextBox.Text = _data.DateAndTime.ToShortTimeString();            
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            _serviceController.ServiceContract.AddTask(_data);
        }
    }
}
