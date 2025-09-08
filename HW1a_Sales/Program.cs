// HW1a Sales Total

// Your Name: Ethan Stone
// Did you seek help ? If yes, specify the helper or web link here: Slides for conversions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {

             double Quantity;         
             double Price;
             double subtotal;
             double salestax;
             double salestotal;

             const double tax = 8.5;

             string Item;
             string QuantityAsString;
             string PriceAsString;

             Console.WriteLine("What is the product name for what you are buying?");
             Item = Console.ReadLine();
             Console.WriteLine($"How many {Item}s are you buying?");
             QuantityAsString = Console.ReadLine();
             Console.WriteLine($"What is the price per {Item}");
             PriceAsString = Console.ReadLine();

             Quantity = Convert.ToDouble(QuantityAsString);
             Price = Convert.ToDouble(PriceAsString);

             subtotal = Price * Quantity;
             salestax = tax * Quantity;
             salestotal = subtotal + tax;

             string subtotalAsString = subtotal.ToString("C2");
             string salestaxAsString = salestax.ToString("C2");
             string salestotalAsString = salestotal.ToString("C2");

             Console.WriteLine($"Your subtotal is {subtotalAsString}");
             Console.WriteLine($"Your sales tax is {salestaxAsString}");
             Console.WriteLine($"Your total bill is {salestotalAsString}");
            
        }
    }
}
