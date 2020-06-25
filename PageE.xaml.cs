using System;
using System.Collections.Generic;
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

namespace InterfaceElemente
{
    /// <summary>
    /// Interaction logic for PageE.xaml
    /// </summary>
    public partial class PageE : Page
    {
        public PageE()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            grdGame.ColumnDefinitions.Clear();
            grdGame.RowDefinitions.Clear();
            grdGame.Children.Clear();

            int newRows;
            if (!int.TryParse(tbY.Text, out newRows))
            {
                tbY.BorderBrush = Brushes.Red;
                return;
            }
            int newCols;
            if (!int.TryParse(tbX.Text, out newCols))
            {
                tbX.BorderBrush = Brushes.Red;
                return;
            }

            for (int i = 0; i < newRows; i++)
            {
                RowDefinition rd = new RowDefinition();
                rd.Height = new GridLength(50);
                grdGame.RowDefinitions.Add(rd);
            }
            for (int i = 0; i < newCols; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(50);
                grdGame.ColumnDefinitions.Add(cd);
            }

            for (int y = 0; y < newRows; y++)
            {
                for (int x = 0; x < newCols; x++)
                {
                    Button btn = new Button();
                    Grid.SetRow(btn,y);
                    Grid.SetColumn(btn,x);
                    grdGame.Children.Add(btn);
                }
            }

            int counter = 0;
            foreach (var item in grdGame.Children.OfType<Button>())
            {
                item.Content = ++counter;
            }
        }
    }
}
