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

namespace Module_6_Lab_09
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

        private void buttonCal_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            if (double.TryParse(textA.Text, out a) 
                && double.TryParse(textB.Text, out b) 
                && double.TryParse(textC.Text, out c))
            {
                if (a<=0 || b<=0 || c<=0)
                {
                    textAlert.Text = "Négative Value";
                }else if (a+b<=c || b+c<=a || c + a <= b)
                {
                    textAlert.Text = "This is not triangle";
                }else
                {
                    double demiP = (a + b + c) / 2;
                    double area = Math.Sqrt(demiP*(demiP-a)*(demiP - b) *(demiP - c));
                    double per = a + b + c;

                    textArea.Text = area.ToString();
                    textPer.Text = per.ToString();
                    textAlert.Text = "";


                    if (a==b && b==c)
                        textAlert.Text = "This is an Equilateral Triangle";

                }

            }
            else
            {
                textAlert.Text = "Wrong Value";
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textPer.Text = "";
            textArea.Text = "";
            textAlert.Text = "";
        }
    }
}
