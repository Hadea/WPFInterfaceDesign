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
    public class EventData
    {
        public DateTime Time { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public EventData(DateTime pTime, string pText, int pAmount)
        {
            Time = pTime;
            Text = pText;
            Amount = pAmount;
        }
    }

    /// <summary>
    /// Interaction logic for PageF.xaml
    /// </summary>
    /// 

    public partial class PageF : Page
    {
        List<EventData> eventList = new List<EventData>();

        public List<EventData> Events
        {
            get { return eventList; }
            private set { eventList = value; }
        }
        public PageF()
        {
            InitializeComponent();


        }

        private void btnLoadList_Click(object sender, RoutedEventArgs e)
        {
            int count;
            if (!int.TryParse(tbCount.Text, out count))
            {
                return;// fast exit if not convertable
            }
            eventList.Clear();
            Random randomGen = new Random();
            for (int i = 0; i < count; i++)
            {
                eventList.Add(new EventData(DateTime.Now.AddDays(randomGen.Next(-100,0)), "Hallo " + i, randomGen.Next(200,10000)));
            }
            lbContent.ItemsSource = Events;
        }
    }
}
