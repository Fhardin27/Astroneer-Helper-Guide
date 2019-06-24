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
using System.Windows.Shapes;

namespace Astroneer_Helper_Guide
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

        private void View_Planets_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen.Visibility = Visibility.Collapsed;
            Planets_Screen.Visibility = Visibility.Visible;
        }

        private void Some_Button_Click(object sender, RoutedEventArgs e)
        {
            Planets_Screen.Visibility = Visibility.Collapsed;
            Home_Screen.Visibility = Visibility.Visible;
        }
    }
}
