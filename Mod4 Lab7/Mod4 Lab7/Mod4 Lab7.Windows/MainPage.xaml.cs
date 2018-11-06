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

namespace Mod4_Lab7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            const double inches = 39.3701;
            const double yards = 1.09361;
            const double miles = 0.000621371;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            const double inches = 39.3701;
            const double yards = 1.09361;
            const double miles = 0.000621371;


            tmeter.Text = textBox.Text;
            tinches.Text = (double.Parse(textBox.Text)*inches).ToString();
            tyards.Text = (double.Parse(textBox.Text)*yards).ToString();
            tmiles.Text = (double.Parse(textBox.Text)*miles).ToString();


        }
    }
}
