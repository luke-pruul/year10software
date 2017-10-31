using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userscore = 0;
            int computerscore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                printscore(ref userscore, ref computerscore);
                string userchoice = userturn();
                string computerchoice = computerturn();
                result = determinewinner(userchoice,computerchoice);
                givefeedback(result, userchoice, computerchoice);
                updatescores(result, ref userscore, ref computerscore);
                repeat = playagain();
            }
        }

        private static bool playagain()
        {
            Console.WriteL ine("do you want to playagain? y/n");
            string choice = Console.ReadLine().ToLower();
            if(choice =="y" || choice == "yes")
            {

            }
        }

        private static void updatescores(string result, ref int userscore, ref int computerscore)
        {
           if(result =="win")
            {
                userscore++;
            }
            else if(result =="lose")
            {
                computerscore++;
            }
        }

        private static void givefeedback(string result, string userchoice, string computerchoice)
        {
            
        }

        private static string determinewinner(string userchoice, string computerchoice)
        {
           if(userchoice == "rock")
           {
                if(computerchoice == "rock")
                {
                    return "draw";
                }
                else if (computerchoice == "paper")
                {
                    return "lose";
                }
                else 
                {
                    return "win";
                }   
            }
           if(userchoice == "paper")
            {
                if (computerchoice == "rock")
                {
                    return "win";
                }
                else if (computerchoice == "paper")
                {
                    return "draw";
                }
                else 
                {
                    return "lose";
                }
            }
            if (userchoice == "scissors")
            {
                if (computerchoice == "rock")
                {
                    return "lose";
                }
                else if (computerchoice == "paper")
                {
                    return "win";
                }
                else 
                {
                    return "draw";
                }
            }
        }


        private static string computerturn()
        {
           
        }

        private static string userturn()
        {
            
        }

        private static void printscore(ref int userscore, ref int computerscore)
        {
            Console.WriteLine("user score: 100\t\tcomputer score: 100");
        }
    }
}
