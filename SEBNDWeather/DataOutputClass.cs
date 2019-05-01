using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            Console.WriteLine("\n========== DATA OUTPUT ==========");
            Console.WriteLine("Hello User, plase enter your search criteria [Name of City/Date of recording]");
            Console.Write("Criteria: ");
            string Selection = Console.ReadLine();
            Console.Write("\n");
            bool isDate = InputCheck(Selection);
            int i = 1;
            if (isDate)
            {
                foreach (WeatherData item in WholeData)
                {
                    if (item.DateOfRecord.Contains(Selection))
                    {
                        Console.WriteLine("\n=================ITEM {0}=================",i);
                        Console.WriteLine("Name of city: " + item.NameOfCity);
                        Console.WriteLine("Recorded temperature: " + item.Temperature);
                        Console.WriteLine("Date of recording: " + item.DateOfRecord);
                        Console.WriteLine("Was there precipitation: " + item.WasPrecipitation);
                        Console.WriteLine("Wind Speed: " + item.WindSpeed + " m/s");
                        Console.WriteLine("Wind direction: " + item.WindDirection);
                        i++;
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                foreach (WeatherData item in WholeData)
                {
                    if (item.NameOfCity.Contains(Selection))
                    {
                        Console.WriteLine("\n=================ITEM {0}=================", i);
                        Console.WriteLine("Name of city: " + item.NameOfCity);
                        Console.WriteLine("Recorded temperature: " + item.Temperature);
                        Console.WriteLine("Date of recording: " + item.DateOfRecord);
                        Console.WriteLine("Was there precipitation: " + item.WasPrecipitation);
                        Console.WriteLine("Wind Speed: " + item.WindSpeed + " m/s");
                        Console.WriteLine("Wind direction: " + item.WindDirection);
                        i++;
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }
        private static bool InputCheck(string input)
        {
            if (DateTime.TryParseExact(input, "yyyy/MM/dd", null, DateTimeStyles.None, out DateTime Test) == true)
            {
                Console.WriteLine("Date");
                return true;
            }
            else
            {
                Console.WriteLine("Not Date");
                return false;
            }
        }
    }
}
