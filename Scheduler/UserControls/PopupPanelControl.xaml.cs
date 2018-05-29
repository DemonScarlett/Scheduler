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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scheduler.UserControls
{
    /// <summary>
    /// Interaction logic for PopupPanelControl.xaml
    /// </summary>
    public partial class PopupPanelControl : UserControl
    {
        public bool IsFallOut { get; set; } = false;
        public double DefaultHeight { get; set; } = 35.0;
        public TimeSpan Duration { get; set; } = TimeSpan.FromMilliseconds(100);
        public PopupPanelControl()
        {
            InitializeComponent();
        }

        public void Toggle()
        {           
           if (!IsFallOut)
           {
               Show();
           }
           else
           {
               Hide();
           }
        }

        public void Show()
        {
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = 0;
            animation.To = DefaultHeight;
            animation.Duration = Duration;
            PopupBorder.BeginAnimation(Border.HeightProperty, animation);
            IsFallOut = true;
        }

        public void Hide()
        {
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = DefaultHeight;
            animation.To = 0;
            animation.Duration = Duration;
            PopupBorder.BeginAnimation(Border.HeightProperty, animation);
            IsFallOut = false;
        }
    }
}
