using System;

namespace Exercise1
{
    internal class Program

    {
        internal class Bakery_items
        {
            public void Ord_bakery()
            {
                Customer customer1 = new Customer();
                customer1.getName();
                Console.WriteLine("Hi {0}", customer1.name);
                Console.WriteLine("You ordered grocery items!");
            }
        }

        internal class Grocery_items
        {
            public void Ord_grocery()
            {
                Customer customer2 = new Customer();
                customer2.getName();
                Console.WriteLine("Hello {0}", customer2.name);
                Console.WriteLine("You ordered bakery items !");
            }
        }

        public static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Would you like to order? 1.Grogcery Items, 2.Bakery Items");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Grocery_items objGrocery = new Grocery_items();
                objGrocery.Ord_grocery();
            }
            else
            {
                if (choice == "2")
                {
                    Bakery_items objBakery = new Bakery_items();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }
            }

            Console.ReadLine();
        }

    }
}