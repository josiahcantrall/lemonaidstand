using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidstand
{
    public class Inventory


    {

        public List<Sugar> sugars = new List<Sugar>();
        public List<Lemon> lemons = new List<Lemon>();
        public List<Cup> cups = new List<Cup>();
        public List<Ice> icecubes = new List<Ice>();
        public Wallet cash = new Wallet();
        

        public void BeginningInventoryLevels()

        {
            Console.WriteLine("Would you like to view your inventory? Type 'yes' or 'no'");
            string name = Console.ReadLine();

            if (name == "yes")
            {

                Console.WriteLine("Here are your current inventory levels:");
                Console.WriteLine();
                Console.WriteLine("Cash on hand: " + cash.AmountInWallet);
                Console.WriteLine("Sugar: " + sugars.Count);
                Console.WriteLine("Lemons: " + lemons.Count);
                Console.WriteLine("Cups: " + cups.Count);
                Console.WriteLine("Icecubs: " + icecubes.Count);
                Console.WriteLine("");
            }

           
        }

        public void CurrentInventoryLevels()

        {
            Console.WriteLine("Would you like to view your updated inventory numbers? Type 'yes' or 'no'");
            string name = Console.ReadLine();

            if (name == "yes")
            {

                Console.WriteLine("Here are your up-to-date inventory levels:");
                Console.WriteLine();
                Console.WriteLine("Cash on hand: " + cash.AmountInWallet);
                Console.WriteLine("Sugar: " + sugars.Count);
                Console.WriteLine("Lemons: " + lemons.Count);
                Console.WriteLine("Cups: " + cups.Count);
                Console.WriteLine("Icecubs: " + icecubes.Count);
                Console.WriteLine("");
            }


        }


    }
}
