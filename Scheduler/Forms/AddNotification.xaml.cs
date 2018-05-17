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

namespace Scheduler.Forms
{
    /// <summary>
    /// Interaction logic for AddNotificationWindow.xaml
    /// </summary>
    public partial class AddNotificationWindow : Window
    {
        public AddNotificationWindow()
        {
            //todo add sounds to notif
            //todo поставить дату и время по умолчанию такими же, как на предыдущей форме
            InitializeComponent();
        }
    }
}
