using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Player
    {
        private int ID { get; set; }
        public String Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public IPosition Position { get; set; }
        public int Salary { get; set; }

        public Player(int id)
        {
            ID = id;
        }

        public Player(int id, String name, int number, int age, IPosition position, int salary)
        {
            ID = id;
            Name = name;
            Number = number;
            Age = age;
            Position = position;
            Salary = salary;
        }
    }
}
