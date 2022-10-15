using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    public class Category
    {
        //Singleton

        private HashSet<string> category;
        private static Category Instance;

        public static Category GetInstance(string name)
        {
            if (Instance == null)
            {
                Instance = new Category();
            }
            return Instance;
        }
        public Category()
        {
            string[] categories = { "**********MENU**********", "1. Home Appliances", "2. Gadgets", "3. Groceries", "4. Bed and bath", "5. Cosmetics" };
            //HashSet
            category = new HashSet<string>(categories);
        }
        public HashSet<string> GetCategories()
        {
            return category;
        }
    }
}
