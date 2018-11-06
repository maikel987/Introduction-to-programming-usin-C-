using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {

            string neg = "";
            Console.WriteLine("enter 40 numbers");
            for (int i = 1; i <= 40; i++)
            {
                double num;
                if (double.TryParse(Console.ReadLine(), out num))
                {
                    if (num < 0)
                        neg = neg + ", " + num;

                }
                else
                {
                    Console.WriteLine("Invalide Number");
                    i--;
                }


            }
            Console.WriteLine("Negative Number are: " + neg);
            Console.ReadLine();
        }
    }
}
