using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPFInterfaceElemente
{
    /// <summary>
    /// Interaction logic for PageH.xaml
    /// </summary>
    public partial class PageH : Page
    {
        bool leftActive;
        readonly Brush brushInitial;
        readonly Brush brushActive;
        readonly DispatcherTimer timer;

        private int tickrate;

        public int TickRate
        {
            get { return tickrate; }
            set
            {
                // nur anpassungen vornehmen wenn der alte und neue Wert ungleich sind
                if (value != tickrate)
                {
                    tickrate = value;
                    timer.Stop();
                    timer.Interval = TimeSpan.FromMilliseconds(tickrate);
                    timer.Start();
                    lblTickRate.Content = tickrate;
                }
            }
        }


        public PageH()
        {
            InitializeComponent();
            DataContext = this;
            leftActive = true;
            brushInitial = raLeft.Fill;
            brushActive = Brushes.Red;

            timer = new DispatcherTimer(); //Timer erstellen
            timer.Tick += flipColors; //funktion wird beim Tick event eingeklinkt
            TickRate = 100; //Stellt die Zeit ein ... hier über setter zeile 40
        }


        //funktion die ausgelöst werden soll nach zeitablauf
        void flipColors(object sender, EventArgs e)
        {
            leftActive = !leftActive;
            raLeft.Fill = (leftActive ? brushActive : brushInitial);
            raRight.Fill = (!leftActive ? brushActive : brushInitial);
        }
    }
}
