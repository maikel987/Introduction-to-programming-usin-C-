using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab02
{
    class Item
    {
        public double _basePrice;
        public double _discountPourcentage;

        public double calculatePrice()
        {
            return _basePrice * (100 -_discountPourcentage) / 100;
        }
    }
}
