using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Opasity_Timer_ProgrBar
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Category { get; set; }

        public bool IsFreeShiping { get; set; }

        public override string ToString()
        {
            string free = IsFreeShiping ? "free shipping" : "paid shipping";
            return Name + "  " + Category + "  " + Price.ToString() + free;
        }

    }
}
