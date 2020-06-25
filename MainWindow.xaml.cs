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

namespace InterfaceElemente
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

        private void btnPageA_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageA());
        }

        private void btnPageB_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageB());

        }

        private void btnPageC_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageC());
        }

        private void btnPageD_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageD());
        }

        private void btnPageE_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageE());
        }

        private void btnPageF_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageF());
        }
    }
}
