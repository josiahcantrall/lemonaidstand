using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidstand
{
    class Rules
    {
        Player player;
        Day day;
        Weather weather;
        Store store;
        public Rules()
        {
            player = new Player();
            day = new Day();
            weather = new lemonaidstand.Weather();
            store = new Store();


        }
        public void PlayGame()
        {
            player.chooseName();
            weather.displayWeatherForToday();
            weather.displayWeatherForWeek();
            store.inventory.BeginningInventoryLevels();
            store.GetIngredients();
            store.inventory.CurrentInventoryLevels();
        }   

        }




       

    }

