using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    internal interface ItemType
    {
        double GetTax();
    }

    internal class Brand : ItemType
    {
        double tax = 0.05;

        public double GetTax()
        {
            return tax;
        }
    }
    internal class NonBrand : ItemType
    {
        double tax = 0.02;
        public double GetTax()
        {
            return tax;
        }
    }
}
