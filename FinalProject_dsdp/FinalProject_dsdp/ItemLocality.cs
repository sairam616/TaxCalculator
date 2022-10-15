using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    internal abstract class ItemLocality : ItemType
    {
        public abstract double GetTax();
    }

    internal class Local : ItemLocality
    {
        private ItemType itemType;
        double tax = 0.02;
        public Local(ItemType itemType)
        {
            this.itemType = itemType;
        }
        public override double GetTax()
        {
            return itemType.GetTax() + tax;
        }
    }

    internal class International : ItemLocality
    {
        private ItemType itemType;
        double tax = 0.05;
        public International(ItemType itemType)
        {
            this.itemType = itemType;
        }
        public override double GetTax()
        {
            return itemType.GetTax() + tax;
        }
    }
}

