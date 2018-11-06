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

namespace Module_6_Lab_10
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

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textA.Text);
            int b = int.Parse(textB.Text);
            int c = int.Parse(textC.Text);

            if (a >= b)
            {
                textBig.Text = a.ToString();
                textMid.Text = b.ToString();

            }
            else
            {
                textBig.Text = b.ToString();
                textMid.Text = a.ToString();
            }

            if (c>= int.Parse(textBig.Text))
            {
                textSma.Text = textMid.Text;
                textMid.Text = textBig.Text;
                textBig.Text = c.ToString();

            }else if (c>= int.Parse(textMid.Text)) {

                textSma.Text = textMid.Text;
                textMid.Text = c.ToString();

            }else
            {
                textSma.Text = c.ToString();
            }






        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            textBig.Text = "";
            textMid.Text = "";
            textSma.Text = "";

            textA.Text = "";
            textB.Text = "";
            textC.Text = "";
        }
    }
}
