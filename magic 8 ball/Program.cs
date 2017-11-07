using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_8_ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playgame();
        }

        private static void playgame()
        {
            string[] answers = { "no", "yes" , "maybe" , "possibly" , "likely" , "not likely" };
            Console.Write("ask me a question (or type ' exit'): ");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(answers[rnd.Next(0,4)]);
            Console.ReadKey();
            playgame();
           


     }
    }
}
