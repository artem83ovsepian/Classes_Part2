using HW.Delegates;
using System;
using System.Runtime.InteropServices;

namespace HW
{
    public class Program
    {

        public static void Main(string[] args)
        {
            PrintStringDelegate del1 = PrintStringGreen;
            PrintStringDelegate del2 = PrintStringOrange;
            PrintStringDelegate delAll = del1 + del2;
            delAll("This is a message");

            CreateHostBuilder(args).Build().Run();

        }
        public static void PrintStringGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PrintStringOrange(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}