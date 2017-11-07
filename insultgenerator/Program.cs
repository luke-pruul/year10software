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
            string name = Getname;

            generateinsult(name);
        }
        private static void generateinsult(string name)
        {
            Console.WriteLine(name + ", you are " getadjective() + getcompoundadjective() + getobject());
            menu(name);
        }
        private static string Getname()                 
        {
           Console.WriteLine("welcome to the insult generator. what is your name?");
            return Console.ReadLine();
        }    
        private static void menu(string name)
        {

        }
        private static string getadjective()
        {
            string[] adjectives = { "a pussy, a big boi, an idiot , a ugly , a ziggy, a xav" };
        }
        private static string getcompoundadjective()
        {
            string[] compundadjectives = { "white-girl, mup-daddy, crack-head, scrawny-pleb, vegan-monster" };
        }
        private static string getobject()
        {
            string[] objects = {"vegan, hippie, jypsy, goth, maggot, rat"}
        }

    }
}
