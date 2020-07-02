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

namespace WPFInterfaceElemente
{
    /// <summary>
    /// Interaction logic for PageI.xaml
    /// </summary>
    public partial class PageI : Page
    {

        bool rolled;
        public PageI()
        {
            InitializeComponent();
            rolled = false;
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

            if (!rolled)
            {
                Uri zielAdresse = new Uri("https://www.youtube.com/watch?v=oHg5SJYRHA0", UriKind.Absolute);
                meinWebBrowser.Navigate(zielAdresse);
                rolled = true;

            }
            else
            {
                meinWebBrowser.Navigate("about:blank");
            }
        }



    }
}
