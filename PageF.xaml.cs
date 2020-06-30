using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WPFInterfaceElemente
{
    /// <summary>
    /// Klasse die einen Eintrag aus einer Datenbank darstellt
    /// </summary>
    public class EventData
    {
        public DateTime Time { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public string UserName { get; set; }

        public EventData(DateTime pTime, string pText, int pAmount, string pUserName)
        {
            Time = pTime;
            Text = pText;
            Amount = pAmount;
            UserName = pUserName;
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
            // testen ob der Inhalt der Textbox eine gültige Zahl darstellt
            if (!int.TryParse(tbCount.Text, out int count))
            {
                return; // Methodenende falls Konvertierung fehlschlägt
            }
            eventList.Clear();
            // Erstellung von zufälligen Inhalten
            Random randomGen = new Random();
            for (int i = 0; i < count; i++)
            {
                eventList.Add(new EventData(DateTime.Now.AddDays(randomGen.Next(-100, 0)), "Hallo " + i, randomGen.Next(-200, 10000), "Max"));
            }
            // Datenbindung von der Listbox auf das Property (getter und setter) für die Liste, direkte Verbindungen zu Variablen gehen nicht.
            lbContent.ItemsSource = Events;
        }

        private void lbContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // leert die Liste an Inhalten des Textblocks
            tbDetails.Inlines.Clear();

            // durchläuft die Liste aller selektierten Einträge, nur funktionsfähig wenn die ListBox mehrfachauswahl (SelectionMode) zulässt.
            foreach (var item in lbContent.SelectedItems)
            {
                // Eintrag als EventData uminterpetieren
                EventData eventData = item as EventData;

                tbDetails.Inlines.Add("Benutzername : " + eventData.UserName + Environment.NewLine);
                tbDetails.Inlines.Add("Datum der Überweisung :" + eventData.Time + Environment.NewLine);
                if (eventData.Amount >= 0)
                {
                    tbDetails.Inlines.Add("Wert der Überweisung  :" + eventData.Amount + " € " + Environment.NewLine);
                }
                else
                {
                    //Sollte der Betrag kleiner als 0 sein wird über Run ein formatiertes Textelement erzeugt (z.B. mit farbe) und als inhaltselement dem TextBlock angehängt
                    tbDetails.Inlines.Add(new Run("Wert der Überweisung  :" + eventData.Amount + " € " + Environment.NewLine ) { Foreground = Brushes.Red });
                }
                // Run kann alle Eigenschaften des Textes beeinflussen wie in XAML 
                tbDetails.Inlines.Add(new Run("Überweisungskommentar :" + eventData.Text + Environment.NewLine + Environment.NewLine) { FontFamily = new FontFamily("Bahnschrift Light") });
            }
        }
    }
}
