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

namespace Module_6_Lab07
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
            int num1 = int.Parse(textBox.Text);
            int num2 = int.Parse(textBox1.Text);
            int num3 = int.Parse(textBox2.Text);

            textBlock.Text = "Max Value is: " 
                + Math.Max(Math.Max(num1, num2), num3).ToString();


            if (num1 == num2 || num2 == num3 || num3 == num1)
            {
                textBlock1.Text = "There are a repeated number!";
            }
            else
            {
                textBlock1.Text = "No repeated number!";
            }


        }

    }
}
