using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickadoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a door 1,2 or 3");
            string choice = Console.ReadLine();

            if (choice =="1")
            {
                Console.WriteLine("behing door 1 is ziggy the bitch");           
            }
            else if (choice =="2")
            {
                Console.WriteLine("behind door 2 is xav the dragon");
            }
            else if (choice == "3")
            {
                Console.WriteLine("bhind door 3 is big shaq");
            }
            else
            {
                Console.WriteLine("ziggy is the goalie no matter what");
            }
            Console.ReadKey();
        }
    }
}
