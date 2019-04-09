using System;
namespace SP_FootballManager
{
    public class UI
    {
        private bool _run = false;

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
                            break;
                        case 2:
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
    }
}
