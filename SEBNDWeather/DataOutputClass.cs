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
        public static void DataOutput(List<WeatherData> WholeData)
        {
            Console.WriteLine("\n========== DATA OUTPUT ==========");
            Console.WriteLine("Hello User, plase enter your search criteria [Name of City/Date of recording]");
            Console.Write("Criteria: ");
            string Selection = Console.ReadLine().Trim();
            Console.Write("\n");
            int i = 1;
            bool isDate = InputCheck(Selection);
            if (isDate)
            {
                foreach (WeatherData item in WholeData)
                {
                    if (item.DateOfRecord.Contains(Selection))
                    {
                        DataPrinter(item, Selection, i);
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
                        DataPrinter(item, Selection, i);
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
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void DataPrinter(WeatherData item, string Selection, int i)
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
}
