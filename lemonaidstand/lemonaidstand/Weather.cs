using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace lemonaidstand
{
    public class Weather
    {
        public string chooseDay;
        public string chooseWeek;
    





        List<string> OptionsList = new List<string>();

        public Weather()

        {
         
            OptionsList.Add("Sunny with a high of 85 degrees and low of 75 degrees.");
            OptionsList.Add("Cloudy with a high of 75 degrees and low of 65 degrees");
            OptionsList.Add("Rainy with a high of 75 degrees and low of 65 degrees");
            OptionsList.Add("Thunderstorms with a high of 75 degrees and low of 60 degrees");
            OptionsList.Add("Hot and humid with a high of 90 degrees and low of 80 degrees");
            OptionsList.Add("Heat Advisory.High of 95 degrees and low of 80 degrees");
            OptionsList.Add("Chance of showers with a high of 72 degrees and low of 62 degrees");
            OptionsList.Add("Heavy fog all day. Temperatures should hover around 75 degrees");
        }


        public void displayWeatherForToday()
        {
            Console.WriteLine("Great. Let's start with the weather forecast!");
            Console.WriteLine("Today's weather report for Milwaukee, WI is:");
            Console.WriteLine("");
            Random random = new Random();
            chooseDay = OptionsList[random.Next(0, OptionsList.Count)];
            Console.WriteLine(chooseDay);
            Console.WriteLine();
        }

        public void displayWeatherForWeek()
        {
            Console.WriteLine("The 7 day forecast for Milwaukee, WI is:");
            Console.WriteLine();
            foreach (var options in OptionsList)
            {
                Console.WriteLine(options);
            }
            Console.WriteLine();
        }

        //public void AddSugarCubes(int sugarCubes)
        //       {
        //           for (int i = 0; i < sugarCubes; i++)
        //           {
        //               Sugar sugar = new Sugar();
        //               inventory.sugars.Add(sugar);
        //           }
        //       }
        //{
        //    Random random = new Random();
        //    chooseWeek = options[random.Next(0, options.Count)];
        //    Console.WriteLine(chooseWeek);
    }







}
