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
    /// Interaction logic for PageB.xaml
    /// </summary>
    public partial class PageB : Page
    {
        public PageB()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            lblAusgabe.Content = "Nutzername: " + tbNutzername.Text + "\nPasswort: " + tbPasswort.Password;
        }
    }
}
