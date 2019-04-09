using System;

namespace SP_FootballManager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player = new Player(1, "Whyskow Luther", 12, 28, new P_Atack(Role.SS), 20000);
            Console.WriteLine(player);
        }
    }
}
