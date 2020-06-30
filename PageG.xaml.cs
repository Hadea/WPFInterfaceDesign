using System.Windows.Controls;

namespace WPFInterfaceElemente
{

    /// <summary>
    /// Interaction logic for PageG.xaml
    /// </summary>
    public partial class PageG : Page
    {
        public PageG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wird ausgelöst solange die Maus über dem 3D-Viewport ist. Dies passiert einmal pro Frame.
        /// </summary>
        /// <param name="sender">Wird ignoriert</param>
        /// <param name="e">Daten zur Maus</param>
        private void vpView_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // die Mausposition über dem Viewport wird direkt in die Rotation um die X achse gesteckt.
            vpRotation.Angle = e.GetPosition(vpView).X;
        }
    }
}
