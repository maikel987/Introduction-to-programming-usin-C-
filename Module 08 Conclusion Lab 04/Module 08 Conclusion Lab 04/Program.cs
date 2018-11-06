using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_Conclusion_Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 1;
            string fiboTwenty = a.ToString() + " " + b.ToString();
            for (int i = 1; i <= 20-2; i++)
            {
                int c = a + b;
                fiboTwenty += " " + c;
                a = b;
                b = c;
            
            }
            Console.WriteLine(fiboTwenty.ToString());
            Console.ReadLine();



            string fiboTenTh = "";
            int one = 1, two = 1, three = 2;
            fiboTenTh = one.ToString() + " " + two.ToString();
            
            while ( three < 10000)
            {
                fiboTenTh += " " + three;

                one = two;
                two = three;
                three = one + two;


            }
            Console.WriteLine(fiboTenTh.ToString());
            Console.ReadLine();

        }
    }
}
