using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_Conclusion_Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 0;

            if (int.TryParse(Console.ReadLine(), out num))
            {
                while (num%2 ==0)
                {
                    counter++;
                    num = num / 2;
                }


            }else
            {
                Console.WriteLine("wrong number");
            }
            Console.WriteLine("this number is divisible " + counter + " time.");
            Console.ReadLine();
        }
    }
}
