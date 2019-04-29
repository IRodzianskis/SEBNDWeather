using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SEBNDWeather
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserPrompt();
        }
        public static void UserPrompt()
        {
            Console.WriteLine("Hello User, would you like to input data or output data?");
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Output Data");
            Console.Write("Selection: ");
            string Selection = Console.ReadLine();
            switch (Selection)
            {
                case "1":
                    DataInput();
                    break;

                case "2":
                    DataOutput();
                    break;
                default:
                    break;
            }
        }
        public static void DataInput()
        {
            
        }
        public static void DataOutput()
        {

        }
    }
    
}
