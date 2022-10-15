using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    public class ProductType
    {

        public ProductType()
        {

        }
        public void Display(string type)
        {
            Console.WriteLine("Sample products in the following Category.");
            if (type == "LBrand")
            {
                string[] LBproducts = { "1.Xiomi mobile", "2.Fogg Deo", "3.Kissan Jam", "4.Onida Tv", "5.Bombay Dyeing Bed and Bath " };
                SortedSet<string> LB = new SortedSet<string>();
                foreach (var item in LBproducts)
                {
                    LB.Add(item);
                }
                foreach (var item in LB)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            else if (type == "IBrand")
            {
                string[] IBproducts = { "1.Apple Mobile", "2.London Perfume", "3.Heins Ketchup", "4.Samsung Tv", "5.Amazon Basics Bed and Bath " };
                SortedSet<string> IB = new SortedSet<string>();
                foreach (var item in IBproducts)
                {
                    IB.Add(item);
                }
                foreach (var item in IB)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (type == "LNBrand")
            {
                string[] LNBproducts = { "celkon mobile", "wild stone", "uncles ketchup", "mi Tv", "Chennai Silks" };
                SortedSet<string> LNB = new SortedSet<string>();
                foreach (var item in LNBproducts)
                {
                    LNB.Add(item);
                }
                foreach (var item in LNB)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                string[] INBproducts = { "Freedom mobile", "Ethique", "Fino salt", "LG Tv", "Hollister" };
                SortedSet<string> INB = new SortedSet<string>();
                foreach (var item in INBproducts)
                {
                    INB.Add(item);
                }
                foreach (var item in INB)
                {
                    Console.WriteLine(item.ToString());
                }

            }
        }
        public int GetPrice(string item, string type)
        {
            int price = 0;
            if (type == "LBrand")
            {
                Dictionary<string, int> LBrand = new Dictionary<string, int>();
                LBrand.Add("Xiomi mobile", 25000);
                LBrand.Add("Fogg Deo", 200);
                LBrand.Add("Kissan Jam", 160);
                LBrand.Add("Onida Tv", 15000);
                LBrand.Add("Bombay Dyeing Bed and Bath", 2000);
                foreach (KeyValuePair<string, int> product in LBrand)
                {
                    if (product.Key.ToLower() == item.ToLower())
                    {
                        price = product.Value;
                    }
                }
            }

            else if (type == "IBrand")
            {
                Dictionary<string, int> IBrand = new Dictionary<string, int>();
                IBrand.Add("Apple Mobile", 100000);
                IBrand.Add("London Perfume", 80000);
                IBrand.Add("Heins Ketchup", 200);
                IBrand.Add("Samsung Tv", 90000);
                IBrand.Add("Amazon Basics Bed and Bath ", 6000);
                foreach (KeyValuePair<string, int> product in IBrand)
                {
                    if (product.Key.ToLower() == item.ToLower())
                    {
                        price = product.Value;
                    }
                }
            }
            else if (type == "LNBrand")
            {
                Dictionary<string, int> LNonBrand = new Dictionary<string, int>();
                LNonBrand.Add("celkon mobile", 7000);
                LNonBrand.Add("wild stone", 100);
                LNonBrand.Add("uncles ketchup", 20);
                LNonBrand.Add("mi Tv", 8000);
                LNonBrand.Add("Chennai Silks", 800);
                foreach (KeyValuePair<string, int> product in LNonBrand)
                {
                    if (product.Key.ToLower() == item.ToLower())
                    {
                        price = product.Value;
                    }
                }
            }
            else
            {
                Dictionary<string, int> INonBrand = new Dictionary<string, int>();
                INonBrand.Add("Freedom mobile", 30000);
                INonBrand.Add("Ethique", 1000);
                INonBrand.Add("Fino salt", 180);
                INonBrand.Add("LG Tv", 8000);
                INonBrand.Add("Hollister", 1600);
                foreach (KeyValuePair<string, int> product in INonBrand)
                {
                    if (product.Key.ToLower() == item.ToLower())
                    {
                        price = product.Value;
                    }
                }
            }
            return price;
        }
    }
}

