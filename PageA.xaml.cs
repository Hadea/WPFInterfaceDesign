using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for PageA.xaml
    /// </summary>
    public partial class PageA : Page
    {
        public PageA()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageB());
        }
    }
}
