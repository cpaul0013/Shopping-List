using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> itemMenu = new Dictionary<string, double>();
            itemMenu.Add("Gas", 2.50);
            itemMenu.Add("Coke", 1.50);
            itemMenu.Add("Chips", 2.00);
            itemMenu.Add("Coffee", 1.00);
            itemMenu.Add("Hot Dog", .75);
            itemMenu.Add("Burrito", 3.00);
            itemMenu.Add("Pizza", 2.25);
            itemMenu.Add("Candy", 1.00);

            List<string> productName = new List<string>();
            List<double> productPrice = new List<double>();

            Dictionary<string, double> purchasedItems = new Dictionary<string, double>();


            bool runProgram = true;
            bool haveProduct = true;
            while (runProgram == true)
            {
                foreach(KeyValuePair <string, double> abc in itemMenu)
                {
                    Console.WriteLine($"{abc.Key}\t\t{abc.Value.ToString("0.00")}");
                }

                Console.WriteLine("What would you like to buy?");
                string product = Console.ReadLine().ToLower();

               foreach(KeyValuePair<string, double> abc in itemMenu)
                {
                    if(product == abc.Key.ToLower())
                    {
                        Console.WriteLine($"Adding {abc.Key} at {abc.Value.ToString("0.00")} to cart");
                        productName.Add(abc.Key);
                        productPrice.Add(abc.Value);
                        haveProduct = true;
                        break;
                    }
                    else
                    {
                        haveProduct = false;
                    }
                    
                        
                }
               if(haveProduct == false)
                {
                    Console.WriteLine($"I am sorry we do not carry {product}");
                }
               

                if (keepGoing() == false)
                {
                    runProgram = false;
                }
               
            }
          
            Console.WriteLine("Thank you for shopping with us!" +
                               "\nHere is what you got!");
            for(int i = 0; i < productName.Count; i++)
            {
                Console.WriteLine($"{productName[i]}\t\t{productPrice[i].ToString("0.00")} ");
            }
            double avg = productPrice.Average();
            avg = Math.Round(avg,2);
            Console.WriteLine(value: $"The average price of your items is {avg}");
            
            
        }
        public static bool keepGoing()
        {
            bool validInput = false;
            bool keepGoing = false;
            while (validInput == false)
            {
                Console.WriteLine("Would you like to order anything else? Y/N");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    keepGoing = true;
                    validInput = true;
                }

                else if (response == "n")
                {
                    keepGoing = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please input Y or N");
                    validInput = false;
                }
            }
            return keepGoing;
        }
      
        }
    
    }

