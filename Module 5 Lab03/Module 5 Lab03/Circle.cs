using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab03
{
    class Circle
    {
        public double _radius;
        public string _color;
        public string _name;




        public string description()
        {
            double surface = Math.PI * Math.Pow(_radius, 2);
            return "Circle " + _name + " is of " 
                    + _color + " color and size " 
                    + Math.PI * Math.Pow(_radius, 2);
            
        }
    }
}


