using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Module03_ConclusionLab01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void rbYellow_Checked(object sender, RoutedEventArgs e)
        {
            rect.Fill = rbYellow.Background;
        }

        private void rbRed_Checked(object sender, RoutedEventArgs e)
        {
            rect.Fill = rbRed.Background;
        }

        private void rbBlue_Checked(object sender, RoutedEventArgs e)
        {
            rect.Fill = rbBlue.Background;
        }

        private void rbGreen_Checked(object sender, RoutedEventArgs e)
        {
            rect.Fill = rbGreen.Background;
        }

        private void btnLarger_Click(object sender, RoutedEventArgs e)
        {
            rect.Height = rect.Height + 10;
            rect.Width = rect.Width + 10;
        }

        private void btnSmaller_Click(object sender, RoutedEventArgs e)
        {
            rect.Height = rect.Height - 10;
            rect.Width = rect.Width - 10;
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(rect, Canvas.GetTop(rect) - 10);
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(rect, Canvas.GetTop(rect) + 10);
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(rect, Canvas.GetLeft(rect) - 10);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(rect, Canvas.GetLeft(rect) + 10);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
