using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFInterfaceElemente
{
    /// <summary>
    /// Interaction logic for PageB.xaml
    /// </summary>
    public partial class PageB : Page
    {
        public PageB()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gibt Nutzernamen und Passwort im Klartext in einem Label aus.
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Wird ignoriert</param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            lblAusgabe.Content = "Nutzername: " + tbNutzername.Text + "\nPasswort: " + tbPasswort.Password;
        }

        /// <summary>
        /// Entfernt die Inhalte aus den Nutzernamen und Passwortfeld.
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Wird ignoriert</param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            tbNutzername.Text = String.Empty;
            tbPasswort.Password = String.Empty;
            lblAusgabe.Content = String.Empty;
        }
    }
}
