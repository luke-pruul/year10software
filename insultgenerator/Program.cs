using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insultgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string name = Getname();

            generateinsult(name, rnd);
        }
        private static void generateinsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + ", you are " getadjective(rnd) + getcompoundadjective(rnd) + getobject(rnd));
            menu(name,  rnd);
        }
        private static string Getname()                 
        {
           Console.WriteLine("welcome to the insult generator. what is your name?");
            return Console.ReadLine();
        }    
        private static void menu(string name , Random rnd)
        {
            Console.WriteLine("would you like another insult? yes/no");
            if (Console.ReadLine() == "y")

                generateinsult(name, rnd);
                
        }
        private static string getadjective(Random rnd)
        {
            string[] adjectives = { "a pussy, a big boi, an idiot , a ugly , a ziggy, a xav" };
            return adjectives[rnd.next(6)];
        }
        private static string getcompoundadjective(Random rnd)
        {
            string[] compundadjectives = { "white-girl, mup-daddy, crack-head, scrawny-pleb, vegan-monster" };
            return compoundAdjectives[rnd.Next(5)];
        }
        private static string getobject(Random rnd)
        {
            string[] objects = { "vegan, hippie, gypsy, goth, maggot, rat" };
            return objects[6];
        }

    }
}
