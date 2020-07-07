using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SQLite;
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
    /// Interaction logic for PageK.xaml
    /// </summary>
    public partial class PageK : Page
    {
        public ObservableCollection<string> ResponseList { get; set; }
        public PageK()
        {
            InitializeComponent();
            ResponseList = new ObservableCollection<string>();
            DataContext = this;
            lvResponse.ItemsSource = ResponseList;
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = @".\Assets\northwindEF.db";
            builder.Version = 3;

            using (SQLiteConnection sqlConnection = new SQLiteConnection(builder.ToString()))
            {
                sqlConnection.Open();
                SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select LastName from Employees;";
                using (SQLiteDataReader sqlResponse = sqlCommand.ExecuteReader())
                {
                    ResponseList.Clear();
                    while (sqlResponse.Read())
                    {
                        ResponseList.Add(sqlResponse.GetString(0));
                    }
                }
            }
        }
    }
}
