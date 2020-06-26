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

        /// <summary>
        /// Erstellt anhand der in tbX und tbY eingestellten Werte Buttons im Grid und nummeriert sie
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Wird ignoriert</param>
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            // leeren der bisherigen inhalte des Grid
            grdGame.ColumnDefinitions.Clear();
            grdGame.RowDefinitions.Clear();
            grdGame.Children.Clear();

            // auslesen der Textboxen und konvertieren in eine Ganzzahl, falls dies nicht klappt wird abgebrochen.
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

            // erstellen von RowDefinitions um später die Buttons daran auszurichten
            for (int i = 0; i < newRows; i++)
            {
                RowDefinition rd = new RowDefinition();
                rd.Height = new GridLength(50);
                grdGame.RowDefinitions.Add(rd); // erstellte RowDefinition an die Liste der Definitionen anhängen.
            }
            for (int i = 0; i < newCols; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(50);
                grdGame.ColumnDefinitions.Add(cd);
            }

            // 2 Dimensionales Zählen um das Grid mit Button zu befüllen, "Für jede Zeile einmal durch alle Spalten"
            for (int y = 0; y < newRows; y++)
            {
                for (int x = 0; x < newCols; x++)
                {
                    Button btn = new Button(); // Button erstellen
                    
                    // Button ausrichten
                    Grid.SetRow(btn, y);
                    Grid.SetColumn(btn, x);

                    // Button in die Liste der Unterobjekte des Grid eintragen
                    grdGame.Children.Add(btn);
                }
            }

            int counter = 0; // zähler für das durchnummerieren der Buttons
            foreach (var item in grdGame.Children.OfType<Button>()) // durch alle Unterobjekte des Grid laufen, aber nur wenn sie ein Button sind
            {
                item.Content = ++counter; //Text auf den Button ersetzen durch den Zähler
            }
        }
        /// <summary>
        /// Reagiert auf den Tastendruck in tbX und tbY und startet die Buttonerstellung sollte die taste ein Enterzeichen sein
        /// </summary>
        /// <param name="sender">Wird an btnCreate_Click weitergeleitet</param>
        /// <param name="e">Die Eventargumente in denen nach einem Enter gesucht wird</param>
        private void tbAxis_KeyEnter(object sender, KeyEventArgs e)
        {
            // falls eine der angeschlossenen Textboxen ein Enter bekommt soll automatisch der Create-button gedückt werden.
            if (e.Key == Key.Return)
            {
                btnCreate_Click(sender, e);
            }
        }
    }
}
