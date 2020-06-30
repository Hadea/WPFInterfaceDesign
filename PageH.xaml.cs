using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
                    timer.Interval = TimeSpan.FromSeconds(tickrate/100);
                    timer.Start();
                }
            }
        }


        public PageH()
        {
            InitializeComponent();
            leftActive = true;
            brushInitial = raLeft.Fill;
            brushActive = Brushes.Red;

            timer = new DispatcherTimer();
            timer.Tick += flipColors;
            TickRate = 100;
        }



        void flipColors(object sender, EventArgs e)
        {
            leftActive = !leftActive;
            raLeft.Fill = (leftActive ? brushActive : brushInitial);
            raRight.Fill = (!leftActive ? brushActive : brushInitial);
        }
    }
}
