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
            UserPromptInitial();
        }
        public static void UserPromptInitial()
        {
            Console.WriteLine("Hello User, would you like to input data or output data?");
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Output Data");
            Console.Write("Selection: ");
            string Selection = Console.ReadLine();
            var WholeData = new List<WeatherData>();
            switch (Selection)
            {
                case "1":
                    WholeData = DataInputClass.InputInit();
                    UserPromptInitial();
                    break;

                case "2":
                    DataOutputClass.OutputInit(WholeData);
                    UserPromptInitial();
                    break;
                default:
                    UserPromptInitial();
                    break;
            }
        }
    }
    
}
