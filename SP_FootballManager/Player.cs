using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    public class Player
    {

        private int ID { get; set; }
        public String Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public IPosition Position { get; set; }
        public int Salary { get; set; }
        public int Score { get; set; }
        public bool IsAbleToPlay { get; set; }


        public Player()
        {
            
        }

        public Player(int id)
        {
            ID = id;
        }

        public Player(int id, String name, int number, int age, IPosition position, int salary, int playerScore, bool isAbleToPlay)
        {
            ID = id;
            Name = name;
            Number = number;
            Age = age;
            Position = position;
            Salary = salary;
            Score = playerScore;
            IsAbleToPlay = isAbleToPlay;
        }

        public override string ToString()
        {
            return string.Format("[Player: Name={0}, Number={1}, Age={2}, Position={3}, Salary={4}, Score={5}, CanPlay= {6}]", Name, Number, Age, Position.Player_role, Salary, Score, IsAbleToPlay);
        }
    }
}
