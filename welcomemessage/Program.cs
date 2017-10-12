using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcomemessage
{
    class Program
    {
        static void Main(string[] args)
       
        {

            Console.Write("enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("welcome to my program " + name);


            //wait at the end
            Console.ReadKey();
        }
    }
}
