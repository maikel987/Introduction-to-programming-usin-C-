using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle planet = new Circle();
            planet._radius = 6400;
            planet._name = "earth";
            planet._color = "Blue";
            Console.WriteLine(planet.description());

            Circle disc = new Circle();
            disc._radius = 45;
            disc._name = "disco";
            disc._color = "Black";
            Console.WriteLine(disc.description());

            Circle boomerang = new Circle();
            boomerang._radius = 6;
            boomerang._name = "miego";
            boomerang._color = "Yellow";
            Console.WriteLine(boomerang.description());

            Console.ReadLine();
        }
    }
}
