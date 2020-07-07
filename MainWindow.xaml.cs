using System.Windows;

namespace WPFInterfaceElemente
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

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnPageG_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageG());
        }



        private void btnPageH_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageH());
        }

        private void btnPageI_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageI());
        }
        private void btnPageJ_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageJ());
        }

        private void btnPageK_Click(object sender, RoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new PageK());
        }
    }
}
