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

            double max=0;
            Console.WriteLine("enter 15 numbers");
            for (int i = 11; i<=15; i++)
            {
                double num;
                if(double.TryParse(Console.ReadLine(),out num))
                {
                    if (num > max)
                        max = num;

                }
                else
                {
                    Console.WriteLine("Invalide Number");
                        i--;
                }
               

        }
            Console.WriteLine("Greatest Number is: " + max.ToString());
            Console.ReadLine();
        }
    }
}
