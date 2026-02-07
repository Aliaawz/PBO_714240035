using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240035
{
    class ProductTest_123
    {
        static void Main(string[] args)
        {
            Book_714240035 product1 = new Book_714240035("Book", "C# Object Oriented Solution", "300");
            DVD_123 product2 = new DVD_123("Eternal Sunshine of the Spotless Mind", "143");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}

