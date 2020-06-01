using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Receiver class</summary>
    /// 
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(decimal amount)
        {
            Price += amount;
            Console.WriteLine($"The price for {Name} has been increased by {amount} $");
        }

        public void DecreasePrice(decimal amount)
        {
            Price -= amount;
            Console.WriteLine($"The price for {Name} has been decresed by {amount} $");
        }

        public override string ToString() => $"Current price for the {Name} is {Price} $";
    }


}
