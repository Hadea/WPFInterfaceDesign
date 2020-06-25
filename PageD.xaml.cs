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
    enum FlipState
    {
        Empty,
        Image,
        Text
    }

    /// <summary>
    /// Interaction logic for PageD.xaml
    /// </summary>
    public partial class PageD : Page
    {
        FlipState stateMultiflip = FlipState.Empty;

        public PageD()
        {
            InitializeComponent();
        }

        private void btnFlipText_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnFlipText.Content == "")
            {
                btnFlipText.Content = "XXXX";
            }
            else
            {
                btnFlipText.Content = String.Empty;
            }
        }

        private void btnFlipImage_Click(object sender, RoutedEventArgs e)
        {
            imgFlipImage.Visibility = (imgFlipImage.Visibility == Visibility.Visible ?Visibility.Hidden:Visibility.Visible);
        }

        private void btnFlipTextImage_Click(object sender, RoutedEventArgs e)
        {
            imgFlipTextImage.Visibility = (imgFlipTextImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible);
            lblFlipTextImage.Visibility = (imgFlipTextImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible);
        }

        private void btnFlipTextImageEmpty_Click(object sender, RoutedEventArgs e)
        {
            switch (stateMultiflip)
            {
                case FlipState.Empty:
                    stateMultiflip = FlipState.Image;
                    imgFlipTextImageEmpty.Visibility = Visibility.Visible;
                    lblFlipTextImageEmpty.Visibility = Visibility.Collapsed;
                    break;
                case FlipState.Image:
                    stateMultiflip = FlipState.Text;
                    imgFlipTextImageEmpty.Visibility = Visibility.Collapsed;
                    lblFlipTextImageEmpty.Visibility = Visibility.Visible;
                    break;
                case FlipState.Text:
                    stateMultiflip = FlipState.Empty;
                    imgFlipTextImageEmpty.Visibility = Visibility.Collapsed;
                    lblFlipTextImageEmpty.Visibility = Visibility.Collapsed;
                    break;
            }


        }
    }
}
