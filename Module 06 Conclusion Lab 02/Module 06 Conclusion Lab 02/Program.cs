using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06_Conclusion_Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a three Digit Number");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                int a = num / 100;
                int b = (num % 100) / 10;
                int c = (num % 10);

                double isStick = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);
                if ((int)isStick == num)
                {
                    Console.WriteLine("The number "+ num + " is a Stickles number");
                }
                else
                {
                    Console.WriteLine("The number " + num + " isn't a Stickles number");
                }

               

            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();




        }

    }
}
