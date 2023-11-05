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
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace ToggleDayNight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnT_Checked(object sender, RoutedEventArgs e)
        {
            DockPanel.SetDock(btnS, Dock.Right);
            Uri resourceUri = new Uri("Images/night-sky.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            brush.Stretch = Stretch.UniformToFill;
            btnT.Background = brush;

            resourceUri = new Uri("Images/icons8-moon-48.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(resourceUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            brush.Stretch = Stretch.UniformToFill;
            btnS.Background = brush;

        }

        private void btnT_Unchecked(object sender, RoutedEventArgs e)
        {
            DockPanel.SetDock(btnS, Dock.Left);
            Uri resourceUri = new Uri("Images/Sunny.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            brush.Stretch = Stretch.UniformToFill;
            btnT.Background = brush;

            resourceUri = new Uri("Images/icons8-sun-48.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(resourceUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            brush.Stretch = Stretch.UniformToFill;
            btnS.Background = brush;
        }
    }
}
