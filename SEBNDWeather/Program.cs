using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Globalization;

namespace SEBNDWeather
{
    public class Program
    {
        static void Main(string[] args)
        {
            var WholeData = new List<WeatherData>();
            UserPrompt(WholeData);
        }
        public static void UserPrompt(List<WeatherData> WholeData)
        {
            Console.WriteLine("\nHello User, would you like to input data or output data?");
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Output Data");
            Console.WriteLine("3. Exit the program");
            Console.Write("Selection: ");
            string Selection = Console.ReadLine();
            switch (Selection)
            {
                case "1":
                    WholeData = DataInputClass.InputInit(WholeData);
                    UserPrompt(WholeData);
                    break;

                case "2":
                    DataOutputClass.OutputInit(WholeData);
                    UserPrompt(WholeData);
                    break;
                case "3":
                    break;
                default:
                    UserPrompt(WholeData);
                    break;
            }
        }
    }
    
}
