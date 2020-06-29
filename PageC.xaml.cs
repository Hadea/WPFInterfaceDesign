using System;
using System.Windows;
using System.Windows.Controls;

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

        /// <summary>
        /// Zeigt die ID des Eintrags an welcher gewählt wurde
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Wird ignoriert</param>
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null && lblAusgabe != null)
            {
                lblAusgabe.Content = "Es wurde der Eintrag mit der ID " + comboBox.SelectedIndex + " gewählt";
            }
        }

        /// <summary>
        /// Zeigt das gewählte Datum im Label an.
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Wird ignoriert</param>
        private void dpDate_CalendarClosed(object sender, RoutedEventArgs e)
        {
            lblAusgabe.Content = "Tag  : " + dpDate.SelectedDate.Value.Day
                + Environment.NewLine + "Monat: " + dpDate.SelectedDate.Value.Month
                + Environment.NewLine + "Jahr : " + dpDate.SelectedDate.Value.Year
                + Environment.NewLine + "Wochentag " + dpDate.SelectedDate.Value.DayOfWeek.ToString();

        }

        /// <summary>
        /// Zeigt die anzahl der gewählten elemente im Label an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItems != null && lblAusgabe != null)
            {
                lblAusgabe.Content = "Es wurden " + listBox.SelectedItems.Count + " Elemente ausgewählt";
            }
        }
    }
}
