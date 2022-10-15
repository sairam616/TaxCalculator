using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    //Strategy Method
    internal class DiscountRange
    {
        private DiscountStrategy discountStrategy;

        internal void SetDiscountStrategy(DiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }
        internal double Calculate(int discount)
        {
            return discountStrategy.Calculate(discount);
        }
    }

    internal interface DiscountStrategy
    {
        double Calculate(int discount);
    }



    internal class SilverStrategy : DiscountStrategy
    {
        double extra = 0.15;
        public double Calculate(int discount)
        {
            return (discount / 100) + extra;
        }
    }
    internal class GoldStrategy : DiscountStrategy
    {
        double extra = 0.1;
        public double Calculate(int discount)
        {
            return (discount / 100) + extra;
        }
    }
    internal class PlatinumStrategy : DiscountStrategy
    {
        double extra = 0.08;
        public double Calculate(int discount)
        {
            return (discount / 100) + extra;
        }
    }
    internal class DiamondStrategy : DiscountStrategy
    {
        double extra = 0.02;
        public double Calculate(int discount)
        {
            return (discount / 100) + extra;
        }
    }
}
