using System;
using System.Collections;
using System.Collections.Generic;

namespace FinalProject_dsdp
{
    class Program
    {
        static void Main(string[] args)
        {
            double ProductTax = 0;
            Console.WriteLine("***Welcome to E-Commerce App***");
            Console.WriteLine("Enter your name to proceed");
            string name = Console.ReadLine();
            //Array List
            List<User> users = new List<User>();
            int flag = 0;
            foreach (var info in users)
            {
                if (info.Name == name)
                {
                    Console.WriteLine("Already a registered User.");
                    flag = 1;
                }
                else
                {
                    continue;
                }
            }
            if (flag != 1)
            {
                Console.WriteLine("Seems Like a New User, Enter Your Details:");
                Console.WriteLine("Name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string Email = Console.ReadLine();
                Console.WriteLine("Phone: ");
                long Phone = long.Parse(Console.ReadLine());

                User u = new User(Name, Email, Phone);
                users.Add(u);
                flag = 1;
            }
            if (flag == 1)
            {
                //Singleton instance
                Category categories = Category.GetInstance(name);
                //Hashset
                HashSet<string> category = categories.GetCategories();
                foreach (var item in category)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Select a Category from which you want to buy a product:");
            int catgry = Int32.Parse(Console.ReadLine());

            //HashTable
            Hashtable exampleProducts = new Hashtable();
            exampleProducts.Add(1, "Example Products: Rice Cooker, Induction Stove, Microwave, Fridge etc.");
            exampleProducts.Add(2, "Example Products: Mobiles, Watches, Airpods, Power Banks, Smart T.V etc.");
            exampleProducts.Add(3, "Example Products: Rice Bags, Milk, Onions, Flour, Yougurt etc.");
            exampleProducts.Add(4, "Example Products: Bed, Comforter, Shower gel, Towels, pillows etc.");
            exampleProducts.Add(5, "Example Products: Deodrants, Perfumes, Facial gel, Other Makeup Products etc.");

            //Factory Instance
            CategoryFactory cf = new CategoryFactory();
            float CategoryTax;
            switch (catgry)
            {
                case 1:
                    PCategory c1 = cf.GetCategory("HomeAppliances", 13);
                    CategoryTax = c1.getTax();
                    break;
                case 2:
                    PCategory c2 = cf.GetCategory("Gadgets", 15);
                    CategoryTax = c2.getTax();
                    break;
                case 3:
                    PCategory c3 = cf.GetCategory("Groceries", 5);
                    CategoryTax = c3.getTax();
                    break;
                case 4:
                    PCategory c4 = cf.GetCategory("BedBath", 9);
                    CategoryTax = c4.getTax();
                    break;
                case 5:
                    PCategory c5 = cf.GetCategory("Cosmetics", 10);
                    CategoryTax = c5.getTax();
                    break;
                default:
                    PCategory c6 = cf.GetCategory("Gadgets", 15);
                    CategoryTax = c6.getTax();
                    break;
            }
            Console.WriteLine(exampleProducts[catgry]);
            ProductTax = ProductTax + CategoryTax;
            //Console.WriteLine("CategoryTax:"+ CategoryTax);

            Console.WriteLine("Select the discount range for the product:");
            string[] discounts = { "1. <25%", "2. 25-50%", "3. 50-75%", "4. >75%" };
            //hashset
            HashSet<string> discountMenu = new HashSet<string>(discounts);
            foreach (var item in discountMenu)
            {
                Console.WriteLine(item);
            }
            int discount = Int32.Parse(Console.ReadLine());



            //Strategy Instance
            DiscountRange discountRange = new DiscountRange();
            Random rand = new Random();
            double DiscountOffer = 0;
            switch (discount)
            {
                case 1:
                    DiscountStrategy strategy1 = new SilverStrategy();
                    discountRange.SetDiscountStrategy(strategy1);
                    int silver = rand.Next(5, 25);
                    DiscountOffer = discountRange.Calculate(silver);
                    break;
                case 2:
                    DiscountStrategy strategy2 = new GoldStrategy();
                    discountRange.SetDiscountStrategy(strategy2);
                    int gold = rand.Next(25, 50);
                    DiscountOffer = discountRange.Calculate(gold);
                    break;
                case 3:
                    DiscountStrategy strategy3 = new PlatinumStrategy();
                    discountRange.SetDiscountStrategy(strategy3);
                    int platinum = rand.Next(50, 75);
                    DiscountOffer = discountRange.Calculate(platinum);
                    break;
                case 4:
                    DiscountStrategy strategy4 = new DiamondStrategy();
                    discountRange.SetDiscountStrategy(strategy4);
                    int diamond = rand.Next(75, 90);
                    DiscountOffer = discountRange.Calculate(diamond);
                    break;
                default:
                    DiscountStrategy strategy5 = new PlatinumStrategy();
                    discountRange.SetDiscountStrategy(strategy5);
                    int defaultDiscount = rand.Next(50, 75);
                    DiscountOffer = discountRange.Calculate(defaultDiscount);
                    break;
            }

            Console.WriteLine("Select the type of the product:");
            string[] ProductType = { "1. Branded & Local", "2. Branded & International", "3. Non-Branded & Local", "4. Non-Branded & International" };
            HashSet<string> typeMenu = new HashSet<string>(ProductType);
            double TypeTax = 0;
            foreach (var item in typeMenu)
            {
                Console.WriteLine(item);
            }


            //Decorator
            ProductType ptype = new ProductType();
            string itemName;
            int itemPrice;
            //Decorator Instances
            int type = Int32.Parse(Console.ReadLine());
            if (type == 1 || type == 2)
            {
                ItemType myBrand = new Brand();
                if (type == 1)
                {
                    myBrand = new Local(myBrand);
                    TypeTax = myBrand.GetTax();
                    string itemType = "LBrand";
                    //Sorted Set
                    ptype.Display(itemType);
                    Console.WriteLine("Select a product to get Sample Price. [Enter the name]");
                    itemName = Console.ReadLine();
                    //Dictionary
                    itemPrice = ptype.GetPrice(itemName, itemType);
                    Console.WriteLine(itemName + " Price is: " + itemPrice);

                }
                else
                {
                    myBrand = new International(myBrand);
                    TypeTax = myBrand.GetTax();
                    string itemType = "IBrand";
                    //Sorted Set
                    ptype.Display(itemType);
                    Console.WriteLine("Select a product to get Sample Price.");
                    itemName = Console.ReadLine();
                    //Dictionary
                    itemPrice = ptype.GetPrice(itemName, itemType);
                    Console.WriteLine(itemName + " Price is: " + itemPrice);
                }

            }
            if (type == 3 || type == 4)
            {
                ItemType myNonBrand = new NonBrand();
                if (type == 3)
                {
                    myNonBrand = new Local(myNonBrand);
                    TypeTax = myNonBrand.GetTax();
                    string itemType = "LNBrand";
                    //Sorted Set
                    ptype.Display(itemType);
                    Console.WriteLine("Select a product to get Sample Price.");
                    itemName = Console.ReadLine();
                    //Dictionary
                    itemPrice = ptype.GetPrice(itemName, itemType);
                    Console.WriteLine(itemName + " Price is: " + itemPrice);
                }
                else
                {
                    myNonBrand = new International(myNonBrand);
                    TypeTax = myNonBrand.GetTax();
                    string itemType = "INBrand";
                    //Sorted Set
                    ptype.Display(itemType);
                    Console.WriteLine("Select a product to get Sample Price.");
                    itemName = Console.ReadLine();
                    //Dictionary
                    itemPrice = ptype.GetPrice(itemName, itemType);
                    Console.WriteLine(itemName + " Price is: " + itemPrice);
                }
            }
            ProductTax = ProductTax + TypeTax;
            Console.WriteLine("Enter the Market Retail Price to Know the Tax:");
            double ProductPrice = double.Parse(Console.ReadLine());
            ProductTax = ProductTax * ProductPrice;
            Console.WriteLine("The Tax on the product will be: " + ProductTax);

            DiscountOffer = DiscountOffer * ProductPrice;

            Console.WriteLine("The Savings on the product will be: " + DiscountOffer);

            ProductPrice = ProductPrice + ProductTax - DiscountOffer;
            Console.WriteLine("The Final Price You Have to pay for the Product is:" + ProductPrice);
        }
    }
}