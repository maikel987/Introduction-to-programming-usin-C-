using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Item tshirt = new Item();
            Item cigarette = new Item();

            tshirt._basePrice = 15;
            tshirt._discountPourcentage = 33.33;
            cigarette._basePrice = 100;
            cigarette._discountPourcentage = 5;

            Console.WriteLine(tshirt.calculatePrice());
            Console.WriteLine(cigarette.calculatePrice());
            Console.ReadLine();
        }
    }
}
