using System.Collections.ObjectModel;
using System.Data.SQLite; // Namespace wird über das Package "System.Data.SQLite.Core" bereitgestellt. Das Core am ende besagt das es nur die Basisfunkitonalität bereitstellt ohne Entity Framework oder LINQ.
using System.Windows;
using System.Windows.Controls;

namespace WPFInterfaceElemente
{
    /// <summary>
    /// Interaction logic for PageK.xaml
    /// </summary>
    public partial class PageK : Page
    {
        public ObservableCollection<string> ResponseList { get; set; } //die Collection welche die Daten aus der Datenbank aufnehmen soll
        public PageK()
        {
            InitializeComponent();
            ResponseList = new ObservableCollection<string>(); // beim Start des Programms wird eine neue Collection erstellt und kann später durch die Datenbank befüllt werden
            lvResponse.ItemsSource = ResponseList; // verbindet die ListView welche im XAML erstellt wurde mit der Collection. Da diese Observable ist werden einfüge und löschoperationen auch dem GUI mitgeteilt.
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(); // Der Stringbuilder hilft dabei den connectionstring zu erstellen falls man unsicher ist bei der Erstellung.
            builder.DataSource = @".\Assets\northwindEF.db"; // Pfad zu der Datenbank, hier ist er relativ zur .exe Datei angegeben. Im Projekt muss die Datenbank-Datei auf Copy gestellt werden damit sie auch im Zielordner der .exe Datei ankommt.
            builder.Version = 3; // Version der Datenbankdatei. Falls unbekannt einfach die Datei mit einem Text-Editor öffnen und nachschauen.

            using (SQLiteConnection sqlConnection = new SQLiteConnection(builder.ToString())) // Bereitet die Verbindung mit der Datenbank vor anhand der Informationen aus dem connectionstring
            {
                sqlConnection.Open(); // startet die Verbindung
                SQLiteCommand sqlCommand = sqlConnection.CreateCommand(); // Bereitet ein neues SQL-Kommando vor passend auf die Datenbankverbindung
                sqlCommand.CommandText = "select LastName from Employees;"; // Der SQL befehl.
                using (SQLiteDataReader sqlResponse = sqlCommand.ExecuteReader()) // Befehl wird an die Datenbank gesendet und eine rückgabe in tabellenform wird erwartet
                {
                    ResponseList.Clear(); // alle alten Einträge aus Sammlung entfernen
                    while (sqlResponse.Read()) // Solange noch Zeilen in der antwort vom Datenbankserver stehen weiterlesen
                    {
                        ResponseList.Add(sqlResponse.GetString(0)); // Zeileninhalt in die Collection einfügen.
                    }
                }
            }
        }
    }
}
