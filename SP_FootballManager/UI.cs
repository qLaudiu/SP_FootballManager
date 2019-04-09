using System;
namespace SP_FootballManager
{
    public class UI
    {
        private bool _run = false;

        private DataLayer dataLayer = DataLayer.GetInstance();

        public UI()
        {
        }

        public void Init()
        {
            _run = true;
            while(_run)
            {
                Console.WriteLine("Please select one option: ");
                Console.WriteLine("1. Show all players ");
                Console.WriteLine("2. Add player ");
                Console.WriteLine("3. Show Team ");
                Console.WriteLine("4. Show best tactic ");
                Console.WriteLine("5. Change Tactic ");
                Console.WriteLine("0. Exit ");
                Console.WriteLine("Enter option: ");

                var optionString = Console.ReadLine();

                int option = -1;
                try
                {
                    option = Convert.ToInt32(optionString);
                }
                catch
                {
                    Console.WriteLine("Please insert a valid option ");
                    continue;
                }

                if (option >= 0 && option <= 5)
                {
                    switch(option)
                    {
                        case 1:
                            foreach(Player p in dataLayer.GetAllPlayers())
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:
                            Player player = InsertNewPlayer();
                            if (player == null)
                            {
                                Console.WriteLine("Error, please try again");
                                break;
                            }
                            else
                            {
                                dataLayer.AddPlayer(player);
                                Console.WriteLine("Player added");
                            }
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 0:
                            _run = false;
                            break;
                        default:
                            Console.WriteLine("Unknown option " + option);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown option " + option);
                }
            }
        }

        private Player InsertNewPlayer()
        {
            Player player = new Player();

            Console.WriteLine("Please enter player name = ");
            var name = Console.ReadLine();
            player.Name = name;

            Console.WriteLine("Please enter player age = ");
            var age = Console.ReadLine();
            var ageInt = Convert.ToInt32(age);
            player.Age = ageInt;

            Console.WriteLine("Please enter player number = ");
            var number = Console.ReadLine();
            var numberInt = Convert.ToInt32(number);
            player.Number = numberInt;

            Console.WriteLine("Please enter player salary = ");
            var salary = Console.ReadLine();
            var salaryInt = Convert.ToInt32(salary);
            player.Salary = salaryInt;

            Console.WriteLine("Please enter player score = ");
            var score = Console.ReadLine();
            var scoreInt = Convert.ToInt32(score);
            player.Score = scoreInt;

            Console.WriteLine("Is player able to play 1 or 0 = ");
            var able = Console.ReadLine();
            var ableInt = Convert.ToInt32(able);
            player.IsAbleToPlay = ableInt == 0 ? false : true;

            Console.WriteLine("Please enter player position = ");
            Console.WriteLine("1. GoalKeeper");
            Console.WriteLine("2. Deffender");
            Console.WriteLine("3. Mid");
            Console.WriteLine("4. Atack");
            var position = Console.ReadLine();
            var positionInt = Convert.ToInt32(position);

            if (positionInt == 1)
            {
                player.Position = new P_GoalKeeper(Role.GK);
            }
            else if (positionInt == 2)
            {
                Console.WriteLine("1. CB");
                Console.WriteLine("2. LB");
                Console.WriteLine("3. RB");
                var role = Console.ReadLine();
                var roleInt = Convert.ToInt32(role);
                if (roleInt == 1)
                {
                    player.Position = new P_Deffender(Role.CB);
                }
                else if (roleInt == 2)
                {
                    player.Position = new P_Deffender(Role.LB);
                }
                else if (roleInt == 3)
                {
                    player.Position = new P_Deffender(Role.RB);
                }
                else
                {
                    Console.WriteLine("Error");
                    return null;
                }
            }
            else if (positionInt == 3)
            {
                Console.WriteLine("1. CM");
                Console.WriteLine("2. LM");
                Console.WriteLine("3. RM");
                Console.WriteLine("4. CDM");
                var role = Console.ReadLine();
                var roleInt = Convert.ToInt32(role);
                if (roleInt == 1)
                {
                    player.Position = new P_Middle(Role.CM);
                }
                else if (roleInt == 2)
                {
                    player.Position = new P_Middle(Role.LM);
                }
                else if (roleInt == 3)
                {
                    player.Position = new P_Middle(Role.RM);
                }
                else if (roleInt == 4)
                {
                    player.Position = new P_Middle(Role.CDM);
                }
                else
                {
                    Console.WriteLine("Error");
                    return null;
                }
            }
            else if (positionInt == 4)
            {
                Console.WriteLine("1. SS");
                Console.WriteLine("2. CF");
                var role = Console.ReadLine();
                var roleInt = Convert.ToInt32(role);
                if (roleInt == 1)
                {
                    player.Position = new P_Atack(Role.SS);
                }
                else if (roleInt == 2)
                {
                    player.Position = new P_Atack(Role.CF);
                }
                else
                {
                    Console.WriteLine("Error");
                    return null;
                }
            }
            else 
            {
                Console.WriteLine("Error");
                return null;
            }

            return player;
        }
    }
}
