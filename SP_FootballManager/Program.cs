using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace SP_FootballManager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    UI ui = new UI();
                    ui.Init();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[#] Program restarting in 5 seconds because of unexpected error: " + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();    
                }
            }
        }
    }
}
