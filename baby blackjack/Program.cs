using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baby_blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            playgame(ref money);
        }

        private static void playgame(ref float money)
        {
            Console.Clear();
            float betamount = makebet(ref money);
            Random rnd = new Random();
            int playertotal = Dealcards(rnd, "you");
            int dealertotal = Dealcards(rnd, "the dealer");
            bool playerwins = determinewinner(playertotal, dealertotal);
            payout(playerwins, betamount, ref money);
            menu(ref money);
        }

        private static void menu(ref float money)
        {
            float betAmount = 0;
            bool validbet = false;

            Console.WriteLine("enter your bet. you have $" + money);

            while (validbet != true)
            {
                validbet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > money)
                {
                    Console.WriteLine("sorry, you do not have enough. try again.");
                    validbet = false;
                }
                else if (betAmount < 0)
                {
                    Console.WriteLine("sorry, you cannot bet a negative amount.try again");
                    validbet = false;
                }
            }

            money = money - betAmount;
            return betAmount;
        }

        private static void payout(bool playerwins, float betamount, ref float money)
        {
            
        }

        private static bool determinewinner(int playertotal, int dealertotal)
        {
            
        }

        private static int Dealcards(Random rnd, string v)
        {
            
        }

        private static float makebet(ref float money)
        {
            
        }
    }
}
