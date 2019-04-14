using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    public class UI : IPlayersListener
    {
        private bool _run = false;

        private DataLayer dataLayer = DataLayer.GetInstance();

        private TacticBuildDirector tacticDir = new TacticBuildDirector();

        private TeamBuilderDirector teamDir = new TeamBuilderDirector();
        private Team team;

        public UI()
        {
            team = teamDir.GetTeam();
        }

        public void Init()
        {
            dataLayer.SetIPlayerListener(this);
            _run = true;
            while (_run)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please select one option: ");
                Console.WriteLine("1. Show all players ");
                Console.WriteLine("2. Add player ");
                Console.WriteLine("3. Show Team ");
                Console.WriteLine("4. Show best tactic ");
                Console.WriteLine("5. Change Tactic ");
                Console.WriteLine("6. Iterate Team");
                Console.WriteLine("0. Exit ");
                Console.WriteLine("Enter option: ");
                Console.ForegroundColor = ConsoleColor.White;

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

                if (option >= 0 && option <= 6)
                {
                    switch (option)
                    {
                        case 1:
                            foreach (Player p in team.Players)
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
                            Console.WriteLine(team);
                            break;
                        case 4:
                            if (team.BestTactic == null)
                            {
                                Console.WriteLine("No best tactic");
                            }
                            else
                            {
                                Console.WriteLine(team.BestTactic);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Tactic: ");
                            Console.WriteLine("1. Formation 2_3_5");
                            Console.WriteLine("2. Formation 3_2_5");
                            Console.WriteLine("3. Formation 2_3_2_3");
                            Console.WriteLine("4. Formation 4_2_4");
                            Console.WriteLine("5. Formation 4_3_3");
                            Console.WriteLine("6. Formation 5_4_1");
                            Console.WriteLine("7. Formation 4_4_2");
                            Console.WriteLine("8. Formation 3_5_2");
                            Console.WriteLine("9. Formation 4_2_3_1");

                            var formationString = Console.ReadLine();
                            int formation = Convert.ToInt32(formationString);
                            switch (formation)
                            {
                                case 1:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation2_3_5, new List<Player>(team.Players));
                                    break;
                                case 2:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation3_2_5, new List<Player>(team.Players));
                                    break;
                                case 3:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation2_3_2_3, new List<Player>(team.Players));
                                    break;
                                case 4:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation4_2_4, new List<Player>(team.Players));
                                    break;
                                case 5:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation4_3_3, new List<Player>(team.Players));
                                    break;
                                case 6:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation5_4_1, new List<Player>(team.Players));
                                    break;
                                case 7:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation4_4_2, new List<Player>(team.Players));
                                    break;
                                case 8:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation3_5_2, new List<Player>(team.Players));
                                    break;
                                case 9:
                                    team.BestTactic = tacticDir.GetTactic(EFormation.Formation4_2_3_1, new List<Player>(team.Players));
                                    break;
                                default:
                                    Console.WriteLine("No formation selected...");
                                    break;

                            }
                            break;
                        case 6:
                            IterateTeamPlayers();
                            break;
                        case 0:
                            _run = false;
                            Environment.Exit(0);
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

        public void IterateTeamPlayers()
        {
            Team_Iterator iterator = new Team_Iterator(team);
            bool run_iterator = true;
            while (iterator.IsValid() && run_iterator)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Curent position: " + iterator.GetPlayer());
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please select operation:");
                Console.WriteLine("1. Pervous");
                Console.WriteLine("2. Next");
                Console.WriteLine("3. Change selection criteria");
                Console.WriteLine("4. Get by index");
                Console.WriteLine("5. Reset");
                Console.WriteLine("6. Sort players by score");
                Console.WriteLine("0. Back");


                var operationRaw = Console.ReadLine();
                int? operation = Convert.ToInt32(operationRaw);

                switch (operation)
                {
                    case 1:
                        iterator.Pervous();
                        operation = null;
                        break;
                    case 2:
                        iterator.Next();
                        operation = null;
                        break;
                    case 3:
                        Console.WriteLine("SS = 1, CF = 2, CM = 3, LM = 4, RM = 5, CDM = 6, CB = 7, LB = 8, RB = 9, GK = 0");
                        Role selection_role = (Role)Convert.ToInt32(Console.ReadLine());
                        iterator.SetRole(selection_role);
                        Console.WriteLine("Selection role set to: " + selection_role);
                        operation = null;
                        break;
                    case 4:
                        Console.WriteLine("Insert index number:");
                        Player player_by_index = iterator.GetByIndex(Convert.ToInt32(Console.ReadLine()));
                        if (player_by_index != null)
                            Console.WriteLine("Selected player: " + player_by_index);
                        else
                            Console.WriteLine("Index not in array");
                        operation = null;
                        break;
                    case 5:
                        iterator.Reset();
                        Console.WriteLine("Iterator position reset!");
                        operation = null;
                        break;
                    case 6:
                        iterator.SortByScore();
                        Console.WriteLine("Sorted by score!");
                        operation = null;
                        break;
                    case 0:
                        run_iterator = false;
                        break;
                }
            }
            if (run_iterator)
                Console.WriteLine("Iteration came to and end!");
        }

        public void OnPlayerModified()
        {
            Console.WriteLine("There is a new player in the db, reload the team");
            team = teamDir.GetTeam();
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
