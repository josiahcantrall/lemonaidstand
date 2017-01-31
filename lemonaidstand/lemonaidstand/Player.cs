using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidstand
{
    public class Player
    {
        public string rungame;
        public string name;
        public string city;
        public Day day;
        public Wallet wallet;


        // Below is the constructor. I store the new instance of Day class in the day variable I created above
        public Player()
        {
            day = new Day();
            wallet = new Wallet();
        }

        public void chooseName()
        {


            Console.WriteLine("Welcome to Lemonade Stand.");
            Console.WriteLine("If you want to be an entrepreneur, this is a good place to start!");
            Console.WriteLine("So here's the deal!");
            Console.WriteLine("You have a Lemonde Stand. An inventory of lemons, sugar, cups, and ice.");
            Console.WriteLine("You need to manage your cash, keep up with customer demand, and hopefully turn a profit");
            Console.WriteLine("Some things to watch out for: Is my inventory running low? Do I have enough cash to buy more supplies? Are my prices too high?");
            Console.WriteLine("Yeah. There's a lot to keep track of. And oh, customers may not even want your product if the weather is bad!");
            Console.WriteLine("....");
            Console.WriteLine("Ready to enter the lemonade world of business?? If so, lets go!");
            Console.WriteLine("To get started. Please type your name:");
            name = Console.ReadLine();
            Console.WriteLine();

        }



 

  
        //public void viewWeather()
        //{

        //    Console.WriteLine("day.Conditions");
        //    Console.WriteLine("Here is the weather for Milwaukee, WI");
        //    Console.WriteLine("Conditions: " + "condition.Conditions");
        //    Console.WriteLine("Temperature (F): " + "tempFahrenheit.Conditions");
        //    Console.WriteLine("Humidity: " + "humidity.Conditions");
        //    Console.WriteLine("Day: " + "DayOfWeek.Conditions");
        //    Console.WriteLine("Temperature (High): " + "high.Conditions");
        //    Console.WriteLine("Temperature (Low): " + "low.Conditions");

        //}








    }



    }
