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

            int firstD = 0;
            int secondD = 0;
            Console.WriteLine("enter 30 numbers with 2 digits");
            for (int i = 1; i <= 30; i++)
            {
                int num;
                if (int.TryParse(Console.ReadLine(), out num)&& (num < 100 && num >= 10))
                {
                    firstD += (num / 10);
                    secondD += (num % 10);


                }
                else
                {
                    Console.WriteLine("Invalide Number");
                    i--;
                }


            }
            Console.WriteLine("Sum of First Digits : " + firstD);
            Console.WriteLine("Sum of Second Digits : " + secondD);

            Console.ReadLine();
        }
    }
}
