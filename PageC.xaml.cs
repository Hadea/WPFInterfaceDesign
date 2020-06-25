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
    /// Interaction logic for PageC.xaml
    /// </summary>
    public partial class PageC : Page
    {
        public PageC()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null && lblAusgabe != null)
            {
                lblAusgabe.Content = comboBox.SelectedItem;

            }
        }
    }
}
