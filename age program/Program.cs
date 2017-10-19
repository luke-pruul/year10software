using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("you are cum");
            }


            else if (age < 13)
            {
                Console.WriteLine("you are a child!");
            }
            else if (age <20)
            {
                Console.WriteLine("you are a teenager!");
            }
            else
            {
                Console.WriteLine("you are an adult");
            }

            Console.ReadKey();



    
        }
    }
}
