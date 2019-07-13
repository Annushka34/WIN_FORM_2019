using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FileDialogs
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
