using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" -----------------");
            Console.WriteLine(" |Red light STOP!|" );
            System.Threading.Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" |Yellow PREPARE!|");
            System.Threading.Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" |Green light GO!|");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(" -----------------");

            Console.ReadLine();
        }
    }
}
