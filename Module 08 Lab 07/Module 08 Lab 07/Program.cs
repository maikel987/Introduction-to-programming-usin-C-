using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string serie = "";
            int counter;
        if (int.TryParse(Console.ReadLine(),out counter))
            {
                serie = serie + counter;
            }else
            {
                Console.WriteLine("Invalide Number");

            }
            for (int i = 0; i < counter; i++)
            {
                double value;
                if(double.TryParse(Console.ReadLine(), out value))
                {
                    serie = serie + ", " + value.ToString();
                }
                else
                {
                    Console.WriteLine("Invalide Number");
                    i--;
                }

            }
            Console.WriteLine(serie);
            Console.ReadLine();
        }
    }
}
