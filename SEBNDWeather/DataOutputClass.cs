using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBNDWeather
{
    public static class DataOutputClass
    {
        public static void OutputInit(List<WeatherData> WholeData)
        {
            DataOutput(WholeData);
        }
        private static void DataOutput(List<WeatherData> WholeData)
        {
            Console.WriteLine("========== DATA OUTPUT ==========");
            Console.WriteLine("Hello User, plase enter your search criteria [Name of City/Date of recording]");
            Console.Write("Criteria: ");
            string Selection = Console.ReadLine();
            Console.Write("\n");


            foreach (WeatherData item in WholeData)
            {
                Console.WriteLine(item.NameOfCity);
                Console.WriteLine(item.Temperature);
                Console.WriteLine(item.DateOfRecord);
                Console.WriteLine(item.WasPrecipitation);
                Console.WriteLine(item.WindSpeed);
                Console.WriteLine(item.WindDirection);
            }
        }
    }
}
