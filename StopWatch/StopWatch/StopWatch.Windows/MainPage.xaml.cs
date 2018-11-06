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

namespace StopWatch
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private DispatcherTimer tmr;
        private DateTime startTime;

        // Data Members


        public MainPage()
        {

            this.InitializeComponent();


            tmr = new DispatcherTimer();
            tmr.Interval = new TimeSpan(0, 0, 0, 0, 50);
            tmr.Tick += OnDurationHandler;


        }

        // Pressing the "Start" button
        private void OnStartHandler(object sender, RoutedEventArgs e)
        {

            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;
            startTime = DateTime.Now;
            tmr.Start();

        }

        // Pressing the "Stop" button
        private void OnStopHandler(object sender, RoutedEventArgs e)
        {

            btnStop.IsEnabled = false;
            btnStart.IsEnabled = true;
            tmr.Stop();

        }

        // Timer
        private void OnDurationHandler(object sender, object e)
        {

            TimeSpan Duration = DateTime.Now - startTime;
            txtDuration.Text = Duration.TotalSeconds.ToString("N2");


        }

    }
}
