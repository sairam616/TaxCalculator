using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    //Factory Method
    internal class CategoryFactory
    {
        internal PCategory GetCategory(string type, float tax)
        {
            switch (type)
            {
                case "HomeAppliances":
                    return new HomeAppliances();
                case "Gadgets":
                    return new Gadgets();
                case "Groceries":
                    return new Groceries();
                case "BedBath":
                    return new BedBath();
                case "Cosmetics":
                    return new Cosmetics();
                default:
                    return new Gadgets();

            }
        }
    }
    internal interface PCategory
    {
        public float getTax();

    }
    internal class HomeAppliances : PCategory
    {

        public float getTax()
        {
            return 0.5F;
        }
    }
    internal class Gadgets : PCategory
    {
        public float getTax()
        {
            return 1.2F;
        }
    }
    internal class Groceries : PCategory
    {
        public float getTax()
        {
            return 0.8F;
        }
    }
    internal class BedBath : PCategory
    {
        public float getTax()
        {
            return 0.4F;
        }
    }
    internal class Cosmetics : PCategory
    {
        public float getTax()
        {
            return 0.6F;
        }
    }


}
