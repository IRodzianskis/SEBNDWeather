using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SEBNDWeather
{
    public static class DataInputClass
    {
        public static List<WeatherData> InputInit()
        {
            List<WeatherData> WholeData = DataInput();
            return WholeData;
        }
        private static List<WeatherData> DataInput()
        {
            string City, Direction = "", DateOfRecord = "", PrecipitationCheck = "", Temperature = "", WindSpeed = "";
            double TemperatureCorrect, WindSpeedCorrect;
            bool WasPrecipitation;

            Console.WriteLine("========== DATA INPUT ==========");
            Console.Write("Please input the name of the city: ");
            City = Console.ReadLine();
            while (!double.TryParse(Temperature, out TemperatureCorrect))
            {
                Console.Write("\nPlease input the temperature in Celsius: ");
                Temperature = Console.ReadLine();
            }
            while (!DateValidation(DateOfRecord))
            {
                Console.Write("\nPlease input the date of recording [Format: yyyy/MM/dd]: ");
                DateOfRecord = Console.ReadLine();
            }
            while (PrecipitationCheck.ToLower() != "yes" && PrecipitationCheck.ToLower() != "no")
            {
                Console.Write("\nPlease input whether there was precipitation of not [Yes/No]: ");
                PrecipitationCheck = Console.ReadLine();
            }
            if (PrecipitationCheck == "Yes")
                WasPrecipitation = true;
            else WasPrecipitation = false;
            while (!double.TryParse(WindSpeed, out WindSpeedCorrect))
            {
                Console.Write("\nPlease input the wind speed [m/s]: ");
                WindSpeed = Console.ReadLine();
            }
            while (!DirectionValidation(Direction))
            {
                Console.Write("\nPlease input the direction of wind [Whole or abbreviated directional words (NE, East, eAst etc.)]: ");
                Direction = Console.ReadLine();
            }
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", City, TemperatureCorrect, DateOfRecord, WasPrecipitation, WindSpeed, Direction);
            var WholeData = new List<WeatherData>();
            WholeData.Add(new WeatherData
            {
                NameOfCity = City,
                Temperature = TemperatureCorrect,
                DateOfRecord = DateOfRecord,
                WasPrecipitation = WasPrecipitation,
                WindSpeed = WindSpeedCorrect,
                WindDirection = Direction
            });
            //foreach (WeatherData item in WholeData)
            //{
            //    Console.WriteLine(item.NameOfCity);
            //    Console.WriteLine(item.Temperature);
            //    Console.WriteLine(item.DateOfRecord);
            //    Console.WriteLine(item.WasPrecipitation);
            //    Console.WriteLine(item.WindSpeed);
            //    Console.WriteLine(item.WindDirection);
            //}
            return WholeData;

        }
        private static bool DateValidation(string date)
        {
            if (DateTime.TryParseExact(date, "yyyy/MM/dd", null, DateTimeStyles.None, out DateTime Test) == true)
                return true;
            else
                return false;
        }
        private static bool DirectionValidation(string direction)
        {
            direction = direction.ToLower();
            List<string> directions = new List<string> { "ne", "e", "se", "s", "sw", "w", "nw", "n", "northeast", "east", "southeast", "south", "southwest", "west", "northwest", "north" };
            if (directions.Contains(direction.ToLower()))
                return true;
            else return false;
        }
    }
}
