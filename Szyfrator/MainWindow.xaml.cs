using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Szyfrator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationService nav;

        public MainWindow()
        {
            nav = NavigationService.GetNavigationService(this);
            InitializeComponent();
        }

        private void Button_FromScreen_Click(object sender, RoutedEventArgs e)
        {
            var WFromScreen = new FromScreen();
            WFromScreen.Show();
            this.Close();
        }

        private void Button_FromFile_Click(object sender, RoutedEventArgs e)
        {
            var WFromFile = new FromFile();
            WFromFile.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                window.Close();
            }
            Application.Current.Shutdown();
        }
    }
}
