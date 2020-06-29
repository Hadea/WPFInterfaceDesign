using System.Windows;
using System.Windows.Controls;

namespace WPFInterfaceElemente
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
