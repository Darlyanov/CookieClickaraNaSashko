using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickaraNaSashko
{
    class Program
    {
        static void Main(string[] args)
        {
            int cookies = 0;
            int cookiesPerClick = 1;
            int upgradeCost = 10;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=== COOKIE CLICKER ===");
                Console.WriteLine();
                Console.WriteLine("Cookies: " + cookies);
                Console.WriteLine("Cookies per click: " + cookiesPerClick);
                Console.WriteLine("Upgrade cost: " + upgradeCost);
                Console.WriteLine();
                Console.WriteLine("1. Click cookie");
                Console.WriteLine("2. Buy upgrade");
                Console.WriteLine("3. Quit");
                Console.WriteLine();
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    cookies = cookies + cookiesPerClick;
                    Console.WriteLine("You clicked the cookie!");
                }
                else if (choice == "2")
                {
                    if (cookies >= upgradeCost)
                    {
                        cookies = cookies - upgradeCost;
                        cookiesPerClick = cookiesPerClick + 1;
                        upgradeCost = upgradeCost + 10;

                        Console.WriteLine("Upgrade bought!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough cookies!");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong option!");
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
