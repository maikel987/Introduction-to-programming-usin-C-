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

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // C'tor
        public MainPage()
        {
            this.InitializeComponent();
        }

        // No need for input validation for now

        // Add
        private void OnAddHandler(object sender, RoutedEventArgs e)
        {
            double n1, n2;
            double.TryParse(tbxNum1.Text,out n1);
            double.TryParse(tbxNum2.Text, out n2);
            txtResult.Text = (n1 + n2).ToString();

        }

        // Subtract
        private void OnSubHandler(object sender, RoutedEventArgs e)
        {
            double n1, n2;
            double.TryParse(tbxNum1.Text, out n1);
            double.TryParse(tbxNum2.Text, out n2);
            txtResult.Text = (n1 - n2).ToString();
        }

        // Multiply
        private void OnMultHandler(object sender, RoutedEventArgs e)
        {
            double n1, n2;
            double.TryParse(tbxNum1.Text, out n1);
            double.TryParse(tbxNum2.Text, out n2);
            txtResult.Text = (n1 * n2).ToString();
        }

        // Divide
        private void OnDivHandler(object sender, RoutedEventArgs e)
        {
            double n1, n2;
            double.TryParse(tbxNum1.Text, out n1);
            double.TryParse(tbxNum2.Text, out n2);
            txtResult.Text = (n1 / n2).ToString();
        }
    }
}
