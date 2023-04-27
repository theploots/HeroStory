using HeroStory;
using System;
using System.Numerics;
using static HeroStory.FightScene;

namespace StoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCreation();




        }

        public static List<FightScene> GetFightScenes()
        {
            List<FightScene> fightScenes = new List<FightScene>();

            fightScenes.Add(new FightScene(SceneType.Fire, " You perform a fireball of death attack"));
            fightScenes.Add(new FightScene(SceneType.Water, "You perform a Squirtle attack."));
            fightScenes.Add(new FightScene(SceneType.Pulse, "You perform a pulse attack."));
            fightScenes.Add(new FightScene(SceneType.Force, "You perform a Hulk Smash"));
            fightScenes.Add(new FightScene(SceneType.Magic, "You say expeliamous!"));

            return fightScenes;
        }

        // here i make a function that fills the player class
        // with the player's name, skill and origins
        static player PlayerCreation()
        {
            player player = new player();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is your name?");
            Console.ResetColor();
            player.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is your skill?");
            Console.ResetColor();
            player.Skill = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Where are you from?");
            Console.ResetColor();
            player.Origins = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            PlayerInfo(player);

            return player;

        }

        //here i make a function that prints the player's name, skill and origins
        static void PlayerInfo(player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is " + player.Name);
            Console.WriteLine("Your skill is " + player.Skill);
            Console.WriteLine("You are from " + player.Origins);
            Console.WriteLine();
            Console.WriteLine("Welcome to the game " + player.Name + "!");
            Console.ResetColor();
            Quest(player);
        }



        //here i make a function that presents the player with a choice of between two quest options with 2 different outcomes each

        static void Quest(player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You are walking down a path and you come across a fork in the road.");
            Console.WriteLine("Do you go left or right?");
            Console.ResetColor();
            string choice = "";
            List<FightScene> fightScenes = GetFightScenes();
            Random fight = new Random();
            int fightMove = fight.Next(0, 5);
            for (int i = 100; i >= player.Vitality; i--)
            {

                choice = Console.ReadLine();
                if (choice == "left")
                {
                    Random random = new Random();
                    int road = random.Next(1, 3);
                    if (road == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You go left and you come across a dragon.");
                        Console.WriteLine("Do you fight(f) it or run away(r)?");
                        Console.ResetColor();
                        string choice2 = Console.ReadLine();
                        if (choice2 == "f" || choice2 == "F")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the dragon!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.WriteLine("You lose 50 lives!");
                                player.Vitality -= 50;
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You fight the dragon!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.WriteLine("You win and stay safe");
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.ResetColor();

                            }
                        }
                        else if (choice2 == "r" || choice2 == "R")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get away safely!");
                                Console.WriteLine("You get no extra lives for being a coward!");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You sneak past with ease!");
                                Console.WriteLine("You were not seen, A true Ninja!!!");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You didn't choose a valid option!");
                            Console.WriteLine("Your fate was doomed !!!!");
                            Console.WriteLine("Returning to the last checkpoint.");
                            Console.ResetColor();
                        }
                    }
                    else if (road == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You go left and you come across a troll.");
                        Console.WriteLine("Do you fight(f) it or run away?(r)");
                        Console.ResetColor();
                        string choice3 = Console.ReadLine();
                        if (choice3 == "f" || choice3 == "F")
                        {

                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the troll!");
                                Console.WriteLine(fightScenes[fightMove].Description);

                                Console.WriteLine("You loose and receive damage!");

                                player.Vitality -= 25;
                                Console.WriteLine($"Your lives are at {player.Vitality}");

                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the troll!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You defeat it successfully!");
                                Console.WriteLine("Your life is safe!!!");
                                player.Vitality -= 3;
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.WriteLine("You are the new Troll Slayer!");
                                Console.ResetColor();
                            }
                        }
                        else if (choice3 == "r" || choice3 == "R")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get away safely!");
                                Console.WriteLine("With better training your courage will evolve.");
                                Console.WriteLine("Get to work!!!!");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get banished from the kings guard!");
                                Console.WriteLine("A disgrace to your kingdom");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You didn't choose a valid option!");
                            Console.WriteLine("Your fate was doomed !!!!");
                            Console.WriteLine("Returning to the last checkpoint.");
                            Console.ResetColor();

                        }


                    }



                }
                else if (choice == "right")
                {
                    Random randomR = new Random();
                    int roadR = randomR.Next(1, 3);
                    if (roadR == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You go right and you come across a necromancer.");
                        Console.WriteLine("Do you fight(f) it or run away(r)?");
                        Console.ResetColor();
                        string choice4 = Console.ReadLine();
                        if (choice4 == "f" || choice4 == "F")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the necromancer!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.WriteLine("You lose 50 lives!");
                                player.Vitality -= 50;
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You fight the necromancer!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.WriteLine("You win with might!!");
                                player.Vitality -= 3;
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.ResetColor();

                            }
                        }
                        else if (choice4 == "r" || choice4 == "R")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get away safely!");
                                Console.WriteLine("You get no extra for being a coward!");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You sneak past with ease!");
                                Console.WriteLine("You were not seen, A true Ninja!!!");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You didn't choose a valid option!");
                            Console.WriteLine("Your fate was doomed !!!!");
                            Console.WriteLine("Returning to the last checkpoint.");
                            Console.ResetColor();
                        }
                    }
                    else if (roadR == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You go right and you come across a army of walking dead chipmunks.");
                        Console.WriteLine("Do you fight(f) it or run away?(r)");
                        Console.ResetColor();
                        string choice5 = Console.ReadLine();
                        if (choice5 == "f" || choice5 == "F")
                        {

                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the chipmunks!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You loose and receive damage");
                                player.Vitality -= 25;
                                Console.WriteLine($"Your lives are at {player.Vitality}");


                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You fight the chipmunks!");
                                Console.WriteLine(fightScenes[fightMove].Description);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You defeat them successfully!");
                                Console.WriteLine("Your life is safe!!!");
                                player.Vitality -= 3;
                                Console.WriteLine($"Your lives are at {player.Vitality}");
                                Console.WriteLine("You are the new Chipmunk Slayer!");
                                Console.ResetColor();
                            }
                        }
                        else if (choice5 == "r" || choice5 == "R")
                        {
                            Random outcome = new Random();
                            int result = outcome.Next(1, 3);
                            if (result == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get away safely!");
                                Console.WriteLine("With better training your courage will evolve.");
                                Console.WriteLine("Get to work!!!!");
                                Console.ResetColor();
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You run away and you get banished from the kings guard!");
                                Console.WriteLine("A disgrace to your kingdom");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You didn't choose a valid option!");
                            Console.WriteLine("Your fate was doomed !!!!");
                            Console.WriteLine("Returning to the last checkpoint.");
                            Console.ResetColor();
                        }

                    }


                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You didn't choose a valid option!");
                    Console.WriteLine("Your fate was doomed !!!!");
                    Console.WriteLine("Returning to the last checkpoint.");
                    Console.ResetColor();
                }




                if (player.Vitality <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You have died.");
                    Console.WriteLine("Game Over!!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    return;

                }
            }
        }
    }
}