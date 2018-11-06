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

namespace Module4_Lab5
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            textPlus.Text = ((double)a + b).ToString();
              

        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            textMinus.Text = ((double)a - b).ToString();

        }

        private void buttonmult_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            textMult.Text = ((double)a * b).ToString();

        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            textDiv.Text = ((double)a / b).ToString();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            textDiv.Text = "";
            textMult.Text = "";
            textMinus.Text = "";
            textPlus.Text = "";
        }
    }
}
