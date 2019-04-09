using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UI ui = new UI();
            ui.Init();

            Player player = new Player(1, "Whyskow Luther", 12, 28, new P_Atack(Role.SS), 20000);
            Console.WriteLine(player);
            
            IStaff staff = new Staff_Members();
            IStaff director = new Staff();
            IStaff director2 = new Staff();

            IStaff subordonate = new Staff_Subordonate();
            director.type = Staff_Type.Director;
            director2.type = Staff_Type.Manager;
            subordonate.type = Staff_Type.Medic;
            
            director.Add(subordonate);
            staff.Add(director);
            staff.Add(director2);

            staff.Display(0);
        }
    }
}
