using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidstand
{
    

    public class Store
    {

        public Store()
        {
            inventory = new Inventory();

        }

       public Inventory inventory;

        public void GetIngredients()
        {
            Console.WriteLine("Would you like to shop for more inventory at the store?");
            string shop = Console.ReadLine();

            if (shop == "yes")
            {
                int sugarAmount = BuySugar();
                AddSugarCubes(sugarAmount);
                int lemonAmount = BuyLemon();
                AddLemonCount(lemonAmount);
                int cupAmount = BuyNumberOfCups();
                AddNumberOfCups(cupAmount);
                int numberOfIceCubes = BuyNumberOfIceCubes();
                AddNumberOfIceCubes(numberOfIceCubes);
                double costOfInventory = new Lemon().Price + new Cup().Price + new Ice().Price + new Sugar().Price;
                inventory.cash.withdrawCostOfInventory(costOfInventory); 
            }
        }

        public int BuySugar()
        {
            Console.WriteLine("Sugar cubes cost $5 per cube.");
            Console.WriteLine("How many sugar cubes do you want?");
            int sugarCubes = Int32.Parse(Console.ReadLine());
            return sugarCubes;
        }
        public void AddSugarCubes(int sugarCubes)
        {
            for (int i = 0; i < sugarCubes; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugars.Add(sugar);
            }
        }

        public int BuyLemon()
        {
            Console.WriteLine("Lemons cost $2 a piece.");
            Console.WriteLine("How many lemons do you want to buy?");
            int lemonCount = Int32.Parse(Console.ReadLine());
            return lemonCount;
        }

        public void AddLemonCount(int lemonCount)
        {
            for (int i = 0; i < lemonCount; i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
        }

        public int BuyNumberOfCups()
        {
            Console.WriteLine("Cups cost $0.25 a piece");
            Console.WriteLine("How mancy cups do you want to buy?");
            int numberOfCups = Int32.Parse(Console.ReadLine());
            return numberOfCups;
        }

        public void AddNumberOfCups(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                inventory.cups.Add(cup);
            }
        }

        public int BuyNumberOfIceCubes()
        {
            Console.WriteLine("Sugar cubes cost $5 per cube.");
            Console.WriteLine("How many sugar cubes do you want?");
            int iceCubes = Int32.Parse(Console.ReadLine());
            return iceCubes;
        }
        public void AddNumberOfIceCubes(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                Ice ice = new Ice();
                inventory.icecubes.Add(ice);
            }
        }
    }
}
