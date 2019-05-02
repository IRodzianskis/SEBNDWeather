using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SEBNDWeather
{
    public static class DataInputClass
    {
        public static List<WeatherData> InputInit(List<WeatherData> WholeData)
        {
            WholeData = DataInput(WholeData);
            Console.Write("Would you like to input more data [Yes/No]? ");
            if (Console.ReadLine().ToLower().Trim() == "yes")
                InputInit(WholeData);
            return WholeData;
        }
        private static List<WeatherData> DataInput(List<WeatherData> WholeData)
        {
            string City = "", Direction = "", DateOfRecord = "", PrecipitationCheck = "", Temperature = "", WindSpeed = "";
            double TemperatureCorrect, WindSpeedCorrect;
            bool WasPrecipitation;

            Console.WriteLine("========== DATA INPUT ==========");
            while (!Regex.IsMatch(City, "^[a-zA-Z ]+$"))
            {
                Console.Write("Please input the name of the city: ");
                City = Console.ReadLine().Trim();
            }
            while (!double.TryParse(Temperature, out TemperatureCorrect))
            {
                Console.Write("\nPlease input the temperature in Celsius: ");
                Temperature = Console.ReadLine().Trim();
            }
            while (!DateValidation(DateOfRecord))
            {
                Console.Write("\nPlease input the date of recording [Format: yyyy/MM/dd]: ");
                DateOfRecord = Console.ReadLine().Trim();
            }
            while (PrecipitationCheck.ToLower() != "yes" && PrecipitationCheck.ToLower() != "no")
            {
                Console.Write("\nPlease input whether there was precipitation of not [Yes/No]: ");
                PrecipitationCheck = Console.ReadLine().Trim();
            }
            if (PrecipitationCheck == "Yes")
                WasPrecipitation = true;
            else WasPrecipitation = false;
            while (!double.TryParse(WindSpeed, out WindSpeedCorrect))
            {
                Console.Write("\nPlease input the wind speed [m/s]: ");
                WindSpeed = Console.ReadLine().Trim();
            }
            while (!DirectionValidation(Direction))
            {
                Console.Write("\nPlease input the direction of wind [Whole or abbreviated directional words (NE, East, eAst etc.)]: ");
                Direction = Console.ReadLine().Trim().ToUpper();
            }
            WholeData.Add(new WeatherData
            {
                NameOfCity = City,
                Temperature = TemperatureCorrect,
                DateOfRecord = DateOfRecord,
                WasPrecipitation = WasPrecipitation,
                WindSpeed = WindSpeedCorrect,
                WindDirection = Direction
            });
            return WholeData;
        }
        private static bool DateValidation(string date)
        {
            if (DateTime.TryParseExact(date, "yyyy/MM/dd", null, DateTimeStyles.None, out DateTime Test) && (Test <= DateTime.Now))
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
