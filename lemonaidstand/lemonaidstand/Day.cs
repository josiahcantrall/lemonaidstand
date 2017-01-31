using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace lemonaidstand
{
    public class Day
    {
        public int weatherReport;
        public Weather weather;
        public Customer customer;
        public string chooseDay;
        public string chooseWeek;
        
      





        public Day()
        {
            weather = new Weather();
            customer = new Customer();

        }

        





        //public class Conditions

        //{

        //    string city = "No Data";

        //    string dayOfWeek = DateTime.Now.DayOfWeek.ToString();

        //    string condition = "No Data";

        //    string tempFahrenheit = "No Data";

        //    string humidity = "No Data";

        //    string high = "No Data";

        //    string low = "No Data";



        //    public string City

        //    {
        //        get { return city; }

        //        set { city = value; }

        //    }

        //    public string Condition

        //    {

        //        get { return condition; }

        //        set { condition = value; }

        //    }

        //    public string TempFahrenheit

        //    {

        //        get { return tempFahrenheit; }

        //        set { tempFahrenheit = value; }

        //    }


        //    public string Humidity

        //    {

        //        get { return humidity; }

        //        set { humidity = value; }

        //    }


        //    public string DayOfWeek

        //    {

        //        get { return dayOfWeek; }

        //        set { dayOfWeek = value; }

        //    }

        //    public string High

        //    {

        //        get { return high; }

        //        set { high = value; }

        //    }

        //    public string Low

        //    {

        //        get { return low; }

        //        set { low = value; }

        //    }

        //    public static Conditions GetCurrentConditions(string location)

        //    {

        //        Conditions conditions = new Conditions();

        //        XmlDocument xmlConditions = new XmlDocument();

        //        xmlConditions.Load(string.Format("http://www.google.com/ig/api?weather={0}", location));


        //        if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)

        //        {

        //            conditions = null;

        //        }

        //        else

        //        {

        //            conditions.City = xmlConditions.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;

        //            conditions.Condition = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/condition").Attributes["data"].InnerText;

        //            conditions.tempFahrenheit = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_f").Attributes["data"].InnerText;

        //            conditions.Humidity = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/humidity").Attributes["data"].InnerText;



        //        }

        //        return conditions;
        //    }

        //    public static List<Conditions> GetForecast(string location)

        //    {

        //        List<Conditions> conditions = new List<Conditions>();



        //        XmlDocument xmlConditions = new XmlDocument();

        //        xmlConditions.Load(string.Format("http://www.google.com/ig/api?weather={0}", location));



        //        if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)

        //        {

        //            conditions = null;

        //        }

        //        else

        //        {

        //            foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/forecast_conditions"))

        //            {

        //                Conditions condition = new Conditions();

        //                condition.City = xmlConditions.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;

        //                condition.Condition = node.SelectSingleNode("condition").Attributes["data"].InnerText;

        //                condition.High = node.SelectSingleNode("high").Attributes["data"].InnerText;

        //                condition.Low = node.SelectSingleNode("low").Attributes["data"].InnerText;

        //                condition.DayOfWeek = node.SelectSingleNode("day_of_week").Attributes["data"].InnerText;

        //                conditions.Add(condition);

        //            }

        //        }



        //        return conditions;

        //    }


    }



    }
