using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    /// Interaction logic for PageJ.xaml
    /// </summary>
    public partial class PageJ : Page
    {

        ObservableCollection<string> dataListObservable;
        List<string> dataListNormal;

        private string textBuffer;
        public string TextElement
        {
            get
            {
                return textBuffer;
            }
            set
            {
                textBuffer = value;
                lblTextElementAusgabe.Content = value;
            }
        }

        public PageJ()
        {
            InitializeComponent();
            dataListObservable = new ObservableCollection<string>
            {
                "testA",
                "testB",
                "testC",
                "testD"
            };
            dataListNormal = dataListObservable.ToList();

            lstDataViewObservable.ItemsSource = dataListObservable;
            lstDataViewNormal.ItemsSource = dataListNormal;

            DataContext = this;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            string jetzt = DateTime.Now.ToString();
            dataListObservable.Add("neu " + jetzt);
            dataListNormal.Add("neu " + jetzt);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lstDataViewNormal.ItemsSource = null;
            lstDataViewNormal.ItemsSource = dataListNormal;
        }
    }
}
