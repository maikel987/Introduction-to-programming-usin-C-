using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_Conclusion_Labs_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;
            int sum = 0;
            int num;
            int counter=-1;
            do
            {


                if (int.TryParse(Console.ReadLine(), out num))
                {
                    sum += num;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalide number");
                }
            } while (num != 0);
            average = (double)sum / counter; 
            Console.WriteLine( "average is : " + Math.Round(average,2).ToString());
            Console.ReadLine();
        }
    }
}
