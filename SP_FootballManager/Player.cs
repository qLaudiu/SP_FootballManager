using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    public class Player
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        int ID;
        String Name;
        int Number;
        int Age;
        IPosition Position;
        int Salary;
        //int PlayerScore - from 0 to 100;
        //bool isAbleToPlay - not injured or suspended
=======
=======
>>>>>>> 7b1490767109ca2fd28d58afef2fd9674436fafd
=======
>>>>>>> 7b1490767109ca2fd28d58afef2fd9674436fafd
        private int ID { get; set; }
        public String Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public IPosition Position { get; set; }
        public int Salary { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 7b1490767109ca2fd28d58afef2fd9674436fafd
=======
>>>>>>> 7b1490767109ca2fd28d58afef2fd9674436fafd
=======
>>>>>>> 7b1490767109ca2fd28d58afef2fd9674436fafd

        public Player()
        {
            
        }

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

        public override string ToString()
        {
            return string.Format("[Player: Name={0}, Number={1}, Age={2}, Position={3}, Salary={4}]", Name, Number, Age, Position, Salary);
        }
    }
}
