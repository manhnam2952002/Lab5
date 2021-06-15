using System;

namespace Exercise1
{
    public class Customer
    {
        public string name;
        public void getName()
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
        }
    }
}